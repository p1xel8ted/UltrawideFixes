// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MaskDecalPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class MaskDecalPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kClearColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr__maskDecalBatcher;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Int32_byref_ScriptableRenderContext_CommandBuffer_IReadOnlyList_1_VisibleMaskDecal_RenderTextureResource_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePreviewCamera_Public_Void_CommandBuffer_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static MaskDecalPass()
  {
    Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (MaskDecalPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr);
    MaskDecalPass.NativeFieldInfoPtr_kClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr, nameof (kClearColor));
    MaskDecalPass.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr, nameof (kSidTexSceneDepth));
    MaskDecalPass.NativeFieldInfoPtr__maskDecalBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr, nameof (_maskDecalBatcher));
    MaskDecalPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr, 100663737);
    MaskDecalPass.NativeMethodInfoPtr_Encode_Public_Int32_byref_ScriptableRenderContext_CommandBuffer_IReadOnlyList_1_VisibleMaskDecal_RenderTextureResource_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr, 100663738);
    MaskDecalPass.NativeMethodInfoPtr_EncodePreviewCamera_Public_Void_CommandBuffer_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr, 100663739);
    MaskDecalPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr, 100663740);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928263, XrefRangeEnd = 928296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MaskDecalPass(Shader maskDecalShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskDecalPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecalShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928333, RefRangeEnd = 928334, XrefRangeStart = 928296, XrefRangeEnd = 928333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    IReadOnlyList<VisibleMaskDecal> visibleMaskDecals,
    RenderTextureResource texFrameMask,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texSceneDepthCopy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) visibleMaskDecals);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texFrameMask));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepthCopy));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaskDecalPass.NativeMethodInfoPtr_Encode_Public_Int32_byref_ScriptableRenderContext_CommandBuffer_IReadOnlyList_1_VisibleMaskDecal_RenderTextureResource_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928334, XrefRangeEnd = 928343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodePreviewCamera(CommandBuffer cmd, RenderTextureResource texFrameMask)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texFrameMask));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalPass.NativeMethodInfoPtr_EncodePreviewCamera_Public_Void_CommandBuffer_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928343, XrefRangeEnd = 928359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Color kClearColor
  {
    get
    {
      Color kClearColor;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalPass.NativeFieldInfoPtr_kClearColor, (void*) &kClearColor);
      return kClearColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalPass.NativeFieldInfoPtr_kClearColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public unsafe MaskDecalBatcher _maskDecalBatcher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalPass.NativeFieldInfoPtr__maskDecalBatcher));
      return num == System.IntPtr.Zero ? (MaskDecalBatcher) null : Il2CppObjectPool.Get<MaskDecalBatcher>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalPass.NativeFieldInfoPtr__maskDecalBatcher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
