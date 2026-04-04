// DisplayManager.cs

namespace SeaOfStars.Managers;

public static class DisplayManager
{
    internal const float NativeAspectRatio = 16f / 9f; // 1.77777777778
    private static int _mainWidth;
    private static int _mainHeight;
    private static int _maxRefresh;
    private static readonly WriteOnceFloat OriginalFixedUpdateRate = new();

    private static int NativeWidth => Mathf.RoundToInt(MainHeight * NativeAspectRatio); // 2560
    internal static float PositiveScaleFactor => MainWidth / (float)NativeWidth; // 1.34375

    public static float MainAspectRatio => MainWidth / (float)MainHeight; // 2.38888888889
    public static float BlackBarSize => (MainWidth - NativeWidth) / 2f; //3440 - 2560 = 440
    internal static int MainWidth => _mainWidth;
    internal static int MainHeight => _mainHeight;
    internal static int MaxRefresh => _maxRefresh;
    internal static bool IsUltrawide => MainAspectRatio > NativeAspectRatio;

    internal static void RefreshDisplayInfo()
    {
        _mainWidth = Display.main.systemWidth;
        _mainHeight = Display.main.systemHeight;

        var maxRefresh = 60;
        var resolutions = Screen.resolutions;
        for (var i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].refreshRate > maxRefresh)
            {
                maxRefresh = resolutions[i].refreshRate;
            }
        }

        _maxRefresh = maxRefresh;
    }

    internal static void CaptureOriginalFixedDeltaTime()
    {
        OriginalFixedUpdateRate.Value = Time.fixedDeltaTime;
    }

    internal static void UpdateFixedDeltaTime()
    {
        var refreshRate = Screen.currentResolution.refreshRate;

        if (Configuration.Configuration.CorrectFixedUpdateRate.Value)
        {
            if (Configuration.Configuration.UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / refreshRate;
                Plugin.Logger.LogInfo($"Set fixed update rate to {refreshRate}Hz (monitor refresh rate).");
            }
            else
            {
                var newRate = Utilities.Utilities.FindLowestFrameRateMultipleAboveFifty(refreshRate);
                Time.fixedDeltaTime = 1f / newRate;
                Plugin.Logger.LogInfo($"Set fixed update rate to {newRate}Hz (lowest divisor of {refreshRate}Hz above 50).");
            }
        }
        else
        {
            Time.fixedDeltaTime = OriginalFixedUpdateRate.Value;
            Plugin.Logger.LogInfo($"Restored original fixed update rate to {Mathf.RoundToInt(1f / OriginalFixedUpdateRate.Value)}Hz.");
        }
    }

    internal static void UpdateDisplay()
    {
        var targetWidth = MainWidth;
        var targetHeight = MainHeight;
        if (Screen.width != targetWidth || Screen.height != targetHeight || Screen.fullScreenMode != FullScreenMode.FullScreenWindow)
        {
            Screen.SetResolution(targetWidth, targetHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
            Plugin.Logger.LogInfo($"Resolution updated: {targetWidth}x{targetHeight}@{MaxRefresh}Hz");
        }

        if (UniverseLibPatches.IsAnyUIShowing())
        {
            SoSuiManager.HandleOverlayUI(false);
            SoSuiManager.HandleOverlayUI(true);
        }
    }
}
