using Cinemachine;
using HarmonyLib;
using MSL.ThirdPersonController;

namespace AgathaChristieMOE;

[Harmony]
public static class Patches
{
    internal static CinemachineVirtualCamera ShoulderCam { get; private set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ThirdPersonCamera), nameof(ThirdPersonCamera.ApplyFOV))]
    public static void ThirdPersonCamera_ApplyFOV(ref ThirdPersonCamera __instance)
    {
        ShoulderCam = __instance._cinemachineCamera;
        var percent = Plugin.FoVMultiplierPercent.Value / 100f;
        __instance._cinemachineCamera.m_Lens.FieldOfView += __instance._cinemachineCamera.m_Lens.FieldOfView * percent;
    }
}