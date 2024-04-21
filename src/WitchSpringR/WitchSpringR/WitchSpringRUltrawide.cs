using System.Net.Mime;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using DG.Tweening;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using WitchSpringR;

namespace WitchSpringR
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class WitchSpringRUltrawide : BasePlugin
    {
        
        private const string PluginGuid = "p1xel8ted.witchspringr.ultrawide";
        private const string PluginName = "WitchSpring R Ultra-Wide";
        private const string PluginVersion = "0.1.2";
        
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
        
        internal static int MainWidth => Display.displays[0].systemWidth;
        private static int MainHeight => Display.displays[0].systemHeight;
        private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
        private static float NormalWidth => MainHeight * 16f / 9f;
        internal static float WidthDifference => MainWidth - NormalWidth;
        internal static float HalfUltraWidth => MainWidth / 2f;
        internal static float Difference => HalfUltraWidth - (WidthDifference / 2f);

        internal static List<Panel_ItemInfo_Left> PanelItemInfoLeftInstances { get; set; } = new();
        private static ManualLogSource Logger { get; set; }
        
        public class Behaviours : MonoBehaviour
        {
            private void Update()
            {
                AdjustCameraFOV(MainCameraPath);
                AdjustUIPosition(PanelItemInfoLeftInstances, WidthDifference / 2f);
               AdjustUIPosition(Patches.PanelTrainingResultNewInstance, HalfUltraWidth);
            }
        }
        
        public override void Load()
        {
            Logger = Log;
            AddComponent<Behaviours>();

            Display.displays[0].Activate(MainWidth, MainHeight, MaxRefresh);

      
            SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

            Logger.LogInfo($"Plugin {PluginName} is loaded!");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
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
                    transform.position = new UnityEngine.Vector3(xPosition, transform.position.y, transform.position.z);
                    break;
            }
        }

        private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Application.targetFrameRate = MaxRefresh;
            Screen.SetResolution(MainWidth,MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
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
                        image.transform.localScale = new Vector3(MainWidth, MainHeight, 1f);
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
                cam.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
                cam.aspect = MainWidth / (float) MainHeight;
            }
        }
    }
}