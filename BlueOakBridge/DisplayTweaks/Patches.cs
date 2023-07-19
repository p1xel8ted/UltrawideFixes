using BlueOakBridge.Core;
using BlueOakBridge.Core.Camera;
using BlueOakBridge.Environment.Room;
using BlueOakBridge.UserInterface.TopDownHud;
using BlueOakBridge.UserInterface.TopDownHud.Inventory.Hotbar;
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

    private static string GetGameObjectPath(GameObject obj)
    {
        var path = "/" + obj.name;
        while (obj.transform.parent != null)
        {
            obj = obj.transform.parent.gameObject;
            path = "/" + obj.name + path;
        }

        return path;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.Awake))]
    public static void MainCamera_Awake(ref MainCamera __instance)
    {
        MainCamera.OutsideMaxZoom = Plugin.MaxZoom.Value;
        MainCamera.ZoomSpeed = Plugin.ZoomSpeed.Value;
        MainCamera.MaxZoom = Plugin.MaxZoom.Value;
    }

    internal static bool SafeToZoom()
    {
        return Game._instance != null && Game.CurrentRoom != null && MainCamera._instance != null;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.FixedUpdate))]
    public static void MainCamera_FixedUpdate()
    {
        if (!SafeToZoom()) return;
        if (Game.CurrentRoom.IsInside) return;
        Plugin.CurrentZoom.Value = MainCamera._instance.OrthographicSize;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(RoomExitTrigger), nameof(RoomExitTrigger.OnTriggerEnter2D))]
    public static void RoomExitTrigger_OnTriggerEnter2D()
    {
        if (!SafeToZoom()) return;
        if (Game.CurrentRoom.IsInside) return;
        Plugin.Log.LogWarning($"Backing up current zoom...{MainCamera._instance.OrthographicSize}");
        Plugin.CurrentZoom.Value = MainCamera._instance.OrthographicSize;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.NotifyRoomLoaded))]
    public static void MainCamera_NotifyRoomLoaded()
    {
        if (!SafeToZoom()) return;
        if (Game.CurrentRoom.IsInside) return;
        Plugin.Log.LogWarning("Restoring zoom level...");
        MainCamera._instance.OrthographicSize = Plugin.CurrentZoom.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (!IsObjectInScene(__instance.gameObject, TopDownHud)) return;
        Plugin.CanvasScaler = __instance;
        Plugin.Log.LogWarning("Found CanvasScaler in " + GetGameObjectPath(__instance.gameObject));
    }
}