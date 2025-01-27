// DisplayManager.cs

namespace SeaOfStars.Managers;

public static class DisplayManager
{
    internal const float NativeAspectRatio = 16f / 9f; // 1.77777777778
    private static int NativeWidth => Mathf.RoundToInt(MainHeight * NativeAspectRatio); // 2560
    internal static float PositiveScaleFactor => MainWidth / (float)NativeWidth; // 1.34375

    private static WriteOnceInt OriginalFixedDeltaTime { get; } = new();
    public static float MainAspectRatio => MainWidth / (float)MainHeight; // 2.38888888889
    public static float BlackBarSize => (MainWidth - NativeWidth) / 2f; //3440 - 2560 = 440
    internal static int MainWidth => SelectedResolution.width;
    internal static int MainHeight => SelectedResolution.height;

    internal static Resolution SelectedResolution
    {
        get
        {
            if (Configuration.Configuration.Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = Configuration.Configuration.Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    internal static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = NativeDisplayWidth,
            height = NativeDisplayHeight,
            refreshRate = RefreshRate
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    private static readonly int NativeDisplayWidth = Display.main.systemWidth;
    private static readonly int NativeDisplayHeight = Display.main.systemHeight;

    internal static int RefreshRate
    {
        get
        {
            if (Configuration.Configuration.UseCustomRefreshRate != null && Configuration.Configuration.CustomRefreshRate != null)
            {
                return Configuration.Configuration.UseCustomRefreshRate.Value ? Configuration.Configuration.CustomRefreshRate.Value : MaxRefresh;
            }

            return MaxRefresh;
        }
    }

    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    public static void FocusChanged(bool focus)
    {
        Application.runInBackground = Configuration.Configuration.RunInBackground.Value;
        var audioSources = Utilities.Utilities.FindIl2CppType<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && Configuration.Configuration.MuteInBackground.Value;
        }
    }

    internal static void UpdateDisplay(bool force = false)
    {
        // Apply VSync setting using the mapped value
        if (Configuration.Configuration.VSyncOptions.TryGetValue(Configuration.Configuration.VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Plugin.Logger.LogWarning($"Invalid VSync setting: {Configuration.Configuration.VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? Configuration.Configuration.TargetFramerate.Value : -1;

        if (force)
        {
            Configuration.Configuration.RequiresUpdate = true;
        }

        if (!Configuration.Configuration.RequiresUpdate) return;

        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, Configuration.Configuration.FullScreenModeConfig.Value, RefreshRate);
        Plugin.Logger.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={Configuration.Configuration.FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        if (ConfigManager.UI.UIManager.ShowMenu)
        {
            SoSuiManager.HandleConfigManager(false);
            SoSuiManager.HandleConfigManager(true);
        }
            
        Configuration.Configuration.RequiresUpdate = false;
    }


    internal static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
        UpdateFixedDeltaTime();
    }

    public static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = Configuration.Configuration.UseCustomRefreshRate.Value ? Configuration.Configuration.CustomRefreshRate.Value : MaxRefresh;

        if (targetRefresh <= 0)
        {
            Plugin.Logger.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
            return;
        }

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
            Plugin.Logger.LogInfo("Game's physics update rate is already equal to or greater than your chosen refresh. Skipping update.");
            return;
        }

        if (Configuration.Configuration.CorrectFixedUpdateRate.Value)
        {
            Time.fixedDeltaTime = 1f / (Configuration.Configuration.UseRefreshRateForFixedUpdateRate.Value ? targetRefresh : Utilities.Utilities.FindLowestFrameRateMultipleAboveFifty(targetRefresh));
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }
    }
}