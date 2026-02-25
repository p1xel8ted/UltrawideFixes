// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusterVisualisation
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ClusterVisualisation(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kPlaneLeftTopNdc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPlaneSizeNdc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDepthMinNdc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDepthMaxNdc;
  private static readonly System.IntPtr NativeFieldInfoPtr_clusterCount3D;
  private static readonly System.IntPtr NativeFieldInfoPtr_practicalNearVs;
  private static readonly System.IntPtr NativeFieldInfoPtr_clusterCoords;
  private static readonly System.IntPtr NativeFieldInfoPtr__planes;
  private static readonly System.IntPtr NativeFieldInfoPtr__sb;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawClusterFace_Private_Static_Void_Plane_byref_Matrix4x4_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCluster_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCluster_Private_Static_Void_ClusterAabb_byref_Matrix4x4_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawGrid_Private_Static_Void_GridInfo_byref_Matrix4x4_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneViewCamera_Private_Static_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcClusterNearFarDistancesVs_Private_Static_Vector2_GridInfo_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcClusterNearFarDistancesNdc_Private_Static_Vector2_GridInfo_Int32_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReconstructPositionVs_Private_Static_Vector3_Vector2_Single_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitClusterPlanes_Private_Static_Void_Vector3Int_GridInfo_byref_Matrix4x4_Il2CppStructArray_1_Plane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeClusterAabbWSV2_Private_Static_ClusterAabb_GridInfo_Vector3Int_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToAabbSquared_Private_Static_Single_Vector3_ClusterAabb_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToAabbSquared_Private_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesConeIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesLineSegmentIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesSphereIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesSphereIntersectNegativeHalfspace_Private_Static_Boolean_Plane_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsConeInsideFrutum_Private_Static_Boolean_Il2CppStructArray_1_Plane_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLineInsideFrustum_Private_Static_Boolean_Il2CppStructArray_1_Plane_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsSphereInsideFrustum_Private_Static_Boolean_Vector3_Single_Il2CppStructArray_1_Plane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TestPointLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TestSpotLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TestLineLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeClusterBoundsVs_Private_Static_ClusterBoundsVs_GridInfo_Vector3Int_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLineLightsInsideCluster_Private_Static_Boolean_Il2CppStructArray_1_Plane_ClusterBoundsVs_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsSpotlightInsideCluster_Private_Static_Boolean_Il2CppStructArray_1_Plane_ClusterBoundsVs_Vector3_Vector3_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPointLightInsideCluster_Private_Static_Boolean_ClusterBoundsVs_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TestDepthVsToClusterCoords_Private_Static_Void_StringBuilder_GridInfo_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TestDepthVsToClusterCoordsUniform_Private_Static_Void_StringBuilder_GridInfo_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Plane_Vector3_Vector3_byref___c__DisplayClass16_0_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_PDM_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Int32_byref___c__DisplayClass32_0_PDM_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_Int32_byref___c__DisplayClass32_0_PDM_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_Plane_byref___c__DisplayClass41_0_PDM_0;

  static ClusterVisualisation()
  {
    Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusterVisualisation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr);
    ClusterVisualisation.NativeFieldInfoPtr_kPlaneLeftTopNdc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (kPlaneLeftTopNdc));
    ClusterVisualisation.NativeFieldInfoPtr_kPlaneSizeNdc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (kPlaneSizeNdc));
    ClusterVisualisation.NativeFieldInfoPtr_kDepthMinNdc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (kDepthMinNdc));
    ClusterVisualisation.NativeFieldInfoPtr_kDepthMaxNdc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (kDepthMaxNdc));
    ClusterVisualisation.NativeFieldInfoPtr_clusterCount3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (clusterCount3D));
    ClusterVisualisation.NativeFieldInfoPtr_practicalNearVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (practicalNearVs));
    ClusterVisualisation.NativeFieldInfoPtr_clusterCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (clusterCoords));
    ClusterVisualisation.NativeFieldInfoPtr__planes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (_planes));
    ClusterVisualisation.NativeFieldInfoPtr__sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (_sb));
    ClusterVisualisation.NativeMethodInfoPtr_DrawClusterFace_Private_Static_Void_Plane_byref_Matrix4x4_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663419 /*0x0600007B*/);
    ClusterVisualisation.NativeMethodInfoPtr_DrawCluster_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663420 /*0x0600007C*/);
    ClusterVisualisation.NativeMethodInfoPtr_DrawCluster_Private_Static_Void_ClusterAabb_byref_Matrix4x4_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663421 /*0x0600007D*/);
    ClusterVisualisation.NativeMethodInfoPtr_DrawGrid_Private_Static_Void_GridInfo_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663422 /*0x0600007E*/);
    ClusterVisualisation.NativeMethodInfoPtr_GetSceneViewCamera_Private_Static_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663423 /*0x0600007F*/);
    ClusterVisualisation.NativeMethodInfoPtr_CalcClusterNearFarDistancesVs_Private_Static_Vector2_GridInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663424 /*0x06000080*/);
    ClusterVisualisation.NativeMethodInfoPtr_CalcClusterNearFarDistancesNdc_Private_Static_Vector2_GridInfo_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663425 /*0x06000081*/);
    ClusterVisualisation.NativeMethodInfoPtr_ReconstructPositionVs_Private_Static_Vector3_Vector2_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663426 /*0x06000082*/);
    ClusterVisualisation.NativeMethodInfoPtr_InitClusterPlanes_Private_Static_Void_Vector3Int_GridInfo_byref_Matrix4x4_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663427 /*0x06000083*/);
    ClusterVisualisation.NativeMethodInfoPtr_MakeClusterAabbWSV2_Private_Static_ClusterAabb_GridInfo_Vector3Int_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663428 /*0x06000084*/);
    ClusterVisualisation.NativeMethodInfoPtr_DistanceToAabbSquared_Private_Static_Single_Vector3_ClusterAabb_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663429 /*0x06000085*/);
    ClusterVisualisation.NativeMethodInfoPtr_DistanceToAabbSquared_Private_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663430 /*0x06000086*/);
    ClusterVisualisation.NativeMethodInfoPtr_DoesConeIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663431 /*0x06000087*/);
    ClusterVisualisation.NativeMethodInfoPtr_DoesLineSegmentIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663432 /*0x06000088*/);
    ClusterVisualisation.NativeMethodInfoPtr_DoesSphereIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663433 /*0x06000089*/);
    ClusterVisualisation.NativeMethodInfoPtr_DoesSphereIntersectNegativeHalfspace_Private_Static_Boolean_Plane_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663434 /*0x0600008A*/);
    ClusterVisualisation.NativeMethodInfoPtr_IsConeInsideFrutum_Private_Static_Boolean_Il2CppStructArray_1_Plane_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663435 /*0x0600008B*/);
    ClusterVisualisation.NativeMethodInfoPtr_IsLineInsideFrustum_Private_Static_Boolean_Il2CppStructArray_1_Plane_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663436 /*0x0600008C*/);
    ClusterVisualisation.NativeMethodInfoPtr_IsSphereInsideFrustum_Private_Static_Boolean_Vector3_Single_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663437 /*0x0600008D*/);
    ClusterVisualisation.NativeMethodInfoPtr_TestPointLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663438 /*0x0600008E*/);
    ClusterVisualisation.NativeMethodInfoPtr_TestSpotLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663439 /*0x0600008F*/);
    ClusterVisualisation.NativeMethodInfoPtr_TestLineLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663440 /*0x06000090*/);
    ClusterVisualisation.NativeMethodInfoPtr_MakeClusterBoundsVs_Private_Static_ClusterBoundsVs_GridInfo_Vector3Int_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663441 /*0x06000091*/);
    ClusterVisualisation.NativeMethodInfoPtr_IsLineLightsInsideCluster_Private_Static_Boolean_Il2CppStructArray_1_Plane_ClusterBoundsVs_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663442 /*0x06000092*/);
    ClusterVisualisation.NativeMethodInfoPtr_IsSpotlightInsideCluster_Private_Static_Boolean_Il2CppStructArray_1_Plane_ClusterBoundsVs_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663443 /*0x06000093*/);
    ClusterVisualisation.NativeMethodInfoPtr_IsPointLightInsideCluster_Private_Static_Boolean_ClusterBoundsVs_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663444 /*0x06000094*/);
    ClusterVisualisation.NativeMethodInfoPtr_TestDepthVsToClusterCoords_Private_Static_Void_StringBuilder_GridInfo_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663445 /*0x06000095*/);
    ClusterVisualisation.NativeMethodInfoPtr_TestDepthVsToClusterCoordsUniform_Private_Static_Void_StringBuilder_GridInfo_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663446 /*0x06000096*/);
    ClusterVisualisation.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663447 /*0x06000097*/);
    ClusterVisualisation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663448 /*0x06000098*/);
    ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Plane_Vector3_Vector3_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663450 /*0x0600009A*/);
    ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663451 /*0x0600009B*/);
    ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Int32_byref___c__DisplayClass32_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663452 /*0x0600009C*/);
    ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_Int32_byref___c__DisplayClass32_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663453 /*0x0600009D*/);
    ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Plane_byref___c__DisplayClass41_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, 100663454 /*0x0600009E*/);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 924877, RefRangeEnd = 924883, XrefRangeStart = 924862, XrefRangeEnd = 924877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawClusterFace(
    ClusterVisualisation.Plane planeVs,
    [In] ref Matrix4x4 invViewMatrix,
    Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &planeVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref invViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DrawClusterFace_Private_Static_Void_Plane_byref_Matrix4x4_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 924892, RefRangeEnd = 924894, XrefRangeStart = 924883, XrefRangeEnd = 924892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCluster(
    Il2CppStructArray<ClusterVisualisation.Plane> planeListVs,
    [In] ref Matrix4x4 invViewMatrix,
    Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planeListVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref invViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DrawCluster_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924894, XrefRangeEnd = 924904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCluster(
    ClusterVisualisation.ClusterAabb aabbVs,
    [In] ref Matrix4x4 invViewMatrix,
    Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aabbVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref invViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DrawCluster_Private_Static_Void_ClusterAabb_byref_Matrix4x4_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924904, XrefRangeEnd = 924915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawGrid(
    ClusterVisualisation.GridInfo gridInfo,
    [In] ref Matrix4x4 invProjMatrix,
    [In] ref Matrix4x4 invViewMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref invViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DrawGrid_Private_Static_Void_GridInfo_byref_Matrix4x4_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924915, XrefRangeEnd = 924916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Camera GetSceneViewCamera()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_GetSceneViewCamera_Private_Static_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924916, XrefRangeEnd = 924918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 CalcClusterNearFarDistancesVs(
    ClusterVisualisation.GridInfo gridInfo,
    int depthSliceIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSliceIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_CalcClusterNearFarDistancesVs_Private_Static_Vector2_GridInfo_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924918, XrefRangeEnd = 924923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 CalcClusterNearFarDistancesNdc(
    ClusterVisualisation.GridInfo gridInfo,
    int depthSliceIndex,
    [In] ref Matrix4x4 projMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSliceIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_CalcClusterNearFarDistancesNdc_Private_Static_Vector2_GridInfo_Int32_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 924924, RefRangeEnd = 924934, XrefRangeStart = 924923, XrefRangeEnd = 924924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 ReconstructPositionVs(
    Vector2 uv,
    float depthVs,
    [In] ref Matrix4x4 invProjMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &uv;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depthVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_ReconstructPositionVs_Private_Static_Vector3_Vector2_Single_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 924945, RefRangeEnd = 924947, XrefRangeStart = 924934, XrefRangeEnd = 924945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitClusterPlanes(
    Vector3Int clusterCoords,
    ClusterVisualisation.GridInfo gridInfo,
    [In] ref Matrix4x4 invProjMatrix,
    Il2CppStructArray<ClusterVisualisation.Plane> planes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &clusterCoords;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planes);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_InitClusterPlanes_Private_Static_Void_Vector3Int_GridInfo_byref_Matrix4x4_Il2CppStructArray_1_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924956, RefRangeEnd = 924957, XrefRangeStart = 924947, XrefRangeEnd = 924956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ClusterVisualisation.ClusterAabb MakeClusterAabbWSV2(
    ClusterVisualisation.GridInfo gridInfo,
    Vector3Int clusterCoords,
    [In] ref Matrix4x4 invProjMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterCoords;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_MakeClusterAabbWSV2_Private_Static_ClusterAabb_GridInfo_Vector3Int_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ClusterVisualisation.ClusterAabb*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924957, XrefRangeEnd = 924961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float DistanceToAabbSquared(
    Vector3 pos,
    ClusterVisualisation.ClusterAabb aabb)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aabb;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DistanceToAabbSquared_Private_Static_Single_Vector3_ClusterAabb_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 924965, RefRangeEnd = 924967, XrefRangeStart = 924961, XrefRangeEnd = 924965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float DistanceToAabbSquared(Vector3 pos, Vector3 aabbMin, Vector3 aabbMax)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aabbMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aabbMax;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DistanceToAabbSquared_Private_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924971, RefRangeEnd = 924972, XrefRangeStart = 924967, XrefRangeEnd = 924971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoesConeIntersectAabb(
    ClusterVisualisation.ClusterAabb aabbVs,
    Vector3 originVs,
    Vector3 forwardVs,
    float lenghtVs,
    float tanOuterHalf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &aabbVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &originVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &forwardVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lenghtVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tanOuterHalf;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DoesConeIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924977, RefRangeEnd = 924978, XrefRangeStart = 924972, XrefRangeEnd = 924977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoesLineSegmentIntersectAabb(
    ClusterVisualisation.ClusterAabb aabbVs,
    Vector3 l0Vs,
    Vector3 fwdVs,
    float lineLengthVs,
    float radiusVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &aabbVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &l0Vs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fwdVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lineLengthVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DoesLineSegmentIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 924985, RefRangeEnd = 924987, XrefRangeStart = 924978, XrefRangeEnd = 924985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoesSphereIntersectAabb(
    ClusterVisualisation.ClusterAabb aabbVs,
    Vector3 originVs,
    float radiusVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aabbVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &originVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DoesSphereIntersectAabb_Private_Static_Boolean_ClusterAabb_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool DoesSphereIntersectNegativeHalfspace(
    ClusterVisualisation.Plane planeVs,
    Vector3 originVs,
    float radiusVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &planeVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &originVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_DoesSphereIntersectNegativeHalfspace_Private_Static_Boolean_Plane_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924997, RefRangeEnd = 924998, XrefRangeStart = 924987, XrefRangeEnd = 924997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsConeInsideFrutum(
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs,
    Vector3 originVs,
    Vector3 forwardVs,
    float lenghtVs,
    float baseRadiusVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &originVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &forwardVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lenghtVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &baseRadiusVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_IsConeInsideFrutum_Private_Static_Boolean_Il2CppStructArray_1_Plane_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924998, XrefRangeEnd = 925002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsLineInsideFrustum(
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs,
    Vector3 l0Vs,
    Vector3 l1Vs,
    float radiusVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &l0Vs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &l1Vs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_IsLineInsideFrustum_Private_Static_Boolean_Il2CppStructArray_1_Plane_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925002, XrefRangeEnd = 925005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsSphereInsideFrustum(
    Vector3 originVs,
    float radiusVs,
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &originVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_IsSphereInsideFrustum_Private_Static_Boolean_Vector3_Single_Il2CppStructArray_1_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925040, RefRangeEnd = 925041, XrefRangeStart = 925005, XrefRangeEnd = 925040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int TestPointLight(
    ClusterVisualisation.GridInfo gridInfo,
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs,
    ClusterVisualisation.ClusterAabb aabbVs,
    ClusterVisualisation.ClusterBoundsVs clusterBoundsVs,
    [In] ref Matrix4x4 viewMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aabbVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterBoundsVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_TestPointLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925041, XrefRangeEnd = 925080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int TestSpotLight(
    ClusterVisualisation.GridInfo gridInfo,
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs,
    ClusterVisualisation.ClusterAabb aabbVs,
    ClusterVisualisation.ClusterBoundsVs clusterBoundsVs,
    [In] ref Matrix4x4 viewMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aabbVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterBoundsVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_TestSpotLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925080, XrefRangeEnd = 925128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int TestLineLight(
    ClusterVisualisation.GridInfo gridInfo,
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs,
    ClusterVisualisation.ClusterAabb aabbVs,
    ClusterVisualisation.ClusterBoundsVs clusterBoundsVs,
    [In] ref Matrix4x4 viewMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aabbVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterBoundsVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_TestLineLight_Private_Static_Int32_GridInfo_Il2CppStructArray_1_Plane_ClusterAabb_ClusterBoundsVs_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925149, RefRangeEnd = 925150, XrefRangeStart = 925128, XrefRangeEnd = 925149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ClusterVisualisation.ClusterBoundsVs MakeClusterBoundsVs(
    ClusterVisualisation.GridInfo gridInfo,
    Vector3Int clusterCoords,
    [In] ref Matrix4x4 invProjMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterCoords;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_MakeClusterBoundsVs_Private_Static_ClusterBoundsVs_GridInfo_Vector3Int_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ClusterVisualisation.ClusterBoundsVs*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925155, RefRangeEnd = 925156, XrefRangeStart = 925150, XrefRangeEnd = 925155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsLineLightsInsideCluster(
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs,
    ClusterVisualisation.ClusterBoundsVs clusterBoundsVs,
    Vector3 l0Vs,
    Vector3 fwdVs,
    float lineLengthVs,
    float radiusVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterBoundsVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &l0Vs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fwdVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lineLengthVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_IsLineLightsInsideCluster_Private_Static_Boolean_Il2CppStructArray_1_Plane_ClusterBoundsVs_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925175, RefRangeEnd = 925176, XrefRangeStart = 925156, XrefRangeEnd = 925175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsSpotlightInsideCluster(
    Il2CppStructArray<ClusterVisualisation.Plane> planesVs,
    ClusterVisualisation.ClusterBoundsVs clusterBoundsVs,
    Vector3 originVs,
    Vector3 forwardVs,
    float lenghtVs,
    float baseRadiusVs,
    float tanOuterHalf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planesVs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterBoundsVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &originVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forwardVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lenghtVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &baseRadiusVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tanOuterHalf;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_IsSpotlightInsideCluster_Private_Static_Boolean_Il2CppStructArray_1_Plane_ClusterBoundsVs_Vector3_Vector3_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925180, RefRangeEnd = 925181, XrefRangeStart = 925176, XrefRangeEnd = 925180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsPointLightInsideCluster(
    ClusterVisualisation.ClusterBoundsVs clusterBoundsVs,
    Vector3 centerVs,
    float radiusVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &clusterBoundsVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &centerVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_IsPointLightInsideCluster_Private_Static_Boolean_ClusterBoundsVs_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925181, XrefRangeEnd = 925227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TestDepthVsToClusterCoords(
    StringBuilder sb,
    ClusterVisualisation.GridInfo gridInfo,
    [In] ref Matrix4x4 viewMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_TestDepthVsToClusterCoords_Private_Static_Void_StringBuilder_GridInfo_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925259, RefRangeEnd = 925260, XrefRangeStart = 925227, XrefRangeEnd = 925259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TestDepthVsToClusterCoordsUniform(
    StringBuilder sb,
    ClusterVisualisation.GridInfo gridInfo,
    [In] ref Matrix4x4 viewMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gridInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_TestDepthVsToClusterCoordsUniform_Private_Static_Void_StringBuilder_GridInfo_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925260, XrefRangeEnd = 925299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925299, XrefRangeEnd = 925307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClusterVisualisation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 925310, RefRangeEnd = 925314, XrefRangeStart = 925307, XrefRangeEnd = 925310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ClusterVisualisation.Plane Method_Internal_Static_Plane_Vector3_Vector3_byref___c__DisplayClass16_0_0(
    Vector3 aVs,
    Vector3 bVs,
    ref ClusterVisualisation.__c__DisplayClass16_0 _param2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Plane_Vector3_Vector3_byref___c__DisplayClass16_0_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ClusterVisualisation.Plane*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925314, XrefRangeEnd = 925317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Method_Internal_Static_Vector3_Vector3_Vector3_PDM_0(
    Vector3 aVs,
    Vector3 bVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bVs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925317, XrefRangeEnd = 925319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Method_Internal_Static_Single_Vector3_Int32_byref___c__DisplayClass32_0_PDM_0(
    Vector3 normal,
    int index,
    ref ClusterVisualisation.__c__DisplayClass32_0 _param2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &normal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Int32_byref___c__DisplayClass32_0_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925319, XrefRangeEnd = 925321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Method_Internal_Static_Single_Single_Single_Int32_byref___c__DisplayClass32_0_PDM_0(
    float normalZSign,
    float planeDistanceVs,
    int index,
    ref ClusterVisualisation.__c__DisplayClass32_0 _param3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &normalZSign;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &planeDistanceVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_Int32_byref___c__DisplayClass32_0_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925321, XrefRangeEnd = 925322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Method_Internal_Static_Vector3_Plane_byref___c__DisplayClass41_0_PDM_0(
    ClusterVisualisation.Plane plane,
    ref ClusterVisualisation.__c__DisplayClass41_0 _param1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &plane;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Plane_byref___c__DisplayClass41_0_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Vector2 kPlaneLeftTopNdc
  {
    get
    {
      Vector2 kPlaneLeftTopNdc;
      IL2CPP.il2cpp_field_static_get_value(ClusterVisualisation.NativeFieldInfoPtr_kPlaneLeftTopNdc, (void*) &kPlaneLeftTopNdc);
      return kPlaneLeftTopNdc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusterVisualisation.NativeFieldInfoPtr_kPlaneLeftTopNdc, (void*) &value);
    }
  }

  public static unsafe Vector2 kPlaneSizeNdc
  {
    get
    {
      Vector2 kPlaneSizeNdc;
      IL2CPP.il2cpp_field_static_get_value(ClusterVisualisation.NativeFieldInfoPtr_kPlaneSizeNdc, (void*) &kPlaneSizeNdc);
      return kPlaneSizeNdc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusterVisualisation.NativeFieldInfoPtr_kPlaneSizeNdc, (void*) &value);
    }
  }

  public static unsafe float kDepthMinNdc
  {
    get
    {
      float kDepthMinNdc;
      IL2CPP.il2cpp_field_static_get_value(ClusterVisualisation.NativeFieldInfoPtr_kDepthMinNdc, (void*) &kDepthMinNdc);
      return kDepthMinNdc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusterVisualisation.NativeFieldInfoPtr_kDepthMinNdc, (void*) &value);
    }
  }

  public static unsafe float kDepthMaxNdc
  {
    get
    {
      float kDepthMaxNdc;
      IL2CPP.il2cpp_field_static_get_value(ClusterVisualisation.NativeFieldInfoPtr_kDepthMaxNdc, (void*) &kDepthMaxNdc);
      return kDepthMaxNdc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusterVisualisation.NativeFieldInfoPtr_kDepthMaxNdc, (void*) &value);
    }
  }

  public unsafe Vector3Int clusterCount3D
  {
    get
    {
      return *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr_clusterCount3D));
    }
    [param: In] set
    {
      *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr_clusterCount3D)) = value;
    }
  }

  public unsafe float practicalNearVs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr_practicalNearVs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr_practicalNearVs)) = value;
    }
  }

  public unsafe Vector3Int clusterCoords
  {
    get
    {
      return *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr_clusterCoords));
    }
    [param: In] set
    {
      *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr_clusterCoords)) = value;
    }
  }

  public unsafe Il2CppStructArray<ClusterVisualisation.Plane> _planes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr__planes));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<ClusterVisualisation.Plane>) null : Il2CppObjectPool.Get<Il2CppStructArray<ClusterVisualisation.Plane>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr__planes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder _sb
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr__sb));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusterVisualisation.NativeFieldInfoPtr__sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GridInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_clusterdCount3D;
    private static readonly System.IntPtr NativeFieldInfoPtr_nearWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_practicalNearWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_farWs;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Single_Single_Single_0;
    [FieldOffset(0)]
    public readonly Vector3Int clusterdCount3D;
    [FieldOffset(12)]
    public readonly float nearWs;
    [FieldOffset(16 /*0x10*/)]
    public readonly float practicalNearWs;
    [FieldOffset(20)]
    public readonly float farWs;

    static GridInfo()
    {
      Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (GridInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr);
      ClusterVisualisation.GridInfo.NativeFieldInfoPtr_clusterdCount3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr, nameof (clusterdCount3D));
      ClusterVisualisation.GridInfo.NativeFieldInfoPtr_nearWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr, nameof (nearWs));
      ClusterVisualisation.GridInfo.NativeFieldInfoPtr_practicalNearWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr, nameof (practicalNearWs));
      ClusterVisualisation.GridInfo.NativeFieldInfoPtr_farWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr, nameof (farWs));
      ClusterVisualisation.GridInfo.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr, 100663455 /*0x0600009F*/);
    }

    [CallerCount(0)]
    public unsafe GridInfo(
      Vector3Int clusterdCount3D,
      float nearWs,
      float practicalNearWs,
      float farWs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &clusterdCount3D;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nearWs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &practicalNearWs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &farWs;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.GridInfo.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusterVisualisation.GridInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ClusterAabb
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_min;
    private static readonly System.IntPtr NativeFieldInfoPtr_max;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCenter_Public_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSize_Public_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoesContain_Public_Boolean_Vector3_0;
    [FieldOffset(0)]
    public Vector3 min;
    [FieldOffset(12)]
    public Vector3 max;

    static ClusterAabb()
    {
      Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (ClusterAabb));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr);
      ClusterVisualisation.ClusterAabb.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr, nameof (min));
      ClusterVisualisation.ClusterAabb.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr, nameof (max));
      ClusterVisualisation.ClusterAabb.NativeMethodInfoPtr_GetCenter_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr, 100663456 /*0x060000A0*/);
      ClusterVisualisation.ClusterAabb.NativeMethodInfoPtr_GetSize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr, 100663457 /*0x060000A1*/);
      ClusterVisualisation.ClusterAabb.NativeMethodInfoPtr_DoesContain_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr, 100663458 /*0x060000A2*/);
    }

    [CallerCount(0)]
    public unsafe Vector3 GetCenter()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.ClusterAabb.NativeMethodInfoPtr_GetCenter_Public_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 924846, RefRangeEnd = 924848, XrefRangeStart = 924843, XrefRangeEnd = 924846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetSize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.ClusterAabb.NativeMethodInfoPtr_GetSize_Public_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924848, XrefRangeEnd = 924850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DoesContain(Vector3 p)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &p
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.ClusterAabb.NativeMethodInfoPtr_DoesContain_Public_Boolean_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusterVisualisation.ClusterAabb>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Plane
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_a;
    private static readonly System.IntPtr NativeFieldInfoPtr_b;
    private static readonly System.IntPtr NativeFieldInfoPtr_c;
    private static readonly System.IntPtr NativeFieldInfoPtr_d;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public Vector3 normal;
    [FieldOffset(12)]
    public float distance;
    [FieldOffset(16 /*0x10*/)]
    public Vector3 a;
    [FieldOffset(28)]
    public Vector3 b;
    [FieldOffset(40)]
    public Vector3 c;
    [FieldOffset(52)]
    public Vector3 d;

    static Plane()
    {
      Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (Plane));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr);
      ClusterVisualisation.Plane.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, nameof (normal));
      ClusterVisualisation.Plane.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, nameof (distance));
      ClusterVisualisation.Plane.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, nameof (a));
      ClusterVisualisation.Plane.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, nameof (b));
      ClusterVisualisation.Plane.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, nameof (c));
      ClusterVisualisation.Plane.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, nameof (d));
      ClusterVisualisation.Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, 100663459 /*0x060000A3*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924850, XrefRangeEnd = 924858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusterVisualisation.Plane>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ClusterBoundsVs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_nLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_nRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_nTop;
    private static readonly System.IntPtr NativeFieldInfoPtr_nBottom;
    private static readonly System.IntPtr NativeFieldInfoPtr_nearDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_farDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_aabbMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_aabbMax;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAabbCenter_Public_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExtents_Public_Vector3_0;
    [FieldOffset(0)]
    public Vector3 nLeft;
    [FieldOffset(12)]
    public Vector3 nRight;
    [FieldOffset(24)]
    public Vector3 nTop;
    [FieldOffset(36)]
    public Vector3 nBottom;
    [FieldOffset(48 /*0x30*/)]
    public float nearDistance;
    [FieldOffset(52)]
    public float farDistance;
    [FieldOffset(56)]
    public Vector3 aabbMin;
    [FieldOffset(68)]
    public Vector3 aabbMax;

    static ClusterBoundsVs()
    {
      Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, nameof (ClusterBoundsVs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr);
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_nLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (nLeft));
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_nRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (nRight));
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_nTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (nTop));
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_nBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (nBottom));
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_nearDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (nearDistance));
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_farDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (farDistance));
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_aabbMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (aabbMin));
      ClusterVisualisation.ClusterBoundsVs.NativeFieldInfoPtr_aabbMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, nameof (aabbMax));
      ClusterVisualisation.ClusterBoundsVs.NativeMethodInfoPtr_GetAabbCenter_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, 100663460 /*0x060000A4*/);
      ClusterVisualisation.ClusterBoundsVs.NativeMethodInfoPtr_GetExtents_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, 100663461 /*0x060000A5*/);
    }

    [CallerCount(0)]
    public unsafe Vector3 GetAabbCenter()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.ClusterBoundsVs.NativeMethodInfoPtr_GetAabbCenter_Public_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 924861, RefRangeEnd = 924862, XrefRangeStart = 924858, XrefRangeEnd = 924861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetExtents()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusterVisualisation.ClusterBoundsVs.NativeMethodInfoPtr_GetExtents_Public_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusterVisualisation.ClusterBoundsVs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("SadCatStudios.Rendering.ClusterVisualisation+<>c__DisplayClass16_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass16_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_nearFarVs;
    [FieldOffset(0)]
    public Vector2 nearFarVs;

    static __c__DisplayClass16_0()
    {
      Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, "<>c__DisplayClass16_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass16_0>.NativeClassPtr);
      ClusterVisualisation.__c__DisplayClass16_0.NativeFieldInfoPtr_nearFarVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass16_0>.NativeClassPtr, nameof (nearFarVs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass16_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("SadCatStudios.Rendering.ClusterVisualisation+<>c__DisplayClass32_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass32_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_originVs;
    private static readonly System.IntPtr NativeFieldInfoPtr_forwardVs;
    private static readonly System.IntPtr NativeFieldInfoPtr_lenghtVs;
    private static readonly System.IntPtr NativeFieldInfoPtr_baseRadiusVs;
    [FieldOffset(0)]
    public Vector3 originVs;
    [FieldOffset(12)]
    public Vector3 forwardVs;
    [FieldOffset(24)]
    public float lenghtVs;
    [FieldOffset(28)]
    public float baseRadiusVs;

    static __c__DisplayClass32_0()
    {
      Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, "<>c__DisplayClass32_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass32_0>.NativeClassPtr);
      ClusterVisualisation.__c__DisplayClass32_0.NativeFieldInfoPtr_originVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass32_0>.NativeClassPtr, nameof (originVs));
      ClusterVisualisation.__c__DisplayClass32_0.NativeFieldInfoPtr_forwardVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass32_0>.NativeClassPtr, nameof (forwardVs));
      ClusterVisualisation.__c__DisplayClass32_0.NativeFieldInfoPtr_lenghtVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass32_0>.NativeClassPtr, nameof (lenghtVs));
      ClusterVisualisation.__c__DisplayClass32_0.NativeFieldInfoPtr_baseRadiusVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass32_0>.NativeClassPtr, nameof (baseRadiusVs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass32_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("SadCatStudios.Rendering.ClusterVisualisation+<>c__DisplayClass41_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass41_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_invViewMatrix;
    [FieldOffset(0)]
    public Matrix4x4 invViewMatrix;

    static __c__DisplayClass41_0()
    {
      Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusterVisualisation>.NativeClassPtr, "<>c__DisplayClass41_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass41_0>.NativeClassPtr);
      ClusterVisualisation.__c__DisplayClass41_0.NativeFieldInfoPtr_invViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass41_0>.NativeClassPtr, nameof (invViewMatrix));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusterVisualisation.__c__DisplayClass41_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
