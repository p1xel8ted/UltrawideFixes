using System.Collections.Generic;
using UnityEngine.UI;

namespace Broforce;

[Harmony]
public static class Patches
{
    /// <summary>
    /// Patches CameraController.DefaultOrthographicSize getter to use Hor+ scaling.
    /// Original: DefaultHalfWidth (227f) / aspect = Vert- (zooms in on ultrawide)
    /// Fixed: Clamp aspect to 16:9 = Hor+ (shows more horizontal content)
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.DefaultOrthographicSize), MethodType.Getter)]
    public static void CameraController_DefaultOrthographicSize(ref float __result)
    {
        var currentAspect = (float)Screen.width / Screen.height;
        if (currentAspect > Plugin.NativeAspect)
        {
            __result = CameraController.DefaultHalfWidth / Plugin.NativeAspect;
        }
    }

    /// <summary>
    /// Patches ResizeForAspectRatio.UpdateOrthoSize to use Hor+ scaling.
    /// Original: 0.8f / aspect = Vert-
    /// Fixed: 0.8f / 16:9 = Hor+
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ResizeForAspectRatio), nameof(ResizeForAspectRatio.UpdateOrthoSize))]
    public static void ResizeForAspectRatio_UpdateOrthoSize(ResizeForAspectRatio __instance)
    {
        var currentAspect = (float)Screen.width / Screen.height;
        if (currentAspect > Plugin.NativeAspect && __instance.cam)
        {
            __instance.cam.orthographicSize = 0.8f / Plugin.NativeAspect;
        }
    }

    /// <summary>
    /// Patches IntroCutsceneController.UpdateOrthoSize to use Hor+ scaling.
    /// Original: 0.8f / aspect = Vert-
    /// Fixed: 0.8f / 16:9 = Hor+
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(IntroCutsceneController), nameof(IntroCutsceneController.UpdateOrthoSize))]
    public static void IntroCutsceneController_UpdateOrthoSize(IntroCutsceneController __instance)
    {
        var currentAspect = (float)Screen.width / Screen.height;
        if (currentAspect > Plugin.NativeAspect && __instance.cam)
        {
            __instance.cam.orthographicSize = 0.8f / Plugin.NativeAspect;
        }
    }

    /// <summary>
    /// Patches SortOfFollow.ZoomToHorizontalGameplayExtents to use Hor+ scaling.
    /// Original: 227.555557f / aspect = Vert-
    /// Fixed: 227.555557f / 16:9 = Hor+
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SortOfFollow), nameof(SortOfFollow.ZoomToHorizontalGameplayExtents))]
    public static void SortOfFollow_ZoomToHorizontalGameplayExtents(SortOfFollow __instance)
    {
        if (__instance.mainCam && __instance.mainCam.aspect > Plugin.NativeAspect)
        {
            __instance.mainCam.orthographicSize = 227.555557f / Plugin.NativeAspect;
        }
    }

    /// <summary>
    /// Stores filtered resolutions (highest refresh rate per resolution) for the resolution menu.
    /// </summary>
    private static Resolution[] FilteredResolutions { get; set; }

    /// <summary>
    /// Filters resolutions to only keep the highest refresh rate for each width x height.
    /// Includes native display resolution as fallback in case Unity filters it out.
    /// </summary>
    private static Resolution[] GetFilteredResolutions()
    {
        var resolutions = Screen.resolutions;
        var bestBySize = new Dictionary<string, Resolution>();

        // Add native display resolution first (in case Unity's supported aspect ratios filter it out)
        var nativeKey = Display.main.systemWidth + "x" + Display.main.systemHeight;
        bestBySize[nativeKey] = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = Screen.currentResolution.refreshRate
        };

        for (var i = 0; i < resolutions.Length; i++)
        {
            var res = resolutions[i];
            var key = res.width + "x" + res.height;
            if (!bestBySize.ContainsKey(key) || res.refreshRate > bestBySize[key].refreshRate)
            {
                bestBySize[key] = res;
            }
        }

        // Convert to sorted list
        var result = new List<Resolution>();
        foreach (var kvp in bestBySize)
        {
            result.Add(kvp.Value);
        }

        result.Sort((a, b) =>
        {
            var widthCompare = b.width.CompareTo(a.width);
            return widthCompare != 0 ? widthCompare : b.height.CompareTo(a.height);
        });

        return result.ToArray();
    }

    /// <summary>
    /// Patches ResolutionMenu.SetupItems to only show highest refresh rate per resolution.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ResolutionMenu), nameof(ResolutionMenu.SetupItems))]
    public static void ResolutionMenu_SetupItems(ResolutionMenu __instance)
    {
        FilteredResolutions = GetFilteredResolutions();

        var menuItems = new List<MenuBarItem>();
        for (var i = 0; i < FilteredResolutions.Length; i++)
        {
            var resolution = FilteredResolutions[i];
            menuItems.Add(new MenuBarItem
            {
                color = Color.white,
                size = __instance.characterSizes,
                localisedKey = string.Empty,
                name = resolution.width + "x" + resolution.height,
                invokeMethod = nameof(ResolutionMenu.SetResolution)
            });
        }

        menuItems.Add(new MenuBarItem
        {
            color = Color.white,
            size = __instance.characterSizes,
            localisedKey = "MENU_BACK",
            name = "BACK",
            invokeMethod = nameof(ResolutionMenu.GoBackToMainMenu)
        });

        __instance.masterItems = menuItems.ToArray();
    }

    /// <summary>
    /// Patches ResolutionMenu.SetResolution to use filtered resolution list.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ResolutionMenu), nameof(ResolutionMenu.SetResolution))]
    public static bool ResolutionMenu_SetResolution(ResolutionMenu __instance)
    {
        if (FilteredResolutions == null || __instance.highlightIndex < 0 || __instance.highlightIndex >= FilteredResolutions.Length)
            return true; // Fall back to original

        var resolution = FilteredResolutions[__instance.highlightIndex];
        PlayerOptions.Instance.resolutionW = resolution.width;
        PlayerOptions.Instance.resolutionH = resolution.height;
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        return false; // Skip original
    }

    /// <summary>
    /// Sets CanvasScaler to Expand mode for ultrawide displays.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        var currentAspect = (float)Screen.width / Screen.height;
        if (currentAspect > Plugin.NativeAspect)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    /// <summary>
    /// Skips the Broforce logo intro.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroController), nameof(IntroController.Start))]
    public static bool IntroController_Start(IntroController __instance)
    {
        // Mute all audio
        AudioListener.volume = 0f;

        __instance.ProcessCommandLineArguments();
        __instance.Continue();
        return false;
    }

    /// <summary>
    /// Prevents IntroController.Update from running (causes NullRef after skip).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroController), nameof(IntroController.Update))]
    public static bool IntroController_Update()
    {
        return false;
    }

    /// <summary>
    /// Skips directly to MainMenu, bypassing all intro scenes.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(TFBGIntro), nameof(TFBGIntro.Start))]
    public static bool TFBGIntro_Start(TFBGIntro __instance)
    {
        // Mute audio during transition
        AudioListener.volume = 0f;

        if (__instance.animator)
        {
            __instance.animator.enabled = false;
        }

        // Skip directly to MainMenu
        GameState.LoadLevel(LevelSelectionController.MainMenuScene);
        return false;
    }

    /// <summary>
    /// Disables the Devolver logo animation.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(DevolverGrow), nameof(DevolverGrow.Awake))]
    public static bool DevolverGrow_Awake(DevolverGrow __instance)
    {
        Object.Destroy(__instance.gameObject);
        return false;
    }

    /// <summary>
    /// Restores audio when Sound manager initializes.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Sound), nameof(Sound.Awake))]
    public static void Sound_Awake()
    {
        // Restore audio volume
        AudioListener.volume = 1f;
        Sound.fading = false;
    }

    /// <summary>
    /// Skips the MainMenu intro animation.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(IntroAnim), nameof(IntroAnim.Awake))]
    public static void IntroAnim_Awake(IntroAnim __instance)
    {
        // Immediately show the main menu
        if (__instance.mainMenu)
        {
            __instance.mainMenu.MenuActive = true;
            Menu.LastInputTime = Time.time + 0.5f;
            __instance.menuWasShown = true;
        }
    }

    /// <summary>
    /// Disables the Free Lives star animation.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(StarGrow), nameof(StarGrow.Awake))]
    public static bool StarGrow_Awake(StarGrow __instance)
    {
        Object.Destroy(__instance.gameObject);
        return false;
    }

    /// <summary>
    /// Disables the Free Lives hand animation.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ColouredHand), nameof(ColouredHand.Awake))]
    public static bool ColouredHand_Awake(ColouredHand __instance)
    {
        Object.Destroy(__instance.gameObject);
        return false;
    }

    /// <summary>
    /// Disables the Free Lives birdman animation.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Birdman), nameof(Birdman.Awake))]
    public static bool Birdman_Awake(Birdman __instance)
    {
        Object.Destroy(__instance.gameObject);
        return false;
    }
}