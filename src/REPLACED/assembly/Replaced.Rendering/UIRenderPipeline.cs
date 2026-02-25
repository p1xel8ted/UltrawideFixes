// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIRenderPipeline
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

public sealed class UIRenderPipeline(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__frameResources;
  private static readonly System.IntPtr NativeFieldInfoPtr__bloomTexturePyramid;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiRenderingPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiResolveColorPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__bloomPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiFullscreenVfxPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiFinalBlitPass;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Render_Public_Void_ScriptableRenderContext_List_1_Camera_byref_CoreParams_GlobalCBuffers_FrameResultTextures_MsaaMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearRenderTargets_Private_Void_ScriptableRenderContext_UIFrameRenderTargets_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeGeomtryUICamerasSimple_Private_Boolean_ScriptableRenderContext_List_1_Camera_CoreParams_GlobalCBuffers_UIFrameRenderTargets_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeGeometryUICamerasWithPostProcessing_Private_Void_ScriptableRenderContext_List_1_Camera_CoreParams_GlobalCBuffers_UIFrameRenderTargets_byref_BloomParams_byref_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeUIPostProcessing_Private_Void_byref_ScriptableRenderContext_BloomParams_Material_FrameResultTextures_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeColorResolvePassIfNecessary_Private_Void_ScriptableRenderContext_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static UIRenderPipeline()
  {
    Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIRenderPipeline));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr);
    UIRenderPipeline.NativeFieldInfoPtr__frameResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, nameof (_frameResources));
    UIRenderPipeline.NativeFieldInfoPtr__bloomTexturePyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, nameof (_bloomTexturePyramid));
    UIRenderPipeline.NativeFieldInfoPtr__uiRenderingPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, nameof (_uiRenderingPass));
    UIRenderPipeline.NativeFieldInfoPtr__uiResolveColorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, nameof (_uiResolveColorPass));
    UIRenderPipeline.NativeFieldInfoPtr__bloomPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, nameof (_bloomPass));
    UIRenderPipeline.NativeFieldInfoPtr__uiFullscreenVfxPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, nameof (_uiFullscreenVfxPass));
    UIRenderPipeline.NativeFieldInfoPtr__uiFinalBlitPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, nameof (_uiFinalBlitPass));
    UIRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664225);
    UIRenderPipeline.NativeMethodInfoPtr_Render_Public_Void_ScriptableRenderContext_List_1_Camera_byref_CoreParams_GlobalCBuffers_FrameResultTextures_MsaaMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664226);
    UIRenderPipeline.NativeMethodInfoPtr_ClearRenderTargets_Private_Void_ScriptableRenderContext_UIFrameRenderTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664227);
    UIRenderPipeline.NativeMethodInfoPtr_EncodeGeomtryUICamerasSimple_Private_Boolean_ScriptableRenderContext_List_1_Camera_CoreParams_GlobalCBuffers_UIFrameRenderTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664228);
    UIRenderPipeline.NativeMethodInfoPtr_EncodeGeometryUICamerasWithPostProcessing_Private_Void_ScriptableRenderContext_List_1_Camera_CoreParams_GlobalCBuffers_UIFrameRenderTargets_byref_BloomParams_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664229);
    UIRenderPipeline.NativeMethodInfoPtr_EncodeUIPostProcessing_Private_Void_byref_ScriptableRenderContext_BloomParams_Material_FrameResultTextures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664230);
    UIRenderPipeline.NativeMethodInfoPtr_EncodeColorResolvePassIfNecessary_Private_Void_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664231);
    UIRenderPipeline.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr, 100664232);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935166, RefRangeEnd = 935167, XrefRangeStart = 935108, XrefRangeEnd = 935166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIRenderPipeline(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderPipeline>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935219, RefRangeEnd = 935220, XrefRangeStart = 935167, XrefRangeEnd = 935219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Render(
    ScriptableRenderContext ctx,
    List<Camera> cameras,
    [In] ref CoreParams coreParams,
    GlobalCBuffers globalCBuffers,
    FrameResultTextures frameResultTextures,
    MsaaMode msaaMode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coreParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) globalCBuffers);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &msaaMode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr_Render_Public_Void_ScriptableRenderContext_List_1_Camera_byref_CoreParams_GlobalCBuffers_FrameResultTextures_MsaaMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 935240, RefRangeEnd = 935242, XrefRangeStart = 935220, XrefRangeEnd = 935240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearRenderTargets(
    ScriptableRenderContext ctx,
    UIFrameRenderTargets renderTargets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) renderTargets));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr_ClearRenderTargets_Private_Void_ScriptableRenderContext_UIFrameRenderTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935242, XrefRangeEnd = 935254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool EncodeGeomtryUICamerasSimple(
    ScriptableRenderContext ctx,
    List<Camera> cameras,
    CoreParams coreParams,
    GlobalCBuffers globalCBuffers,
    UIFrameRenderTargets renderTargets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &coreParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) globalCBuffers);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) renderTargets));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr_EncodeGeomtryUICamerasSimple_Private_Boolean_ScriptableRenderContext_List_1_Camera_CoreParams_GlobalCBuffers_UIFrameRenderTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935290, RefRangeEnd = 935291, XrefRangeStart = 935254, XrefRangeEnd = 935290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeGeometryUICamerasWithPostProcessing(
    ScriptableRenderContext ctx,
    List<Camera> cameras,
    CoreParams coreParams,
    GlobalCBuffers globalCBuffers,
    UIFrameRenderTargets renderTargets,
    out BloomParams bloom,
    out Material fullscreenVfxMaterial)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
    numPtr1[0] = (System.IntPtr) &ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &coreParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) globalCBuffers);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) renderTargets));
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref bloom;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr_EncodeGeometryUICamerasWithPostProcessing_Private_Void_ScriptableRenderContext_List_1_Camera_CoreParams_GlobalCBuffers_UIFrameRenderTargets_byref_BloomParams_byref_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Material local = ref fullscreenVfxMaterial;
    System.IntPtr pointer = zero;
    Material material = pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    local = material;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935313, RefRangeEnd = 935314, XrefRangeStart = 935291, XrefRangeEnd = 935313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeUIPostProcessing(
    [In] ref ScriptableRenderContext ctx,
    BloomParams bloom,
    Material fullscreenVfxMaterial,
    FrameResultTextures frameResultTextures)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bloom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fullscreenVfxMaterial);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr_EncodeUIPostProcessing_Private_Void_byref_ScriptableRenderContext_BloomParams_Material_FrameResultTextures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 935315, RefRangeEnd = 935317, XrefRangeStart = 935314, XrefRangeEnd = 935315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeColorResolvePassIfNecessary(ScriptableRenderContext ctx)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ctx
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr_EncodeColorResolvePassIfNecessary_Private_Void_ScriptableRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935317, XrefRangeEnd = 935331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderPipeline.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UIFrameResources _frameResources
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__frameResources));
      return num == System.IntPtr.Zero ? (UIFrameResources) null : Il2CppObjectPool.Get<UIFrameResources>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__frameResources), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BloomTexturePyramid _bloomTexturePyramid
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__bloomTexturePyramid));
      return num == System.IntPtr.Zero ? (BloomTexturePyramid) null : Il2CppObjectPool.Get<BloomTexturePyramid>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__bloomTexturePyramid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIRenderingPass _uiRenderingPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiRenderingPass));
      return num == System.IntPtr.Zero ? (UIRenderingPass) null : Il2CppObjectPool.Get<UIRenderingPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiRenderingPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIResolveColorPass _uiResolveColorPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiResolveColorPass));
      return num == System.IntPtr.Zero ? (UIResolveColorPass) null : Il2CppObjectPool.Get<UIResolveColorPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiResolveColorPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BloomPass _bloomPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__bloomPass));
      return num == System.IntPtr.Zero ? (BloomPass) null : Il2CppObjectPool.Get<BloomPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__bloomPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIFullscreenVfxPass _uiFullscreenVfxPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiFullscreenVfxPass));
      return num == System.IntPtr.Zero ? (UIFullscreenVfxPass) null : Il2CppObjectPool.Get<UIFullscreenVfxPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiFullscreenVfxPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIFinalBlitPass _uiFinalBlitPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiFinalBlitPass));
      return num == System.IntPtr.Zero ? (UIFinalBlitPass) null : Il2CppObjectPool.Get<UIFinalBlitPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderPipeline.NativeFieldInfoPtr__uiFinalBlitPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
