namespace NeonInferno.Patches;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private const int NativeViewportWidth = 424;
    private const float NativeViewportWidthFloat = 424f;
    private const string SinaiFilterName = "sinai";
    private const string SteamBottomPath = "SteamBottom";
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];


    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroController), nameof(IntroController.Start))]
    private static bool IntroController_Start()
    {
        TransitionManager.ChangeScene(TransitionManager.SceneID.TitleScreen, false, 0, 0);
        AudioManager.FadeOutMusic(0);
        AudioManager.StopAmbientSounds();
        AudioManager.StopLongSounds();
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraSingleton), nameof(CameraSingleton.Awake))]
    public static void CameraSingleton_Awake(CameraSingleton __instance)
    {
        var mainRectY = __instance.mainRect.sizeDelta.y;
        __instance.mainRect.sizeDelta = new Vector2(mainRectY * Plugin.MainAspectRatio, mainRectY);

        var cameraBounds = __instance.GetComponentInChildren<BoxCollider>();
        if (!cameraBounds) return;

        var ogSize = cameraBounds.size.x;
        var newSize = ogSize * Plugin.PositiveScaleFactor;
        cameraBounds.size = cameraBounds.size with { x = newSize };

        Plugin.Log.LogInfo($"Scaled CameraSingleton BoxCollider width by {Plugin.PositiveScaleFactor}x (from {ogSize} to {newSize})");
    }

    private static readonly WriteOnce<float> OverlayOriginalScaleX = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameOver), nameof(GameOver.Start))]
    [HarmonyPatch(typeof(GameOver), nameof(GameOver.OnRuntimeMethodLoad))]
    public static void GameOver_OnEnable(GameOver __instance)
    {
        if (__instance.Overlay)
        {
            OverlayOriginalScaleX.Value = __instance.Overlay.transform.localScale.x;
            __instance.Overlay.transform.localScale = __instance.Overlay.transform.localScale with
            {
                x = OverlayOriginalScaleX * Plugin.PositiveScaleFactor
            };
        }
    }

    private static readonly WriteOnce<float> SteamOriginalScaleX = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameSettings), nameof(GameSettings.Awake))]
    [HarmonyPatch(typeof(GameSettings), nameof(GameSettings.OnRuntimeMethodLoad))]
    public static void GameSettings_OnEnable(GameSettings __instance)
    {
        var steamBottom = __instance.transform.Find(SteamBottomPath);
        if (steamBottom)
        {
            SteamOriginalScaleX.Value = steamBottom.localScale.x;
            steamBottom.localScale = steamBottom.localScale with
            {
                x = SteamOriginalScaleX * Plugin.PositiveScaleFactor
            };
        }
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(SetBoundsWhenCrossed), nameof(SetBoundsWhenCrossed.TestPoint))]
    public static IEnumerable<CodeInstruction> TestPoint_Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var codes = new List<CodeInstruction>(instructions);
        var getViewportWidthMethod = AccessTools.Method(typeof(Patches), nameof(GetViewportWidthInt));

        for (var i = 0; i < codes.Count; i++)
        {
            if (codes[i].opcode == OpCodes.Ldc_I4 && codes[i].OperandIs(NativeViewportWidth))
            {
                Plugin.Log.LogInfo($"Found hardcoded viewport width {NativeViewportWidth} in {__originalMethod.Name} - replacing with dynamic calculation");
                codes[i] = new CodeInstruction(OpCodes.Call, getViewportWidthMethod);
            }
        }

        return codes.AsEnumerable();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(SetBoundsWhenCrossed), nameof(SetBoundsWhenCrossed.Start))]
    public static void Start_Postfix(SetBoundsWhenCrossed __instance)
    {
        var boxCollider = __instance.GetComponent<BoxCollider>();
        if (!boxCollider) return;

        var ogSize = boxCollider.size.x;
        var scaleFactor = Plugin.PositiveScaleFactor;
        var newSize = ogSize * scaleFactor;
        boxCollider.size = boxCollider.size with { x = newSize };

        Plugin.Log.LogInfo($"Scaled SetBoundsWhenCrossed BoxCollider width by {scaleFactor}x (from {ogSize} to {newSize})");
    }

    private static int GetViewportWidthInt()
    {
        var ultrawideWidth = Mathf.RoundToInt(NativeViewportWidth * Plugin.PositiveScaleFactor);
        return ultrawideWidth;
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(ObjectUtil), nameof(ObjectUtil.GetCameraBounds))]
    [HarmonyPatch(typeof(ObjectUtil), nameof(ObjectUtil.IsPointOnscreen))]
    public static IEnumerable<CodeInstruction> GetCameraBounds_Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var codes = new List<CodeInstruction>(instructions);
        var getViewportWidthMethod = AccessTools.Method(typeof(Patches), nameof(GetViewportWidthFloat));

        for (var i = 0; i < codes.Count; i++)
        {
            if (codes[i].opcode == OpCodes.Ldc_R4 && codes[i].OperandIs(NativeViewportWidthFloat))
            {
                Plugin.Log.LogInfo($"Found hardcoded viewport width {NativeViewportWidthFloat} in {__originalMethod.Name} - replacing with dynamic calculation");
                codes[i] = new CodeInstruction(OpCodes.Call, getViewportWidthMethod);
            }
        }

        return codes.AsEnumerable();
    }



    [HarmonyPostfix]
    [HarmonyPatch(typeof(S1PreCutscene), nameof(S1PreCutscene.Start))]
    public static void S1PreCutscene_Start(S1PreCutscene __instance)
    {
      var dateTimeBackground = GameObject.Find("DateTimeShot/Background");
        if (dateTimeBackground.transform)
        {
            dateTimeBackground.transform.localScale = dateTimeBackground.transform.localScale with { x = 500 };
        }
    }


    private static float GetViewportWidthFloat()
    {
        return NativeViewportWidthFloat * Plugin.PositiveScaleFactor;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains(SinaiFilterName)) return;

        CanvasScalers.Add(__instance);
        UpdateScalers(Plugin.MainAspectRatio);
    }


    internal static void UpdateScalers(float aspect)
    {
        var isUltrawide = aspect > Plugin.NativeAspect;

        foreach (var scaler in CanvasScalers)
        {
            if (!scaler) continue;

            var scalerId = scaler.GetInstanceID();

            if (!OriginalScreenMatchModes.TryGetValue(scalerId, out var originalMode))
            {
                originalMode = scaler.screenMatchMode;
                OriginalScreenMatchModes[scalerId] = originalMode;
            }

            scaler.screenMatchMode = isUltrawide ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    internal static void CleanupDestroyedScalers()
    {
        CanvasScalers.RemoveAll(scaler => !scaler);
        
        var activeIds = new HashSet<int>(CanvasScalers.Where(s => s).Select(s => s.GetInstanceID()));
        var deadIds = OriginalScreenMatchModes.Keys.Where(id => !activeIds.Contains(id)).ToList();

        foreach (var id in deadIds)
        {
            OriginalScreenMatchModes.Remove(id);
        }
    }
}