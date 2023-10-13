using Il2Cpp;
using Il2CppDG.Tweening;
using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using WitchSpringR;

[assembly: MelonInfo(typeof(WitchSpringRUltrawide), "WitchSpring R Ultra-Wide", "0.1.1", "p1xel8ted")]

namespace WitchSpringR
{
    public class WitchSpringRUltrawide : MelonMod
    {
        private const string BlackPanelImage = "blackPanel";
        private const string PaperSideImage = "PaperSide";
        private const string MinimapCamera = "MiniMapCamera";
        private const string TitleScene = "#Title";
        private const string HomePieberryScene = "#Home_Pieberry";
        private const string MainCameraPath = "mainCamera/Body/Box/camera";
        private const string LetterboxRightPath = "Canvas(Clone)/Canvas/LetterBox_Right";
        private const string LetterboxLeftPath = "Canvas(Clone)/Canvas/LetterBox_Left";
        private const string VersionPath = "Canvas(Clone)/Canvas/Layer_Mid/UI_Title(Clone)/Under";
        private const string LayerTopPath = "Canvas(Clone)/Canvas/Layer_Top";
        private const string LayerBottomPath = "Canvas(Clone)/Canvas/Layer_Bottom";
        private const string LayerBasePath = "Canvas(Clone)/Canvas/Layer_Base";
        private static float NormalWidth => Display.main.systemHeight * 16f / 9f;
        private static float UltraWidth => Display.main.systemWidth;
        internal static float WidthDifference => UltraWidth - NormalWidth;
        internal static float HalfUltraWidth => UltraWidth / 2f;
        internal static float Difference => HalfUltraWidth - (WidthDifference / 2f);
        private static float Height => Display.main.systemHeight;
        private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

        internal static List<Panel_ItemInfo_Left> PanelItemInfoLeftInstances { get; set; } = new();

        public override void OnUpdate()
        {
            base.OnUpdate();

            AdjustCameraFOV(MainCameraPath);
            AdjustUIPosition(PanelItemInfoLeftInstances, WidthDifference / 2f);
            AdjustUIPosition(Patches.PanelTrainingResultNewInstance, HalfUltraWidth);
        }

        private static void AdjustCameraFOV(string path)
        {
            var cameraObj = GameObject.Find(path);
            if (cameraObj != null && !SceneManager.GetActiveScene().name.Equals(HomePieberryScene))
            {
                var camera = cameraObj.GetComponent<Camera>();
                camera.fieldOfView = SceneManager.GetActiveScene().name.Equals(TitleScene) ? 55 : 35;
            }
        }

        private static void AdjustUIPosition(object instance, float xPosition)
        {
            switch (instance)
            {
                case List<Panel_ItemInfo_Left> list:
                {
                    foreach (var item in list.Where(i => i != null))
                    {
                        item.transform.DOMoveX(xPosition, 0.25f).SetEase(Ease.OutCubic).SetUpdate(true);
                    }

                    break;
                }
                case Panel_ItemInfo_Left panel:
                    var transform = panel.transform;
                    transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
                    break;
            }
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            base.OnSceneWasInitialized(buildIndex, sceneName);

            Application.targetFrameRate = MaxRefresh;
            Screen.SetResolution((int) UltraWidth, (int) Height, FullScreenMode.FullScreenWindow, MaxRefresh);
            Time.fixedDeltaTime = 1f / MaxRefresh;

            DeactivateGameObject(LetterboxRightPath);
            DeactivateGameObject(LetterboxLeftPath);
            DeactivateGameObject(VersionPath);

            AdjustCanvasPosition(LayerTopPath);
            AdjustCanvasPosition(LayerBottomPath);
            AdjustCanvasPosition(LayerBasePath);

            AdjustCameraFOV(MainCameraPath);

            AdjustBlackImages();
            AdjustCameras();
        }

        private static void DeactivateGameObject(string path)
        {
            var obj = GameObject.Find(path);
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }

        private static void AdjustCanvasPosition(string path, bool half = false)
        {
            var canvas = GameObject.Find(path);
            if (canvas != null)
            {
                canvas.transform.position =
                    half
                        ? new Vector3(HalfUltraWidth, canvas.transform.position.y, canvas.transform.position.z)
                        : new Vector3(Difference, canvas.transform.position.y, canvas.transform.position.z);
            }
        }

        private static void AdjustBlackImages()
        {
            var blackImages = Resources.FindObjectsOfTypeAll<Image>();
            foreach (var image in blackImages)
            {
                switch (image.name)
                {
                    case BlackPanelImage:
                        image.transform.localScale = new Vector3(UltraWidth, Height, 1f);
                        break;
                    case PaperSideImage:
                        image.gameObject.SetActive(false);
                        break;
                }
            }
        }

        private static void AdjustCameras()
        {
            var cameras = Resources.FindObjectsOfTypeAll<Camera>();
            foreach (var cam in cameras)
            {
                if (cam.transform.GetFullPath().Contains(MinimapCamera)) continue;
                cam.pixelRect = new Rect(0, 0, UltraWidth, Height);
                cam.aspect = UltraWidth / Height;
            }
        }
    }
}