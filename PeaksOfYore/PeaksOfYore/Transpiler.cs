using System.Collections.Generic;

namespace PeaksOfYore
{
    /// <summary>
    /// A Harmony patch to intercept Unity's Screen.resolutions method and add custom resolutions.
    /// </summary>
    [HarmonyPatch]
    public static class ScreenResolutionsPatch
    {
        /// <summary>
        /// Provides a list of resolutions, including a custom one based on the main display.
        /// This method is meant to replace <see cref="Screen.resolutions"/>.
        /// </summary>
        /// <returns>A list of resolutions, including the custom one.</returns>
        public static Resolution[] MyResolutions()
        {
            Plugin.Log.LogInfo("Unity Screen.resolutions intercepted!");
            var newRes = new Resolution
            {
                height = Plugin.MainHeight,
                width = Plugin.MainWidth,
                refreshRate = Plugin.MaxRefresh
            };
            var availableResolutions = Screen.resolutions.ToList();
            availableResolutions.Add(newRes);
            return availableResolutions.ToArray();
        }

        /// <summary>
        /// Specifies the methods to which the transpiler should be applied.
        /// </summary>
        /// <returns>A list of methods to be patched by the transpiler.</returns>
        [HarmonyTargetMethods]
        private static IEnumerable<MethodBase> TargetMethods()
        {
            yield return AccessTools.Method(typeof(DisplayOptions), nameof(DisplayOptions.InitialiseDisplayOptions));
            yield return AccessTools.Method(typeof(DisplayOptions), nameof(DisplayOptions.SetScreenResCustom));
        }

        /// <summary>
        /// Replaces calls to <see cref="Screen.resolutions"/> with calls to <see cref="MyResolutions"/> in the target methods.
        /// </summary>
        /// <param name="instructions">The original IL instructions of the method.</param>
        /// <returns>The modified IL instructions.</returns>
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var originalInstructions = instructions.ToList();
            var getResolutionsMethod = AccessTools.Property(typeof(Screen), nameof(Screen.resolutions))?.GetGetMethod();
            var myResolutionsMethod = AccessTools.Method(typeof(ScreenResolutionsPatch), nameof(MyResolutions));

            foreach (var instruction in originalInstructions)
            {
                if(instruction.Calls(getResolutionsMethod))
                {
                    instruction.operand = myResolutionsMethod;
                }
                yield return instruction;
            }
        }
    }
}