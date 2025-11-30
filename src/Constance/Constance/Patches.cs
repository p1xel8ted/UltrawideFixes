namespace Constance;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private const string SinaiFilterName = "sinai";

    // Forces video playback to fit vertically and resizes render textures to match screen resolution
    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        if (__instance.name == "video_Desc") return;

        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        if (__instance.renderMode == VideoRenderMode.RenderTexture &&
            __instance.targetTexture &&
            __instance.targetTexture.width != Plugin.CurrentWidth)
        {
            var tex = __instance.targetTexture;
            tex.Release();
            tex.width = Plugin.CurrentWidth;
            tex.height = Plugin.CurrentHeight;
            tex.Create();
            Plugin.Log.LogInfo($"Resized VideoPlayer RenderTexture to {tex.width}x{tex.height}");
        }
    }

    // Skips the splash screen on startup
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CConStartMenu), nameof(CConStartMenu.Start))]
    public static void CConStartMenu_Start()
    {
        ConStaticFlags.ShowSplashScreen = false;
        Plugin.Log.LogInfo("Skipping splash screen");
    }

    // Adds aspect ratio fitters to the journal panel and background for proper ultrawide display
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiPanel_Journal), nameof(CConUiPanel_Journal.Awake))]
    public static void CConUiPanel_Journal_Awake(CConUiPanel_Journal __instance)
    {
        var arf = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = Plugin.NativeAspect;
        Plugin.Log.LogInfo($"Added AspectRatioFitter to Journal panel with native aspect {Plugin.NativeAspect:F4}");

        var bgImage = __instance.transform.Find("Journal_Base");
        if (bgImage)
        {
            var arfBg = bgImage.gameObject.TryAddComponent<AspectRatioFitter>();
            arfBg.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arfBg.aspectRatio = Plugin.CurrentAspect;
            bgImage.gameObject.TryAddComponent<PositionEnforcer>();
            Plugin.Log.LogInfo($"Added AspectRatioFitter to Journal background with current aspect {Plugin.CurrentAspect:F4}");
        }
    }

    // Removes the game's built-in aspect ratio enforcement to allow ultrawide
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConEnforceAspectRatio), nameof(CConEnforceAspectRatio.Awake))]
    public static void CConEnforceAspectRatio_Awake(CConEnforceAspectRatio __instance)
    {
        Plugin.Log.LogInfo($"Destroying CConEnforceAspectRatio component on {__instance.gameObject.name}");
        Object.Destroy(__instance);
    }

    // Replaces hardcoded 16:9 aspect ratio with actual camera aspect for frustum calculations
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(ConCameraScaleUtils), nameof(ConCameraScaleUtils.CalculateFrustumFillBounds))]
    public static IEnumerable<CodeInstruction> ConCameraScaleUtils_CalculateFrustumFillBounds_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);
        for (var i = 0; i < codes.Count; i++)
        {
            if (codes[i].opcode == OpCodes.Ldc_R4 && codes[i].operand is float f && Mathf.Approximately(f, 1.7777778f))
            {
                Plugin.Log.LogInfo("Patching ConCameraScaleUtils: Replacing hardcoded 1.7777778f with Camera.main.aspect");

                codes[i] = new CodeInstruction(OpCodes.Call, AccessTools.PropertyGetter(typeof(Camera), nameof(Camera.main)));
                codes.Insert(i + 1, new CodeInstruction(OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(Camera), nameof(Camera.aspect))));
                break;
            }
        }

        return codes;
    }

    // Forces MoreMountains camera component to use screen ratio instead of fixed aspect (dont think this actually gets used, but just in case)
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MMCameraAspectRatio), nameof(MMCameraAspectRatio.ApplyAspectRatio))]
    public static void MMCameraAspectRatio_ApplyAspectRatio(MMCameraAspectRatio __instance)
    {
        Plugin.Log.LogInfo($"MMCameraAspectRatio detected on {__instance.TargetCamera?.name ?? "unknown"}, forcing ScreenRatio mode");
        __instance.Mode = MMCameraAspectRatio.Modes.ScreenRatio;
    }

    // Unlocks camera X-axis to allow horizontal panning on ultrawide displays
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CConCamBase), nameof(CConCamBase.RestrictRawPosition))]
    public static void CConCamBase_RestrictRawPosition_Prefix(CConCamBase __instance)
    {
        if (__instance.xAxis != ConCameraAxisType.Free)
        {
            Plugin.Log.LogInfo($"CConCamBase: Forcing X-axis from {__instance.xAxis} to Free for ultrawide panning");
            __instance.xAxis = ConCameraAxisType.Free;
        }
    }

    // Adds HUD positioning component to player HUD for ultrawide offset adjustments
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConPlayerHudController), nameof(CConPlayerHudController.Init))]
    public static void CConPlayerHudController_Init(CConPlayerHudController __instance)
    {
        var arf = __instance.gameObject.TryAddComponent<HudAspect>();
        Plugin.Log.LogInfo($"Added HudAspect component to Player HUD '{arf.name}' for ultrawide adjustments");
    }

    // Scales tutorial panel background to fill ultrawide screen
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiPanel_BasicTutorial), nameof(CConUiPanel_BasicTutorial.TryGetNewSelection))]
    [HarmonyPatch(typeof(CConUiPanel_BasicTutorial), nameof(CConUiPanel_BasicTutorial.OpenAnimationTask))]
    public static void CConUiPanel_BasicTutorial_TryGetNewSelection(CConUiPanel_BasicTutorial __instance)
    {
        var bg = __instance.transform.Find("BG");
        if (bg)
        {
            var arfBg = bg.gameObject.TryAddComponent<AspectRatioFitter>();
            arfBg.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arfBg.aspectRatio = Plugin.CurrentAspect;
            Plugin.Log.LogInfo($"Added AspectRatioFitter to {__instance.name} background with current aspect {Plugin.CurrentAspect:F4}");
        }
    }

    // Scales black overlay blockers to cover the full ultrawide screen
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConSelectionLayer_Blocker), nameof(CConSelectionLayer_Blocker.TryGetNewSelection))]
    public static void CConSelectionLayer_Blocker_TryGetNewSelection(CConSelectionLayer_Blocker __instance)
    {
        var image = __instance.GetComponent<Image>();
        if (!image) return;
        if (image.name == "Overlay Black")
        {
            var arf = image.gameObject.TryAddComponent<AspectRatioFitter>();
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = Plugin.CurrentAspect;
            Plugin.Log.LogInfo($"Added AspectRatioFitter to overlay blocker '{image.name}' with current aspect {arf.aspectRatio:F4}");
        }
    }

    // Adds aspect ratio and HUD positioning to shop, elevator, and upgrade panels
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiPanel_Shop), nameof(CConUiPanel_Shop.OpenPanel))]
    [HarmonyPatch(typeof(CConUiPanel_ElevatorSelect), nameof(CConUiPanel_ElevatorSelect.Start))]
    [HarmonyPatch(typeof(CConUiPanel_UpgradeStation), nameof(CConUiPanel_UpgradeStation.OpenPanel))]
    public static void CConUiPanel_Shop_Start(MonoBehaviour __instance)
    {
        var arf = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = Plugin.NativeAspect;
        Plugin.Log.LogInfo($"Added AspectRatioFitter to '{__instance.name}' with current aspect {arf.aspectRatio:F4}");

        var ha = __instance.gameObject.TryAddComponent<HudAspect>();
        ha.rightSideHud = true;
        Plugin.Log.LogInfo($"Added HudAspect component to '{__instance.name}' for ultrawide adjustments");
    }

    // Registers post-processing volumes for runtime configuration
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register), typeof(Volume))]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register), typeof(Volume), typeof(int))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    // Applies configured post-processing settings when a volume is enabled
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    // Sets canvas scalers to expand mode for proper ultrawide UI scaling
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains(SinaiFilterName, StringComparison.OrdinalIgnoreCase)) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    // Adjusts map snapshot tooltips for ultrawide and removes crop marks
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiMapTooltip_Snapshot), nameof(CConUiMapTooltip_Snapshot.LoadSnapshot))]
    public static void CConUiMapTooltip_Snapshot_LoadSnapshot(CConUiMapTooltip_Snapshot __instance)
    {
        DisableCropMarks(__instance);

        var arf = __instance.image?.GetComponent<AspectRatioFitter>();
        if (arf)
        {
            arf.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight; //since tooltip width is fixed
            arf.aspectRatio = Plugin.CurrentAspect;
            Plugin.Log.LogInfo($"Updated AspectRatioFitter on map snapshot tooltip to current aspect {Plugin.CurrentAspect:F4}");
        }
    }

    private static void DisableCropMarks(MonoBehaviour __instance)
    {
        foreach (var crop in __instance.transform.GetComponentsInChildren<Image>().Where(c => c.name.Contains("cropMark", StringComparison.OrdinalIgnoreCase)))
        {
            Plugin.Log.LogInfo($"Disabling crop mark '{crop.name}' on '{__instance.name}'");
            crop.enabled = false;
        }
    }

    // Adjusts zoomed map snapshots for ultrawide and removes crop marks
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiPanel_MapSnapshotZoom), nameof(CConUiPanel_MapSnapshotZoom.OpenPanel))]
    public static void CConUiPanel_MapSnapshotZoom_OpenPanel(CConUiPanel_MapSnapshotZoom __instance)
    {
        DisableCropMarks(__instance);

        var arf = __instance.image.gameObject.TryAddComponent<AspectRatioFitter>();
        if (arf)
        {
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = Plugin.CurrentAspect;
            Plugin.Log.LogInfo($"Updated AspectRatioFitter on map snapshot zoom rawImage to current aspect {Plugin.CurrentAspect:F4}");
        }
    }

    // Removes crop marks from snapshot initialization
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConUiPanel_Snapshot), nameof(ConUiPanel_Snapshot.InitSnapshot))]
    public static void ConUiPanel_Snapshot_InitSnapshot(ConUiPanel_Snapshot __instance)
    {
        DisableCropMarks(__instance);
    }

    // Sets snapshot resolution to screen size and adjusts aspect ratio
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConUiPanel_Snapshot), nameof(ConUiPanel_Snapshot.Awake))]
    public static void ConUiPanel_Snapshot_Awake(ConUiPanel_Snapshot __instance)
    {
        ConUiPanel_Snapshot.SnapshotResolution = new Vector2Int(Plugin.CurrentWidth, Plugin.CurrentHeight);
        Plugin.Log.LogInfo($"Set ConUiPanel_Snapshot.SnapshotResolution to {ConUiPanel_Snapshot.SnapshotResolution.x}x{ConUiPanel_Snapshot.SnapshotResolution.y}");

        var arf = __instance.rawImage?.GetComponent<AspectRatioFitter>();
        if (arf)
        {
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = Plugin.CurrentAspect;
            Plugin.Log.LogInfo($"Updated AspectRatioFitter on snapshot rawImage to current aspect {Plugin.CurrentAspect:F4}");
        }
    }

    // Remove max snapshot count from UI display (e.g., "3/5" becomes "3")
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiCollectableDisplay_Snapshot), nameof(CConUiCollectableDisplay_Snapshot.Replace))]
    public static void CConUiCollectableDisplay_Snapshot_Replace(ref string __result)
    {
        if (!Plugin.UnlimitedPolaroids.Value) return;

        __result = ConMonoBehaviour.SceneRegistry.SnapshotManager._snapshots.Count(s => s.IsUsed).ToString(CultureInfo.CurrentCulture);

        Plugin.Log.LogInfo("Removed max snapshot count from UI display");
    }

    // Allow unlimited snapshots - bypass the Polaroid collectible limit
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConSnapshotManager), nameof(CConSnapshotManager.IsCreateAllowed))]
    [HarmonyPatch(typeof(ConUiPanel_Snapshot), nameof(ConUiPanel_Snapshot.IsSaveAllowed))]
    public static void CConSnapshotManager_IsCreateAllowed(ref bool __result)
    {
        if (!Plugin.UnlimitedPolaroids.Value) return;
        __result = true;
    }

    // Loads additional snapshots beyond the default limit when unlimited polaroids is enabled
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConSnapshotManager), nameof(CConSnapshotManager.LoadMissingSnapshots))]
    public static void CConSnapshotManager_LoadMissingSnapshots(CConSnapshotManager __instance)
    {
        if (!Plugin.UnlimitedPolaroids.Value) return;

        var index = __instance._snapshots.Count;

        while (true)
        {
            var snapshot = new CConSnapshotManager.SnapshotInfo(index);

            if (!snapshot.IsUsed) break;

            __instance._snapshots.Add(snapshot);
            __instance.AddToLevelIndex(snapshot);
            __instance._usedSnapshotCount++;

            index++;
            Plugin.Log.LogInfo($"Restored extra persisted snapshot at index {snapshot.Index}");
        }
    }

    // Returns unlimited available snapshots when the feature is enabled
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConSnapshotManager), nameof(CConSnapshotManager.AvailableSnapshots), MethodType.Getter)]
    public static void CConSnapshotManager_AvailableSnapshots(ref int __result)
    {
        if (!Plugin.UnlimitedPolaroids.Value) return;
        __result = int.MaxValue; // Return a very large number to simulate unlimited snapshots
    }

    // Updates polaroid count display to show actual count instead of x/max format
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiCollectableDisplay), nameof(CConUiCollectableDisplay.Replace))]
    public static void CConUiCollectableDisplay_Replace(CConUiCollectableDisplay __instance, ref string __result)
    {
        if (__instance.name != "txt_Polaroid") return;
        if (!Plugin.UnlimitedPolaroids.Value) return;
        __result = ConMonoBehaviour.SceneRegistry.SnapshotManager._snapshots.Count(s => s.IsUsed).ToString(CultureInfo.CurrentCulture);
    }

    // Adds HUD positioning to top-right prompts for ultrawide offset
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiPlayerHudManager), nameof(CConUiPlayerHudManager.UpdatePlayerHudVisible))]
    public static void CConUiPlayerHudManager_UpdatePlayerHudVisible(CConUiPlayerHudManager __instance)
    {
        var ha = __instance.promptTopRight.gameObject.TryAddComponent<HudAspect>();
        ha.rightSideHud = true;
    }

    //updates the camera icon on the top right to not display a number
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiPlayerHudManager), nameof(CConUiPlayerHudManager.UpdateSnapshotPrompt))]
    public static void CConUiPlayerHudManager_UpdateSnapshotPrompt(CConUiPlayerHudManager __instance)
    {
        if (!Plugin.UnlimitedPolaroids.Value) return;
        __instance.snapshotPromptGroup.alpha = 1;
        __instance.txtSnapshotAvailable.text = ConMonoBehaviour.SceneRegistry.SnapshotManager._snapshots.Count(s => s.IsUsed).ToString(CultureInfo.CurrentCulture);
    }
}