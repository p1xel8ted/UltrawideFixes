// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SsrTracePass
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

public sealed class SsrTracePass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneNormalPrev;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMinHIZ;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexHitInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__texBlankSceneNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbufferHIZ;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbufferSsr;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeScreenEdgeFade_Public_Static_Vector2_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeAabbUv_Private_Static_Vector2_FrameRenderingParams_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector2Int_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static SsrTracePass()
  {
    Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SsrTracePass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr);
    SsrTracePass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (kGroupSize));
    SsrTracePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (kSidTexSceneNormalPrev));
    SsrTracePass.NativeFieldInfoPtr_kSidTexMinHIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (kSidTexMinHIZ));
    SsrTracePass.NativeFieldInfoPtr_kSidTexHitInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (kSidTexHitInfo));
    SsrTracePass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (_compute));
    SsrTracePass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (_kernel));
    SsrTracePass.NativeFieldInfoPtr__texBlankSceneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (_texBlankSceneNormal));
    SsrTracePass.NativeFieldInfoPtr__cbufferHIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (_cbufferHIZ));
    SsrTracePass.NativeFieldInfoPtr__cbufferSsr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (_cbufferSsr));
    SsrTracePass.NativeMethodInfoPtr_MakeScreenEdgeFade_Public_Static_Vector2_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, 100663911);
    SsrTracePass.NativeMethodInfoPtr_MakeAabbUv_Private_Static_Vector2_FrameRenderingParams_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, 100663912);
    SsrTracePass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, 100663913);
    SsrTracePass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, 100663914);
    SsrTracePass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector2Int_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, 100663915);
    SsrTracePass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, 100663916);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930711, XrefRangeEnd = 930715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 MakeScreenEdgeFade(FrameRenderingParams frp)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SsrTracePass.NativeMethodInfoPtr_MakeScreenEdgeFade_Public_Static_Vector2_FrameRenderingParams_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 930721, RefRangeEnd = 930723, XrefRangeStart = 930715, XrefRangeEnd = 930721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 MakeAabbUv(FrameRenderingParams frp, Vector3 pWs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pWs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SsrTracePass.NativeMethodInfoPtr_MakeAabbUv_Private_Static_Vector2_FrameRenderingParams_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930743, RefRangeEnd = 930744, XrefRangeStart = 930723, XrefRangeEnd = 930743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SsrTracePass(ComputeShader compute, Texture2D texBlankSceneNormal)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texBlankSceneNormal);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrTracePass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930775, RefRangeEnd = 930776, XrefRangeStart = 930744, XrefRangeEnd = 930775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texSceneNormalPrev,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texHitInfo,
    [In] ref FrameRenderingParams frp,
    [In] ref Matrix4x4 prevProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneNormalPrev));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texHitInfo));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrTracePass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_byref_FrameRenderingParams_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930811, RefRangeEnd = 930812, XrefRangeStart = 930776, XrefRangeEnd = 930811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(SsrTracePass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector2Int_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930819, RefRangeEnd = 930820, XrefRangeStart = 930812, XrefRangeEnd = 930819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrTracePass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(SsrTracePass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrTracePass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneNormalPrev
  {
    get
    {
      int texSceneNormalPrev;
      IL2CPP.il2cpp_field_static_get_value(SsrTracePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev, (void*) &texSceneNormalPrev);
      return texSceneNormalPrev;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrTracePass.NativeFieldInfoPtr_kSidTexSceneNormalPrev, (void*) &value);
    }
  }

  public static unsafe int kSidTexMinHIZ
  {
    get
    {
      int kSidTexMinHiz;
      IL2CPP.il2cpp_field_static_get_value(SsrTracePass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &kSidTexMinHiz);
      return kSidTexMinHiz;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrTracePass.NativeFieldInfoPtr_kSidTexMinHIZ, (void*) &value);
    }
  }

  public static unsafe int kSidTexHitInfo
  {
    get
    {
      int kSidTexHitInfo;
      IL2CPP.il2cpp_field_static_get_value(SsrTracePass.NativeFieldInfoPtr_kSidTexHitInfo, (void*) &kSidTexHitInfo);
      return kSidTexHitInfo;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrTracePass.NativeFieldInfoPtr_kSidTexHitInfo, (void*) &value);
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  public unsafe Texture2D _texBlankSceneNormal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__texBlankSceneNormal));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__texBlankSceneNormal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<SsrTracePass.HIZTraversalCBufferData> _cbufferHIZ
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__cbufferHIZ));
      return num == System.IntPtr.Zero ? (CBuffer<SsrTracePass.HIZTraversalCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SsrTracePass.HIZTraversalCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__cbufferHIZ), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<SsrTracePass.SsrTraceCBufferData> _cbufferSsr
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__cbufferSsr));
      return num == System.IntPtr.Zero ? (CBuffer<SsrTracePass.SsrTraceCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SsrTracePass.SsrTraceCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrTracePass.NativeFieldInfoPtr__cbufferSsr), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct HIZTraversalCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_mipmap0Size;
    private static readonly System.IntPtr NativeFieldInfoPtr_mipmap0SizeRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_characterAabbMinUv;
    private static readonly System.IntPtr NativeFieldInfoPtr_characterAabbMaxUv;
    [FieldOffset(0)]
    public Vector2 mipmap0Size;
    [FieldOffset(8)]
    public Vector2 mipmap0SizeRcp;
    [FieldOffset(16 /*0x10*/)]
    public Vector2 characterAabbMinUv;
    [FieldOffset(24)]
    public Vector2 characterAabbMaxUv;

    static HIZTraversalCBufferData()
    {
      Il2CppClassPointerStore<SsrTracePass.HIZTraversalCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (HIZTraversalCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsrTracePass.HIZTraversalCBufferData>.NativeClassPtr);
      SsrTracePass.HIZTraversalCBufferData.NativeFieldInfoPtr_mipmap0Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.HIZTraversalCBufferData>.NativeClassPtr, nameof (mipmap0Size));
      SsrTracePass.HIZTraversalCBufferData.NativeFieldInfoPtr_mipmap0SizeRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.HIZTraversalCBufferData>.NativeClassPtr, nameof (mipmap0SizeRcp));
      SsrTracePass.HIZTraversalCBufferData.NativeFieldInfoPtr_characterAabbMinUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.HIZTraversalCBufferData>.NativeClassPtr, nameof (characterAabbMinUv));
      SsrTracePass.HIZTraversalCBufferData.NativeFieldInfoPtr_characterAabbMaxUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.HIZTraversalCBufferData>.NativeClassPtr, nameof (characterAabbMaxUv));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SsrTracePass.HIZTraversalCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SsrTraceCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputTc2Uv;
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_prevProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraPositionWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_screenEdgeFade;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector4 texOutputTc2Uv;
    [FieldOffset(16 /*0x10*/)]
    public Matrix4x4 projectionViewMatrix;
    [FieldOffset(80 /*0x50*/)]
    public Matrix4x4 invProjectionViewMatrix;
    [FieldOffset(144 /*0x90*/)]
    public Matrix4x4 prevProjectionViewMatrix;
    [FieldOffset(208 /*0xD0*/)]
    public Vector4 cameraPositionWs;
    [FieldOffset(224 /*0xE0*/)]
    public Vector2 screenEdgeFade;
    [FieldOffset(232)]
    public Vector2 padding;

    static SsrTraceCBufferData()
    {
      Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SsrTracePass>.NativeClassPtr, nameof (SsrTraceCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr);
      SsrTracePass.SsrTraceCBufferData.NativeFieldInfoPtr_texOutputTc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, nameof (texOutputTc2Uv));
      SsrTracePass.SsrTraceCBufferData.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, nameof (projectionViewMatrix));
      SsrTracePass.SsrTraceCBufferData.NativeFieldInfoPtr_invProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, nameof (invProjectionViewMatrix));
      SsrTracePass.SsrTraceCBufferData.NativeFieldInfoPtr_prevProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, nameof (prevProjectionViewMatrix));
      SsrTracePass.SsrTraceCBufferData.NativeFieldInfoPtr_cameraPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, nameof (cameraPositionWs));
      SsrTracePass.SsrTraceCBufferData.NativeFieldInfoPtr_screenEdgeFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, nameof (screenEdgeFade));
      SsrTracePass.SsrTraceCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SsrTracePass.SsrTraceCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
