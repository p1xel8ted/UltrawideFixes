using I2.Loc;
using UnityEngine;

namespace xMysticSurvivor;

public static class ExtensionMethods
{
    public static void ResizeRect(this GameObject go)
    {
        var rectTransform = go.GetComponent<RectTransform>();
        if (rectTransform.sizeDelta == Vector2.zero)
        {
            Plugin.LOG.LogWarning($"ResizeRect: {go.name} has a size of 0, skipping.");
            return;
        }

        var y = rectTransform.sizeDelta.y;
        var x = y * Plugin.MainAspect;
        rectTransform.sizeDelta = new Vector2(x, y);
    }
}