// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CullingResults
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CullingResults
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocationInfo;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;
  [FieldOffset(0)]
  public System.IntPtr ptr;
  [FieldOffset(8)]
  public System.IntPtr m_AllocationInfo;
  private static readonly CullingResults.GetLightIndexCountDelegate GetLightIndexCountDelegateField;
  private static readonly CullingResults.GetReflectionProbeIndexCountDelegate GetReflectionProbeIndexCountDelegateField;
  private static readonly CullingResults.GetLightIndexMapSizeDelegate GetLightIndexMapSizeDelegateField;
  private static readonly CullingResults.GetReflectionProbeIndexMapSizeDelegate GetReflectionProbeIndexMapSizeDelegateField;
  private static readonly CullingResults.FillLightIndexMapDelegate FillLightIndexMapDelegateField;
  private static readonly CullingResults.FillReflectionProbeIndexMapDelegate FillReflectionProbeIndexMapDelegateField;
  private static readonly CullingResults.SetLightIndexMapDelegate SetLightIndexMapDelegateField;
  private static readonly CullingResults.SetReflectionProbeIndexMapDelegate SetReflectionProbeIndexMapDelegateField;
  private static readonly CullingResults.FillLightAndReflectionProbeIndices_InjectedDelegate FillLightAndReflectionProbeIndices_InjectedDelegateField;
  private static readonly CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegate FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegateField;

  static CullingResults()
  {
    Il2CppClassPointerStore<CullingResults>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (CullingResults));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingResults>.NativeClassPtr);
    CullingResults.NativeFieldInfoPtr_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, nameof (ptr));
    CullingResults.NativeFieldInfoPtr_m_AllocationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, nameof (m_AllocationInfo));
    CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670353);
    CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670354);
    CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670355);
    CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670356);
    CullingResults.NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670357);
    CullingResults.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670358);
    CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670359);
    CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670360);
    CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670361);
    CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670362);
    CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670363);
    CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670364);
    CullingResults.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670365);
    CullingResults.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670366);
    CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100670367);
    CullingResults.GetLightIndexCountDelegateField = IL2CPP.ResolveICall<CullingResults.GetLightIndexCountDelegate>("UnityEngine.Rendering.CullingResults::GetLightIndexCount");
    CullingResults.GetReflectionProbeIndexCountDelegateField = IL2CPP.ResolveICall<CullingResults.GetReflectionProbeIndexCountDelegate>("UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexCount");
    CullingResults.GetLightIndexMapSizeDelegateField = IL2CPP.ResolveICall<CullingResults.GetLightIndexMapSizeDelegate>("UnityEngine.Rendering.CullingResults::GetLightIndexMapSize");
    CullingResults.GetReflectionProbeIndexMapSizeDelegateField = IL2CPP.ResolveICall<CullingResults.GetReflectionProbeIndexMapSizeDelegate>("UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexMapSize");
    CullingResults.FillLightIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.FillLightIndexMapDelegate>("UnityEngine.Rendering.CullingResults::FillLightIndexMap");
    CullingResults.FillReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.FillReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::FillReflectionProbeIndexMap");
    CullingResults.SetLightIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.SetLightIndexMapDelegate>("UnityEngine.Rendering.CullingResults::SetLightIndexMap");
    CullingResults.SetReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.SetReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::SetReflectionProbeIndexMap");
    CullingResults.FillLightAndReflectionProbeIndices_InjectedDelegateField = IL2CPP.ResolveICall<CullingResults.FillLightAndReflectionProbeIndices_InjectedDelegate>("UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndices_Injected");
    CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndicesGraphicsBuffer_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487515, XrefRangeEnd = 487517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetShadowCasterBounds(
    System.IntPtr cullingResultsPtr,
    int lightIndex,
    out Bounds bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &cullingResultsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref bounds;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487517, XrefRangeEnd = 487519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ComputeSpotShadowMatricesAndCullingPrimitives(
    System.IntPtr cullingResultsPtr,
    int activeLightIndex,
    out Matrix4x4 viewMatrix,
    out Matrix4x4 projMatrix,
    out ShadowSplitData shadowSplitData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &cullingResultsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref shadowSplitData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487519, XrefRangeEnd = 487521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ComputePointShadowMatricesAndCullingPrimitives(
    System.IntPtr cullingResultsPtr,
    int activeLightIndex,
    CubemapFace cubemapFace,
    float fovBias,
    out Matrix4x4 viewMatrix,
    out Matrix4x4 projMatrix,
    out ShadowSplitData shadowSplitData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &cullingResultsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapFace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fovBias;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref shadowSplitData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487521, XrefRangeEnd = 487523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ComputeDirectionalShadowMatricesAndCullingPrimitives(
    System.IntPtr cullingResultsPtr,
    int activeLightIndex,
    int splitIndex,
    int splitCount,
    Vector3 splitRatio,
    int shadowResolution,
    float shadowNearPlaneOffset,
    out Matrix4x4 viewMatrix,
    out Matrix4x4 projMatrix,
    out ShadowSplitData shadowSplitData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[10];
    numPtr[0] = (System.IntPtr) &cullingResultsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &splitIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &splitCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &splitRatio;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowResolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowNearPlaneOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref shadowSplitData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe NativeArray<VisibleLight> visibleLights
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 487526, RefRangeEnd = 487528, XrefRangeStart = 487523, XrefRangeEnd = 487526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new NativeArray<VisibleLight>(pointer);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487530, RefRangeEnd = 487531, XrefRangeStart = 487528, XrefRangeEnd = 487530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> GetNativeArray<T>(void* dataPointer, int length) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) dataPointer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CullingResults.MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487533, RefRangeEnd = 487535, XrefRangeStart = 487531, XrefRangeEnd = 487533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBounds;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487537, RefRangeEnd = 487538, XrefRangeStart = 487535, XrefRangeEnd = 487537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ComputeSpotShadowMatricesAndCullingPrimitives(
    int activeLightIndex,
    out Matrix4x4 viewMatrix,
    out Matrix4x4 projMatrix,
    out ShadowSplitData shadowSplitData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &activeLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref shadowSplitData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487540, RefRangeEnd = 487541, XrefRangeStart = 487538, XrefRangeEnd = 487540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ComputePointShadowMatricesAndCullingPrimitives(
    int activeLightIndex,
    CubemapFace cubemapFace,
    float fovBias,
    out Matrix4x4 viewMatrix,
    out Matrix4x4 projMatrix,
    out ShadowSplitData shadowSplitData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &activeLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapFace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fovBias;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref shadowSplitData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487543, RefRangeEnd = 487544, XrefRangeStart = 487541, XrefRangeEnd = 487543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ComputeDirectionalShadowMatricesAndCullingPrimitives(
    int activeLightIndex,
    int splitIndex,
    int splitCount,
    Vector3 splitRatio,
    int shadowResolution,
    float shadowNearPlaneOffset,
    out Matrix4x4 viewMatrix,
    out Matrix4x4 projMatrix,
    out ShadowSplitData shadowSplitData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) &activeLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &splitIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &splitCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &splitRatio;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowResolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowNearPlaneOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref shadowSplitData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487544, XrefRangeEnd = 487547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(CullingResults other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487547, XrefRangeEnd = 487553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487553, XrefRangeEnd = 487554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487554, XrefRangeEnd = 487557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(CullingResults left, CullingResults right)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487557, XrefRangeEnd = 487559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(
    System.IntPtr cullingResultsPtr,
    int activeLightIndex,
    int splitIndex,
    int splitCount,
    [In] ref Vector3 splitRatio,
    int shadowResolution,
    float shadowNearPlaneOffset,
    out Matrix4x4 viewMatrix,
    out Matrix4x4 projMatrix,
    out ShadowSplitData shadowSplitData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[10];
    numPtr[0] = (System.IntPtr) &cullingResultsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &splitIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &splitCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref splitRatio;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowResolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowNearPlaneOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref shadowSplitData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static int GetLightIndexCount(System.IntPtr cullingResultsPtr)
  {
    return CullingResults.GetLightIndexCountDelegateField(cullingResultsPtr);
  }

  public static int GetReflectionProbeIndexCount(System.IntPtr cullingResultsPtr)
  {
    return CullingResults.GetReflectionProbeIndexCountDelegateField(cullingResultsPtr);
  }

  public static void FillLightAndReflectionProbeIndices(
    System.IntPtr cullingResultsPtr,
    ComputeBuffer computeBuffer)
  {
    CullingResults.FillLightAndReflectionProbeIndices_Injected(cullingResultsPtr, computeBuffer == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(computeBuffer));
  }

  public static void FillLightAndReflectionProbeIndicesGraphicsBuffer(
    System.IntPtr cullingResultsPtr,
    GraphicsBuffer buffer)
  {
    CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer_Injected(cullingResultsPtr, buffer == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer));
  }

  public static int GetLightIndexMapSize(System.IntPtr cullingResultsPtr)
  {
    return CullingResults.GetLightIndexMapSizeDelegateField(cullingResultsPtr);
  }

  public static int GetReflectionProbeIndexMapSize(System.IntPtr cullingResultsPtr)
  {
    return CullingResults.GetReflectionProbeIndexMapSizeDelegateField(cullingResultsPtr);
  }

  public static void FillLightIndexMap(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize)
  {
    CullingResults.FillLightIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
  }

  public static void FillReflectionProbeIndexMap(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize)
  {
    CullingResults.FillReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
  }

  public static void SetLightIndexMap(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize)
  {
    CullingResults.SetLightIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
  }

  public static void SetReflectionProbeIndexMap(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize)
  {
    CullingResults.SetReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
  }

  public unsafe NativeArray<VisibleLight> visibleOffscreenVertexLights
  {
    get
    {
      return this.GetNativeArray<VisibleLight>((void*) ((CullingAllocationInfo*) this.m_AllocationInfo)->visibleOffscreenVertexLightsPtr, ((CullingAllocationInfo*) this.m_AllocationInfo)->visibleOffscreenVertexLightCount);
    }
  }

  public unsafe NativeArray<VisibleReflectionProbe> visibleReflectionProbes
  {
    get
    {
      return this.GetNativeArray<VisibleReflectionProbe>((void*) ((CullingAllocationInfo*) this.m_AllocationInfo)->visibleReflectionProbesPtr, ((CullingAllocationInfo*) this.m_AllocationInfo)->visibleReflectionProbeCount);
    }
  }

  public int lightIndexCount => CullingResults.GetLightIndexCount(this.ptr);

  public int reflectionProbeIndexCount => CullingResults.GetReflectionProbeIndexCount(this.ptr);

  public int lightAndReflectionProbeIndexCount
  {
    get
    {
      return CullingResults.GetLightIndexCount(this.ptr) + CullingResults.GetReflectionProbeIndexCount(this.ptr);
    }
  }

  public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer)
  {
    CullingResults.FillLightAndReflectionProbeIndices(this.ptr, computeBuffer);
  }

  public void FillLightAndReflectionProbeIndices(GraphicsBuffer buffer)
  {
    CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer(this.ptr, buffer);
  }

  public unsafe NativeArray<int> GetLightIndexMap(Allocator allocator)
  {
    int lightIndexMapSize = CullingResults.GetLightIndexMapSize(this.ptr);
    NativeArray<int> nativeArray;
    // ISSUE: explicit constructor call
    ((NativeArray<int>) ref nativeArray).\u002Ector(lightIndexMapSize, allocator, NativeArrayOptions.UninitializedMemory);
    CullingResults.FillLightIndexMap(this.ptr, (System.IntPtr) nativeArray.GetUnsafePtr<int>(), lightIndexMapSize);
    return nativeArray;
  }

  public unsafe void SetLightIndexMap(NativeArray<int> lightIndexMap)
  {
    CullingResults.SetLightIndexMap(this.ptr, (System.IntPtr) lightIndexMap.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref lightIndexMap).Length);
  }

  public unsafe NativeArray<int> GetReflectionProbeIndexMap(Allocator allocator)
  {
    int probeIndexMapSize = CullingResults.GetReflectionProbeIndexMapSize(this.ptr);
    NativeArray<int> nativeArray;
    // ISSUE: explicit constructor call
    ((NativeArray<int>) ref nativeArray).\u002Ector(probeIndexMapSize, allocator, NativeArrayOptions.UninitializedMemory);
    CullingResults.FillReflectionProbeIndexMap(this.ptr, (System.IntPtr) nativeArray.GetUnsafePtr<int>(), probeIndexMapSize);
    return nativeArray;
  }

  public unsafe void SetReflectionProbeIndexMap(NativeArray<int> lightIndexMap)
  {
    CullingResults.SetReflectionProbeIndexMap(this.ptr, (System.IntPtr) lightIndexMap.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref lightIndexMap).Length);
  }

  public void Validate()
  {
  }

  public static bool operator !=(CullingResults left, CullingResults right) => !left.Equals(right);

  public static void FillLightAndReflectionProbeIndices_Injected(
    System.IntPtr cullingResultsPtr,
    System.IntPtr computeBuffer)
  {
    CullingResults.FillLightAndReflectionProbeIndices_InjectedDelegateField(cullingResultsPtr, computeBuffer);
  }

  public static void FillLightAndReflectionProbeIndicesGraphicsBuffer_Injected(
    System.IntPtr cullingResultsPtr,
    System.IntPtr buffer)
  {
    CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegateField(cullingResultsPtr, buffer);
  }

  private sealed class MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CullingResults.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CullingResults>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate int GetLightIndexCountDelegate(System.IntPtr cullingResultsPtr);

  private delegate int GetReflectionProbeIndexCountDelegate(System.IntPtr cullingResultsPtr);

  private delegate int GetLightIndexMapSizeDelegate(System.IntPtr cullingResultsPtr);

  private delegate int GetReflectionProbeIndexMapSizeDelegate(System.IntPtr cullingResultsPtr);

  private delegate void FillLightIndexMapDelegate(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize);

  private delegate void FillReflectionProbeIndexMapDelegate(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize);

  private delegate void SetLightIndexMapDelegate(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize);

  private delegate void SetReflectionProbeIndexMapDelegate(
    System.IntPtr cullingResultsPtr,
    System.IntPtr indexMapPtr,
    int indexMapSize);

  private delegate void FillLightAndReflectionProbeIndices_InjectedDelegate(
    System.IntPtr cullingResultsPtr,
    System.IntPtr computeBuffer);

  private delegate void FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegate(
    System.IntPtr cullingResultsPtr,
    System.IntPtr buffer);
}
