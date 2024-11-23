// SceneHandlers.cs

namespace SeaOfStars.Handlers;

public static class SceneHandlers
{
    public static void OnSceneUnloaded(Scene scene)
    {
        if (scene.name.Equals(Core.Constants.InitialScene))
        {
            Time.timeScale = 1f;
        }
    }

    public static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals(Core.Constants.InitialScene))
        {
            Time.timeScale = 10000f;
        }

        DisplayManager.UpdateDisplay();
        DisplayManager.UpdateFixedDeltaTime();
        
        SoSuiManager.ProcessSceneElements();

        SoSuiManager.HandleConfigManager(ConfigManager.UI.UIManager.ShowMenu);
    }
}