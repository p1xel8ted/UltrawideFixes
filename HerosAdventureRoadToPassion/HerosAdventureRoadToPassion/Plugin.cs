using TMPro;

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
    internal static int SelectedWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int SelectedHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefreshRate => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<bool> DisableTips { get; private set; }
    internal static ConfigEntry<bool> CorrectMenu { get; private set; }

    internal static ConfigEntry<bool> ExpandUI { get; private set; }
    internal static ConfigFile ConfigInstance { get; private set; }
    internal static CanvasScaler RootScaler { get; private set; }

    public override void Load()
    {
        ConfigInstance = Config;
        DisplayToUse = Config.Bind(Const.GeneralCat, "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisableTips = Config.Bind(Const.GeneralCat, "Disable Tips", false, "Disables tips under the Esc menu");
        CorrectMenu = Config.Bind(Const.GeneralCat, "Correct Menu", false, "Corrects the menu to fit the screen");
        ExpandUI = Config.Bind(Const.GeneralCat, "Expand UI", true, "Expands the UI to fit the screen");
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


        var safeAreaHelpers = Utils.FindIl2CppType<SafeAreaHelper>();
        foreach (var sah in safeAreaHelpers)
        {
            sah.Start();
            sah.canvasSize = new Vector2(SelectedWidth, SelectedHeight);
            if (!ExpandUI.Value)
            {
                sah.wideScreen = AspectWidthDifference;
            }
            else
            {
                sah.wideScreen = 0;
            }
            sah.SetupArea();
        }

        UpdateScales();
    }

    private static void UpdateControllerIcons()
    {
        var controllerTips = Utils.FindIl2CppType<ControllerIconTipsGroup>();
        var shouldExpand = ExpandUI.Value;
        var scaleFactor = shouldExpand ? 1 : PositiveScaleFactor;

        foreach (var controllerTip in controllerTips)
        {
            var bottom = controllerTip.transform.FindChild(Const.BottomPath);
            if (bottom == null) continue;
            var localScale = bottom.localScale;
            localScale = new Vector3(scaleFactor, localScale.y, localScale.z);
            bottom.localScale = localScale;
            foreach (var o in bottom)
            {
                var child = o.TryCast<Transform>();
                if (child == null) continue;
                var scale = child.localScale;
                scale = new Vector3(scaleFactor, scale.y, scale.z);
                child.localScale = scale;
            }
        }
    }

    private static void UpdateBlurBackgrounds()
    {
        var blurs = Utils.FindIl2CppType<BlurBg>();
        foreach (var transform in blurs.Select(blur => blur.transform))
        {
            transform.localScale = transform.localScale with {x = PositiveScaleFactor};
        }
    }

    private static Dictionary<int, float> FontSizeDictionary { get; } = new();

    private static IEnumerable<string> TextToSkip { get; } = ["NpcBigTalk", "NpcSmallTalk", "headchat", "StoryLog"];

    internal static void UpdateTextMesh()
    {
        var textMeshProUGUIs = Utils.FindIl2CppType<TextMeshProUGUI>();
        foreach (var text in textMeshProUGUIs)
        {
            var path = text.transform.GetAbsolutePathInHierarchy();

            if (TextToSkip.Any(path.Contains))
            {
                if (path.Contains("StoryLog"))
                {
                    //expand the width of the textbox
                    text.rectTransform.sizeDelta = text.rectTransform.sizeDelta with {x = 500};
                }
                continue;
            }

            text.enableWordWrapping = true;
            FontSizeDictionary.TryAdd(text.GetInstanceID(), text.fontSize);

            if (FontSizeDictionary.TryGetValue(text.GetInstanceID(), out var fontSize))
            {
                text.fontSize = fontSize - 4;
            }
        }
    }

    internal static void UpdateScales()
    {
        UpdateBlurBackgrounds();
        UpdateControllerIcons();
        // UpdateTextMesh();
    }
}