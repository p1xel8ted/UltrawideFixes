using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using SodaDen.Pacha.UI;
using UnityEngine;

namespace CavemanGoggles
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public partial class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.rootsofpacha.cavemangoggles";
        private const string PluginName = "CavemanGoggles";
        private const string PluginVersion = "0.0.1";

        private static ConfigEntry<float> QuickslotsContainerScale { get; set; }
        private static ConfigEntry<float> ActionHintsContainerScale { get; set; }
        private static ConfigEntry<float> ClockContainerScale { get; set; }
        private static ConfigEntry<float> MasterCanvasScale { get; set; }
        private static QuickslotsContainer QuickslotsContainer { get; set; }
        private static ActionHintsContainer ActionHintsContainer { get; set; }
        private static ClockContainer ClockContainer { get; set; }
        private static Canvas MasterCanvas { get; set; }
        private static ManualLogSource LOG { get; set; }

        private const string Mainscale = "Main Scale";

        private void Awake()
        {
            LOG = new ManualLogSource(nameof(CavemanGoggles));
            BepInEx.Logging.Logger.Sources.Add(LOG);

            ConfigFile = Config;

            MasterCanvasScale = Config.Bind<float>(Mainscale, nameof(MasterCanvasScale), 4,
                new ConfigDescription(
                    "This is the overall scale of most, if not the entire UI. Change this first, then set individually below.",
                    new AcceptableValueRange<float>(0, 10f), new ConfigurationManagerAttributes {Order = 4}));
            MasterCanvasScale.SettingChanged += OnScaleChanged;

            QuickslotsContainerScale = Config.Bind<float>(Mainscale, nameof(QuickslotsContainerScale), 1,
                new ConfigDescription(
                    "The scale of the actionbar/quickslots at the bottom left of the screen.",
                    new AcceptableValueRange<float>(0, 10f), new ConfigurationManagerAttributes {Order = 3}));
            QuickslotsContainerScale.SettingChanged += OnScaleChanged;

            ActionHintsContainerScale = Config.Bind<float>(Mainscale, nameof(ActionHintsContainerScale), 1,
                new ConfigDescription(
                    "The scale of the little menu at the bottom right of the screen.",
                    new AcceptableValueRange<float>(0, 10f), new ConfigurationManagerAttributes {Order = 2}));
            ActionHintsContainerScale.SettingChanged += OnScaleChanged;

            ClockContainerScale = Config.Bind<float>(Mainscale, nameof(ClockContainerScale), 1,
                new ConfigDescription(
                    "The scale of clock section at the top right of the screen.",
                    new AcceptableValueRange<float>(0, 10f), new ConfigurationManagerAttributes {Order = 1}));
            ClockContainerScale.SettingChanged += OnScaleChanged;


            Config.Bind(Mainscale, "Reset to Recommended", true,
                new ConfigDescription("Set scales to default.", null,
                    new ConfigurationManagerAttributes
                        {Order = 0, HideDefaultButton = true, CustomDrawer = ResetButtonDrawer}));

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            LOG.LogInfo($"Plugin {PluginName} is loaded!");
        }
        
        private void OnDestroy()
        {
            LOG.LogInfo($"{PluginName} has been destroyed!");
        }

        private void OnDisable()
        {
            LOG.LogInfo($"{PluginName} has been disabled!");
        }

        private static bool _showConfirmationDialog;

        private static void DisplayConfirmationDialog()
        {
            GUILayout.Label("Are you sure you want to reset to default scales?");

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Yes", GUILayout.ExpandWidth(true)))
                {
                    ResetScalesAction();
                    _showConfirmationDialog = false;
                }

                if (GUILayout.Button("No", GUILayout.ExpandWidth(true)))
                {
                    _showConfirmationDialog = false;
                }
            }
            GUILayout.EndHorizontal();
        }

        private static void ResetButtonDrawer(ConfigEntryBase entry)
        {
            if (_showConfirmationDialog)
            {
                DisplayConfirmationDialog();
            }
            else
            {
                var button = GUILayout.Button("Reset Scales", GUILayout.ExpandWidth(true));
                if (button)
                {
                    _showConfirmationDialog = true;
                }
            }
        }

        private static void ResetScalesAction()
        {
            MasterCanvasScale.Value = 4;
            QuickslotsContainerScale.Value = 1;
            ActionHintsContainerScale.Value = 1;
            ClockContainerScale.Value = 1;

            foreach (var setting in ConfigFile.Select(kv => kv.Value))
            {
                setting.BoxedValue = setting.DefaultValue;
            }

            ConfigFile.Save();
        }

        private static void OnScaleChanged(object sender, System.EventArgs e)
        {
            void OnScaleChangedUpdateScale(Transform transform, float scaleValue)
            {
                if (scaleValue > 0)
                {
                    transform.localScale = new Vector3(scaleValue, scaleValue, 1);
                }
            }

            if (MasterCanvas != null && MasterCanvasScale.Value > 0)
            {
                MasterCanvas.scaleFactor = MasterCanvasScale.Value;
            }

            if (QuickslotsContainer != null)
            {
                OnScaleChangedUpdateScale(QuickslotsContainer.transform, QuickslotsContainerScale.Value);
            }

            if (ActionHintsContainer != null)
            {
                OnScaleChangedUpdateScale(ActionHintsContainer.transform, ActionHintsContainerScale.Value);
            }

            if (ClockContainer != null)
            {
                OnScaleChangedUpdateScale(ClockContainer.transform, ClockContainerScale.Value);
            }
        }
    }
}