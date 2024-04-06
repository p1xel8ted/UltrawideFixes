using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Elderland;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.elderland.ultrawide";
    private const string PluginName = "Elderland Ultra-Wide!";
    private const string PluginVersion = "0.1.0";

    private static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    private static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;
    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    internal static float PositiveScaleFactor => MainWidth / NormalWidth;
    private static float BaseAspect => 16f / 9f;
    private static float NormalWidth => MainHeight * BaseAspect;
    internal static ConfigEntry<bool> KeepUICentered { get; private set; }
    internal static float BlackBarSize => (MainWidth - NormalWidth) / 2f;
    private static ConfigEntry<int> DisplayToUse { get; set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    internal static ManualLogSource Log { get; private set; }

    private void Awake()
    {
        Log = Logger;
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        
        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 101}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        FieldOfView = Config.Bind("02. Camera", "Field of View", 50, new ConfigDescription("Increase or decrease the field of view of the camera. Default is 50% increases", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 100}));
        KeepUICentered = Config.Bind("03. UI", "Keep UI Centered", true, "Keeps the UI (and other screens) at the original 16:9 ratio.");

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
    }

    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals("MainMenu"))
        {
            var parent = GameObject.Find("Canvas/AspectRatio/TitleScreen");
            
            // Create a static black image and set it as the first sibling, covering the entire screen
            var blackImage = new GameObject("BlackImage", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));

            // Cache the RectTransform and set it up
            var rectTransform = blackImage.GetComponent<RectTransform>();
            rectTransform.SetParent(parent.transform, false);
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.sizeDelta = Vector2.zero;

            // Set the image color to black
            blackImage.GetComponent<Image>().color = new Color(2f / 255f, 2f / 255f, 2f / 255f);

            // Place it as the first sibling
            rectTransform.SetAsFirstSibling();
        }
    }
}