// SceneHandlers.cs

using SeaOfStars.Core;
using SeaOfStars.Managers;

namespace SeaOfStars.Handlers;

public static class SceneHandlers
{
    public static void OnSceneUnloaded(Scene scene)
    {
        if (scene.name.Equals(Constants.InitialScene))
        {
            Time.timeScale = 1f;
        }

        State.FishingActive = SoSuiManager.FishingScreen != null;
        State.FishingViewPortUpdated = !State.FishingActive && State.FishingViewPortUpdated;
    }

    public static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals(Constants.InitialScene))
        {
            Time.timeScale = 10000f;
        }

        DisplayManager.UpdateDisplay();
        DisplayManager.UpdateFixedDeltaTime();

        SoSuiManager.ProcessSceneElements(scene.name);

        State.FishingActive = SoSuiManager.FishingScreen != null;
    }
}