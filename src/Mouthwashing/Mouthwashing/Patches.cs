using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Object = UnityEngine.Object;

namespace Mouthwashing;

[Harmony]
public static class Patches
{
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenHandler), nameof(ScreenHandler.Apply))]
    public static bool ScreenHandler_Apply(ScreenHandler __instance)
    {
        __instance.screenRenderer.sharedMaterial = __instance.GetMaterial();
        Plugin.Log.LogWarning($"ScreenHandler.Apply: {  __instance.screenRenderer.sharedMaterial.mainTexture.name}");
        MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
        materialPropertyBlock.SetFloat("_Aspect_Ratio", __instance.aspectRatio);
        __instance.screenRenderer.SetPropertyBlock(materialPropertyBlock);
        __instance.lightMesh.enabled = __instance.isOn;
        __instance.lightMesh.color = __instance.GetLightColor();
        
        ILevelBakeReciever.SetDirty(__instance.screenRenderer);
        ILevelBakeReciever.SetDirty(__instance.lightMesh);
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenHandler), nameof(ScreenHandler.GetMaterial))]
    public static void ScreenHandler_GetMaterial(ScreenHandler __instance)
    {
        Plugin.Log.LogWarning("ScreenHandler.GetMaterial");
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.Awake))]
    public static void ScreenHandler_Awake(SwanseaMonologuePlayer __instance)
    {
        Plugin.Log.LogWarning("SwanseaMonologuePlayer.Awake");
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.AlignCamera))]
    public static void ScreenHandler_AlignCamera(SwanseaMonologuePlayer __instance)
    {
        Plugin.Log.LogWarning("SwanseaMonologuePlayer.AlignCamera");
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.OnEnable))]
    public static void OnEnable(SwanseaMonologuePlayer __instance)
    {
        Plugin.Log.LogWarning("SwanseaMonologuePlayer.OnEnable");
    }

    
    //	private void SetBackground(VideoClip clip, Color tint, bool isFlipped)
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.SetBackground), typeof(VideoClip), typeof(Color), typeof(bool))]
    public static void ScreenHandler_SetBackground(SwanseaMonologuePlayer __instance, VideoClip clip, Color tint, bool isFlipped)
    {
        Plugin.Log.LogWarning("SwanseaMonologuePlayer.SetBackground");
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OverlayVideoHandler), nameof(OverlayVideoHandler.Awake))]
    public static void ScreenHandler_Awake(OverlayVideoHandler __instance)
    {
        Plugin.Log.LogWarning("OverlayVideoHandler.Awake");
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(OverlayVideoHandler), nameof(OverlayVideoHandler.PlayOverlayVideoRoutine))]
    public static void OverlayVideoHandler_PlayOverlayVideoRoutine(OverlayVideoHandler __instance)
    {
        __instance.overlayVideoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
        
       Plugin.Log.LogWarning("OverlayVideoHandler.PlayOverlayVideoRoutine");
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(RoomCullingManager), nameof(RoomCullingManager.SetRenderersState))]
    public static void RoomCullingManager_SetRenderersState(RoomCullingManager __instance, ref bool _state)
    {
        _state = true;
        
        Plugin.Log.LogWarning("RoomCullingManager.SetRenderersState");
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(RenderTextureBlitterFeature), nameof(RenderTextureBlitterFeature.Create))]
    public static void RenderTextureBlitterFeature_Create(ref RenderTextureBlitterFeature __instance)
    {
        Plugin.Log.LogWarning("RenderTextureBlitterFeature.Create");
        
        // Ensure the destinationTexture is valid and exists
        if (__instance.destinationTexture != null)
        {
            // Get the current descriptor of the existing RenderTexture
            var descriptor = __instance.destinationTexture.descriptor;

            // Define the desired aspect ratio (21:9 in this case)
            float targetAspectRatio = Plugin.MainDisplayAspectRatio;

            // Modify the width based on the current height and the new aspect ratio
            int newWidth = Mathf.RoundToInt(descriptor.height * targetAspectRatio);

            // Check if the existing texture's width is different before resizing
            if (descriptor.width != newWidth)
            {
                Debug.Log($"[Harmony] Resizing RenderTexture from {descriptor.width}x{descriptor.height} to {newWidth}x{descriptor.height} (21:9 aspect)");

                // Update the descriptor's width to match the new aspect ratio
                descriptor.width = newWidth;

                // Reassign the modified descriptor to the existing RenderTexture
                __instance.destinationTexture.Release();  // Release the old texture
                __instance.destinationTexture.descriptor = descriptor;  // Apply the updated descriptor
                __instance.destinationTexture.Create();  // Recreate the RenderTexture with the new size

                Debug.Log($"[Harmony] Successfully resized RenderTexture to {newWidth}x{descriptor.height}");
            }
        }
    }
    
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(GameManager), nameof(GameManager.ScreenAspect), MethodType.Getter)]
    // public static void GameManager_ScreenAspect(ref float __result)
    // {
    //     __result = Plugin.MainDisplayAspectRatio;
    // }
    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(GameManager), nameof(GameManager.ScreenSize), MethodType.Getter)]
    // public static void GameManager_ScreenSize(ref Vector2 __result)
    // {
    //     __result = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
    // }
    //
    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(GameManager), nameof(GameManager.ScreenSizePixelated), MethodType.Getter)]
    // public static void GameManager_ScreenAspect(ref Vector2 __result)
    // {
    //     __result = new Vector2(__result.y * Plugin.MainDisplayAspectRatio, __result.y);
    // }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    // public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    // {
    //     __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    // }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    // public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    // {
    //     __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
    //     if (__instance.name.Equals("Metal Doors"))
    //     {
    //         MetalDoors.Add(__instance.gameObject);
    //         __instance.gameObject.SetActive(Plugin.MenuMetalDoors.Value);
    //     }
    // }
}