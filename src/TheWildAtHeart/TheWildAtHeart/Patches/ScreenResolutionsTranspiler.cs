using JetBrains.Annotations;
using TheWildAtHeart.Misc;

namespace TheWildAtHeart.Patches;

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
    public static UnityEngine.Resolution[] MyResolutions()
    {
        var newRes = new UnityEngine.Resolution
        {
            height = Display.main.systemHeight,
            width = Display.main.systemWidth,
            refreshRate = Screen.resolutions.Max(a => a.refreshRate)
        };
        var availableResolutions = Screen.resolutions.ToList();
        availableResolutions.Add(newRes);
        var distinctResolutions = availableResolutions.Distinct(new ResolutionComparer()).ToList();
        distinctResolutions.SortByPixelCount();
        return distinctResolutions.ToArray();
    }

    /// <summary>
    /// Specifies the methods to which the transpiler should be applied.
    /// </summary>
    /// <returns>A list of methods to be patched by the transpiler.</returns>
    [HarmonyTargetMethods]
    [UsedImplicitly]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(GraphicsSettings), nameof(GraphicsSettings.ApplyResolution));
        yield return AccessTools.Method(typeof(BGraphicsSettings), nameof(BGraphicsSettings.InitializeResolution));
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

/// <summary>
/// Efficient equality comparer for Unity Resolution structs.
/// </summary>
internal sealed class ResolutionComparer : IEqualityComparer<UnityEngine.Resolution>
{
    public bool Equals(UnityEngine.Resolution x, UnityEngine.Resolution y)
    {
        return x.width == y.width && x.height == y.height && x.refreshRate == y.refreshRate;
    }

    public int GetHashCode(UnityEngine.Resolution obj)
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + obj.width;
            hash = hash * 23 + obj.height;
            hash = hash * 23 + obj.refreshRate;
            return hash;
        }
    }
}