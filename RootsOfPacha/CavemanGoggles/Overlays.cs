using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx.Configuration;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace CavemanGoggles
{
    [HarmonyPatch]
    public partial class Plugin
    {
        private static readonly Dictionary<Type, MonoBehaviour> UiComponentCache = new();
        private static ConfigFile ConfigFile { get; set; }
        private static int Count { get; set; }

        [HarmonyPatch]
        public static class HarmonyTargetMethods
        {
            [HarmonyPatch]
            [HarmonyLib.HarmonyTargetMethods]
            public static IEnumerable<MethodBase> TargetMethods()
            {
                var uiTypes = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                    .Where(type => type.Namespace == "SodaDen.Pacha.UI" && (type.Name.EndsWith("Overlay", StringComparison.InvariantCultureIgnoreCase) || type.Name.EndsWith("Container", StringComparison.InvariantCultureIgnoreCase)))
                    .ToList();

                if (uiTypes.Count <= 0)
                {
                    LOG.LogWarning("No UI Types Found!");
                    yield break;
                }

                foreach (var type in uiTypes)
                {
                    ConfigEntry<float> thisUiType;
                    if (Count == 0)
                    {
                        thisUiType = ConfigFile.Bind<float>("Advanced Scales", type.Name, 1,
                            new ConfigDescription(
                                "Automatically generated from assemblies UI namespace. Will conflict with some of the main ones. If the setting keeps reverting to 0, the mod can't find the associated object in game.",
                                new AcceptableValueRange<float>(0.0f, 10f),
                                new ConfigurationManagerAttributes {IsAdvanced = true}));
                    }
                    else
                    {
                        thisUiType = ConfigFile.Bind<float>("Advanced Scales", type.Name, 1,
                            new ConfigDescription(
                                string.Empty,
                                new AcceptableValueRange<float>(0.0f, 10f),
                                new ConfigurationManagerAttributes {IsAdvanced = true}));   
                    }
                    Count++;
                    thisUiType.SettingChanged += (_, _) => UpdateScaleForUIType(type, ref thisUiType);
                }
            }
            

            private static void UpdateScaleForUIType(Type type, ref ConfigEntry<float> thisUiType)
            {
                if (!UiComponentCache.TryGetValue(type, out var uiComponent))
                {
                    uiComponent = FindObjectOfType(type) as MonoBehaviour;
                    if (uiComponent == null)
                    {
                        thisUiType.Value = -1;
                        return;
                    }
                    UiComponentCache[type] = uiComponent;
                }

                var greyOverlay = uiComponent.GetComponentInChildren<Image>(true);
                if (greyOverlay != null && greyOverlay.gameObject.activeSelf)
                {
                    greyOverlay.gameObject.SetActive(false);
                }

                uiComponent.transform.localScale = new Vector3(thisUiType.Value, thisUiType.Value, 1);
            }

        }
    }
}