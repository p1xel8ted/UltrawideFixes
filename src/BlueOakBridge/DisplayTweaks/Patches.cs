using BlueOakBridge.Core;
using BlueOakBridge.Core.Camera;
using BlueOakBridge.Environment.Room;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace DisplayTweaks;

[Harmony]
public static class Patches
{
    private const string TopDownHud = "TopDownHud";

    private static bool IsObjectInScene(GameObject obj, string sceneName)
    {
        return obj.scene.name == sceneName;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.Awake))]
    public static void MainCamera_Awake(ref MainCamera __instance)
    {
        MainCamera.OutsideMaxZoom = Plugin.MaxZoom.Value;
        MainCamera.ZoomSpeed = Plugin.ZoomSpeed.Value;
        MainCamera.MaxZoom = Plugin.MaxZoom.Value;
        __instance.OrthographicSize = Plugin.CurrentZoom.Value;
    }

    internal static bool SafeToZoom()
    {
        return Game._instance && Game.CurrentRoom && MainCamera._instance && !Game.CurrentRoom.IsInside;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.FixedUpdate))]
    public static void MainCamera_FixedUpdate()
    {
        if (!SafeToZoom()) return;
        MainCamera._instance.OrthographicSize = Plugin.CurrentZoom.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(RoomExitTrigger), nameof(RoomExitTrigger.OnTriggerEnter2D))]
    public static void RoomExitTrigger_OnTriggerEnter2D()
    {
        if (!SafeToZoom()) return;
        Plugin.CurrentZoom.Value = MainCamera._instance.OrthographicSize;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.NotifyRoomLoaded))]
    public static void MainCamera_NotifyRoomLoaded()
    {
        if (!SafeToZoom()) return;
        MainCamera.Instance.OrthographicSize = Plugin.CurrentZoom.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        if (!IsObjectInScene(__instance.gameObject, TopDownHud)) return;
        Plugin.CanvasScaler = __instance;
    }
}