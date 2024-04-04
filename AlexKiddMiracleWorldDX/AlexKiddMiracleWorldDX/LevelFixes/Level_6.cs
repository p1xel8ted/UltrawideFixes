using AlexKiddMiracleWorldDX.MonoBehaviours;
using UnityEngine;

namespace AlexKiddMiracleWorldDX.LevelFixes;

public static class Level_6
{
    public static void RunFixes()
    {
        var background1 = GameObject.Find("Tilemap Bottom/BackgroundWaterRemake/background_water");
        if (background1)
        {
            background1.gameObject.AddComponent<PositiveScaler>();
        }
        
        var background2 = GameObject.Find("Tilemap Bottom/BackgroundWaterRemake/background_water (1)");
        if (background2)
        {
            background2.gameObject.AddComponent<PositiveScaler>();
        }
        
        var classicBackground = GameObject.Find("Tilemap Bottom/Background");
        if (classicBackground)
        {
            classicBackground.gameObject.AddComponent<PositiveScaler>();
        }
    }
}