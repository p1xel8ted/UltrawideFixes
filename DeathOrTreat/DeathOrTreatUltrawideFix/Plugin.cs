using System;
using System.Collections.Generic;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using Cinemachine;
using HarmonyLib;
using SaonaStudios.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DeathOrTreatUltrawideFix
{
    /// <summary>
    /// A BepInEx plugin for fixing ultra-wide support in Death or Treat.
    /// </summary>
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.deathortreat.ultrawide";
        private const string PluginName = "Death or Treat Ultra-Wide Fix";
        private const string PluginVersion = "0.0.3.1";
        private const float BaseAspectRatio = 16f / 9f;
        private const string BepInExText = "\nAssembly = Assembly-CSharp.dll\nType = CurrencyItem\nMethod = .cctor";

        /// <summary>
        /// Custom scale factor for UI elements.
        /// </summary>
        internal static ConfigEntry<float> CustomScale { get; private set; }

        /// <summary>
        /// Camera zoom level.
        /// </summary>
        private static ConfigEntry<int> CameraZoom { get; set; }
        
        private static float PlayerAspectRatio { get; set; }
        private static float ScaleFactor { get; set; }

        /// <summary>
        /// Collection of all CanvasScalers in the scene.
        /// </summary>
        internal static HashSet<CanvasScaler> CanvasScalers { get; private set; }

        private static readonly WriteOnce<Camera> MainCamera = new();
        private static readonly WriteOnce<CinemachineVirtualCamera> VcCamera = new();
        private static readonly int Fade = Animator.StringToHash("Fade");

        /// <summary>
        /// Method called when the plugin is loaded. Sets up the configuration, harmony patches, and event listeners.
        /// </summary>
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += SceneLoaded;
            Application.runInBackground = true;
            CanvasScalers = new HashSet<CanvasScaler>();
            UpdateAspectValues();

            CameraZoom = Config.Bind("General", "Camera Zoom", 5, new ConfigDescription("Adjusts the zoom level of the camera.", new AcceptableValueRange<int>(1, 101)));
            CameraZoom.SettingChanged += (_, _) => { UpdateCameras(); };

            CustomScale = Config.Bind("General", "Custom Scale", 1 * ScaleFactor, new ConfigDescription("Custom scale factor for UI elements. It's calculated automatically based on a 16:9 aspect ratio and your display's aspect ratio.", new AcceptableValueRange<float>(0.5f, 2f)));
            CustomScale.SettingChanged += (_, _) => { UpdateCanvas(); };

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            Logger.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private void Update()
        {
            UpdateCameras();
        }

        /// <summary>
        /// Event handler for plugin destroyed. Logs an error message with instructions.
        /// </summary>
        private void OnDestroy()
        {
            Logger.LogError($"I've been disabled! Make sure that the entry point details in BepInEx.cfg are as so: {BepInExText}");
        }        /// <summary>
        /// Event handler for plugin disabled. Logs an error message with instructions.
        /// </summary>
        private void OnDisable()
        {
            Logger.LogError($"I've been disabled! Make sure that the entry point details in BepInEx.cfg are as so: {BepInExText}");
        }

        /// <summary>
        /// Updates the aspect ratio values.
        /// </summary>
        private static void UpdateAspectValues()
        {
            PlayerAspectRatio = (float)Display.main.systemWidth / Display.main.systemHeight; //3440 / 1440
            ScaleFactor = PlayerAspectRatio / BaseAspectRatio;
        }

        /// <summary>
        /// Updates the orthographic size of the cameras in the scene.
        /// </summary>
        /// <remarks>
        /// This method is responsible for maintaining the appropriate zoom level of the cameras in the scene.
        /// 
        /// The first part of the method checks whether the <see cref="MainCamera"/> and <see cref="VcCamera"/> instances have been initialized.
        /// If not, it resets their values and calls the nested UpdateCams function, which iterates over all the 
        /// cameras in the scene to set their orthographic size and assign the correct <see cref="MainCamera"/> and <see cref="VcCamera"/> 
        /// instances. This is particularly useful at the start of the scene or when the camera configuration changes.
        ///
        /// If the <see cref="MainCamera"/> and <see cref="VcCamera"/> instances are already set, the method then checks whether the 
        /// orthographic size of the <see cref="MainCamera"/> matches the desired <see cref="CameraZoom"/> value. If it already matches, 
        /// the function returns early as no further adjustments are needed.
        ///
        /// If the orthographic size doesn't match the desired <see cref="CameraZoom"/> value, the method adjusts the orthographic 
        /// size of the <see cref="MainCamera"/> and updates the lens of the <see cref="VcCamera"/> to match the new orthographic size. 
        /// This ensures that the camera zoom level always matches the configured <see cref="CameraZoom"/> value.
        /// </remarks>
        private static void UpdateCameras()
        {
            if (MainCamera.Value == null || VcCamera.Value == null)
            {
                MainCamera.ResetValue();
                VcCamera.ResetValue();
                UpdateCams();
                return;
            }

            if (Mathf.Approximately(MainCamera.Value.orthographicSize, CameraZoom.Value)) return;

            MainCamera.Value.orthographicSize = CameraZoom.Value;

            var lens = VcCamera.Value.m_Lens;
            lens.OrthographicSize = CameraZoom.Value;
            VcCamera.Value.m_Lens = lens;

            void UpdateCams()
            {
                foreach (var camera in Camera.allCameras)
                {
                    if (!camera.orthographic) continue;

                    camera.orthographicSize = CameraZoom.Value;

                    var cbc = camera.GetComponent<CinemachineBrain>();
                    if (cbc == null) continue;

                    var avc = cbc.ActiveVirtualCamera;
                    if (avc == null || avc.VirtualCameraGameObject == null) continue;

                    var vc = avc.VirtualCameraGameObject.GetComponent<CinemachineVirtualCamera>();
                    if (vc == null) continue;

                    var mLens = vc.m_Lens;
                    mLens.OrthographicSize = CameraZoom.Value;
                    vc.m_Lens = mLens;

                    MainCamera.Value = camera;
                    VcCamera.Value = vc;
                }
            }
        }

        private static void UpdateCanvas()
        {
            foreach (var scaler in CanvasScalers)
            {
                if (CustomScale.Value <= 1)
                {
                    scaler.scaleFactor = CustomScale.Value;
                }
                else
                {
                    scaler.scaleFactor = 1 * CustomScale.Value;
                }

                scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            }
        }

        /// <summary>
        /// Event handler for scene loaded. Skips the logo scene and updates the cameras.
        /// </summary>
        private static void SceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            if (arg0.name.Contains("Logo"))
            {
                Resources.UnloadUnusedAssets();
                GC.Collect();
                SceneHandler.instance._anim.SetTrigger(Fade);
                SceneHandler.instance.loadingGO.SetActive(false);
                SceneManager.LoadScene("MainMenu");
            }

            UpdateCameras();
            UpdateCanvas();
        }
    }
}