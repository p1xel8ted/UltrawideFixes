// ViewportHandler.cs

using SeaOfStars.Managers;

namespace SeaOfStars.Handlers;

public static class ViewportHandler
{
    public static void HandleViewportShifts()
    {
        var isModifierPressed = Input.GetKey(Configuration.Configuration.ModifierKeybind.Value);

        if (isModifierPressed)
        {
            if (Input.GetKey(Configuration.Configuration.ShiftViewportLeftKeybind.Value))
            {
                ShiftViewportLeft();
            }

            if (Input.GetKey(Configuration.Configuration.ShiftViewportRightKeybind.Value))
            {
                ShiftViewportRight();
            }
        }
        else
        {
            if (Input.GetKeyDown(Configuration.Configuration.ShiftViewportLeftKeybind.Value))
            {
                ShiftViewportLeft();
            }

            if (Input.GetKeyDown(Configuration.Configuration.ShiftViewportRightKeybind.Value))
            {
                ShiftViewportRight();
            }
        }
    }

    public static void ResetViewportOnResetKey()
    {
        if (Input.GetKeyDown(Configuration.Configuration.ResetViewportKeybind.Value))
        {
            ResetViewports();
        }
    }

    private static void ShiftViewportLeft()
    {
        var newOffset = 0f;
        foreach (var v in SoSuiManager.CanvasUpscaleViewports.Where(v => v != null))
        {
            newOffset = v.customCanvasPos.x - 1f;
            v.customCanvasPos = new Vector2(newOffset, 0f);
        }

        Configuration.Configuration.UiPosition.Value = (int)newOffset;
    }

    private static void ShiftViewportRight()
    {
        var newOffset = 0f;
        foreach (var v in SoSuiManager.CanvasUpscaleViewports.Where(v => v != null))
        {
            newOffset = v.customCanvasPos.x + 1f;
            v.customCanvasPos = new Vector2(newOffset, 0f);
        }

        Configuration.Configuration.UiPosition.Value = (int)newOffset;
    }

    private static void ResetViewports()
    {
        foreach (var v in SoSuiManager.CanvasUpscaleViewports.Where(v => v != null))
        {
            v.customCanvasPos = new Vector2(SoSuiManager.CanvasPosition, 0f);
        }

        Configuration.Configuration.UiPosition.Value = SoSuiManager.CanvasPosition;
    }
}