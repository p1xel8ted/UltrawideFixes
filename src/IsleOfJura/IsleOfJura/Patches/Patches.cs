using System.Diagnostics;
using Cinemachine;
using IsleOfJura.Helpers;
using IsleOfJura.Misc;
using IsleOfJura.MonoBehaviours;

namespace IsleOfJura.Patches;

[Harmony]
public static class Patches
{
    private static WriteOnce<float> _originalDetailObjectDensity = new();
    private static WriteOnce<float> _originalDetailObjectDistance = new();

    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TransitionWipe), nameof(TransitionWipe.Start))]
    public static void TransitionWipe_Start(TransitionWipe __instance)
    {
        var scaleFactor = Resolutions.CurrentAspect / Resolutions.NativeAspect;
        __instance.transform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.PushStateToUnityCamera))]
    public static void CinemachineBrain_PushStateToUnityCamera(CinemachineBrain __instance, CameraState state)
    {
        var newFov = state.Lens.FieldOfView * Plugin.FieldOfViewMultiplier.Value;
        if (__instance.m_OutputCamera)
        {
            __instance.m_OutputCamera.fieldOfView = newFov;
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsTab), nameof(OptionsTab.Start))]
    [HarmonyPatch(typeof(OptionsTab), nameof(OptionsTab.Awake))]
    [HarmonyPatch(typeof(OptionsTab), nameof(OptionsTab.reflectLanguage))]
    public static void OptionsTab_Start(OptionsTab __instance)
    {
        __instance.screenResDropdown.gameObject.SetActive(false);
        __instance.screenResTitle.text = "Press F1 to change resolution settings.";
        __instance.vSyncToggle.gameObject.SetActive(false);
        __instance.vSyncTitle.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.OnSceneLoaded))]
    public static void GameManager_OnSceneLoaded()
    {
        var force = Screen.width != Resolutions.SelectedResolution.width || Screen.height != Resolutions.SelectedResolution.height || Screen.fullScreenMode != Plugin.FullScreenModeConfig.Value;
        Plugin.UpdateAll(force);
        UpdateGraphics();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsTab), nameof(OptionsTab.onQualityChanged))]
    public static void OptionsTab_onQualityChanged(OptionsTab __instance)
    {
        UpdateGraphics(true);
    }

    internal static void UpdateGraphics(bool refresh = false)
    {
        var terrain = Resources.FindObjectsOfTypeAll<Terrain>().FirstOrDefault();
        if (!terrain) return;

        if (refresh)
        {
            _originalDetailObjectDensity = new WriteOnce<float>();
            _originalDetailObjectDistance = new WriteOnce<float>();
        }

        _originalDetailObjectDensity.Value = terrain.detailObjectDensity;
        _originalDetailObjectDistance.Value = terrain.detailObjectDistance;

        terrain.detailObjectDensity = _originalDetailObjectDensity * Plugin.TerrainDetailObjectDensityMultiplier.Value;
        terrain.detailObjectDistance = _originalDetailObjectDistance * Plugin.TerrainDetailObjectDistanceMultiplier.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraScript), nameof(CameraScript.Start))]
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.Awake))]
    public static void CameraScript_Start()
    {
        var force = Screen.width != Resolutions.SelectedResolution.width || Screen.height != Resolutions.SelectedResolution.height || Screen.fullScreenMode != Plugin.FullScreenModeConfig.Value;
        Plugin.UpdateDisplay(force);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.applyVisualSettings))]
    public static bool SettingsManager_applyVisualSettings(SettingsManager __instance)
    {
        //original game settings
        QualitySettings.vSyncCount = !__instance.settings.vSyncOn ? 0 : 1;
        QualitySettings.SetQualityLevel((int)__instance.settings.qualityLevel);

        //force resolution change
        Plugin.UpdateAll(true);

        UpdateGraphics();
        //dont let original method run
        return false;
    }

    internal static void UpdateScalers()
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = Resolutions.CurrentAspect > Resolutions.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    /// <summary>
    /// Corrects scaling for certain UI components    
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //unity explorer
        if (__instance.name.Contains("sinai")) return;

        switch (__instance.name)
        {
            //the post-processing notifications canvas
            case "MessageCanvas":
                return;
            case "UICanvas":
                LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, true);
                LayoutController.AddLayoutControllerPath(__instance.transform, "ScreenCover", LayoutController.LayoutSize.ForceFullScreen, 0f, true);
                LayoutController.AddLayoutControllerPath(__instance.transform, "BlackImage", LayoutController.LayoutSize.ForceFullScreen, 0f, true);
                break;
        }

        UpdateScalers();

        CanvasScalers.Add(__instance);
    }
}