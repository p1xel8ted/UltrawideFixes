namespace TailsOfIron
{
    /// <summary>
    /// A Harmony patch to intercept Unity's Screen.resolutions method and add custom resolutions.
    /// </summary>
    [HarmonyPatch]
    public static class ScreenResolutionsPatch
    {
        // Custom equality comparer for Resolution struct
        private class ResolutionEqualityComparer : IEqualityComparer<Resolution>
        {
            public bool Equals(Resolution x, Resolution y)
            {
                return x.width == y.width && x.height == y.height && x.refreshRate == y.refreshRate;
            }

            public int GetHashCode(Resolution obj)
            {
                // Combine hash codes for width, height, and refreshRate to ensure unique keys
                return obj.width * 397 ^ obj.height * 17 ^ obj.refreshRate;
            }
        }

        /// <summary>
        /// Provides a list of resolutions, including a custom one based on the main display.
        /// This method is meant to replace <see cref="Screen.resolutions"/>.
        /// </summary>
        /// <returns>A list of resolutions, including the custom one.</returns>
        public static Resolution[] MyResolutions()
        {
            var newRes = new Resolution
            {
                height = Plugin.MainHeight,
                width = Plugin.MainWidth,
                refreshRate = Plugin.MaxRefresh
            };
            //
            // var customRes = new Resolution
            // {
            //     height = 900,
            //     width = 3200,
            //     refreshRate = Plugin.MaxRefresh
            // };

            var availableResolutions = Screen.resolutions.ToList();
            availableResolutions.Add(newRes);
            // availableResolutions.Add(customRes);

            // Sort resolutions by pixel count, from lowest to highest
            availableResolutions.Sort((a, b) => (a.width * a.height).CompareTo(b.width * b.height));

            // Use Distinct with the custom equality comparer to remove duplicate resolutions
            availableResolutions = availableResolutions
                .Distinct(new ResolutionEqualityComparer())
                .ToList();

            return availableResolutions.ToArray();
        }

        /// <summary>
        /// Specifies the methods to which the transpiler should be applied.
        /// </summary>
        /// <returns>A list of methods to be patched by the transpiler.</returns>
        [HarmonyTargetMethods]
        private static IEnumerable<MethodBase> TargetMethods()
        {
            yield return AccessTools.Method(typeof(BootFlowController), nameof(BootFlowController.SetScreenOptions));
            yield return AccessTools.Method(typeof(SettingsVideoSubMenu), nameof(SettingsVideoSubMenu.SetResolutionOptions));
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
                if (instruction.Calls(getResolutionsMethod))
                {
                    instruction.operand = myResolutionsMethod;
                }

                yield return instruction;
            }
        }
    }
}