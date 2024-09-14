using ShadowOfTheNinjaReborn;

namespace TheNinjaSaviors;

[Harmony]
public static class Patches
{
    // private const string TitleScene = "TitleMenu";
    // private const string FadeCanvas = "FadeCanvas";
    // private const string MainCamera = "Main Camera";
    //
    //
    private static void UpdateLetterbox(bool enabled)
    {
        var lbc = GameObject.Find("Common/Canvas/LetterBox");
        if (lbc)
        {
            lbc.SetActive(enabled);
        }
    }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(MakerLogo), nameof(MakerLogo.Start))]
    // public static void MakerLogo_Start()
    // {
    //     SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
    //     SplashScreen.CancelSplashScreen();
    //     SceneManager.LoadScene(TitleScene, LoadSceneMode.Single);
    //
    //     UpdateLetterbox(true);
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleMenu), nameof(TitleMenu.Start))]
    public static void TitleMenu_Start()
    {
        UpdateLetterbox(false);
       Plugin.Logger.LogWarning("TitleMenu Start");
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(GameMain), nameof(GameMain.GameFadeIn))]
    // public static void GameMain_FadeStart(GameMain __instance)
    // {
    //
    // }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;
        Plugin.Logger.LogWarning($"CanvasScaler OnEnable: {__instance.name} - {__instance.transform.GetFullPath()}");
        // var fadeCanvas = __instance.transform.Find(FadeCanvas);
        // if (fadeCanvas)
        // {
        //     fadeCanvas.localScale = new Vector3(Plugin.ScaleFactor, 1f, 1f);
        // }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.InitGame))]
    internal static void GameMain_InitGame()
    {
        Plugin.Logger.LogWarning("GameMain InitGame");
        RunFixes();
    }
    
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(GameMain), nameof(GameMain.InitScene))]
    // internal static void GameMain_InitScene()
    // {
    //     Plugin.Logger.LogWarning("GameMain InitScene");
    //     RunFixes();
    // }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Common), nameof(Common.SetHeght))]
    internal static void Common_SetHeght(ref int val)
    {
        Plugin.Logger.LogWarning($"Common_SetHeght: {val}");
        val = Plugin.MainHeight;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Common), nameof(Common.SetWitdth))]
    internal static void Common_SetWitdth(ref int val)
    {
        Plugin.Logger.LogWarning($"Common_SetWitdth: {val}");
        val = Plugin.MainWidth;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.InitStage))]
    internal static void GameMain_InitStage()
    {
        Plugin.Logger.LogWarning("GameMain InitStage");
        RunFixes();
    }

    private static Camera MainCameraInstance => Utils.FindIl2CppType<Camera>().FirstOrDefault(a=>a.name == "GameCamera");
    private static MeshRenderer MainMeshRendererInstance => Utils.FindIl2CppType<MeshRenderer>().FirstOrDefault(a=>a.name == "RenderTexture426x720Quad");

    internal static void UpdateDisplay()
    {
        Display.main.Activate();
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefresh);
        Application.targetFrameRate = Plugin.MaxRefresh;
        Time.fixedDeltaTime = 1f / Plugin.MaxRefresh;
    }

    internal static void RunFixes()
    {
        // var commonFades = Resources.FindObjectsOfTypeAll<CommonFade>();
        // foreach (var fade in commonFades)
        // {
        //     fade.transform.localScale = new Vector3(Plugin.ScaleFactor, 1f, 1f);
        // }
    
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
        Plugin.Logger.LogWarning($"MainMeshRendererInstance: {mr.name} - {mr.transform.GetFullPath()}");
        mr.material.mainTexture = camera.targetTexture;
        
        
    }
    //
    // internal static void UpdateAA()
    // {
    //     var mode = Plugin.AntialiasingMode.Value.ToAntialiasingMode();
    //     MainCameraInstance.GetUniversalAdditionalCameraData().antialiasing = mode;
    // }
}