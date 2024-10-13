// DisplayManager.cs

using SeaOfStars.Components;
using SeaOfStars.Core;
using SeaOfStars.Utilities;

namespace SeaOfStars.Managers;

public static class DisplayManager
{
    internal static int MainWidth => Display.displays[Configuration.Configuration.DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[Configuration.Configuration.DisplayToUse.Value].systemHeight;
    internal static int NormalWidth => Mathf.RoundToInt(MainHeight * 16f / 9f);
    internal static float PositiveScaleFactor => MainWidth / (float)NormalWidth;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static WriteOnceInt OriginalFixedDeltaTime { get; } = new();

    public static void FocusChanged(bool focus)
    {
        Application.runInBackground = Configuration.Configuration.RunInBackground.Value;
        var audioSources = Utilities.Utilities.FindIl2CppType<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && Configuration.Configuration.MuteInBackground.Value;
        }
    }

    public static void UpdateDisplay()
    {
        if (PlatformHelper.Is(Platform.Windows))
        {
            if (WindowPositioner.Instance == null)
            {
                Plugin.Logger.LogWarning("WindowPositioner instance is not initialized.");
            }
            else
            {
                WindowPositioner.Instance.Start(); // Explicitly call Start() if needed
            }
        }
        Application.runInBackground = Configuration.Configuration.RunInBackground.Value;
        SetResolution();
        Application.targetFrameRate = Configuration.Configuration.TargetFramerate.Value;
    }

    internal static void SetResolution(bool sixteenNine = false)
    {
        Display.displays[Configuration.Configuration.DisplayToUse.Value].Activate();
        Screen.SetResolution(
            sixteenNine ? NormalWidth : MainWidth,
            MainHeight,
            Configuration.Configuration.FullScreenModeConfig.Value,
            Configuration.Configuration.UseCustomRefreshRate.Value ? Configuration.Configuration.CustomRefreshRate.Value : MaxRefresh
        );
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

        Plugin.Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }
}