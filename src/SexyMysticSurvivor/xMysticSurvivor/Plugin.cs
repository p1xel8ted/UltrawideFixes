using System.Reflection;
using AMG;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace xMysticSurvivor
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.sexymysticsurvivor.xmysticsurvivor";
        private const string PluginName = "xMysticSurvivors Ultra-Wide Fix & Tweaks";
        private const string PluginVersion = "0.0.1";
        internal static ManualLogSource? LOG { get; private set; }
        internal static ConfigEntry<bool>? UltraWide { get; private set; }
        private static ConfigEntry<bool>? ModifyUiScalingBehaviour { get; set; }
        private static ConfigEntry<bool>? ManualScaling { get; set; }
        private static ConfigEntry<float>? ScaleValue { get; set; }
        private static ConfigEntry<bool>? IncreaseCameraZoom { get; set; }
        private static ConfigEntry<int>? MaxZoomOut { get; set; }
        internal static ConfigEntry<float>? CurrentZoomLevel { get; private set; }
        internal static ConfigEntry<bool>? StopTransparentTrees { get; private set; }
        internal static ConfigEntry<bool>? AutoOpenChests { get; private set; }
        internal static CanvasScaler? CanvasOverlay { get; set; }
        internal static CanvasScaler? CanvasCamera { get; set; }
        internal static CameraZoomer? CameraZoomer { get; set; }
        internal static ConfigEntry<bool>? LevelUpVoice { get; private set; }
        internal static ConfigEntry<bool>? CollectCrystalsSound { get; private set; }
        internal static ConfigEntry<float>? LevelUpVoiceVolume { get; private set; }
        internal static ConfigEntry<float>? CollectCrystalsVolume { get; private set; }
        internal static ConfigEntry<float>? SunStoneVolume { get; private set; }
        private static readonly WriteOnce<float> OriginalBackgroundWidth = new();

        private void Awake()
        {
            CurrentZoomLevel = Config.Bind("0. Hidden", "CurrentZoomLevel", 0.0f,
                new ConfigDescription("Current Zoom Level", null,
                    new ConfigurationManagerAttributes {Browsable = false, Order = 13}));

            UltraWide = Config.Bind("1. General", "Ultra-wide", true,
                new ConfigDescription("Enable Ultra-wide mode. Restart the game after toggling this setting to apply changes.", null,
                    new ConfigurationManagerAttributes {Order = 12}));

            Config.Bind("2. Scaling", "Restart", true,
                new ConfigDescription(
                    "Restart",
                    null, new ConfigurationManagerAttributes {ReadOnly = true, HideDefaultButton = true, HideSettingName = true, CustomDrawer = RestartText, Order = 11}));

            ModifyUiScalingBehaviour = Config.Bind("2. Scaling", "Modify UI Scaling Behaviour", true,
                new ConfigDescription(
                    "Modify Automatic Scaling Behavior. This is primarily for ultra-wide users. The result may be better or worse depending on your resolution.",
                    null, new ConfigurationManagerAttributes {Order = 10}));
            ModifyUiScalingBehaviour.SettingChanged += (_, _) => { SetScaling(); };

            ManualScaling = Config.Bind("2. Scaling", "Manual Scaling", false,
                new ConfigDescription("Enable Manual Scaling. This will override Automatic Scaling. Adjust the slider below to your desired scale - there might not be much adjustment available.", null,
                    new ConfigurationManagerAttributes {Order = 9}));
            ManualScaling.SettingChanged += (_, _) =>
            {
                if (ModifyUiScalingBehaviour.Value)
                {
                    ModifyUiScalingBehaviour.Value = false;
                }

                SetScaling();
            };

            ScaleValue = Config.Bind("2. Scaling", "Manual Scale Value", 1.0f,
                new ConfigDescription("Adjust the value to set the desired scale for manual scaling mode.", new AcceptableValueRange<float>(0.05f, 3f),
                    new ConfigurationManagerAttributes {Order = 8}));
            ScaleValue.SettingChanged += (_, _) =>
            {
                ScaleValue.Value = RoundToNearest(ScaleValue.Value, 0.05f);
                SetScaling();
            };


            IncreaseCameraZoom = Config.Bind("4. Camera Zoom", "Increase Camera Zoom", true,
                new ConfigDescription("Enable or disable increased camera zoom. When enabled, you can zoom out further than the default limit.", null,
                    new ConfigurationManagerAttributes {Order = 7}));
            IncreaseCameraZoom.SettingChanged += (_, _) => { SetZoom(); };

            MaxZoomOut = Config.Bind("4. Camera Zoom", "Max Zoom Out", 10,
                new ConfigDescription("Set the maximum zoom-out level. This determines how far out you can zoom. The game's default level is 10. Zooming too far will expose un-rendered areas.", new AcceptableValueRange<int>(2, 20),
                    new ConfigurationManagerAttributes {Order = 6}));
            MaxZoomOut.SettingChanged += (_, _) => { SetZoom(); };


            LevelUpVoice = Config.Bind("5. Sound", "Level Up Voice", true,
                new ConfigDescription("Enable or disable the level up voice sound. Check the box to enable the sound, uncheck to disable it.", null,
                    new ConfigurationManagerAttributes {Order = 5}));
            LevelUpVoiceVolume = Config.Bind("5. Sound", "Level Up Voice Volume", 0f,
                new ConfigDescription("Adjust the level up voice volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                    new ConfigurationManagerAttributes {Order = 4}));

            CollectCrystalsSound = Config.Bind("5. Sound", "Collect Crystals", true,
                new ConfigDescription("Enable or disable the crystal collection sound. Check the box to enable the sound, uncheck to disable it.", null,
                    new ConfigurationManagerAttributes {Order = 3}));
            CollectCrystalsVolume = Config.Bind("5. Sound", "Collect Crystal Volume", 0f,
                new ConfigDescription("Adjust the collect crystal volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                    new ConfigurationManagerAttributes {Order = 2}));

            SunStoneVolume = Config.Bind("5. Sound", "Sun Stone Volume", 0f,
                new ConfigDescription("Adjust the sun stone volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                    new ConfigurationManagerAttributes {Order = 1}));

            StopTransparentTrees = Config.Bind("6. Misc", "Stop Transparent Trees", true,
                new ConfigDescription("Prevent trees from becoming transparent when the camera is close or zooming in.", null,
                    new ConfigurationManagerAttributes {Order = 0}));
            AutoOpenChests = Config.Bind("6. Misc", "Auto Open Chests", true,
                new ConfigDescription("Automatically open chests when the dialog appears.", null,
                    new ConfigurationManagerAttributes {Order = -1}));

            LOG = new ManualLogSource("Log");
            BepInEx.Logging.Logger.Sources.Add(LOG);
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            LOG.LogWarning($"Plugin {PluginName} is loaded!");
            SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        }

        private static void RestartText(ConfigEntryBase obj)
        {
            var centeredStyle = new GUIStyle(GUI.skin.label)
            {
                normal =
                {
                    textColor = Color.white
                },
                alignment = TextAnchor.MiddleCenter,
                wordWrap = true,
                fontSize = 14
            };

            GUILayout.Label("You must restart after changing any scaling settings; otherwise, the special ability UI will not light up when ready. It's still usable, but it just doesn't light up.\n", centeredStyle);
        }


        private static float RoundToNearest(float value, float roundingFactor)
        {
            return Mathf.Round(value / roundingFactor) * roundingFactor;
        }

        private static float GetNewWidth(float baseValue)
        {
            float baseHeight = Screen.height;
            const float aspectRatio = 16f / 9f;
            var baseWidth = aspectRatio * baseHeight;

            float newWidth = Screen.width;
            var widthRatio = newWidth / baseWidth;

            return baseValue * widthRatio;
        }

        internal static void SetZoom()
        {
            if (CameraZoomer == null) return;
            if (IncreaseCameraZoom is {Value: true})
            {
                CameraZoomer.MaxZoomValue = 1f;
                if (MaxZoomOut != null) CameraZoomer.MinZoomValue = MaxZoomOut.Value;
            }
            else
            {
                CameraZoomer.MaxZoomValue = 6f;
                CameraZoomer.MinZoomValue = 10f;
            }
        }

        internal static void SetScaling()
        {
            if (CanvasOverlay == null || CanvasCamera == null) return;

            //disable the survey button
            var disableMe = GameObject.Find("CanvasCamera/WrapperCC/holder");
            if (disableMe != null)
            {
                disableMe.SetActive(false);
            }

            if (UltraWide is {Value: true})
            {
                //adjust main menu background image and associated blur
                var menuBackground = GameObject.Find("CanvasWorld/BackgroundComp/BackgroundImage2");
                var menuBackgroundBlur = GameObject.Find("CanvasWorld/BackgroundComp/BackgroundImage2_BLURMORE");
                if (menuBackground != null && menuBackgroundBlur != null)
                {
                    var menuBackgroundScale = menuBackground.transform.localScale;

                    OriginalBackgroundWidth.Value = menuBackgroundScale.x;

                    var newWidth = GetNewWidth(OriginalBackgroundWidth.Value);

                    var menuBackgroundBlurScale = menuBackgroundBlur.transform.localScale;


                    menuBackgroundScale = new Vector3(newWidth, menuBackgroundScale.y, menuBackgroundScale.z);

                    menuBackground.transform.localScale = menuBackgroundScale;

                    menuBackgroundBlurScale = new Vector3(newWidth, menuBackgroundBlurScale.y, menuBackgroundBlurScale.z);

                    menuBackgroundBlur.transform.localScale = menuBackgroundBlurScale;
                }
            }

            if (ManualScaling is {Value: true})
            {
                CanvasCamera.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
                CanvasOverlay.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;

                if (ScaleValue == null) return;

                CanvasOverlay.scaleFactor = ScaleValue.Value;
                CanvasCamera.scaleFactor = ScaleValue.Value;

                return;
            }

            if (ModifyUiScalingBehaviour is {Value: true})
            {
                CanvasOverlay.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                CanvasOverlay.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;

                CanvasCamera.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                CanvasCamera.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
            }
            else
            {
                CanvasOverlay.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                CanvasOverlay.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

                CanvasCamera.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                CanvasCamera.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            }
        }

        private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            if (UltraWide is {Value: true})
            {
                //disable the left and right black bars
                var leftPane = GameObject.Find("CanvasOverlay/ScreenWrapper/OVERLAY_PLANE_LEFT");
                if (leftPane != null)
                {
                    leftPane.SetActive(false);
                }

                var rightPane = GameObject.Find("CanvasOverlay/ScreenWrapper/OVERLAY_PLANE_RIGHT");
                if (rightPane != null)
                {
                    rightPane.SetActive(false);
                }
            }

            SetScaling();
        }

        private void OnDestroy()
        {
            LOG?.LogError("I've been destroyed!");
        }

        private void OnDisable()
        {
            LOG?.LogError("I've been disabled!");
        }
    }
}