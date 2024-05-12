namespace CrowCountry.Patches;

[Harmony]
public static class Patches
{
    private readonly static int BaseAlpha = Shader.PropertyToID("baseAlpha");
    private readonly static int ColorMat = Shader.PropertyToID("colorMat");
    private const string PoisonFrame = "poison frame";
    internal static PlayMakerFSM Poison { get; private set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PMFullscreen), nameof(PMFullscreen.SetResolution))]
    public static void PMFullscreen_SetResolution(ref int w, ref int h, ref FullScreenMode fullscreenMode)
    {
        w = Plugin.MainWidth;
        h = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        Plugin.UpdatePoison();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.Start))]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.OnEnable))]
    public static void PlayMakerFSM_OnEnable(PlayMakerFSM __instance)
    {
        if (__instance.name.Equals(PoisonFrame))
        {
            Poison = __instance;
        }

        if (__instance.name.Equals("camera root"))
        {
            var letterBox = __instance.transform.Find("camera parent/Cutscene Camera/letterbox");
            if (letterBox)
            {
                letterBox.gameObject.SetActive(false);
            }
        }
    }

    internal static CrowCountryCamEffect CrowCountryCamEffectInstance { get; private set; }

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
        if (Application.isPlaying)
        {
            Application.targetFrameRate = (int) Plugin.RefreshRate.value;
            QualitySettings.antiAliasing = 8;
        }

        if (Plugin.Pixelation.Value)
        {
            PixelationOn(__instance);
        }
        else
        {
            PixelationOff(__instance);
        }
    }

    internal static void PixelationOff(CrowCountryCamEffect __instance)
    {
        __instance.midBuffer = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.psxRenderTexture = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 24, RenderTextureFormat.ARGB32)
        {
            filterMode = FilterMode.Trilinear
        };
        __instance.camRenderTexture1 = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture2 = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture3 = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture4 = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture5 = new RenderTexture(1, 1, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.crtBlurTexture = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0);
        __instance.fbBuffer = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0)
        {
            filterMode = FilterMode.Trilinear
        };
    }

    internal static void PixelationOn(CrowCountryCamEffect __instance)
    {
        __instance.midBuffer = new RenderTexture(1248, 702, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.psxRenderTexture = new RenderTexture(550, 400, 16, RenderTextureFormat.ARGB32)
        {
            filterMode = FilterMode.Point
        };
        __instance.camRenderTexture1 = new RenderTexture(1248, 702, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture2 = new RenderTexture(624, 351, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture3 = new RenderTexture(416, 234, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture4 = new RenderTexture(550, 400, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture5 = new RenderTexture(1, 1, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.crtBlurTexture = new RenderTexture(1248, 702, 0);
        __instance.fbBuffer = new RenderTexture(416, 234, 0)
        {
            filterMode = FilterMode.Point
        };
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CrowCountryCamEffect), nameof(CrowCountryCamEffect.UpdateColorMatrices))]
    public static void CrowCountryCamEffect_UpdateColorMatrices(CrowCountryCamEffect __instance)
    {
        var brightnessAdjustment = Plugin.CRTEffectBrightness.Value;
        var brightnessVector = new Vector4(brightnessAdjustment, brightnessAdjustment, brightnessAdjustment, 1f);
        __instance.crtBrightnessMat.SetColumn(3, brightnessVector);
        __instance.crtColorMat = __instance.crtBrightnessMat * __instance.crtContrastMat * __instance.crtSaturationMat;
        __instance.crtPostProMaterial.SetMatrix(ColorMat, __instance.crtColorMat);
        __instance.crtPostProMaterial.SetFloat(BaseAlpha, 0f);
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = Plugin.ScreenMatchMode.Value;
    }
}