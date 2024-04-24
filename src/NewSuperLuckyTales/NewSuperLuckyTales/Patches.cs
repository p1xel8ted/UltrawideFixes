namespace NewSuperLuckyTales;

[Harmony]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(UiLoadingScreen), nameof(UiLoadingScreen.Awake))]
    [HarmonyPatch(typeof(UiLoadingScreen), nameof(UiLoadingScreen.Start))]
    [HarmonyPatch(typeof(UiLoadingScreen), nameof(UiLoadingScreen.Show))]
    [HarmonyPatch(typeof(UiLoadingScreen), nameof(UiLoadingScreen.ShowHubTransition))]
    public static void UiLoadingScreen_Start(UiLoadingScreen __instance)
    {
        var starryBg = __instance.transform.Find("TipContent/Background");
        if (starryBg)
        {
            starryBg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
        }


        var playfulBg = __instance.transform.Find("BootstrapperContent/Background_Image");
        if (playfulBg)
        {
            playfulBg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        var menuBackground = __instance.transform.Find("Background/Background_Image");
        if (!menuBackground) return;

        var image = menuBackground.GetComponent<Image>();
        image.rectTransform.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        var pivot = image.rectTransform.pivot;

        var resourceName = Plugin.MainAspectRatio switch
        {
            >= Plugin.SuperWideAspectRatio => "NewSuperLuckyTales.assets.32-9.jpg",
            > Plugin.BaseAspectRatio => "NewSuperLuckyTales.assets.21-9.jpg",
            _ => "NewSuperLuckyTales.assets.21-9.jpg"
        };

        var assembly = Assembly.GetExecutingAssembly();
        var texture = new Texture2D(2, 2);

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                Plugin.Log.LogError($"Embedded image resource not found: {resourceName}");
                return;
            }

            var imageData = new byte[stream.Length];
            _ = stream.Read(imageData, 0, imageData.Length);
            texture.LoadImage(imageData);
        }

        image.sprite = Sprite.Create(texture, new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight), pivot);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameConfiguration), MethodType.Constructor)]
    [HarmonyPatch(typeof(GameConfiguration), MethodType.StaticConstructor)]
    public static void GameConfiguration_Constructor(
        ref float[] ___DesiredAspectRatios,
        ref float ___TargetFps,
        ref float ___TargetFrameMs,
        ref bool ____canSendTelemetry)
    {
        ___DesiredAspectRatios = [1.7777778f, 1.6f, 1.3333334f, 1.25f, Plugin.MainWidth / (float) Plugin.MainHeight];
        ___TargetFps = Plugin.MaxRefresh;
        ___TargetFrameMs = 1000f / ___TargetFps;
        ____canSendTelemetry = false;
    }


    [HarmonyTranspiler]
    [HarmonyPatch(typeof(DefaultFreeLookCameraModifier), nameof(DefaultFreeLookCameraModifier.Update))]
    public static IEnumerable<CodeInstruction> DefaultFreeLookCameraModifier_Update_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        //removes the field of view adjustment as we postfix patch it. Reason we're removing it altogether, is the game fights us on it, which causes slight fov twitches
        var autoOrbitMethod = AccessTools.Method(typeof(DefaultFreeLookCameraModifier), nameof(DefaultFreeLookCameraModifier.AutoOrbit));
        var codeInstructions = instructions.ToList();
        for (var i = 0; i < codeInstructions.Count; i++)
        {
            if (!codeInstructions[i].Calls(autoOrbitMethod)) continue;
            for (var j = i + 1; j < codeInstructions.Count; j++)
            {
                codeInstructions[j].opcode = OpCodes.Nop;
            }
        }
        codeInstructions.Add(new CodeInstruction(OpCodes.Pop));
        codeInstructions.Add(new CodeInstruction(OpCodes.Ret));
        return codeInstructions.AsEnumerable();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DefaultFreeLookCameraModifier), nameof(DefaultFreeLookCameraModifier.Update))]
    public static void DefaultFreeLookCameraModifier_Update(ref DefaultFreeLookCameraModifier __instance)
    {
        var instance = PlayerController.Instance;
        if (!instance)
        {
            return;
        }
        if (!__instance._brain)
        {
            return;
        }
        if (Camera.main && !CinemachineTransposer.IsPinned)
        {
            var pct = Plugin.FieldOfView.Value / 100f;
            if (__instance._lockFovAtHighEnd)
            {
                __instance._freeLook.m_Lens.FieldOfView = 64.8f * (1f + pct);
            }
            else
            {
                __instance._freeLook.m_Lens.FieldOfView = Mathf.MoveTowards(__instance._freeLook.m_Lens.FieldOfView, 54f * (1f + pct) * __instance._fovCurve.Evaluate(__instance._freeLook.m_YAxis.Value / __instance._freeLook.m_YAxis.m_MaxValue), Time.deltaTime * 40f);
            }
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameConfiguration), nameof(GameConfiguration.AllowTelemetry))]
    public static void GameConfiguration_AllowTelemetry(ref bool allow)
    {
        allow = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.EnableCamera))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.EnableMainCamera))]
    public static void CameraManager_Patches(CameraManager __instance)
    {
        __instance.TempBlitResolution = new Vector2Int(Plugin.MainWidth, Plugin.MainHeight);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameConfiguration), nameof(GameConfiguration.OnGraphicsSettingsApplied))]
    public static void GameConfiguration_OnGraphicsSettingsApplied(GameConfiguration __instance)
    {
        __instance.TargetFps = Plugin.MaxRefresh;
        __instance.TargetFrameMs = 1000f / __instance.TargetFps;
        Time.fixedDeltaTime = 1f / __instance.TargetFps;
    }
}