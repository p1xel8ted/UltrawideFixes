// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalBufferPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class DecalBufferPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepthCopy;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRenderTargetLabels;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRenderTargetClearColors;
  private static readonly System.IntPtr NativeFieldInfoPtr__decalBatcher;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderTargets;
  private static readonly System.IntPtr NativeFieldInfoPtr__rtBinding;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Int32_byref_ScriptableRenderContext_CommandBuffer_IReadOnlyList_1_VisibleDecal_RenderTextureResource_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderTargets_Private_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePreviewCamera_Public_Void_CommandBuffer_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static DecalBufferPass()
  {
    Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalBufferPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr);
    DecalBufferPass.NativeFieldInfoPtr_kSidTexSceneDepthCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, nameof (kSidTexSceneDepthCopy));
    DecalBufferPass.NativeFieldInfoPtr_kRenderTargetLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, nameof (kRenderTargetLabels));
    DecalBufferPass.NativeFieldInfoPtr_kRenderTargetClearColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, nameof (kRenderTargetClearColors));
    DecalBufferPass.NativeFieldInfoPtr__decalBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, nameof (_decalBatcher));
    DecalBufferPass.NativeFieldInfoPtr__renderTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, nameof (_renderTargets));
    DecalBufferPass.NativeFieldInfoPtr__rtBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, nameof (_rtBinding));
    DecalBufferPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, 100663698);
    DecalBufferPass.NativeMethodInfoPtr_Encode_Public_Int32_byref_ScriptableRenderContext_CommandBuffer_IReadOnlyList_1_VisibleDecal_RenderTextureResource_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, 100663699);
    DecalBufferPass.NativeMethodInfoPtr_SetupRenderTargets_Private_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, 100663700);
    DecalBufferPass.NativeMethodInfoPtr_EncodePreviewCamera_Public_Void_CommandBuffer_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, 100663701);
    DecalBufferPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr, 100663702);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927786, RefRangeEnd = 927787, XrefRangeStart = 927728, XrefRangeEnd = 927786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalBufferPass()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalBufferPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBufferPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927823, RefRangeEnd = 927824, XrefRangeStart = 927787, XrefRangeEnd = 927823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    IReadOnlyList<VisibleDecal> visibleDecals,
    RenderTextureResource texDecalBuffer,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texSceneDepthCopy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) visibleDecals);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDecalBuffer));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepthCopy));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalBufferPass.NativeMethodInfoPtr_Encode_Public_Int32_byref_ScriptableRenderContext_CommandBuffer_IReadOnlyList_1_VisibleDecal_RenderTextureResource_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927850, RefRangeEnd = 927851, XrefRangeStart = 927824, XrefRangeEnd = 927850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupRenderTargets(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    RenderTextureResource texDecalBuffer,
    RenderTextureResource texSceneDepth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDecalBuffer));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBufferPass.NativeMethodInfoPtr_SetupRenderTargets_Private_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927851, XrefRangeEnd = 927860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodePreviewCamera(CommandBuffer cmd, RenderTextureResource texDecalBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDecalBuffer));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBufferPass.NativeMethodInfoPtr_EncodePreviewCamera_Public_Void_CommandBuffer_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927860, XrefRangeEnd = 927873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBufferPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexSceneDepthCopy
  {
    get
    {
      int texSceneDepthCopy;
      IL2CPP.il2cpp_field_static_get_value(DecalBufferPass.NativeFieldInfoPtr_kSidTexSceneDepthCopy, (void*) &texSceneDepthCopy);
      return texSceneDepthCopy;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalBufferPass.NativeFieldInfoPtr_kSidTexSceneDepthCopy, (void*) &value);
    }
  }

  public static unsafe Il2CppStringArray kRenderTargetLabels
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(DecalBufferPass.NativeFieldInfoPtr_kRenderTargetLabels, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalBufferPass.NativeFieldInfoPtr_kRenderTargetLabels, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<Color> kRenderTargetClearColors
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(DecalBufferPass.NativeFieldInfoPtr_kRenderTargetClearColors, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalBufferPass.NativeFieldInfoPtr_kRenderTargetClearColors, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DecalBatcher _decalBatcher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBufferPass.NativeFieldInfoPtr__decalBatcher));
      return num == System.IntPtr.Zero ? (DecalBatcher) null : Il2CppObjectPool.Get<DecalBatcher>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBufferPass.NativeFieldInfoPtr__decalBatcher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<RenderTextureResource> _renderTargets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBufferPass.NativeFieldInfoPtr__renderTargets));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RenderTextureResource>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTextureResource>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBufferPass.NativeFieldInfoPtr__renderTargets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public RenderTargetBinding _rtBinding
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBufferPass.NativeFieldInfoPtr__rtBinding);
      return new RenderTargetBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBufferPass.NativeFieldInfoPtr__rtBinding), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
