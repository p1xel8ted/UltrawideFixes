namespace MagentaHorizon;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuFunctions), nameof(MainMenuFunctions.ResolutionChanged))]
    public static void MainMenuFunctions_ResolutionChanged(MainMenuFunctions __instance)
    {
        switch (__instance.resolution.value)
        {
            case 9:
                SetRes(__instance);
                break;
            default:
                return;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuFunctions), nameof(MainMenuFunctions.Start))]
    public static void MainMenuFunctions_Start(MainMenuFunctions __instance)
    {
        var optionData = new Dropdown.OptionData
        {
            text = $"{Plugin.MainWidth}x{Plugin.MainHeight}"
        };
        __instance.resolution.options.Add(optionData);
        MainMenuFunctions.sizeNumber = __instance.sceneData.screenResolution;
        switch (MainMenuFunctions.sizeNumber)
        {
            case 10:
                SetRes(__instance);
                break;
        }
    }

    private static void SetRes(MainMenuFunctions ctx)
    {
        MainMenuFunctions.sizeNumber = 10;
        ctx.sceneData.screenResolution = MainMenuFunctions.sizeNumber;
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, MainMenuFunctions.fullScreen, Plugin.MaxRefresh);
    }
}