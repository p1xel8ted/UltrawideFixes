namespace HerosAdventureRoadToPassion;

[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BasePlugin
{

    private static ManualLogSource Logger { get; set; }
    private static Harmony HarmonyInstance { get; } = new(Const.PluginGuid);
    private static float CurrentAspect => (float) Display.displays[DisplayToUse.Value].systemWidth / Display.displays[DisplayToUse.Value].systemHeight;
    internal static float AspectWidthDifference => WidthDifference / 2f;
    internal static float WidthDifference => SelectedWidth - BaseWidth;
    internal static float PositiveScaleFactor => CurrentAspect / Const.BaseAspect;
    private static float BaseWidth => Display.displays[DisplayToUse.Value].systemHeight * Const.BaseAspect;
    internal static float NegativeScaleFactor => 1f / (CurrentAspect / Const.BaseAspect);
    internal static float MiddleOfScreenX => BaseWidth / 2f;
    internal static int SelectedWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int SelectedHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefreshRate => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<bool> DisableTips { get; private set; }
    internal static ConfigEntry<bool> CorrectMenu { get; private set; }

    internal static ConfigEntry<bool> SixteenByNineHud { get; private set; }
    internal static ConfigFile ConfigInstance { get; private set; }
    internal static CanvasScaler RootScaler { get; private set; }

    public override void Load()
    {
        ConfigInstance = Config;
        DisplayToUse = Config.Bind(Const.GeneralCat, "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisableTips = Config.Bind(Const.GeneralCat, "Disable Tips", false, "Disables tips under the Esc menu");
        CorrectMenu = Config.Bind(Const.GeneralCat, "Correct Menu", false, "Corrects the menu to fit the screen");
        SixteenByNineHud = Config.Bind(Const.GeneralCat, "Restrict HUD", false, "Sets the HUD to 16:9");
        PlayerPrefs.SetInt(Const.UnitySelectMonitor, DisplayToUse.Value);
        PlayerPrefs.Save();
        Display.displays[DisplayToUse.Value].Activate();

        Logger = Log;
        Utils.AttachToSceneOnLoaded(OnSceneLoaded);
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        HarmonyInstance.PatchAll();
    }

    internal static void L(string message)
    {
        Logger.LogWarning(message);
    }

    private static void CamFix(Camera cam)
    {
        if (cam.targetTexture == null) return;
        var targetTexture = cam.targetTexture;
        var descriptor = targetTexture.descriptor;
        if (descriptor.width == SelectedWidth) return;
        descriptor.width = SelectedWidth;
        descriptor.height = SelectedHeight;
        var renderTexture = new RenderTexture(descriptor)
        {
            filterMode = targetTexture.filterMode,
            name = targetTexture.name
        };
        cam.targetTexture = renderTexture;
        if (cam.targetTexture == renderTexture)
        {
            targetTexture.Release();
        }
    }

    internal static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Screen.SetResolution(SelectedWidth, SelectedHeight, FullScreenMode.FullScreenWindow, MaxRefreshRate);
        Application.targetFrameRate = MaxRefreshRate;
        Time.fixedDeltaTime = 1f / MaxRefreshRate;

        var cameras = Utils.FindIl2CppType<Camera>();
        foreach (var camera in cameras)
        {
            CamFix(camera);
        }

        var canvasScalers = Utils.FindIl2CppType<CanvasScaler>();
        foreach (var canvasScaler in canvasScalers.Where(canvasScaler => !canvasScaler.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)))
        {
            if (canvasScaler.name.Equals(Const.WulinUiRootClone))
            {
                RootScaler = canvasScaler;
            }

            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            canvasScaler.referenceResolution = new Vector2(Mathf.RoundToInt(canvasScaler.referenceResolution.y * Const.BaseAspect), canvasScaler.referenceResolution.y);
            canvasScaler.scaleFactor = PositiveScaleFactor;
        }

        var pixelPerfects = Utils.FindIl2CppType<PixelPerfectCamera>();
        foreach (var p in pixelPerfects)
        {
            p.cropFrame = PixelPerfectCamera.CropFrame.None;
            p.cropFrameX = false;
            p.cropFrameY = false;
            p.refResolutionX = Mathf.RoundToInt(p.refResolutionY * Const.BaseAspect);
        }

        var targetFramerate = Utils.FindIl2CppType<TargetFrameRate>();
        foreach (var tf in targetFramerate)
        {
            tf.targetFrameRate = MaxRefreshRate;
        }

        
        SetSafeArea(!SixteenByNineHud.Value);
    }


    internal static void SetSafeArea(bool expand)
    {
        var safeAreaHelpers = Utils.FindIl2CppType<SafeAreaHelper>();
        foreach (var sah in safeAreaHelpers)
        {
            sah.Start();
            sah.canvasSize = new Vector2(SelectedWidth, SelectedHeight);
            if (expand)
            {
                sah.wideScreen = 0;
            }
            else
            {
                sah.wideScreen = AspectWidthDifference;
            }

            sah.SetupArea();
        }
    }
}