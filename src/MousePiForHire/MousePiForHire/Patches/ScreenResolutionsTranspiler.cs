namespace MousePiForHire;

// Transpiler that swaps `Screen.resolutions` calls inside the game's resolution-handling methods
// with our MyResolutions(), which adds the player's native ultrawide entry, dedupes, and sorts
// descending so it shows up at the top of the in-game dropdown.
[Harmony]
public static class ScreenResolutionsTranspiler
{
    private static bool _myResolutionsLogged;

    // Substitute resolution list. Tuple-key GroupBy avoids ValueType.Equals reflection on Resolution.
    public static Resolution[] MyResolutions()
    {
        var newRes = new Resolution
        {
            m_Height = DisplayMetrics.NativeSystemHeight,
            m_Width = DisplayMetrics.NativeSystemWidth,
            m_RefreshRate = DisplayMetrics.MaxRefreshRate
        };
        var availableResolutions = Screen.resolutions.ToList();
        availableResolutions.Add(newRes);
        var result = availableResolutions
            .GroupBy(r => (r.width, r.height, r.refreshRateRatio.numerator, r.refreshRateRatio.denominator))
            .Select(g => g.First())
            .OrderByDescending(r => r.width)
            .ThenByDescending(r => r.height)
            .ThenByDescending(r => r.refreshRateRatio.value)
            .ToArray();
        if (!_myResolutionsLogged)
        {
            _myResolutionsLogged = true;
            var last = result[result.Length - 1];
            Plugin.Log.LogInfo($"[Resolutions] MyResolutions first call: injected native {newRes.width}x{newRes.height}@{newRes.refreshRateRatio.value:F2}Hz; total unique entries={result.Length} (sorted descending). Top: {result[0].width}x{result[0].height}@{result[0].refreshRateRatio.value:F2}Hz, bottom: {last.width}x{last.height}@{last.refreshRateRatio.value:F2}Hz.");
        }
        return result;
    }

    // Every game method that pulls the resolution list - need to redirect them all to see the
    // injected native entry consistently.
    [HarmonyTargetMethods]
    [UsedImplicitly]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(DisplayUtility), nameof(DisplayUtility.GetAvailableResolutions));
        yield return AccessTools.Method(typeof(DisplayUtility), nameof(DisplayUtility.GetHighestRefreshRate));
        yield return AccessTools.Method(typeof(DisplayUtility), nameof(DisplayUtility.IsSupportedResolution));
        yield return AccessTools.Method(typeof(ResolutionSetter), nameof(ResolutionSetter.InitAvailableResolutions));
    }


    [HarmonyTranspiler]
    [UsedImplicitly]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase original)
    {
        var originalInstructions = instructions.ToList();
        var getResolutionsMethod = AccessTools.Property(typeof(Screen), nameof(Screen.resolutions))?.GetGetMethod();
        var myResolutionsMethod = AccessTools.Method(typeof(ScreenResolutionsTranspiler), nameof(MyResolutions));

        var redirects = 0;
        foreach (var instruction in originalInstructions)
        {
            if (instruction.Calls(getResolutionsMethod))
            {
                instruction.operand = myResolutionsMethod;
                redirects++;
            }
            yield return instruction;
        }
        Plugin.Log.LogInfo($"[Resolutions] Transpiled {original.DeclaringType?.Name}.{original.Name}: redirected {redirects} call(s) to Screen.resolutions -> MyResolutions.");
    }
}