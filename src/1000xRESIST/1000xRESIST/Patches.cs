using Cinemachine;
using SunsetVisitor._1000xRESIST;
using SunsetVisitor.Core;
using WanzyeeStudio.Extension;

namespace xRESIST;

[Harmony]
public static class Patches
{
    internal static CanvasScaler ConfigCanvasScaler { get; private set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ModalPrompt), nameof(ModalPrompt.Show))]
    public static void ModalPrompt_Show(ref ModalPrompt __instance)
    {
        //ModalPrompt
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "PromptBackground_Img", LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadMenu), nameof(LoadMenu.OnShown))]
    public static void LoadMenu_OnShown(ref LoadMenu __instance)
    {
        //LoadMenu
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "FullscreenBackground_Img", LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(ChapterSelectMenu), nameof(ChapterSelectMenu.OnShown))]
    public static void ChapterSelectMenu_OnShown(ref ChapterSelectMenu __instance)
    {
        //ChapterSelectMenu
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Background", LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsMenu), nameof(SettingsMenu.Awake))]
    public static void SettingsMenu_OnShown(ref SettingsMenu __instance)
    {
        //SettingsMenu
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "SettingsFullscreenBackground_Img", LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.Awake))]
    public static void MainMenu_Awake(ref MainMenu __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Menu/Background_Img", LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Fade), nameof(Fade.Awake))]
    public static void Fade_Awake(ref Fade __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
    }


    internal class Forcer : MonoBehaviour
    {
        private CinemachineOrbitalTransposer _transposer;
        
        private void OnEnable()
        {
            _transposer = GetComponent<CinemachineOrbitalTransposer>();
        }
        
        private void Update()
        {
            if (_transposer)
            {
                _transposer.m_FollowOffset = _transposer.m_FollowOffset with { x = Plugin.OffsetX.Value };
            }
        }
    }
   

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadingPanel), nameof(LoadingPanel.Awake))]
    public static void LoadingPanel_Awake(ref LoadingPanel __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform.parent, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform.parent, "BackgroundImage", LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("BepInExConfigManager"))
        {
            ConfigCanvasScaler = __instance;
            __instance.uiScaleMode = Plugin.CurrentAspect >= 3.7f ? CanvasScaler.ScaleMode.ScaleWithScreenSize : CanvasScaler.ScaleMode.ConstantPixelSize;
        }

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    // [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnRectTransformDimensionsChange))]
    // [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnTransformParentChanged))]
    // public static void AspectRatioFitter_Patches(AspectRatioFitter __instance)
    // {
    //     __instance.aspectRatio = Plugin.MainAspectRatio;
    // }
    //
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    // [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    // [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    // public static void VideoPlayer_Play(VideoPlayer __instance)
    // {
    //     //if target is a camera
    //     __instance.aspectRatio = VideoAspectRatio.FitVertically;
    //
    //     //if target is a render texture
    //     if (__instance.targetTexture && Plugin.MainAspectRatio > Plugin.NativeAspect)
    //     {
    //         var rawImage = __instance.GetComponent<RawImage>();
    //         if (rawImage)
    //         {
    //             rawImage.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1f);
    //         }
    //     }
    // }
}