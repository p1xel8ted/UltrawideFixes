namespace PlatypusReclayed.Camera;

/// <summary>
/// Harmony patches for camera management and viewport handling.
/// Ensures proper camera aspect ratio and viewport settings for ultrawide displays.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class CameraPatches
{
    /// <summary>
    /// Postfix patch that overrides the camera aspect ratio calculation.
    /// Returns the current display aspect ratio instead of the game's default ratio.
    /// </summary>
    /// <param name="__result">The aspect ratio to use for camera rendering.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.AspectRatioTypeToRatio))]
    public static void CameraManager_AspectRatioTypeToRatio(ref float __result)
    {
        __result = ResolutionManager.CurrentAspect;
    }

    /// <summary>
    /// Postfix patch that ensures camera viewport fills the entire screen.
    /// Prevents letterboxing or pillarboxing on ultrawide displays.
    /// </summary>
    /// <param name="__instance">The CameraManager instance setting the viewport.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.SetCameraViewport))]
    public static void CameraManager_SetCameraViewport(CameraManager __instance)
    {
        // Set viewport to full screen
        __instance.m_camera.rect = new Rect(0f, 0f, 1f, 1f);

        // Update tracked screen dimensions
        __instance.m_currentScreenWidth = ResolutionManager.MainWidth;
        __instance.m_currentScreenHeight = ResolutionManager.MainHeight;
    }

    /// <summary>
    /// Prefix patch that resets screen dimension tracking on camera initialization.
    /// Forces viewport recalculation on first SetCameraViewport call.
    /// </summary>
    /// <param name="__instance">The CameraManager instance being initialized.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Awake))]
    public static void CameraManager_Awake(CameraManager __instance)
    {
        // Reset to zero to force initial viewport update
        __instance.m_currentScreenWidth = 0;
        __instance.m_currentScreenHeight = 0;
    }
}
