using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Cuisineer;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.cuisineer.cuisineertweaks";
    private const string PluginName = "Cuisineer Tweaks (IL2CPP)";
    private const string PluginVersion = "0.1.1";
    internal static ManualLogSource Logger { get; private set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<bool> IncreaseStackSize { get; private set; }
    internal static ConfigEntry<bool> InstantText { get; private set; }
    private static ConfigEntry<bool> EnableAutoSave { get; set; }
    private static ConfigEntry<int> AutoSaveFrequency { get; set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private static int TimeScale => FindLowestFrameRateMultipleAboveFifty(MaxRefresh);

    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        // Start from half of the original rate and decrement by one to find the highest multiple above 50.
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        // Fallback, though this scenario is unlikely with standard monitor refresh rates
        return originalRate;
    }

    public override void Load()
    {
        Logger = Log;
        CorrectFixedUpdateRate = Config.Bind("01. General", "CorrectFixedUpdateRate", true,
            new ConfigDescription("Correct the fixed update rate to the lowest multiple of the refresh rate above 50."));
        UseRefreshRateForFixedUpdateRate = Config.Bind("01. General", "UseRefreshRateForFixedUpdateRate", true,
            new ConfigDescription("Use the refresh rate for the fixed update rate. If false, the fixed update rate will be lowest multiple of the refresh rate above 50."));
        InstantText = Config.Bind("01. General", "InstantText", true,
            new ConfigDescription("Instantly show all text in cutscenes."));
        IncreaseStackSize = Config.Bind("01. General", "IncreaseStackSize", true,
            new ConfigDescription("Increase stack size to 999."));
        EnableAutoSave = Config.Bind("01. General", "EnableAutoSave", true,
            new ConfigDescription("Enable auto save."));
        EnableAutoSave.SettingChanged += (_, _) => UpdateAutoSave();
        AutoSaveFrequency = Config.Bind("01. General", "AutoSaveFrequency", 300, new ConfigDescription("Auto save frequency in seconds.", new AcceptableValueRange<int>(30, 600)));
        AutoSaveFrequency.SettingChanged += (_, _) => UpdateAutoSave();
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginGuid} is loaded!");
        AddComponent<UnityEvents>();
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Logger.LogInfo($"Scene loaded: {arg0.name}: Running Fixes");
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, MaxRefresh);
        Logger.LogInfo($"Set resolution to {Screen.currentResolution}");

        Application.targetFrameRate = MaxRefresh;
        Logger.LogInfo($"Set targetFrameRate to {Application.targetFrameRate}.");

        if (!CorrectFixedUpdateRate.Value) return;
        var scale = UseRefreshRateForFixedUpdateRate.Value ? MaxRefresh : TimeScale;
        Time.fixedDeltaTime = 1f / scale;
        Logger.LogInfo($"Set fixedDeltaTime to {Time.fixedDeltaTime} ({scale}).");

        UpdateAutoSave();
        UpdateInventoryStackSize();
    }

    private static void UpdateInventoryStackSize()
    {
        if (InventoryManager.Instance == null) return;
        foreach (var instanceMInventory in InventoryManager.Instance.m_Inventories)
        {
            if (instanceMInventory is {Value: null}) continue;
            foreach (var valueMSlot in instanceMInventory.Value.m_Slots)
            {
                if (valueMSlot == null || valueMSlot.ItemSO == null) continue;
                valueMSlot.ItemSO.m_MaxStack = 999;
                Logger.LogInfo($"Set {valueMSlot.ItemID} stack size to {valueMSlot.ItemSO.m_MaxStack} in inventory {instanceMInventory.Value.Type}");
            }
        }
    }

    private static void UpdateAutoSave()
    {
        if (CuisineerSaveManager.Instance == null) return;
        CuisineerSaveManager.Instance.m_AutoSave = EnableAutoSave.Value;
        CuisineerSaveManager.Instance.m_AutoSaveFrequency = AutoSaveFrequency.Value;
        Logger.LogInfo($"AutoSave: {CuisineerSaveManager.Instance.m_AutoSave} ({CuisineerSaveManager.Instance.m_AutoSaveFrequency / 60f} minutes)");
    }

    public class UnityEvents : MonoBehaviour
    {
        private void Awake()
        {
            Logger.LogInfo("UnityEvents Awake");
        }

        private void Update()
        {
            if (CuisineerInputWrapper.GetGameActionKeyUp(BattlebrewGameAction.DebugK))
            {
                CuisineerSaveManager.SaveCurrent();
                Logger.LogInfo("Saved current game.");
            }
        }
    }
}