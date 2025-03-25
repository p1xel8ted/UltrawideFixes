using JUTPS.FX;
using UnityEngine.Rendering;
using YasukeSimulator.Helpers;

namespace YasukeSimulator.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    private static void UpdateScalers()
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = Resolutions.CurrentAspect > Resolutions.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    /// <summary>
    /// Overrides quality settings set by the game based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int))]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel()
    {
        QualSettings.UpdateSettings();
    }

    /// <summary>
    /// Forces game to apply expensive changes when quality settings are changed    
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel(ref bool applyExpensiveChanges)
    {
        applyExpensiveChanges = true;
    }

    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateVolumes();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BloodScreen), nameof(BloodScreen.Update))]
    public static void BloodScreen_Update(BloodScreen __instance)
    {
        if (!__instance.pl) return;
        if (!__instance.pl.CharacterHealth) return;

        if (Plugin.DisableBloodOverlay.Value)
        {
            __instance.img.color = __instance.img.color with { a = 0 };
            __instance.currentColor = __instance.currentColor with { a = 0 };
            return;
        }

        if (__instance.img.color.a < 0.17f && __instance.healthvalue > 0.8f)
        {
            __instance.img.color = __instance.img.color with { a = 0 };
            __instance.currentColor = __instance.currentColor with { a = 0 };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //unity explorer
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers();

        if (__instance.name == "Canvas")
        {
            var sceneName = SceneManager.GetActiveScene().name;
            if (sceneName == "Scene_Intro_Cinematic")
            {
                //find child transforms ending in )
                foreach (Transform child in __instance.transform)
                {
                    if (child.name == "RawImage" && child.GetComponent<RawImage>().color.a < 800)
                    {
                        child.localScale = new Vector3(10000f, 10000f, 1f);
                    }

                    if (child.name.EndsWith(")"))
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}