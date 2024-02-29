namespace PeaksOfYore;

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
    [HarmonyPatch(typeof(DisplayOptions), nameof(DisplayOptions.InitialiseDisplayOptions))]
    public static void DisplayOptions_InitialiseDisplayOptions(DisplayOptions __instance)
    {
        __instance.resolutionDropdown.interactable = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DisplayOptions), nameof(DisplayOptions.SetScreenResCustom))]
    public static void DisplayOptions_SetScreenResCustom(DisplayOptions __instance)
    {
        Plugin.ChangeResolution();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Button), nameof(Button.ToggleFullScreen))]
    [HarmonyPatch(typeof(Button), nameof(Button.ToggleBorderlessWindowed))]
    public static bool Button_Toggles(Button __instance)
    {
        SetButtonOptions(__instance);
        return false;
    }
    private static void SetButtonOptions(Button __instance)
    {
        Button.fullScreenCheck = true;
        Button.borderlessCheck = true;
        
        ActivateAndDisableButton(__instance.buttonOn);
        ActivateAndDisableButton(__instance.buttonOff);
        ActivateAndDisableButton(__instance.borderlessButtonOn);
        ActivateAndDisableButton(__instance.borderlessButtonOff);
    }


    private static void ActivateAndDisableButton(GameObject buttonObj)
    {
        if (buttonObj == null) return;
        buttonObj.SetActive(true);
        var button = buttonObj.GetComponent<UnityEngine.UI.Button>();
        if (button != null)
        {
            button.interactable = false;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(Button), nameof(Button.LoadSavedOptions))]
    public static void Button_LoadSavedOptions(Button __instance)
    {
        SetButtonOptions(__instance);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution(ref int width, ref int height)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        fullscreenMode = FullScreenMode.FullScreenWindow;
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }
}