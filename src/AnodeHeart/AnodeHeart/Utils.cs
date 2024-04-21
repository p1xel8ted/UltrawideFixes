using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace AnodeHeart;

public static class Utils
{
    internal static float GetNewScale(float reference)
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
            var newScale = GetNewScale(a.referenceResolution.y);
            a.scaleFactor = newScale;
        });
    }

    public static void UpdateItemSlotScaling()
    {
        var slots = GameObject.Find("LevelBase/Canvas/Below Overlay/MainMenu/Inventory(Clone)/ItemSlots");
        if (slots == null) return;
        var normalWidth = Display.main.systemHeight * 16f / 9f;
        var newScale = Display.main.systemWidth / normalWidth;
        slots.transform.localScale = new Vector3(newScale, 1, 1);
    }
}