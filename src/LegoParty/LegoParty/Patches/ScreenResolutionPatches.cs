namespace LegoParty.Patches;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class ScreenResolution
{
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_BoolWithInt(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Bool(ref int width, ref int height, ref bool fullscreen)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Mode(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_ModeWithInt(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_ModeWithRefreshRate(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }
    
}