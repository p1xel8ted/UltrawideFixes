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
    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    private const float BaseAspectRatio = 16f / 9f;
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }

    private const float SuperWideAspectRatio = 32f / 9f;
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Log { get; set; }

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

        // FieldOfView = Config.Bind("02. Camera", "Field of View", 50, new ConfigDescription("Increase or decrease the field of view of the camera. Default is 50% increases", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 100}));

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();

        var rectTransforms = Resources.FindObjectsOfTypeAll<RectTransform>();
        foreach (var rect in rectTransforms)
        {
            if (rect.sizeDelta is {x: >= 1600, y: >= 1200} || rect.name.Equals("BlackScreen", StringComparison.OrdinalIgnoreCase))
            {
                rect.sizeDelta = new Vector2(MainWidth, MainHeight);
            }
        }


        UpdateMenuBackground();
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