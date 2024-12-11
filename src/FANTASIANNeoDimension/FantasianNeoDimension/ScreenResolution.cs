// namespace FantasianNeoDimension;
//
// [Harmony]
// public static class ScreenResolution
// {
//    
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
//     public static void Screen_SetResolution_One(ref int width, ref int height)
//     {
//         width = Plugin.MainWidth;
//         height = Plugin.MainHeight;
//     }
//
//     
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
//     public static void Screen_SetResolution_Two(ref int width, ref int height)
//     {
//         width = Plugin.MainWidth;
//         height = Plugin.MainHeight;
//     }
//
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
//     public static void Screen_SetResolution_Three(ref int width, ref int height)
//     {
//         width = Plugin.MainWidth;
//         height = Plugin.MainHeight;
//     }
//
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
//     public static void Screen_SetResolution_Four(ref int width, ref int height)
//     {
//         width = Plugin.MainWidth;
//         height = Plugin.MainHeight;
//     }
//     
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
//     public static void Screen_SetResolution_Five(ref int width, ref int height)
//     {
//         width = Plugin.MainWidth;
//         height = Plugin.MainHeight;
//     }
//     
//     
// }