using System.Collections.Generic;
using System.Linq;
using AlexKiddMiracleWorldDX.Constants;
using AlexKiddMiracleWorldDX.LevelFixes;
using AlexKiddMiracleWorldDX.Misc;
using AlexKiddMiracleWorldDX.MonoBehaviours;
using Assets.Scripts.Manager;
using Assets.Scripts.UI;
using Game2DWaterKit;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

namespace AlexKiddMiracleWorldDX;

[HarmonyPatch]
public static class Patches
{
   

    private readonly static Dictionary<BoxCollider2D, WriteOnce<float>> BoxColliders = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIProjectionScaler), nameof(UIProjectionScaler.Awake))]
    [HarmonyPatch(typeof(UIProjectionScaler), nameof(UIProjectionScaler.LateUpdate))]
    public static void UIProjectionScaler_Awake(ref UIProjectionScaler __instance)
    {
        __instance.targetAspectRatio = Plugin.SimplifiedMainAspect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Logos), nameof(Logos.Awake))]
    public static void Logos_Patches(ref Logos __instance)
    {
        Singleton<SceneLoader>.Instance.LoadLevel(Levels.main_menu);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GMSCanvasScaler), nameof(GMSCanvasScaler.OnEnable))]
    public static void GMSCanvasScaler_OnEnable(ref GMSCanvasScaler __instance)
    {
        var newX = Mathf.RoundToInt(__instance.referenceResolution.y * Plugin.MainAspectRatio);
        __instance.referenceResolution = __instance.referenceResolution with {x = newX};
        __instance.screenMatchMode = GMSCanvasScaler.ScreenMatchMode.Expand;
        
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneTransitionIn), nameof(SceneTransitionIn.StartTransition))]
    [HarmonyPatch(typeof(SceneTransitionOut), nameof(SceneTransitionOut.StartTransition))]
    public static void SceneTransition_StartTransition(ref SceneTransition __instance)
    {
        //scales the transition screens to the fill the view
        Scalers.AddPositiveScaler(__instance.transform.gameObject, updateEnabled: false, forceYScale: true);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        var newX = Mathf.RoundToInt(__instance.referenceResolution.x * Plugin.MainAspectRatio);
        __instance.referenceResolution = __instance.referenceResolution with {x = newX};
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.LateUpdate))]
    public static void PixelPerfectCamera_Patches(ref PixelPerfectCamera __instance)
    {
        __instance.cropFrameX = true;
        __instance.cropFrameX = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AnimatorSwap), nameof(AnimatorSwap.Awake))]
    public static void AnimatorSwap_Awake(ref AnimatorSwap __instance)
    {
        // adds the hud move to the top right UI component
        Scalers.AddHudMover(__instance.gameObject, Const.UsableItemSelector);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SpriteSwap), nameof(SpriteSwap.Awake))]
    public static void SpriteSwap_Awake(ref SpriteSwap __instance)
    {
        // adds the hud move to the top left UI component
        Scalers.AddHudMover(__instance.gameObject, Const.MoneyAndLife);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Game2DWater), nameof(Game2DWater.InitializeModules))]
    public static void Game2DWater_InitializeModules(ref Game2DWater __instance)
    {
        //ocean and/or lake scenes use this for water; this expands it to fill the view
        Scalers.AddPositiveScaler(__instance.transform.parent.gameObject, updateEnabled: false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.Awake))]
    public static void CameraController_Awake(ref CameraController __instance)
    {
        //this fixes the colliders on the edge of the screen that stop the player, from being in the 16:9 position
        var wallBox = GameObject.Find(Const.Wall);
        if (wallBox)
        {
            var boxCollider = wallBox.GetComponent<BoxCollider2D>();

            var writeOnce = new WriteOnce<float>
            {
                Value = boxCollider.offset.x
            };

            BoxColliders.TryAdd(boxCollider, writeOnce);

            var newX = BoxColliders[boxCollider].Value * Plugin.PositiveScaleFactor;
            boxCollider.offset = boxCollider.offset with {x = newX};
        }


        var boxColliders = __instance.GetComponents<BoxCollider2D>();
        foreach (var boxCollider in boxColliders)
        {
            var writeOnce = new WriteOnce<float>
            {
                Value = boxCollider.offset.x
            };

            BoxColliders.TryAdd(boxCollider, writeOnce);

            var newX = BoxColliders[boxCollider].Value * Plugin.PositiveScaleFactor;
            boxCollider.offset = boxCollider.offset with {x = newX};

            var cameraLimit = __instance.GetComponentInChildren<CameraLimit>();
            if (cameraLimit)
            {
                cameraLimit.enabled = false;
            }
        }
    }
    
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(StateSwap), nameof(StateSwap.Start))]
    // public static void StateSwap_Start(ref StateSwap __instance)
    // {
    //   
    // }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraResolutionController), nameof(CameraResolutionController.Awake))]
    [HarmonyPatch(typeof(CameraResolutionController), nameof(CameraResolutionController.Start))]
    public static void CanvasScaler_OnEnable(ref CameraResolutionController __instance)
    {
        __instance.targetRatio = Plugin.SimplifiedMainAspect;
        __instance.width = Plugin.MainWidth;
        __instance.heigth = Plugin.MainHeight;
        __instance.AdjustFixedRatio(Plugin.MainAspectRatio);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ResolutionController), nameof(ResolutionController.GetOptionsValues))]
    private static bool ResolutionController_GetOptionsValues(ref ResolutionController __instance)
    {
        __instance.FullscreenToggle.Toggle(Screen.fullScreenMode == FullScreenMode.FullScreenWindow);

        var list = Screen.resolutions
            .Select(r => $"{r.width} x {r.height}")
            .Distinct()
            .Select(rv => new AbstractCustomSelector.TextValue {text = rv, value = rv})
            .ToList();

        list.Add(new AbstractCustomSelector.TextValue {text = $"{Plugin.MainWidth} x {Plugin.MainHeight}", value = $"{Plugin.MainWidth} x {Plugin.MainHeight}"});

        __instance.ResolutionSelector.Items = list;
        __instance.ResolutionSelector.UpdateSelectedItem($"{Plugin.MainWidth} x {Plugin.MainHeight}");

        return false;
    }

}