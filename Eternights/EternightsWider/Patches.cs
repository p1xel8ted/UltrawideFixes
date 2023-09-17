using HarmonyLib;

namespace EternightsWider;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerPrefController), nameof(PlayerPrefController.SetTargetFrameRate))]
    public static void PlayerPrefController_SetTargetFrameRate(ref PlayerPrefController __instance)
    {
        Plugin.ForceResolution("PlayerPrefController.SetTargetFrameRate");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerPrefController), nameof(PlayerPrefController.SetResolution))]
    public static void PlayerPrefController_SetResolution(ref PlayerPrefController __instance)
    {
        Plugin.ForceResolution("PlayerPrefController.SetResolution");
    }
}