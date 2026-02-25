// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DirectionalLightsV2Data
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

public sealed class DirectionalLightsV2Data(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kDirectionalLightCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kMainLightCascadeCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbufferCloud;
  private static readonly System.IntPtr NativeFieldInfoPtr__shadowData;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__cloudLightCount;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MainLightCastsShadows_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MainLightShadowData_Public_get_MainLightShadowData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CloudLightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLight_Public_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_Single_ShadowCullingDataBuilder_LightingStageErrors_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCameraEmbeddedLight_Public_Void_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCloudLight_Private_Void_byref_VisibleLight_LightExtraData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCBufferRenderingLayerMask_Private_Void_Int32_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCBufferPackedData_Private_Void_Int32_byref_PackedDataA_byref_PackedDataB_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCloudCBufferData_Private_Void_Int32_Single_Vector3_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMainLightShadowSettings_Public_Void_byref_ShadowMappingParams_0;

  static DirectionalLightsV2Data()
  {
    Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DirectionalLightsV2Data));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr);
    DirectionalLightsV2Data.NativeFieldInfoPtr_kDirectionalLightCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (kDirectionalLightCountLimit));
    DirectionalLightsV2Data.NativeFieldInfoPtr_kMainLightCascadeCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (kMainLightCascadeCountLimit));
    DirectionalLightsV2Data.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (_cbuffer));
    DirectionalLightsV2Data.NativeFieldInfoPtr__cbufferCloud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (_cbufferCloud));
    DirectionalLightsV2Data.NativeFieldInfoPtr__shadowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (_shadowData));
    DirectionalLightsV2Data.NativeFieldInfoPtr__lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (_lightCount));
    DirectionalLightsV2Data.NativeFieldInfoPtr__cloudLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (_cloudLightCount));
    DirectionalLightsV2Data.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663842);
    DirectionalLightsV2Data.NativeMethodInfoPtr_get_MainLightCastsShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663843);
    DirectionalLightsV2Data.NativeMethodInfoPtr_get_MainLightShadowData_Public_get_MainLightShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663844);
    DirectionalLightsV2Data.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663845);
    DirectionalLightsV2Data.NativeMethodInfoPtr_get_CloudLightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663846);
    DirectionalLightsV2Data.NativeMethodInfoPtr_AddLight_Public_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_Single_ShadowCullingDataBuilder_LightingStageErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663847);
    DirectionalLightsV2Data.NativeMethodInfoPtr_AddCameraEmbeddedLight_Public_Void_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663848);
    DirectionalLightsV2Data.NativeMethodInfoPtr_AddCloudLight_Private_Void_byref_VisibleLight_LightExtraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663849);
    DirectionalLightsV2Data.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663850);
    DirectionalLightsV2Data.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663851);
    DirectionalLightsV2Data.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663852);
    DirectionalLightsV2Data.NativeMethodInfoPtr_SetCBufferRenderingLayerMask_Private_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663853);
    DirectionalLightsV2Data.NativeMethodInfoPtr_SetCBufferPackedData_Private_Void_Int32_byref_PackedDataA_byref_PackedDataB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663854);
    DirectionalLightsV2Data.NativeMethodInfoPtr_SetCloudCBufferData_Private_Void_Int32_Single_Vector3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663855);
    DirectionalLightsV2Data.NativeMethodInfoPtr_SetMainLightShadowSettings_Public_Void_byref_ShadowMappingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, 100663856 /*0x06000230*/);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929752, RefRangeEnd = 929754, XrefRangeStart = 929720, XrefRangeEnd = 929752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DirectionalLightsV2Data()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool MainLightCastsShadows
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_get_MainLightCastsShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MainLightShadowData MainLightShadowData
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_get_MainLightShadowData_Public_get_MainLightShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new MainLightShadowData(pointer);
    }
  }

  public unsafe int LightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int CloudLightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_get_CloudLightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929802, RefRangeEnd = 929803, XrefRangeStart = 929754, XrefRangeEnd = 929802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddLight(
    int vlIndex,
    [In] ref VisibleLight vl,
    LightExtraData led,
    [In] ref CullingResults cullingResults,
    float shadowNearPlaneDistance,
    ShadowCullingDataBuilder shadowCullingDataBuilder,
    LightingStageErrors errors)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowNearPlaneDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowCullingDataBuilder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) errors);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_AddLight_Public_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_Single_ShadowCullingDataBuilder_LightingStageErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCameraEmbeddedLight(float intensity, Vector3 negForwardWs)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &intensity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &negForwardWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_AddCameraEmbeddedLight_Public_Void_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929803, XrefRangeEnd = 929806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCloudLight([In] ref VisibleLight vl, LightExtraData led)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_AddCloudLight_Private_Void_byref_VisibleLight_LightExtraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929813, RefRangeEnd = 929815, XrefRangeStart = 929806, XrefRangeEnd = 929813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindGlobal(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929815, RefRangeEnd = 929817, XrefRangeStart = 929815, XrefRangeEnd = 929815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929824, RefRangeEnd = 929826, XrefRangeStart = 929817, XrefRangeEnd = 929824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetCBufferRenderingLayerMask(int lightIndex, uint mask)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mask;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_SetCBufferRenderingLayerMask_Private_Void_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetCBufferPackedData(
    int lightIndex,
    [In] ref DirectionalLightsV2Data.PackedDataA a,
    [In] ref DirectionalLightsV2Data.PackedDataB b)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &lightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_SetCBufferPackedData_Private_Void_Int32_byref_PackedDataA_byref_PackedDataB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetCloudCBufferData(
    int lightIndex,
    float intensity,
    Vector3 negForwardWs,
    uint tint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &lightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &intensity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &negForwardWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tint;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_SetCloudCBufferData_Private_Void_Int32_Single_Vector3_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929826, RefRangeEnd = 929828, XrefRangeStart = 929826, XrefRangeEnd = 929826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetMainLightShadowSettings([In] ref ShadowMappingParams smp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref smp
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DirectionalLightsV2Data.NativeMethodInfoPtr_SetMainLightShadowSettings_Public_Void_byref_ShadowMappingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kDirectionalLightCountLimit
  {
    get
    {
      int directionalLightCountLimit;
      IL2CPP.il2cpp_field_static_get_value(DirectionalLightsV2Data.NativeFieldInfoPtr_kDirectionalLightCountLimit, (void*) &directionalLightCountLimit);
      return directionalLightCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DirectionalLightsV2Data.NativeFieldInfoPtr_kDirectionalLightCountLimit, (void*) &value);
    }
  }

  public static unsafe int kMainLightCascadeCountLimit
  {
    get
    {
      int cascadeCountLimit;
      IL2CPP.il2cpp_field_static_get_value(DirectionalLightsV2Data.NativeFieldInfoPtr_kMainLightCascadeCountLimit, (void*) &cascadeCountLimit);
      return cascadeCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DirectionalLightsV2Data.NativeFieldInfoPtr_kMainLightCascadeCountLimit, (void*) &value);
    }
  }

  public unsafe CBuffer<DirectionalLightsV2Data.DirectionalLightsV2CBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>) null : Il2CppObjectPool.Get<CBuffer<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData> _cbufferCloud
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__cbufferCloud));
      return num == System.IntPtr.Zero ? (CBuffer<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>) null : Il2CppObjectPool.Get<CBuffer<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__cbufferCloud), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public MainLightShadowData _shadowData
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__shadowData);
      return new MainLightShadowData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__shadowData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe int _lightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__lightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__lightCount)) = value;
    }
  }

  public unsafe int _cloudLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__cloudLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionalLightsV2Data.NativeFieldInfoPtr__cloudLightCount)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PackedDataA
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_flags;
    private static readonly System.IntPtr NativeFieldInfoPtr_tint;
    private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricIntensity;
    [FieldOffset(0)]
    public uint flags;
    [FieldOffset(4)]
    public uint tint;
    [FieldOffset(8)]
    public float intensity;
    [FieldOffset(12)]
    public float volumetricIntensity;

    static PackedDataA()
    {
      Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (PackedDataA));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataA>.NativeClassPtr);
      DirectionalLightsV2Data.PackedDataA.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataA>.NativeClassPtr, nameof (flags));
      DirectionalLightsV2Data.PackedDataA.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataA>.NativeClassPtr, nameof (tint));
      DirectionalLightsV2Data.PackedDataA.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataA>.NativeClassPtr, nameof (intensity));
      DirectionalLightsV2Data.PackedDataA.NativeFieldInfoPtr_volumetricIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataA>.NativeClassPtr, nameof (volumetricIntensity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataA>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PackedDataB
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_negForwardWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding1;
    [FieldOffset(0)]
    public Vector3 negForwardWs;
    [FieldOffset(12)]
    public uint padding1;

    static PackedDataB()
    {
      Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (PackedDataB));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataB>.NativeClassPtr);
      DirectionalLightsV2Data.PackedDataB.NativeFieldInfoPtr_negForwardWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataB>.NativeClassPtr, nameof (negForwardWs));
      DirectionalLightsV2Data.PackedDataB.NativeFieldInfoPtr_padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataB>.NativeClassPtr, nameof (padding1));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLightsV2Data.PackedDataB>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DirectionalLightsV2CBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_lightCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask0;
    private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask1;
    private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask2;
    private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask3;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataA0;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataA1;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataA2;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataA3;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataB0;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataB1;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataB2;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedDataB3;
    [FieldOffset(0)]
    public uint lightCount;
    [FieldOffset(4)]
    public Vector3Int padding;
    [FieldOffset(16 /*0x10*/)]
    public uint renderingLayerMask0;
    [FieldOffset(20)]
    public uint renderingLayerMask1;
    [FieldOffset(24)]
    public uint renderingLayerMask2;
    [FieldOffset(28)]
    public uint renderingLayerMask3;
    [FieldOffset(32 /*0x20*/)]
    public DirectionalLightsV2Data.PackedDataA packedDataA0;
    [FieldOffset(48 /*0x30*/)]
    public DirectionalLightsV2Data.PackedDataA packedDataA1;
    [FieldOffset(64 /*0x40*/)]
    public DirectionalLightsV2Data.PackedDataA packedDataA2;
    [FieldOffset(80 /*0x50*/)]
    public DirectionalLightsV2Data.PackedDataA packedDataA3;
    [FieldOffset(96 /*0x60*/)]
    public DirectionalLightsV2Data.PackedDataB packedDataB0;
    [FieldOffset(112 /*0x70*/)]
    public DirectionalLightsV2Data.PackedDataB packedDataB1;
    [FieldOffset(128 /*0x80*/)]
    public DirectionalLightsV2Data.PackedDataB packedDataB2;
    [FieldOffset(144 /*0x90*/)]
    public DirectionalLightsV2Data.PackedDataB packedDataB3;

    static DirectionalLightsV2CBufferData()
    {
      Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (DirectionalLightsV2CBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr);
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (lightCount));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (padding));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_renderingLayerMask0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (renderingLayerMask0));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_renderingLayerMask1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (renderingLayerMask1));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_renderingLayerMask2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (renderingLayerMask2));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_renderingLayerMask3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (renderingLayerMask3));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataA0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataA0));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataA1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataA1));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataA2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataA2));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataA3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataA3));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataB0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataB0));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataB1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataB1));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataB2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataB2));
      DirectionalLightsV2Data.DirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedDataB3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedDataB3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLightsV2Data.DirectionalLightsV2CBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct CloudDirectionalLightsV2CBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_lightCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedData0;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedData1;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedData2;
    private static readonly System.IntPtr NativeFieldInfoPtr_packedData3;
    private static readonly System.IntPtr NativeFieldInfoPtr_tint0;
    private static readonly System.IntPtr NativeFieldInfoPtr_tint1;
    private static readonly System.IntPtr NativeFieldInfoPtr_tint2;
    private static readonly System.IntPtr NativeFieldInfoPtr_tint3;
    [FieldOffset(0)]
    public uint lightCount;
    [FieldOffset(4)]
    public Vector3Int padding;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 packedData0;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 packedData1;
    [FieldOffset(48 /*0x30*/)]
    public Vector4 packedData2;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 packedData3;
    [FieldOffset(80 /*0x50*/)]
    public uint tint0;
    [FieldOffset(84)]
    public uint tint1;
    [FieldOffset(88)]
    public uint tint2;
    [FieldOffset(92)]
    public uint tint3;

    static CloudDirectionalLightsV2CBufferData()
    {
      Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirectionalLightsV2Data>.NativeClassPtr, nameof (CloudDirectionalLightsV2CBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr);
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (lightCount));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (padding));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedData0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedData0));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedData1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedData1));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedData2));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_packedData3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (packedData3));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_tint0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (tint0));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_tint1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (tint1));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_tint2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (tint2));
      DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData.NativeFieldInfoPtr_tint3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, nameof (tint3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLightsV2Data.CloudDirectionalLightsV2CBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
