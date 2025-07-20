namespace YouWillDieTonight.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadingSequence), nameof(LoadingSequence.Start))]
    public static bool LoadingSequence_Start(LoadingSequence __instance)
    {
        __instance.Finished.Invoke();
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuStack), nameof(MenuStack.OpenMenu))]
    public static void MainMenu_OnEnable(MenuStack __instance)
    {
        var exists = __instance.transform.Find("Root/Background/NewBackground");
        if (exists)
        {
            // If the background already exists, we don't need to do anything.
            return;
        }

        var bg = __instance.transform.Find("Root/Background");
        if (bg)
        {
            var image = bg.GetComponent<Image>();
            if (image)
            {
                var clonedTop = Utils.CloneImage(image, bg, "NewBackground", true);
                if (clonedTop)
                {
                    image.enabled = false;
                    clonedTop.rectTransform.sizeDelta = clonedTop.rectTransform.sizeDelta with { x = Screen.width };
                }
            }
        }
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(ScreenEffects), nameof(ScreenEffects.PlayEffect), typeof(string), typeof(bool))]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var code = new List<CodeInstruction>(instructions);
        var modifyMethod = AccessTools.Method(typeof(Patches), nameof(ModifyFx));

        for (var i = 0; i < code.Count - 2; i++)
        {
            if (
                code[i].opcode == OpCodes.Ldloc_0 &&
                code[i + 1].opcode == OpCodes.Ldfld && code[i + 1].operand is FieldInfo { Name: "fx" } f1 &&
                code[i + 2].opcode == OpCodes.Ldfld && code[i + 2].operand is FieldInfo { Name: "Run" })
            {
                // Inject: ldloc.0 → ldfld fx → call ModifyFx(fx)
                code.Insert(i, new CodeInstruction(OpCodes.Ldloc_0));
                code.Insert(i + 1, new CodeInstruction(OpCodes.Ldfld, f1));
                code.Insert(i + 2, new CodeInstruction(OpCodes.Call, modifyMethod));
                break;
            }
        }

        return code;
    }

    public static void ModifyFx(ScreenEffect fx)
    {
        if (fx)
        {
            Plugin.Log.LogInfo($"Modifying ScreenEffect: {fx.name} ({fx.Id})");
            LayoutController.AddLayoutControllerRoot(fx.transform, LayoutController.LayoutSize.ForceFullScreen, 0, false);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectUtility), nameof(AspectUtility.Awake))]
    public static void AspectUtility_Awake(AspectUtility __instance)
    {
        AspectUtility.wantedAspectRatio = __instance._wantedAspectRatio = Plugin.CurrentAspectRatio;
        __instance.SetCamera();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name == "Video Canvas")
        {
            LayoutController.AddLayoutControllerPath(__instance.transform, "Root/Background", LayoutController.LayoutSize.ForceFullScreen, 0, false);
        }

        ProcessScaler(__instance);
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
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeartRateVolumeWeight), nameof(HeartRateVolumeWeight.OnEnable))]
    public static bool HeartRateVolumeWeight_OnEnable(HeartRateVolumeWeight __instance)
    {
        if (Plugin.HeartBeatEffect.Value) return true;
        __instance.heartBeat.UnregisterListener(__instance.onHeartBeat);
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeartRateVolumeWeight), nameof(HeartRateVolumeWeight.Update))]
    public static bool HeartRateVolumeWeight_Update()
    {
        return Plugin.HeartBeatEffect.Value;
    }

    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Plugin.CurrentAspectRatio > Plugin.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }
}