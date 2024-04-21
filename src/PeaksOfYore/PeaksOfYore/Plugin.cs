using System;
using System.Collections.Generic;
using SCPE;
using UnityEngine.PlayerLoop;
using UnityEngine.Rendering.PostProcessing;
using Dithering = UnityEngine.Rendering.PostProcessing.Dithering;

namespace PeaksOfYore;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.peaksofyore.ultrawide";
    private const string PluginName = "Peaks of Yore Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    private static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    private static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;
    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
internal static ConfigEntry<bool> Boundaries { get; set; }
    internal static ConfigEntry<bool> Vignette { get; set; }
    internal static ConfigEntry<bool> Dithering { get; set; }
    internal static ConfigEntry<float> SharpenAmount { get; set; }
    internal static ConfigEntry<PostProcessLayer.Antialiasing> AntiAliasing { get; set; }
    internal static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }

    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Log { get; set; }

    private void Awake()
    {
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        AnisotropicFiltering = Config.Bind("02. Quality", "Anisotropic Filtering", true, new ConfigDescription("Enable Anisotropic Filtering."));
        AnisotropicFiltering.SettingChanged += (_, _) =>
        {
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable;
        };
        
        Vignette = Config.Bind("03. Post-Processing", "Vignette", true, new ConfigDescription("Enable Vignette effect on the game screen."));
        
        Dithering = Config.Bind("03. Post-Processing", "Dithering", true, new ConfigDescription("Disabling dithering in the game menu doesn't disable all of the effects. This is a workaround to disable it completely."));

        AntiAliasing = Config.Bind("03. Post-Processing", "Anti-Aliasing", PostProcessLayer.Antialiasing.TemporalAntialiasing, new ConfigDescription("Enable Anti-Aliasing effect on the game screen."));
        SharpenAmount = Config.Bind("03. Post-Processing", "Sharpen Amount", 0.5f, new ConfigDescription("Set the amount of sharpening effect on the game screen.", new AcceptableValueRange<float>(0,5)));

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };
        
       Boundaries = Config.Bind("04. Misc", "Boundaries", true, new ConfigDescription("Toggle the games player fencing.", null, new ConfigurationManagerAttributes {Order = 100}));
       Boundaries.SettingChanged += (_, _) =>
       {
           UpdateColliders();
       };
        
        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void UpdateColliders()
    {
        var colliders = Resources.FindObjectsOfTypeAll<BoxCollider>();
        foreach (var collider in colliders)
        {
            if (!collider) continue;
            if (!collider.transform.parent) continue;
            if (!collider.transform.parent.name.Equals("BoundaryColliders")) continue;
            if (collider.gameObject)
            {
                collider.gameObject.SetActive(Boundaries.Value);
            }
        }
    }
    
    internal static void UpdateMainMenu()
    {
        var menuOptions = GameObject.Find("Canvas/InGameMenu/InGameMenuObj_DisableMe/menu_pg/MainLayoutMenu");
        //find every Text component in set the colour to black
        if (menuOptions)
        {
            foreach (var text in menuOptions.GetComponentsInChildren<Text>())
            {
                var parentButton = text.transform.parent.GetComponent<UnityEngine.UI.Button>();
                if (parentButton != null)
                    parentButton.colors = new ColorBlock
                    {
                        normalColor = Color.black,
                        highlightedColor = Color.grey,
                        pressedColor = Color.black,
                        selectedColor = Color.black,
                        disabledColor = Color.black,
                        colorMultiplier = 1,
                        fadeDuration = 0.1f
                    };
            }
        }

        var climber = GameObject.Find("Canvas/BackgroundImage/climber");
        if (climber)
        {
            climber.SetActive(false);
        }

        var background = GameObject.Find("Canvas/BackgroundImage/Image (1)");
        if (background)
        {
            background.SetActive(false);
        }
    }
    
    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
        UpdateGraphicsQualitySettings();
        UpdateColliders();
        UpdateLoadingBackgrounds();
    }
    
    private static void UpdateLoadingBackgrounds()
    {
        var background = GameObject.Find("LOADINGSCREEN/BlackScreenCanvas/BlackScreen/bg");
        if (background)
        {
            var rect = background.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(MainWidth, MainHeight);
        }
    }

    internal static void UpdateResolutionText()
    {
        var resText = GameObject.Find("Canvas/InGameMenu/InGameMenuObj_DisableMe/Options_pg_DisableMe/holder/GraphicsOption/graphicsholder/ScreenResolutionDropdownCustom/Label");
        if (!resText) return;

        var label = resText.GetComponent<Text>();
        if (!label) return;

        label.fontSize = 50;
        label.horizontalOverflow = HorizontalWrapMode.Overflow;
    }
    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }
    private static void UpdateGraphicsQualitySettings()
    {
        QualitySettings.shadowResolution = ShadowResolution.VeryHigh;
        QualitySettings.antiAliasing = 8;
        QualitySettings.realtimeReflectionProbes = true;
        QualitySettings.softParticles = true;
        QualitySettings.particleRaycastBudget = 4096;
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable;
        QualitySettings.lodBias = 10.0f;
        QualitySettings.maximumLODLevel = 0;
    }
}