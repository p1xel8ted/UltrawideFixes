using Microsoft.Xna.Framework.Graphics;
using SharpDX.Mathematics.Interop;
using SharpDX.MediaFoundation;

namespace Kynseed;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsDevice), nameof(GraphicsDevice.GetDisplayResolution))]
    public static void GraphicsDevice_GetDisplayResolution(GraphicsDevice __instance, ref int width, ref int height)
    {
        Plugin.Logger.LogWarning($"GraphicsDevice.GetDisplayResolution intercepted! {width}x{height}");
    }
    

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoDisplayControl), nameof(VideoDisplayControl.SetAspectRatioMode))]
    public static void VideoDisplayControl_SetAspectRatioMode(int dwAspectRatioMode)
    {
        Plugin.Logger.LogWarning($"VideoDisplayControl.SetAspectRatioMode intercepted! {dwAspectRatioMode}");
    }
}