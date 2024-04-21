using System.Diagnostics.CodeAnalysis;
using HarmonyLib;

namespace TheLastCampfire;

[HarmonyPatch]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CameraManagerComponent), nameof(CameraManagerComponent.ReInitializeCameras))]
    // private static void Trigger_Update()
    // {
    //     UpdateAll();
    // }
    
}