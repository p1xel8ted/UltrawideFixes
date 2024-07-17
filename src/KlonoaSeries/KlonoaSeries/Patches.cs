namespace KlonoaSeries;

[Harmony]
[HarmonyAfter("settings_fix")]
public static class Patches
{
    private readonly static string[] DontDestroy = ["UniverseLib", "BepInEx", "sinai", "ExplorerBehaviour", "UnityExplorer"];
    private static Vector2 MainResolution => new(Plugin.MainWidth, Plugin.MainHeight);
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasChecker), nameof(CanvasChecker.Update))]
    public static void nsPFWLauncher_CanvasChecker_SetBaseSize(CanvasChecker __instance)
    {
        __instance.rectMaskLeft.gameObject.SetActive(false);
        __instance.rectMaskRight.gameObject.SetActive(false);
        __instance.rectMaskUp.gameObject.SetActive(false);
        __instance.rectMaskDown.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(nsPFW.CanvasChecker), nameof(nsPFW.CanvasChecker.Update))]
    public static void nsPFW_CanvasChecker_Update(nsPFW.CanvasChecker __instance)
    {
        __instance.rectMaskLeft.gameObject.SetActive(false);
        __instance.rectMaskRight.gameObject.SetActive(false);
        __instance.rectMaskUp.gameObject.SetActive(false);
        __instance.rectMaskDown.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(nsPFW.CanvasChecker), nameof(nsPFW.CanvasChecker.SetBaseSize))]
    public static void nsPFW_CanvasChecker_SetBaseSize(nsPFW.CanvasChecker __instance)
    {
        __instance.aspect = Plugin.MainAspect;
    }


    internal static void UpdateBeautify()
    {
        foreach (var b in Resources.FindObjectsOfTypeAll<Beautify>())
        {
            b.preset = Plugin.Preset.Value;
            b.sharpen = Plugin.Sharpen.Value;
            b.bloom = Plugin.Bloom.Value;
            b.bloomUltra = false;
            b.bloomIntensity = Plugin.BloomIntensity.Value;
            b._quality = Plugin.Quality.Value;
            b.tonemap = Plugin.Tonemap.Value;
            b.lensDirt = Plugin.LensDirt.Value;
            b.lensDirtIntensity = Plugin.LensDirtIntensity.Value;
            b.dither = Plugin.Dither.Value;
            b.ditherDepth = Plugin.DitherDepth.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Beautify), nameof(Beautify.OnEnable))]
    public static void Beautify_OnEnable(Beautify __instance)
    {
        UpdateBeautify();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(nsPFW.nw4r.g3d.Camera), nameof(nsPFW.nw4r.g3d.Camera.SetPerspective))]
    public static void nsPFW_nw4r_g3d_Camera_SetPerspective(ref nsPFW.nw4r.g3d.Camera __instance, ref float fovy, ref float aspect)
    {
        var baseFov = fovy * Plugin.ScaleFactor;

        if (!Plugin.AtTitleMenu)
        {
            var pct = Plugin.FieldOfView.Value / 100f;
            var newFov = baseFov + baseFov * pct;

            fovy = newFov;
        }
        else
        {
            fovy = baseFov;
        }

        aspect = Plugin.MainAspect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(nsPFW.CanvasChecker), nameof(nsPFW.CanvasChecker.GetAspect))]
    public static void nsPFW_CanvasChecker_GetAspect(ref float __result)
    {
        __result = Plugin.MainAspect;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CanvasScaleAdjuster), nameof(CanvasScaleAdjuster.Start))]
    public static bool App_Klonoa2_CanvasScaleAdjuster_Start()
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Beautify), nameof(Beautify.vignettingAspectRatio), MethodType.Getter)]
    public static void BeautifyEffect_Beautify_vignettingAspectRatio_Getter(ref float __result)
    {
        __result = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Beautify), nameof(Beautify.vignettingAspectRatio), MethodType.Setter)]
    public static void BeautifyEffect_Beautify_vignettingAspectRatio_Setter(ref float value)
    {
        value = 0;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CCamera), nameof(CCamera.Aspect), typeof(float))]
    public static void Camera_Aspect(ref float value)
    {
        value = Plugin.MainAspect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CDisplayInfo), nameof(CDisplayInfo.Aspect), [])]
    public static void CDisplayInfo_Aspect(ref float __result)
    {
        __result = Plugin.MainAspect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CCamera), nameof(CCamera.Aspect), [])]
    public static void Camera_Aspect_Getter(ref float __result)
    {
        __result = Plugin.MainAspect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CWiiConfiguration), nameof(CWiiConfiguration.Aspect), [])]
    public static void CWiiConfiguration_Aspect(ref float __result)
    {
        __result = Plugin.MainAspect;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CDisplayInfo), nameof(CDisplayInfo.Init))]
    public static void CDisplayInfo_Init(ref float aspect, ref uint framerate)
    {
        aspect = Plugin.MainAspect;
        framerate = (uint) Plugin.MaxRefresh;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(nsPFW.nw4r.g3d.Camera), nameof(nsPFW.nw4r.g3d.Camera.SetUnityCamera))]
    public static void nsPFW_nw4r_g3d_Camera_SetUnityCamera(Camera camTarget)
    {
        camTarget.aspect = Plugin.MainAspect;
        camTarget.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        camTarget.rect = new Rect(0, 0, 1, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Scene), nameof(Scene.GetRootGameObjects), [])]
    public static void Scene_GetRootGameObjects(ref GameObject[] __result)
    {
        __result = DontDestroy.Aggregate(__result, (current, str) => current.Where(x => !x.name.Contains(str, StringComparison.OrdinalIgnoreCase)).ToArray());
    }


    private static void UpdateResolution()
    {
        var res = Game.resolutionSize;
        res[res.Length - 1] = MainResolution;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.Awake))]
    public static void App_Klonoa2_GameManager_Awake(GameManager __instance)
    {
        Application.targetFrameRate = Plugin.MaxRefresh;
        __instance.useFastLoad = true;
        Plugin.UpdateDisplay();
        UpdateResolution();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Game), nameof(Game.IsValidUnityScreenResolution))]
    public static void App_Klonoa2_Game_IsValidUnityScreenResolution(ref bool __result)
    {
        UpdateResolution();
        __result = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Global), nameof(Global.IsEnableResolution))]
    public static void nsPFW_Global_IsEnableResolution(ref bool __result)
    {
        UpdateResolution();
        __result = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainController), nameof(MainController.IsEnableResolution))]
    public static void nsPFWLauncher_MainController_IsEnableResolution(ref bool __result)
    {
        UpdateResolution();
        __result = true;
    }
}