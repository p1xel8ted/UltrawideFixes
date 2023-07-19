using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using AssetsLib;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using InControl;
using TrackIt.Patches;
using UnityEngine;

namespace TrackIt;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency("Aidanamite.AssetsLib")]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.moonlighter.trackit";
    private const string PluginName = "TrackIt!";
    private const string PluginVersion = "0.1.1";

    internal static Texture2D RedQuestIcon { get; private set; }
    internal static Sprite RedQuestIconSprite { get; private set; }
    internal static Texture2D BlueQuestIcon { get; private set; }
    internal static Sprite BlueQuestIconSprite { get; private set; }
    internal static Texture2D MagentaQuestIcon { get; private set; }
    internal static Sprite MagentaQuestIconSprite { get; private set; }
    internal static Texture2D OrangeQuestIcon { get; private set; }
    internal static Sprite OrangeQuestIconSprite { get; private set; }
    internal static Texture2D WhiteQuestIcon { get; private set; }
    internal static Sprite WhiteQuestIconSprite { get; private set; }
    internal static Texture2D WishIcon { get; private set; }
    internal static Sprite WishIconSprite { get; private set; }


    public enum QuestIconColor
    {
        Red,
        Blue,
        Magenta,
        Orange,
        White
    }

    public static QuestIconColor ChosenQuestIconColor
    {
        get
        {
            var position = QuestIconColorConfig.Value;
            var positionEnum = (QuestIconColor) Enum.Parse(typeof(QuestIconColor), position);
            return positionEnum;
        }
    }

    public const string QuestIcon = "QuestIcon";
    

    internal static string WishIconSpriteString { get; private set; }

    internal new static ManualLogSource Logger { get; private set; }

    private static ConfigEntry<string> QuestIconPositionConfig { get; set; }
    private static ConfigEntry<string> QuestIconColorConfig { get; set; }

    internal static ConfigEntry<bool> ColouriseQuestTracker { get; private set; }

    internal static ConfigEntry<Color> QuestTrackerHeaderColour { get; private set; }
    internal static ConfigEntry<Color> QuestTrackerCompletedColour { get; private set; }
    internal static ConfigEntry<Color> QuestTrackerFailedColour { get; private set; }
    internal static ConfigEntry<Color> QuestTrackerHalfwayColour { get; private set; }
    internal static ConfigEntry<bool> AnimateQuestImages { get; private set; }
    private static ConfigEntry<KeyboardShortcut> QuestTrackerToggleKeybind { get; set; }
    internal static ConfigEntry<string> CustomFont { get; private set; }
    internal static ConfigEntry<bool> UseGameFont { get; private set; }
    internal static ConfigEntry<int> FontSize { get; private set; }
    internal static ConfigEntry<int> QuestLineGap { get; private set; }
    internal static ConfigEntry<int> MaxQuestCount { get; private set; }
    internal static ConfigEntry<int> DaysToComplete { get; private set; }
    private static ConfigEntry<int> TrackerUpdatePeriod { get; set; }
    internal static ConfigEntry<bool> ShowQuestTargetImages { get; private set; }
    private static Color Complete { get; } = new(0f / 255f, 255f / 255f, 0f / 255f, 0.75f);
    private static Color Progress { get; } = new(255f / 255f, 165f / 255f, 0f / 255f, 0.75f);
    private static Color Failed { get; } = new(255f / 255f, 0f / 255f, 0f / 255f, 0.75f);
    public static Color Grey { get; } = new(1, 1, 1, 0.75f);
    private static Color Header { get; } = new(0f, 0.8f, 0.6f, 1);

    private void Awake()
    {

        Logger = base.Logger;
        
        // 1. Keybind Options
        
        QuestTrackerToggleKeybind = Config.Bind("1. Keybinds", "Quest Tracker Toggle Keybind", new KeyboardShortcut(KeyCode.Q),
             new ConfigDescription("Select the keybind to toggle the visibility of the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 49}));

        // 2. Visual Customization
        QuestIconColorConfig = Config.Bind("2. Visual Customization", "Quest Icon Color", QuestIconColor.Red.ToString(),
            new ConfigDescription("Choose the color of the Quest icon appearing on item drops.", new AcceptableValueList<string>(Enum.GetNames(typeof(QuestIconColor))), new ConfigurationManagerAttributes {Order = 48}));
        QuestIconColorConfig.SettingChanged += (_, _) => { Helpers.UpdateQuestIcons(); };

        // 3. Color Preferences
        ColouriseQuestTracker = Config.Bind("3. Color Preferences", "Colorize Quest Tracker", true,
            new ConfigDescription("Enable color-coding of Quest Tracker based on quest progress.", null, new ConfigurationManagerAttributes {Order = 47}));
        ColouriseQuestTracker.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        QuestTrackerHeaderColour = Config.Bind("3. Color Preferences", "Quest Tracker Header Color", Header,
            new ConfigDescription("Choose the color for the header in the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 46}));
        QuestTrackerHeaderColour.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        QuestTrackerCompletedColour = Config.Bind("3. Color Preferences", "Completed Quest Color", Complete,
            new ConfigDescription("Select the color for completed quests in the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 45}));
        QuestTrackerCompletedColour.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        QuestTrackerFailedColour = Config.Bind("3. Color Preferences", "Failed Quest Color", Failed,
            new ConfigDescription("Select the color for failed quests in the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 44}));
        QuestTrackerFailedColour.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        QuestTrackerHalfwayColour = Config.Bind("3. Color Preferences", "Halfway Completed Quest Color", Progress,
            new ConfigDescription("Select the color for quests that are halfway completed in the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 43}));
        QuestTrackerHalfwayColour.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        // 4. Quest Tracker Configuration
        MaxQuestCount = Config.Bind("4. Quest Configuration", "Maximum Active Quests", 3,
            new ConfigDescription("Set the maximum number of active quests allowed.", new AcceptableValueRange<int>(1, 10), new ConfigurationManagerAttributes {Order = 42}));
        MaxQuestCount.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        DaysToComplete = Config.Bind("4. Quest Configuration", "Quest Completion Time", 3,
            new ConfigDescription("Set the number of days to complete a quest.", new AcceptableValueRange<int>(1, 10), new ConfigurationManagerAttributes {Order = 41}));

        FontSize = Config.Bind("5. Quest Tracker Font", "Quest Tracker Font Size", 14,
            new ConfigDescription("Define the font size for the Quest Tracker.", new AcceptableValueRange<int>(1, 20), new ConfigurationManagerAttributes {Order = 40}));
        FontSize.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        UseGameFont = Config.Bind("5. Quest Tracker Font", "Use Game Font", true,
            new ConfigDescription("Use the game's default font for the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 39}));
        UseGameFont.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        CustomFont = Config.Bind("5. Quest Tracker Font", "Custom Font", "Rockwell",
            new ConfigDescription("Choose a custom font for the Quest Tracker.", new AcceptableValueList<string>(Font.GetOSInstalledFontNames()), new ConfigurationManagerAttributes {HideDefaultButton = true, Order = 38}));
        CustomFont.SettingChanged += (_, _) =>
        {
            if (!UseGameFont.Value)
            {
                QuestTrackerNeedsUpdating = true;
            }
        };

        Config.Bind("5. Quest Tracker Font", "Custom Font Buttons", "Rockwell",
            new ConfigDescription("Select a custom font for the buttons in the Quest Tracker.", null, new ConfigurationManagerAttributes {HideSettingName = true, HideDefaultButton = true, CustomDrawer = CustomDrawer, Order = 37}));

        QuestLineGap = Config.Bind("6. Miscellaneous", "Quest Line Gap", -15,
            new ConfigDescription("Set the space between quest lines in the Quest Tracker.", new AcceptableValueRange<int>(-20, -5), new ConfigurationManagerAttributes {Order = 36}));
        QuestLineGap.SettingChanged += (_, _) => { QuestTrackerNeedsUpdating = true; };

        ShowQuestTargetImages = Config.Bind("6. Miscellaneous", "Show Quest Target Images", true,
            new ConfigDescription("Enable or disable images of the quest targets in the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 35}));
        ShowQuestTargetImages.SettingChanged += (_, _) => { QuestTracker.UpdateQuestTargetImageVisibility(); };

        AnimateQuestImages = Config.Bind("6. Miscellaneous", "Animate Quest Images", false,
            new ConfigDescription("Choose whether to animate the quest target images in the Quest Tracker.", null, new ConfigurationManagerAttributes {Order = 34}));
        AnimateQuestImages.SettingChanged += (_, _) => { QuestTracker.UpdateImageAnimations(); };

        TrackerUpdatePeriod = Config.Bind("6. Miscellaneous", "Quest Tracker Refresh Rate", 3,
            new ConfigDescription("Set how often the Quest Tracker should update in seconds. Lower values update more frequently, but may affect performance.", new AcceptableValueRange<int>(1, 10), new ConfigurationManagerAttributes {Order = 33}));


        //Red
        RedQuestIcon = AssetsLibTools.LoadImage("QuestIcon_Red.png", 8, 8);
        RedQuestIconSprite = RedQuestIcon.CreateSprite();
        AssetsLibTools.RegisterAsset(nameof(RedQuestIcon), RedQuestIconSprite);

        //Blue
        BlueQuestIcon = AssetsLibTools.LoadImage("QuestIcon_Blue.png", 8, 8);
        BlueQuestIconSprite = BlueQuestIcon.CreateSprite();
        AssetsLibTools.RegisterAsset(nameof(BlueQuestIcon), BlueQuestIconSprite);

        //Magenta
        MagentaQuestIcon = AssetsLibTools.LoadImage("QuestIcon_Magenta.png", 8, 8);
        MagentaQuestIconSprite = MagentaQuestIcon.CreateSprite();
        AssetsLibTools.RegisterAsset(nameof(MagentaQuestIcon), MagentaQuestIconSprite);

        //Orange
        OrangeQuestIcon = AssetsLibTools.LoadImage("QuestIcon_Orange.png", 8, 8);
        OrangeQuestIconSprite = OrangeQuestIcon.CreateSprite();
        AssetsLibTools.RegisterAsset(nameof(OrangeQuestIcon), OrangeQuestIconSprite);

        //White
        WhiteQuestIcon = AssetsLibTools.LoadImage("QuestIcon_White.png", 8, 8);
        WhiteQuestIconSprite = WhiteQuestIcon.CreateSprite();
        AssetsLibTools.RegisterAsset(nameof(WhiteQuestIcon), WhiteQuestIconSprite);


        WishIcon = AssetsLibTools.LoadImage("WishIcon.png", 8, 8);
        WishIconSprite = WishIcon.CreateSprite();
        WishIconSpriteString = AssetsLibTools.RegisterAsset(nameof(WishIcon), WishIconSprite);

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogWarning($"Plugin {PluginName} is loaded!");
    }

    private static void CustomDrawer(ConfigEntryBase obj)
    {
        var values = Font.GetOSInstalledFontNames().ToList();
        var index = values.IndexOf(CustomFont.Value);

        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("<", GUILayout.ExpandWidth(true)))
        {
            index = (index - 1 + values.Count) % values.Count;
        }

        if (GUILayout.Button(">", GUILayout.ExpandWidth(true)))
        {
            index = (index + 1) % values.Count;
        }

        GUILayout.EndHorizontal();

        CustomFont.Value = values[index];
    }

    private void Start()
    {
        StartCoroutine(nameof(CheckQuests));
    }

    private List<ActiveQuest> _currentQuests = new();
    internal static bool QuestTrackerNeedsUpdating { get; set; }
    internal static bool QuestTrackerNeedsRebuilding { get; set; }
    private IEnumerator CheckQuests()
    {
        while (true)
        {
            var ok = HeroMerchant.Instance != null && GameManager.Instance != null;
            if (ok)
            {
                var activeQuests = QuestTracker.GetQuests(); // replace this with your function to fetch active quests

                if (!CompareQuestLists(_currentQuests, activeQuests) || QuestTrackerNeedsUpdating || QuestTrackerNeedsRebuilding)
                {
                    // The quests have changed, update the tracker
                    yield return QuestTracker.RunUpdateQuestTrackerIE(QuestTrackerNeedsRebuilding);

                    // update the current snapshot of quests
                    _currentQuests = activeQuests;
                    QuestTrackerNeedsUpdating = false;
                }
            }

            yield return new WaitForSeconds(TrackerUpdatePeriod.Value); // wait for 3 second before next check
        }
        // ReSharper disable once IteratorNeverReturns
    }

    private static bool CompareQuestLists(IReadOnlyCollection<ActiveQuest> list1, IReadOnlyCollection<ActiveQuest> list2)
    {
        // If the counts are different, the lists are definitely not the same
        if (list1.Count != list2.Count)
        {
            return false;
        }

        // Create copies of the lists so that we can modify them without affecting the originals
        var tempList1 = new List<ActiveQuest>(list1);
        var tempList2 = new List<ActiveQuest>(list2);

        // For each quest in the first list, try to find and remove a matching quest from the second list
        foreach (var matchingQuest in tempList1.Select(quest1 => tempList2.FirstOrDefault(quest2 => AreActiveQuestsEqual(quest1, quest2))))
        {
            if (matchingQuest == null)
            {
                // We didn't find a match, so the lists are not the same
                return false;
            }

            // We found a match, so remove it from the second list and move on to the next quest
            tempList2.Remove(matchingQuest);
        }

        // If we've made it this far, all quests in the first list had a match in the second list, so the lists are the same
        return true;
    }

    private static bool AreActiveQuestsEqual(ActiveQuest quest1, ActiveQuest quest2)
    {
        // Compare whatever properties you consider important to determine if two ActiveQuests are effectively the same
        return quest1.quest == quest2.quest && quest1.completed == quest2.completed && quest1.failed == quest2.failed
               && quest1.completeDay == quest2.completeDay && quest1.giverVisitorPrefabName == quest2.giverVisitorPrefabName;
    }


    private void Update()
    {
        if ((InputManager.ActiveDevice.RightStickButton.WasPressed || InputManager.ActiveDevice.LeftStickButton.WasPressed || QuestTrackerToggleKeybind.Value.IsUp()) && QuestTracker.QuestTrackerObject != null)
        {
            QuestTracker.QuestTrackerObject.SetActive(!QuestTracker.QuestTrackerObject.activeSelf);
        }
    }

    private void OnDisable()
    {
        Logger.LogError("I've been disabled! Do you have the necessary DLC?");
    }


    private void OnDestroy()
    {
        Logger.LogError("I've been destroyed!");
    }
}