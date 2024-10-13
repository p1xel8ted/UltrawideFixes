// MonoMethods.cs

using SeaOfStars.Handlers;
using SeaOfStars.Managers;

namespace SeaOfStars.Components;

public class MonoMethods : MonoBehaviour
{
    private void Update()
    {
        ViewportHandler.HandleViewportShifts();
        ViewportHandler.ResetViewportOnResetKey();
        SoSuiManager.FindUIElements();
        SoSuiManager.AdjustLoadTransitionScale();
        SoSuiManager.UpdateLoadTransitionCanvasUpscaleViewports();
        SoSuiManager.UpdateFishingViewportsIfNeeded();
    }
}