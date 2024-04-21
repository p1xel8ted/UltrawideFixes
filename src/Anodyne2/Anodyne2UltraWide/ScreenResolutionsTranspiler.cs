using JetBrains.Annotations;

namespace Anodyne2UltraWide;

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
        //Plugin.Log.LogInfo("Unity Screen.resolutions intercepted!");
        var newRes = new Resolution
        {
            height = Display.main.systemHeight,
            width = Display.main.systemWidth,
            refreshRate = Screen.resolutions.Max(a => a.refreshRate)
        };
        var availableResolutions = Screen.resolutions.ToList();
        availableResolutions.Add(newRes);
        return availableResolutions.Distinct().ToArray();
    }

    /// <summary>
    /// Specifies the methods to which the transpiler should be applied.
    /// </summary>
    /// <returns>A list of methods to be patched by the transpiler.</returns>
    [HarmonyTargetMethods]
    [UsedImplicitly]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(PauseMenu), nameof(PauseMenu.RefreshPauseVisuals));
        yield return AccessTools.Method(typeof(PauseMenu), nameof(PauseMenu.Start));
        yield return AccessTools.Method(typeof(UIManager2D), nameof(UIManager2D.Set2DScreenResolution));
        yield return AccessTools.Method(typeof(UIManager2D), nameof(UIManager2D.UpdateCanvasScalerSizeToDefault));
        yield return AccessTools.Method(typeof(UIManagerAno2), nameof(UIManagerAno2.Update3DUIScale));
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
            if(instruction.Calls(getResolutionsMethod))
            {
                instruction.operand = myResolutionsMethod;
            }
            yield return instruction;
        }
    }
}