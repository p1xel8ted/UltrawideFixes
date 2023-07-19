using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using SodaDen.Pacha;
using UnityEngine;

namespace CavemanQoL;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public partial class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.rootsofpacha.cavemanqol";
    private const string PluginName = "Caveman QoL";
    private const string PluginVersion = "0.0.1";
    private static ManualLogSource LOG { get; set; }
    

    private void Awake()
    {
        LOG = new ManualLogSource(nameof(CavemanGoggles));
        BepInEx.Logging.Logger.Sources.Add(LOG);

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private void Update()
    {
        if (Session.Instance == null) return;
        if (Input.GetKeyUp(KeyCode.F5))
        {
            SavedGames.Save(Session.Instance.CurrentDay.Value, Session.Instance.ShippingBin.NextDayContributions, Session.Instance.ShippingBin.NextDayProsperity);
        }
    }

    private void OnDestroy()
    {
        LOG.LogInfo($"{PluginName} has been destroyed!");
    }

    private void OnDisable()
    {
        LOG.LogInfo($"{PluginName} has been disabled!");
    }

      
}