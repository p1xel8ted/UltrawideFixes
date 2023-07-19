using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using Moonlighter.DLC.WandererDungeon;
using StackIt.Utilities;

namespace StackIt;

/// <summary>
/// A class that represents the modifications applied to items in the game.
/// This class is used to alter the properties of items, specifically their stack sizes.
/// </summary>
[HarmonyPatch]
public static class ItemPatches
{
    /// <summary>
    /// A dictionary used for backing up the original state of the items in the game.
    /// Each entry consists of a string key (item's name) and an integer value (item's max stack size).
    /// This backup is used to restore items to their original state.
    /// </summary>
    private static readonly WriteOnce<Dictionary<string, int>> ItemBackup = new();

    /// <summary>
    /// Retrieves all items in the game, including regular items, DLC items, and generated items.
    /// The items are retrieved from the game's ItemDatabase and then combined into a single HashSet.
    /// </summary>
    /// <returns>A HashSet of <see cref="ItemMaster"/> objects, each representing an item in the game.</returns>
    private static HashSet<ItemMaster> GetItems()
    {
        var regularItems = ItemDatabase.GetItems();
        var currentGamePlusLevel = GameManager.Instance.GetCurrentGamePlusLevel();
        var dlcItems = ItemDatabase.GetDLCItems("WANDERER_DLC", null, currentGamePlusLevel);
        var generatedItems = ItemDatabase.GetGeneratedItems();
        Plugin.LOG.LogInfo($"RegularItems: {regularItems.Count}, DlcItems: {dlcItems.Count}, GeneratedItems: {generatedItems.Count}");
        return new HashSet<ItemMaster>(regularItems.Concat(dlcItems).Concat(generatedItems));
    }

    /// <summary>
    /// Applies modifications to all items in the game.
    /// The modifications are applied based on the current game state and the settings of the StackIt plugin.
    /// If the Wanderer DLC is not enabled, an error message is logged and the method returns false.
    /// </summary>
    /// <returns>True if the modifications were applied successfully, false if the Wanderer DLC is not enabled.</returns>
    public static bool ApplyModifications()
    {
        if (WandererDLCController.Instance == null)
        {
            Plugin.LOG.LogError("WandererDLCController.Instance is null");
            return false;
        }

        var allItems = GetItems();

        if (!ItemBackup.HasValue)
        {
            ItemBackup.Value = new Dictionary<string, int>();
            foreach (var item in allItems)
            {
                ItemBackup.Value.TryAdd(item.nameKey, item.maxStack);
            }
        }

        // var text = string.Empty;

        foreach (var item in allItems.Where(Modify))
        {
            if (ItemBackup.Value.TryGetValue(item.nameKey, out var original))
            {
                // text+= $"\n\n------------------------------------------------------------";
                // text+= $"\nName: {item.nameKey}\nOriginal Size: {original}";
                item.maxStack = original;


                if (Plugin.StackIt.Value)
                {
                    DoubleStacks(item, original);
                }
                else if (Plugin.CustomStackSizes.Value && original < Plugin.MaxStackSize.Value)
                {
                    CustomStackSizes(item, original);
                }
                
                // text+= $"\nNew Size: {item.maxStack}";
            }
            else
            {
                Plugin.LOG.LogWarning($"Item not found in backup: {item.name}");
            }
        }
        // Plugin.LOG.LogWarning(text);

        return true;
    }

    /// <summary>
    /// This method is invoked after the Wanderer DLC has been enabled.
    /// It applies the modifications to the items in the game by calling the <see cref="ApplyModifications"/> method.
    /// This method serves as a Harmony postfix patch for the <see cref="WandererDLCController.Enable"/> method.
    /// </summary>
    /// <param name="__instance">The instance of the Wanderer DLC controller where the method is patched.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(WandererDLCController), nameof(WandererDLCController.Enable))]
    public static void WandererDLCController_Enable(ref WandererDLCController __instance)
    {
        ApplyModifications();
    }


    /// <summary>
    /// Determines whether a given item should be modified.
    /// This method ignores coins and items with a total stack size of 3 or 4.
    /// </summary>
    /// <param name="item">The <see cref="ItemMaster"/> object representing the item to check.</param>
    /// <returns>True if the item should be modified, otherwise false.</returns>
    private static bool Modify(ItemMaster item)
    {
        //ignores coin has it has a stack size of 999999999... and returns false for items that have 1 of each stack size as they are not stackable/unique
        if (item.name.Equals("Coin")) return false;

        var a = item.minChestStack;
        var b = item.maxChestStack;
        var c = item.maxStack;
        var d = item.fixedChestStack;
        var total = a + b + c + d;
        switch (total)
        {
            case 3:
            case 4:
                return false;
            default:
                return true;
        }
    }

    /// <summary>
    /// Doubles the maximum stack size of a given item.
    /// If the original stack size is greater than 0, the item's max stack size is set to twice the original value.
    /// </summary>
    /// <param name="item">The <see cref="ItemMaster"/> object representing the item to modify.</param>
    /// <param name="original">The original maximum stack size of the item.</param>
    private static void DoubleStacks(ItemMaster item, int original)
    {
        if (original > 0)
        {
            item.maxStack = original * 2;
        }
    }

    /// <summary>
    /// Applies custom stack sizes to a given item.
    /// If the original stack size is greater than 0 and less than the maximum stack size specified by the StackIt plugin,
    /// the item's max stack size is set to the plugin's maximum stack size.
    /// </summary>
    /// <param name="item">The <see cref="ItemMaster"/> object representing the item to modify.</param>
    /// <param name="original">The original maximum stack size of the item.</param>
    private static void CustomStackSizes(ItemMaster item, int original)
    {
        if (original > 0 && item.maxStack < Plugin.MaxStackSize.Value)
        {
            item.maxStack = Plugin.MaxStackSize.Value;
        }
    }
}