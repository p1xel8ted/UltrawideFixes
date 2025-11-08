// namespace xRESIST;
//
// /// <summary>
// /// Harmony patches that intercept and override screen resolution calls to apply configured resolution and display mode.
// /// Consolidates multiple Screen.SetResolution overloads into a single patch using __args parameter array.
// /// </summary>
// [Harmony]
// public static class ScreenResolutionPatches
// {
//     /// <summary>
//     /// Gets the user-configured resolution from Mod.SelectedResolution.
//     /// </summary>
//     private static Resolution ChosenResolution => Mod.SelectedResolution;
//
//     /// <summary>
//     /// Determines if the game should run in fullscreen mode based on user configuration.
//     /// Returns true for ExclusiveFullScreen and FullScreenWindow modes, false for windowed.
//     /// </summary>
//     private static bool IsFullScreen => Mod.FullScreenModeConfig.Value != FullScreenMode.Windowed;
//
//     /// <summary>
//     /// Prefix patch that overrides all Screen.SetResolution calls to use the configured resolution and display settings.
//     /// Uses __args to handle all 5 SetResolution overloads with a single patch method.
//     /// </summary>
//     /// <param name="__args">The argument array for the original method call, modified to use configured values.</param>
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
//     public static void Screen_SetResolution_Prefix(object[] __args)
//     {
//         // Validate array bounds
//         if (__args == null || __args.Length < 2)
//         {
//             MelonLogger.Error("Screen.SetResolution called with invalid arguments array");
//             return;
//         }
//
//         // Override width and height for all overloads
//         __args[0] = ChosenResolution.width;
//         __args[1] = ChosenResolution.height;
//
//         // Handle different parameter patterns based on argument count and types
//         switch (__args.Length)
//         {
//             case 3 when __args[2] is bool:
//                 // (int, int, bool)
//                 __args[2] = IsFullScreen;
//                 break;
//             case 3 when __args[2] is FullScreenMode:
//                 // (int, int, FullScreenMode)
//                 __args[2] = Mod.FullScreenModeConfig.Value;
//                 break;
//             case 4 when __args[2] is bool:
//                 // (int, int, bool, int)
//                 __args[2] = IsFullScreen;
//                 __args[3] = Mod.RefreshRate;
//                 break;
//             case 4 when __args[2] is FullScreenMode && __args[3] is int:
//                 // (int, int, FullScreenMode, int)
//                 __args[2] = Mod.FullScreenModeConfig.Value;
//                 __args[3] = Mod.RefreshRate;
//                 break;
//             case 4 when __args[2] is FullScreenMode && __args[3] is RefreshRate:
//                 // (int, int, FullScreenMode, RefreshRate)
//                 __args[2] = Mod.FullScreenModeConfig.Value;
//                 __args[3] = new RefreshRate { numerator = (uint)Math.Max(1, Mod.RefreshRate), denominator = 1 };
//                 break;
//             default:
//                 MelonLogger.Warning($"Unexpected Screen.SetResolution overload: {__args.Length} arguments. Width and height were set, but other parameters may be incorrect.");
//                 break;
//         }
//     }
//
//     /// <summary>
//     /// Prefix patch that overrides Screen.fullScreen setter to use the configured fullscreen mode.
//     /// </summary>
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreen), MethodType.Setter)]
//     public static void Screen_fullScreen_Setter(ref bool value)
//     {
//         value = IsFullScreen;
//     }
//
//     /// <summary>
//     /// Prefix patch that overrides Screen.fullScreenMode setter to use the configured fullscreen mode.
//     /// </summary>
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
//     public static void Screen_fullScreenMode_Setter(ref FullScreenMode value)
//     {
//         value = Mod.FullScreenModeConfig.Value;
//     }
// }