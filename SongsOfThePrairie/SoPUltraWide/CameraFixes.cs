using System.Linq;
using Cinemachine;
using UnityEngine;

namespace SoPUltraWide;

public class CameraFixes : MonoBehaviour
{
    private readonly WriteOnce<Camera> _mainCamera = new();
    private readonly WriteOnce<GameObject> _head = new();
    private readonly WriteOnce<CinemachineVirtualCamera> _vcCamera = new();
    private static float AspectRatio => Display.main.systemWidth / (float) Display.main.systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(r => r.refreshRate);

    private void Update()
    {
        _head.Value = GameObject.Find("Launcher/PanelManager/GameUI/PlayerInfo/PlayerHead/");
        if (_head.Value != null && !Mathf.Approximately(_head.Value.transform.localScale.x, AspectRatio))
        {
            _head.Value.transform.localScale = new Vector3(AspectRatio, 1, 1);
            Plugin.LOG.LogWarning($"Head scale changed: {_head.Value.transform.localScale}");
        }


        if (_mainCamera.Value == null || _vcCamera.Value == null)
        {
            _mainCamera.ResetValue();
            _vcCamera.ResetValue();
            UpdateCams();
            return;
        }

        if (Mathf.Approximately(_vcCamera.Value.m_Lens.Aspect, AspectRatio) && Mathf.Approximately(_mainCamera.Value.aspect, AspectRatio) && Screen.currentResolution.width == Display.main.systemWidth) return;

        if (Screen.currentResolution.width != Display.main.systemWidth)
        {
            Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, MaxRefresh);
            Plugin.LOG.LogWarning($"Screen resolution changed: {Screen.currentResolution.width}x{Screen.currentResolution.height} {Screen.currentResolution.refreshRate}");
        }

        UpdateCameraProperties(_vcCamera.Value, _mainCamera.Value);
    }

    private void UpdateCameraProperties(CinemachineVirtualCamera vc, Camera camera)
    {
        var lens = vc.m_Lens;
        lens.SensorSize = new Vector2(AspectRatio, 1);
        vc.m_Lens = lens;

        camera.aspect = AspectRatio;
        camera.rect = new Rect(0, 0, Display.main.systemWidth, Display.main.systemHeight);
        camera.pixelRect = new Rect(0, 0, Display.main.systemWidth, Display.main.systemHeight);
    }

    private void UpdateCams()
    {
        foreach (var camera in Camera.allCameras)
        {
            var cbc = camera.GetComponent<CinemachineBrain>();
            if (cbc == null) continue;

            var avc = cbc.ActiveVirtualCamera;
            if (avc == null || avc.VirtualCameraGameObject == null) continue;

            var vc = avc.VirtualCameraGameObject.GetComponent<CinemachineVirtualCamera>();
            if (vc == null) continue;

            UpdateCameraProperties(vc, camera);

            Application.targetFrameRate = MaxRefresh;
            _mainCamera.Value = camera;
            _vcCamera.Value = vc;
            Plugin.LOG.LogWarning($"VC Camera updated: {vc.name}, Aspect: {vc.m_Lens.Aspect}, SensorSize: {vc.m_Lens.SensorSize}");
            Plugin.LOG.LogWarning($"Main Camera updated: {camera.name}, Resolution: {camera.pixelRect}, Aspect: {camera.aspect}, SensorSize: {camera.sensorSize}");
        }
    }
}