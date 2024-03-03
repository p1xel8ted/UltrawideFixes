namespace LittleGoodyTwoShoes;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.Load))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultLighting))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultWeather))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultWind))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultPostProcessing))]
    public static void LightingLoader_Load(ref LightingLoader __instance)
    {
        Plugin.LightingLoaderInstance = __instance;
        Plugin.UpdateLightingWeight();
        Plugin.UpdatePauseFrame();
        Plugin.UpdateDialogueFrame();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        Utils.UpdateScaler(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsConfigMenu), nameof(GraphicsConfigMenu.Start))]
    [HarmonyPatch(typeof(GraphicsConfigMenu), nameof(GraphicsConfigMenu.Refresh))]
    private static void GraphicsConfigMenu_Start(ref GraphicsConfigMenu __instance)
    {
        //forces the fullscreen window and locks the options
        __instance.windowed.currentIndex = 1;
        __instance.windowed.LockOptions(1);
        __instance.windowed.left.interactable = false;
        __instance.windowed.right.interactable = false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    private static void VideoPlayer_Play(VideoPlayer __instance)
    {
        //forces the video to fit vertically
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicsConfigMenu), nameof(GraphicsConfigMenu.OnScreenModeChange))]
    private static void GraphicsConfigMenu_OnScreenModeChange(ref int index)
    {
        //forces the fullscreen window
        index = 1;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(DialogueWindow), nameof(DialogueWindow.StartConversation))]
    private static void DialogueWindow_Show(ref DialogueWindow __instance, ref bool frameless)
    {
        //forces the dialogue window to be frameless based on config and enables auto advance
        if (Plugin.AutoAdvanceConfig.Value)
        {
            __instance.controller.auto = false;
            __instance.ToggleAuto();
        }
        __instance.settingsPanel.SetActive(false);
        frameless = !Plugin.DialogueFrameConfig.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Parallax), nameof(Parallax.Start))]
    private static void Parallax_Start(Parallax __instance)
    {
        var name = __instance.name;
        var path = __instance.gameObject.GetGameObjectPath();
        if (name.Equals(Const.BG) && path.Contains(Const.TitleUI))
        {
            var transform = __instance.transform;
            transform.localScale = transform.localScale with {x = Plugin.PositiveScaleFactor + 0.200f, y = Plugin.PositiveScaleFactor + 0.200f};
            __instance.enabled = false;

            var bg1 = __instance.transform.Find(Const.Bg1);
            PerformPositiveXYScale(bg1);

            var bg2 = __instance.transform.Find(Const.Bg2);
            PerformPositiveXYScale(bg2);
        }
    }

    private static void PerformPositiveXYScale(Transform tf)
    {
        tf.localScale = tf.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
    }

    private static void PerformPositiveXScale(Transform tf)
    {
        tf.localScale = tf.localScale with {x = Plugin.PositiveScaleFactor};
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(QuestGoalUpdate), nameof(QuestGoalUpdate.Start))]
    private static void QuestGoalUpdate_Start(QuestGoalUpdate __instance)
    {
        var transform = __instance.transform;

        var position = transform.position;

        position = position with {x = position.x * Plugin.PositiveScaleFactor};

        transform.position = position;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AllIn1Shader), nameof(AllIn1Shader.OnEnable))]
    private static void AllIn1Shader_OnEnable(AllIn1Shader __instance)
    {
        if (__instance.name.Equals(Const.Fader))
        {
            PerformPositiveXScale(__instance.transform);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameObject), nameof(GameObject.SetActive))]
    private static void GameObject_SetActive(GameObject __instance, ref bool value)
    {
        //disable the splash screen and photo sensitive warning
        if (__instance.name.Equals(Const.SplashCanvas) || __instance.name.Equals(Const.PhotoSensitiveWarning))
        {
            value = false;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LgtsUtils), nameof(LgtsUtils.SetTimeout))]
    private static void LgtsUtils_SetTimeout(ref float timeout, ref Action action)
    {
        //skip the delay between showing the splash screen and the photo sensitive warning and playing the video
        if (Mathf.Approximately(6.5f, timeout))
        {
            timeout = 0;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.FilterResolutions))]
    public static void SettingsManager_FilterResolutions(ref SettingsManager __instance)
    {
        //makes sure the custom resolution is the only one available
        __instance._resolutions.Clear();
        var res = new Resolution
        {
            height = Plugin.MainHeight,
            width = Plugin.MainWidth,
            refreshRate = Plugin.MaxRefresh
        };
        __instance._resolutions.Add(res);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.SetResolution))]
    public static void SettingsManager_SetResolution(ref int index)
    {
        //forces the custom resolution
        index = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.SetScreenMode))]
    public static void SettingsManager_SetScreenMode(ref int index)
    {
        //fullscreen window to preserve aspect ratio
        index = 1;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(StartingPosition), nameof(StartingPosition.VerifyAndApplyPosition))]
    public static void StartingPosition_VerifyAndApplyPosition()
    {
        if (!Plugin.CameraZoomConfig.Value) return;
        if (Camera.main == null) return;
        //figure is irrelevant, just needs to be a number as it gets patched in the setter
        Camera.main.orthographicSize = 5f;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.Start))]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.Awake))]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.SetScreenSize))]
    public static void ProCamera2D_Start(ref ProCamera2D __instance)
    {
        Plugin.ProCamera2DInstance = __instance;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.orthographicSize), MethodType.Setter)]
    private static void Camera_OrthographicSize_Setter(ref float value)
    {
        if (!Plugin.CameraZoomConfig.Value) return;
        //adjusts the orthographic size of the camera
        value = Utils.GetBaseOrthographicSize(Plugin.ProCamera2DInstance) * Plugin.CameraZoomConfigValue.Value;
        if (value <= 2f)
        {
            value = 2f;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(RuntimeManager), nameof(RuntimeManager.PlayOneShot), typeof(string), typeof(Vector3))]
    private static bool RuntimeManager_PlayOneShot(string path)
    {
        //stops the title menu voice over from playing
        if (Plugin.TitleMenuVoiceOver.Value) return true;
        return !path.Contains(Const.GameTitleVo);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(TitleScreenManager), nameof(TitleScreenManager.Start))]
    public static void TitleScreenManager_Start(ref TitleScreenManager __instance)
    {
        var sceneBg = GameObject.Find("Scene/Background/Background");
        sceneBg.transform.position = sceneBg.transform.position with {x = -Plugin.PositiveScaleFactor};
        sceneBg.transform.localScale = sceneBg.transform.localScale with {x = Plugin.PositiveScaleFactor};
        
        var creditsButton = GameObject.Find(Const.CreditsButtonPath);
        creditsButton.SetActive(false);

        //skip the animation video/intro and the press any key screen

        if (!Plugin.GoStraightToTitleMenu.Value) return;


        var flash = GameObject.Find(Const.IntroAnimationFlashTitlePath);
        if (flash != null)
        {
            flash.SetActive(false);
            Object.Destroy(flash);
        }
        
        __instance.PlayTitleMusic();
        __instance.OnAfterShowAnyKeyPressed();
        __instance.ShowLogo();
      
    }
}