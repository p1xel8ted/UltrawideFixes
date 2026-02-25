// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GITemporalPass
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

public sealed class GITemporalPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMinHIZ;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputGI;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexGlobalIlluminationPrev;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexGlobalIlluminationResult;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeDiffuse_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeSpecular_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Private_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_Matrix4x4_byref_Matrix4x4_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GITemporalPass()
  {
    Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GITemporalPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr);
    GITemporalPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (kGroupSize));
    GITemporalPass.NativeFieldInfoPtr_kSidTexMinHIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (kSidTexMinHIZ));
    GITemporalPass.NativeFieldInfoPtr_kSidTexInputGI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (kSidTexInputGI));
    GITemporalPass.NativeFieldInfoPtr_kSidTexGlobalIlluminationPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (kSidTexGlobalIlluminationPrev));
    GITemporalPass.NativeFieldInfoPtr_kSidTexGlobalIlluminationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (kSidTexGlobalIlluminationResult));
    GITemporalPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (_compute));
    GITemporalPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (_kernel));
    GITemporalPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (_cbuffer));
    GITemporalPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, 100663863);
    GITemporalPass.NativeMethodInfoPtr_EncodeDiffuse_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, 100663864);
    GITemporalPass.NativeMethodInfoPtr_EncodeSpecular_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, 100663865);
    GITemporalPass.NativeMethodInfoPtr_Encode_Private_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, 100663866);
    GITemporalPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_Matrix4x4_byref_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, 100663867);
    GITemporalPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, 100663868);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929944, XrefRangeEnd = 929956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GITemporalPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GITemporalPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929956, XrefRangeEnd = 929957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeDiffuse(
    CommandBuffer cmd,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texSpecularGI,
    RenderTextureResource texGlobalIlluminationPrev,
    RenderTextureResource texGlobalIllumination,
    [In] ref Matrix4x4 invProjectionViewMatrix,
    [In] ref Matrix4x4 prevProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSpecularGI));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texGlobalIlluminationPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texGlobalIllumination));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GITemporalPass.NativeMethodInfoPtr_EncodeDiffuse_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929957, XrefRangeEnd = 929958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeSpecular(
    CommandBuffer cmd,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texSpecularGI,
    RenderTextureResource texGlobalIlluminationPrev,
    RenderTextureResource texGlobalIllumination,
    [In] ref Matrix4x4 invProjectionViewMatrix,
    [In] ref Matrix4x4 prevProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSpecularGI));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texGlobalIlluminationPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texGlobalIllumination));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GITemporalPass.NativeMethodInfoPtr_EncodeSpecular_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 929988, RefRangeEnd = 929992, XrefRangeStart = 929958, XrefRangeEnd = 929988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texInputGI,
    RenderTextureResource texGlobalIlluminationPrev,
    RenderTextureResource texGlobalIllumination,
    [In] ref Matrix4x4 invProjectionViewMatrix,
    [In] ref Matrix4x4 prevProjectionViewMatrix,
    bool diffuseGIFlag)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputGI));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texGlobalIlluminationPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texGlobalIllumination));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevProjectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &diffuseGIFlag;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GITemporalPass.NativeMethodInfoPtr_Encode_Private_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_Matrix4x4_byref_Matrix4x4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929992, XrefRangeEnd = 930014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    Vector2Int texSize,
    [In] ref Matrix4x4 invProjectionViewMatrix,
    [In] ref Matrix4x4 prevProjectionViewMatrix,
    bool diffuseFlag)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref invProjectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevProjectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &diffuseFlag;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GITemporalPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_Matrix4x4_byref_Matrix4x4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930014, XrefRangeEnd = 930018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GITemporalPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(GITemporalPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GITemporalPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexMinHIZ
  {
    get
    {
      int kSidTexMinHiz;
      IL2CPP.il2cpp_field_static_get_value(GITemporalPass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &kSidTexMinHiz);
      return kSidTexMinHiz;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GITemporalPass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputGI
  {
    get
    {
      int kSidTexInputGi;
      IL2CPP.il2cpp_field_static_get_value(GITemporalPass.NativeFieldInfoPtr_kSidTexInputGI, (void*) &kSidTexInputGi);
      return kSidTexInputGi;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GITemporalPass.NativeFieldInfoPtr_kSidTexInputGI, (void*) &value);
    }
  }

  public static unsafe int kSidTexGlobalIlluminationPrev
  {
    get
    {
      int illuminationPrev;
      IL2CPP.il2cpp_field_static_get_value(GITemporalPass.NativeFieldInfoPtr_kSidTexGlobalIlluminationPrev, (void*) &illuminationPrev);
      return illuminationPrev;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GITemporalPass.NativeFieldInfoPtr_kSidTexGlobalIlluminationPrev, (void*) &value);
    }
  }

  public static unsafe int kSidTexGlobalIlluminationResult
  {
    get
    {
      int illuminationResult;
      IL2CPP.il2cpp_field_static_get_value(GITemporalPass.NativeFieldInfoPtr_kSidTexGlobalIlluminationResult, (void*) &illuminationResult);
      return illuminationResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GITemporalPass.NativeFieldInfoPtr_kSidTexGlobalIlluminationResult, (void*) &value);
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GITemporalPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GITemporalPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GITemporalPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GITemporalPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  public unsafe CBuffer<GITemporalPass.GiTemporalCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GITemporalPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GITemporalPass.GiTemporalCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GITemporalPass.GiTemporalCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GITemporalPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GiTemporalCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputTc2Uv;
    private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_prevProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_diffuseFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector4 texOutputTc2Uv;
    [FieldOffset(16 /*0x10*/)]
    public Matrix4x4 invProjectionViewMatrix;
    [FieldOffset(80 /*0x50*/)]
    public Matrix4x4 prevProjectionViewMatrix;
    [FieldOffset(144 /*0x90*/)]
    public float diffuseFlag;
    [FieldOffset(148)]
    public Vector3 padding;

    static GiTemporalCBufferData()
    {
      Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GITemporalPass>.NativeClassPtr, nameof (GiTemporalCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr);
      GITemporalPass.GiTemporalCBufferData.NativeFieldInfoPtr_texOutputTc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr, nameof (texOutputTc2Uv));
      GITemporalPass.GiTemporalCBufferData.NativeFieldInfoPtr_invProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr, nameof (invProjectionViewMatrix));
      GITemporalPass.GiTemporalCBufferData.NativeFieldInfoPtr_prevProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr, nameof (prevProjectionViewMatrix));
      GITemporalPass.GiTemporalCBufferData.NativeFieldInfoPtr_diffuseFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr, nameof (diffuseFlag));
      GITemporalPass.GiTemporalCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GITemporalPass.GiTemporalCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
