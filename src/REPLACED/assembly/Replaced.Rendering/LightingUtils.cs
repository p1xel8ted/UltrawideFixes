// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LightingUtils
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public static class LightingUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kShadowReceiverNdc2Uv;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLightExraData_Public_Static_LightExtraData_Light_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcExposure_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcExposureEv100_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcShadowBiases_Public_Static_Vector4_Single_Single_byref_Matrix4x4_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFovBiasInDegrees_Public_Static_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesCastShadows_Public_Static_Boolean_Int32_LightExtraData_LightShadows_byref_CullingResults_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLightType_Public_Static_LightType_LightShapeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingProjectionType_Public_Static_BatchCullingProjectionType_LightType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SyncLightTypeWithShapeType_Public_Static_Void_Light_LightShapeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SyncLightShadowsWithShadowMappingEnabled_Public_Static_Void_Light_Boolean_0;

  static LightingUtils()
  {
    Il2CppClassPointerStore<LightingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LightingUtils));
    LightingUtils.NativeFieldInfoPtr_kShadowReceiverNdc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, nameof (kShadowReceiverNdc2Uv));
    LightingUtils.NativeMethodInfoPtr_AddLightExraData_Public_Static_LightExtraData_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100663996);
    LightingUtils.NativeMethodInfoPtr_CalcExposure_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100663997);
    LightingUtils.NativeMethodInfoPtr_CalcExposureEv100_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100663998);
    LightingUtils.NativeMethodInfoPtr_CalcShadowBiases_Public_Static_Vector4_Single_Single_byref_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100663999);
    LightingUtils.NativeMethodInfoPtr_GetFovBiasInDegrees_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100664000 /*0x060002C0*/);
    LightingUtils.NativeMethodInfoPtr_DoesCastShadows_Public_Static_Boolean_Int32_LightExtraData_LightShadows_byref_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100664001);
    LightingUtils.NativeMethodInfoPtr_GetLightType_Public_Static_LightType_LightShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100664002);
    LightingUtils.NativeMethodInfoPtr_GetCullingProjectionType_Public_Static_BatchCullingProjectionType_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100664003);
    LightingUtils.NativeMethodInfoPtr_SyncLightTypeWithShapeType_Public_Static_Void_Light_LightShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100664004);
    LightingUtils.NativeMethodInfoPtr_SyncLightShadowsWithShadowMappingEnabled_Public_Static_Void_Light_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingUtils>.NativeClassPtr, 100664005);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931598, XrefRangeEnd = 931610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LightExtraData AddLightExraData(Light light)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) light)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_AddLightExraData_Public_Static_LightExtraData_Light_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LightExtraData) null : Il2CppObjectPool.Get<LightExtraData>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931611, RefRangeEnd = 931612, XrefRangeStart = 931610, XrefRangeEnd = 931611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float CalcExposure(float ev100)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ev100
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_CalcExposure_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931612, XrefRangeEnd = 931613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float CalcExposureEv100(float ev100)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ev100
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_CalcExposureEv100_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931613, RefRangeEnd = 931614, XrefRangeStart = 931613, XrefRangeEnd = 931613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 CalcShadowBiases(
    float depthBias,
    float normalBias,
    [In] ref Matrix4x4 projection,
    float shadowMapResolution)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &depthBias;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &normalBias;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref projection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowMapResolution;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_CalcShadowBiases_Public_Static_Vector4_Single_Single_byref_Matrix4x4_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float GetFovBiasInDegrees(int shadowMapResolution)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &shadowMapResolution
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_GetFovBiasInDegrees_Public_Static_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931615, RefRangeEnd = 931616, XrefRangeStart = 931614, XrefRangeEnd = 931615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoesCastShadows(
    int visibleLightIndex,
    LightExtraData led,
    LightShadows shadows,
    [In] ref CullingResults cullingResults)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &visibleLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &shadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_DoesCastShadows_Public_Static_Boolean_Int32_LightExtraData_LightShadows_byref_CullingResults_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931616, XrefRangeEnd = 931617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LightType GetLightType(LightShapeType shapeType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &shapeType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_GetLightType_Public_Static_LightType_LightShapeType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LightType*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe BatchCullingProjectionType GetCullingProjectionType(LightType type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &type
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_GetCullingProjectionType_Public_Static_BatchCullingProjectionType_LightType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(BatchCullingProjectionType*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931617, XrefRangeEnd = 931642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SyncLightTypeWithShapeType(Light light, LightShapeType shapeType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) light);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shapeType;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_SyncLightTypeWithShapeType_Public_Static_Void_Light_LightShapeType_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931642, XrefRangeEnd = 931644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SyncLightShadowsWithShadowMappingEnabled(
    Light light,
    bool shadowMappingEnabled)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) light);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowMappingEnabled;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingUtils.NativeMethodInfoPtr_SyncLightShadowsWithShadowMappingEnabled_Public_Static_Void_Light_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public LightingUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Matrix4x4 kShadowReceiverNdc2Uv
  {
    get
    {
      Matrix4x4 shadowReceiverNdc2Uv;
      IL2CPP.il2cpp_field_static_get_value(LightingUtils.NativeFieldInfoPtr_kShadowReceiverNdc2Uv, (void*) &shadowReceiverNdc2Uv);
      return shadowReceiverNdc2Uv;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingUtils.NativeFieldInfoPtr_kShadowReceiverNdc2Uv, (void*) &value);
    }
  }
}
