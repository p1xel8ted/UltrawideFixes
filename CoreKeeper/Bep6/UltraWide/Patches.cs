// using HarmonyLib;
//
// namespace UltraWide;
//
// [HarmonyPatch]
// public static class Patches
// {
    
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.UpdateOrigoTransforms))]
    // public static bool CameraManager_UpdateOrigoTransforms(ref CameraManager __instance, ref Vector3Int newRenderOrigo)
    // {
    //     
    //     foreach (Transform transform in __instance.origoTransformList)
    //     {
    //         transform.position -= newRenderOrigo - __instance.RenderOrigo;
    //     }
    //     if (__instance.OrigoTransform.localPosition.sqrMagnitude > 10)
    //     {
    //         int count = __instance.origoTransformList.Count;
    //         __instance.origoTransformList.Add(new GameObject("OrigoTransform").transform);
    //         __instance.origoTransformList[count].SetParent(__instance.transform);
    //         __instance.origoTransformList[count].localPosition = Vector3.zero;
    //     }
    //     for (int i = __instance.origoTransformList.Count - 2; i >= 0; i--)
    //     {
    //         if (__instance.origoTransformList[i].localPosition.sqrMagnitude > 90)
    //         {
    //             foreach (object obj in __instance.origoTransformList[i])
    //             {
    //                 ((Transform)obj).SetParent(__instance.OrigoTransform, true);
    //             }
    //         }
    //     }
    //     for (int j = __instance.origoTransformList.Count - 2; j >= 0; j--)
    //     {
    //         if (__instance.origoTransformList[j].childCount == 0)
    //         {
    //             UnityEngine.Object.Destroy(__instance.origoTransformList[j].gameObject);
    //             __instance.origoTransformList.RemoveAt(j);
    //         }
    //     }
    //
    //     return false;
    // }
    
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Init))]
    // public static void CameraManager_Init(ref CameraManager __instance)
    // {
    //     Plugin.Log.LogWarning($"CameraManager.Awake {__instance}");
    //     __instance.backgroundCameraRenderRate = 120;
    // }
    //
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(SinglePugMap), nameof(SinglePugMap.Clear))]
    // [HarmonyPatch(typeof(SinglePugMap), nameof(SinglePugMap.ClearTileOfType))]
    // [HarmonyPatch(typeof(SinglePugMap), nameof(SinglePugMap.ClearHiddenTileOfTypeAndTileset))]
    // public static bool SinglePugMap_Clear(ref SinglePugMap __instance)
    // {
    //     return false;
    // }
    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.RenderOrigo), MethodType.Getter)]
    // public static void CameraManager_RenderOrigo_Get(ref CameraManager __instance, ref Vector3Int __result)
    // {
    //     if (__result != Vector3Int.zero)
    //     {
    //         __result.x += 20;
    //     }
    //    Plugin.Log.LogWarning($"CameraManager.RenderOrigo GET {__result}");
    //    Plugin.Log.LogWarning($"CameraManager backgroundCameraRenderRate {__instance.backgroundCameraRenderRate}");
    // }
    
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.RenderOrigo), MethodType.Setter)]
    // public static void CameraManager_RenderOrigo_Set(ref CameraManager __instance, ref Vector3Int value)
    // {
    //     if (value != Vector3Int.zero)
    //     {
    //         value.x += 10;
    //     }
    //     Plugin.Log.LogWarning($"CameraManager.RenderOrigo SET {value}");
    // }
    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.UpdateBackgroundCameras))]
    // public static void CameraManager_UpdateBackgroundCameras(ref CameraManager __instance)
    // {
    //     Plugin.Log.LogWarning($"CameraManager.UpdateBackgroundCameras");
    // }
// }