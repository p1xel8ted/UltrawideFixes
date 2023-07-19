using HarmonyLib;
using SodaDen.Pacha.UI;
using UnityEngine;

namespace CavemanGoggles
{
    [HarmonyPatch]
    public partial class Plugin
    {
        private static void UpdateScale(Transform transform, float scaleValue)
        {
            if (scaleValue <= 0) return;
            transform.localScale = new Vector3(scaleValue, scaleValue, 1);
        }

        private static void OnEnablePatchHelper(Component instance, float scaleValue)
        {
            FindAndUpdateMasterCanvas();
            UpdateScale(instance.transform, scaleValue);
        }
        
        
        [HarmonyPostfix]
        [HarmonyPatch(typeof(QuickslotsContainer), nameof(QuickslotsContainer.OnEnable))]
        public static void QuickslotsContainer_OnEnable(ref QuickslotsContainer __instance)
        {
            QuickslotsContainer = __instance;
            OnEnablePatchHelper(__instance, QuickslotsContainerScale.Value);
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(ActionHintsContainer), nameof(ActionHintsContainer.OnEnable))]
        public static void ActionHintsContainer_OnEnable(ref ActionHintsContainer __instance)
        {
            ActionHintsContainer = __instance;
            OnEnablePatchHelper(__instance, ActionHintsContainerScale.Value);
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(ClockContainer), nameof(ClockContainer.OnEnable))]
        public static void ClockContainer_OnEnable(ref ClockContainer __instance)
        {
            ClockContainer = __instance;
            OnEnablePatchHelper(__instance, ClockContainerScale.Value);
        }

        private static void FindAndUpdateMasterCanvas()
        {
            MasterCanvas = GameObject.Find("CanvasContainer/SessionMasterCanvas(Clone)").GetComponent<Canvas>();
            if (MasterCanvas != null && MasterCanvasScale.Value > 0)
            {
                MasterCanvas.scaleFactor = MasterCanvasScale.Value;
            }
        }
    }
}