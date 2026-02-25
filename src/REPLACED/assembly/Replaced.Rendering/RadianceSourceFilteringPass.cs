// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.RadianceSourceFilteringPass
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

public sealed class RadianceSourceFilteringPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputRadianceMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputSceneNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMinHIZ;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutputRadianceMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutputNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelMip0;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelLowerMips;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexTempRadianceMap_Private_Static_RenderTextureResource_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_Single_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeMip0_Private_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_RenderTextureResource_RenderTextureResource_RenderTextureResource_Single_Vector4_Vector2Int_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeLowerMip_Private_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Single_Vector4_Vector2Int_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Single_Vector4_Vector2Int_Int32_0;

  static RadianceSourceFilteringPass()
  {
    Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (RadianceSourceFilteringPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr);
    RadianceSourceFilteringPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (kGroupSize));
    RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputRadianceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (kSidTexInputRadianceMap));
    RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputSceneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (kSidTexInputSceneNormal));
    RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (kSidTexInputSceneDepth));
    RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexMinHIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (kSidTexMinHIZ));
    RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexOutputRadianceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (kSidTexOutputRadianceMap));
    RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexOutputNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (kSidTexOutputNormal));
    RadianceSourceFilteringPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (_cbuffer));
    RadianceSourceFilteringPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (_compute));
    RadianceSourceFilteringPass.NativeFieldInfoPtr__kernelMip0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (_kernelMip0));
    RadianceSourceFilteringPass.NativeFieldInfoPtr__kernelLowerMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (_kernelLowerMips));
    RadianceSourceFilteringPass.NativeMethodInfoPtr_MakeTexTempRadianceMap_Private_Static_RenderTextureResource_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, 100663877);
    RadianceSourceFilteringPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, 100663878);
    RadianceSourceFilteringPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, 100663879);
    RadianceSourceFilteringPass.NativeMethodInfoPtr_EncodeMip0_Private_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_RenderTextureResource_RenderTextureResource_RenderTextureResource_Single_Vector4_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, 100663880);
    RadianceSourceFilteringPass.NativeMethodInfoPtr_EncodeLowerMip_Private_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Single_Vector4_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, 100663881);
    RadianceSourceFilteringPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, 100663882);
    RadianceSourceFilteringPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Single_Vector4_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, 100663883);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930223, XrefRangeEnd = 930233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexTempRadianceMap(Vector2Int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &size
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RadianceSourceFilteringPass.NativeMethodInfoPtr_MakeTexTempRadianceMap_Private_Static_RenderTextureResource_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930233, XrefRangeEnd = 930248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RadianceSourceFilteringPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceFilteringPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930286, RefRangeEnd = 930287, XrefRangeStart = 930248, XrefRangeEnd = 930286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texSceneColor,
    RenderTextureResource texSceneNormal,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texOutputRadianceMap,
    RenderTextureResource texOutputMinHINormal,
    float radianceSourceLimit,
    Vector4 depthProjectionParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneNormal));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputRadianceMap));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputMinHINormal));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &radianceSourceLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceFilteringPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_Single_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930311, RefRangeEnd = 930312, XrefRangeStart = 930287, XrefRangeEnd = 930311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeMip0(
    CommandBuffer cmd,
    RenderTargetIdentifier texRtidInputRadianceMap,
    RenderTargetIdentifier texRtidInputSceneNormal,
    RenderTargetIdentifier texRtidInputSceneDepth,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texOutputRadianceMap,
    RenderTextureResource texOutputMinHINormal,
    float radianceSourceLimit,
    Vector4 depthProjectionParams,
    Vector2Int mipmapSize,
    int outputMipmapLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[11];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texRtidInputRadianceMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &texRtidInputSceneNormal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &texRtidInputSceneDepth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputRadianceMap));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputMinHINormal));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &radianceSourceLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &mipmapSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &outputMipmapLevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceFilteringPass.NativeMethodInfoPtr_EncodeMip0_Private_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_RenderTextureResource_RenderTextureResource_RenderTextureResource_Single_Vector4_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930330, RefRangeEnd = 930331, XrefRangeStart = 930312, XrefRangeEnd = 930330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeLowerMip(
    CommandBuffer cmd,
    RenderTextureResource texRadianceMap,
    RenderTextureResource texTmpRadianceMap,
    float radianceSourceLimit,
    Vector4 depthProjectionParams,
    Vector2Int mipmapSize,
    int outputMipmapLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texRadianceMap));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texTmpRadianceMap));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radianceSourceLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mipmapSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &outputMipmapLevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceFilteringPass.NativeMethodInfoPtr_EncodeLowerMip_Private_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Single_Vector4_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930331, XrefRangeEnd = 930335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceFilteringPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 930365, RefRangeEnd = 930367, XrefRangeStart = 930335, XrefRangeEnd = 930365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    float radianceSourceLimit,
    Vector4 depthProjectionParams,
    Vector2Int outputMipmapSize,
    int outputMipmapLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radianceSourceLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &outputMipmapSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &outputMipmapLevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceFilteringPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Single_Vector4_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputRadianceMap
  {
    get
    {
      int inputRadianceMap;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputRadianceMap, (void*) &inputRadianceMap);
      return inputRadianceMap;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputRadianceMap, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputSceneNormal
  {
    get
    {
      int inputSceneNormal;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputSceneNormal, (void*) &inputSceneNormal);
      return inputSceneNormal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputSceneNormal, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputSceneDepth
  {
    get
    {
      int texInputSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputSceneDepth, (void*) &texInputSceneDepth);
      return texInputSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexInputSceneDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexMinHIZ
  {
    get
    {
      int kSidTexMinHiz;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &kSidTexMinHiz);
      return kSidTexMinHiz;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutputRadianceMap
  {
    get
    {
      int outputRadianceMap;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexOutputRadianceMap, (void*) &outputRadianceMap);
      return outputRadianceMap;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexOutputRadianceMap, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutputNormal
  {
    get
    {
      int sidTexOutputNormal;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexOutputNormal, (void*) &sidTexOutputNormal);
      return sidTexOutputNormal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceFilteringPass.NativeFieldInfoPtr_kSidTexOutputNormal, (void*) &value);
    }
  }

  public unsafe CBuffer<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>) null : Il2CppObjectPool.Get<CBuffer<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernelMip0
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__kernelMip0));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__kernelMip0)) = value;
    }
  }

  public unsafe int _kernelLowerMips
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__kernelLowerMips));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceFilteringPass.NativeFieldInfoPtr__kernelLowerMips)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct RadianceSourceFilteringCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputTc2Uv;
    private static readonly System.IntPtr NativeFieldInfoPtr_outputMipmapLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_radianceLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthProjectionParams;
    [FieldOffset(0)]
    public Vector4 texOutputTc2Uv;
    [FieldOffset(16 /*0x10*/)]
    public float outputMipmapLevel;
    [FieldOffset(20)]
    public float radianceLimit;
    [FieldOffset(24)]
    public Vector2 padding;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 depthProjectionParams;

    static RadianceSourceFilteringCBufferData()
    {
      Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadianceSourceFilteringPass>.NativeClassPtr, nameof (RadianceSourceFilteringCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr);
      RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData.NativeFieldInfoPtr_texOutputTc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr, nameof (texOutputTc2Uv));
      RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData.NativeFieldInfoPtr_outputMipmapLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr, nameof (outputMipmapLevel));
      RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData.NativeFieldInfoPtr_radianceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr, nameof (radianceLimit));
      RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr, nameof (padding));
      RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData.NativeFieldInfoPtr_depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr, nameof (depthProjectionParams));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RadianceSourceFilteringPass.RadianceSourceFilteringCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
