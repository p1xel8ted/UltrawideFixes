using System.Diagnostics.CodeAnalysis;
using HarmonyLib;

namespace TrackIt.Patches;

[HarmonyPatch]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class EnemyPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.SpawnEnemy), typeof(DungeonRoomInfo.EnemySpawn), typeof(int), typeof(bool))]
    public static void InventoryPanel_Updates(ref DungeonRoom __instance, ref DungeonRoomInfo.EnemySpawn spawnPair, ref int tile, ref bool isChampion, ref Enemy __result)
    {
        var quest = Helpers.IsQuestEnemy(spawnPair.enemy);
        if (__result != null && quest)
        {
            Plugin.Logger.LogWarning($"{__instance.name} spawned enemy: {spawnPair.enemy.name}. Champion?: {isChampion}. Quest?: {true}");
            Helpers.AttachQuestMarkerToEnemy(__result);
        }
    }
}