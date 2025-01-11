namespace Doorstop;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PersistentSettingsLoader), nameof(PersistentSettingsLoader.UpdateViewToMatchScreenSettings))]
    [HarmonyPatch(typeof(PersistentSettingsLoader), nameof(PersistentSettingsLoader.UpdateVignettesPositions))]
    public static void PersistentSettingsLoader_UpdateViewToMatchScreenSettings(PersistentSettingsLoader __instance)
    {
        __instance.additionalTopVignette.gameObject.SetActive(false);
        __instance.additionalBottomVignette.gameObject.SetActive(false);
        __instance.mainBottomVignette.gameObject.SetActive(false);
        __instance.mainTopVignette.gameObject.SetActive(false);
        
        // Set the gameImageRect to fullscreen
        __instance.gameImageRect.anchorMin = new Vector2(0f, 0f);
        __instance.gameImageRect.anchorMax = new Vector2(1f, 1f);

        // Optionally reset offsets to zero to ensure full stretch
        __instance.gameImageRect.offsetMin = Vector2.zero;
        __instance.gameImageRect.offsetMax = Vector2.zero;
    }
}