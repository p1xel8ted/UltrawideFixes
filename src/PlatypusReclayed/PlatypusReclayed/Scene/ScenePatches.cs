namespace PlatypusReclayed.Scene;

/// <summary>
/// Harmony patches for scene management and loading screens.
/// Controls splash screen behavior during scene transitions.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class ScenePatches
{
    /// <summary>
    /// Prefix patch that disables the splash screen during loading.
    /// Improves loading screen experience by skipping unnecessary splash animation.
    /// </summary>
    /// <param name="target">The loading screen target being loaded.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadingScreen), nameof(LoadingScreen.InternalLoad))]
    public static void LoadingScreen_InternalLoad(ref LoadingScreen.Target target)
    {
        LoadingScreen.runSplash = false;
    }
}
