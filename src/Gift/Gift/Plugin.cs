using System.Linq;
using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime.Injection;
using MonoMod.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Gift;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.gift.ultrawide";
    private const string PluginName = "Gift Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }
    internal static ConfigEntry<CanvasScaler.ScreenMatchMode> ScreenMatchMode { get; private set; }
    internal static ConfigEntry<CanvasScaler.ScaleMode> ScaleMode { get; private set; }
    internal static ConfigEntry<float> ScaleFactor { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ManualLogSource Logger { get; set; }
    // internal static RefreshRate RefreshRate => new()
    // {
    //     denominator = 1,
    //     numerator = (uint) MaxRefresh
    // };


    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 105}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 104}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways.", null, new ConfigurationManagerAttributes {Order = 103}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 102}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        ScaleMode = Config.Bind("03. Scaler", "Canvas Scaler Scale Mode", CanvasScaler.ScaleMode.ScaleWithScreenSize, new ConfigDescription("The scaling mode to use for the CanvasScaler component.", null, new ConfigurationManagerAttributes {Order = 101}));
        ScreenMatchMode = Config.Bind("03. Scaler", "Canvas Scaler Screen Match Mode", CanvasScaler.ScreenMatchMode.Expand, new ConfigDescription("The screen match mode to use for the CanvasScaler component. Has no effect unless Scale Mode is set to ScaleWithScreenSize.", null, new ConfigurationManagerAttributes {Order = 100}));
        ScaleFactor = Config.Bind("03. Scaler", "Canvas Scaler Scale Factor", 1f, new ConfigDescription("The scaling factor to use for the CanvasScaler component. Has no effect when Scale Mode is set to ScaleWithScreenSize.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 99}));
        ScaleFactor.SettingChanged += (_, _) =>
        {
            ScaleFactor.Value = Mathf.Round(ScaleFactor.Value * 4) / 4;
        };

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", true, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 97}));

        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static WriteOnceInt OriginalFixedDeltaTime { get; } = new();

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Logger.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
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
        Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void FocusChanged(bool focus)
    {
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

}