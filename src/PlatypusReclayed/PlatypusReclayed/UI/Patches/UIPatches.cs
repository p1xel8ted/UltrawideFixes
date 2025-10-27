namespace PlatypusReclayed.UI.Patches;

/// <summary>
/// Harmony patches for UI components including HUD and menus.
/// Applies aspect ratio fitters to ensure proper UI scaling on ultrawide displays.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class UIPatches
{
    /// <summary>
    /// Postfix patch that applies custom aspect ratio fitter to the Level UI.
    /// Finds the AspectRatio container and replaces the default AspectRatioSetter with a custom layout-based fitter.
    /// This ensures the HUD scales properly based on user's configured aspect ratio preference.
    /// </summary>
    /// <param name="__instance">The LevelUIManager instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LevelUIManager), nameof(LevelUIManager.Start))]
    public static void LevelUIManager_Start(LevelUIManager __instance)
    {
        var ar = __instance.transform.Find("AspectRatio");
        if (!ar) return;

        // Add custom aspect fitter that uses LayoutElement for width control
        var fitter = AspectRatioFitterFactory.AddCustomAspectFitter(ar.gameObject);
        AspectRatioFitterFactory.LayoutElementAspectFitters.Add(fitter);
        fitter.UpdateWidth();

        // Disable the game's default aspect ratio setter
        var ars = ar.GetComponent<AspectRatioSetter>();
        if (ars)
        {
            ars.enabled = false;
        }

        // Disable the game's default aspect ratio fitter
        var arf = ar.GetComponent<AspectRatioFitter>();
        if (arf)
        {
            arf.enabled = false;
        }
    }
}
