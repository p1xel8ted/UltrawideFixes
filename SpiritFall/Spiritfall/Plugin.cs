using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Spiritfall;

/// <summary>
/// A BepInEx plugin that provides a set of ultra-wide fixes and tweaks for the game Spiritfall.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public partial class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.spiritfall.ultrawide";
    private const string PluginName = "Spiritfall Ultra-Wide Fixes & Tweaks";
    private const string PluginVersion = "0.0.2";

    /// <summary>
    /// The logging source for this plugin.
    /// </summary>
    internal static ManualLogSource Log { get; private set; }

    private static Harmony Harmony { get; set; }

    private static ConfigEntry<bool> ModEnabled { get; set; }
    private static Dictionary<string, ConfigEntry<bool>> UIElements { get; set; } = new();
    private static ConfigEntry<bool> QuitToDesktop { get; set; }

    /// <summary>
    /// Invoked when the <see cref="Plugin"/> is loaded. It initializes the log, harmony patches and the configuration.
    /// </summary>
    private void Awake()
    {
        Log = Logger;
        Harmony = new Harmony(PluginGuid);
        InitConfiguration();
        ApplyPatches(this, null);
    }

    /// <summary>
    /// Initializes configuration entries and binds scene event handlers.
    /// </summary>
    private void InitConfiguration()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.activeSceneChanged += OnActiveSceneChanged;

        ModEnabled = Config.Bind("1. General", "Enabled", true, $"Toggle {PluginName}");
        ModEnabled.SettingChanged += ApplyPatches;
        UIElements = new Dictionary<string, ConfigEntry<bool>>
        {
            {"WelcomePopup", Config.Bind("2. Main Menu Tweaks", "WelcomePopup", false, "Toggle Welcome Popup")},
            {
                "EarlyAccessBanner",
                Config.Bind("2. Main Menu Tweaks", "EarlyAccessBanner", true, "Toggle Early Access Banner")
            },
            {"DiscordButton", Config.Bind("2. Main Menu Tweaks", "DiscordButton", true, "Toggle Discord Button")},
            {"TwitterButton", Config.Bind("2. Main Menu Tweaks", "TwitterButton", false, "Toggle Twitter Button")},
            {"FeedbackButton", Config.Bind("2. Main Menu Tweaks", "FeedbackButton", false, "Toggle Feedback Button")},
            {"RoadmapButton", Config.Bind("2. Main Menu Tweaks", "RoadmapButton", true, "Toggle Roadmap Button")},
            {"CreditsButton", Config.Bind("2. Main Menu Tweaks", "CreditsButton", true, "Toggle Credits Button")}
        };


        QuitToDesktop = Config.Bind("3. In Game Tweaks", "QuitToDesktop", true,
            "Re-enables the Quit to Desktop button in the pause menu. (It's hidden by default)");

        foreach (var uiElement in UIElements.Values)
        {
            uiElement.SettingChanged += ToggleAll;
        }
    }

    /// <summary>
    /// Handler for the scene change event. Invokes UI element toggling.
    /// </summary>
    private void OnActiveSceneChanged(Scene arg0, Scene arg1)
    {
        ToggleAll(this, null);
    }

    /// <summary>
    /// Handler for the scene loaded event. Invokes UI element toggling.
    /// </summary>
    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        ToggleAll(this, null);
    }

    /// <summary>
    /// Fetches a <see cref="GameObject"/> from the current scene based on its name.
    /// </summary>
    private static GameObject GetGameObject(string name)
    {
        return GameObject.Find(name);
    }

    /// <summary>
    /// Toggles visibility of all UI elements according to their configuration entries.
    /// </summary>
    private static void ToggleAll(object sender, EventArgs eventArgs)
    {
        if (UIElements.Values.Any(a => a.Value))
        {
            var uiElementPaths = new Dictionary<string, string>
            {
                {"WelcomePopup", "CanvasMainMenu/WelcomePopup"},
                {"EarlyAccessBanner", "CanvasMainMenu/MenuPanel/EarlyAccessBanner"},
                {"DiscordButton", "CanvasMainMenu/MenuPanel/DiscordButton"},
                {"TwitterButton", "CanvasMainMenu/MenuPanel/TwitterButton"},
                {"FeedbackButton", "CanvasMainMenu/MenuPanel/FeedbackButton"},
                {"RoadmapButton", "CanvasMainMenu/MenuPanel/Content/Roadmap"},
                {"CreditsButton", "CanvasMainMenu/MenuPanel/Content/Credits"}
            };
            foreach (var uiElement in UIElements)
            {
                var gameObject = GetGameObject(uiElementPaths[uiElement.Key]);
                if (gameObject != null)
                {
                    gameObject.SetActive(uiElement.Value.Value);
                }
            }

            var pauseMenuTwitterButton =
                GetGameObject("CanvasPauseMenu/PauseMenu/Content/MarketingButtons/TwitterButton");
            if (pauseMenuTwitterButton != null)
            {
                pauseMenuTwitterButton.SetActive(UIElements["TwitterButton"].Value);
            }

            if (!UIElements["FeedbackButton"].Value)
            {
                RemoveFeedbackButtonInPauseMenu();
            }
        }

        if (QuitToDesktop.Value)
        {
            var pauseMenuQuitButton = GetGameObject("CanvasPauseMenu/PauseMenu/Content/Quit");
            if (pauseMenuQuitButton != null)
            {
                pauseMenuQuitButton.SetActive(true);
            }

            RemoveFeedbackButtonInPauseMenu();
        }

        void RemoveFeedbackButtonInPauseMenu()
        {
            var pauseMenuFeedBack = GetGameObject("CanvasPauseMenu/PauseMenu/Content/Feedback");
            if (pauseMenuFeedBack != null)
            {
                var spaceOne = GetGameObject("CanvasPauseMenu/PauseMenu/Content/_Space");
                if (spaceOne != null)
                {
                    spaceOne.SetActive(false);
                }

                var spaceTwo = GetGameObject("CanvasPauseMenu/PauseMenu/Content/_Space_01");
                if (spaceTwo != null)
                {
                    spaceTwo.SetActive(false);
                }

                pauseMenuFeedBack.SetActive(false);
            }
        }
    }

    /// <summary>
    /// Apply or remove harmony patches based on the _modEnabled configuration entry.
    /// </summary>
    private static void ApplyPatches(object sender, EventArgs e)
    {
        if (ModEnabled.Value)
        {
            Log.LogInfo($"Applying patches for {PluginName}");
            Harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
        else
        {
            Log.LogInfo($"Removing patches for {PluginName}");
            Harmony.UnpatchSelf();
        }
    }
}