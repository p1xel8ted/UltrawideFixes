// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.BloomPass
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

public sealed class BloomPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kDownsampleMipmapCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kUpsampleMipmapCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidBloomThresholdCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputLowRes;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidUpscaleParams;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexelScaleUVOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr__prefilterCompute;
  private static readonly System.IntPtr NativeFieldInfoPtr__prefilterKernelHdr;
  private static readonly System.IntPtr NativeFieldInfoPtr__prefilterKernelLdr;
  private static readonly System.IntPtr NativeFieldInfoPtr__blurCompute;
  private static readonly System.IntPtr NativeFieldInfoPtr__downsampleKernelHdr;
  private static readonly System.IntPtr NativeFieldInfoPtr__downsampleKernelLdr;
  private static readonly System.IntPtr NativeFieldInfoPtr__upsampleKernelHdr;
  private static readonly System.IntPtr NativeFieldInfoPtr__upsampleKernelLdr;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateTexelScaleUVOffsetParams_Private_Static_Vector4_byref_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeDispatchCompute_Private_Static_Void_CommandBuffer_ComputeShader_Int32_byref_RenderTextureResource_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_BloomParams_byref_RenderTextureResource_BloomTexturePyramid_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static BloomPass()
  {
    Il2CppClassPointerStore<BloomPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (BloomPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomPass>.NativeClassPtr);
    BloomPass.NativeFieldInfoPtr_kDownsampleMipmapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kDownsampleMipmapCount));
    BloomPass.NativeFieldInfoPtr_kUpsampleMipmapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kUpsampleMipmapCount));
    BloomPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kGroupSize));
    BloomPass.NativeFieldInfoPtr_kSidBloomThresholdCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kSidBloomThresholdCurve));
    BloomPass.NativeFieldInfoPtr_kSidTexInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kSidTexInput));
    BloomPass.NativeFieldInfoPtr_kSidTexInputLowRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kSidTexInputLowRes));
    BloomPass.NativeFieldInfoPtr_kSidTexOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kSidTexOutput));
    BloomPass.NativeFieldInfoPtr_kSidUpscaleParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kSidUpscaleParams));
    BloomPass.NativeFieldInfoPtr_kSidTexelScaleUVOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (kSidTexelScaleUVOffset));
    BloomPass.NativeFieldInfoPtr__prefilterCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_prefilterCompute));
    BloomPass.NativeFieldInfoPtr__prefilterKernelHdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_prefilterKernelHdr));
    BloomPass.NativeFieldInfoPtr__prefilterKernelLdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_prefilterKernelLdr));
    BloomPass.NativeFieldInfoPtr__blurCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_blurCompute));
    BloomPass.NativeFieldInfoPtr__downsampleKernelHdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_downsampleKernelHdr));
    BloomPass.NativeFieldInfoPtr__downsampleKernelLdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_downsampleKernelLdr));
    BloomPass.NativeFieldInfoPtr__upsampleKernelHdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_upsampleKernelHdr));
    BloomPass.NativeFieldInfoPtr__upsampleKernelLdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, nameof (_upsampleKernelLdr));
    BloomPass.NativeMethodInfoPtr_CreateTexelScaleUVOffsetParams_Private_Static_Vector4_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, 100664077 /*0x0600030D*/);
    BloomPass.NativeMethodInfoPtr_EncodeDispatchCompute_Private_Static_Void_CommandBuffer_ComputeShader_Int32_byref_RenderTextureResource_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, 100664078 /*0x0600030E*/);
    BloomPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, 100664079 /*0x0600030F*/);
    BloomPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_BloomParams_byref_RenderTextureResource_BloomTexturePyramid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, 100664080 /*0x06000310*/);
    BloomPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomPass>.NativeClassPtr, 100664081);
  }

  [CallerCount(0)]
  public static unsafe Vector4 CreateTexelScaleUVOffsetParams([In] ref Vector2Int textureSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref textureSize
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomPass.NativeMethodInfoPtr_CreateTexelScaleUVOffsetParams_Private_Static_Vector4_byref_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 932474, RefRangeEnd = 932477, XrefRangeStart = 932455, XrefRangeEnd = 932474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EncodeDispatchCompute(
    CommandBuffer cmd,
    ComputeShader cs,
    int kernel,
    [In] ref RenderTextureResource texInput,
    [In] ref RenderTextureResource texOutput)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInput);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutput);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomPass.NativeMethodInfoPtr_EncodeDispatchCompute_Private_Static_Void_CommandBuffer_ComputeShader_Int32_byref_RenderTextureResource_byref_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932496, RefRangeEnd = 932498, XrefRangeStart = 932477, XrefRangeEnd = 932496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BloomPass(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932548, RefRangeEnd = 932550, XrefRangeStart = 932498, XrefRangeEnd = 932548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref BloomParams bloom,
    [In] ref RenderTextureResource texColor,
    BloomTexturePyramid bloomTexturePyramid,
    bool colorIsHdr)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bloom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bloomTexturePyramid);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &colorIsHdr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_BloomParams_byref_RenderTextureResource_BloomTexturePyramid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kDownsampleMipmapCount
  {
    get
    {
      int downsampleMipmapCount;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kDownsampleMipmapCount, (void*) &downsampleMipmapCount);
      return downsampleMipmapCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kDownsampleMipmapCount, (void*) &value);
    }
  }

  public static unsafe int kUpsampleMipmapCount
  {
    get
    {
      int upsampleMipmapCount;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kUpsampleMipmapCount, (void*) &upsampleMipmapCount);
      return upsampleMipmapCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kUpsampleMipmapCount, (void*) &value);
    }
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidBloomThresholdCurve
  {
    get
    {
      int bloomThresholdCurve;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kSidBloomThresholdCurve, (void*) &bloomThresholdCurve);
      return bloomThresholdCurve;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kSidBloomThresholdCurve, (void*) &value);
    }
  }

  public static unsafe int kSidTexInput
  {
    get
    {
      int kSidTexInput;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kSidTexInput, (void*) &kSidTexInput);
      return kSidTexInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kSidTexInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputLowRes
  {
    get
    {
      int sidTexInputLowRes;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kSidTexInputLowRes, (void*) &sidTexInputLowRes);
      return sidTexInputLowRes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kSidTexInputLowRes, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutput
  {
    get
    {
      int kSidTexOutput;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &kSidTexOutput);
      return kSidTexOutput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &value);
    }
  }

  public static unsafe int kSidUpscaleParams
  {
    get
    {
      int sidUpscaleParams;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kSidUpscaleParams, (void*) &sidUpscaleParams);
      return sidUpscaleParams;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kSidUpscaleParams, (void*) &value);
    }
  }

  public static unsafe int kSidTexelScaleUVOffset
  {
    get
    {
      int texelScaleUvOffset;
      IL2CPP.il2cpp_field_static_get_value(BloomPass.NativeFieldInfoPtr_kSidTexelScaleUVOffset, (void*) &texelScaleUvOffset);
      return texelScaleUvOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomPass.NativeFieldInfoPtr_kSidTexelScaleUVOffset, (void*) &value);
    }
  }

  public unsafe ComputeShader _prefilterCompute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__prefilterCompute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__prefilterCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _prefilterKernelHdr
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__prefilterKernelHdr));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__prefilterKernelHdr)) = value;
    }
  }

  public unsafe int _prefilterKernelLdr
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__prefilterKernelLdr));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__prefilterKernelLdr)) = value;
    }
  }

  public unsafe ComputeShader _blurCompute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__blurCompute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__blurCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _downsampleKernelHdr
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__downsampleKernelHdr));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__downsampleKernelHdr)) = value;
    }
  }

  public unsafe int _downsampleKernelLdr
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__downsampleKernelLdr));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__downsampleKernelLdr)) = value;
    }
  }

  public unsafe int _upsampleKernelHdr
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__upsampleKernelHdr));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__upsampleKernelHdr)) = value;
    }
  }

  public unsafe int _upsampleKernelLdr
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__upsampleKernelLdr));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomPass.NativeFieldInfoPtr__upsampleKernelLdr)) = value;
    }
  }
}
