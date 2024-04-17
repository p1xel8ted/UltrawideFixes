using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Assets.Code.Audio.Sfx;
using Assets.Code.Loading;
using Assets.Code.Platform;
using Assets.Code.Rendering;
using Assets.Code.UI.Screens;
using Assets.Code.UI.Widgets;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using Display = UnityEngine.Display;
using Math = System.Math;

namespace DarkestDungeon2UltrawideFix;

/// <summary>
/// A class to hold patches for manipulating screen resolutions and other game aspects.
/// </summary>
[HarmonyPatch]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    /// <summary>
    /// Converts a resolution to a simplified ratio using the Greatest Common Divisor (GCD).
    /// </summary>
    /// <param name="width">The width of the resolution.</param>
    /// <param name="height">The height of the resolution.</param>
    /// <returns>A tuple representing the simplified width and height.</returns>
    private static (int SimplifiedWidth, int SimplifiedHeight) ConvertResolutionToRatio(int width, int height)
    {
        var gcd = Gcd(width, height);
        var simplifiedWidth = width / gcd;
        var simplifiedHeight = height / gcd;

        // Special case for 21:9 ratio, commonly found in ultrawide monitors
        if (simplifiedWidth == 43 && simplifiedHeight == 18)
        {
            return (21, 9);
        }

        return (simplifiedWidth, simplifiedHeight);

        // Calculate the Greatest Common Divisor using Euclid's algorithm
        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    /// <summary>
    /// A postfix patch for <see cref="ScreenResolutionWidgetBhv.GetDisplayAspectRatio"/> method.
    /// Modifies the resulting aspect ratio based on the current screen resolution.
    /// </summary>
    /// <param name="__instance">The instance of the <see cref="ScreenResolutionWidgetBhv"/> class.</param>
    /// <param name="__result">The result of the original method (aspect ratio).</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionWidgetBhv), nameof(ScreenResolutionWidgetBhv.GetDisplayAspectRatio))]
    private static void ScreenResolutionWidgetBhv_GetDisplayAspectRatio(ref ScreenResolutionWidgetBhv __instance, ref ResolutionAspectRatio __result)
    {
        var resolutions = Screen.resolutions;
        var maxResolution = resolutions.OrderByDescending(r => r.width * r.height).First();
        var aspectRatio = maxResolution.width / (float) maxResolution.height;

        // Simplify the check by using a helper function
        __result = GetClosestAspectRatio(aspectRatio);
    }

    // Helper function to determine the closest aspect ratio
    private static ResolutionAspectRatio GetClosestAspectRatio(float aspectRatio)
    {
        if (Math.Abs(aspectRatio - 16f / 10f) < 0.01)
            return ResolutionAspectRatio.AR_16x10;
        if (Math.Abs(aspectRatio - 16f / 9f) < 0.01)
            return ResolutionAspectRatio.AR_16x9;

        var sCurrent = ConvertResolutionToRatio(Display.main.systemWidth, Display.main.systemHeight);
        var currentAspectRatio = sCurrent.SimplifiedWidth / (float) sCurrent.SimplifiedHeight;
        if (Math.Abs(aspectRatio - currentAspectRatio) < 0.01)
            return (ResolutionAspectRatio) 3;

        return ResolutionAspectRatio.AR_16x9;
    }


    /// <summary>
    /// A WriteOnce list of <see cref="TMP_Dropdown.OptionData"/> that represents the options for the resolution dropdown.
    /// </summary>
    /// <remarks>
    /// WriteOnce is a custom data type that allows a value to be set once and then prevents further modifications.
    /// </remarks>
    private readonly static WriteOnce<List<TMP_Dropdown.OptionData>> ResolutionDropdown = new();

    /// <summary>
    /// A WriteOnce list of integers that represents the index mappings for the resolution dropdown.
    /// </summary>
    /// <remarks>
    /// WriteOnce is a custom data type that allows a value to be set once and then prevents further modifications.
    /// Each integer in this list corresponds to an index in the resolution dropdown options.
    /// </remarks>
    private readonly static WriteOnce<List<int>> DropdownIndexMappings = new();


    /// <summary>
    /// Postfix patch for the <see cref="ScreenResolutionWidgetBhv.RefreshResolution"/> method.
    /// This method adjusts the resolution options and index mappings for the resolution dropdown based on custom resolutions provided by <see cref="ScreenResolutionsPatch.MyResolutions"/>.
    /// </summary>
    /// <param name="__instance">The instance of the <see cref="ScreenResolutionWidgetBhv"/> that this patch is applied to.</param>
    /// <param name="currentWindowMode">The current window mode of the game.</param>
    /// <remarks>
    /// This patch checks if the resolution options and dropdown index mappings have been set. If they have, it applies these values to the instance's resolution dropdown and index mappings.
    /// If they haven't been set, it gets the custom resolutions from <see cref="ScreenResolutionsPatch.MyResolutions"/>, adds resolutions that match the aspect ratio to the dropdown, 
    /// and sets the resolution dropdown options and index mappings to these new values.
    /// Finally, it refreshes the dropdown value.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionWidgetBhv), nameof(ScreenResolutionWidgetBhv.RefreshResolution))]
    public static void ScreenResolutionWidgetBhv_RefreshResolution(ref ScreenResolutionWidgetBhv __instance, FullScreenMode currentWindowMode)
    {
        if (ResolutionDropdown.HasValue && DropdownIndexMappings.HasValue)
        {
            __instance.m_resolutionDropdown.options = ResolutionDropdown.Value;
            __instance.m_dropdownIndexMappings = DropdownIndexMappings.Value;
        }
        else
        {
            var resolutions = ScreenResolutionsPatch.MyResolutions();
            __instance.AddResolutionsMatchingAspectRatio((ResolutionAspectRatio) 3, currentWindowMode, resolutions);

            ResolutionDropdown.Value = __instance.m_resolutionDropdown.options;
            DropdownIndexMappings.Value = __instance.m_dropdownIndexMappings;
        }

        __instance.RefreshDropdownValue();
    }


    /// <summary>
    /// Postfix patch for the <see cref="MainMenuUiScreenBhv.Awake"/> method.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="MainMenuUiScreenBhv"/> that this method is operating on.</param>
    /// <remarks>
    /// This patch ensures that the OptionsButton on the main menu UI is set to active when the <see cref="MainMenuUiScreenBhv.Awake"/> method is invoked.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuUiScreenBhv), nameof(MainMenuUiScreenBhv.Awake))]
    public static void MainMenuUiScreenBhv_Awake(ref MainMenuUiScreenBhv __instance)
    {
        var optionsButton = GameObject.Find("MainMenuUI/MainMenuUIScreen/UI/OptionsButton");
        if (optionsButton)
        {
            optionsButton.SetActive(true);
        }

        var m1 = GameObject.Find("MainMenuUI/MainMenuUIScreen/Background_Far_Mountains");
        var m2 = GameObject.Find("MainMenuUI/MainMenuUIScreen/Background_Near_Mountains");

        m1.AddComponent<Scaler>();
        m2.AddComponent<Scaler>();
    }


    private class Scaler : MonoBehaviour
    {
        private void LateUpdate()
        {
            transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1.0f, 1.0f);
        }
    }

    /// <summary>
    /// Postfix patch for the <see cref="ButtonAudioBhv.Awake"/> method.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="ButtonAudioBhv"/> that this method is operating on.</param>
    /// <remarks>
    /// This patch deactivates the FeedbackButton, CreditsButton, and MailingListButton in the UI when the <see cref="ButtonAudioBhv.Awake"/> method is invoked.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ButtonAudioBhv), nameof(ButtonAudioBhv.Awake))]
    public static void ButtonAudioBhv_Awake(ref ButtonAudioBhv __instance)
    {
        if (__instance.m_button.name.Equals("FeedbackButton") || __instance.m_button.name.Equals("CreditsButton") || __instance.m_button.name.Equals("MailingListButton"))
        {
            __instance.m_button.gameObject.SetActive(false);
        }
    }


    /// <summary>
    /// Postfix patch for the <see cref="PauseMenuButtonBhv.Awake"/> method.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="PauseMenuButtonBhv"/> that this method is operating on.</param>
    /// <remarks>
    /// This patch deactivates the FeedbackButton in the pause menu UI when the <see cref="PauseMenuButtonBhv.Awake"/> method is invoked.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseMenuButtonBhv), nameof(PauseMenuButtonBhv.Awake))]
    public static void PauseMenuButtonBhv_Awake(ref PauseMenuButtonBhv __instance)
    {
        if (__instance.m_button.name.Equals("FeedbackButton"))
        {
            __instance.m_button.gameObject.SetActive(false);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    public static void VideoPlayer_Play(ref VideoPlayer __instance)
    {
        if (__instance.clip.name.Contains("RED_HOOK_INTRO", StringComparison.OrdinalIgnoreCase))
        {
            __instance.playbackSpeed = 1000f;
        }
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlatformMgr), nameof(PlatformMgr.ToggleGPUBoost))]
    [HarmonyPatch(typeof(PlatformMgr), nameof(PlatformMgr.ToggleCPUBoost))]
    public static void PlatformMgr_ToggleGPUBoost(ref bool isBoosted)
    {
        Application.backgroundLoadingPriority = ThreadPriority.High;
        isBoosted = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(RedHookSplashSceneBhv), nameof(RedHookSplashSceneBhv.ShowPUACard))]
    public static void RedHookSplashSceneBhv_ShowPUACard(ref RedHookSplashSceneBhv __instance)
    {
        __instance.m_cardDisplayTime = 0;
        __instance.m_fadeTime = 0;
        __instance.m_postMovieWaitTime = 0;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }


    /// <summary>
    /// Prefix patch for the <see cref="RenderingManager.ChangeOutlineFeatureResolution"/> method.
    /// </summary>
    /// <param name="__instance">The instance of the <see cref="RenderingManager"/> that the method is being called on.</param>
    /// <remarks>
    /// This method creates a new resolution based on the system's current display resolution and modifies the <see cref="OutlineFeature"/> 
    /// settings to match this resolution. For each <see cref="OutlineFeature"/> in the instance's renderer features, the method finds the settings 
    /// matching the calculated width and height and adds them to the settings for the new resolution. 
    /// If any existing settings match the new resolution's width and height, they are removed.
    /// This patch is applied before the original method execution (<see cref="HarmonyPrefix"/>).
    /// </remarks>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(RenderingManager), nameof(RenderingManager.ChangeOutlineFeatureResolution))]
    public static void ChangeOutlineFeatureResolutionPrefix(ref RenderingManager __instance)
    {
        var newResolution = GetDisplayResScriptableObject();
        foreach (var t in __instance.m_forwardRenderers)
        {
            foreach (var outlineFeature in t.rendererFeatures.Where(scriptableRendererFeature => scriptableRendererFeature.GetType() == typeof(OutlineFeature)).Cast<OutlineFeature>())
            {
                var calculatedWidth = newResolution.height * 16 / 9;
                var resToCopy = outlineFeature.outlinePassSettingsPerResolution.FirstOrDefault(a => a.screenResolution.width == calculatedWidth && a.screenResolution.height == newResolution.height);
                var existingList = outlineFeature.outlinePassSettingsPerResolution.ToList();
                if (resToCopy != null)
                {
                    var newOutlineSettings = new OutlineFeature.OutlinePassSettingsPerResolution
                    {
                        screenResolution = newResolution,
                        outlinePassSettings = resToCopy.outlinePassSettings
                    };

                    existingList.RemoveAll(a => a.screenResolution.width == newResolution.width && a.screenResolution.height == newResolution.height);
                    existingList.Add(newOutlineSettings);
                }

                outlineFeature.outlinePassSettingsPerResolution = existingList.ToArray();
            }
        }
    }

    /// <summary>
    /// Creates a new instance of <see cref="ScreenResolution"/> with system's height, width, and aspect ratio values.
    /// </summary>
    /// <returns>An instance of <see cref="ScreenResolution"/> with system's height, width, and aspect ratio values.</returns>
    /// <remarks>
    /// The system's height and width values are obtained from <see cref="Display.main"/>,
    /// and the aspect ratio is set to <see cref="ResolutionAspectRatio"/>.3.
    /// </remarks>
    private static ScreenResolution GetDisplayResScriptableObject()
    {
        var newResolution = ScriptableObject.CreateInstance<ScreenResolution>();
        newResolution.height = Plugin.MainHeight;
        newResolution.width = Plugin.MainWidth;
        newResolution.aspectRatio = (ResolutionAspectRatio) 3;
        return newResolution;
    }

    /// <summary>
    /// Prefix patch for the <see cref="RenderingManager.DetermineCurrentScreenResolution"/> method.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="RenderingManager"/> that the method is operating on.</param>
    /// <remarks>
    /// This method obtains a new <see cref="ScreenResolution"/> object from the <see cref="GetDisplayResScriptableObject"/> method,
    /// and adds it to the list of supported screen resolutions in the <see cref="RenderingManager"/> instance.
    /// This patch is applied before the original method execution (<see cref="HarmonyPrefix"/>).
    /// </remarks>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(RenderingManager), nameof(RenderingManager.DetermineCurrentScreenResolution))]
    public static void RenderingManager_DetermineCurrentScreenResolution(ref RenderingManager __instance)
    {
        var newResolution = GetDisplayResScriptableObject();
        __instance.supportedScreenResolutions.screenResolutions.Add(newResolution);
    }

    /// <summary>
    /// Postfix patch for the <see cref="ScreenResolutionWidgetBhv.DetermineLabel"/> method.
    /// </summary>
    /// <param name="resolution">The <see cref="ScreenResolution"/> object being processed.</param>
    /// <param name="__result">The result string that will be returned by the patched method.</param>
    /// <remarks>
    /// This method modifies the label string for the given screen resolution, adding the aspect ratio information.
    /// The aspect ratio is determined based on the <see cref="ResolutionAspectRatio"/> of the resolution. If the aspect ratio is unknown,
    /// it is displayed as "unknown". Otherwise, the ratio is added to the label in the format " (Width : Height)".
    /// This patch is applied after the original method execution (<see cref="HarmonyPostfix"/>).
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionWidgetBhv), nameof(ScreenResolutionWidgetBhv.DetermineLabel))]
    private static void ScreenResolutionWidget_DetermineLabel(ScreenResolution resolution, ref string __result)
    {
        var sCurrent = ConvertResolutionToRatio(resolution.width, resolution.height);
        var aspectRatioText = resolution.aspectRatio switch
        {
            ResolutionAspectRatio.AR_16x9 => " (16 : 9)",
            ResolutionAspectRatio.AR_16x10 => " (16 : 10)",
            (ResolutionAspectRatio) 3 => $" ({sCurrent.SimplifiedWidth} : {sCurrent.SimplifiedHeight})",
            _ => " (unknown)"
        };

        __result = $"{resolution.width} x {resolution.height}{aspectRatioText}";
    }

}