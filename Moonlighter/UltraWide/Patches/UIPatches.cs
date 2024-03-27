using System.Diagnostics.CodeAnalysis;
using System.Linq;
using HarmonyLib;

namespace UltraWide.Patches;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class UIPatches
{
    private const float BaseAspect = 16f / 9f;
    private static float AspectRatio => (float)Plugin.MainWidth / Plugin.MainHeight;
    private static float ScaleFactor => AspectRatio / BaseAspect;
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(InfoPopUp), nameof(InfoPopUp.Enable))]
    public static void InfoPopUp_Enable(ref InfoPopUp __instance)
    {
        if (!Plugin.UltrawideFixes.Value) return;

        var bg = __instance.transform.GetComponentsInChildren<UnityEngine.UI.Image>(true).ToList().Where(a=>a.name.Equals("Image - DarkLayer", System.StringComparison.OrdinalIgnoreCase));
        foreach(var b in bg)
        {
            b.transform.localScale = new UnityEngine.Vector3(ScaleFactor, 1.0f, 1.0f);
        }
    }
}