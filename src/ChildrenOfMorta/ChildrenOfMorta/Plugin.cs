using System.Collections;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace ChildrenOfMorta;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.childrenofmorta.ultrawide";
    private const string PluginName = "Ultra-Wide!";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; private set; }

    internal static ConfigEntry<int> PlayerHudXPosition { get; private set; }
    internal static ConfigEntry<int> MiniMapPosition { get; private set; }
    internal static ConfigEntry<bool> CustomPositions { get; private set; }

    private static Coroutine UpdateCoroutine { get; set; }

    private void Awake()
    {
        CustomPositions = Config.Bind("UI", "Custom Positions", false, "Use custom positions");
        CustomPositions.SettingChanged += (_, _) =>
        {
            if (UpdateCoroutine != null)
            {
                StopCoroutine(UpdateCoroutine);
                UpdateCoroutine = null;
            }
            
            if (CustomPositions.Value)
            {
                UpdateCoroutine = StartCoroutine(UpdateAll());
            }
            else
            {
                foreach (var gObject in Patches.OriginalPositions.Where(gObject => gObject.Key != null))
                {
                    Log.LogInfo($"Resetting position of {gObject.Key.name} to {gObject.Value}");
                    gObject.Key.transform.localPosition = gObject.Value;
                }
            }
        };
        PlayerHudXPosition = Config.Bind("UI", "Player HUD Position", 0, "X position of the player HUD");
        MiniMapPosition = Config.Bind("UI", "Mini Map Position", 0, "X position of the mini map");

        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
    }

    private void Start()
    {
        UpdateCoroutine = StartCoroutine(UpdateAll());
    }

    private static IEnumerator UpdateAll()
    {
        while (true)
        {
            Patches.UpdateAll();
            yield return new WaitForSeconds(1);
        }
        // ReSharper disable once IteratorNeverReturns
    }
}