// #if DEBUG
// namespace HollowKnightSilkSong;
//
// [Harmony]
// public static class ScreenResDebug
// {
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
//     public static void Screen_SetResolution_One(ref int width, ref int height)
//     {
//         ApplyMainResolution(ref width, ref height);
//     }
//
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
//     public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
//     {
//         ApplyMainResolutionAndFullscreen(ref width, ref height, ref fullscreenMode);
//     }
//     
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
//     public static void Screen_SetFullScreenMode(ref FullScreenMode value)
//     {
//         value = FullScreenMode.Windowed;
//     }
//
//     private static void ApplyMainResolution(ref int width, ref int height)
//     {
//         width = Plugin.TestWidth;
//         height =  Plugin.TestHeight;
//     }
//
//     private static void ApplyMainResolutionAndFullscreen(ref int width, ref int height, ref FullScreenMode fullscreenMode)
//     {
//         ApplyMainResolution(ref width, ref height);
//         fullscreenMode = FullScreenMode.Windowed;
//     }
// }
// #endif