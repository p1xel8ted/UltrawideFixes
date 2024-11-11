namespace TheMessenger;

[Harmony]
public static class ScreenResolution
{
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    // public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    // {
    //     width = 3200;
    //     height = 900;
    //     fullscreen = false;
    //     preferredRefreshRate = Plugin.MaxRefresh;
    // }
    //
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    // public static void Screen_SetResolution_Two(ref int width, ref int height,ref bool fullscreen)
    // {
    //     width = 3200;
    //     height = 900;
    //     fullscreen = false;
    // }


}