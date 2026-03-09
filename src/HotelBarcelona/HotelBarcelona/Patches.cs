namespace HotelBarcelona;

/// <summary>
/// Harmony patches for Hotel Barcelona ultrawide support. Handles resolution enforcement,
/// UI scaling, camera viewport correction, fade stretching, letterbox suppression,
/// aspect ratio fixes, video playback, startup skipping, and announcement suppression.
/// </summary>
[Harmony]
public static class Patches
{
    // --- Resolution Enforcement ---

    /// <summary>
    /// Overrides resolution parameters in <see cref="Screen.SetResolution"/> overloads
    /// that do not include a <see cref="FullScreenMode"/> parameter.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_One(ref int width, ref int height)
    {
        Utils.ApplyMainResolution(ref width, ref height);
    }

    /// <summary>
    /// Overrides resolution and fullscreen mode in <see cref="Screen.SetResolution"/> overloads
    /// that include a <see cref="FullScreenMode"/> parameter.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        Utils.ApplyMainResolutionAndFullscreen(ref width, ref height, ref fullscreenMode);
    }

    /// <summary>
    /// Forces borderless fullscreen window mode whenever the game sets the fullscreen mode property.
    /// Uses string name because <c>MethodType.Setter</c> does not work in IL2CPP.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), "set_fullScreenMode")]
    public static void Screen_SetFullScreenMode(ref FullScreenMode value)
    {
        value = FullScreenMode.FullScreenWindow;
    }

    // --- UI Scaling ---

    /// <summary>
    /// Switches all <see cref="CanvasScaler"/> instances to <see cref="CanvasScaler.ScreenMatchMode.Expand"/>
    /// so UI elements scale correctly on ultrawide displays instead of being cropped.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    // --- Scene Load Hook ---

    /// <summary>
    /// Re-applies resolution and all global fixups whenever the game changes scenes.
    /// Forces <paramref name="autoActivation"/> to <c>true</c> to prevent loading stalls.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.ChangeScene))]
    public static void SceneManager_ChangeScene(string sceneName, ref bool autoActivation)
    {
        autoActivation = true;
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.FullScreenWindow, 0);
        Utils.ApplyGlobalFixups();
    }

    // --- Camera Viewport Rect Fix ---

    /// <summary>
    /// Intercepts the <see cref="CameraBehavior"/> rect setter to force full viewport,
    /// preventing the engine from applying letterboxed camera rects.
    /// Uses string name because <c>MethodType.Setter</c> does not work in IL2CPP.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraBehavior), "set_rect")]
    public static void CameraBehavior_SetRect(ref Rect value)
    {
        value = Utils.FullViewportRect;
    }

    /// <summary>
    /// Ensures cameras adapted by <see cref="CameraManagerEntity"/> have a black background
    /// and full viewport rect, correcting any aspect-ratio-based adjustments.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManagerEntity), nameof(CameraManagerEntity.Adapt))]
    public static void CameraManagerEntity_Adapt(UnityEngine.Camera camera)
    {
        if (camera == null) return;
        camera.backgroundColor = Color.black;
        if (camera.rect != Utils.FullViewportRect)
        {
            camera.rect = Utils.FullViewportRect;
        }
    }

    // --- Fade Image Stretch Fix ---

    /// <summary>
    /// Stretches the fade controller's image to cover the full ultrawide display after any
    /// fade lifecycle event (create, start, fade in, fade out).
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(FadeControllerEntity), nameof(FadeControllerEntity.SetFadeIn))]
    [HarmonyPatch(typeof(FadeControllerEntity), nameof(FadeControllerEntity.SetFadeOut))]
    [HarmonyPatch(typeof(FadeControllerEntity), nameof(FadeControllerEntity.OnCreate))]
    [HarmonyPatch(typeof(FadeControllerEntity), nameof(FadeControllerEntity.OnStart))]
    public static void FadeControllerEntity_SetFadeIn(FadeControllerEntity __instance)
    {
        Utils.StretchFadeImage(__instance);
    }

    // --- LetterBox Suppression ---

    /// <summary>
    /// Prevents the letterbox overlay from being shown by skipping the original method entirely.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(LetterBox), nameof(LetterBox.Show))]
    public static bool LetterBox_Show()
    {
        return false;
    }

    /// <summary>
    /// Hides and disables the letterbox canvas group on awake so it never becomes visible
    /// or intercepts input.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LetterBox), nameof(LetterBox.Awake))]
    public static void LetterBox_Awake(LetterBox __instance)
    {
        var cg = __instance._CanvasGroup;
        if (cg != null)
        {
            cg.alpha = 0f;
            cg.blocksRaycasts = false;
        }
    }

    // --- ActionCameraBehavior Aspect Correction ---

    /// <summary>
    /// Overrides the aspect ratio parameter in <see cref="ActionCameraBehavior"/> camera limit
    /// calculations with the actual display aspect, preventing camera bounds from being
    /// calculated for 16:9.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ActionCameraBehavior), nameof(ActionCameraBehavior.LimitWithRegion), typeof(Vector3), typeof(float), typeof(float), typeof(float))]
    [HarmonyPatch(typeof(ActionCameraBehavior), nameof(ActionCameraBehavior.LimitWithCtrl), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float))]
    public static void ActionCameraBehavior_LimitWithRegion(ref float aspect)
    {
        aspect = DisplayMetrics.MainAspect;
    }

    // --- Video Player ---

    /// <summary>
    /// Stops the boot movie from playing and sets all other videos to
    /// <see cref="VideoAspectRatio.FitVertically"/> so they display correctly on ultrawide.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        var clipName = __instance.clip != null ? __instance.clip.name : __instance.url ?? "unknown";

        if (clipName == "BootMovie")
        {
            __instance.Stop();
            __instance.playOnAwake = false;
            return;
        }

        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    // --- Startup Skip ---

    /// <summary>
    /// Skips eye-catch (splash screen) animations by immediately invoking the completion
    /// callback and preventing the original method from running.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(EyeCatchManager), nameof(EyeCatchManager.Play))]
    public static bool EyeCatchManager_Play(Action action)
    {
        action?.Invoke();
        return false;
    }

    /// <summary>
    /// Skips the boot timer screen by zeroing its duration and wait time, disabling the
    /// input requirement, and immediately closing it. Also applies global fixups.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BootTimerProcess), nameof(BootTimerProcess.Setup))]
    public static void BootTimerProcess_Setup(BootTimerProcess __instance)
    {
        Utils.ApplyGlobalFixups();

        __instance._Duration = 0f;
        __instance._Wait = 0f;
        __instance._IsRequiredInput = false;
        __instance.ToClose();
    }

    /// <summary>
    /// Immediately skips any screen movie by setting the skip flag after playback starts.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenMovie), nameof(ScreenMovie.Play))]
    public static void ScreenMovie_Play(ScreenMovie __instance)
    {
        __instance._Skip = true;
    }

    /// <summary>
    /// Immediately skips sequential video playback by setting the skip flag after playback starts.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SequentialVideoPlayer), nameof(SequentialVideoPlayer.Play))]
    public static void SequentialVideoPlayer_Play(SequentialVideoPlayer __instance)
    {
        __instance._Skip = true;
    }

    // --- Volume Registration ---

    /// <summary>
    /// Intercepts volume registration to track all post-processing components and create
    /// dynamic config entries for each unique effect type (atmospheric scattering, volumetric
    /// light, PCSS, darkness, etc.).
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register), typeof(Volume), typeof(int))]
    public static void VolumeManager_Register(Volume volume, int layer)
    {
        Volumes.ProcessVolumeRegistration(volume, layer);
    }

    /// <summary>
    /// Cleans up tracked component references when a volume is unregistered,
    /// preventing stale references from accumulating.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Unregister), typeof(Volume), typeof(int))]
    public static void VolumeManager_Unregister(Volume volume)
    {
        Volumes.ProcessVolumeUnregister(volume);
    }

    /// <summary>
    /// Applies the current config state to a volume's components whenever the volume
    /// is enabled, ensuring user preferences are respected for newly activated volumes.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    // --- Config Reload (Main Thread) ---

    /// <summary>
    /// Finalizer on <see cref="SceneManagerEntity.Update"/> that serves two purposes:
    /// 1. Checks the <see cref="Plugin.ConfigChanged"/> flag each frame and reloads config
    ///    on the main thread (required because <see cref="System.IO.FileSystemWatcher"/>
    ///    fires on a thread pool thread where Unity API calls silently fail in IL2CPP).
    /// 2. Suppresses the game's internal <see cref="NullReferenceException"/> in
    ///    <c>SoundManager.StopGlobalAudioWhole</c> that spams the log when this method
    ///    is patched by Harmony's IL2CPP trampoline.
    /// </summary>
    [HarmonyFinalizer]
    [HarmonyPatch(typeof(SceneManagerEntity), nameof(SceneManagerEntity.Update))]
    public static Exception SceneManagerEntity_Update(Exception __exception)
    {
        if (Plugin.ConfigChanged)
        {
            Plugin.ConfigChanged = false;
            Plugin.ConfigFile.Reload();
            Utils.UpdateAntiAliasing();
            Plugin.Logger.LogInfo("Config file changed - reloaded.");
        }

        return null;
    }

    // --- Announcement/News Popup Suppression ---

    /// <summary>
    /// Suppresses in-game announcement popups by immediately invoking the end callback
    /// and skipping the original display logic.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(AnnouncementManager), nameof(AnnouncementManager.DoProcess))]
    [HarmonyPatch(typeof(AnnouncementManager), nameof(AnnouncementManager.DoProcessOnHotel))]
    public static bool AnnouncementManager_DoProcess(Action actionEnd)
    {
        actionEnd?.Invoke();
        return false;
    }

    /// <summary>
    /// Deactivates the announcement UI GameObject and prevents the original enable/setup
    /// logic from running, ensuring announcements never appear.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(AnnouncementProcess), nameof(AnnouncementProcess.OnEnable))]
    [HarmonyPatch(typeof(AnnouncementProcess), nameof(AnnouncementProcess.Setup))]
    public static bool AnnouncementProcess_OnEnable(AnnouncementProcess __instance)
    {
        __instance.gameObject.SetActive(false);
        return false;
    }
}
