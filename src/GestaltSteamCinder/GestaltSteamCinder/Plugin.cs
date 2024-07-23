namespace GestaltSteamCinder;

[HarmonyPatch]
[HarmonyWrapSafe]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.gestaltsteamcinder.ultrawide";
    private const string PluginName = "Gestalt: Steam & Cinder Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private const string LogosAndControllerWarningScene = "Logos and controller warning scene";
    private const string StartingScene = "starting_scene";
    private const string LeftPillarBox = "PillarBoxMask/RootPanel/Left";
    private const string RightPillarBox = "PillarBoxMask/RootPanel/Right";

    private readonly static int MainWidth = Display.main.systemWidth;
    private readonly static int MainHeight = Display.main.systemHeight;
    private readonly static float AspectRatio = MainWidth / (float) MainHeight;
    private readonly static int MaxRefreshRate = Screen.resolutions.Max(res => res.refreshRate);

    private static float x;
    private static float y;

    public override void Load()
    {
        Log.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }


    [HarmonyPostfix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.Internal_SceneLoaded))]
    public static void SceneManager_Internal_SceneLoaded(Scene scene)
    {
        if (scene.name.Equals(LogosAndControllerWarningScene))
        {
            SceneManager.LoadScene(StartingScene);
        }

        var left = GameObject.Find(LeftPillarBox);
        if (left)
        {
            left.gameObject.SetActive(false);
        }

        var right = GameObject.Find(RightPillarBox);
        if (right)
        {
            right.gameObject.SetActive(false);
        }

        Time.fixedDeltaTime = 1f / MaxRefreshRate;

        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefreshRate);

        Application.runInBackground = true;
        Application.targetFrameRate = MaxRefreshRate;
    }

    [HarmonyPostfix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.LateUpdate))]
    public static void ProCamera2D_FixedUpdate(ProCamera2D __instance)
    {
        __instance.Rect = new Rect(0, 0, MainWidth, MainHeight);

        if (x <= 0)
        {
            x = __instance.ScreenSizeInWorldCoordinates.x;
        }

        if (y <= 0)
        {
            y = __instance.ScreenSizeInWorldCoordinates.y;
        }

        __instance.ScreenSizeInWorldCoordinates = new Vector2(y * AspectRatio, y);
    }


    [HarmonyPostfix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreen = true;
        preferredRefreshRate = MaxRefreshRate;
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreen = true;
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
        preferredRefreshRate = MaxRefreshRate;
    }
}