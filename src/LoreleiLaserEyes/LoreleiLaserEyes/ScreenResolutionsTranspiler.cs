namespace LoreleiLaserEyes;

/// <summary>
/// A Harmony patch to intercepting Unity's Screen.resolutions method and add custom resolutions.
/// </summary>
[HarmonyPatch]
public static class ScreenResolutionsTranspiler
{
    /// <summary>
    /// Provides a list of resolutions, including a custom one based on the main display.
    /// This method is meant to replace <see cref="Screen.resolutions"/>.
    /// </summary>
    /// <returns>A list of resolutions, including the custom one.</returns>
    public static Resolution[] MyResolutions()
    {
        var resolutions = Screen.resolutions;
        var maxRefreshRate = resolutions.Length > 0 ? resolutions.Max(a => a.refreshRate) : 60;

#if DEBUG
        var newRes = new Resolution
        {
            height = 600,
            width = 3200,
            refreshRate = maxRefreshRate
        };
#else
        var newRes = new Resolution
        {
            height = Display.main.systemHeight,
            width = Display.main.systemWidth,
            refreshRate = maxRefreshRate
        };
#endif

        var uniqueResolutions = new Dictionary<(int, int), Resolution>
        {
            [(newRes.width, newRes.height)] = newRes
        };

        foreach (var res in resolutions)
        {
            var key = (res.width, res.height);
            if (!uniqueResolutions.TryGetValue(key, out var existing) || res.refreshRate > existing.refreshRate)
            {
                uniqueResolutions[key] = res;
            }
        }

        if (Plugin.ShowMainResolutionOnly.Value)
        {
            // Main resolution only (3), max refresh rate (3 dupes due to res switcher behaviour)
            return [newRes, newRes, newRes];
        }
        
        return uniqueResolutions.Values
            .OrderByDescending(r => r.width * r.height)
            .Take(5)
            .ToArray();
    }

    /// <summary>
    /// Specifies the methods to which the transpiler should be applied.
    /// </summary>
    /// <returns>A list of methods to be patched by the transpiler.</returns>
    [HarmonyTargetMethods]
    [UsedImplicitly]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(BootScript), nameof(BootScript.EnsureValidResolution));
        yield return AccessTools.Method(typeof(SGDeviceSpecific), nameof(SGDeviceSpecific.Init));
        yield return AccessTools.Method(typeof(UIElement_MenuSystem_AutoFillOptions), nameof(UIElement_MenuSystem_AutoFillOptions.ReInitResolutions));
    }


    /// <summary>
    /// Replaces calls to <see cref="Screen.resolutions"/> with calls to <see cref="MyResolutions"/> in the target methods.
    /// </summary>
    /// <param name="instructions">The original IL instructions of the method.</param>
    /// <returns>The modified IL instructions.</returns>
    [HarmonyTranspiler]
    [UsedImplicitly]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var originalInstructions = instructions.ToList();
        var getResolutionsMethod = AccessTools.Property(typeof(Screen), nameof(Screen.resolutions))?.GetGetMethod();
        var myResolutionsMethod = AccessTools.Method(typeof(ScreenResolutionsTranspiler), nameof(MyResolutions));

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