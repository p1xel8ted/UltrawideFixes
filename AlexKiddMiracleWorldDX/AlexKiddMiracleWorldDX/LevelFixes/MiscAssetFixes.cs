using System;
using System.Linq;
using AlexKiddMiracleWorldDX.Constants;
using AlexKiddMiracleWorldDX.Misc;
using AlexKiddMiracleWorldDX.MonoBehaviours;
using UnityEngine;
using UnityEngine.Animations;

namespace AlexKiddMiracleWorldDX.LevelFixes;

public static class MiscAssetFixes
{
    internal static void RunIlluminationFixes()
    {
        var globalVolume = GameObject.Find("GameController/Default Illumination");
        if (globalVolume)
        {
            globalVolume.TryAddComponent<EffectsToggler>();
        }
    }


    internal static void RunParallaxFixes()
    {
        var parallax = GameObject.Find("GameController/Camera Holder/Main Camera/Parallax");
        if (parallax)
        {
            Scalers.AddPositiveScaler(parallax, updateEnabled: false);
        }
    }

    internal static void RunPauseMenuFixes()
    {
        var pauseMenu = GameObject.Find(Const.PauseMenuOrangeBackground);
        if (pauseMenu)
        {
            Scalers.AddPositiveScaler(pauseMenu, updateEnabled: false);
        }
    }

    public static void RunWaterFixes()
    {
        var positionConstraints = Resources.FindObjectsOfTypeAll<PositionConstraint>();
        foreach (var pc in positionConstraints)
        {
            if (pc.name.Equals("Scarf")) continue;
            Scalers.AddPositiveScaler(pc.gameObject, buffers: new Vector2(10f, 0f), updateEnabled: false);
        }
    }

    public static void RunThunderFixes()
    {
        var thunder = Resources.FindObjectsOfTypeAll<Animator>().Where(a => a.name.Contains("thunder", StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (var thun in thunder)
        {
            Scalers.AddPositiveScaler(thun.gameObject, updateEnabled: false);
        }
    }

}