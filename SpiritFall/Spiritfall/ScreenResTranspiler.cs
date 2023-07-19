using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Avrahamy;
using HarmonyLib;
using UnityEngine;
using Display = UnityEngine.Display;

namespace Spiritfall;

/// <summary>
/// Represents a Harmony patch for Unity's <see cref="Screen.resolutions"/> method. 
/// This patch is designed to add custom screen resolutions to the list of available resolutions.
/// </summary>
[HarmonyPatch]
public static class ScreenResolutionsPatch
{
    /// <summary>
    /// Gets or sets the list of vector resolutions.
    /// </summary>
    internal static List<Vector2Int> VectorResolutions { get; private set; } = new();

    /// <summary>
    /// Gets or sets the list of supported refresh rates.
    /// </summary>
    internal static List<int> SupportRefresh { get; private set; } = new();

    /// <summary>
    /// Provides a list of screen resolutions, including custom ones based on the main display.
    /// This method is designed to replace the original <see cref="Screen.resolutions"/> method.
    /// </summary>
    /// <returns>
    /// A list of resolutions, including the custom ones added by this patch.
    /// </returns>
    public static Resolution[] MyResolutions()
    {
        Plugin.Log.LogWarning("Unity Screen.resolutions intercepted!");

        VectorResolutions.Clear();
        SupportRefresh.Clear();
        
        SupportRefresh = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToList();
        var availableResolutions = Screen.resolutions.ToList();
        availableResolutions.AddRange(SupportRefresh.Select(refreshRate => new Resolution {height = Display.main.systemHeight, width = Display.main.systemWidth, refreshRate = refreshRate}));
        foreach (var res in availableResolutions)
        {
            VectorResolutions.Add(new Vector2Int(res.width, res.height));
        }

        VectorResolutions = VectorResolutions.Distinct().ToList();
        return availableResolutions.ToArray();
    }

    /// <summary>
    /// Specifies the methods to which the transpiler should be applied.
    /// </summary>
    /// <returns>
    /// A list of methods to be patched by the transpiler. In this case, 
    /// the method that retrieves the supported fullscreen resolutions from the <see cref="SettingsModel"/> class.
    /// </returns>
    [HarmonyTargetMethods]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Property(typeof(SettingsModel), nameof(SettingsModel.SupportedFullscreenResolutions))?.GetGetMethod();
    }

    /// <summary>
    /// Transpiler method that modifies the IL instructions of the target methods.
    /// This method replaces calls to <see cref="Screen.resolutions"/> with calls to <see cref="MyResolutions"/>.
    /// </summary>
    /// <param name="instructions">The original IL instructions of the method.</param>
    /// <returns>The modified IL instructions with the <see cref="Screen.resolutions"/> calls replaced.</returns>
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