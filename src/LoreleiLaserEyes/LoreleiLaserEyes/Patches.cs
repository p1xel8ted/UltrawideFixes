// ReSharper disable InconsistentNaming

namespace LoreleiLaserEyes;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    private static readonly HashSet<SGDeviceSpecific> _deviceSpecifics = [];

    private static void UpdateScalers(float aspect)
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

    internal static void UpdateSGDeviceSpecifics()
    {
        foreach (var ds in _deviceSpecifics.Where(ds => ds != null))
        {
            ds.SetValues();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }


    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessEffectSettings), nameof(PostProcessEffectSettings.OnEnable))]
    public static void PostProcessProfile_OnEnable(PostProcessEffectSettings __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BootScript), nameof(BootScript.Awake))]
    public static void BootScript_SpeedUpLoading(BootScript __instance)
    {
        // Speed up all fade animations
        __instance.loadingAnimationFadeInOut = 0.01f;
        __instance.preloadLoopSoundFadeIn = 0.01f;
        __instance.preloadLoopSoundFadeOut = 0.01f;
    
        // Skip boot freeze frames
        __instance.m_nBootFreezeFrames = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BootScript), nameof(BootScript.Update))]
    public static void BootScript_Update_SpeedUp(BootScript __instance)
    {
        // Speed up preload states by reducing wait times
        if (__instance.m_nBootState == BootScript.BootState.Preload && 
            __instance.m_nPreloadState == BootScript.PreloadState.LoadingComplete)
        {
            // Reduce the 0.7f wait to instant
            __instance.m_fPreloadStateTime = 1f;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Postfix(int width, int height)
    {
        UpdateSGDeviceSpecifics();

        var gameView = SGGameView.GetInstance();
        gameView?.OnResolutionChanged();

        var currentAspect = width / (float)height;
        UpdateScalers(currentAspect);
    }

    // //this doesn't appear to get used anywhere in a UI, but leaving it just in case
    // [HarmonyTranspiler]
    // [HarmonyPatch(typeof(SGDeviceSpecific), nameof(SGDeviceSpecific.Init))]
    // private static IEnumerable<CodeInstruction> ReplaceResolutionTranspiler(IEnumerable<CodeInstruction> instructions)
    // {
    //     var codes = new List<CodeInstruction>(instructions);
    //
    //     for (var i = 0; i < codes.Count - 2; i++)
    //     {
    //         // Look for the pattern where 3440 and 1440 are loaded
    //         if (codes[i].opcode == OpCodes.Ldc_I4 && (int)codes[i].operand == 3440 &&
    //             codes[i + 1].opcode == OpCodes.Ldc_I4 && (int)codes[i + 1].operand == 1440)
    //         {
    //             // Replace with current screen dimensions
    //             codes[i] = new CodeInstruction(OpCodes.Call, AccessTools.PropertyGetter(typeof(Screen), nameof(Screen.width)));
    //             codes[i + 1] = new CodeInstruction(OpCodes.Call, AccessTools.PropertyGetter(typeof(Screen), nameof(Screen.height)));
    //            // Plugin.Log.LogWarning($"Replaced resolution string with current resolution #1");
    //             // Also need to update the string "3440 x 1440" that follows
    //             for (var j = i + 2; j < codes.Count; j++)
    //             {
    //                 if (codes[j].opcode == OpCodes.Ldstr && (string)codes[j].operand == "3440 x 1440")
    //                 {
    //                     codes[j] = new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Patches), nameof(GetCurrentResolutionString)));
    //                    // Plugin.Log.LogWarning($"Replaced resolution string with current resolution #2");
    //                     break;
    //                 }
    //             }
    //
    //             break;
    //         }
    //     }
    //
    //     return codes;
    // }
    //
    // public static string GetCurrentResolutionString()
    // {
    //     return $"{Display.main.systemWidth} x {Display.main.systemHeight}";
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SGDeviceSpecific), nameof(SGDeviceSpecific.Init))]
    [HarmonyPatch(typeof(SGDeviceSpecific), nameof(SGDeviceSpecific.SetValues))]
    public static void SGDeviceSpecific_Init(SGDeviceSpecific __instance)
    {
        _deviceSpecifics.Add(__instance);
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(SGDeviceSpecific), nameof(SGDeviceSpecific.SetValues))]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);

        for (var i = 0; i < codes.Count; i++)
        {
            if (codes[i].opcode == OpCodes.Ldc_R4 && Mathf.Approximately((float)codes[i].operand, 1.7777778f))
            {
                codes[i] = new CodeInstruction(OpCodes.Call, typeof(Patches).GetMethod(nameof(GetScreenAspectRatio)));
            }
        }

        return codes;
    }

    public static float GetScreenAspectRatio()
    {
        return Plugin.GetPreferredAspect();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BootScript), nameof(BootScript.GotoState))]
    public static void BootScript_GotoState(BootScript __instance, ref BootScript.BootState nState)
    {
        if (nState == BootScript.BootState.LogoTrain)
        {
            __instance.m_nLogoTrainIndex = __instance.logoTrain.Count;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SGGameView), nameof(SGGameView.OnResolutionChanged))]
    [HarmonyPatch(typeof(SGGameView), nameof(SGGameView.UpdateRenderParams))]
    [HarmonyPatch(typeof(SGGameView), nameof(SGGameView.UpdateRenderTexture))]
    [HarmonyPatch(typeof(SGGameView), nameof(SGGameView.SetGameViewShaderParams))]
    public static void EnsureUltrawideValues()
    {
        SGFW.DeviceSpecific.SCREEN_WIDTH = Screen.width;
        SGFW.DeviceSpecific.SCREEN_HEIGHT = Screen.height;

        SGFW.DeviceSpecific.GAMEVIEW_WIDTH = Screen.width;
        SGFW.DeviceSpecific.GAMEVIEW_HEIGHT = Screen.height;

        SGFW.DeviceSpecific.GAMEVIEW_RESOLUTION_SCALER = Screen.height / 1080f;

        SGFW.DeviceSpecific.SCREEN_RESOLUTION_SCALER = Screen.height / 1080f;

        SGFW.DeviceSpecific.m_nGameViewRenderWidth = Screen.width;
        SGFW.DeviceSpecific.m_nGameViewRenderHeight = Screen.height;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Plugin.CurrentAspect);
    }
}