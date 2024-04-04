using System;
using AlexKiddMiracleWorldDX.Constants;
using AlexKiddMiracleWorldDX.MonoBehaviours;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlexKiddMiracleWorldDX.LevelFixes;

public static class Level_2
{

    private static bool CorrectScene => SceneManager.GetActiveScene().name.Equals(Levels.level_2, StringComparison.OrdinalIgnoreCase);

    internal static void RunFixes()
    {
        if (!CorrectScene) return;

        var tileMap = GameObject.Find("Tilemap/BackgroundRemake");
        if (tileMap)
        {
            //this expands the water sprite to the left on modern level 2 (ignore the level_06, reused object)
            SpriteExpander.ExpandSpriteHorizontally(tileMap, "level_06_animated_water", 20, true);

            //scales the tree
            Scalers.AddPositiveScaler(tileMap, "level_02_entradilla", updateEnabled: false);
        }
    }

}