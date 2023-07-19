using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using UnityEngine;

namespace TrackIt.Patches
{
    [HarmonyPatch]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class ItemDropPatches
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(ItemStack), nameof(ItemStack.ApplyFallDamageEffect))]
        [HarmonyPatch(typeof(ItemStack), nameof(ItemStack.OnAddedToContainer))]
        [HarmonyPatch(typeof(ItemStack), nameof(ItemStack.OnAddedToHeroInventory))]
        public static void ItemStack_ApplyFallDamageEffect(ref ItemStack __instance)
        {
            Helpers.SetItemStackMarkersInactive(__instance);
            Plugin.QuestTrackerNeedsUpdating = true;
        }
        
        [HarmonyPostfix]
        [HarmonyPatch(typeof(ItemStack), nameof(ItemStack.OnAddedToHeroInventory))]
        [HarmonyPatch(typeof(ItemStack), nameof(ItemStack.OnAddedToContainer))]
        [HarmonyPatch(typeof(ItemStack), nameof(ItemStack.OnEndDrop))]
        public static void ItemStack_OnAddedToHeroInventory(ref ItemStack __instance)
        {
            Plugin.QuestTrackerNeedsUpdating = true;
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(ItemStack), nameof(ItemStack.Drop), typeof(Vector2), typeof(float), typeof(Transform))]
        public static void ItemStack_Drop(ref ItemStack __instance, ref Vector2 position, ref float radius, ref Transform parent)
        {
            Helpers.AttachMarkerToItemStack(__instance);
            Helpers.UpdateItemStackMarkerPositions(__instance);
            Plugin.QuestTrackerNeedsUpdating = true;
        }
    }
}