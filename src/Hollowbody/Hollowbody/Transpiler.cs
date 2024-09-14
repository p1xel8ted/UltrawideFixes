namespace Hollowbody;

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
        return Plugin.SupportedResolutions;
    }

    /// <summary>
    /// Specifies the methods to which the transpiler should be applied.
    /// </summary>
    /// <returns>A list of methods to be patched by the transpiler.</returns>
    [HarmonyTargetMethods]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(AC.ActionApplyResolution), nameof(AC.ActionApplyResolution.Run));
        yield return AccessTools.Method(typeof(AC.GraphicOptions), nameof(AC.GraphicOptions.Awake));
        yield return AccessTools.Method(typeof(HutongGames.PlayMaker.Actions.ArrayListGetScreenResolutions), nameof(HutongGames.PlayMaker.Actions.ArrayListGetScreenResolutions.getResolutions));
        yield return AccessTools.Method(typeof(SetupOptionsResolutions), nameof(SetupOptionsResolutions.GenerateResolutionCycleOptions));
        yield return AccessTools.Method(typeof(SetupOptionsResolutions), nameof(SetupOptionsResolutions.InitResolutionVariable));
        yield return AccessTools.Method(typeof(UIManagerTech), nameof(UIManagerTech.Start));
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