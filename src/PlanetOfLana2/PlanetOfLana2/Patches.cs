namespace PlanetOfLana2;

/// <summary>
/// Harmony patches for ultrawide display support, aspect ratio correction, and cinematic bar removal.
/// </summary>
[Harmony]
public static class Patches
{
    private static bool _loggedCameraARCap;
    
    /// <summary>
    /// Removes the aspect ratio cap that restricts the camera viewport on ultra-wide displays.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraARCap), nameof(CameraARCap.OnPreRender))]
    public static void CameraARCap_OnPreRender(CameraARCap __instance)
    {
        __instance.aspectRatioCap = new Vector2(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight);
        if (__instance.camera)
        {
            __instance.camera.rect = new Rect(0f, 0f, 1f, 1f);
        }
        if (!_loggedCameraARCap)
        {
            _loggedCameraARCap = true;
            Plugin.Logger.LogInfo($"CameraARCap ({__instance.name}): Set aspect ratio cap to {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}");
        }
    }

    /// <summary>
    /// Disables the pillarbox overlay camera and updates the target aspect to match the display.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraPillarBox), nameof(CameraPillarBox.OnEnable))]
    public static void CameraPillarBox_OnEnable(CameraPillarBox __instance)
    {
        __instance.targetAspect = DisplayMetrics.MainAspect;
        __instance.SetPillarBoxEnabled(false);
        Plugin.Logger.LogInfo($"CameraPillarBox ({__instance.name}): Disabled pillarbox");
    }

    /// <summary>
    /// Updates the UltraWideCamera aspect ratio fields to match the actual display.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UltraWideCamera), nameof(UltraWideCamera.Start))]
    public static void UltraWideCamera_Start(UltraWideCamera __instance)
    {
        __instance.aspectRatioWidth = DisplayMetrics.MainWidth;
        __instance.aspectRatioHeight = DisplayMetrics.MainHeight;
        __instance.OnChanged();
        Plugin.Logger.LogInfo($"UltraWideCamera ({__instance.name}): Set to {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}");
    }

    /// <summary>
    /// Removes cinematic letterbox bars by setting their height to zero.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinematicView), nameof(CinematicView.Setup))]
    public static void CinematicView_Setup(CinematicView __instance)
    {
        __instance.normalizedHeight = 0f;
        Plugin.Logger.LogInfo($"CinematicView ({__instance.name}): Removed letterbox bars");
    }

    /// <summary>
    /// Prevents CinematicBarsRef from showing letterbox bars.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinematicBarsRef), nameof(CinematicBarsRef.Visible))]
    public static void CinematicBarsRef_Visible(CinematicBarsRef __instance)
    {
        if (__instance.canvasGroup)
        {
            __instance.canvasGroup.alpha = 0f;
        }
        Plugin.Logger.LogInfo($"CinematicBarsRef ({__instance.name}): Hidden cinematic bars");
    }
}
