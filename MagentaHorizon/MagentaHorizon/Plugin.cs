using System;

namespace MagentaHorizon;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.magentahorizon.ultrawide";
    private const string PluginName = "Magenta Horizon Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    private static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;
    private static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    private const float BaseAspectRatio = 16f / 9f;

    internal static float WidthDifference => MainWidth - NormalWidth; //3440 - 2560 = 880
    internal static float BlackBarSize => WidthDifference / 2f; //880 / 2 = 440
    private static float NormalWidth => MainHeight * BaseAspectRatio; //1440 * 16/9 = 2560
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    private const float SuperWideAspectRatio = 32f / 9f;
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Log { get; private set; }

    internal static ConfigEntry<bool> KeepUICentered { get; private set; }

    private void Awake()
    {
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        KeepUICentered = Config.Bind("02. UI", "Keep UI Centered", true, "Keeps the UI (and other screens) at the original 16:9 ratio.");

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();

        UpdateOpaqueBackgrounds();

        UpdateMenuBackground();
    }

    private static void UpdateOpaqueBackgrounds()
    {
        var rectTransforms = Resources.FindObjectsOfTypeAll<RectTransform>();
        foreach (var rect in rectTransforms)
        {
            if (rect.sizeDelta is {x: >= 1600, y: >= 1200} || rect.name.Equals("BlackScreen", StringComparison.OrdinalIgnoreCase) || rect.name.Equals("GameObject_1", StringComparison.OrdinalIgnoreCase))
            {
                rect.sizeDelta = new Vector2(MainWidth, MainHeight);
            }
        }
    }

    private static void UpdateMenuBackground()
    {
        var menuBackground = GameObject.Find("Canvas/MainMenu");
        if (!menuBackground) return;

        var image = menuBackground.GetComponent<Image>();
        if (!image) return;

        var texture = new Texture2D(1, 1);

        var path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        var file = MainAspectRatio switch
        {
            >= SuperWideAspectRatio => "assets/32-9.jpg",
            > BaseAspectRatio => "assets/21-9.jpg",
            _ => string.Empty
        };

        if (string.IsNullOrEmpty(file)) return;
        var imagePath = System.IO.Path.Combine(path!, file);
        texture.LoadImage(System.IO.File.ReadAllBytes(imagePath));
        image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        var rectTransform = image.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(texture.width, texture.height);
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        // Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Time.fixedDeltaTime = 1f / MaxRefresh;
        Application.targetFrameRate = MaxRefresh;
    }
}