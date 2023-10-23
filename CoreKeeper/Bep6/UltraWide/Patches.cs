using HarmonyLib;
using PugRP;
using PugTilemap;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace UltraWide;

[HarmonyPatch]
public static class Patches
{
    // public static int XSize = 18;
    // public static int ZSize = 12;
    //     
    // private static int newMinX;
    // private static int newMaxX;
    // private static int newMinZ;
    // private static int newMaxZ;
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ShaderTexturesSystem), nameof(ShaderTexturesSystem.OnUpdate))]
    public static bool ShaderTexturesSystem_OnUpdate(ref ShaderTexturesSystem __instance)
    {
        if (Manager.sceneHandler.isInGame)
        {

            Vector3Int renderOrigo = Manager.camera.RenderOrigo;
            int num = renderOrigo.x;
            int num2 = renderOrigo.x;
            int num3 = renderOrigo.z;
            int num4 = renderOrigo.z;
            NativeArray<Color32> rawTextureData = __instance.finalizeSystem.electricityTex.GetRawTextureData<Color32>();
            NativeArray<Color32> rawTextureData2 = __instance.finalizeSystem.ignoreVertexOffsetTex.GetRawTextureData<Color32>();
            BlobAssetReference<PugDatabase.PugDatabaseBank> blobAssetReference = __instance.database;
            int num5 = 36;
            //red
            Color32 color = __instance.black;
            __instance.ShaderTexturesSystem_LambdaJob_4_Execute(num, num2, num3, num4, rawTextureData2, color);
            __instance.ShaderTexturesSystem_LambdaJob_0_Execute(num, num2, num3, num4, rawTextureData2, blobAssetReference, num5);
             __instance.ShaderTexturesSystem_LambdaJob_5_Execute(num, num2, num3, num4, rawTextureData, color);
            __instance.ShaderTexturesSystem_LambdaJob_1_Execute(num, num2, num3, num4, rawTextureData, num5);
            __instance.ShaderTexturesSystem_LambdaJob_2_Execute(num, num2, num3, num4, rawTextureData, num5);
            NativeArray<bool> nativeArray = CollectionHelper.CreateNativeArray<bool>(1, __instance.World.UpdateAllocator.Handle, NativeArrayOptions.ClearMemory);
            nativeArray[0] = true;
            __instance.ShaderTexturesSystem_LambdaJob_3_Execute(nativeArray);
            int2 origo = Manager.multiMap.Origo;
            NativeParallelMultiHashMap<int2, TileInfo> tileLookup = Manager.multiMap.tileLookup;
            NativeArray<int> surfacePriorityLookup = TileTypeUtility.GetSurfacePriorityLookup(__instance.World.UpdateAllocator.Handle);
            __instance.ShaderTexturesSystem_LambdaJob_6_Execute(renderOrigo, num, num2, num3, num4, rawTextureData2, blobAssetReference, nativeArray, origo, tileLookup, surfacePriorityLookup);
            return false;
        }

        return true;
    }
    
    [HarmonyPrefix]  
    [HarmonyPatch(typeof(LoadingScene), nameof(LoadingScene.Awake))]
    public static bool LoadingScene_Start(ref LoadingScene __instance)
    {
        Manager.InitializeGlobalManager();
        Manager.load.LoadSceneImmediately(new LoadManager.LoadingQueueEntry("Title", 0f, 0f, FadePresets.blackToBlack, 0),false);
        return false;
    }
}