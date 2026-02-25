// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DownsampleSceneDataPass
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

public sealed class DownsampleSceneDataPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexRadainceMapResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneNormalResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneLinearRoughness;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneLinearRoughnessResult;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__radianceSourceGenerationPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__gaussianWeights;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelDownsampleNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr__radianceSourceFilteringPass;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexTempColorQuarterRes_Private_Static_RenderTextureResource_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_ComputeShader_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static DownsampleSceneDataPass()
  {
    Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DownsampleSceneDataPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr);
    DownsampleSceneDataPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (kGroupSize));
    DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (kSidTexSceneColor));
    DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexRadainceMapResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (kSidTexRadainceMapResult));
    DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (kSidTexSceneNormal));
    DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneNormalResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (kSidTexSceneNormalResult));
    DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneLinearRoughness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (kSidTexSceneLinearRoughness));
    DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneLinearRoughnessResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (kSidTexSceneLinearRoughnessResult));
    DownsampleSceneDataPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (_cbuffer));
    DownsampleSceneDataPass.NativeFieldInfoPtr__radianceSourceGenerationPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (_radianceSourceGenerationPass));
    DownsampleSceneDataPass.NativeFieldInfoPtr__gaussianWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (_gaussianWeights));
    DownsampleSceneDataPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (_compute));
    DownsampleSceneDataPass.NativeFieldInfoPtr__kernelDownsampleNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (_kernelDownsampleNormal));
    DownsampleSceneDataPass.NativeFieldInfoPtr__radianceSourceFilteringPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (_radianceSourceFilteringPass));
    DownsampleSceneDataPass.NativeMethodInfoPtr_MakeTexTempColorQuarterRes_Private_Static_RenderTextureResource_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, 100663857);
    DownsampleSceneDataPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_ComputeShader_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, 100663858);
    DownsampleSceneDataPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, 100663859);
    DownsampleSceneDataPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, 100663860);
    DownsampleSceneDataPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, 100663861);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929828, XrefRangeEnd = 929836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexTempColorQuarterRes(
    RenderTextureDescriptor texRadianceMapDesc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &texRadianceMapDesc
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DownsampleSceneDataPass.NativeMethodInfoPtr_MakeTexTempColorQuarterRes_Private_Static_RenderTextureResource_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929877, RefRangeEnd = 929878, XrefRangeStart = 929836, XrefRangeEnd = 929877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DownsampleSceneDataPass(
    ComputeShader downsampleCompute,
    ComputeShader radianceSourceGenerationCompute,
    ComputeShader radianceSourceFilteringCompute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) downsampleCompute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) radianceSourceGenerationCompute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) radianceSourceFilteringCompute);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleSceneDataPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_ComputeShader_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929878, XrefRangeEnd = 929887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleSceneDataPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 929906, RefRangeEnd = 929909, XrefRangeStart = 929887, XrefRangeEnd = 929906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(CommandBuffer cmd, SceneFrame frame, [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleSceneDataPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929943, RefRangeEnd = 929944, XrefRangeStart = 929909, XrefRangeEnd = 929943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleSceneDataPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneColor
  {
    get
    {
      int sidTexSceneColor;
      IL2CPP.il2cpp_field_static_get_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneColor, (void*) &sidTexSceneColor);
      return sidTexSceneColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexRadainceMapResult
  {
    get
    {
      int radainceMapResult;
      IL2CPP.il2cpp_field_static_get_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexRadainceMapResult, (void*) &radainceMapResult);
      return radainceMapResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexRadainceMapResult, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneNormal
  {
    get
    {
      int sidTexSceneNormal;
      IL2CPP.il2cpp_field_static_get_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneNormal, (void*) &sidTexSceneNormal);
      return sidTexSceneNormal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneNormal, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneNormalResult
  {
    get
    {
      int sceneNormalResult;
      IL2CPP.il2cpp_field_static_get_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneNormalResult, (void*) &sceneNormalResult);
      return sceneNormalResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneNormalResult, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneLinearRoughness
  {
    get
    {
      int sceneLinearRoughness;
      IL2CPP.il2cpp_field_static_get_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneLinearRoughness, (void*) &sceneLinearRoughness);
      return sceneLinearRoughness;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneLinearRoughness, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneLinearRoughnessResult
  {
    get
    {
      int linearRoughnessResult;
      IL2CPP.il2cpp_field_static_get_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneLinearRoughnessResult, (void*) &linearRoughnessResult);
      return linearRoughnessResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleSceneDataPass.NativeFieldInfoPtr_kSidTexSceneLinearRoughnessResult, (void*) &value);
    }
  }

  public unsafe CBuffer<DownsampleSceneDataPass.DownsampleSceneDataCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<DownsampleSceneDataPass.DownsampleSceneDataCBufferData>) null : Il2CppObjectPool.Get<CBuffer<DownsampleSceneDataPass.DownsampleSceneDataCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RadianceSourceGenerationPass _radianceSourceGenerationPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__radianceSourceGenerationPass));
      return num == System.IntPtr.Zero ? (RadianceSourceGenerationPass) null : Il2CppObjectPool.Get<RadianceSourceGenerationPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__radianceSourceGenerationPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<RadianceSourceGenerationPass.Weights> _gaussianWeights
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__gaussianWeights));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RadianceSourceGenerationPass.Weights>) null : Il2CppObjectPool.Get<Il2CppStructArray<RadianceSourceGenerationPass.Weights>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__gaussianWeights), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernelDownsampleNormal
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__kernelDownsampleNormal));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__kernelDownsampleNormal)) = value;
    }
  }

  public unsafe RadianceSourceFilteringPass _radianceSourceFilteringPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__radianceSourceFilteringPass));
      return num == System.IntPtr.Zero ? (RadianceSourceFilteringPass) null : Il2CppObjectPool.Get<RadianceSourceFilteringPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DownsampleSceneDataPass.NativeFieldInfoPtr__radianceSourceFilteringPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DownsampleSceneDataCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputTc2Uv;
    [FieldOffset(0)]
    public Vector4 texOutputTc2Uv;

    static DownsampleSceneDataCBufferData()
    {
      Il2CppClassPointerStore<DownsampleSceneDataPass.DownsampleSceneDataCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DownsampleSceneDataPass>.NativeClassPtr, nameof (DownsampleSceneDataCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownsampleSceneDataPass.DownsampleSceneDataCBufferData>.NativeClassPtr);
      DownsampleSceneDataPass.DownsampleSceneDataCBufferData.NativeFieldInfoPtr_texOutputTc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleSceneDataPass.DownsampleSceneDataCBufferData>.NativeClassPtr, nameof (texOutputTc2Uv));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownsampleSceneDataPass.DownsampleSceneDataCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
