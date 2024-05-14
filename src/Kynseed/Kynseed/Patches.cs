using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoProtoFramework;

namespace Kynseed;

[Harmony]
public static class Patches
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsDeviceManager), nameof(GraphicsDeviceManager.Initialize))]
    [HarmonyPatch(typeof(GraphicsDeviceManager), nameof(GraphicsDeviceManager.OnDeviceCreated))]
    public static void GraphicsDeviceManager_Initialize(GraphicsDeviceManager __instance)
    {

        if (__instance.GraphicsDevice == null) return;
        
        GraphicsDeviceManager.DefaultBackBufferWidth = __instance.GraphicsDevice.Adapter.CurrentDisplayMode.Width;
        GraphicsDeviceManager.DefaultBackBufferHeight = __instance.GraphicsDevice.Adapter.CurrentDisplayMode.Height;
        Plugin.Logger.LogWarning($"GraphicsDeviceManager.OnDeviceCreated");
        __instance.PreferredBackBufferWidth = __instance.GraphicsDevice.Adapter.CurrentDisplayMode.Width;
        __instance.PreferredBackBufferHeight = __instance.GraphicsDevice.Adapter.CurrentDisplayMode.Height;
        __instance.GraphicsDevice.Viewport = new Viewport(0, 0, __instance.PreferredBackBufferWidth, __instance.PreferredBackBufferHeight);
        __instance.IsFullScreen = true;
        __instance.ApplyChanges();
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(GraphicsDevice), nameof(GraphicsDevice.Viewport), MethodType.Setter)]
    // public static void GraphicsDevice_Viewport_Setter(GraphicsDevice __instance, ref Viewport value)
    // {
    //     value = new Viewport(0, 0, 3440, 1440);
    // }
    //
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsDevice), nameof(GraphicsDevice.Viewport), MethodType.Getter)]
    public static void GraphicsDevice_Viewport_Getter(GraphicsDevice __instance, ref Viewport __result)
    {
        __result = new Viewport(0, 0, 3440, 1440);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsDeviceManager), nameof(GraphicsDeviceManager.PreferredBackBufferHeight), MethodType.Getter)]
    public static void GraphicsDeviceManager_PreferredBackBufferHeight(GraphicsDeviceManager __instance, ref int __result)
    {
        __result = 1440;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsDeviceManager), nameof(GraphicsDeviceManager.PreferredBackBufferWidth), MethodType.Getter)]
    public static void GraphicsDeviceManager_PreferredBackBufferWidth(GraphicsDeviceManager __instance, ref int __result)
    {
        __result = 3440;
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Camera2d), nameof(Camera2d.GetVisibleArea))]
    public static void Camera2d_GetVisibleArea(Camera2d __instance, ref Rectangle __result)
    {
        // Plugin.Logger.LogWarning("Camera2d.GetVisibleArea");
        __result = new Rectangle(0, 0, 3440, 1440);
    }
}