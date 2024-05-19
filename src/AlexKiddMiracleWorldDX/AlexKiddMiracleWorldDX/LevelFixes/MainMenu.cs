namespace AlexKiddMiracleWorldDX.LevelFixes;


public static class MainMenu
{
    private static bool CorrectScene => SceneManager.GetActiveScene().name.Equals(Levels.main_menu, StringComparison.OrdinalIgnoreCase);
    
    public static void FixBackground()
    {
        // if (SceneManager.GetActiveScene().name.Equals(Levels.main_menu))
        // {
        //     var staticBackground = GameObject.Find("Menu/Canvas/ScreenFitter/Options Menu/Consoles/Background");
        //     if (staticBackground)
        //     {
        //         Scalers.AddPositiveScaler(staticBackground.gameObject, updateEnabled: false);
        //     }
        // }
    }
    
}