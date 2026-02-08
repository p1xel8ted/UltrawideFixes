using DuloGames.UI;
using UnityEngine.UI;

namespace DominusAutoma;

[Harmony]
public static class Patches
{
    /// <summary>
    /// Clamps UICanvasAspectResize to 16:9 aspect ratio.
    /// Original: canvas width = camera.aspect * rect.height (stretches on ultrawide)
    /// Fixed: canvas width = min(camera.aspect, 16:9) * rect.height
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICanvasAspectResize), nameof(UICanvasAspectResize.Update))]
    public static void UICanvasAspectResize_Update(UICanvasAspectResize __instance)
    {
        if (!__instance.m_Camera) return;

        var aspect = __instance.m_Camera.aspect;
        if (aspect > Plugin.NativeAspect)
        {
            __instance.m_RectTransform.SetSizeWithCurrentAnchors(
                RectTransform.Axis.Horizontal,
                Plugin.NativeAspect * __instance.m_RectTransform.rect.size.y);
        }
    }

    /// <summary>
    /// Sets CanvasScaler to Expand mode for ultrawide displays.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if ((float)Screen.width / Screen.height > Plugin.NativeAspect)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }
}
