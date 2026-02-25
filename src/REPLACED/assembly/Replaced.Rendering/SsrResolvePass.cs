// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SsrResolvePass
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

public sealed class SsrResolvePass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTemporalJitterSampleCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexRadianceMapPrev;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneNormalPrev;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMinHIZ;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexHitInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexAmbientVisibility;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutputGlobalIllumination;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__texBlankSceneNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__currentTemporalIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_FrameRenderingParams_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static SsrResolvePass()
  {
    Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SsrResolvePass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr);
    SsrResolvePass.NativeFieldInfoPtr_kTemporalJitterSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kTemporalJitterSampleCount));
    SsrResolvePass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kGroupSize));
    SsrResolvePass.NativeFieldInfoPtr_kSidTexRadianceMapPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kSidTexRadianceMapPrev));
    SsrResolvePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kSidTexSceneNormalPrev));
    SsrResolvePass.NativeFieldInfoPtr_kSidTexMinHIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kSidTexMinHIZ));
    SsrResolvePass.NativeFieldInfoPtr_kSidTexHitInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kSidTexHitInfo));
    SsrResolvePass.NativeFieldInfoPtr_kSidTexAmbientVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kSidTexAmbientVisibility));
    SsrResolvePass.NativeFieldInfoPtr_kSidTexOutputGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (kSidTexOutputGlobalIllumination));
    SsrResolvePass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (_compute));
    SsrResolvePass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (_kernel));
    SsrResolvePass.NativeFieldInfoPtr__texBlankSceneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (_texBlankSceneNormal));
    SsrResolvePass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (_cbuffer));
    SsrResolvePass.NativeFieldInfoPtr__currentTemporalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (_currentTemporalIndex));
    SsrResolvePass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, 100663906);
    SsrResolvePass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, 100663907);
    SsrResolvePass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_FrameRenderingParams_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, 100663908);
    SsrResolvePass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, 100663909);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930648, RefRangeEnd = 930649, XrefRangeStart = 930636, XrefRangeEnd = 930648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SsrResolvePass(ComputeShader compute, Texture2D texBlankSceneNormal)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texBlankSceneNormal);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrResolvePass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930694, RefRangeEnd = 930695, XrefRangeStart = 930649, XrefRangeEnd = 930694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texRadianceMapPrev,
    RenderTextureResource texSceneNormalPrev,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texHitInfo,
    RenderTextureResource texAmbientVisibility,
    RenderTextureResource texOutputGlobalIllumination,
    [In] ref FrameRenderingParams frp,
    [In] ref Matrix4x4 prevNonJitteredProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texRadianceMapPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneNormalPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texHitInfo));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texAmbientVisibility));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputGlobalIllumination));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevNonJitteredProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrResolvePass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930705, RefRangeEnd = 930706, XrefRangeStart = 930695, XrefRangeEnd = 930705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    Vector2Int texSize,
    [In] ref FrameRenderingParams frp,
    [In] ref Matrix4x4 prevNonJitteredProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevNonJitteredProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrResolvePass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_FrameRenderingParams_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930710, RefRangeEnd = 930711, XrefRangeStart = 930706, XrefRangeEnd = 930710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrResolvePass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe uint kTemporalJitterSampleCount
  {
    get
    {
      uint jitterSampleCount;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kTemporalJitterSampleCount, (void*) &jitterSampleCount);
      return jitterSampleCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kTemporalJitterSampleCount, (void*) &value);
    }
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexRadianceMapPrev
  {
    get
    {
      int texRadianceMapPrev;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexRadianceMapPrev, (void*) &texRadianceMapPrev);
      return texRadianceMapPrev;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexRadianceMapPrev, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneNormalPrev
  {
    get
    {
      int texSceneNormalPrev;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev, (void*) &texSceneNormalPrev);
      return texSceneNormalPrev;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev, (void*) &value);
    }
  }

  public static unsafe int kSidTexMinHIZ
  {
    get
    {
      int kSidTexMinHiz;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &kSidTexMinHiz);
      return kSidTexMinHiz;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &value);
    }
  }

  public static unsafe int kSidTexHitInfo
  {
    get
    {
      int kSidTexHitInfo;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexHitInfo, (void*) &kSidTexHitInfo);
      return kSidTexHitInfo;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexHitInfo, (void*) &value);
    }
  }

  public static unsafe int kSidTexAmbientVisibility
  {
    get
    {
      int ambientVisibility;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexAmbientVisibility, (void*) &ambientVisibility);
      return ambientVisibility;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexAmbientVisibility, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutputGlobalIllumination
  {
    get
    {
      int globalIllumination;
      IL2CPP.il2cpp_field_static_get_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexOutputGlobalIllumination, (void*) &globalIllumination);
      return globalIllumination;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrResolvePass.NativeFieldInfoPtr_kSidTexOutputGlobalIllumination, (void*) &value);
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  public unsafe Texture2D _texBlankSceneNormal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__texBlankSceneNormal));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__texBlankSceneNormal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<SsrResolvePass.SsrResolveCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<SsrResolvePass.SsrResolveCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SsrResolvePass.SsrResolveCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe uint _currentTemporalIndex
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__currentTemporalIndex));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrResolvePass.NativeFieldInfoPtr__currentTemporalIndex)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SsrResolveCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputTc2Uv;
    private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_prevProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_temporalIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_fadeDistance2Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_screenEdgeFade;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraPositionWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_leftColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_rightColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_topColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_frontColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_backColor;
    [FieldOffset(0)]
    public Vector4 texOutputTc2Uv;
    [FieldOffset(16 /*0x10*/)]
    public Matrix4x4 invProjectionViewMatrix;
    [FieldOffset(80 /*0x50*/)]
    public Matrix4x4 prevProjectionViewMatrix;
    [FieldOffset(144 /*0x90*/)]
    public uint temporalIndex;
    [FieldOffset(148)]
    public float fadeDistance2Ws;
    [FieldOffset(152)]
    public Vector2 screenEdgeFade;
    [FieldOffset(160 /*0xA0*/)]
    public Vector4 cameraPositionWs;
    [FieldOffset(176 /*0xB0*/)]
    public Vector4 leftColor;
    [FieldOffset(192 /*0xC0*/)]
    public Vector4 rightColor;
    [FieldOffset(208 /*0xD0*/)]
    public Vector4 bottomColor;
    [FieldOffset(224 /*0xE0*/)]
    public Vector4 topColor;
    [FieldOffset(240 /*0xF0*/)]
    public Vector4 frontColor;
    [FieldOffset(256 /*0x0100*/)]
    public Vector4 backColor;

    static SsrResolveCBufferData()
    {
      Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SsrResolvePass>.NativeClassPtr, nameof (SsrResolveCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr);
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_texOutputTc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (texOutputTc2Uv));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_invProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (invProjectionViewMatrix));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_prevProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (prevProjectionViewMatrix));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_temporalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (temporalIndex));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_fadeDistance2Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (fadeDistance2Ws));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_screenEdgeFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (screenEdgeFade));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_cameraPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (cameraPositionWs));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_leftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (leftColor));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_rightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (rightColor));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (bottomColor));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (topColor));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_frontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (frontColor));
      SsrResolvePass.SsrResolveCBufferData.NativeFieldInfoPtr_backColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, nameof (backColor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SsrResolvePass.SsrResolveCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
