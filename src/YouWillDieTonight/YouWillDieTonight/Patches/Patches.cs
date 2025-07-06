using Hazard.Camera;
using Hazard.Menus;
using Hazard.Menus.MainMenu;
using Hazard.UI;
using SpottedZebra.Foundation.Events;
using UnityEngine.Rendering;

namespace YouWillDieTonight.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadingSequence), nameof(LoadingSequence.Start))]
    public static bool LoadingSequence_Start(LoadingSequence __instance)
    {
        __instance.Finished.Invoke();
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuStack), nameof(MenuStack.OpenMenu))]
    public static void MainMenu_OnEnable(MenuStack __instance)
    {
        var exists = __instance.transform.Find("Root/Background/NewBackground");
        if (exists)
        {
            // If the background already exists, we don't need to do anything.
            return;
        }

        var bg = __instance.transform.Find("Root/Background");
        if (bg)
        {
            var image = bg.GetComponent<Image>();
            if (image)
            {
                var clonedTop = Utils.CloneImage(image, bg, "NewBackground", true);
                if (clonedTop)
                {
                    image.enabled = false;
                    clonedTop.rectTransform.sizeDelta = clonedTop.rectTransform.sizeDelta with { x = Screen.width };
                }
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectUtility), nameof(AspectUtility.Awake))]
    public static void AspectUtility_Awake(AspectUtility __instance)
    {
        AspectUtility.wantedAspectRatio = __instance._wantedAspectRatio = Plugin.CurrentAspectRatio;
        __instance.SetCamera();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }

    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeartRateVolumeWeight), nameof(HeartRateVolumeWeight.OnEnable))]
    public static bool HeartRateVolumeWeight_OnEnable(HeartRateVolumeWeight __instance)
    {
        if (Plugin.HeartBeatEffect.Value) return true;
        __instance.heartBeat.UnregisterListener(__instance.onHeartBeat);
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeartRateVolumeWeight), nameof(HeartRateVolumeWeight.Update))]
    public static bool HeartRateVolumeWeight_Update()
    {
        return Plugin.HeartBeatEffect.Value;
    }

    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Plugin.CurrentAspectRatio > Plugin.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }
}