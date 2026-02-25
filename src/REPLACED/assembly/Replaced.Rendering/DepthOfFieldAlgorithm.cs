// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DepthOfFieldAlgorithm
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

public sealed class DepthOfFieldAlgorithm(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kMaxBokehPointCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderPipelineDevdbg;
  private static readonly System.IntPtr NativeFieldInfoPtr__bokehPointBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__computeCocPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__cocStabilizationPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderBokehPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__bokehTaaPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__blurPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__composeDofImagePass;
  private static readonly System.IntPtr NativeFieldInfoPtr__debugPass;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_IDevdbgRenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_DepthOfFieldParams_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeComputeCoc_Private_Void_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeRenderBokeh_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static DepthOfFieldAlgorithm()
  {
    Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DepthOfFieldAlgorithm));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr);
    DepthOfFieldAlgorithm.NativeFieldInfoPtr_kMaxBokehPointCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (kMaxBokehPointCount));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__renderPipelineDevdbg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_renderPipelineDevdbg));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__bokehPointBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_bokehPointBuffer));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__computeCocPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_computeCocPass));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__cocStabilizationPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_cocStabilizationPass));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__renderBokehPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_renderBokehPass));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__bokehTaaPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_bokehTaaPass));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__blurPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_blurPass));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__composeDofImagePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_composeDofImagePass));
    DepthOfFieldAlgorithm.NativeFieldInfoPtr__debugPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (_debugPass));
    DepthOfFieldAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_IDevdbgRenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, 100664120);
    DepthOfFieldAlgorithm.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_DepthOfFieldParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, 100664121);
    DepthOfFieldAlgorithm.NativeMethodInfoPtr_EncodeComputeCoc_Private_Void_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, 100664122);
    DepthOfFieldAlgorithm.NativeMethodInfoPtr_EncodeRenderBokeh_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, 100664123);
    DepthOfFieldAlgorithm.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, 100664124);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933267, RefRangeEnd = 933268, XrefRangeStart = 933161, XrefRangeEnd = 933267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DepthOfFieldAlgorithm(
    ScsRenderPipelineResources resources,
    IDevdbgRenderPipeline renderPipelineDevdbg)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipelineDevdbg);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthOfFieldAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_IDevdbgRenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933316, RefRangeEnd = 933317, XrefRangeStart = 933268, XrefRangeEnd = 933316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    [In] ref DepthOfFieldParams dof,
    bool taaEnabled)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &taaEnabled;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthOfFieldAlgorithm.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_DepthOfFieldParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933341, RefRangeEnd = 933342, XrefRangeStart = 933317, XrefRangeEnd = 933341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeComputeCoc(
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    RenderTextureResource texSceneColor,
    RenderTextureResource texSceneDepthCopy,
    out RenderTextureResource texCocFullRes,
    out RenderTextureResource texColorHalfRes,
    out RenderTextureResource texCocHalfRes)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepthCopy));
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
    System.IntPtr zero3 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero3;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
    System.IntPtr num4;
    IL2CPP.il2cpp_runtime_invoke(DepthOfFieldAlgorithm.NativeMethodInfoPtr_EncodeComputeCoc_Private_Void_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    ref RenderTextureResource local1 = ref texCocFullRes;
    System.IntPtr pointer1 = zero1;
    RenderTextureResource renderTextureResource1 = pointer1 == System.IntPtr.Zero ? (RenderTextureResource) null : new RenderTextureResource(pointer1);
    local1 = renderTextureResource1;
    ref RenderTextureResource local2 = ref texColorHalfRes;
    System.IntPtr pointer2 = zero2;
    RenderTextureResource renderTextureResource2 = pointer2 == System.IntPtr.Zero ? (RenderTextureResource) null : new RenderTextureResource(pointer2);
    local2 = renderTextureResource2;
    ref RenderTextureResource local3 = ref texCocHalfRes;
    System.IntPtr pointer3 = zero3;
    RenderTextureResource renderTextureResource3 = pointer3 == System.IntPtr.Zero ? (RenderTextureResource) null : new RenderTextureResource(pointer3);
    local3 = renderTextureResource3;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933363, RefRangeEnd = 933364, XrefRangeStart = 933342, XrefRangeEnd = 933363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeRenderBokeh(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    RenderTextureResource texCoc,
    RenderTextureResource texStableBokehColor,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texHistoryBokehColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCoc));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texStableBokehColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texHistoryBokehColor));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthOfFieldAlgorithm.NativeMethodInfoPtr_EncodeRenderBokeh_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933382, RefRangeEnd = 933383, XrefRangeStart = 933364, XrefRangeEnd = 933382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthOfFieldAlgorithm.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kMaxBokehPointCount
  {
    get
    {
      int maxBokehPointCount;
      IL2CPP.il2cpp_field_static_get_value(DepthOfFieldAlgorithm.NativeFieldInfoPtr_kMaxBokehPointCount, (void*) &maxBokehPointCount);
      return maxBokehPointCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthOfFieldAlgorithm.NativeFieldInfoPtr_kMaxBokehPointCount, (void*) &value);
    }
  }

  public unsafe IDevdbgRenderPipeline _renderPipelineDevdbg
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__renderPipelineDevdbg));
      return num == System.IntPtr.Zero ? (IDevdbgRenderPipeline) null : Il2CppObjectPool.Get<IDevdbgRenderPipeline>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__renderPipelineDevdbg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _bokehPointBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__bokehPointBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__bokehPointBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeCocPass _computeCocPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__computeCocPass));
      return num == System.IntPtr.Zero ? (ComputeCocPass) null : Il2CppObjectPool.Get<ComputeCocPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__computeCocPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CocTaaPass _cocStabilizationPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__cocStabilizationPass));
      return num == System.IntPtr.Zero ? (CocTaaPass) null : Il2CppObjectPool.Get<CocTaaPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__cocStabilizationPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderBokehPass _renderBokehPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__renderBokehPass));
      return num == System.IntPtr.Zero ? (RenderBokehPass) null : Il2CppObjectPool.Get<RenderBokehPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__renderBokehPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BokehTaaPass _bokehTaaPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__bokehTaaPass));
      return num == System.IntPtr.Zero ? (BokehTaaPass) null : Il2CppObjectPool.Get<BokehTaaPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__bokehTaaPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DofBlurPass _blurPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__blurPass));
      return num == System.IntPtr.Zero ? (DofBlurPass) null : Il2CppObjectPool.Get<DofBlurPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__blurPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComposeDofImagePass _composeDofImagePass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__composeDofImagePass));
      return num == System.IntPtr.Zero ? (ComposeDofImagePass) null : Il2CppObjectPool.Get<ComposeDofImagePass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__composeDofImagePass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DepthOfFieldDebugPass _debugPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__debugPass));
      return num == System.IntPtr.Zero ? (DepthOfFieldDebugPass) null : Il2CppObjectPool.Get<DepthOfFieldDebugPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldAlgorithm.NativeFieldInfoPtr__debugPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct BokehPoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeFieldInfoPtr_color;
    private static readonly System.IntPtr NativeFieldInfoPtr_coc;
    private static readonly System.IntPtr NativeFieldInfoPtr_sizeFactor;
    [FieldOffset(0)]
    public Vector2 position;
    [FieldOffset(8)]
    public Vector3 color;
    [FieldOffset(20)]
    public float coc;
    [FieldOffset(24)]
    public float sizeFactor;

    static BokehPoint()
    {
      Il2CppClassPointerStore<DepthOfFieldAlgorithm.BokehPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthOfFieldAlgorithm>.NativeClassPtr, nameof (BokehPoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldAlgorithm.BokehPoint>.NativeClassPtr);
      DepthOfFieldAlgorithm.BokehPoint.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm.BokehPoint>.NativeClassPtr, nameof (position));
      DepthOfFieldAlgorithm.BokehPoint.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm.BokehPoint>.NativeClassPtr, nameof (color));
      DepthOfFieldAlgorithm.BokehPoint.NativeFieldInfoPtr_coc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm.BokehPoint>.NativeClassPtr, nameof (coc));
      DepthOfFieldAlgorithm.BokehPoint.NativeFieldInfoPtr_sizeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldAlgorithm.BokehPoint>.NativeClassPtr, nameof (sizeFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthOfFieldAlgorithm.BokehPoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
