namespace GIJoeWrathOfCobra;

[Harmony]
public static class Patches
{
    private static readonly Vector2 TargetResolution = new(Plugin.MainWidth, Plugin.MainHeight);
    private static readonly List<GameObject> MetalDoors = [];
    private static readonly List<GameObject> MenuBackgrounds = [];
    private static GameObject TopGradientFade { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitterSetter), nameof(AspectRatioFitterSetter.OnEnable))]
    public static void AspectRatioFitterSetter_OnEnable(AspectRatioFitterSetter __instance)
    {
        if (__instance.name.Equals("Background"))
        {
            MenuBackgrounds.Add(__instance.gameObject);
            __instance.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1);
        }
    }

    internal static void UpdateHUD()
    {
        if (!TopGradientFade)
        {
            TopGradientFade = GameObject.Find("User Interface Canvas/In-Game User Interface/Gameplay Elements/Top Gradient Fade");
        }

        if (TopGradientFade)
        {
            TopGradientFade.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1);
            TopGradientFade.SetActive(!Plugin.TransparentHUD.Value);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(InGameUserInterface), nameof(InGameUserInterface.OnEnable))]
    public static void InGameUserInterface_OnEnable(InGameUserInterface __instance)
    {
        var top = __instance.transform.Find("Gameplay Elements/Top Gradient Fade");
        if (top)
        {
            TopGradientFade = top.gameObject;

            top.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1);
            top.gameObject.SetActive(!Plugin.TransparentHUD.Value);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LevelStart), nameof(LevelStart.OnEnable))]
    [HarmonyPatch(typeof(GameOver), nameof(GameOver.OnEnable))]
    [HarmonyPatch(typeof(LevelEnd), nameof(LevelEnd.OnEnable))]
    [HarmonyPatch(typeof(PauseMenu), nameof(PauseMenu.OnEnable))]
    public static void LevelStart_OnEnable(Panel __instance)
    {
        var top = __instance.transform.Find("Top Gradient");
        if (top)
        {
            top.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1);
        }

        var bottom = __instance.transform.Find("Bottom Gradient");
        if (bottom)
        {
            bottom.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UnlockShopScreen), nameof(UnlockShopScreen.OnStateEntered))]
    public static void UnlockShopScreen_OnStateEntered(UnlockShopScreen __instance)
    {
        var leftGradient = __instance.transform.Find("Shopfade Left");
        if (leftGradient)
        {
            leftGradient.localPosition = new Vector3(-Plugin.WidthDifference, 0, 0);
        }

        var rightGradient = __instance.transform.Find("Shopfade Right");

        if (rightGradient)
        {
            rightGradient.localPosition = new Vector3(Plugin.WidthDifference, 0, 0);
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroSequenceScreen), nameof(IntroSequenceScreen.OnStateEntered))]
    public static bool IntroSequenceScreen_OnStateEntered(IntroSequenceScreen __instance)
    {
        __instance.Open();
        ScriptableObjectSingleton<AudioManager>.Instance.TryLoadData();

        __instance.pressStartCanvasGroup.Close();
        __instance.logoAnimator.Play("Hidden");

        if (Plugin.SkipIntroCinematic.Value)
        {
            __instance.videoPlayer.Stop();
            __instance.videoPlayerCanvasGroup.Close();
            __instance.Close();
            __instance.mainMenu.PlayMusic(__instance.mainMenu.MainMenuMusic);
            __instance.mainMenu.ChangePanel(__instance.mainMenu.Panels.Title);
        }
        else
        {
            __instance.curState = IntroSequenceScreen.IntroState.IntroCinematic;
            __instance.videoPlayer.loopPointReached += source => IntroSequenceScreen_OnVideoCompleted(__instance, source);
            __instance.videoPlayer.isLooping = false;
            __instance.videoPlayer.clip = __instance.cinematicVideo;
            __instance.videoPlayer.Play();
            __instance.videoPlayerCanvasGroup.Open();
        }
        
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(IntroSequenceScreen), nameof(IntroSequenceScreen.OnVideoCompleted))]
    private static void IntroSequenceScreen_OnVideoCompleted(IntroSequenceScreen __instance, VideoPlayer source)
    {
        __instance.videoPlayerCanvasGroup.Close();
        __instance.Close();
        __instance.mainMenu.ChangePanel(__instance.mainMenu.Panels.Title);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        if (__instance.clip.name.Contains("indie", StringComparison.OrdinalIgnoreCase))
        {
            return; //don't apply to intro's
        }

        var rawImage = __instance.GetComponentInChildren<RawImage>();
        var exists = __instance.transform.Find("Video Background");
        if (rawImage && !exists)
        {
            rawImage.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1);
            var background = new GameObject("Video Background");
            var image = background.GetOrAddComponent<Image>();
            background.GetOrAddComponent<CanvasRenderer>();
            var rect = background.GetOrAddComponent<RectTransform>();
            image.color = Color.black;
            rect.anchoredPosition = Vector2.zero;
            rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
            background.transform.SetParent(__instance.transform, false);
            background.transform.SetAsFirstSibling();
        }
    }

    internal static void UpdateMetalDoors()
    {
        var doors = Resources.FindObjectsOfTypeAll<AspectRatioFitter>()
            .Where(a => a.name.Equals("Metal Doors"))
            .Select(a => a.gameObject);

        MetalDoors.AddRange(doors);

        foreach (var door in MetalDoors.ToList().Where(door => door))
        {
            door.SetActive(Plugin.MenuMetalDoors.Value);
        }
    }

    internal static void UpdateMenuBackgrounds()
    {
        var backgrounds = Resources.FindObjectsOfTypeAll<AspectRatioFitterSetter>()
            .Where(a => a.name.Equals("Background"))
            .Select(a => a.gameObject);

        MenuBackgrounds.AddRange(backgrounds);

        foreach (var background in MenuBackgrounds.ToList().Where(background => background))
        {
            background.transform.localScale = Plugin.ScaleMenuBackgrounds.Value ? new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1) : new Vector3(1f, 1f, 1);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        if (__instance.name.Equals("Metal Doors"))
        {
            MetalDoors.Add(__instance.gameObject);
            __instance.gameObject.SetActive(Plugin.MenuMetalDoors.Value);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraAspectController), nameof(CameraAspectController.Update))]
    public static void CameraAspectController_OnEnable(CameraAspectController __instance)
    {
        __instance.targetResolution = TargetResolution;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CharacterSelectScreen), nameof(CharacterSelectScreen.OnStateEntered))]
    public static void CharacterSelectScreen_OnStateEntered(CharacterSelectScreen __instance)
    {
        var black = __instance.readyOverlayAnimator.transform.Find("Black Overlay");
        if (black)
        {
            black.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1);
        }
    }
}