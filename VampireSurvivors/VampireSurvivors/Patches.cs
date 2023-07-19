using HarmonyLib;
using Il2CppVampireSurvivors.Data;
using Il2CppVampireSurvivors.Objects;
using Il2CppVampireSurvivors.UI;
using MelonLoader;
using UnityEngine;

namespace VampireSurvivors;

[HarmonyPatch]
public partial class VampireSurvivors
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Stage), nameof(Stage.InitStage))]
    public static void Stage_InitStage(StageType stageType)
    {
        CurrentType = stageType;
        Melon<VampireSurvivors>.Logger.Warning($"Stage: {CurrentType.ToString()}");
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameOverPage), nameof(GameOverPage.Start))]
    [HarmonyPatch(typeof(GameOverPage), nameof(GameOverPage.OnShowStart))]
    [HarmonyPatch(typeof(GameOverPage), nameof(GameOverPage.Construct))]
    public static void GameOverPage_Start(ref GameOverPage __instance)
    {
        __instance._Background.preserveAspect = false;
        var deathScreenMessage = GameObject.Find("GAME UI/Canvas - Game UI/Safe Area/View - Game Over/Container");
        if (deathScreenMessage != null)
        {
            Melon<VampireSurvivors>.Logger.Warning($"Found Death Screen Message - Adjusting Position");
            deathScreenMessage.transform.localPosition = new Vector3(4.2336f, -513.2808f, 0);
        }
    }
}