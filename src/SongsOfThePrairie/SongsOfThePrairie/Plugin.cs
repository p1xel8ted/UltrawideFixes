namespace SongsOfThePrairie;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.songsoftheprairie.ultrawide";
    private const string PluginName = "Songs of the Prairie Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    // private const float NativeAspect = 16f / 9f;
    
    private readonly static int MainWidth = Display.main.systemWidth;
    private readonly static int MainHeight = Display.main.systemHeight;
    
    // private readonly static float AspectRatio = MainWidth / (float) MainHeight;
    // private readonly static float ScaleFactor = AspectRatio / NativeAspect;
    private readonly static int MaxRefreshRate = Screen.resolutions.Max(res => res.refreshRate);
    //
    // private static float x;
    // private static float y;

    public override void Load()
    {
        Log.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.Internal_SceneLoaded))]
    public static void SceneManager_Internal_SceneLoaded(Scene scene)
    {
        // SkipControllerMessage(scene);
        //
        // DisablePillarbox();

        DisplayStuff();
        //
        // FixVignette();
        //
        // FixHeatShimmer();
    }
    

    // private static void SkipControllerMessage(Scene scene)
    // {
    //     if (scene.name.Equals(LogosAndControllerWarningScene))
    //     {
    //         SceneManager.LoadScene(StartingScene);
    //     }
    // }

    private static void DisplayStuff()
    {
        Time.fixedDeltaTime = 1f / MaxRefreshRate;

        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefreshRate);

        Application.runInBackground = true;
        Application.targetFrameRate = MaxRefreshRate;
    }

    // private static void DisablePillarbox()
    // {
    //     var left = GameObject.Find(LeftPillarBox);
    //     if (left)
    //     {
    //         left.gameObject.SetActive(false);
    //     }
    //
    //     var right = GameObject.Find(RightPillarBox);
    //     if (right)
    //     {
    //         right.gameObject.SetActive(false);
    //     }
    // }
    //
    // private static void FixVignette()
    // {
    //     var vignette = GameObject.Find(Vignette);
    //     if (vignette)
    //     {
    //         vignette.transform.localScale = new Vector3(ScaleFactor, 1, 1);
    //     }
    // }
    //
    // private static void FixHeatShimmer()
    // {
    //     var heatShimmer = GameObject.Find(HeatShimmer);
    //     if (heatShimmer)
    //     {
    //         var y1 = heatShimmer.transform.localScale.y;
    //         var x1 = y * AspectRatio;
    //         heatShimmer.transform.localScale = new Vector3(x1, y1, 1);
    //     }
    // }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.LateUpdate))]
    // public static void ProCamera2D_FixedUpdate(ProCamera2D __instance)
    // {
    //     __instance.Rect = new Rect(0, 0, MainWidth, MainHeight);
    //
    //     if (x <= 0)
    //     {
    //         x = __instance.ScreenSizeInWorldCoordinates.x;
    //     }
    //
    //     if (y <= 0)
    //     {
    //         y = __instance.ScreenSizeInWorldCoordinates.y;
    //     }
    //
    //     __instance.ScreenSizeInWorldCoordinates = new Vector2(y * AspectRatio, y);
    // }


    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    // public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    // {
    //     __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    //     __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    // }
   
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreen = true;
        preferredRefreshRate = MaxRefreshRate;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreen = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
        preferredRefreshRate = MaxRefreshRate;
    }
}