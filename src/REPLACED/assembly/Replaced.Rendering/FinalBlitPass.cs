// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FinalBlitPass
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

public sealed class FinalBlitPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kFinalBlitShaderPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSimpleFinalBlitShaderPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCopyDepthShaderPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBloom;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCgLut;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexFilmGrain;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__blitMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeCopyDepth_Public_Void_CommandBuffer_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_byref_PresentToCameraRTParams_Int32_Vector4_0;

  static FinalBlitPass()
  {
    Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FinalBlitPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr);
    FinalBlitPass.NativeFieldInfoPtr_kFinalBlitShaderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kFinalBlitShaderPass));
    FinalBlitPass.NativeFieldInfoPtr_kSimpleFinalBlitShaderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kSimpleFinalBlitShaderPass));
    FinalBlitPass.NativeFieldInfoPtr_kCopyDepthShaderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kCopyDepthShaderPass));
    FinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kSidTexInputColor));
    FinalBlitPass.NativeFieldInfoPtr_kSidTexBloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kSidTexBloom));
    FinalBlitPass.NativeFieldInfoPtr_kSidTexInputDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kSidTexInputDepth));
    FinalBlitPass.NativeFieldInfoPtr_kSidTexCgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kSidTexCgLut));
    FinalBlitPass.NativeFieldInfoPtr_kSidTexFilmGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (kSidTexFilmGrain));
    FinalBlitPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (_cbuffer));
    FinalBlitPass.NativeFieldInfoPtr__blitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, nameof (_blitMaterial));
    FinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100664155);
    FinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100664156);
    FinalBlitPass.NativeMethodInfoPtr_EncodeCopyDepth_Public_Void_CommandBuffer_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100664157);
    FinalBlitPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100664158);
    FinalBlitPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_byref_PresentToCameraRTParams_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100664159);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933849, XrefRangeEnd = 933862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalBlitPass(Shader blitShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blitShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933895, RefRangeEnd = 933896, XrefRangeStart = 933862, XrefRangeEnd = 933895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    RenderTextureResource texInputColor,
    RenderTextureResource texBloom,
    RenderTextureResource texCgLut,
    Vector4 errorFillColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBloom));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCgLut));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &errorFillColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933896, XrefRangeEnd = 933907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeCopyDepth(CommandBuffer cmd, [In] ref RenderTextureResource texInputDepth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputDepth);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_EncodeCopyDepth_Public_Void_CommandBuffer_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933907, XrefRangeEnd = 933915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933955, RefRangeEnd = 933956, XrefRangeStart = 933915, XrefRangeEnd = 933955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    [In] ref PresentToCameraRTParams pcp,
    int cgLutSize,
    Vector4 errorFillColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) pcp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &cgLutSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &errorFillColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_byref_PresentToCameraRTParams_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kFinalBlitShaderPass
  {
    get
    {
      int finalBlitShaderPass;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kFinalBlitShaderPass, (void*) &finalBlitShaderPass);
      return finalBlitShaderPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kFinalBlitShaderPass, (void*) &value);
    }
  }

  public static unsafe int kSimpleFinalBlitShaderPass
  {
    get
    {
      int finalBlitShaderPass;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kSimpleFinalBlitShaderPass, (void*) &finalBlitShaderPass);
      return finalBlitShaderPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kSimpleFinalBlitShaderPass, (void*) &value);
    }
  }

  public static unsafe int kCopyDepthShaderPass
  {
    get
    {
      int copyDepthShaderPass;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kCopyDepthShaderPass, (void*) &copyDepthShaderPass);
      return copyDepthShaderPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kCopyDepthShaderPass, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputColor
  {
    get
    {
      int sidTexInputColor;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &sidTexInputColor);
      return sidTexInputColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexBloom
  {
    get
    {
      int kSidTexBloom;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexBloom, (void*) &kSidTexBloom);
      return kSidTexBloom;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexBloom, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputDepth
  {
    get
    {
      int sidTexInputDepth;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexInputDepth, (void*) &sidTexInputDepth);
      return sidTexInputDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexInputDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexCgLut
  {
    get
    {
      int kSidTexCgLut;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexCgLut, (void*) &kSidTexCgLut);
      return kSidTexCgLut;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexCgLut, (void*) &value);
    }
  }

  public static unsafe int kSidTexFilmGrain
  {
    get
    {
      int kSidTexFilmGrain;
      IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexFilmGrain, (void*) &kSidTexFilmGrain);
      return kSidTexFilmGrain;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.NativeFieldInfoPtr_kSidTexFilmGrain, (void*) &value);
    }
  }

  public unsafe CBuffer<FinalBlitCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<FinalBlitCBufferData>) null : Il2CppObjectPool.Get<CBuffer<FinalBlitCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _blitMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr__blitMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr__blitMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
