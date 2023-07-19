using System;
using System.Diagnostics.CodeAnalysis;
using HarmonyLib;

namespace TrackIt.Patches;

[HarmonyPatch]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class MiscPatches
{

    [HarmonyWrapSafe]
    [HarmonyFinalizer]
    [HarmonyPatch(typeof(HeroMerchantController), nameof(HeroMerchantController.SetArmorAnimatorInteger), typeof(string), typeof(int))]
    public static Exception Finalizer()
    {
      return null;
    }
}