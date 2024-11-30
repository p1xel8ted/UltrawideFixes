using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Object = UnityEngine.Object;

namespace Mouthwashing;

[Harmony]
public static class Patches
{
//     
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(ScreenHandler), nameof(ScreenHandler.Apply))]
//     public static bool ScreenHandler_Apply(ScreenHandler __instance)
//     {
//         __instance.screenRenderer.sharedMaterial = __instance.GetMaterial();
//         Plugin.Log.LogWarning($"ScreenHandler.Apply: {  __instance.screenRenderer.sharedMaterial.mainTexture.name}");
//         MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
//         materialPropertyBlock.SetFloat("_Aspect_Ratio", __instance.aspectRatio);
//         __instance.screenRenderer.SetPropertyBlock(materialPropertyBlock);
//         __instance.lightMesh.enabled = __instance.isOn;
//         __instance.lightMesh.color = __instance.GetLightColor();
//         
//         ILevelBakeReciever.SetDirty(__instance.screenRenderer);
//         ILevelBakeReciever.SetDirty(__instance.lightMesh);
//         return false;
//     }
//     
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(ScreenHandler), nameof(ScreenHandler.GetMaterial))]
//     public static void ScreenHandler_GetMaterial(ScreenHandler __instance)
//     {
//         Plugin.Log.LogWarning("ScreenHandler.GetMaterial");
//     }
//     
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.Awake))]
//     public static void ScreenHandler_Awake(SwanseaMonologuePlayer __instance)
//     {
//         Plugin.Log.LogWarning("SwanseaMonologuePlayer.Awake");
//     }
//     
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.AlignCamera))]
//     public static void ScreenHandler_AlignCamera(SwanseaMonologuePlayer __instance)
//     {
//         Plugin.Log.LogWarning("SwanseaMonologuePlayer.AlignCamera");
//     }
//     
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.OnEnable))]
//     public static void OnEnable(SwanseaMonologuePlayer __instance)
//     {
//         Plugin.Log.LogWarning("SwanseaMonologuePlayer.OnEnable");
//     }
//
//     
//     //	private void SetBackground(VideoClip clip, Color tint, bool isFlipped)
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(SwanseaMonologuePlayer), nameof(SwanseaMonologuePlayer.SetBackground), typeof(VideoClip), typeof(Color), typeof(bool))]
//     public static void ScreenHandler_SetBackground(SwanseaMonologuePlayer __instance, VideoClip clip, Color tint, bool isFlipped)
//     {
//         Plugin.Log.LogWarning("SwanseaMonologuePlayer.SetBackground");
//     }
//     
//     
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(OverlayVideoHandler), nameof(OverlayVideoHandler.Awake))]
//     public static void ScreenHandler_Awake(OverlayVideoHandler __instance)
//     {
//         Plugin.Log.LogWarning("OverlayVideoHandler.Awake");
//     }
//     
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(OverlayVideoHandler), nameof(OverlayVideoHandler.PlayOverlayVideoRoutine))]
//     public static void OverlayVideoHandler_PlayOverlayVideoRoutine(OverlayVideoHandler __instance)
//     {
//         __instance.overlayVideoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
//         
//        Plugin.Log.LogWarning("OverlayVideoHandler.PlayOverlayVideoRoutine");
//     }
//     
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(RoomCullingManager), nameof(RoomCullingManager.SetRenderersState))]
//     public static void RoomCullingManager_SetRenderersState(RoomCullingManager __instance, ref bool _state)
//     {
//         _state = true;
//         
//         Plugin.Log.LogWarning("RoomCullingManager.SetRenderersState");
//     }
//     
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenHandler), nameof(ScreenHandler.Apply))]
    public static void ScreenHandler_Apply(ScreenHandler __instance)
    {
        __instance.screenRenderer.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
        Plugin.Log.LogWarning($"ScreenHandler.Apply: {__instance.screenRenderer.sharedMaterial.mainTexture.name}");
    }


    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(RenderTextureBlitterFeature), nameof(RenderTextureBlitterFeature.AddRenderPasses))]
    // public static void RenderTextureBlitterFeature_AddRenderPasses(ref RenderTextureBlitterFeature __instance, ref ScriptableRenderer renderer, ref RenderingData renderingData)
    // {
    //     Plugin.Log.LogWarning("RenderTextureBlitterFeature.AddRenderPasses");
    //     Plugin.Log.LogWarning("|------------- CAMERA -------------|");
    //     Plugin.Log.LogWarning($"{renderingData.cameraData.camera.aspect}");
    //     Plugin.Log.LogWarning($"{renderingData.cameraData.camera.pixelRect}");
    //     Plugin.Log.LogWarning($"{renderingData.cameraData.camera.rect}");
    //
    //     Plugin.Log.LogWarning("|------------- CAMERA DATA -------------|");
    //     Plugin.Log.LogWarning($"{renderingData.cameraData.aspectRatio}");
    //     Plugin.Log.LogWarning($"{renderingData.cameraData.pixelRect}");
    //
    //
    //     if (__instance.writeMaterial != null)
    //     {
    //         if (__instance.writeMaterial.mainTexture != null)
    //         {
    //             Plugin.Log.LogWarning("|------------- INSTANCE WRITE-MATERIAL MAIN-TEXTURE -------------|");
    //             Plugin.Log.LogWarning($"{__instance.writeMaterial.mainTexture.width}");
    //             Plugin.Log.LogWarning($"{__instance.writeMaterial.mainTexture.height}");
    //         }
    //     }
    //
    //     Plugin.Log.LogWarning("|------------- INSTANCE DESTINATION TEXTURE -------------|");
    //     if (__instance.destinationTexture != null)
    //     {
    //         Plugin.Log.LogWarning($"{__instance.destinationTexture.width}");
    //         Plugin.Log.LogWarning($"{__instance.destinationTexture.height}");
    //
    //         Plugin.Log.LogWarning("|------------- INSTANCE DESTINATION TEXTURE DESCRIPTOR -------------|");
    //         Plugin.Log.LogWarning($"{__instance.destinationTexture.descriptor.width}");
    //         Plugin.Log.LogWarning($"{__instance.destinationTexture.descriptor.height}");
    //     }
    //
    //     Plugin.Log.LogWarning("|-------------  CAMERA DATA TARGET DESCRIPTOR -------------|");
    //     Plugin.Log.LogWarning($"{renderingData.cameraData.cameraTargetDescriptor.width}");
    //     Plugin.Log.LogWarning($"{renderingData.cameraData.cameraTargetDescriptor.height}");
    //
    //
    //     if (renderingData.cameraData.targetTexture != null)
    //     {
    //         Plugin.Log.LogWarning("|-------------  CAMERA DATA TARGET TEXTURE -------------|");
    //         Plugin.Log.LogWarning($"{renderingData.cameraData.targetTexture.width}");
    //         Plugin.Log.LogWarning($"{renderingData.cameraData.targetTexture.height}");
    //
    //         Plugin.Log.LogWarning("|-------------  CAMERA DATA TARGET TEXTURE DESCRIPTOR -------------|");
    //         Plugin.Log.LogWarning($"{renderingData.cameraData.targetTexture.descriptor.width}");
    //         Plugin.Log.LogWarning($"{renderingData.cameraData.targetTexture.descriptor.height}");
    //     }
    //
    //
    //     if (renderingData.cameraData.baseCamera != null)
    //     {
    //         Plugin.Log.LogWarning("|------------- BASE CAMERA -------------|");
    //         Plugin.Log.LogWarning($"{renderingData.cameraData.baseCamera.aspect}");
    //         Plugin.Log.LogWarning($"{renderingData.cameraData.baseCamera.pixelRect}");
    //         Plugin.Log.LogWarning($"{renderingData.cameraData.baseCamera.rect}");
    //     }
    // }

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
            float targetAspectRatio = Plugin.MainAspect;

            // Modify the width based on the current height and the new aspect ratio
            int newWidth = Mathf.RoundToInt(descriptor.height * targetAspectRatio);

            // Check if the existing texture's width is different before resizing
            if (descriptor.width != newWidth)
            {
                Plugin.Log.LogWarning($"[Harmony] Resizing RenderTexture from {descriptor.width}x{descriptor.height} to {newWidth}x{descriptor.height} (21:9 aspect)");

                // Update the descriptor's width to match the new aspect ratio
                descriptor.width = newWidth;

                // Reassign the modified descriptor to the existing RenderTexture
                __instance.destinationTexture.Release(); // Release the old texture
                __instance.destinationTexture.descriptor = descriptor; // Apply the updated descriptor
                __instance.destinationTexture.Create(); // Recreate the RenderTexture with the new size

                Plugin.Log.LogWarning($"[Harmony] Successfully resized RenderTexture to {newWidth}x{descriptor.height}");
            }
        }
    }
}