namespace CatQuest1
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

            // Create the custom resolution
            var newRes = new Resolution
            {
                height = Plugin.MainHeight,
                width = Plugin.MainWidth,
                refreshRate = Plugin.MaxRefreshRate
            };

            // Get the available resolutions and add the custom one
            var availableResolutions = new List<Resolution>(Screen.resolutions.Length + 1);
            availableResolutions.AddRange(Screen.resolutions);
            availableResolutions.Add(newRes);

            // Remove duplicates (distinct by width, height, and refresh rate)
            var distinctResolutions = new List<Resolution>();
            foreach (var res in availableResolutions)
            {
                var isDuplicate = false;
                foreach (var distinctRes in distinctResolutions)
                {
                    if (distinctRes.width == res.width && distinctRes.height == res.height && distinctRes.refreshRate == res.refreshRate)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    distinctResolutions.Add(res);
                }
            }

            // Sort the resolutions by pixel count (width * height), lowest to highest
            for (var i = 0; i < distinctResolutions.Count - 1; i++)
            {
                for (var j = i + 1; j < distinctResolutions.Count; j++)
                {
                    if (distinctResolutions[i].width * distinctResolutions[i].height > distinctResolutions[j].width * distinctResolutions[j].height)
                    {
                        // Swap the resolutions
                        // ReSharper disable once SwapViaDeconstruction
                        var temp = distinctResolutions[i];
                        distinctResolutions[i] = distinctResolutions[j];
                        distinctResolutions[j] = temp;
                    }
                }
            }

            // Convert the list to an array and return
            return distinctResolutions.ToArray();
        }

        /// <summary>
        /// Specifies the methods to which the transpiler should be applied.
        /// </summary>
        /// <returns>A list of methods to be patched by the transpiler.</returns>
        [HarmonyTargetMethods]
        private static IEnumerable<MethodBase> TargetMethods()
        {
            yield return AccessTools.Method(typeof(Game), nameof(Game.LogSystemInfo));
            yield return AccessTools.Method(typeof(SettingsPanel), nameof(SettingsPanel.Awake));
            yield return AccessTools.Method(typeof(SystemPanel), nameof(SystemPanel.Awake));
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