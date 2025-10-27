namespace PlatypusReclayed.Gameplay;

/// <summary>
/// Harmony patches for background rendering and parallax layers.
/// Adjusts background elements to properly fill ultrawide displays.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class BackgroundPatches
{
    /// <summary>
    /// Postfix patch that scales the background clear color to fill ultrawide displays.
    /// Adjusts the clear color layer's size and position based on the aspect ratio scale factor.
    /// </summary>
    /// <param name="__instance">The BackgroundManager instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BackgroundManager), nameof(BackgroundManager.Initialise))]
    public static void BackgroundManager_Initialise(BackgroundManager __instance)
    {
        var scaleFactor = ResolutionManager.PositiveScaleFactor;

        __instance.clearColor.transform.localScale = new Vector3(
            GameConstants.BackgroundClearColorWidth * scaleFactor,
            GameConstants.NativeScreenHeight,
            1f);

        __instance.clearColor.transform.localPosition = new Vector3(
            GameConstants.NativeScreenCenterX * scaleFactor,
            -240f,
            0f);
    }

    /// <summary>
    /// Postfix patch that updates parallax background layer bounds for ultrawide displays.
    /// Ensures background tiles properly extend to the edges of ultrawide screens.
    /// Applied on both Initialise and Tick to handle dynamic viewport changes.
    /// </summary>
    /// <param name="__instance">The BackgroundTileLayer instance being updated.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BackgroundTileLayer), nameof(BackgroundTileLayer.Initialise))]
    [HarmonyPatch(typeof(BackgroundTileLayer), nameof(BackgroundTileLayer.Tick))]
    public static void BackgroundTileLayer_UpdateBounds(BackgroundTileLayer __instance)
    {
        var camera = GameUtils.GetCamera();
        var num = Globals.layerOffsetY.Get(__instance.layer, 0f);

        var vector = camera.ViewportToWorldPoint(new Vector3(1f, 1f, __instance.transform.position.z - camera.transform.position.z));
        __instance.m_startingPos = new Vector3(
            vector.x * ResolutionManager.PositiveScaleFactor,
            num,
            vector.z);

        var vector2 = camera.ViewportToWorldPoint(new Vector3(0f, 1f, __instance.transform.position.z - camera.transform.position.z));
        __instance.m_endingPos = new Vector3(
            vector2.x * ResolutionManager.PositiveScaleFactor,
            num,
            vector2.z);
    }
}
