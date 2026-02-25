// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowCastingPass
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

public sealed class ShadowCastingPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMainLightShadowMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexPunctualLightShadowMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexMainLightShadowMapDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexPunctualLightShadowMapDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr__punctualLightCache;
  private static readonly System.IntPtr NativeFieldInfoPtr__shadowCastingCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__texMainLightShadowMap;
  private static readonly System.IntPtr NativeFieldInfoPtr__texPunctualLightShadowMap;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeMainLightDummyShadowMapTexture_Private_Static_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakePunctualLightDummyShadowMapTexture_Private_Static_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderShadowCasters_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_ShadowObjectsFilter_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Nullable_1_Single_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_LightingData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeMainLightShadowCasting_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_Boolean_LightingData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePunctualLightsShadowCasting_Private_Nullable_1_Single_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_Boolean_LightingData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessPunctualLight_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_byref_PunctualLightTexShadowMapData_Int32_Boolean_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ShadowCastingPass()
  {
    Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowCastingPass));
    ShadowCastingPass.NativeFieldInfoPtr_kSidTexMainLightShadowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (kSidTexMainLightShadowMap));
    ShadowCastingPass.NativeFieldInfoPtr_kSidTexPunctualLightShadowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (kSidTexPunctualLightShadowMap));
    ShadowCastingPass.NativeFieldInfoPtr_kTexMainLightShadowMapDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (kTexMainLightShadowMapDesc));
    ShadowCastingPass.NativeFieldInfoPtr_kTexPunctualLightShadowMapDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (kTexPunctualLightShadowMapDesc));
    ShadowCastingPass.NativeFieldInfoPtr__punctualLightCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (_punctualLightCache));
    ShadowCastingPass.NativeFieldInfoPtr__shadowCastingCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (_shadowCastingCBuffer));
    ShadowCastingPass.NativeFieldInfoPtr__texMainLightShadowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (_texMainLightShadowMap));
    ShadowCastingPass.NativeFieldInfoPtr__texPunctualLightShadowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (_texPunctualLightShadowMap));
    ShadowCastingPass.NativeMethodInfoPtr_MakeMainLightDummyShadowMapTexture_Private_Static_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664034);
    ShadowCastingPass.NativeMethodInfoPtr_MakePunctualLightDummyShadowMapTexture_Private_Static_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664035);
    ShadowCastingPass.NativeMethodInfoPtr_RenderShadowCasters_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_ShadowObjectsFilter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664036);
    ShadowCastingPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664037);
    ShadowCastingPass.NativeMethodInfoPtr_Encode_Public_Nullable_1_Single_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_LightingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664038);
    ShadowCastingPass.NativeMethodInfoPtr_EncodeMainLightShadowCasting_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_Boolean_LightingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664039);
    ShadowCastingPass.NativeMethodInfoPtr_EncodePunctualLightsShadowCasting_Private_Nullable_1_Single_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_Boolean_LightingData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664040);
    ShadowCastingPass.NativeMethodInfoPtr_ProcessPunctualLight_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_byref_PunctualLightTexShadowMapData_Int32_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664041);
    ShadowCastingPass.NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664042);
    ShadowCastingPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, 100664043);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931878, XrefRangeEnd = 931889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeMainLightDummyShadowMapTexture()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_MakeMainLightDummyShadowMapTexture_Private_Static_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931889, XrefRangeEnd = 931900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakePunctualLightDummyShadowMapTexture()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_MakePunctualLightDummyShadowMapTexture_Private_Static_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 931910, RefRangeEnd = 931913, XrefRangeStart = 931900, XrefRangeEnd = 931910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RenderShadowCasters(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref CullingResults cullingResults,
    ShadowObjectsFilter filter,
    int visibleLightIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &visibleLightIndex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_RenderShadowCasters_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_ShadowObjectsFilter_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931913, XrefRangeEnd = 931944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowCastingPass()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931944, XrefRangeEnd = 931961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Nullable<float> Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    LightingData lightingData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightingData);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_Encode_Public_Nullable_1_Single_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_LightingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<float>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932025, RefRangeEnd = 932027, XrefRangeStart = 931961, XrefRangeEnd = 932025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeMainLightShadowCasting(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref CullingResults cullingResults,
    bool shadowMappingIsOn,
    LightingData lightingData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowMappingIsOn;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightingData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_EncodeMainLightShadowCasting_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_Boolean_LightingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932057, RefRangeEnd = 932059, XrefRangeStart = 932027, XrefRangeEnd = 932057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Nullable<float> EncodePunctualLightsShadowCasting(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref CullingResults cullingResults,
    bool shadowMappingIsOn,
    LightingData lightingData,
    bool useCache)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowMappingIsOn;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightingData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &useCache;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_EncodePunctualLightsShadowCasting_Private_Nullable_1_Single_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_Boolean_LightingData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<float>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932115, RefRangeEnd = 932116, XrefRangeStart = 932059, XrefRangeEnd = 932115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessPunctualLight(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref CullingResults cullingResults,
    [In] ref PunctualLightTexShadowMapData shadowData,
    int shadowMapIdx,
    bool useCaching,
    ref int cacheableLightCounter,
    ref int newCacheSlotCounter)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) shadowData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowMapIdx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &useCaching;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref cacheableLightCounter;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref newCacheSlotCounter;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_ProcessPunctualLight_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CullingResults_byref_PunctualLightTexShadowMapData_Int32_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932116, XrefRangeEnd = 932121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_EndFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932121, XrefRangeEnd = 932143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCastingPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexMainLightShadowMap
  {
    get
    {
      int mainLightShadowMap;
      IL2CPP.il2cpp_field_static_get_value(ShadowCastingPass.NativeFieldInfoPtr_kSidTexMainLightShadowMap, (void*) &mainLightShadowMap);
      return mainLightShadowMap;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowCastingPass.NativeFieldInfoPtr_kSidTexMainLightShadowMap, (void*) &value);
    }
  }

  public static unsafe int kSidTexPunctualLightShadowMap
  {
    get
    {
      int punctualLightShadowMap;
      IL2CPP.il2cpp_field_static_get_value(ShadowCastingPass.NativeFieldInfoPtr_kSidTexPunctualLightShadowMap, (void*) &punctualLightShadowMap);
      return punctualLightShadowMap;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowCastingPass.NativeFieldInfoPtr_kSidTexPunctualLightShadowMap, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor kTexMainLightShadowMapDesc
  {
    get
    {
      RenderTextureDescriptor lightShadowMapDesc;
      IL2CPP.il2cpp_field_static_get_value(ShadowCastingPass.NativeFieldInfoPtr_kTexMainLightShadowMapDesc, (void*) &lightShadowMapDesc);
      return lightShadowMapDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowCastingPass.NativeFieldInfoPtr_kTexMainLightShadowMapDesc, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor kTexPunctualLightShadowMapDesc
  {
    get
    {
      RenderTextureDescriptor lightShadowMapDesc;
      IL2CPP.il2cpp_field_static_get_value(ShadowCastingPass.NativeFieldInfoPtr_kTexPunctualLightShadowMapDesc, (void*) &lightShadowMapDesc);
      return lightShadowMapDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowCastingPass.NativeFieldInfoPtr_kTexPunctualLightShadowMapDesc, (void*) &value);
    }
  }

  public unsafe ShadowMapCache _punctualLightCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__punctualLightCache));
      return num == System.IntPtr.Zero ? (ShadowMapCache) null : Il2CppObjectPool.Get<ShadowMapCache>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__punctualLightCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<ShadowCastingPass.ShadowCastingCBufferData> _shadowCastingCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__shadowCastingCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ShadowCastingPass.ShadowCastingCBufferData>) null : Il2CppObjectPool.Get<CBuffer<ShadowCastingPass.ShadowCastingCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__shadowCastingCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public RenderTextureResource _texMainLightShadowMap
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__texMainLightShadowMap);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__texMainLightShadowMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public RenderTextureResource _texPunctualLightShadowMap
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__texPunctualLightShadowMap);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastingPass.NativeFieldInfoPtr__texPunctualLightShadowMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ShadowCastingCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_lightDirWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_biasValues;
    [FieldOffset(0)]
    public Matrix4x4 projectionViewMatrix;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 lightDirWs;
    [FieldOffset(80 /*0x50*/)]
    public Vector4 biasValues;

    static ShadowCastingCBufferData()
    {
      Il2CppClassPointerStore<ShadowCastingPass.ShadowCastingCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowCastingPass>.NativeClassPtr, nameof (ShadowCastingCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCastingPass.ShadowCastingCBufferData>.NativeClassPtr);
      ShadowCastingPass.ShadowCastingCBufferData.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass.ShadowCastingCBufferData>.NativeClassPtr, nameof (projectionViewMatrix));
      ShadowCastingPass.ShadowCastingCBufferData.NativeFieldInfoPtr_lightDirWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass.ShadowCastingCBufferData>.NativeClassPtr, nameof (lightDirWs));
      ShadowCastingPass.ShadowCastingCBufferData.NativeFieldInfoPtr_biasValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastingPass.ShadowCastingCBufferData>.NativeClassPtr, nameof (biasValues));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowCastingPass.ShadowCastingCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
