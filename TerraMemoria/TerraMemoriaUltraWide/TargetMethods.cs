namespace TerraMemoriaUltraWide;

[Harmony]
public static class TargetMethodsPatch
{
    [HarmonyTargetMethods]
    internal static IEnumerable<MethodBase> TargetMethods()
    {
        var methods = AccessTools.GetDeclaredMethods(typeof(AmbientManager));
        foreach (var method in from method in methods where !method.Name.Equals("Update") where !method.Name.StartsWith("set_") where !method.Name.StartsWith("get_") select method)
        {
            yield return method;
        }
    }

    [HarmonyPostfix]
    public static void AmbientManager_TargetMethods(ref AmbientManager __instance)
    {
        Plugin.RefreshVolumeProfiles();
        var ambientProfiles = new[]
        {
            __instance._currentAmbient,
            __instance._forceAmbient,
            __instance._blendFrom,
            __instance._blendTo,
            __instance._waitingBlend,
            __instance.DayAmbient,
            __instance.NightAmbient,
        };

        foreach (var profile in ambientProfiles)
        {
            if (profile?._postProcessing is null) continue;
            Plugin.VolumeProfiles.Add(profile._postProcessing);
        }

        if (__instance._generalVolume?.profile != null)
        {
            Plugin.VolumeProfiles.Add(__instance._generalVolume.profile);
        }
    }


}