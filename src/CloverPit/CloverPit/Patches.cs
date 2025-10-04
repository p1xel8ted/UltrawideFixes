// ReSharper disable InconsistentNaming

namespace CloverPit;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    internal static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PowerupTriggerAnimController), nameof(PowerupTriggerAnimController.Awake))]
    public static void PowerupTriggerAnimController_Awake(PowerupTriggerAnimController __instance)
    {
        var descriptor = __instance.myCamera.targetTexture.descriptor;
        var newWidth = Mathf.RoundToInt(descriptor.height * Plugin.CurrentAspect);
        if (descriptor.width != newWidth)
        {
            descriptor.width = newWidth;
            __instance.myCamera.targetTexture.Release();
            __instance.myCamera.targetTexture.descriptor = descriptor;
            __instance.myCamera.targetTexture.Create();
        }

        __instance.myCamera.aspect = Plugin.CurrentAspect;
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(UnityTwitch), nameof(UnityTwitch.CreatePAL))]
    // [HarmonyPatch(typeof(UnityTwitch), nameof(UnityTwitch.InitializeInternally))]
    // [HarmonyPatch(typeof(UnityTwitch.UnityPAL), nameof(UnityTwitch.UnityPAL.Start))]
    // private static bool UnityTwitch_CreatePAL()
    // {
    //     return false;
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.Start))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        if (__instance.name == "Powerup Trigger Anim Renderer")
        {
            __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            __instance.aspectRatio = Plugin.CurrentAspect;
            __instance.transform.position = __instance.transform.position with { x = Plugin.ScaleFactor };
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.transform.parent && __instance.transform.parent.name.ContainsInsensitive("powerup")) return;

        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Plugin.CurrentAspect);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroScript), nameof(IntroScript.PopUpShow))]
    private static bool IntroScript_PopUpShow(string title)
    {
        return !title.Contains("photosensitive", StringComparison.OrdinalIgnoreCase);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroScript), nameof(IntroScript.IntroCoroutine))]
    private static void IntroScript_IntroCoroutine_Prefix()
    {
        if (Master.instance)
        {
            Master.instance.SHOW_AUTOSAVE_WARNING_STARTUP = false;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GeneralUiScript), nameof(GeneralUiScript.Awake))]
    [HarmonyPatch(typeof(GeneralUiScript), nameof(GeneralUiScript.Start))]
    private static void GeneralUiScript_Awake(GeneralUiScript __instance)
    {
        AddFitter(__instance.gameObject);

        var transition = __instance.transform.Find("Holder/FadeImage");
        if (transition)
        {
            AddFitter(transition.gameObject, Plugin.CurrentAspect);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(PhoneUiScript), nameof(PhoneUiScript.Awake))]
    [HarmonyPatch(typeof(PhoneUiScript), nameof(PhoneUiScript.Start))]
    private static void PhoneUiScript_Awake(PhoneUiScript __instance)
    {
        AddFitter(__instance.gameObject, Plugin.NativeAspect);
    }


    private static void AddFitter(GameObject go, float aspect = 0)
    {
        if (!go) return;
        var arf = go.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        if (aspect > 0)
        {
            arf.aspectRatio = aspect;
        }
        else
        {
            arf.aspectRatio = arf.aspectRatio = Plugin.GetPreferredAspect();
        }
    }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(PowerupTriggerAnimController), nameof(PowerupTriggerAnimController.Start))]
    // private static void PowerupTriggerAnimController_Start(PowerupTriggerAnimController __instance)
    // {
    //     __instance.myBackImage.rectTransform.localScale = new Vector3(Plugin.ScaleFactor, Plugin.ScaleFactor, 1);
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DialogueScript), nameof(DialogueScript.Awake))]
    [HarmonyPatch(typeof(DialogueScript), nameof(DialogueScript.Start))]
    private static void DialogueScript_Awake(DialogueScript __instance)
    {
        AddFitter(__instance.gameObject, Plugin.NativeAspect);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(IntroScript), nameof(IntroScript.IntroCoroutine))]
    private static void IntroScript_IntroCoroutine_Postfix(ref IEnumerator __result)
    {
        __result = FilterEnumerator(__result, [typeof(WaitForSeconds)]);
        Plugin.Log.LogInfo("Filtered IntroCoroutine to remove WaitForSeconds");
    }

    private static IEnumerator FilterEnumerator(IEnumerator original, Type[] typesToRemove)
    {
        while (original.MoveNext())
        {
            var current = original.Current;
            if (current != null && !typesToRemove.Contains(current.GetType()))
            {
                yield return current;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessEffectSettings), nameof(PostProcessEffectSettings.OnEnable))]
    public static void PostProcessProfile_OnEnable(PostProcessEffectSettings __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Data.SettingsData), nameof(Data.SettingsData.ResolutionDesiredWidthGet))]
    public static void SettingsData_ResolutionDesiredWidthGet(ref int __result)
    {
#if DEBUG
        __result = Plugin.Width;
#else
        __result = Display.main.systemWidth;
#endif
        Plugin.Log.LogInfo($"Adjusted desired width for aspect ratio: {Plugin.CurrentAspect} - {__result}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Data.SettingsData), nameof(Data.SettingsData.ResolutionDesiredHeightGet))]
    public static void SettingsData_ResolutionDesiredHeightGet(ref int __result)
    {
#if DEBUG
        __result = Plugin.Height;
#else
        __result = Display.main.systemHeight;
#endif
        Plugin.Log.LogInfo($"Adjusted desired height for aspect ratio: {Plugin.CurrentAspect} - {__result}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SlotSideUIScript), nameof(SlotSideUIScript.Awake))]
    public static void SlotSideUIScript_Awake(SlotSideUIScript __instance)
    {
        __instance.leftPromptHidePosition.x *= Plugin.ScaleFactor;
        __instance.rightPromptHidePosition.x *= Plugin.ScaleFactor;
        Plugin.Log.LogInfo($"Adjusted SlotSideUIScript positions for aspect ratio: {Plugin.CurrentAspect} - Left: {__instance.leftPromptHidePosition.x} - Right: {__instance.rightPromptHidePosition.x}");
    }

    public static void UpdateHUD()
    {
        var arf = GeneralUiScript.instance?.GetComponent<AspectRatioFitter>();
        if (arf)
        {
            arf.aspectRatio = Plugin.GetPreferredAspect();
        }
    }
}