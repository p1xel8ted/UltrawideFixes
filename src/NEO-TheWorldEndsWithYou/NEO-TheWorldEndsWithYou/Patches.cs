namespace NEOTheWorldEndsWithYouUltraWide;

[Harmony]
public static class Patches
{
    // private static Camera ComicCamera { get; set; }
    private static GameObject BlackBarCanvas { get; set; }
    private static GameObject LeftBlackBar { get; set; }
    private static GameObject RightBlackBar { get; set; }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattleScene), nameof(BattleScene.OnAwake))]
    [HarmonyPatch(typeof(BattleScene), nameof(BattleScene.OnStart))]
    [HarmonyPatch(typeof(BattleScene), nameof(BattleScene.OnInitialize))]
    public static void BattleScene_OnAwake()
    {
        RestrictCamera();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattleResultScene), nameof(BattleResultScene.OnStart))]
    public static void BattleResultScene_OnStart(ref BattleResultScene __instance)
    {
        EnablePillarBoxing();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattleResultScene), nameof(BattleResultScene.OnDestroy))]
    public static void BattleResultScene_OnDestroy(ref BattleResultScene __instance)
    {
        DisablePillarBoxing();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattlePauseUI), nameof(BattlePauseUI.OnAwake))]
    public static void BattlePauseUI_OnAwake()
    {
        EnablePillarBoxing();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattlePauseUI), nameof(BattlePauseUI.OnCancel))]
    [HarmonyPatch(typeof(BattlePauseUI), nameof(BattlePauseUI.OnDecide))]
    public static void BattlePauseUI_OnCancel()
    {
        DisablePillarBoxing();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        var bg = __instance.transform.FindChild("Setting/BG");
        if (bg)
        {
            bg.transform.localScale = bg.transform.localScale with {x = Plugin.PositiveScaleFactor};
        }

        var fadebg = __instance.transform.FindDeepChild("fade_bg", StringComparison.OrdinalIgnoreCase);
        if (fadebg)
        {
            fadebg.transform.localScale = fadebg.transform.localScale with {x = Plugin.PositiveScaleFactor};
        }

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        if (__instance.name.Contains("transition", StringComparison.OrdinalIgnoreCase))
        {
            EnablePillarBoxing();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnDisable))]
    public static void CanvasScaler_OnDisable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("transition", StringComparison.OrdinalIgnoreCase))
        {
            DisablePillarBoxing();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ComicEventDirector), nameof(ComicEventDirector.End))]
    public static void ComicEventDirector_End(ref ComicEventDirector __instance)
    {
        var text = $"ComicEventDirector End {__instance.name} is";
        if (Utils.IsMain(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} main");
            ProcessComicStripOptionsEnd();
        }
        else if (Utils.IsBefore(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} before");
            ProcessComicStripOptionsEnd();
        }
        else if (Utils.IsChatter(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} chatter");
            ProcessNpcChatterOptionsEnd();
        }
        else if (Utils.IsMission(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} mission");
            ProcessComicStripOptionsEnd();
        }
        else if (Utils.IsChoice(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} choice");
            ProcessComicStripOptionsEnd();
        }
        else
        {
            Plugin.Logger.LogWarning($"{text} unknown");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScenarioMovieManager), nameof(ScenarioMovieManager.Stop))]
    public static void ScenarioMovieManager_Stop(ref ScenarioMovieManager __instance)
    {
        DisablePillarBoxing();
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

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScenarioMovieManager), nameof(ScenarioMovieManager.PlayMovie))]
    public static void ScenarioMovieManager_PlayMovie(ref ScenarioMovieManager __instance)
    {
        EnablePillarBoxing();
        RestrictCamera();
    }

    private static void RestoreCamera()
    {
        var camera = UIManager.Instance.mCamera2D;
        camera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        camera.aspect = Plugin.MainAspectRatio;
    }

    private static void RestrictCamera()
    {
        var camera = UIManager.Instance.mCamera2D;
        camera.pixelRect = new Rect(Plugin.BlackBarSize, 0, Plugin.CameraWidth, Plugin.CameraHeight);
        camera.aspect = Plugin.BaseAspectRatio;
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
    
    private static void ProcessComicStripOptionsEnd()
    {
        if (Plugin.CenterComicStripDialog.Value)
        {
            RestoreCamera();
            if (Plugin.PillarBoxComicStripDialog.Value)
            {
                DisablePillarBoxing();
            }
        }
    }
    
    private static void ProcessComicStripOptionsStart()
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
    }

    private static void ProcessNpcChatterOptionsEnd()
    {
        if (Plugin.CenterNpcChatter.Value)
        {
            RestoreCamera();
            if (Plugin.PillarBoxNpcChatter.Value)
            {
                DisablePillarBoxing();
            }
        }
    }
    private static void ProcessNpcChatterOptionsStart()
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
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ComicEventDirector), nameof(ComicEventDirector.Play))]
    public static void ComicEventDirector_OnPlayBegin(ref ComicEventDirector __instance)
    {
        var text = $"ComicEventDirector Play {__instance.name} is";
        if (Utils.IsMain(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} main");
            ProcessComicStripOptionsStart();
        }
        else if (Utils.IsBefore(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} before");
            ProcessComicStripOptionsStart();
        }
        else if (Utils.IsChatter(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} chatter");
            ProcessNpcChatterOptionsStart();
        }
        else if (Utils.IsMission(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} mission");
            ProcessComicStripOptionsStart();
        }
        else if (Utils.IsChoice(__instance.name))
        {
            Plugin.Logger.LogInfo($"{text} choice");
            ProcessComicStripOptionsStart();
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