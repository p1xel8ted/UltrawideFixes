namespace TormentedSouls;

[Harmony]
public static class Patches
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(ref CinemachineVirtualCamera __instance)
    {
        if (__instance.gameObject.TryGetComponent(out FoVController _)) return;
        __instance.gameObject.AddComponent<FoVController>();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(InitMenuController), nameof(InitMenuController.OnEnter))]
    public static void InitMenuController_OnEnter(ref InitMenuController __instance)
    {
        __instance.tormented2WishlistButton.SetActive(false);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.Update))]
    private static void Volume_Update(PostProcessVolume __instance)
    {
       if (!Plugin.PostProcessingEffects.Value) return;
       
        var ap = __instance.profile;
        
        if (ap.TryGetSettings(out Bloom bloomComponent))
        {
            bloomComponent.active = Plugin.Bloom.Value;
        }
        
        if (ap.TryGetSettings(out AmbientOcclusion ambientOcclusionComponent))
        {
            ambientOcclusionComponent.active = Plugin.AmbientOcclusion.Value;
        }
    
        if (ap.TryGetSettings(out ColorGrading colorGradingComponent))
        {
            colorGradingComponent.active = Plugin.ColorAdjustments.Value;
        }
    
        if (ap.TryGetSettings(out Streak streakComponent))
        {
            streakComponent.active = Plugin.Streak.Value;
        }
    
        if (ap.TryGetSettings(out SharpenV2 sharpenV2Component))
        {
            sharpenV2Component.active = Plugin.Sharpen.Value;
        }
    
        if (ap.TryGetSettings(out TiltShiftBlur tiltShiftBlurComponent))
        {
            tiltShiftBlurComponent.active = Plugin.TiltShiftBlur.Value;
        }
    
        if (ap.TryGetSettings(out RapidOldTVVignette rapidOldTVVignetteComponent))
        {
            rapidOldTVVignetteComponent.active = Plugin.RapidOldTVVignette.Value;
        }
        
        if(!ap.TryGetSettings(out ScreenSpaceReflections ssr))
        {
            ssr = ScriptableObject.CreateInstance<ScreenSpaceReflections>();
            ssr.active = true;

            ap.AddSettings(ssr);
        }
        
        ssr.active = Plugin.ScreenSpaceReflections.Value;
        ssr.resolution.value = ScreenSpaceReflectionResolution.FullSize;
        ssr.preset.value = ScreenSpaceReflectionPreset.Ultra;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.Init))]
    public static void PostProcessLayer_Init(ref PostProcessLayer __instance)
    {
        __instance.gameObject.TryGetComponent(out PostProcessVolume volume);
        if (!volume)
        {
            volume = __instance.gameObject.AddComponent<PostProcessVolume>();
        }
        var ap = volume.profile;
        if (!ap.TryGetSettings(out ScreenSpaceReflections ssr))
        {
            ssr = ScriptableObject.CreateInstance<ScreenSpaceReflections>();
            ap.AddSettings(ssr);
            ssr.active = true;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    public static void VideoPlayer_Play(ref VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains(Const.Sinai, StringComparison.OrdinalIgnoreCase)) return;
        var refHeight = __instance.referenceResolution.y;
        if (Mathf.Approximately(refHeight, Const.UiReferenceResolutionHeight))
        {
            Utils.UpdateCanvasScaler(__instance, Const.UiReferenceResolutionHeight);
        }
        else if (Mathf.Approximately(refHeight, Const.DeathReferenceResolutionHeight))
        {
            Utils.UpdateCanvasScaler(__instance, Const.DeathReferenceResolutionHeight);
        }
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicsBaseMenuController), nameof(GraphicsBaseMenuController.OnSResolutionPress))]
    public static void GraphicsBaseMenuController_OnSResolutionPress_Prefix(ref GraphicsBaseMenuController __instance, ref int pos)
    {
        if (__instance.sResolutionTextID.Exists(new Func<string, bool>(a => a.Equals(Const.Uw)))) return;
        __instance.sResolutionTextID.Add(Const.Uw);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MultilanguageUIManager), nameof(MultilanguageUIManager.GetText))]
    public static bool GetText(ref MultilanguageUIManager __instance, ref string id, ref Il2CppSystem.Collections.Generic.Dictionary<SceneDataSO.LanguagesEnum, string> __result)
    {
        if (!id.Equals(Const.Uw)) return true;
        var dictionary = new Il2CppSystem.Collections.Generic.Dictionary<SceneDataSO.LanguagesEnum, string>();
        dictionary.Add(SceneDataSO.LanguagesEnum.EN, "Ultra Wide");
        dictionary.Add(SceneDataSO.LanguagesEnum.ES, "Ultra Ancho");
        dictionary.Add(SceneDataSO.LanguagesEnum.GER, "Ultra Breit");
        dictionary.Add(SceneDataSO.LanguagesEnum.FR, "Ultra Large");
        dictionary.Add(SceneDataSO.LanguagesEnum.RU, "Сверхширокий");
        dictionary.Add(SceneDataSO.LanguagesEnum.IT, "Ultra Ampio");
        dictionary.Add(SceneDataSO.LanguagesEnum.POR, "Ultra Amplo");
        dictionary.Add(SceneDataSO.LanguagesEnum.KR, "울트라와이드");
        dictionary.Add(SceneDataSO.LanguagesEnum.CH, "超广角");
        dictionary.Add(SceneDataSO.LanguagesEnum.JP, "超広角");
        __result = dictionary;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.Setup))]
    public static void QualitySettingsManager_Setup(ref QualitySettingsManager __instance)
    {
        var settingsData = PersistentData.GetSettingsData();
        __instance.SetupResolution();
        __instance.debugResolution = 4;
        settingsData.currentResolution = 4;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicsBaseMenuController), nameof(GraphicsBaseMenuController.OnSResolutionForceUpdate))]
    public static void GraphicsBaseMenuController_OnSResolutionForceUpdate(ref GraphicsBaseMenuController __instance)
    {
        if (__instance.sResolutionTextID.Exists(new Func<string, bool>(a => a.Equals(Const.Uw)))) return;

        __instance.sResolutionTextID.Add(Const.Uw);
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.IterateResolution), [])]
    public static bool QualitySettingsManager_IterateResolution(ref QualitySettingsManager __instance, ref int __result)
    {
        __instance.debugResolution =
            (int) Mathf.Repeat(PersistentData.GetSettingsData().currentResolution + 1, 5f);
        __instance.SetupResolution();
        PersistentData.GetSettingsData().currentResolution = __instance.debugResolution;
        __result = __instance.debugResolution;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.IterateResolution), typeof(int))]
    public static bool QualitySettingsManager_IterateResolution_Int(ref QualitySettingsManager __instance, ref int pos,
        ref int __result)
    {
        __instance.debugResolution =
            (int) Mathf.Repeat(PersistentData.GetSettingsData().currentResolution + pos, 5f);
        __instance.SetupResolution();
        PersistentData.GetSettingsData().currentResolution = __instance.debugResolution;
        __result = __instance.debugResolution;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.SetupResolution))]
    public static bool QualitySettingsManager_SetupResolution(ref QualitySettingsManager __instance)
    {
        switch (__instance.debugResolution)
        {
            case 4:
                Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, Plugin.MaxRefresh);
                break;
            case 3:
                Screen.SetResolution(3840, 2160, true, Plugin.MaxRefresh);
                break;
            case 2:
                Screen.SetResolution(2560, 1440, true, Plugin.MaxRefresh);
                break;
            case 1:
                Screen.SetResolution(1920, 1080, true, Plugin.MaxRefresh);
                break;
            case 0:
                Screen.SetResolution(1280, 720, true, Plugin.MaxRefresh);
                break;
        }
        return false;
    }
}