namespace FANTASIANNeoDimension.Patches;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];


    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Mod.MainAspect > Mod.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    private static void UpdateCam(Camera cam)
    {
        if (!cam) return;

        cam.aspect = Mod.MainAspect;
        cam.rect = new Rect(0, 0, 1, 1);
        cam.pixelRect = new Rect(0, 0, Mod.NativeDisplayWidth, Mod.NativeDisplayHeight);
    }


    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(LetterboxCamera), nameof(LetterboxCamera.ResetCamera))]
    // [HarmonyPatch(typeof(LetterboxCamera), nameof(LetterboxCamera.Awake))]
    // [HarmonyPatch(typeof(LetterboxCamera), nameof(LetterboxCamera.UpdateCamera))]
    // public static void LetterboxCamera_Awake(LetterboxCamera __instance)
    // {
    //     __instance.targetAspect = Mod.MainAspect;
    //     UpdateCam(__instance.cam);
    // }

    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(FixedAspectRatio), nameof(FixedAspectRatio.Start))]
    // [HarmonyPatch(typeof(FixedAspectRatio), nameof(FixedAspectRatio.UpdateViewport))]
    // public static void FixedAspectRatio_Start(FixedAspectRatio __instance)
    // {
    //     __instance.targetAspect = Mod.MainAspect;
    //     UpdateCam(__instance.cam);
    // }
    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(LetterboxCameraBars), nameof(LetterboxCameraBars.Awake))]
    // [HarmonyPatch(typeof(LetterboxCameraBars), nameof(LetterboxCameraBars.SetBar))]
    // [HarmonyPatch(typeof(LetterboxCameraBars), nameof(LetterboxCameraBars.UpdateBars))]
    // public static void LetterboxCameraBars_Awake(LetterboxCameraBars __instance)
    // {
    //     __instance.targetAspect = Mod.MainAspect;
    //     __instance.barBottom.enabled = false;
    //     __instance.barTop.enabled = false;
    //     __instance.barLeft.enabled = false;
    //     __instance.barRight.enabled = false;
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }

    // private static PostProcessVolume MainVolume => Camera.allCameras.FirstOrDefault(c => c.name == "FirstPersonCharacter")?.GetComponent<PostProcessVolume>();
    //
    // internal static void UpdatePostProcessing()
    // {
    //     var volume = MainVolume;
    //     if (!volume) return;
    //     
    //     foreach (var setting in volume.profile.settings)
    //     {
    //         UpdateSetting(setting);
    //     }
    // }
    //
    // private static void UpdateSetting(PostProcessEffectSettings setting)
    // {
    //     setting.active = setting.GetIl2CppType().Name switch
    //     {
    //         "Vignette" => Mod.Vignette.Value,
    //         "ChromaticAberration" => Mod.ChromaticAberration.Value,
    //         "LensDistortion" => Mod.LensDistortion.Value,
    //         "AmbientOcclusion" => Mod.AmbientOcclusion.Value,
    //         "Bloom" => Mod.Bloom.Value,
    //         "ColorGrading" => Mod.ColorGrading.Value,
    //         "MotionBlur" => Mod.MotionBlur.Value,
    //         "Grain" => Mod.Grain.Value,
    //         _ => setting.active
    //     };
    // }
    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    // public static void PostProcessEffectSettings_OnEnable(PostProcessVolume __instance)
    // {
    //     if (__instance.name != "FirstPersonCharacter") return;
    //
    //     foreach (var setting in __instance.profile.settings)
    //     {
    //         UpdateSetting(setting);
    //     }
    // }
}