// using System.Linq;
// using JetBrains.Annotations;
// using OctofoxGames.Core.Utils.Quality;
//
// namespace WildWoods;
//
// /// <summary>
// /// A Harmony patch to intercept Unity's Screen.resolutions method and add custom resolutions.
// /// </summary>
// [HarmonyPatch]
// public static class ScreenResolutionsPatch
// {
//     private static uint RefreshRateNumerator => Screen.resolutions.Max(a => a.refreshRateRatio.numerator);
//     private static uint RefreshRateDenominator => Screen.resolutions.Max(a => a.refreshRateRatio.denominator);
//
//     // Custom equality comparer for Resolution struct
//     private class ResolutionEqualityComparer : IEqualityComparer<Resolution>
//     {
//         public bool Equals(Resolution x, Resolution y)
//         {
//             return x.width == y.width && x.height == y.height && Mathf.Approximately((float)x.refreshRateRatio.value, (float)y.refreshRateRatio.value);
//         }
//
//         public int GetHashCode(Resolution obj)
//         {
//             // Combine hash codes for width, height, and refreshRate to ensure unique keys
//             return obj.width * 397 ^ obj.height * 17 ^ (int)obj.refreshRateRatio.value;
//         }
//     }
//
//     /// <summary>
//     /// Provides a list of resolutions, including a custom one based on the main display.
//     /// This method is meant to replace <see cref="Screen.resolutions"/>.
//     /// </summary>
//     /// <returns>A list of resolutions, including the custom one.</returns>
//     public static Resolution[] MyResolutions()
//     {
//         //16:9
//         var customRes0 = new Resolution
//         {
//             height = 600,
//             width = 1066,
//             refreshRateRatio = new RefreshRate
//             {
//                 numerator = RefreshRateNumerator,
//                 denominator = RefreshRateDenominator
//             }
//         };
//
//         //21.5:9
//         var customRes1 = new Resolution
//         {
//             height = 600,
//             width = 1433,
//             refreshRateRatio = new RefreshRate
//             {
//                 numerator = RefreshRateNumerator,
//                 denominator = RefreshRateDenominator
//             }
//         };
//
//
//         //32:9
//         var customRes2 = new Resolution
//         {
//             height = 600,
//             width = 2133,
//             refreshRateRatio = new RefreshRate
//             {
//                 numerator = RefreshRateNumerator,
//                 denominator = RefreshRateDenominator
//             }
//         };
//
//         //48:9
//         var customRes3 = new Resolution
//         {
//             height = 600,
//             width = 3200,
//             refreshRateRatio = new RefreshRate
//             {
//                 numerator = RefreshRateNumerator,
//                 denominator = RefreshRateDenominator
//             }
//         };
//         
//         //native res
//         var customRes4 = new Resolution
//         {
//             height = Display.main.systemHeight,
//             width = Display.main.systemWidth,
//             refreshRateRatio = new RefreshRate
//             {
//                 numerator = RefreshRateNumerator,
//                 denominator = RefreshRateDenominator
//             }
//         };
//
//
//         var availableResolutions = new List<Resolution>
//         {
//             customRes0,
//             customRes1,
//             customRes2,
//             customRes3,
//             customRes4
//         };
//
//         // Sort resolutions by pixel count, from lowest to highest
//         availableResolutions.Sort((a, b) => (a.width * a.height).CompareTo(b.width * b.height));
//
//         // Use Distinct with the custom equality comparer to remove duplicate resolutions
//         availableResolutions = availableResolutions
//             .Distinct(new ResolutionEqualityComparer())
//             .ToList();
//
//         return availableResolutions.ToArray();
//     }
//
//     /// <summary>
//     /// Specifies the methods to which the transpiler should be applied.
//     /// </summary>
//     /// <returns>A list of methods to be patched by the transpiler.</returns>
//     [HarmonyTargetMethods]
//     [UsedImplicitly]
//     private static IEnumerable<MethodBase> TargetMethods()
//     {
//         yield return AccessTools.Method(typeof(UIResolutionDropdown), nameof(UIResolutionDropdown.InitializeOptions));
//     }
//
//     /// <summary>
//     /// Replaces calls to <see cref="Screen.resolutions"/> with calls to <see cref="MyResolutions"/> in the target methods.
//     /// </summary>
//     /// <param name="instructions">The original IL instructions of the method.</param>
//     /// <returns>The modified IL instructions.</returns>
//     [HarmonyTranspiler]
//     [UsedImplicitly]
//     private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
//     {
//         var originalInstructions = instructions.ToList();
//         var getResolutionsMethod = AccessTools.Property(typeof(Screen), nameof(Screen.resolutions))?.GetGetMethod();
//         var myResolutionsMethod = AccessTools.Method(typeof(ScreenResolutionsPatch), nameof(MyResolutions));
//
//         foreach (var instruction in originalInstructions)
//         {
//             if (instruction.Calls(getResolutionsMethod))
//             {
//                 instruction.operand = myResolutionsMethod;
//             }
//
//             yield return instruction;
//         }
//     }
// }