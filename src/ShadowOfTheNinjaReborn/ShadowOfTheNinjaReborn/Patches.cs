namespace ShadowOfTheNinjaReborn;

[Harmony]
public static class Patches
{
    private const string TitleScene = "TitleMenu";
    private const string FadeCanvas = "FadeCanvas";
    private const string MainCamera = "Main Camera";

    private static void UpdateLetterbox(bool enabled)
    {
        var lbc = Utils.FindIl2CppType<LetterBoxControl>();
        foreach (var lb in lbc.Where(lb => lb.obj))
        {
            lb.obj.SetActive(enabled);
        }

        if (!AspectCamera.Instance) return;

        if (enabled)
        {
            AspectCamera.Instance.width = AspectCamera.Instance.height * Plugin.NativeAspect;
        }
        else
        {
            AspectCamera.Instance.width = AspectCamera.Instance.height * Plugin.CurrentAspect;
        }
    }
    
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(nnObjSky), nameof(nnObjSky.StepInit))]
    // public static void nnObjSky_OnEnable(nnObjSky __instance)
    // {
    //     var aspectRatio = Plugin.CurrentAspect;
    //     var scale = new Vector3(1f, 1f, 1f);
    //
    //     if (Plugin.ScaleBackgrounds.Value)
    //     {
    //         scale = aspectRatio switch
    //         {
    //             // 48:9 or similar
    //             > 5.0f => new Vector3(1.5f, 1.5f, 1f),
    //             // 32:9 or similar
    //             > 3.5f => new Vector3(1.25f, 1.25f, 1f),
    //             _ => scale
    //         };
    //     }
    //
    //     if (aspectRatio > 2.0f) // 21:9 or similar
    //     {
    //         scale = new Vector3(1.1f, 1.1f, 1f);
    //     }
    //
    //     __instance.localScale = scale;
    // }



    private static void UpdateCameraBackgrounds()
    {
        var ct = Resources.FindObjectsOfTypeAll<nnObjCameraTrace>();
        foreach (var c in ct)
        {
            if (Plugin.ScaleBackgrounds.Value)
            {
                c.localScaleX = Plugin.ScaleFactor;
                c.localScaleY = Plugin.ScaleFactor;
            }
            else
            {
                c.localScaleX = 1f;
                c.localScaleY = 1f;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameOver), nameof(GameOver.OnEnable))]
    public static void GameOver_OnEnable(GameOver __instance)
    {
        var cam = __instance.GetComponentInChildren<Camera>();
        if (cam)
        {
            cam.aspect = Plugin.CurrentScreenAspect;
        }
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MakerLogo), nameof(MakerLogo.Start))]
    public static void MakerLogo_Start()
    {
        // SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
        // SplashScreen.CancelSplashScreen();
        // SceneManager.LoadScene(TitleScene, LoadSceneMode.Single);

        UpdateLetterbox(true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(StaffRoll), nameof(StaffRoll.Start))]
    [HarmonyPatch(typeof(TitleMovie), nameof(TitleMovie.Start))]
    [HarmonyPatch(typeof(EdDemoRoot), nameof(EdDemoRoot.Start))]
    [HarmonyPatch(typeof(OpDemoRoot), nameof(OpDemoRoot.Start))]
    [HarmonyPatch(typeof(TitleMenu), nameof(TitleMenu.Start))]
    [HarmonyPatch(typeof(ItemShop), nameof(ItemShop.Start))]
    public static void TitleMenu_Start()
    {
        UpdateLetterbox(true);
    }

    private static void FixWhiteLines()
    {
        var characters = Resources.FindObjectsOfTypeAll<nnObjPlayer>();
        if (!Plugin.UseTwentyOneNine.Value)
        {
            foreach (var ch in characters)
            {
                ch.localScaleX = 0.97f;
                ch.localScaleY = 0.98f;
            }
        }
        else
        {
            foreach (var ch in characters)
            {
                ch.localScaleX = 1f;
                ch.localScaleY = 1f;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(nnObjPlayer), nameof(nnObjPlayer.StepInit))]
    public static void nnObjPlayer_StepInit(nnObjPlayer __instance)
    {
        FixWhiteLines();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionMenuPage), nameof(OptionMenuPage.Start))]
    public static void OptionMenuPage_Start()
    {
        UpdateLetterbox(SceneManager.GetActiveScene().name.Equals(TitleScene));
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.FadeStart))]
    public static void GameMain_FadeStart(GameMain __instance)
    {
        var transform = __instance.m_GameFadeQuad.transform;
        var x = transform.localScale.x;
        var y = transform.localScale.y;
        var newX = x * Plugin.ScaleFactor;
        __instance.m_GameFadeQuad.transform.localScale = new Vector3(newX, y, 1f);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        var fadeCanvas = __instance.transform.Find(FadeCanvas);
        if (fadeCanvas)
        {
            fadeCanvas.localScale = new Vector3(Plugin.ScaleFactor, 1f, 1f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.Init_GameStart))]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.Init_GameArea))]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.Init_GameRetry))]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.Init_GameContinue))]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.Init_GameStage))]
    internal static void GameMain_Init_GameStage()
    {
        RunFixes();
    }

    private static Camera MainCameraInstance => Camera.allCameras.FirstOrDefault(a => a.name.Equals(MainCamera));
    private static MeshRenderer MainMeshRendererInstance => GameObject.Find("Common/MasterCamera/VirtualDisplay480x270")?.GetComponent<MeshRenderer>();

    internal static void UpdateDisplay()
    {
        Display.main.Activate();
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefresh);
        Application.targetFrameRate = Plugin.MaxRefresh;
        Time.fixedDeltaTime = 1f / Plugin.MaxRefresh;
    }

    internal static void RunFixes()
    {
        
        AspectCamera.Instance.width = AspectCamera.Instance.height * Plugin.CurrentAspect;
        
        FixWhiteLines();
        
        UpdateCameraBackgrounds();

        UpdateFades();

        Application.runInBackground = Plugin.RunInBackground.Value;

        UpdateDisplay();

        UpdateLetterbox(!SceneManager.GetActiveScene().name.Contains("stage"));
        
        var mr = MainMeshRendererInstance;
        var camera = MainCameraInstance;

        if (!mr || !camera) return;

        if (camera.targetTexture)
        {
            var targetTexture = camera.targetTexture;
            var descriptor = targetTexture.descriptor;
            var newWidth = descriptor.height * Plugin.CurrentAspect;


            if (!Mathf.Approximately(descriptor.width, newWidth))
            {
                descriptor.width = (int)newWidth;

                var renderTexture = new RenderTexture(descriptor)
                {
                    filterMode = targetTexture.filterMode,
                    name = targetTexture.name
                };

                renderTexture.name = $"Render Texture{descriptor.width}x{descriptor.height}";

                camera.targetTexture = renderTexture;

                if (camera.targetTexture == renderTexture)
                {
                    targetTexture.Release();
                }
            }
        }

        mr.transform.localScale = new Vector3(
            mr.transform.localScale.y * Plugin.CurrentAspect,
            mr.transform.localScale.y,
            mr.transform.localScale.z
        );
        mr.material.mainTexture = camera.targetTexture;

        UpdateAA();
    }

    private static void UpdateFades()
    {
        var commonFades = Resources.FindObjectsOfTypeAll<CommonFade>();
        foreach (var fade in commonFades)
        {
            fade.transform.localScale = new Vector3(Plugin.ScaleFactor, 1f, 1f);
        }
    }

    internal static void UpdateAA()
    {
        var mode = Plugin.AntialiasingMode.Value.ToAntialiasingMode();
        MainCameraInstance.GetUniversalAdditionalCameraData().antialiasing = mode;
    }
}