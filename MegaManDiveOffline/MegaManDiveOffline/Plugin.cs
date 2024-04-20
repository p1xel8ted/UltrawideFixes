namespace MegaManDiveOffline;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.megamandiveoffline.ultrawide";
    private const string PluginName = "MEGA MAN X DiVE Offline Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private static ConfigEntry<string> Resolution { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static Resolution SelectedResolution { get; private set; }
    internal static int SelectedRefresh => SelectedResolution.refreshRate;
    internal static int SelectedWidth => SelectedResolution.width;
    internal static int SelectedHeight => SelectedResolution.height;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }

    internal static ConfigEntry<int> FieldOfView { get; private set; }
    internal static ManualLogSource Logger { get; set; }
    internal static ConfigEntry<float> CustomScale { get; private set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    
    private static int MaxRefreshRate => Screen.resolutions.Max(a => a.refreshRate);
    

    public override void Load()
    {
        var maxRes = $"{Display.main.systemWidth}x{Display.main.systemHeight}@{MaxRefreshRate}Hz";
        
        Logger = Log;

        var acceptedResolutions = Screen.resolutions
            .GroupBy(a => $"{a.width}x{a.height}")
            .Select(a => a.MaxBy(b => b.refreshRate))
            .Select(a => $"{a.width}x{a.height}@{a.refreshRate}Hz")
            .ToArray();
        
        Resolution = Config.Bind("02. Display", "Resolution", maxRes, new ConfigDescription("Set the resolution of the game", new AcceptableValueList<string>(acceptedResolutions), new ConfigurationManagerAttributes {Order = 100}));
        Resolution.SettingChanged += (_, _) =>
        {
            ApplySettings();
        };
        
        FullScreenModeConfig = Config.Bind("02. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null,new ConfigurationManagerAttributes {Order = 99}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            ApplySettings();
        };
        CustomScale = Config.Bind("03. UI", "Custom UI Scale", 1.2f, new ConfigDescription("Custom scale for the game's UI.", new AcceptableValueRange<float>(0.5f, 2f), new ConfigurationManagerAttributes {Order = 98}));

        FieldOfView = Config.Bind("04. Camera", "Field of View", 50, new ConfigDescription("Increase or decrease the field of view of the camera. Default is 50% increases", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 97}));
        FieldOfView.SettingChanged += (_, _) =>
        {
            ApplyFieldOfView();
        };
        
        CorrectFixedUpdateRate = Config.Bind("05. Performance", "Correct Physics Update Rate", true,
            new ConfigDescription("Adjusts the physics update rate to minimum amount to reduce camera judder based on your refresh rate. Not all games like this setting being adjusted.", null, new ConfigurationManagerAttributes {Order = 96}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedRate();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("05. Performance", "Use Refresh Rate For Physics Update Rate", true,
            new ConfigDescription("Sets the physics update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 95}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedRate();
            
        };
        
        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 94}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 93}));
        MuteInBackground.SettingChanged += (_, _) =>
        {
            AudioListener.pause = !Application.isFocused && MuteInBackground.Value;
        };
        
        
        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
      
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        ApplySettings();
        UpdateBackgrounds();
    }

    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }

    private static void UpdateFixedRate()
    {
        if (SelectedRefresh <= 60)
        {
            Logger.LogInfo("Refresh rate is 60Hz or lower. Skipping physics update rate adjustment.");
            return;
        }
        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / SelectedRefresh;
            }
            else
            {
                var denominator = FindLowestFrameRateMultipleAboveFifty(SelectedRefresh);
                Time.fixedDeltaTime = 1f / denominator;
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / 60f; //Game default  
        }
    }
    private static void ApplySettings()
    {
        var res = Resolution.Value.Split('@');
        var resSplit = res[0].Split('x');
        var width = int.Parse(resSplit[0]);
        var height = int.Parse(resSplit[1]);
        var refreshRate = int.Parse(res[1].Replace("Hz", ""));

        SelectedResolution = new Resolution
        {
            width = width,
            height = height,
            refreshRate = refreshRate
        };

        Application.runInBackground = RunInBackground.Value;
        Screen.SetResolution(SelectedWidth, SelectedHeight, FullScreenModeConfig.Value, SelectedRefresh);
        Application.targetFrameRate = SelectedRefresh;
        UpdateFixedRate();
        ApplyFieldOfView();
    }

    private static void ApplyFieldOfView()
    {
        var ct = Resources.FindObjectsOfTypeAll(Il2CppType.Of<CameraControl>());
        foreach (var c in ct)
        {
            var cameraControl = c.TryCast<CameraControl>();
            if (cameraControl)
            {
                cameraControl.UpdateCameraFov(cameraControl._defaultFov + cameraControl._defaultFov * (FieldOfView.Value / 100f));
            }
        }
    }

    private static void UpdateBackgrounds()
    {
        var backgroundImages = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Image>());
        foreach (var image in backgroundImages)
        {
            var i = image.TryCast<Image>();
            if (!i) continue;
            var rect = i.GetComponent<RectTransform>();
            if (!rect) continue;
            if (Mathf.Approximately(rect.sizeDelta.x, 3000))
            {
                rect.sizeDelta = new Vector2(SelectedWidth, SelectedHeight);
            }
        }
    }

}