namespace TheWalkingDeadStreetsOfSurvival;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private const string UnityExplorerMarker = "Sinai";

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize) return;
        if (__instance.name.IndexOf(UnityExplorerMarker, StringComparison.OrdinalIgnoreCase) >= 0) return;
        if (__instance.screenMatchMode == CanvasScaler.ScreenMatchMode.MatchWidthOrHeight && Mathf.Approximately(__instance.matchWidthOrHeight, 1f)) return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        __instance.matchWidthOrHeight = 1f;
    }

    // The demo has no post-processing volumes, so these never do anything. Left for the full game.
    //[HarmonyPostfix]
    //[HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register), typeof(Volume), typeof(int))]
    //public static void VolumeManager_Register(Volume volume, int layer)
    //{
    //    Volumes.ProcessVolumeRegistration(volume, layer);
    //}

    //[HarmonyPostfix]
    //[HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Unregister), typeof(Volume), typeof(int))]
    //public static void VolumeManager_Unregister(Volume volume, int layer)
    //{
    //    Volumes.ProcessVolumeUnregister(volume);
    //}

    //[HarmonyPostfix]
    //[HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    //public static void Volume_OnEnable(Volume __instance)
    //{
    //    Volumes.UpdateSingleVolume(__instance);
    //}

    private const string LabelKey = "ultrawide_native_resolution";

    private static int NativeIndex(UIMenuSettings menu)
    {
        return menu._resolution._optionTexts.Count - 1;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(GeneralSaveData.Settings), MethodType.Constructor)]
    public static void Settings_Constructor(GeneralSaveData.Settings __instance)
    {
        __instance.resolutionWidth = Plugin.MainWidth;
        __instance.resolutionHeight = Plugin.MainHeight;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIMenuSettings), nameof(UIMenuSettings.OnEnable))]
    public static void UIMenuSettings_OnEnable(UIMenuSettings __instance)
    {
        var options = __instance._resolution._optionTexts;
        if (options.Count == 0) return;
        if (options[options.Count - 1].TableEntryReference.Key == LabelKey) return;

        var label = $"{Plugin.MainWidth} x {Plugin.MainHeight}";
        var table = options[0].TableReference;

        try
        {
            foreach (var locale in LocalizationSettings.AvailableLocales.Locales)
            {
                var stringTable = LocalizationSettings.StringDatabase.GetTable(table, locale);
                if (!stringTable) continue;
                if (stringTable.GetEntry(LabelKey) == null)
                {
                    stringTable.AddEntry(LabelKey, label);
                }
            }
        }
        catch (Exception e)
        {
            Plugin.Log.LogWarning($"Could not add native resolution label: {e.Message}");
            return;
        }

        options.Add(new LocalizedString(table, LabelKey));
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIMenuSettings), nameof(UIMenuSettings.ConvertResolution), typeof(int), typeof(int))]
    public static void UIMenuSettings_ConvertResolution_ToIndex(UIMenuSettings __instance, int width, int height, ref int __result)
    {
        if (width == Plugin.MainWidth && height == Plugin.MainHeight)
        {
            __result = NativeIndex(__instance);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIMenuSettings), nameof(UIMenuSettings.ConvertResolution), typeof(int))]
    public static void UIMenuSettings_ConvertResolution_ToSize(UIMenuSettings __instance, int index, ref (int width, int height) __result)
    {
        if (index == NativeIndex(__instance))
        {
            __result = (Plugin.MainWidth, Plugin.MainHeight);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIMenuLogosIntro), nameof(UIMenuLogosIntro.Start))]
    public static void UIMenuLogosIntro_Start(UIMenuLogosIntro __instance)
    {
        __instance._Animator.enabled = false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIMenuLogosIntro), nameof(UIMenuLogosIntro.Update))]
    public static bool UIMenuLogosIntro_Update()
    {
        var scenes = ServiceLocator.Get<SceneManagerService>();
        if (scenes._sceneLoadOperation != null && scenes._holdActivation)
        {
            scenes.ReleaseHoldOnSceneActivation();
        }
        return false;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.PushStateToUnityCamera))]
    public static void CinemachineBrain_PushStateToUnityCamera(ref CameraState state)
    {
        if (Mathf.Approximately(Plugin.FovMultiplier, 1f)) return;
        state.Lens.FieldOfView *= Plugin.FovMultiplier;
    }
}
