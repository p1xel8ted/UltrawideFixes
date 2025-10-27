namespace ScarletMaiden.Camera;

/// <summary>
/// Harmony patches for camera behavior, field of view adjustments, and orthographic size calculations.
/// Handles ultrawide camera adjustments, FOV multipliers, and camera bounds for proper viewport scaling.
/// </summary>
[Harmony]
public static class CameraPatches
{
    /// <summary>
    /// Indicates whether the game is in a loading/transition state.
    /// When true, camera adjustments are disabled to prevent visual issues during dungeon transitions.
    /// </summary>
    internal static bool LoadingScreen { get; set; } = false;

    /// <summary>
    /// List of scene names where custom orthographic size adjustments should be skipped.
    /// These scenes use default camera behavior to prevent visual issues.
    /// </summary>
    private static readonly string[] SkipTheseScenes = ["TitleScreen", "SetupScene", "Intro", "OttersideSplash"];

    /// <summary>
    /// Replaces the default orthographic size calculation to support ultrawide aspect ratios.
    /// Calculates camera size based on native 16:9 resolution, then applies aspect ratio scaling and FoV multiplier.
    /// Skips custom sizing in specific scenes where default behavior is required.
    /// </summary>
    /// <param name="__instance">The CameraFix instance being patched.</param>
    /// <returns>False to skip the original method, as we're replacing its functionality entirely.</returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.UpdateOrthographicSize))]
    public static bool CameraFix_UpdateOrthographicSize(CameraFix __instance)
    {
        var newWidth = Mathf.RoundToInt(Screen.height * ResolutionManager.NativeAspect);
        var res = CameraFix.GetStateForResolution(newWidth, Screen.height);

        if (res == ResolutionState.R_NOT_SUPPORTED)
        {
            newWidth = Mathf.RoundToInt(Display.main.systemHeight * ResolutionManager.NativeAspect);
            res = CameraFix.GetStateForResolution(newWidth, Display.main.systemHeight);
            Plugin.Log.LogWarning($"Resolution {newWidth}x{Screen.height} not supported, fallback to native height resolution state: {res}");
        }
        else
        {
            Plugin.Log.LogInfo($"Calculated resolution state: {res} for screen {newWidth}x{Screen.height}");
        }

        var resolutionTuple = CameraFix.GetResolutionForState(res);
        var getResStateZoom = resolutionTuple.Item2 / __instance.ppu / 2f / (float)__instance.resolutionState / __instance.currenZoomLevel;


        var ogZoom = getResStateZoom * ResolutionManager.PositiveScaleFactor;

        Plugin.Log.LogInfo($"Base orthographic size calculation: {getResStateZoom} -> adjusted for aspect ratio: {ogZoom}");

        if (FoVConfig.FieldOfViewMultiplier.Value != 0f)
        {
            ogZoom *= FoVConfig.FieldOfViewMultiplier.Value;
        }

        if (LoadingScreen || SkipTheseScenes.Contains(SceneManager.GetActiveScene().name))
        {
            __instance.cam.orthographicSize = CameraFix.GetResolutionForState(__instance.resolutionState).Item2 / __instance.ppu / 2f / (float)__instance.resolutionState / __instance.currenZoomLevel;
            Plugin.Log.LogInfo($"Skipping custom orthographic size in scene: {SceneManager.GetActiveScene().name}");
        }
        else
        {
            __instance.cam.orthographicSize = ogZoom;
            Plugin.Log.LogInfo($"Final orthographic size set to: {ogZoom}");
        }

        UpdateFramerate(__instance);

        return false;
    }

    /// <summary>
    /// Replaces the default camera follow behavior to properly handle ultrawide aspect ratios.
    /// Adjusts camera positioning and bounds checking to account for extended horizontal viewport.
    /// Prevents the camera from moving beyond level boundaries while supporting wide displays.
    /// </summary>
    /// <param name="__instance">The CameraFollow instance being patched.</param>
    /// <returns>False to skip the original method, as we're replacing its functionality entirely.</returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraFollow), nameof(CameraFollow.LateUpdate))]
    public static bool CameraFollow_Postfix(CameraFollow __instance)
    {
        __instance.focusArea.Update(__instance.target.GetComponent<BoxCollider2D>().bounds);
        var vector = (Vector3)__instance.focusArea.centre + Vector3.up * __instance.verticalOffset + Vector3.forward * -10f;
        var num = __instance.cam.orthographicSize * 2f;
        var num2 = num * Screen.width / Screen.height;

        Vector3 vector2;
        Vector3 vector3;

        if (__instance.useCamBoundsOverride)
        {
            vector2 = __instance.camBoundsOverride.min;
            vector3 = __instance.camBoundsOverride.max;
        }
        else
        {
            var tilemapObject = GameObject.FindGameObjectWithTag("Tilemap");
            if (!tilemapObject)
            {
                Plugin.Log.LogWarning("No GameObject with 'Tilemap' tag found. Using camera bounds override instead.");
                vector2 = __instance.camBoundsOverride.min;
                vector3 = __instance.camBoundsOverride.max;
            }
            else
            {
                var collider = tilemapObject.GetComponent<CompositeCollider2D>();
                if (!collider)
                {
                    Plugin.Log.LogWarning("Tilemap GameObject found but no CompositeCollider2D component. Using camera bounds override instead.");
                    vector2 = __instance.camBoundsOverride.min;
                    vector3 = __instance.camBoundsOverride.max;
                }
                else
                {
                    vector2 = collider.bounds.min;
                    vector3 = collider.bounds.max;
                }
            }
        }

        if (vector3.x - vector2.x > 0f)
        {
            var levelWidth = vector3.x - vector2.x;

            if (levelWidth > num2)
            {
                if (vector.x < vector2.x + num2 / 2f + 2f)
                    vector.x = vector2.x + num2 / 2f + 2f;
                else if (vector.x > vector3.x - num2 / 2f - 2f)
                    vector.x = vector3.x - num2 / 2f - 2f;
            }
            else
            {
                vector.x = (vector2.x + vector3.x) / 2f;
            }

            var levelHeight = vector3.y - vector2.y;

            if (levelHeight > num)
            {
                if (vector.y < vector2.y + num / 2f + 2f)
                    vector.y = vector2.y + num / 2f + 2f;
                else if (vector.y > vector3.y - num / 2f - 2f)
                    vector.y = vector3.y - num / 2f - 2f;
            }
            else
            {
                vector.y = (vector2.y + vector3.y) / 2f;
            }
        }

        if (__instance.snapToPosition)
        {
            __instance.transform.position = vector;
            __instance.snapToPosition = false;
        }
        else
        {
            __instance.transform.position = Vector3.Lerp(__instance.transform.position, vector, __instance.lerpSpeed);
        }

        if (__instance.lerpTimer > 0)
        {
            __instance.lerpTimer--;
            if (__instance.lerpTimer == 0)
            {
                __instance.lerpSpeed = 0.1f;
            }
        }

        if (__instance.shaking)
        {
            __instance.camTransform = __instance.GetComponent(typeof(Transform)) as Transform;
            __instance.originalPos = __instance.camTransform!.localPosition;
            __instance.camTransform.localPosition = __instance.originalPos + Random.insideUnitSphere * __instance.shakeStrength;
            if (__instance.shakeTimerMax > 0f)
            {
                __instance.shakeTimer += Time.deltaTime;
                if (__instance.shakeTimer > __instance.shakeTimerMax)
                {
                    __instance.shaking = false;
                }
            }
        }

        return false;
    }

    /// <summary>
    /// Updates all camera instances with current configuration settings.
    /// Applies camera mode, vertical offset, target framerate, and orthographic size.
    /// </summary>
    internal static void UpdateCameras()
    {
        Application.targetFrameRate = ResolutionManager.MaxRefresh;

        var cameraFollowers = Resources.FindObjectsOfTypeAll<CameraFollow>();
        foreach (var cam in cameraFollowers)
        {
            cam.useCamBoundsOverride = CameraConfig.AlternateCameraMode.Value;
            cam.verticalOffset = CameraConfig.CameraVerticality.Value;
        }

        var cameraFixes = Resources.FindObjectsOfTypeAll<CameraFix>();
        foreach (var cam in cameraFixes)
        {
            if (cam && cam.cam)
            {
                cam.targetFramerate = ResolutionManager.MaxRefresh;
                cam.UpdateOrthographicSize();
            }
        }
    }

    /// <summary>
    /// Disables the game's built-in camera input handling.
    /// Prevents conflicts with ultrawide camera adjustments.
    /// </summary>
    /// <returns>False to skip the original method.</returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.HandleInput))]
    public static bool CameraFix_HandleInput()
    {
        return false;
    }

    /// <summary>
    /// Postfix patch that applies camera configuration settings when CameraFollow starts.
    /// Sets camera mode and vertical offset from user preferences.
    /// </summary>
    /// <param name="__instance">The CameraFollow instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFollow), nameof(CameraFollow.Start))]
    public static void CameraFollow_Start(CameraFollow __instance)
    {
        __instance.useCamBoundsOverride = CameraConfig.AlternateCameraMode.Value;
        __instance.verticalOffset = CameraConfig.CameraVerticality.Value;
    }

    /// <summary>
    /// Postfix patch that applies framerate settings when CameraFix starts.
    /// Ensures camera refresh rate matches display configuration.
    /// </summary>
    /// <param name="__instance">The CameraFix instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.Start))]
    public static void CameraFix_Start(CameraFix __instance)
    {
        UpdateFramerate(__instance);
    }

    /// <summary>
    /// Updates the target framerate for a specific CameraFix instance and the application.
    /// Synchronizes camera refresh rate with the display's maximum refresh rate.
    /// </summary>
    /// <param name="cameraFix">The CameraFix instance to update.</param>
    private static void UpdateFramerate(CameraFix cameraFix)
    {
        cameraFix.targetFramerate = ResolutionManager.MaxRefresh;
        Application.targetFrameRate = ResolutionManager.MaxRefresh;
    }
}