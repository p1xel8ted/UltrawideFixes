// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PostProcessStage
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

public sealed class PostProcessStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kCgLutSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_texCgLutDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kErrorFillColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kNoErrorFillColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__devdbgRP;
  private static readonly System.IntPtr NativeFieldInfoPtr__copyDepthPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__resolveMsaaPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__taaPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__depthOfFieldAlgorithm;
  private static readonly System.IntPtr NativeFieldInfoPtr__cgLutPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__bloomPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__finalBlitPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__cllHeatmapPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__bloomTexturePyramid;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ClusteredLightListHeatmapSettings_IDevdbgRenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePostProcessing_Public_Void_byref_ScriptableRenderContext_SceneFrame_FrameResultTextures_byref_FrameRenderingParams_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeAntiAliasing_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeFinalPostProcessing_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_FrameResultTextures_byref_FrameRenderingParams_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PostProcessStage()
  {
    Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PostProcessStage));
    PostProcessStage.NativeFieldInfoPtr_kCgLutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (kCgLutSize));
    PostProcessStage.NativeFieldInfoPtr_texCgLutDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (texCgLutDesc));
    PostProcessStage.NativeFieldInfoPtr_kErrorFillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (kErrorFillColor));
    PostProcessStage.NativeFieldInfoPtr_kNoErrorFillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (kNoErrorFillColor));
    PostProcessStage.NativeFieldInfoPtr__devdbgRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_devdbgRP));
    PostProcessStage.NativeFieldInfoPtr__copyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_copyDepthPass));
    PostProcessStage.NativeFieldInfoPtr__resolveMsaaPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_resolveMsaaPass));
    PostProcessStage.NativeFieldInfoPtr__taaPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_taaPass));
    PostProcessStage.NativeFieldInfoPtr__depthOfFieldAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_depthOfFieldAlgorithm));
    PostProcessStage.NativeFieldInfoPtr__cgLutPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_cgLutPass));
    PostProcessStage.NativeFieldInfoPtr__bloomPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_bloomPass));
    PostProcessStage.NativeFieldInfoPtr__finalBlitPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_finalBlitPass));
    PostProcessStage.NativeFieldInfoPtr__cllHeatmapPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_cllHeatmapPass));
    PostProcessStage.NativeFieldInfoPtr__bloomTexturePyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, nameof (_bloomTexturePyramid));
    PostProcessStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ClusteredLightListHeatmapSettings_IDevdbgRenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, 100664170);
    PostProcessStage.NativeMethodInfoPtr_EncodePostProcessing_Public_Void_byref_ScriptableRenderContext_SceneFrame_FrameResultTextures_byref_FrameRenderingParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, 100664171);
    PostProcessStage.NativeMethodInfoPtr_EncodeAntiAliasing_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, 100664172);
    PostProcessStage.NativeMethodInfoPtr_EncodeFinalPostProcessing_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_FrameResultTextures_byref_FrameRenderingParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, 100664173);
    PostProcessStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr, 100664174);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934116, RefRangeEnd = 934117, XrefRangeStart = 934047, XrefRangeEnd = 934116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PostProcessStage(
    ScsRenderPipelineResources resources,
    ClusteredLightListHeatmapSettings cllHeatmapSettings,
    IDevdbgRenderPipeline devdbgRP)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cllHeatmapSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) devdbgRP);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PostProcessStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ClusteredLightListHeatmapSettings_IDevdbgRenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934135, RefRangeEnd = 934136, XrefRangeStart = 934117, XrefRangeEnd = 934135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodePostProcessing(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    FrameResultTextures frameResultTextures,
    [In] ref FrameRenderingParams frp,
    bool useErrorFillColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &useErrorFillColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PostProcessStage.NativeMethodInfoPtr_EncodePostProcessing_Public_Void_byref_ScriptableRenderContext_SceneFrame_FrameResultTextures_byref_FrameRenderingParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934161, RefRangeEnd = 934162, XrefRangeStart = 934136, XrefRangeEnd = 934161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeAntiAliasing(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PostProcessStage.NativeMethodInfoPtr_EncodeAntiAliasing_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934195, RefRangeEnd = 934196, XrefRangeStart = 934162, XrefRangeEnd = 934195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeFinalPostProcessing(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SceneFrame frame,
    FrameResultTextures frameResultTextures,
    [In] ref FrameRenderingParams frp,
    bool useErrorFillColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &useErrorFillColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PostProcessStage.NativeMethodInfoPtr_EncodeFinalPostProcessing_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_FrameResultTextures_byref_FrameRenderingParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934249, RefRangeEnd = 934250, XrefRangeStart = 934196, XrefRangeEnd = 934249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PostProcessStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kCgLutSize
  {
    get
    {
      int kCgLutSize;
      IL2CPP.il2cpp_field_static_get_value(PostProcessStage.NativeFieldInfoPtr_kCgLutSize, (void*) &kCgLutSize);
      return kCgLutSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PostProcessStage.NativeFieldInfoPtr_kCgLutSize, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor texCgLutDesc
  {
    get
    {
      RenderTextureDescriptor texCgLutDesc;
      IL2CPP.il2cpp_field_static_get_value(PostProcessStage.NativeFieldInfoPtr_texCgLutDesc, (void*) &texCgLutDesc);
      return texCgLutDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PostProcessStage.NativeFieldInfoPtr_texCgLutDesc, (void*) &value);
    }
  }

  public static unsafe Vector4 kErrorFillColor
  {
    get
    {
      Vector4 kErrorFillColor;
      IL2CPP.il2cpp_field_static_get_value(PostProcessStage.NativeFieldInfoPtr_kErrorFillColor, (void*) &kErrorFillColor);
      return kErrorFillColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PostProcessStage.NativeFieldInfoPtr_kErrorFillColor, (void*) &value);
    }
  }

  public static unsafe Vector4 kNoErrorFillColor
  {
    get
    {
      Vector4 noErrorFillColor;
      IL2CPP.il2cpp_field_static_get_value(PostProcessStage.NativeFieldInfoPtr_kNoErrorFillColor, (void*) &noErrorFillColor);
      return noErrorFillColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PostProcessStage.NativeFieldInfoPtr_kNoErrorFillColor, (void*) &value);
    }
  }

  public unsafe IDevdbgRenderPipeline _devdbgRP
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__devdbgRP));
      return num == System.IntPtr.Zero ? (IDevdbgRenderPipeline) null : Il2CppObjectPool.Get<IDevdbgRenderPipeline>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__devdbgRP), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CopyDepthPass _copyDepthPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__copyDepthPass));
      return num == System.IntPtr.Zero ? (CopyDepthPass) null : Il2CppObjectPool.Get<CopyDepthPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__copyDepthPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ResolveMsaaPass _resolveMsaaPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__resolveMsaaPass));
      return num == System.IntPtr.Zero ? (ResolveMsaaPass) null : Il2CppObjectPool.Get<ResolveMsaaPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__resolveMsaaPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TaaPass _taaPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__taaPass));
      return num == System.IntPtr.Zero ? (TaaPass) null : Il2CppObjectPool.Get<TaaPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__taaPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DepthOfFieldAlgorithm _depthOfFieldAlgorithm
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__depthOfFieldAlgorithm));
      return num == System.IntPtr.Zero ? (DepthOfFieldAlgorithm) null : Il2CppObjectPool.Get<DepthOfFieldAlgorithm>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__depthOfFieldAlgorithm), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorGradingLutPass _cgLutPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__cgLutPass));
      return num == System.IntPtr.Zero ? (ColorGradingLutPass) null : Il2CppObjectPool.Get<ColorGradingLutPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__cgLutPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BloomPass _bloomPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__bloomPass));
      return num == System.IntPtr.Zero ? (BloomPass) null : Il2CppObjectPool.Get<BloomPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__bloomPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FinalBlitPass _finalBlitPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__finalBlitPass));
      return num == System.IntPtr.Zero ? (FinalBlitPass) null : Il2CppObjectPool.Get<FinalBlitPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__finalBlitPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClusteredLightListHeatmapPass _cllHeatmapPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__cllHeatmapPass));
      return num == System.IntPtr.Zero ? (ClusteredLightListHeatmapPass) null : Il2CppObjectPool.Get<ClusteredLightListHeatmapPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__cllHeatmapPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BloomTexturePyramid _bloomTexturePyramid
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__bloomTexturePyramid));
      return num == System.IntPtr.Zero ? (BloomTexturePyramid) null : Il2CppObjectPool.Get<BloomTexturePyramid>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessStage.NativeFieldInfoPtr__bloomTexturePyramid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
