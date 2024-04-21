namespace TrainValleyOne;

[Harmony]
public static class Patches
{
    private const string UIRootGaugePcGauge = "UI Root/Gauge/pcGauge";
    private static GameObject GaugeGameObject { get; set; }
    private static float NewLeftPosition { get; set; }
    private static float NewRightPosition { get; set; }
    private static bool PositionsCalculated { get; set; }

    private static GameObject GetGaugeGameObject()
    {
        return GaugeGameObject ??= GameObject.Find(UIRootGaugePcGauge);
    }

    private static void CalculatePositions(ToolBar toolBar)
    {
        if (PositionsCalculated) return;

        var leftPanelWidth = toolBar.leftPanel.sizeDelta.y; //120 at time of writing
        var ultraWidth = Display.main.systemWidth; //3440
        var normalWidth = Display.main.systemHeight * 16f / 9f; //1440 * 16 / 9 = 2560
        var difference = ultraWidth - normalWidth; //880
        var splitDifference = difference / 2f; //440

        NewLeftPosition = leftPanelWidth - splitDifference; //120 - 440 = -320
        NewRightPosition = Mathf.Abs(NewLeftPosition); //320

        PositionsCalculated = true;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ToolBar), nameof(ToolBar.Start))]
    [HarmonyPatch(typeof(ToolBar), nameof(ToolBar.ShowPanels))]
    public static void ToolBar_Start(ref ToolBar __instance)
    {
        CalculatePositions(__instance);
        UpdatePositions(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ToolBar), nameof(ToolBar.Update))]
    public static void ToolBar_Update(ref ToolBar __instance)
    {
        UpdatePositions(__instance);
    }

    private static void UpdatePositions(ToolBar __instance)
    {
        if (Plugin.ExpandUI.Value)
        {
            __instance.leftPanel.SetAnchoredPositionX(NewLeftPosition);
            __instance.rightPanel.SetAnchoredPositionX(NewRightPosition);
            SetGaugePosition(NewRightPosition - Plugin.GaugeAdjustment.Value);
        }
        else
        {
            ResetUIPositions(__instance);
        }
    }

    private static void SetGaugePosition(float position)
    {
        var gaugeGameObject = GetGaugeGameObject();
        if (gaugeGameObject != null)
        {
            gaugeGameObject.GetComponent<RectTransform>().SetAnchoredPositionX(position);
        }
    }

    private static void ResetUIPositions(ToolBar toolBar)
    {
        toolBar.leftPanel.SetAnchoredPositionX(0);
        toolBar.rightPanel.SetAnchoredPositionX(0);
        SetGaugePosition(0);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PromoAnimation), nameof(PromoAnimation.Start))]
    public static void PromoAnimation_Start(ref PromoAnimation __instance)
    {
        __instance.gameObject.SetActive(false);
    }
}