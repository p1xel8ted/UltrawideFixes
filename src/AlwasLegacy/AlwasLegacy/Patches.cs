using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using AlwasLegacy.AspectRatio;
using AlwasLegacy.Misc;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace AlwasLegacy;

[HarmonyPatch]
public static class Patches
{

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(PressAdjustValues), nameof(PressAdjustValues.Resolution))]
    [HarmonyPatch(typeof(PressAdjustValues), nameof(PressAdjustValues.UpdateValues))]
    public static IEnumerable<CodeInstruction> PressAdjustValues_Resolution(IEnumerable<CodeInstruction> instructions)
    {
        var codes = instructions.ToList();
        foreach (var t in codes.Where(t => t.opcode == OpCodes.Ldc_I4_4))
        {
            t.opcode = OpCodes.Ldc_I4_5;
        }
        return codes.AsEnumerable();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraScript), nameof(CameraScript.LateUpdate))]
    public static void CameraScript_LateUpdate(ref CameraScript __instance)
    {
        if (Math.Abs(__instance.playerScreenPos.x - Plugin.BlackBarSize) <= Plugin.EdgeDetectionBuffer.Value)
        {
            __instance.playerScreenPos.x = 0;
        }

        if (Math.Abs(__instance.playerScreenPos.x - (Screen.currentResolution.width - Plugin.BlackBarSize)) <= Plugin.EdgeDetectionBuffer.Value)
        {
            __instance.playerScreenPos.x = Screen.currentResolution.width;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PauseManager), nameof(PauseManager.EnterPause))]
    public static void PauseManager_EnterPause(ref PauseManager __instance)
    {
        var rect = __instance.bgObject.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Screen.currentResolution.width, Screen.currentResolution.height);
        rect.localPosition = new Vector3(0, 0, 0);
        __instance.bgObject.gameObject.SetActive(true);
        __instance.parentNode.Find("Vignette").gameObject.SetActive(false);
        __instance.parentNode.Find("SlidePanel/Inventory/MidBigPanel/Info_BottomMidBG/DarkOverlay").gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FileSelect), nameof(FileSelect.LoadGame))]
    [HarmonyPatch(typeof(FileSelect), nameof(FileSelect.LoadLatestSave))]
    public static void FileSelect_Load(ref FileSelect __instance)
    {
        foreach (var rect in __instance.loadingScreenNode.GetComponentsInChildren<RectTransform>())
        {
            if (rect.name.Equals("BlackBG"))
            {
                rect.sizeDelta = new Vector2(Screen.currentResolution.width, Screen.currentResolution.height);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(InfoPopup), MethodType.Constructor)]
    public static void InfoPopup_Constructor(ref Vector2 ___outsidePos, ref Vector2 ___insidePos)
    {
        ___outsidePos = new Vector2(-640f * Plugin.PositiveScaleFactor, -155f);
        ___insidePos = new Vector2(-254f * Plugin.PositiveScaleFactor - 25f, -155f);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PauseManager), nameof(PauseManager.ExitPause))]
    public static void PauseManager_ExitPause(ref PauseManager __instance)
    {
        __instance.bgObject.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Start))]
    public static void HudManager_Start(ref HudManager __instance)
    {
        var newTopLeft = new GameObject("NewTopLeft");
        newTopLeft.transform.SetParent(__instance.transform, true);

        foreach (var hud in __instance.topLeftHud)
        {
            hud.transform.SetParent(newTopLeft.transform, true);
        }
        newTopLeft.TryAddComponent<LeftHudMover>();

        var newTopRight = new GameObject("NewTopRight");
        newTopRight.transform.SetParent(__instance.transform, true);
        foreach (var hud in __instance.topRightHud)
        {
            hud.transform.SetParent(newTopRight.transform, true);
        }
        newTopRight.TryAddComponent<RightHudMover>();

        __instance.parentNode.SetAsLastSibling();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MoveCanvasOnStart), nameof(MoveCanvasOnStart.Start))]
    public static void MoveCanvasOnStart_Start(ref MoveCanvasOnStart __instance)
    {
        var borders = __instance.transform.Find("Borders");
        borders.transform.localScale = borders.transform.localScale with {x = 1000f};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuSwipeAnimation), nameof(MenuSwipeAnimation.Start))]
    public static void MenuSwipeAnimation_Start(ref MenuSwipeAnimation __instance)
    {
        var fadeImage = GameObject.Find("Canvas/FadeImage");
        if (fadeImage)
        {
            fadeImage.gameObject.SetActive(false);
        }

        var mainMenu = GameObject.Find("Canvas");
        if (!mainMenu)
        {
            Plugin.LOG.LogError("Canvas not found!");
            return;
        }
        var bg = GameObject.Find("Background");
        if (bg)
        {
            Object.Destroy(bg);
        }

        var newBackground = new GameObject("NewBackground");
        newBackground.transform.SetParent(mainMenu.transform, false);
        newBackground.transform.SetAsFirstSibling();
        newBackground.SetActive(true);

        var rectTransform = newBackground.AddComponent<RectTransform>();
        rectTransform.anchorMin = Vector2.zero;
        rectTransform.anchorMax = Vector2.one;
        rectTransform.pivot = new Vector2(0.5f, 0.5f);
        rectTransform.offsetMin = rectTransform.offsetMax = Vector2.zero;

        newBackground.AddComponent<CanvasRenderer>();
        var canvas = newBackground.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        var newImage = newBackground.AddComponent<Image>();

        var resourceName = Plugin.MainAspectRatio switch
        {
            >= Plugin.SuperWideAspectRatio => "AlwasLegacy.assets.32-9.jpg",
            > Plugin.BaseAspectRatio => "AlwasLegacy.assets.21-9.jpg",
            _ => "AlwasLegacy.assets.21-9.jpg"
        };

        var assembly = Assembly.GetExecutingAssembly();
        var texture = new Texture2D(2, 2);

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                Plugin.LOG.LogError($"Embedded image resource not found: {resourceName}");
                return;
            }

            var imageData = new byte[stream.Length];
            _ = stream.Read(imageData, 0, imageData.Length);
            texture.LoadImage(imageData);
        }

        newImage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        newImage.type = Image.Type.Simple;
        newImage.preserveAspect = true;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuScript), nameof(MainMenuScript.ExitSettings))]
    [HarmonyPatch(typeof(MainMenuScript), nameof(MainMenuScript.Start))]
    public static void MainMenuScript_ExitSettings(ref MainMenuScript __instance)
    {
        __instance.settingsParent.transform.localPosition = new Vector2(640f + Plugin.MainWidth, 0f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.Awake))]
    public static void SettingsManager_Awake(ref SettingsManager __instance)
    {
        __instance.resolutionTexts = __instance.resolutionTexts.Concat(new[] {$"{Plugin.MainWidth}x{Plugin.MainHeight}"}).ToArray();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SplashScreens), nameof(SplashScreens.Start))]
    public static void SplashScreens_WaitForSplashScreens(ref SplashScreens __instance)
    {
        __instance.delay = 0f;
        __instance.splashScreens.videosToPlay.Clear();
        __instance.splashScreens.finishedPlaying = true;
        __instance.controllerNode.SetActive(false);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CutsceneBorders), nameof(CutsceneBorders.ShowBorders))]
    public static bool CutsceneBorders_ShowBorders()
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.GetResolutionIndex))]
    public static void SettingsManager_GetResolutionIndex(ref int __result)
    {
        var currentResolution = Screen.currentResolution;
        if (currentResolution.width == Plugin.MainWidth && currentResolution.height == Plugin.MainHeight)
        {
            __result = 5;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.ChangeResolution))]
    public static bool SettingsManager_ChangeResolution(ref SettingsManager __instance, ref int res, ref bool waitForConfirmation)
    {
        if (res != 5) return true;
        
        var fullScreen = SystemSaveSettings.instance.fullscreenIndex != 1;
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, fullScreen);
        if (waitForConfirmation && SystemSaveSettings.instance.resolutionIndex != __instance.changedResolutionIndex)
        {
            __instance.confirmTimer = 10f;
            __instance.navigationActive = false;
            __instance.usingConfirmResolution = TranslationsManager.instance.FindOutput(__instance.confirmResolutionString);
            __instance.nodeOrder = SettingsManager.NodeOrders.confirmState;
        }
        
        return false;
    }
}