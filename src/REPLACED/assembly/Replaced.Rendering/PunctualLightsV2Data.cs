// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PunctualLightsV2Data
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class PunctualLightsV2Data(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidPLV2BufferRenderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidPLV2BufferPackedData;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidPLV2BufferPackedDataVolumetric;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidPLV2BufferShadowMapData;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidPLV2BufferSMProjectionViewReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidPLV2BufferPatternData;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexPatternAtlas;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferRenderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferPackedData;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferPackedDataVolumetric;
  private static readonly System.IntPtr NativeFieldInfoPtr__maxLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__globalShadowData;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferShadowMapData;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferSMProjectionViewReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr__punctualLightTexShadowMapList;
  private static readonly System.IntPtr NativeFieldInfoPtr__texShadowMapCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferPatternData;
  private static readonly System.IntPtr NativeFieldInfoPtr__texWhiteTexture2DArray;
  private static readonly System.IntPtr NativeFieldInfoPtr__texLightPatternAtlas;
  private static readonly System.IntPtr NativeFieldInfoPtr__pointLightWithShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__pointLightWithCacheableShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__spotlightWithShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__spotlightWithCacheableShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__spotlightWithPatternCount;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Texture2DArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GlobalShadowData_Public_get_PunctualLightGlobalShadowData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TexShadowMapCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PointLightWithShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PointLightWithCacheableShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpotlightWithShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpotlightWithCacheableShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpotlightWithPatternCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPunctualLightTexShadowMapData_Public_PunctualLightTexShadowMapData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_UInt32_Buffer_1_PackedData_Buffer_1_PackedData_Buffer_1_SMData_Buffer_1_Matrix4x4_Buffer_1_PatternData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_LightingStageErrors_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPointLightShadowData_Private_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddSpotlightPatternData_Private_Void_Int32_byref_VisibleLight_LightExtraData_LightingStageErrors_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddSpotlightShadowData_Private_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PunctualLightsV2Data()
  {
    Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PunctualLightsV2Data));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr);
    PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (kSidPLV2BufferRenderingLayerMask));
    PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPackedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (kSidPLV2BufferPackedData));
    PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPackedDataVolumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (kSidPLV2BufferPackedDataVolumetric));
    PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferShadowMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (kSidPLV2BufferShadowMapData));
    PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferSMProjectionViewReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (kSidPLV2BufferSMProjectionViewReceiver));
    PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPatternData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (kSidPLV2BufferPatternData));
    PunctualLightsV2Data.NativeFieldInfoPtr_kSidTexPatternAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (kSidTexPatternAtlas));
    PunctualLightsV2Data.NativeFieldInfoPtr__bufferRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_bufferRenderingLayerMask));
    PunctualLightsV2Data.NativeFieldInfoPtr__bufferPackedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_bufferPackedData));
    PunctualLightsV2Data.NativeFieldInfoPtr__bufferPackedDataVolumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_bufferPackedDataVolumetric));
    PunctualLightsV2Data.NativeFieldInfoPtr__maxLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_maxLightCount));
    PunctualLightsV2Data.NativeFieldInfoPtr__lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_lightCount));
    PunctualLightsV2Data.NativeFieldInfoPtr__globalShadowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_globalShadowData));
    PunctualLightsV2Data.NativeFieldInfoPtr__bufferShadowMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_bufferShadowMapData));
    PunctualLightsV2Data.NativeFieldInfoPtr__bufferSMProjectionViewReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_bufferSMProjectionViewReceiver));
    PunctualLightsV2Data.NativeFieldInfoPtr__punctualLightTexShadowMapList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_punctualLightTexShadowMapList));
    PunctualLightsV2Data.NativeFieldInfoPtr__texShadowMapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_texShadowMapCount));
    PunctualLightsV2Data.NativeFieldInfoPtr__bufferPatternData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_bufferPatternData));
    PunctualLightsV2Data.NativeFieldInfoPtr__texWhiteTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_texWhiteTexture2DArray));
    PunctualLightsV2Data.NativeFieldInfoPtr__texLightPatternAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_texLightPatternAtlas));
    PunctualLightsV2Data.NativeFieldInfoPtr__pointLightWithShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_pointLightWithShadowCount));
    PunctualLightsV2Data.NativeFieldInfoPtr__pointLightWithCacheableShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_pointLightWithCacheableShadowCount));
    PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_spotlightWithShadowCount));
    PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithCacheableShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_spotlightWithCacheableShadowCount));
    PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithPatternCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (_spotlightWithPatternCount));
    PunctualLightsV2Data.NativeMethodInfoPtr__ctor_Public_Void_Int32_Texture2DArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664014);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664015);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_GlobalShadowData_Public_get_PunctualLightGlobalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664016 /*0x060002D0*/);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_TexShadowMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664017);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_PointLightWithShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664018);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_PointLightWithCacheableShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664019);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_SpotlightWithShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664020);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_SpotlightWithCacheableShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664021);
    PunctualLightsV2Data.NativeMethodInfoPtr_get_SpotlightWithPatternCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664022);
    PunctualLightsV2Data.NativeMethodInfoPtr_GetPunctualLightTexShadowMapData_Public_PunctualLightTexShadowMapData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664023);
    PunctualLightsV2Data.NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_UInt32_Buffer_1_PackedData_Buffer_1_PackedData_Buffer_1_SMData_Buffer_1_Matrix4x4_Buffer_1_PatternData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664024);
    PunctualLightsV2Data.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664025);
    PunctualLightsV2Data.NativeMethodInfoPtr_AddLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_LightingStageErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664026);
    PunctualLightsV2Data.NativeMethodInfoPtr_AddPointLightShadowData_Private_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664027);
    PunctualLightsV2Data.NativeMethodInfoPtr_AddSpotlightPatternData_Private_Void_Int32_byref_VisibleLight_LightExtraData_LightingStageErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664028);
    PunctualLightsV2Data.NativeMethodInfoPtr_AddSpotlightShadowData_Private_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664029);
    PunctualLightsV2Data.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664030);
    PunctualLightsV2Data.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, 100664031);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931693, XrefRangeEnd = 931697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PunctualLightsV2Data(int maxLightCount, Texture2DArray texWhiteTexture2DArray)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &maxLightCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texWhiteTexture2DArray);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr__ctor_Public_Void_Int32_Texture2DArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int LightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe PunctualLightGlobalShadowData GlobalShadowData
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_GlobalShadowData_Public_get_PunctualLightGlobalShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PunctualLightGlobalShadowData*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int TexShadowMapCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_TexShadowMapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int PointLightWithShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_PointLightWithShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int PointLightWithCacheableShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_PointLightWithCacheableShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int SpotlightWithShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_SpotlightWithShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int SpotlightWithCacheableShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_SpotlightWithCacheableShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int SpotlightWithPatternCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_get_SpotlightWithPatternCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe PunctualLightTexShadowMapData GetPunctualLightTexShadowMapData(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_GetPunctualLightTexShadowMapData_Public_PunctualLightTexShadowMapData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new PunctualLightTexShadowMapData(pointer);
  }

  [CallerCount(0)]
  public unsafe void BeginWrite(
    Buffer<uint> bufferRenderingLayerMask,
    Buffer<PunctualLightsV2Data.PackedData> bufferPackedData,
    Buffer<PunctualLightsV2Data.PackedData> bufferPackedDataVolumetric,
    Buffer<PunctualLightsV2Data.SMData> bufferShadowMapData,
    Buffer<Matrix4x4> bufferSMProjectionViewReceiver,
    Buffer<PunctualLightsV2Data.PatternData> bufferPatternData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferRenderingLayerMask);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferPackedData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferPackedDataVolumetric);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferShadowMapData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferSMProjectionViewReceiver);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferPatternData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_UInt32_Buffer_1_PackedData_Buffer_1_PackedData_Buffer_1_SMData_Buffer_1_Matrix4x4_Buffer_1_PatternData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931697, XrefRangeEnd = 931715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndWrite(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931760, RefRangeEnd = 931761, XrefRangeStart = 931715, XrefRangeEnd = 931760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int AddLight(
    int vlIndex,
    [In] ref VisibleLight vl,
    LightExtraData led,
    [In] ref CullingResults cullingResults,
    ShadowCullingDataBuilder shadowCullingDataBuilder,
    LightingStageErrors errors)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowCullingDataBuilder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) errors);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_AddLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_LightingStageErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931793, RefRangeEnd = 931794, XrefRangeStart = 931761, XrefRangeEnd = 931793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPointLightShadowData(
    int vlIndex,
    [In] ref VisibleLight vl,
    LightExtraData led,
    [In] ref CullingResults cullingResults,
    ShadowCullingDataBuilder shadowCullingDataBuilder)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowCullingDataBuilder);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_AddPointLightShadowData_Private_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931813, RefRangeEnd = 931814, XrefRangeStart = 931794, XrefRangeEnd = 931813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddSpotlightPatternData(
    int currentPunctualLightIndex,
    [In] ref VisibleLight vl,
    LightExtraData led,
    LightingStageErrors errors)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &currentPunctualLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) errors);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_AddSpotlightPatternData_Private_Void_Int32_byref_VisibleLight_LightExtraData_LightingStageErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931840, RefRangeEnd = 931841, XrefRangeStart = 931814, XrefRangeEnd = 931840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddSpotlightShadowData(
    int vlIndex,
    [In] ref VisibleLight vl,
    LightExtraData led,
    [In] ref CullingResults cullingResults,
    ShadowCullingDataBuilder shadowCullingDataBuilder)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowCullingDataBuilder);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_AddSpotlightShadowData_Private_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 931876, RefRangeEnd = 931878, XrefRangeStart = 931841, XrefRangeEnd = 931876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindGlobal(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PunctualLightsV2Data.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidPLV2BufferRenderingLayerMask
  {
    get
    {
      int renderingLayerMask;
      IL2CPP.il2cpp_field_static_get_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferRenderingLayerMask, (void*) &renderingLayerMask);
      return renderingLayerMask;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferRenderingLayerMask, (void*) &value);
    }
  }

  public static unsafe int kSidPLV2BufferPackedData
  {
    get
    {
      int bufferPackedData;
      IL2CPP.il2cpp_field_static_get_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPackedData, (void*) &bufferPackedData);
      return bufferPackedData;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPackedData, (void*) &value);
    }
  }

  public static unsafe int kSidPLV2BufferPackedDataVolumetric
  {
    get
    {
      int packedDataVolumetric;
      IL2CPP.il2cpp_field_static_get_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPackedDataVolumetric, (void*) &packedDataVolumetric);
      return packedDataVolumetric;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPackedDataVolumetric, (void*) &value);
    }
  }

  public static unsafe int kSidPLV2BufferShadowMapData
  {
    get
    {
      int bufferShadowMapData;
      IL2CPP.il2cpp_field_static_get_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferShadowMapData, (void*) &bufferShadowMapData);
      return bufferShadowMapData;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferShadowMapData, (void*) &value);
    }
  }

  public static unsafe int kSidPLV2BufferSMProjectionViewReceiver
  {
    get
    {
      int projectionViewReceiver;
      IL2CPP.il2cpp_field_static_get_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferSMProjectionViewReceiver, (void*) &projectionViewReceiver);
      return projectionViewReceiver;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferSMProjectionViewReceiver, (void*) &value);
    }
  }

  public static unsafe int kSidPLV2BufferPatternData
  {
    get
    {
      int bufferPatternData;
      IL2CPP.il2cpp_field_static_get_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPatternData, (void*) &bufferPatternData);
      return bufferPatternData;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidPLV2BufferPatternData, (void*) &value);
    }
  }

  public static unsafe int kSidTexPatternAtlas
  {
    get
    {
      int sidTexPatternAtlas;
      IL2CPP.il2cpp_field_static_get_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidTexPatternAtlas, (void*) &sidTexPatternAtlas);
      return sidTexPatternAtlas;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PunctualLightsV2Data.NativeFieldInfoPtr_kSidTexPatternAtlas, (void*) &value);
    }
  }

  public unsafe Buffer<uint> _bufferRenderingLayerMask
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferRenderingLayerMask));
      return num == System.IntPtr.Zero ? (Buffer<uint>) null : Il2CppObjectPool.Get<Buffer<uint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferRenderingLayerMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.PackedData> _bufferPackedData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferPackedData));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferPackedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.PackedData> _bufferPackedDataVolumetric
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferPackedDataVolumetric));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferPackedDataVolumetric), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _maxLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__maxLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__maxLightCount)) = value;
    }
  }

  public unsafe int _lightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__lightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__lightCount)) = value;
    }
  }

  public unsafe PunctualLightGlobalShadowData _globalShadowData
  {
    get
    {
      return *(PunctualLightGlobalShadowData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__globalShadowData));
    }
    [param: In] set
    {
      *(PunctualLightGlobalShadowData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__globalShadowData)) = value;
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.SMData> _bufferShadowMapData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferShadowMapData));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.SMData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.SMData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferShadowMapData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<Matrix4x4> _bufferSMProjectionViewReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferSMProjectionViewReceiver));
      return num == System.IntPtr.Zero ? (Buffer<Matrix4x4>) null : Il2CppObjectPool.Get<Buffer<Matrix4x4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferSMProjectionViewReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<PunctualLightTexShadowMapData> _punctualLightTexShadowMapList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__punctualLightTexShadowMapList));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<PunctualLightTexShadowMapData>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<PunctualLightTexShadowMapData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__punctualLightTexShadowMapList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _texShadowMapCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__texShadowMapCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__texShadowMapCount)) = value;
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.PatternData> _bufferPatternData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferPatternData));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PatternData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PatternData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__bufferPatternData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2DArray _texWhiteTexture2DArray
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__texWhiteTexture2DArray));
      return num == System.IntPtr.Zero ? (Texture2DArray) null : Il2CppObjectPool.Get<Texture2DArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__texWhiteTexture2DArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2DArray _texLightPatternAtlas
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__texLightPatternAtlas));
      return num == System.IntPtr.Zero ? (Texture2DArray) null : Il2CppObjectPool.Get<Texture2DArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__texLightPatternAtlas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _pointLightWithShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__pointLightWithShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__pointLightWithShadowCount)) = value;
    }
  }

  public unsafe int _pointLightWithCacheableShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__pointLightWithCacheableShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__pointLightWithCacheableShadowCount)) = value;
    }
  }

  public unsafe int _spotlightWithShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithShadowCount)) = value;
    }
  }

  public unsafe int _spotlightWithCacheableShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithCacheableShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithCacheableShadowCount)) = value;
    }
  }

  public unsafe int _spotlightWithPatternCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithPatternCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightsV2Data.NativeFieldInfoPtr__spotlightWithPatternCount)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PackedData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_positionWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_rangeWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_rangeScaleStartFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_tint;
    private static readonly System.IntPtr NativeFieldInfoPtr_negForwardWsAngleScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_angleOffsetIntensityLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
    [FieldOffset(0)]
    public Vector3 positionWs;
    [FieldOffset(12)]
    public float rangeWs;
    [FieldOffset(16 /*0x10*/)]
    public uint rangeScaleStartFlags;
    [FieldOffset(20)]
    public uint tint;
    [FieldOffset(24)]
    public Vector2Int negForwardWsAngleScale;
    [FieldOffset(32 /*0x20*/)]
    public uint angleOffsetIntensityLimit;
    [FieldOffset(36)]
    public float intensity;

    static PackedData()
    {
      Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (PackedData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr);
      PunctualLightsV2Data.PackedData.NativeFieldInfoPtr_positionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, nameof (positionWs));
      PunctualLightsV2Data.PackedData.NativeFieldInfoPtr_rangeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, nameof (rangeWs));
      PunctualLightsV2Data.PackedData.NativeFieldInfoPtr_rangeScaleStartFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, nameof (rangeScaleStartFlags));
      PunctualLightsV2Data.PackedData.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, nameof (tint));
      PunctualLightsV2Data.PackedData.NativeFieldInfoPtr_negForwardWsAngleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, nameof (negForwardWsAngleScale));
      PunctualLightsV2Data.PackedData.NativeFieldInfoPtr_angleOffsetIntensityLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, nameof (angleOffsetIntensityLimit));
      PunctualLightsV2Data.PackedData.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, nameof (intensity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PunctualLightsV2Data.PackedData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SMData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_shadowMapIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_shadowedLightTint;
    [FieldOffset(0)]
    public uint shadowMapIndex;
    [FieldOffset(4)]
    public uint shadowedLightTint;

    static SMData()
    {
      Il2CppClassPointerStore<PunctualLightsV2Data.SMData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (SMData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightsV2Data.SMData>.NativeClassPtr);
      PunctualLightsV2Data.SMData.NativeFieldInfoPtr_shadowMapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.SMData>.NativeClassPtr, nameof (shadowMapIndex));
      PunctualLightsV2Data.SMData.NativeFieldInfoPtr_shadowedLightTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.SMData>.NativeClassPtr, nameof (shadowedLightTint));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PunctualLightsV2Data.SMData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PatternData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_pvmMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_arraySliceIndex;
    [FieldOffset(0)]
    public Matrix4x4 pvmMatrix;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 uvScaleOffset;
    [FieldOffset(80 /*0x50*/)]
    public uint arraySliceIndex;

    static PatternData()
    {
      Il2CppClassPointerStore<PunctualLightsV2Data.PatternData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunctualLightsV2Data>.NativeClassPtr, nameof (PatternData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightsV2Data.PatternData>.NativeClassPtr);
      PunctualLightsV2Data.PatternData.NativeFieldInfoPtr_pvmMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PatternData>.NativeClassPtr, nameof (pvmMatrix));
      PunctualLightsV2Data.PatternData.NativeFieldInfoPtr_uvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PatternData>.NativeClassPtr, nameof (uvScaleOffset));
      PunctualLightsV2Data.PatternData.NativeFieldInfoPtr_arraySliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightsV2Data.PatternData>.NativeClassPtr, nameof (arraySliceIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PunctualLightsV2Data.PatternData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
