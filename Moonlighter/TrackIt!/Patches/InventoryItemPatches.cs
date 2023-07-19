using System.Diagnostics.CodeAnalysis;
using HarmonyLib;

namespace TrackIt.Patches
{
    [HarmonyPatch]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class InventoryItemPatches
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(InventoryPanel), nameof(InventoryPanel.OnInventorySlotSwap), typeof(InventorySlotGUI), typeof(InventorySlotGUI))]
        public static void InventoryPanel_OnInventorySlotSwap(ref InventoryPanel __instance, ref InventorySlotGUI origin, ref InventorySlotGUI destination)
        {
            Helpers.UpdateQuestIconVisibilityInInventories(origin);
            Helpers.UpdateQuestIconVisibilityInInventories(destination);
        }


        [HarmonyPostfix]
        [HarmonyPatch(typeof(InventorySlotGUI), nameof(InventorySlotGUI.SetItem), typeof(ItemMaster), typeof(int), typeof(bool))]
        public static void InventorySlotGUI_SetItem(ref InventorySlotGUI __instance, ref ItemMaster master)
        {
            if (__instance is null) return;
            if (__instance.transform == null) return;
            if (__instance.imageWishlisted == null) return;
            if (__instance.imageWishlisted.rectTransform == null) return;
            if (master is null)
            {
                Helpers.UpdateQuestIconVisibilityInInventories(__instance);
                return;
            }

            Helpers.CreateAndAttachQuestSprite(__instance);

            Helpers.UpdateQuestIconVisibilityInInventories(__instance);
        }
    }
}