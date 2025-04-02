namespace AI_Limit;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.ailimit.ultrawide";
    private const string PluginName = "AI Limit Ultra-Wide";
    private const string PluginVersion = "0.1.4";

    internal static ManualLogSource Logger { get; set; }
    // private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();

    private static bool RequiresUpdate { get; set; }


    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = Configuration.RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && Configuration.MuteInBackground.Value;
        }
    }

    private static void SetupCustomTypes()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceGateFit>();
        ClassInjector.RegisterTypeInIl2Cpp<CameraGateFitEnforcer>();
    }

    public override void Load()
    {
        // Configuration.ConfigFile = Config;
        Logger = Log;

        SetupCustomTypes();

#if DEBUG
        SetupDebugConfigurations(); //00
#endif
        SetupDisplayConfigurations(); //01
        SetupCameraConfigurations(); //02
        // SetupPerformanceConfigurations(); //03
        SetupMiscConfigurations(); //04

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private void SetupMiscConfigurations()
    {
        Configuration.RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        Configuration.RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = Configuration.RunInBackground.Value; };

        Configuration.MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));
    }

    // private void SetupPerformanceConfigurations()
    // {
    //   Configuration.CorrectFixedUpdateRate = Config.Bind("03. Performance", "Modify Physics Rate", false,
    //         new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This is a generic Unity fix and may not do anything for this title.", null, new ConfigurationManagerAttributes { Order = 94 }));
    //     Configuration.CorrectFixedUpdateRate.SettingChanged += (_, _) => UpdateFixedDeltaTime();
    //
    //     Configuration.UseRefreshRateForFixedUpdateRate = Config.Bind("03. Performance", "Use Refresh Rate For Physics Rate", false,
    //         new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment.", null, new ConfigurationManagerAttributes { Order = 93 }));
    //     Configuration.UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => UpdateFixedDeltaTime();
    // }


    private void SetupCameraConfigurations()
    {
        Configuration.CameraFieldOfView = Config.Bind("02. Camera", "Field of View", 25f, new ConfigDescription("Adjust the camera's field of view by a percentage.", new AcceptableValueRange<float>(-99f, 200f), new ConfigurationManagerAttributes { Order = 90 }));
        Configuration.CameraFieldOfView.SettingChanged += (_, _) =>
        {
            Configuration.CameraFieldOfView.Value = Mathf.Round(Configuration.CameraFieldOfView.Value * 4f) / 4f;
            Patches.Patches.UpdateCamera();
        };
    }


    private void SetupDisplayConfigurations()
    {
        Configuration.Resolution = Config.Bind("01. Display", "Resolution", $"{Resolutions.MainWidth}x{Resolutions.MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(Resolutions.GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Configuration.Resolution.SettingChanged += (_, _) => UpdateResolution(true);
    }


#if DEBUG
    private void SetupDebugConfigurations()
    {
        Configuration.SixteenTenTesting = Config.Bind("00. Testing", "16:10 Testing", false,
            new ConfigDescription("Enable this option to test 16:10 aspect ratio."));
        Configuration.SixteenTenTesting.SettingChanged += (_, _) =>
        {
            if (Configuration.SixteenTenTesting.Value)
            {
                Configuration.ThirtyTwoNineTesting.Value = false;
                Configuration.FourtyEightNineTesting.Value = false;
            }

            UpdateResolution(true);
        };

        Configuration.ThirtyTwoNineTesting = Config.Bind("00. Testing", "32:9 Testing", false,
            new ConfigDescription("Enable this option to test 32:9 aspect ratio."));
        Configuration.ThirtyTwoNineTesting.SettingChanged += (_, _) =>
        {
            if (Configuration.ThirtyTwoNineTesting.Value)
            {
                Configuration.SixteenTenTesting.Value = false;
                Configuration.FourtyEightNineTesting.Value = false;
            }

            UpdateResolution(true);
        };

        Configuration.FourtyEightNineTesting = Config.Bind("00. Testing", "48:9 Testing", false,
            new ConfigDescription("Enable this option to test 48:9 aspect ratio."));
        Configuration.FourtyEightNineTesting.SettingChanged += (_, _) =>
        {
            if (Configuration.FourtyEightNineTesting.Value)
            {
                Configuration.SixteenTenTesting.Value = false;
                Configuration.ThirtyTwoNineTesting.Value = false;
            }

            UpdateResolution(true);
        };
    }
#endif

    // private static void UpdateFixedDeltaTime()
    // {
    //     OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
    //     var targetRefresh = Screen.currentResolution.refreshRate;
    //     if (targetRefresh <= 0)
    //     {
    //         Logger.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
    //         return;
    //     }
    //
    //     if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
    //     {
    //         Logger.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
    //         return;
    //     }
    //
    //     if (Configuration.CorrectFixedUpdateRate.Value)
    //     {
    //         if (Configuration.UseRefreshRateForFixedUpdateRate.Value)
    //         {
    //             Time.fixedDeltaTime = 1f / targetRefresh;
    //         }
    //         else
    //         {
    //             Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
    //         }
    //     }
    //     else
    //     {
    //         Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
    //     }
    //
    //     Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    // }

    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            if (!camera) continue;
            camera.gameObject.TryAddComponent<CameraGateFitEnforcer>();
        }
    }

    private static void UpdateResolution(bool force = false)
    {
        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;


       Screen.SetResolution(Resolutions.SelectedResolution.width, Resolutions.SelectedResolution.height, Screen.fullScreenMode);
        Logger.LogInfo($"Resolution updated: {Resolutions.SelectedResolution.width}x{Resolutions.SelectedResolution.height}, Full Screen Mode={Screen.fullScreenMode}, Refresh Rate={Screen.currentResolution.refreshRate}Hz");

        Patches.Patches.UpdateScalers();
        Patches.Patches.UpdateTransforms();
        
        RequiresUpdate = false;
    }
    
    private static void UpdateAll(bool force = false)
    {
        UpdateResolution(force);
        UpdateCameras();
       // UpdateFixedDeltaTime();
        Patches.Patches.UpdateCamera();
        Patches.Patches.UpdateScalers();
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }
}