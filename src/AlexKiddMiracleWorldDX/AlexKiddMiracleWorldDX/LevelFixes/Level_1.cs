using System;
using System.Linq;
using AlexKiddMiracleWorldDX.Constants;
using AlexKiddMiracleWorldDX.Misc;
using Assets.Scripts.Manager;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

namespace AlexKiddMiracleWorldDX.LevelFixes;

[Harmony]
public static class Level_1
{
    private static bool CorrectScene => SceneManager.GetActiveScene().name.Equals(Levels.level_1, StringComparison.OrdinalIgnoreCase);
    
    internal static void RunFixes()
    {
        if (!CorrectScene) return;
        
        var floorRemake = Resources.FindObjectsOfTypeAll<Tilemap>().First(a => a.name == "FloorRemake");
        if (floorRemake)
        {
            var floor = floorRemake.transform.parent.transform.FindFirstChildByName("Floor");
            if (floor)
            {
                floor.localScale = floor.localScale with {x = Plugin.PositiveScaleFactor};
            }

            var grass = floorRemake.transform.parent.transform.FindFirstChildByName("HierbaRemake");
            if (grass)
            {
                grass.localScale = grass.localScale with {x = Plugin.PositiveScaleFactor};
            }

            floorRemake.transform.localScale = floorRemake.transform.localScale with {x = Plugin.PositiveScaleFactor};

            var destroyables = floorRemake.transform.parent.transform.FindFirstChildByName("Destroyable");
            foreach (var destroyable in destroyables.GetComponentsInChildren<Transform>())
            {
                destroyable.localPosition = destroyable.localPosition with {x = destroyable.localPosition.x * Plugin.PositiveScaleFactor};
            }
        }
    }
}