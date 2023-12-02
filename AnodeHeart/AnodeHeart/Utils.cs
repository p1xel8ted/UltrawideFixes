using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace AnodeHeart;

public static class Utils
{
    internal const int UiReferenceResolutionHeight = 135;

    private static float GetNewScale(float reference)
    {
        var displayHeight = Display.main.systemHeight;
        var scale = 1f / (reference / displayHeight);
        return scale;
    }

    internal static void UpdateScalers()
    {
        Resources.FindObjectsOfTypeAll<CanvasScaler>().ToList().ForEach(a =>
        {
            if (a.name.ToLowerInvariant().Contains("sinai")) return;
            a.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            a.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            var newScale = GetNewScale(a.referenceResolution.y) * Plugin.ConfigScale.Value;
            a.scaleFactor = newScale;
        });
    }

}