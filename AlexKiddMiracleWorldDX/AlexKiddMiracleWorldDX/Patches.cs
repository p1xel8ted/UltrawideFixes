using System;
using System.Collections.Generic;
using System.Linq;
using AlexKiddMiracleWorldDX.MonoBehaviours;
using Assets.Scripts.Manager;
using Assets.Scripts.UI;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace AlexKiddMiracleWorldDX;

[HarmonyPatch]
public static class Patches
{
    private const string MoneyAndLife = "Money and Life";
    private const string UsableItemSelector = "Usable Item Selector";
    private const string shop = "shop";
    private const string GlobalVolume = "Global Volume";
    private const string MainMenuBackground = "Menu/Canvas/ScreenFitter/Background";
    private const string PauseMenuOrangeBackground = "GameController/Camera Holder/Main Camera/Inventory Menu/Background_Orange";
    private const string InterstitialMap = "interstitial_map"; 
    private const string Shop = shop;

    private readonly static Dictionary<BoxCollider2D, WriteOnce<float>> BoxColliders = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIProjectionScaler), nameof(UIProjectionScaler.Awake))]
    [HarmonyPatch(typeof(UIProjectionScaler), nameof(UIProjectionScaler.LateUpdate))]
    public static void UIProjectionScaler_Awake(ref UIProjectionScaler __instance)
    {
        if (Plugin.KeepUICentered.Value)
        {
            __instance.targetAspectRatio = Plugin.SimplifiedBaseAspect;
            return;
        }

        __instance.targetAspectRatio = Plugin.SimplifiedMainAspect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Logos), nameof(Logos.Awake))]
    public static void Logos_Patches(ref Logos __instance)
    {
        Singleton<SceneLoader>.Instance.LoadLevel("demo_menu");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(InventoryMenuController), nameof(InventoryMenuController.OnEnable))]
    public static void InventoryMenuController_OnEnable(ref InventoryMenuController __instance)
    {
        __instance.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1f);
        var orangeBackground = GameObject.Find(PauseMenuOrangeBackground);
        if (orangeBackground)
        {
            orangeBackground.transform.localScale = orangeBackground.transform.localScale with {x = Plugin.PositiveScaleFactor};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GMSCanvasScaler), nameof(GMSCanvasScaler.OnEnable))]
    public static void GMSCanvasScaler_OnEnable(ref GMSCanvasScaler __instance)
    {
        var newX = Mathf.RoundToInt(__instance.referenceResolution.y * Plugin.MainAspectRatio);
        __instance.referenceResolution = __instance.referenceResolution with {x = newX};
        __instance.screenMatchMode = GMSCanvasScaler.ScreenMatchMode.Expand;

        var menuBackground = GameObject.Find(MainMenuBackground);
        if (menuBackground)
        {
            menuBackground.transform.localScale = menuBackground.transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneTransitionIn), nameof(SceneTransitionIn.StartTransition))]
    [HarmonyPatch(typeof(SceneTransitionOut), nameof(SceneTransitionOut.StartTransition))]
    public static void SceneTransition_StartTransition(ref SceneTransition __instance)
    {
        __instance.transform.localScale = __instance.transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
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
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(ref Volume __instance)
    {
        if (__instance.name.Equals(GlobalVolume))
        {
            __instance.gameObject.TryAddComponent<VolumeToggler>();
        }
    }

    private readonly static string[] TurnBarsOn = [Shop, InterstitialMap];
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.LateUpdate))]
    public static void PixelPerfectCamera_Patches(ref PixelPerfectCamera __instance)
    {
        if(TurnBarsOn.Any(scene => SceneManager.GetActiveScene().name.Equals(scene, StringComparison.OrdinalIgnoreCase)))
        {
            __instance.cropFrameX = true;
            __instance.cropFrameY = true;
        }
        else
        {
            __instance.cropFrameX = false;
            __instance.cropFrameY = false;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AnimatorSwap), nameof(AnimatorSwap.Awake))]
    public static void AnimatorSwap_Awake(ref AnimatorSwap __instance)
    {
        if (__instance.name.Equals(UsableItemSelector))
        {
            __instance.gameObject.TryAddComponent<HudScaler>();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SpriteSwap), nameof(SpriteSwap.Awake))]
    public static void SpriteSwap_Awake(ref SpriteSwap __instance)
    {
        if (__instance.name.Equals(MoneyAndLife))
        {
            __instance.gameObject.TryAddComponent<HudScaler>();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.Awake))]
    public static void CameraController_Awake(ref CameraController __instance)
    {
        //this fixes the colliders on the edge of the screen that stop the player, from being in the 16:9 position
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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(StateSwap), nameof(StateSwap.Start))]
    public static void StateSwap_Start(ref StateSwap __instance)
    {
        if (!__instance?.gameObject) return;

        //this expands the water sprite to the left on retro level 2
        var retroWater = __instance.gameObject.transform.FindFirstChildByName("Water Top");
        if (retroWater)
        {
            //get the width of the sprite
            var retroWaterWidth = retroWater.GetComponent<SpriteRenderer>().bounds.size.x;
            for (var i = 0; i < 5; i++)
            {
                var newWater = Object.Instantiate(retroWater.gameObject, retroWater.transform.parent);
                var newPosition = newWater.transform.localPosition;
                newPosition.x -= retroWaterWidth * (i + 1); // Move each new water object left by its width times its index (plus one to start after the original)
                newWater.transform.localPosition = newPosition;
            }
        }
        
        //this expands the water sprite to the left on modern level 2 (ignore the level_06, reused object)
        var aw = __instance.gameObject.transform.FindFirstChildByName("level_06_animated_water");
        if (aw)
        {
            //lower it a little, otherwise it appears above the ground
            var position = aw.transform.localPosition;
            position.y -= 0.10f;
            aw.transform.localPosition = position;

            var ps = aw.gameObject.TryAddComponent<PositiveScaler>();
            ps.SetBuffers(0.5f);
        }

        var tree = __instance.gameObject.transform.FindFirstChildByName("level_02_entradilla");
        if (tree)
        {
            tree.gameObject.TryAddComponent<PositiveScaler>();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Parallax), nameof(Parallax.Start))]
    public static void Parallax_Start(ref Parallax __instance)
    {
        var parent = __instance.transform.parent.transform;
        if (Plugin.SuperWide)
        {
            parent.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1);
        }
        else
        {
            parent.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
        }
    }
    

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