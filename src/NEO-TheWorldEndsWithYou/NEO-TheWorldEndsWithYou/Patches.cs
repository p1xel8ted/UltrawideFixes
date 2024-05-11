using System;
using ComicEvent;
using HnLib;
using UI.Battle;
using UI.Event;

namespace NEOTheWorldEndsWithYouUltraWide;

[Harmony]
public static class Patches
{
    private static Camera ComicCamera { get; set; }
    private static GameObject BlackBarCanvas { get; set; }
    private static GameObject LeftBlackBar { get; set; }
    private static GameObject RightBlackBar { get; set; }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(UIManager), nameof(UIManager.))]
    // public static void UIManager_SetupCreateUI(GameObject go, GameObject prefab)
    // {
    //     Plugin.Logger.LogWarning($"UIManager.SetupCreateUI: {go.name} {prefab.name}");
    // }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattlePauseUI), nameof(BattlePauseUI.OnAwake))]
    public static void BattlePauseUI_OnAwake(ref BattlePauseUI __instance)
    {
        EnablePillarBoxing();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattlePauseUI), nameof(BattlePauseUI.OnCancel))]
    [HarmonyPatch(typeof(BattlePauseUI), nameof(BattlePauseUI.OnDecide))]
    public static void BattlePauseUI_OnCancel(ref BattlePauseUI __instance)
    {
        DisablePillarBoxing();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        if (__instance.name.Contains("transition", StringComparison.OrdinalIgnoreCase))
        {
            EnablePillarBoxingAndRestrictCamera();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnDisable))]
    public static void CanvasScaler_OnDisable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("transition", StringComparison.OrdinalIgnoreCase))
        {
            DisablePillarBoxingAndRestoreCamera();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ComicEventDirector), nameof(ComicEventDirector.End))]
    public static void ComicEventDirector_End(ref ComicEventDirector __instance)
    {
        DisablePillarBoxingAndRestoreCamera();
    }

    private static void DisablePillarBoxingAndRestoreCamera()
    {
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(false);
        }
        RestoreCamera();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScenarioMovieManager), nameof(ScenarioMovieManager.Stop))]
    public static void ScenarioMovieManager_Stop(ref ScenarioMovieManager __instance)
    {
        DisablePillarBoxingAndRestoreCamera();
    }

    private static void EnablePillarBoxing()
    {
        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(true);
        }
    }

    private static void DisablePillarBoxing()
    {
        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(false);
        }
    }

    private static void EnablePillarBoxingAndRestrictCamera()
    {
        EnablePillarBoxing();
        RestrictCamera();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScenarioMovieManager), nameof(ScenarioMovieManager.PlayMovie))]
    public static void ScenarioMovieManager_PlayMovie(ref ScenarioMovieManager __instance)
    {
        EnablePillarBoxing();
        RestrictCamera();
    }

    private static void RestoreCamera()
    {
        var camera = ComicCamera = UIManager.Instance.mCamera2D;
        camera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        camera.aspect = Plugin.MainAspectRatio;
    }

    private static void RestrictCamera()
    {
        var camera = ComicCamera = UIManager.Instance.mCamera2D;
        if (Plugin.CenterComicStripDialog.Value)
        {
            camera.pixelRect = new Rect(Plugin.BlackBarSize, 0, Plugin.CameraWidth, Plugin.CameraHeight);
            camera.aspect = Plugin.BaseAspectRatio;
        }
        else
        {
            camera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
            camera.aspect = Plugin.MainAspectRatio;
        }
    }

    private static void CreateBlackBars()
    {
        if (!BlackBarCanvas)
        {
            BlackBarCanvas = new GameObject("BlackBarCanvas");
            var canvas = BlackBarCanvas.TryAddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            if (!LeftBlackBar)
            {
                LeftBlackBar = new GameObject("LeftBlackBar");
                LeftBlackBar.transform.SetParent(canvas.transform, false);
                var leftImage = LeftBlackBar.TryAddComponent<Image>();
                leftImage.color = Color.black;
                var leftRect = leftImage.GetComponent<RectTransform>();
                leftRect.anchorMin = new Vector2(0, 0);
                leftRect.anchorMax = new Vector2(0, 1);
                leftRect.offsetMin = new Vector2(0, 0);
                leftRect.offsetMax = new Vector2(Plugin.BlackBarSize, 0);
            }

            if (!RightBlackBar)
            {
                RightBlackBar = new GameObject("RightBlackBar");
                RightBlackBar.transform.SetParent(canvas.transform, false);
                var rightImage = RightBlackBar.TryAddComponent<Image>();
                rightImage.color = Color.black;
                var rightRect = rightImage.GetComponent<RectTransform>();
                rightRect.anchorMin = new Vector2(1, 0);
                rightRect.anchorMax = new Vector2(1, 1);
                rightRect.offsetMin = new Vector2(-Plugin.BlackBarSize, 0);
                rightRect.offsetMax = new Vector2(0, 0);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(EventChoice), nameof(EventChoice.OnEnable))]
    public static void EventChoice_OnEnable(ref EventChoice __instance)
    {
        var bg = __instance.transform.FindDeepChild("BG");
        if (!bg) return;
        var rect = bg.GetComponent<RectTransform>();
        if (rect)
        {
            var y = rect.sizeDelta.y;
            var newX = y * Plugin.MainAspectRatio;
            rect.sizeDelta = new Vector2(newX, y);
        }
        else
        {
            bg.localScale = bg.localScale with {x = Plugin.PositiveScaleFactor};
        }
    }
    
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(UIChoicePanel.ChoicePanelObject), nameof(UIChoicePanel.ChoicePanelObject.SetItemActive))]
    // public static void UIChoicePanel_OnEnable(ref UIChoicePanel.ChoicePanelObject __instance)
    // {
    //     var bg =   __instance.Object.transform.FindDeepChild("BG");
    //     if (!bg) return;
    //     var rect = bg.GetComponent<RectTransform>();
    //     if (rect)
    //     {
    //         var y = rect.sizeDelta.y;
    //         var newX = y * Plugin.MainAspectRatio;
    //         rect.sizeDelta = new Vector2(newX, y);
    //     }
    //     else
    //     {
    //         bg.localScale = bg.localScale with {x = Plugin.PositiveScaleFactor};
    //     }
    // }

    private static void ProcessComicStripOptions()
    {
        if (Plugin.CenterComicStripDialog.Value)
        {
            RestrictCamera();
            if (Plugin.PillarBoxComicStripDialog.Value)
            {
                EnablePillarBoxing();
            }
            else
            {
                DisablePillarBoxing();
            }
        }
        else
        {
            DisablePillarBoxingAndRestoreCamera();
        }
    }

    private static void ProcessNpcChatterOptions()
    {
        if (Plugin.CenterNpcChatter.Value)
        {
            RestrictCamera();
            if (Plugin.PillarBoxNpcChatter.Value)
            {
                EnablePillarBoxing();
            }
            else
            {
                DisablePillarBoxing();
            }
        }
        else
        {
            DisablePillarBoxingAndRestoreCamera();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ComicEventDirector), nameof(ComicEventDirector.Play))]
    public static void ComicEventDirector_OnPlayBegin(ref ComicEventDirector __instance)
    {
        var text = $"ComicEventDirector {__instance.name} is";
        if (Utils.IsMain(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} main");
            ProcessComicStripOptions();
        }
        else if (Utils.IsBefore(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} before");
            ProcessComicStripOptions();
        }
        else if (Utils.IsChatter(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} chatter");
            ProcessNpcChatterOptions();
        }
        else if (Utils.IsMission(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} mission");
            ProcessComicStripOptions();
        }
        else if (Utils.IsChoice(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} choice");
            ProcessComicStripOptions();
        }
        else
        {
            Plugin.Logger.LogWarning($"{text} unknown");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GlobalBehaviour), nameof(GlobalBehaviour.CalcAspectAdjustSize16By9))]
    [HarmonyPatch(typeof(GlobalBehaviour), nameof(GlobalBehaviour.CalcAspectAdjustSize))]
    public static void GlobalBehaviour_CalcAspectAdjustSize(ref Vector2Int size, ref Vector2Int __result)
    {
        size = new Vector2Int(Plugin.MainWidth, Plugin.MainHeight);
        __result = new Vector2Int(Plugin.MainWidth, Plugin.MainHeight);
    }
}