using System;
using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace AnodeHeart;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private const string Sinai = "sinai";
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.ToLowerInvariant().Contains(Sinai)) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        var newScale = Utils.GetNewScale(__instance.referenceResolution.y);
        __instance.scaleFactor = newScale;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.Load), typeof(Action<ItemType>), typeof(IsItemInteractable))]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.Load), typeof(ItemMenuResult))]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.Load), typeof(IsItemInteractable), typeof(bool), typeof(Monster))]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.LoadInBattle))]
    public static void InventoryHUD_LoadData(ref InventoryHUD __instance)
    {
        var slots = __instance.ItemSlotsContainer;
        var normalWidth = Display.main.systemHeight * 16f / 9f;
        var newScale = Display.main.systemWidth / normalWidth;
        slots.transform.localScale = new Vector3(newScale, 1, 1);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionResolution), nameof(OptionResolution.isResolutionSupported))]
    public static void OptionResolution_isResolutionSupported(ref bool __result)
    {
        __result = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.LateUpdate))]
    public static void CameraController_Start(ref CameraController __instance)
    {
        __instance.SmoothFollow = true;
        __instance.Bounds = new Rect(-10000f, -10000f, 20000f, 20000f);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.orthographicSize), MethodType.Getter)]
    public static void Camera_orthographicSize(ref Camera __instance, ref float __result)
    {
        if (SceneSingleton<CameraController>.m_Instance == null) return;
        __result = SceneSingleton<CameraController>.m_Instance.targetOrthographicSize;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.NormalOrthographicSize), MethodType.Getter)]
    public static void CameraController_NormalOrthographicSize(ref CameraController __instance, ref float __result)
    {
        __result *= Plugin.ConfigZoom.Value;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.targetOrthographicSize), MethodType.Getter)]
    public static void CameraController_targetOrthographicSize(ref CameraController __instance, ref float __result)
    {
        __result *= Plugin.ConfigZoom.Value;
    }
}