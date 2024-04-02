namespace DeathMustDie;

[Harmony]
public static class Patches
{
    private static bool ComeFromGame { get; set; }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Game), nameof(Game.ExitToMainMenu))]
    public static void Game_ExitToMainMenu()
    {
        ComeFromGame = true;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Facade_MainMenu), nameof(Facade_MainMenu.Start))]
    public static void Facade_MainMenu_Start(ref Facade_MainMenu __instance)
    {
        var buttons = __instance._buttons.Selectables;

        if (Plugin.RemoveExcessMenuItems.Value)
        {
            //disable the discord etc. buttons in the bottom right
            foreach (var button in __instance._sideButtons.Selectables)
            {
                button.SetInteractable(false);
                button.gameObject.SetActive(false);
            }

            // [0] Button_Play
            // [1] Button_Options
            // [2] Button_PatchNotes
            // [3] Button_Credits
            // [4] Button_Quit
            
            //disable the patch notes and credits button, and correct the navigation
            buttons[1].SetMoveTarget(MoveDirection.Down, buttons[4].gameObject);
            buttons[4].SetMoveTarget(MoveDirection.Up, buttons[1].gameObject);
            buttons[4].SetMoveTarget(MoveDirection.Down, buttons[0].gameObject);
            buttons[4].SetMoveTarget(MoveDirection.Down, buttons[0].gameObject);
            buttons[0].SetMoveTarget(MoveDirection.Up, buttons[4].gameObject);

            buttons[2].SetInteractable(false);
            buttons[2].gameObject.SetActive(false);

            buttons[3].SetInteractable(false);
            buttons[3].gameObject.SetActive(false);
        }

        if (Plugin.LoadStraightIntoGame.Value && !Input.GetKey(KeyCode.LeftShift) && !ComeFromGame)
        {
            // load immediately into the game
            buttons[0].OnClickEv.Invoke(MainMenuOption.Play);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ParallaxLayer), nameof(ParallaxLayer.OnEnable))]
    public static void ParallaxLayer_OnEnable(ref ParallaxLayer __instance)
    {
        if (!Plugin.CorrectMainMenuBackground.Value) return;
        
        if (Plugin.BaseAspect > 21f / 9f)
        {
            __instance.transform.parent.transform.localScale = __instance.transform.parent.transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor}; 
        }
        else
        {
            __instance.transform.parent.transform.localScale = __instance.transform.parent.transform.localScale with {x = Plugin.PositiveScaleFactor}; 
        }
    }
}