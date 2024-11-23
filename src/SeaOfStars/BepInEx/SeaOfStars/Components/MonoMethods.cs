// MonoMethods.cs

namespace SeaOfStars.Components;

public class MonoMethods : MonoBehaviour
{
    private void Update()
    {
        ViewportHandler.HandleViewportShifts();
        ViewportHandler.ResetViewportSizeKey();
    }
}