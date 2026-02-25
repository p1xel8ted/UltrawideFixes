// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SsdoEstimatePass
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

public sealed class SsdoEstimatePass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSampleBaseRotationCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexRadianceMapPrev;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneNormalPrev;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMinHIZ;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutputGlobalIllumination;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexAmbientVisibility;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbufferSsdo;
  private static readonly System.IntPtr NativeFieldInfoPtr__texBlankSceneNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__sampleBaseRotations;
  private static readonly System.IntPtr NativeFieldInfoPtr__currSamleRotationIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector2Int_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static SsdoEstimatePass()
  {
    Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SsdoEstimatePass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr);
    SsdoEstimatePass.NativeFieldInfoPtr_kSampleBaseRotationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (kSampleBaseRotationCount));
    SsdoEstimatePass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (kGroupSize));
    SsdoEstimatePass.NativeFieldInfoPtr_kSidTexRadianceMapPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (kSidTexRadianceMapPrev));
    SsdoEstimatePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (kSidTexSceneNormalPrev));
    SsdoEstimatePass.NativeFieldInfoPtr_kSidTexMinHIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (kSidTexMinHIZ));
    SsdoEstimatePass.NativeFieldInfoPtr_kSidTexOutputGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (kSidTexOutputGlobalIllumination));
    SsdoEstimatePass.NativeFieldInfoPtr_kSidTexAmbientVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (kSidTexAmbientVisibility));
    SsdoEstimatePass.NativeFieldInfoPtr__cbufferSsdo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (_cbufferSsdo));
    SsdoEstimatePass.NativeFieldInfoPtr__texBlankSceneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (_texBlankSceneNormal));
    SsdoEstimatePass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (_compute));
    SsdoEstimatePass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (_kernel));
    SsdoEstimatePass.NativeFieldInfoPtr__sampleBaseRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (_sampleBaseRotations));
    SsdoEstimatePass.NativeFieldInfoPtr__currSamleRotationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (_currSamleRotationIndex));
    SsdoEstimatePass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, 100663891);
    SsdoEstimatePass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, 100663892);
    SsdoEstimatePass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector2Int_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, 100663893);
    SsdoEstimatePass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, 100663894);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930438, RefRangeEnd = 930439, XrefRangeStart = 930422, XrefRangeEnd = 930438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SsdoEstimatePass(ComputeShader compute, Texture2D texBlankSceneNormal)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texBlankSceneNormal);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsdoEstimatePass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930482, RefRangeEnd = 930483, XrefRangeStart = 930439, XrefRangeEnd = 930482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texRadianceMapPrev,
    RenderTextureResource texSceneNormalPrev,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texOutputGlobalIllumination,
    RenderTextureResource texAmbientVisibility,
    [In] ref FrameRenderingParams frp,
    [In] ref Matrix4x4 prevProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texRadianceMapPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneNormalPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputGlobalIllumination));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texAmbientVisibility));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsdoEstimatePass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930490, RefRangeEnd = 930491, XrefRangeStart = 930483, XrefRangeEnd = 930490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    Vector2Int texSize,
    [In] ref Matrix4x4 prevProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &texSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsdoEstimatePass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector2Int_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930495, RefRangeEnd = 930496, XrefRangeStart = 930491, XrefRangeEnd = 930495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsdoEstimatePass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSampleBaseRotationCount
  {
    get
    {
      int baseRotationCount;
      IL2CPP.il2cpp_field_static_get_value(SsdoEstimatePass.NativeFieldInfoPtr_kSampleBaseRotationCount, (void*) &baseRotationCount);
      return baseRotationCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoEstimatePass.NativeFieldInfoPtr_kSampleBaseRotationCount, (void*) &value);
    }
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(SsdoEstimatePass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoEstimatePass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexRadianceMapPrev
  {
    get
    {
      int texRadianceMapPrev;
      IL2CPP.il2cpp_field_static_get_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexRadianceMapPrev, (void*) &texRadianceMapPrev);
      return texRadianceMapPrev;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexRadianceMapPrev, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneNormalPrev
  {
    get
    {
      int texSceneNormalPrev;
      IL2CPP.il2cpp_field_static_get_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev, (void*) &texSceneNormalPrev);
      return texSceneNormalPrev;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev, (void*) &value);
    }
  }

  public static unsafe int kSidTexMinHIZ
  {
    get
    {
      int kSidTexMinHiz;
      IL2CPP.il2cpp_field_static_get_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &kSidTexMinHiz);
      return kSidTexMinHiz;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutputGlobalIllumination
  {
    get
    {
      int globalIllumination;
      IL2CPP.il2cpp_field_static_get_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexOutputGlobalIllumination, (void*) &globalIllumination);
      return globalIllumination;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexOutputGlobalIllumination, (void*) &value);
    }
  }

  public static unsafe int kSidTexAmbientVisibility
  {
    get
    {
      int ambientVisibility;
      IL2CPP.il2cpp_field_static_get_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexAmbientVisibility, (void*) &ambientVisibility);
      return ambientVisibility;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoEstimatePass.NativeFieldInfoPtr_kSidTexAmbientVisibility, (void*) &value);
    }
  }

  public unsafe CBuffer<SsdoEstimatePass.SsdoEstimateCBufferData> _cbufferSsdo
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__cbufferSsdo));
      return num == System.IntPtr.Zero ? (CBuffer<SsdoEstimatePass.SsdoEstimateCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SsdoEstimatePass.SsdoEstimateCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__cbufferSsdo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D _texBlankSceneNormal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__texBlankSceneNormal));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__texBlankSceneNormal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> _sampleBaseRotations
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__sampleBaseRotations));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__sampleBaseRotations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _currSamleRotationIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__currSamleRotationIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoEstimatePass.NativeFieldInfoPtr__currSamleRotationIndex)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SsdoEstimateCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texelCoordToUv;
    private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_prevNonJitteredProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_sampleBaseRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_radisuPixels;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxOccluderDistance2Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_avContrast;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraPositionWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraForwardWs;
    [FieldOffset(0)]
    public Vector4 texelCoordToUv;
    [FieldOffset(16 /*0x10*/)]
    public Matrix4x4 invProjectionViewMatrix;
    [FieldOffset(80 /*0x50*/)]
    public Matrix4x4 prevNonJitteredProjectionViewMatrix;
    [FieldOffset(144 /*0x90*/)]
    public float sampleBaseRotation;
    [FieldOffset(148)]
    public float radisuPixels;
    [FieldOffset(152)]
    public float maxOccluderDistance2Ws;
    [FieldOffset(156)]
    public float avContrast;
    [FieldOffset(160 /*0xA0*/)]
    public Vector4 cameraPositionWs;
    [FieldOffset(176 /*0xB0*/)]
    public Vector4 cameraForwardWs;

    static SsdoEstimateCBufferData()
    {
      Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SsdoEstimatePass>.NativeClassPtr, nameof (SsdoEstimateCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr);
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_texelCoordToUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (texelCoordToUv));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_invProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (invProjectionViewMatrix));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_prevNonJitteredProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (prevNonJitteredProjectionViewMatrix));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_sampleBaseRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (sampleBaseRotation));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_radisuPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (radisuPixels));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_maxOccluderDistance2Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (maxOccluderDistance2Ws));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_avContrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (avContrast));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_cameraPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (cameraPositionWs));
      SsdoEstimatePass.SsdoEstimateCBufferData.NativeFieldInfoPtr_cameraForwardWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, nameof (cameraForwardWs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SsdoEstimatePass.SsdoEstimateCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
