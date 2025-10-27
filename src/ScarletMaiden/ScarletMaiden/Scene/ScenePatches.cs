namespace ScarletMaiden.Scene;

/// <summary>
/// Harmony patches for scene flow and game logic that isn't UI-specific.
/// Handles scene transitions, splash screens, and other non-UI game mechanics.
/// </summary>
[Harmony]
public static class ScenePatches
{
    /// <summary>
    /// Prefix patch that skips the Otterside splash screen.
    /// Immediately loads the next scene to speed up game startup.
    /// </summary>
    /// <param name="__instance">The OttersideSplash instance being started.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(OttersideSplash), nameof(OttersideSplash.Start))]
    public static void OttersideSplash_Start(OttersideSplash __instance)
    {
        __instance.LoadNextScene();
    }
}