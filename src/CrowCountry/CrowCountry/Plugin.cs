namespace CrowCountry;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.crowcountry.ultrawide";
    private const string PluginName = "Crow Country Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }

    internal static RefreshRate RefreshRate => new()
    {
        denominator = 1,
        numerator = (uint) MaxRefresh
    };

    internal static ConfigEntry<bool> PSXEffect { get; set; }
    internal static ConfigEntry<bool> CRTEffect { get; set; }

    internal static ConfigEntry<float> CRTEffectBrightness { get; private set; }
    internal static ConfigEntry<float> CRTEffectContrast { get; private set; }
    internal static ConfigEntry<float> CRTEffectSaturation { get; private set; }


    internal static ConfigEntry<bool> FlashbackEffect { get; set; }


    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => (int) Screen.resolutions.Max(a => a.refreshRateRatio.value);

    internal const float NativeAspectRatio = 16f / 9f;
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;

    internal static float NativeWidth => MainHeight * NativeAspectRatio;

    internal static float BlackBarSize => (MainWidth - NativeWidth) / 2f;

    internal static float ScaleFactor => MainAspectRatio / NativeAspectRatio;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> PoisonOverlay { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; set; }

    internal static ConfigEntry<CanvasScaler.ScreenMatchMode> ScreenMatchMode { get; set; }


    public static ConfigEntry<int> PixelationAmount { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ManualLogSource Log { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static string[] SkipScenes { get; } = ["Logos", "Title"];
    // private static Dictionary<string, WriteOnce<float>> SceneCameraFov { get; } = new();
    private void Awake()
    {
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 104}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 103}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        FieldOfView = Config.Bind("02. Camera", "Field of View", 10, new ConfigDescription("Increase or decrease the field of view of the camera by a percentage.", new AcceptableValueRange<int>(-75, 100), new ConfigurationManagerAttributes {Order = 102}));
        FieldOfView.SettingChanged += (_, _) =>
        {
            UpdateCamera(SceneManager.GetActiveScene().name);
        };

        PoisonOverlay = Config.Bind("03. Post-Processing", "Poison Overlay", true, new ConfigDescription("Enables the poison overlay in the game.", null, new ConfigurationManagerAttributes {Order = 101}));
        PoisonOverlay.SettingChanged += (_, _) =>
        {
            UpdatePoison();
        };

        PSXEffect = Config.Bind("03. Post-Processing", "PSX Effect", true, new ConfigDescription("Enables the PSX effect in the game.", null, new ConfigurationManagerAttributes {Order = 100}));

        CRTEffect = Config.Bind("03. Post-Processing", "CRT Effect", false, new ConfigDescription("Enables the CRT effect in the game.", null, new ConfigurationManagerAttributes {Order = 99}));

        CRTEffectBrightness = Config.Bind("03. Post-Processing", "CRT Effect Brightness", -0.5f, new ConfigDescription("Adjust the brightness of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes {Order = 98}));
        CRTEffectBrightness.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CRTEffectBrightness.Value * 20f) / 20f;
            CRTEffectBrightness.Value = snappedValue;
            UpdateCrt();
        };

        CRTEffectContrast = Config.Bind("03. Post-Processing", "CRT Effect Contrast", 0.4f, new ConfigDescription("Adjust the contrast of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes {Order = 97}));
        CRTEffectContrast.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CRTEffectContrast.Value * 20f) / 20f;
            CRTEffectContrast.Value = snappedValue;
            UpdateCrt();
        };

        CRTEffectSaturation = Config.Bind("03. Post-Processing", "CRT Effect Saturation", 0f, new ConfigDescription("Adjust the saturation of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes {Order = 96}));
        CRTEffectSaturation.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CRTEffectSaturation.Value * 20f) / 20f;
            CRTEffectSaturation.Value = snappedValue;
            UpdateCrt();
        };


        FlashbackEffect = Config.Bind("03. Post-Processing", "Flashback Effect", false, new ConfigDescription("Enables the flashback effect in the game.", null, new ConfigurationManagerAttributes {Order = 95}));


        PixelationAmount = Config.Bind("03. Post-Processing", "Pixelation Amount", 4, new ConfigDescription("Lessens the pixelation effect in the game. 0 is off, 4 is game default.", new AcceptableValueRange<int>(0, 4), new ConfigurationManagerAttributes {Order = 93}));
        PixelationAmount.SettingChanged += (_, _) =>
        {
            Patches.Patches.PixelationAdjust(Patches.Patches.CrowCountryCamEffectInstance);
        };

        CorrectFixedUpdateRate = Config.Bind("04. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways.", null, new ConfigurationManagerAttributes {Order = 92}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("04. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 91}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        // ScaleMode = Config.Bind("05. Scalers", "Canvas Scaler Scale Mode", CanvasScaler.ScaleMode.ScaleWithScreenSize, new ConfigDescription("The scaling mode to use for the CanvasScaler component.", null, new ConfigurationManagerAttributes {Order = 93}));
        ScreenMatchMode = Config.Bind("05. Scalers", "Canvas Scaler Screen Match Mode", CanvasScaler.ScreenMatchMode.MatchWidthOrHeight, new ConfigDescription("The screen match mode to use for the CanvasScaler component.", null, new ConfigurationManagerAttributes {Order = 90}));


        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 89}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 88}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateCrt()
    {
        Patches.Patches.CrowCountryCamEffectInstance.UpdateColorMatrices();
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Log.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / MaxRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }
        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    internal static void UpdatePoison()
    {
        if (Patches.Patches.Poison)
        {
            Patches.Patches.Poison.gameObject.SetActive(PoisonOverlay.Value);
        }
    }

    internal static void UpdateCamera(string scene)
    {
        if (!Camera.main) return;
        if (SkipScenes.Contains(scene)) return;

        var pct = FieldOfView.Value / 100f;
        Camera.main.DOFieldOfView(10f + 10f * pct, 1f).SetEase(Ease.InOutQuad);
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        if (a.name.Equals("Logos"))
        {
            SceneManager.LoadScene("Title");
        }

        UpdateDisplay();
        UpdateFixedDeltaTime();
        UpdateCamera(a.name);
        ForceCameraChanges();
        UpdatePoison();
    }

    private static void ForceCameraChanges()
    {
        foreach (var camera in Camera.allCameras)
        {
            camera.rect = new Rect(0, 0, MainWidth, MainHeight);
            camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
            camera.aspect = MainWidth / (float) MainHeight;
            Plugin.Log.LogInfo($"Forcing camera changes for {camera.name}. Camera aspect ratio set to {camera.aspect} and resolution set to {MainWidth}x{MainHeight}.");
        }
    }

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }
        Application.runInBackground = RunInBackground.Value;
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, RefreshRate);
        Application.targetFrameRate = MaxRefresh;
    }
}