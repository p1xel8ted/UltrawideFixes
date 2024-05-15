namespace CrowCountry.Patches;

[Harmony]
public static class Patches
{
    private const string PoisonFrame = "poison frame";
    private readonly static int ColorMat = Shader.PropertyToID("colorMat");
    private readonly static int BlurTex = Shader.PropertyToID("_BlurTex");

    private static bool PauseCanvasScaled;
    internal static PlayMakerFSM Poison { get; private set; }

    internal static CrowCountryCamEffect CrowCountryCamEffectInstance { get; private set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIPixelate), nameof(UIPixelate.OnEnable))]
    public static void UIPixelate_OnEnable(UIPixelate __instance)
    {
        var rect = __instance.GetComponent<RectTransform>();
        if (rect && __instance.name.Equals("bg main", StringComparison.OrdinalIgnoreCase))
        {
            var x = rect.sizeDelta.x * Plugin.ScaleFactor;
            var y = rect.sizeDelta.y * Plugin.ScaleFactor;
            rect.sizeDelta = new Vector2(x, y);
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(PMFullscreen), nameof(PMFullscreen.SetResolution))]
    public static void PMFullscreen_SetResolution(ref int w, ref int h, ref FullScreenMode fullscreenMode)
    {
        w = Plugin.MainWidth;
        h = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        Plugin.UpdatePoison();
        if (CrowCountryCamEffectInstance)
        {
            PixelationAdjust(CrowCountryCamEffectInstance);
            CrowCountryCamEffectInstance.UpdateColorMatrices();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.Start))]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.OnEnable))]
    public static void PlayMakerFSM_OnEnable(PlayMakerFSM __instance)
    {
        if (__instance.name.Equals(PoisonFrame, StringComparison.OrdinalIgnoreCase))
        {
            Poison = __instance;
        }
        
        if (__instance.name.Equals("ItemAction (3D items)", StringComparison.OrdinalIgnoreCase))
        {
            var onOff = __instance.transform.GetChild(0);
            onOff.gameObject.TryAddComponent<CameraFoV>();
        }
        
        if (__instance.name.Equals("Tips (Background)", StringComparison.OrdinalIgnoreCase))
        {
            var onOff = __instance.transform.GetChild(0);
          onOff.gameObject.TryAddComponent<CameraFoV>();
        }

        if (__instance.name.Equals("camera root", StringComparison.OrdinalIgnoreCase))
        {
            var letterBox = __instance.transform.Find("camera parent/Cutscene Camera/letterbox");
            if (letterBox)
            {
                letterBox.gameObject.SetActive(false);
            }
        }
        
        if (__instance.name.Equals("Tips", StringComparison.OrdinalIgnoreCase))
        {
            __instance.transform.localScale = __instance.transform.localScale with {x = 0.9f, y = 0.9f};
        }

        if (CrowCountryCamEffectInstance)
        {
            PixelationAdjust(CrowCountryCamEffectInstance);
            CrowCountryCamEffectInstance.UpdateColorMatrices();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CrowCountryCamEffect), nameof(CrowCountryCamEffect.OnRenderImage))]
    public static void CrowCountryCamEffect_OnRenderImage(CrowCountryCamEffect __instance)
    {
        CrowCountryCamEffectInstance = __instance;

        __instance.enableCRTBlurFilter = Plugin.CRTEffect.Value;
        __instance.enableCRTPostFilter = Plugin.CRTEffect.Value;

        __instance.enablePSXFilter = Plugin.PSXEffect.Value;

        __instance.enableSFBFilter = Plugin.FlashbackEffect.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CrowCountryCamEffect), nameof(CrowCountryCamEffect.Awake))]
    public static void CrowCountryCamEffect_Awake(CrowCountryCamEffect __instance)
    {
        CrowCountryCamEffectInstance = __instance;

        if (Application.isPlaying)
        {
            Application.targetFrameRate = (int) Plugin.RefreshRate.value;
        }

        PixelationAdjust(__instance);
    }


internal static void PixelationAdjust(CrowCountryCamEffect __instance)
{
    QualitySettings.antiAliasing = Plugin.PixelationAmount.Value > 0 ? 0 : 4;

    ReleaseRenderTexture(ref __instance.midBuffer);
    ReleaseRenderTexture(ref __instance.psxRenderTexture);
    ReleaseRenderTexture(ref __instance.camRenderTexture1);
    ReleaseRenderTexture(ref __instance.camRenderTexture2);
    ReleaseRenderTexture(ref __instance.camRenderTexture3);
    ReleaseRenderTexture(ref __instance.camRenderTexture4);
    ReleaseRenderTexture(ref __instance.camRenderTexture5);
    ReleaseRenderTexture(ref __instance.crtBlurTexture);
    ReleaseRenderTexture(ref __instance.fbBuffer);
    
    __instance.midBuffer = new RenderTexture(Adjust(1248), Adjust(702, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
    __instance.psxRenderTexture = new RenderTexture(Adjust(550), Adjust(400, true), 16, RenderTextureFormat.ARGB32)
    {
        filterMode = Plugin.PixelationAmount.Value == 0 ? FilterMode.Trilinear : FilterMode.Point
    };
    __instance.camRenderTexture1 = new RenderTexture(Adjust(1248), Adjust(702, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
    __instance.camRenderTexture2 = new RenderTexture(Adjust(624), Adjust(351, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
    __instance.camRenderTexture3 = new RenderTexture(Adjust(416), Adjust(234, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
    __instance.camRenderTexture4 = new RenderTexture(Adjust(550), Adjust(400, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
    __instance.camRenderTexture5 = new RenderTexture(1, 1, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
    __instance.crtBlurTexture = new RenderTexture(Adjust(1248), Adjust(702, true), 0);
    __instance.fbBuffer = new RenderTexture(Adjust(416), Adjust(234, true), 0)
    {
        filterMode = Plugin.PixelationAmount.Value == 0 ? FilterMode.Trilinear : FilterMode.Point
    };
    
    __instance.UpdateColorMatrices();
    return;
    
    void ReleaseRenderTexture(ref RenderTexture rt)
    {
        if (!rt) return;
        rt.Release();
        rt = null;
    }
}


    private static int Adjust(int value, bool height = false)
    {
        return Plugin.PixelationAmount.Value switch
        {
            0 => height ? Plugin.MainHeight : Plugin.MainWidth,
            1 =>
                //100% resolution increase
                Mathf.RoundToInt(value * 2),
            2 =>
                //75% resolution increase
                Mathf.RoundToInt(value * 1.75f),
            3 =>
                // 50% resolution increase
                Mathf.RoundToInt(value * 1.5f),
            4 =>
                // 25% resolution increase
                Mathf.RoundToInt(value * 1.25f),
            _ => value
        };
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CrowCountryCamEffect), nameof(CrowCountryCamEffect.UpdateColorMatrices))]
    public static void CrowCountryCamEffect_UpdateColorMatrices(CrowCountryCamEffect __instance)
    {
        var brightnessAdjustment = Plugin.CRTEffectBrightness.Value;
        var brightnessVector = new Vector4(brightnessAdjustment, brightnessAdjustment, brightnessAdjustment, 1f);

        var contractAdjustment = Plugin.CRTEffectContrast.Value;
        var contrastVector = new Vector4(contractAdjustment, contractAdjustment, contractAdjustment, 1f);

        var saturationAdjustment = Plugin.CRTEffectSaturation.Value;
        var saturationVector = new Vector4(saturationAdjustment, saturationAdjustment, saturationAdjustment, 1f);

        __instance.crtBrightnessMat.SetColumn(3, brightnessVector);
        __instance.crtContrastMat.SetColumn(3, contrastVector);
        __instance.crtSaturationMat.SetColumn(3, saturationVector);

        __instance.crtColorMat = __instance.crtBrightnessMat * __instance.crtContrastMat * __instance.crtSaturationMat;

        __instance.crtPostProMaterial.SetTexture(BlurTex, __instance.crtBlurTexture);
        __instance.crtPostProMaterial.SetMatrix(ColorMat, __instance.crtColorMat);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnDisable))]
    public static void CanvasScaler_OnDisable(CanvasScaler __instance)
    {
        if (__instance.name.Equals("UI Canvas Inventory OFF", StringComparison.OrdinalIgnoreCase))
        {
            Utils.DisablePillarBoxing();
            Plugin.UpdateCamera(SceneManager.GetActiveScene().name);
        }
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (!PauseCanvasScaled && __instance.name.Equals("UI Canvas Pause OFF", StringComparison.OrdinalIgnoreCase))
        {
            var bg = __instance.transform.Find("child Pause UI/UI Pause BG/bg/fg");
            if (bg)
            {
                PauseCanvasScaled = true;
                bg.transform.localScale *= Plugin.ScaleFactor;
            }
        }

        if (__instance.name.Equals("Canvas", StringComparison.OrdinalIgnoreCase))
        {
            var black = __instance.transform.Find("menu cover (ON)/Image");
            if (black)
            {
                black.gameObject.SetActive(false);
            }
        }

        if (__instance.name.Equals("UI Canvas Inventory OFF", StringComparison.OrdinalIgnoreCase))
        {
            Utils.EnablePillarBoxing(); //this is to cover the edges at superwide+
            if (Camera.main)
            {
                Camera.main.fieldOfView = 10f;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_Handle(CanvasScaler __instance)
    {
        __instance.screenMatchMode = Plugin.ScreenMatchMode.Value;
    }
}