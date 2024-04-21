using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using UnityEngine;
using Zyklus.CameraManager;
using Zyklus.Home;
using Zyklus.Video;

namespace ChildrenOfMorta;

[HarmonyPatch]
public static class AspectRatioTranspiler
{
    private const float OldValue = 16 / (float) 9;

    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(CameraManagerComponent), nameof(CameraManagerComponent.UpdateAspectRatio));
        yield return AccessTools.Method(typeof(CameraManagerComponent), nameof(CameraManagerComponent.UpdateCameraArea));
        yield return AccessTools.Method(typeof(RenderOutputManager), nameof(RenderOutputManager.UpdateScreenBox));
        yield return AccessTools.Method(typeof(CameraHandle), nameof(CameraHandle.GetAspectRatio));
        yield return AccessTools.Method(typeof(CameraHandle), nameof(CameraHandle.DrawGizmo));
        yield return AccessTools.Method(typeof(DenLoiteringManager), nameof(DenLoiteringManager.SetLeft));
        yield return AccessTools.Method(typeof(DenLoiteringManager), nameof(DenLoiteringManager.SetRight));
        yield return AccessTools.Method(typeof(EndlessLoiteringManager), nameof(EndlessLoiteringManager.SetLeft));
        yield return AccessTools.Method(typeof(EndlessLoiteringManager), nameof(EndlessLoiteringManager.SetRight));
        yield return AccessTools.Method(typeof(HomeLoiteringManager), nameof(HomeLoiteringManager.SetLeft));
        yield return AccessTools.Method(typeof(HomeLoiteringManager), nameof(HomeLoiteringManager.SetRight));
        yield return AccessTools.Method(typeof(VideoPlayerManager), nameof(VideoPlayerManager.ForceUpdate));
    }

    [HarmonyTranspiler]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var newValue = Display.main.systemWidth / (float) Display.main.systemHeight;
        foreach (var inst in instructions)
        {
            if (inst.opcode == OpCodes.Ldc_R4 && Mathf.Approximately((float) inst.operand, OldValue))
            {
                inst.operand = newValue;
            }
            yield return inst;
        }
    }
}