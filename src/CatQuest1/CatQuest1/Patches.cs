namespace CatQuest1;

[Harmony]
public static class Patches
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(Cutscene_Gentlebros), nameof(Cutscene_Gentlebros.Start))]
    public static void Cutscene_Gentlebros_Start(Cutscene_Gentlebros __instance)
    {
        __instance.OnCutsceneEnd();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SystemSettings), MethodType.Constructor)]
    public static void SystemSettings_Constructor(SystemSettings __instance)
    {
        __instance.IsFacebookLiked = true;
        __instance.IsTwitterFollowed = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SystemSettings), nameof(SystemSettings.ApplySettings))]
    public static bool SystemSettings_ApplySettings(SystemSettings __instance)
    {
        if (Plugin.UseCustomRefreshRate.Value)
        {
            Screen.SetResolution(__instance.Resolution.width, __instance.Resolution.height, Plugin.FullScreenModeConfig.Value, Plugin.CustomRefreshRate.Value);
            Application.targetFrameRate = Plugin.CustomRefreshRate.Value;
        }
        else
        {
            Screen.SetResolution(__instance.Resolution.width, __instance.Resolution.height, Plugin.FullScreenModeConfig.Value, Plugin.MaxRefreshRate);
            Application.targetFrameRate = Plugin.MaxRefreshRate;
        }
        return false;
    }


}