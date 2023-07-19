using HarmonyLib;

namespace QoL.Patches;

[HarmonyPatch]
public static class SkipPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoSequence), nameof(VideoSequence.Play))]
    public static bool VideoSequence_Play(ref VideoSequence __instance)
    {
        return !Plugin.SkipIntros.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MainMenuPanel), nameof(MainMenuPanel.ShowGamepadGUI))]
    public static bool MainMenuPanel_ShowGamepadGUI(ref MainMenuPanel __instance)
    {
        if (!Plugin.SkipIntros.Value) return true;
        
        __instance.CloseGamepadPanel();
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuPanel), nameof(MainMenuPanel.PlayPressKeyReminderAnimationDelayed))]
    public static void MainMenuPanel_PlayPressKeyReminderAnimationDelayed(ref MainMenuPanel __instance)
    {
        if (!Plugin.SkipIntros.Value) return;
        
        __instance.PlayOpenAnimation();
        __instance.StopPressKeyReminderAnimation();
        __instance.SetInteractable(true, __instance.mainMenuButtons);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuPanel), nameof(MainMenuPanel.CheckContinueAndSelectFirstButton))]
    public static void MainMenuPanel_CheckContinueAndSelectFirstButton(ref MainMenuPanel __instance)
    {
        if (!Plugin.LoadStraightIntoGame.Value) return;
        
        if (__instance.HasLoadedGame)
        {
            __instance.StartGame();
        }
    }  
}