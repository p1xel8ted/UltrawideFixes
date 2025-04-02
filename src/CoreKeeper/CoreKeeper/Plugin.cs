using BepInEx.Unity.Mono;
using CoreKeeper.Helpers;
using CoreKeeper.Misc;
using Pug.RP;
using Screen = UnityEngine.Device.Screen;

namespace CoreKeeper;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    // Plugin Metadata
    private const string PluginGuid = "p1xel8ted.corekeeper.uwfixes";
    private const string PluginName = "Core Keeper Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private static ManualLogSource Log { get; set; }

    private static ConfigurationManager.ConfigurationManager ConfigurationManager =>
        global::ConfigurationManager.ConfigurationManager.Instance;

#if DEBUG
    internal static ConfigEntry<bool> SixteenTenTesting { get; set; }
    internal static ConfigEntry<bool> ThirtyTwoNineTesting { get; set; }
    internal static ConfigEntry<bool> FourtyEightNineTesting { get; set; }
#endif


    internal static ConfigEntry<string> Resolution { get; private set; }


    internal static ConfigEntry<bool> MatchAspectRatio { get; private set; }
    private static bool RequiresUpdate { get; set; }


    /// <summary>
    /// Initializes the plugin, setting up configuration entries, debug options, and event handlers.
    /// </summary>
    private void Awake()
    {
        Log = Logger;

#if DEBUG
        SetupDebugConfigurations();
#endif

        SetupDisplayConfigurations(); //01
        SetupAspectConfigurations(); //02


        RequiresUpdate = true;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;


        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    internal static ConfigEntry<int> CustomViewPortWidth { get; private set; }

    private const int ViewPortHeight = 270;

    private static int GetWidth()
    {
        var num = Mathf.Clamp(Mathf.CeilToInt(Resolutions.MainWidth / (float)Resolutions.MainHeight * ViewPortHeight), 360, 630);
        return num % 2 != 0 ? num + 1 : num;
    }

    private void SetupAspectConfigurations()
    {
        var width = GetWidth();
        MatchAspectRatio = Config.Bind("02. Viewable Area", "Match Aspect Ratio", true,
            new ConfigDescription(
                "If true, viewport will be expanded to fill the screen.", null, new ConfigurationManagerAttributes { Order = 99 }));

        MatchAspectRatio.SettingChanged += UpdateCameras;
        CustomViewPortWidth = Config.Bind("02. Viewable Area", "Viewable Area", width, new ConfigDescription("Set the width of the viewable area. This is only used if 'MatchAspectRatio' is set to false.", new AcceptableValueRange<int>(360, width + 50), new ConfigurationManagerAttributes { Order = 98 }));
        CustomViewPortWidth.SettingChanged += UpdateCameras;
    }

    private static void UpdateCameras(object sender, EventArgs e)
    {
        var cameras = Resources.FindObjectsOfTypeAll<PugCamera>().ToList();
        foreach (var cam in cameras)
        {
            if (MatchAspectRatio.Value)
            {
                cam.SetPreferredOutputMode(OutputMode.MatchAspect);
            }
            else
            {
                cam.SetPreferredOutputMode(OutputMode.Fixed);
                cam.outputWidth = CustomViewPortWidth.Value;
            }
        }
    }

#if DEBUG
    /// <summary>
    /// Sets up debug configurations for aspect ratio testing.
    /// </summary>
    private void SetupDebugConfigurations()
    {
        SixteenTenTesting = Config.Bind("00. Testing", "16:10 Testing", false,
            new ConfigDescription("Enable this option to test 16:10 aspect ratio."));
        SixteenTenTesting.SettingChanged += (_, _) =>
        {
            if (SixteenTenTesting.Value)
            {
                ThirtyTwoNineTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }

            UpdateAll(true);
        };

        ThirtyTwoNineTesting = Config.Bind("00. Testing", "32:9 Testing", false,
            new ConfigDescription("Enable this option to test 32:9 aspect ratio."));
        ThirtyTwoNineTesting.SettingChanged += (_, _) =>
        {
            if (ThirtyTwoNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }

            UpdateAll(true);
        };

        FourtyEightNineTesting = Config.Bind("00. Testing", "48:9 Testing", false,
            new ConfigDescription("Enable this option to test 48:9 aspect ratio."));
        FourtyEightNineTesting.SettingChanged += (_, _) =>
        {
            if (FourtyEightNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                ThirtyTwoNineTesting.Value = false;
            }

            UpdateAll(true);
        };
    }
#endif


    /// <summary>
    /// Sets up configurations related to display settings.
    /// </summary>
    private void SetupDisplayConfigurations()
    {
        Resolution = Config.Bind("01. Display", "Resolution", $"{Resolutions.MainWidth}x{Resolutions.MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(Resolutions.GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => UpdateAll(true);
    }

    /// <summary>
    /// Updates all systems based on configuration changes.
    /// </summary>
    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
        UpdateCameras(null, null);
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        var force = Screen.width != Resolutions.SelectedResolution.width || Screen.height != Resolutions.SelectedResolution.height;
        UpdateDisplay(force);
    }

    private static void UpdateDisplay(bool force = false)
    {
        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;

        Screen.SetResolution(Resolutions.SelectedResolution.width, Resolutions.SelectedResolution.height, Screen.fullScreenMode);
        Log.LogInfo($"Resolution updated: {Resolutions.SelectedResolution.width}x{Resolutions.SelectedResolution.height}, Full Screen Mode={Screen.fullScreenMode}");

        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        RequiresUpdate = false;
    }
}