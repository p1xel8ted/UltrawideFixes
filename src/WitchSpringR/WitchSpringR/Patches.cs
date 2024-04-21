using DG.Tweening;
using HarmonyLib;
using UnityEngine;

namespace WitchSpringR;

[Harmony]
public static class Patches
{
    private static float PanelQuestionTargetPosition { get;  set; }
    //internal static Panel_ItemInfo_Left Panel_ItemInfo_Left_Instance { get; private set; }
    internal static Panel_TrainingResultNew PanelTrainingResultNewInstance { get; private set; }
    internal static Panel_Question_Target PanelQuestionTargetInstance { get; private set; }
    // internal static Panel_InfoText Panel_InfoText_Instance { get; private set; }
    internal static Panel_EnemyStatus PanelEnemyStatusInstance { get; private set; }
    internal static GuideTextPanel GuideTextPanelInstance { get; private set; }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Panel_BattleTotalDamage), nameof(Panel_BattleTotalDamage.SetDamage))]
    [HarmonyPatch(typeof(Panel_BattleTotalDamage), nameof(Panel_BattleTotalDamage.Update))]
    public static void Panel_BattleTotalDamage_Patches(ref Panel_BattleTotalDamage __instance)
    {
        __instance.transform.DOMoveX(WitchSpringRUltrawide.Difference, 0.25f).SetEase(Ease.OutCubic).SetUpdate(true);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Panel_EnemyStatus), nameof(Panel_EnemyStatus.ShowNowPanelOn))]
    public static void Panel_EnemyStatus_Patches(ref Panel_EnemyStatus __instance)
    {
        PanelEnemyStatusInstance = __instance;
        __instance.transform.DOMoveX(WitchSpringRUltrawide.HalfUltraWidth, 0.25f).SetEase(Ease.OutCubic)
            .SetUpdate(true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Panel_TrainingResultNew), nameof(Panel_TrainingResultNew.Start))]
    [HarmonyPatch(typeof(Panel_TrainingResultNew), nameof(Panel_TrainingResultNew.ShowResult))]
    [HarmonyPatch(typeof(Panel_TrainingResultNew), nameof(Panel_TrainingResultNew.ShowResultStart))]
    public static void Panel_TrainingResultNew_Patches(ref Panel_TrainingResultNew __instance)
    {
        PanelTrainingResultNewInstance = __instance;
        __instance.transform.DOMoveX(WitchSpringRUltrawide.HalfUltraWidth, 0.25f).SetEase(Ease.OutCubic)
            .SetUpdate(true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Panel_Question_Target), nameof(Panel_Question_Target.EndTick))]
    public static void Panel_Question_Target_Patches(ref Panel_Question_Target __instance)
    {
        PanelQuestionTargetInstance = __instance;
        if (PanelQuestionTargetPosition == 0)
        {
            PanelQuestionTargetPosition =
                __instance.transform.position.x - (WitchSpringRUltrawide.WidthDifference / 2f);
        }

        __instance.tracingPanel.enabled = false;
        __instance.transform.DOMoveX(PanelQuestionTargetPosition, 0.25f).SetEase(Ease.OutCubic).SetUpdate(true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Panel_Talk), nameof(Panel_Talk.Update))]
    public static void Panel_Talk_Patches(ref Panel_Talk __instance)
    {
        if (__instance == null) return;
        var tp = __instance.GetComponent<TracingPanel>();
        if (tp != null)
        {
            tp.plusVector =
                new Vector3(-(WitchSpringRUltrawide.WidthDifference / 2f) + 110, 0, 0);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Panel_ItemInfo_Left), nameof(Panel_ItemInfo_Left.SetItemInfo))]
    [HarmonyPatch(typeof(Panel_ItemInfo_Left), nameof(Panel_ItemInfo_Left.EndBar))]
    [HarmonyPatch(typeof(Panel_ItemInfo_Left), nameof(Panel_ItemInfo_Left.SetItemInfo_Center))]
    public static void Panel_ItemInfo_Left_Patches(ref Panel_ItemInfo_Left __instance)
    {
        if (!WitchSpringRUltrawide.PanelItemInfoLeftInstances.Contains(__instance))
        {
            WitchSpringRUltrawide.PanelItemInfoLeftInstances.Add(__instance);
        }

        __instance.transform.DOMoveX(WitchSpringRUltrawide.WidthDifference / 2f, 0.25f).SetEase(Ease.OutCubic)
            .SetUpdate(true);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GuideTextPanel), nameof(GuideTextPanel.SetGuide))]
    [HarmonyPatch(typeof(GuideTextPanel), nameof(GuideTextPanel.ShowInfo))]
    [HarmonyPatch(typeof(GuideTextPanel), nameof(GuideTextPanel.OnComplete))]
    public static void GuideTextPanel_Patches(ref GuideTextPanel __instance)
    {
        GuideTextPanelInstance = __instance;
        __instance.transform.DOMoveX(WitchSpringRUltrawide.HalfUltraWidth, 0.25f).SetEase(Ease.OutCubic)
            .SetUpdate(true);
    }
}