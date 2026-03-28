namespace ProjectSongbird;

/// <summary>
/// All Harmony patches for ultrawide support. Forces Hor+ gate fit on all cameras, enforces native resolution,
/// suppresses letterboxing, corrects aspect ratio on game settings/cameras, scales UI backgrounds,
/// and applies runtime FOV changes from ConfigManager.
/// </summary>
[Harmony]
public static class Patches
{
    /// <summary>Set when the FOV config slider changes, consumed in FOVController.Update to apply on the main thread.</summary>
    internal static volatile bool FovChanged;

    // --- Resolution Enforcement ---

    /// <summary>
    /// Blocks non-native resolution calls and allows native resolution through only when the screen
    /// hasn't already been set. Prevents the game from overriding the ultrawide resolution.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static bool Screen_SetResolution(ref int width, ref int height)
    {
        if (width != DisplayMetrics.MainWidth || height != DisplayMetrics.MainHeight) return false;
        if (Screen.width == DisplayMetrics.MainWidth && Screen.height == DisplayMetrics.MainHeight) return false;
        Plugin.Logger.LogInfo($"[Screen.SetResolution]: Allowing {width}x{height} -> Scene: {Utils.CurrentScene}.");
        return true;
    }

    // --- UI Scaling ---

    /// <summary>
    /// Adds an <see cref="AspectRatioFitter"/> to the film scratches overlay so it covers the full ultrawide display.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(FilmScratches), nameof(FilmScratches.Start))]
    public static void FilmScratches_Start(FilmScratches __instance)
    {
        __instance.gameObject.AddAspectRatioFitter(__instance);
    }

    /// <summary>
    /// Adds an <see cref="AspectRatioFitter"/> to the blink overlay so it covers the full ultrawide display.
    /// Filters by name to avoid fitting non-UI trigger colliders that also use <c>BlinkTrigger</c>.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BlinkTrigger), nameof(BlinkTrigger.Start))]
    public static void BlinkTrigger_Start(BlinkTrigger __instance)
    {
        if (__instance.blink && __instance.blink.name.Contains("blink", StringComparison.OrdinalIgnoreCase))
        {
            __instance.blink.AddAspectRatioFitter(__instance);
        }
    }


    /// <summary>
    /// Adds an <see cref="AspectRatioFitter"/> to the inventory wheel background so it doesn't stretch on ultrawide.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(InventoryWheel), nameof(InventoryWheel.Start))]
    public static void InventoryWheel_Start(InventoryWheel __instance)
    {
        if (!__instance.background)
        {
            __instance.LogWarning("background field is null");
            return;
        }

        __instance.background.gameObject.AddAspectRatioFitter(__instance);
    }

    /// <summary>
    /// Adds an <see cref="AspectRatioFitter"/> to the death screen black overlay so it covers the full ultrawide display.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(DeathScreen), nameof(DeathScreen.Start))]
    public static void DeathScreen_Start(DeathScreen __instance)
    {
        if (!__instance.blackScreen)
        {
            __instance.LogWarning("blackScreen field is null");
            return;
        }
        __instance.blackScreen.AddAspectRatioFitter(__instance);
    }

    /// <summary>
    /// Sets all CanvasScalers to <see cref="CanvasScaler.ScreenMatchMode.Expand"/> so UI scales correctly on ultrawide.
    /// For the HUD canvas, also scales damage vignette and camera lens overlays to fill the wider viewport.
    /// Disables any letterbox GameObjects found in the canvas hierarchy.
    /// Skips UnityExplorer/UniverseLib canvases.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase) ||
            __instance.name.Contains("UniverseLib", StringComparison.OrdinalIgnoreCase)) return;


        if (__instance.name == "HUD")
        {
            var damage = __instance.transform.FindChild("All UI/Damage");
            if (damage)
            {
                damage.gameObject.TryAddComponent<ScaleEnforcer>();
            }

            __instance.transform.ScaleTransform(__instance, "All UI/Camera Lens/Intro Black");
            __instance.transform.ScaleTransform(__instance, "All UI/Camera Lens/Outro Black");
        }

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        __instance.transform.DisableAll(__instance);
    }

    /// <summary>
    /// Adds an <see cref="AspectRatioFitter"/> to the light leak effect so it covers the full ultrawide display.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LightLeakController), nameof(LightLeakController.Start))]
    public static void LightLeakController_Start(LightLeakController __instance)
    {
        __instance.gameObject.AddAspectRatioFitter(__instance);
    }

    /// <summary>
    /// Adds an <see cref="AspectRatioFitter"/> to the opening credits black screen overlay during scene transitions.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneLoad), nameof(SceneLoad.Start))]
    public static void SceneLoad_Start(SceneLoad __instance)
    {
        var openingCredits = __instance.transform.FindChild("Opening Block/Black Screen");
        if (openingCredits)
        {
            openingCredits.gameObject.AddAspectRatioFitter(__instance);
        }
        else
        {
            __instance.LogWarning("No 'Opening Block/Black Screen' child found for aspect ratio fitting");
        }
    }

    /// <summary>
    /// Shared postfix for multiple screen types (splash, menus, warnings, HUD).
    /// Disables letterbox GameObjects, scales backgrounds to fill ultrawide, and adds
    /// an <see cref="AspectRatioFitter"/> to the 'Fade In' overlay.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Splashscreen), nameof(Splashscreen.Start))]
    [HarmonyPatch(typeof(PhotoSensitivitySkip), nameof(PhotoSensitivitySkip.Start))]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.Start))]
    [HarmonyPatch(typeof(HUDStart), nameof(HUDStart.Start))]
    [HarmonyPatch(typeof(WarningScreen), nameof(WarningScreen.Start))]
    [HarmonyPatch(typeof(ContentWarning), nameof(ContentWarning.Start))]
    public static void MainMenu_Start(MonoBehaviour __instance)
    {
        __instance.transform.DisableAll(__instance);
        __instance.transform.ScaleTransform(__instance, "Background");
        var fadeIn = __instance.transform.FindChild("Fade In");
        if (fadeIn)
        {
            fadeIn.gameObject.AddAspectRatioFitter(__instance);
        }
        else
        {
            __instance.LogWarning("No 'Fade In' child found for aspect ratio fitting");
        }
    }

    /// <summary>
    /// Forces <see cref="Camera.GateFitMode.Vertical"/> (Hor+) on all cameras managed by CameraSettings:
    /// <c>cameras</c>, <c>overideResolutionCameras</c>, and <c>disableResolutionCameras</c>.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraSettings), nameof(CameraSettings.Start))]
    [HarmonyPatch(typeof(CameraSettings), nameof(CameraSettings.ApplySettings))]
    public static void CameraSettings_ForceGateFit(CameraSettings __instance)
    {
        var cameraArray = new List<Camera>();
        if (__instance.cameras != null)
        {
            cameraArray.AddRange(__instance.cameras);
        }

        if (__instance.overideResolutionCameras != null)
        {
            cameraArray.AddRange(__instance.overideResolutionCameras);
        }

        if (__instance.disableResolutionCameras != null)
        {
            cameraArray.AddRange(__instance.disableResolutionCameras);
        }

        foreach (var cam in cameraArray.Where(cam => cam))
        {
            cam.EnforceGateFit();
        }
    }

    /// <summary>
    /// Forces the native ultrawide aspect ratio and Hor+ gate fit on the player's FollowCam (cam + cam2).
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(FollowCam), nameof(FollowCam.Start))]
    [HarmonyPatch(typeof(FollowCam), nameof(FollowCam.ApplySettings))]
    public static void FollowCam_ForceGateFitAndAspect(FollowCam __instance)
    {
        __instance.aspectRatio = DisplayMetrics.MainAspect;
        __instance.cam.EnforceGateFit();
        __instance.cam2.EnforceGateFit();
    }

    /// <summary>
    /// Forces the native ultrawide aspect ratio, Hor+ gate fit, and user-configured FOV on the FOVController camera.
    /// Overrides <c>FOVSetting</c> with the plugin's config value. The game applies <c>FOVSetting</c> additively
    /// to the lerped FOV arrays in <c>Update()</c>, so zoom/aim/run transitions continue to work correctly.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(FOVController), nameof(FOVController.Awake))]
    [HarmonyPatch(typeof(FOVController), nameof(FOVController.ApplySettings))]
    public static void FOVController_ForceGateFitAndAspect(FOVController __instance)
    {
        __instance.aspectRatio = DisplayMetrics.MainAspect;
        __instance.cam.EnforceGateFit();

        __instance.FOVSetting = Plugin.FieldOfView.Value;
        __instance.LogInfo($"FOVSetting={__instance.FOVSetting}");
    }

    /// <summary>
    /// Applies pending FOV changes from ConfigManager slider on the main thread.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(FOVController), nameof(FOVController.Update))]
    public static void FOVController_Update(FOVController __instance)
    {
        if (!FovChanged) return;
        FovChanged = false;
        __instance.FOVSetting = Plugin.FieldOfView.Value;
        __instance.LogInfo($"FOV config changed to {Plugin.FieldOfView.Value}");
    }

    /// <summary>
    /// Forces ultrawide settings via the VideoSettings pathway. VideoSettings holds its own reference to
    /// SettingsData and a letterbox GameObject that must be suppressed independently of the SettingsData patches.
    /// Disables lens distortion (causes edge smearing on ultrawide) and forces FOV/resolution/aspect.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoSettings), nameof(VideoSettings.Start))]
    [HarmonyPatch(typeof(VideoSettings), nameof(VideoSettings.ApplySettings))]
    public static void VideoSettings_Start(VideoSettings __instance)
    {
        if (__instance.settingsData)
        {
            __instance.settingsData.fov = Plugin.FieldOfView.Value;
            __instance.settingsData.letterbox = false;
            __instance.settingsData.whiteLetterbox = false;
            __instance.settingsData.resolutionX = DisplayMetrics.MainWidth;
            __instance.settingsData.resolutionY = DisplayMetrics.MainHeight;
            __instance.settingsData.aspectRatio = DisplayMetrics.MainAspect;
            __instance.settingsData.lensDistortion = false; //broken on ultra-wide. no one wants it anyway.
        }

        if (__instance.letterbox)
        {
            __instance.letterbox.SetActive(false);
        }

        __instance.LogInfo($"Forced SettingsData via VideoSettings: letterbox=disabled, lensDistortion=disabled, fov={Plugin.FieldOfView.Value}");
    }


    // --- Video ---

    /// <summary>
    /// Enforces <see cref="VideoAspectRatio.FitVertically"/> on all video players when they play, prepare,
    /// or step forward. Skips the Splash Screen scene where video aspect enforcement causes issues.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play_Prepare(VideoPlayer __instance)
    {
        __instance.EnforceAspectRatio();
    }

    // --- Settings Data Enforcement ---

    /// <summary>
    /// Forces the native ultrawide aspect ratio, resolution, and FOV on the game's SettingsData singleton.
    /// Disables both standard and white letterboxing, and disables lens distortion (causes edge smearing
    /// on ultrawide). Runs on every settings read/write to ensure the game never reverts to 16:9 values.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsData), nameof(SettingsData.Awake))]
    [HarmonyPatch(typeof(SettingsData), nameof(SettingsData.ReadAll))]
    [HarmonyPatch(typeof(SettingsData), nameof(SettingsData.ReadVideoSettings))]
    [HarmonyPatch(typeof(SettingsData), nameof(SettingsData.ReadGameplaySettings))]
    [HarmonyPatch(typeof(SettingsData), nameof(SettingsData.ReadResolutionSettings))]
    [HarmonyPatch(typeof(SettingsData), nameof(SettingsData.ReadGameplayModifiers))]
    public static void SettingsData_ForceUltrawide(SettingsData __instance)
    {
        __instance.fov = Plugin.FieldOfView.Value;
        __instance.aspectRatio = DisplayMetrics.MainAspect;
        __instance.letterbox = false;
        __instance.whiteLetterbox = false;
        __instance.resolutionX = DisplayMetrics.MainWidth;
        __instance.resolutionY = DisplayMetrics.MainHeight;
        __instance.lensDistortion = false; //broken on ultra-wide. no one wants it anyway.

        __instance.LogInfo($"Forced aspect={DisplayMetrics.MainAspect:F4}, resolution={DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, letterbox=false, fov={__instance.fov}");
    }

    // --- Game Bug Suppression ---

    /// <summary>
    /// Suppresses NullReferenceExceptions thrown by the game's own code in ReadGraveUI.Update and Workbench.Awake.
    /// These are pre-existing game bugs unrelated to the ultrawide fix.
    /// </summary>
    [HarmonyFinalizer]
    [HarmonyPatch(typeof(ReadGraveUI), nameof(ReadGraveUI.Update))]
    [HarmonyPatch(typeof(Workbench), nameof(Workbench.Awake))]
    public static Exception SuppressNre() => null;
}