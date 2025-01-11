// ReSharper disable Unity.IncorrectMonoBehaviourInstantiation

#if BEPINEX
using Drova;
using Drova.GUI;
using Drova.Vfx;
#endif
using DrovaForsakenKin.MonoBehaviours;
using HarmonyLib;
#if MELONLOADER
using Il2CppDrova;
using Il2CppDrova.GUI;
using Il2CppDrova.Vfx;
#endif
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.Video;

namespace DrovaForsakenKin.Patches;

[Harmony]
public static class Patches
{
    internal static PixelPerfectCamera MainMenuCamera { get; private set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        //if target is a camera
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        //if target is a render texture
        if (__instance.targetTexture)
        {
            var rawImage = __instance.GetComponent<RawImage>();
            if (rawImage)
            {
#if MELONLOADER
                rawImage.transform.localScale = new Vector3(DrovaMelon.NegativeScaleFactor, 1f, 1f);
#endif
#if BEPINEX
                rawImage.transform.localScale = new Vector3(BepInExPlugin.NegativeScaleFactor, 1f, 1f);
#endif
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CamWideSupport), nameof(CamWideSupport.Start))]
    public static void CamWideSupport_OnEnable(CamWideSupport __instance)
    {
        var pp = __instance.GetComponent<PixelPerfectCamera>();
        UpdatePixelPerfectCamera(pp);
    }

    public static readonly List<CanvasScaler> HudScalers = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GUI_HUD), nameof(GUI_HUD.Start))]
    public static void GUI_HUD_Start(GUI_HUD __instance)
    {
#if MELONLOADER
        DrovaMelon.UpdateFixedDeltaTime();
        var scale = DrovaMelon.UIScale.Value;
#endif
#if BEPINEX
        BepInExPlugin.UpdateFixedDeltaTime();
        var scale = BepInExPlugin.UIScale.Value;
#endif

        var scalers = __instance.GetComponentsInChildren<CanvasScaler>();
        foreach (var scaler in scalers)
        {
            HudScalers.Add(scaler);
            scaler.scaleFactor = scale;
        }
    }

    private static readonly WriteOnceVector2 OriginalWorldSize = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FloorFogBhvr), nameof(FloorFogBhvr.Awake))]
    public static void FloorFogBhvr_Awake(FloorFogBhvr __instance)
    {
        FloorFogInstance = __instance;
        OriginalWorldSize.Value = __instance._worldSize;
        
        
#if MELONLOADER
        var scale = DrovaMelon.PositiveScaleFactor;
#endif
#if BEPINEX
       var scale = BepInExPlugin.PositiveScaleFactor;
#endif
        
        var newX = Mathf.RoundToInt(OriginalWorldSize.Value.x * scale * 100);
        __instance._worldSize = __instance._worldSize with { x = newX };
    }

    internal static FloorFogBhvr FloorFogInstance { get; set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(FloorFogBhvr), nameof(FloorFogBhvr.CreatePatchAt))]
    public static bool FloorFogBhvr_CreatePatchAt(FloorFogBhvr __instance)
    {
        FloorFogInstance = __instance;
        
#if MELONLOADER
        var run = DrovaMelon.RemoveFogLayer.Value;
#endif
#if BEPINEX
        var run = BepInExPlugin.RemoveFogLayer.Value;
        
#endif
        return !run;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(FloorFogBhvr), nameof(FloorFogBhvr.UpdateFloorFog))]
    public static void FloorFogBhvr_UpdateFloorFog(FloorFogBhvr __instance, ref float dt, ref float percent)
    {
        FloorFogInstance = __instance;
#if MELONLOADER
        var run = DrovaMelon.RemoveFogLayer.Value;
#endif
#if BEPINEX
        var run = BepInExPlugin.RemoveFogLayer.Value;
        
        
#endif
        if (!run) return;

        dt = 0;
        percent = 0;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_OnEnable(PixelPerfectCamera __instance)
    {
        UpdatePixelPerfectCamera(__instance);
    }

    private static void UpdatePixelPerfectCamera(PixelPerfectCamera pp)
    {
        pp.cropFrameX = false;
        pp.cropFrameY = false;

#if MELONLOADER
        pp.refResolutionX = Mathf.RoundToInt(pp.refResolutionY * DrovaMelon.MainAspect);
#endif
#if BEPINEX
        pp.refResolutionX = Mathf.RoundToInt(pp.refResolutionY * BepInExPlugin.MainAspect);
#endif


        pp.cropFrame = PixelPerfectCamera.CropFrame.None;
        if (pp.name != "WorldCam_Extra") return;
        MainMenuCamera = pp;
#if MELONLOADER
        if (DrovaMelon.ConstrainMainMenu.Value)
        {
            pp.cropFrame = PixelPerfectCamera.CropFrame.Pillarbox;
        }
#endif
#if BEPINEX
        if (BepInExPlugin.ConstrainMainMenu.Value)
        {
            pp.cropFrame = PixelPerfectCamera.CropFrame.Pillarbox;
        }
#endif
    }
}