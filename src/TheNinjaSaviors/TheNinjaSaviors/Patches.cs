using ShadowOfTheNinjaReborn;

namespace TheNinjaSaviors;

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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MakerLogo), nameof(MakerLogo.Start))]
    public static void MakerLogo_Start()
    {
        SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
        SplashScreen.CancelSplashScreen();
        SceneManager.LoadScene(TitleScene, LoadSceneMode.Single);

        UpdateLetterbox(true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OpDemoRoot), nameof(OpDemoRoot.Start))]
    [HarmonyPatch(typeof(TitleMenu), nameof(TitleMenu.Start))]
    public static void TitleMenu_Start()
    {
        UpdateLetterbox(true);
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
        var commonFades = Resources.FindObjectsOfTypeAll<CommonFade>();
        foreach (var fade in commonFades)
        {
            fade.transform.localScale = new Vector3(Plugin.ScaleFactor, 1f, 1f);
        }

        Application.runInBackground = Plugin.RunInBackground.Value;

        UpdateDisplay();

        UpdateLetterbox(false);

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

    internal static void UpdateAA()
    {
        var mode = Plugin.AntialiasingMode.Value.ToAntialiasingMode();
        MainCameraInstance.GetUniversalAdditionalCameraData().antialiasing = mode;
    }
}