// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SceneRenderPipeline
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

public sealed class SceneRenderPipeline(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__frameStatsReport;
  private static readonly System.IntPtr NativeFieldInfoPtr__devdbgRenderPipeline;
  private static readonly System.IntPtr NativeFieldInfoPtr__tveCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__config;
  private static readonly System.IntPtr NativeFieldInfoPtr__resources;
  private static readonly System.IntPtr NativeFieldInfoPtr__integrateDfgLut;
  private static readonly System.IntPtr NativeFieldInfoPtr__decalStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightingStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__globalIlluminationStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumetricStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__depthPrepass;
  private static readonly System.IntPtr NativeFieldInfoPtr__depthPyramidStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__geometryRenderingStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__fakeFogPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__downsampleSceneDataStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__firmamentStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__postProcessStage;
  private static readonly System.IntPtr NativeFieldInfoPtr__cllBuildPass;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineConfig_ScsRenderPipelineResources_FrameStatsReport_ParticipatingMediumManager_DecalManager_ClusteredLightListHeatmapSettings_IDevdbgRenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderFrame_Public_Void_byref_ScriptableRenderContext_FrameResultTextures_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePreGeometryRenderingAlgorithmsSerial_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePreGeometryRenderingAlgorithmsAsync_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderSceneCameraWireframe_Private_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupTVECBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_0;

  static SceneRenderPipeline()
  {
    Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SceneRenderPipeline));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr);
    SceneRenderPipeline.NativeFieldInfoPtr__frameStatsReport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_frameStatsReport));
    SceneRenderPipeline.NativeFieldInfoPtr__devdbgRenderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_devdbgRenderPipeline));
    SceneRenderPipeline.NativeFieldInfoPtr__tveCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_tveCBuffer));
    SceneRenderPipeline.NativeFieldInfoPtr__config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_config));
    SceneRenderPipeline.NativeFieldInfoPtr__resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_resources));
    SceneRenderPipeline.NativeFieldInfoPtr__integrateDfgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_integrateDfgLut));
    SceneRenderPipeline.NativeFieldInfoPtr__decalStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_decalStage));
    SceneRenderPipeline.NativeFieldInfoPtr__lightingStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_lightingStage));
    SceneRenderPipeline.NativeFieldInfoPtr__globalIlluminationStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_globalIlluminationStage));
    SceneRenderPipeline.NativeFieldInfoPtr__volumetricStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_volumetricStage));
    SceneRenderPipeline.NativeFieldInfoPtr__depthPrepass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_depthPrepass));
    SceneRenderPipeline.NativeFieldInfoPtr__depthPyramidStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_depthPyramidStage));
    SceneRenderPipeline.NativeFieldInfoPtr__geometryRenderingStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_geometryRenderingStage));
    SceneRenderPipeline.NativeFieldInfoPtr__fakeFogPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_fakeFogPass));
    SceneRenderPipeline.NativeFieldInfoPtr__downsampleSceneDataStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_downsampleSceneDataStage));
    SceneRenderPipeline.NativeFieldInfoPtr__firmamentStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_firmamentStage));
    SceneRenderPipeline.NativeFieldInfoPtr__postProcessStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_postProcessStage));
    SceneRenderPipeline.NativeFieldInfoPtr__cllBuildPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (_cllBuildPass));
    SceneRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineConfig_ScsRenderPipelineResources_FrameStatsReport_ParticipatingMediumManager_DecalManager_ClusteredLightListHeatmapSettings_IDevdbgRenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100664194);
    SceneRenderPipeline.NativeMethodInfoPtr_RenderFrame_Public_Void_byref_ScriptableRenderContext_FrameResultTextures_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100664195);
    SceneRenderPipeline.NativeMethodInfoPtr_EncodePreGeometryRenderingAlgorithmsSerial_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100664196);
    SceneRenderPipeline.NativeMethodInfoPtr_EncodePreGeometryRenderingAlgorithmsAsync_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100664197);
    SceneRenderPipeline.NativeMethodInfoPtr_RenderSceneCameraWireframe_Private_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100664198);
    SceneRenderPipeline.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100664199);
    SceneRenderPipeline.NativeMethodInfoPtr_SetupTVECBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100664200);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934621, RefRangeEnd = 934622, XrefRangeStart = 934532, XrefRangeEnd = 934621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneRenderPipeline(
    ScsRenderPipelineConfig config,
    ScsRenderPipelineResources resources,
    FrameStatsReport frameStatsReport,
    ParticipatingMediumManager mediumManager,
    DecalManager decalManager,
    ClusteredLightListHeatmapSettings cllHeatmapSettings,
    IDevdbgRenderPipeline renderPipelineDevdbg)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) config);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameStatsReport);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mediumManager);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decalManager);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cllHeatmapSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipelineDevdbg);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineConfig_ScsRenderPipelineResources_FrameStatsReport_ParticipatingMediumManager_DecalManager_ClusteredLightListHeatmapSettings_IDevdbgRenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 934666, RefRangeEnd = 934668, XrefRangeStart = 934622, XrefRangeEnd = 934666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RenderFrame(
    [In] ref ScriptableRenderContext ctx,
    FrameResultTextures frameResultTextures,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr_RenderFrame_Public_Void_byref_ScriptableRenderContext_FrameResultTextures_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934689, RefRangeEnd = 934690, XrefRangeStart = 934668, XrefRangeEnd = 934689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodePreGeometryRenderingAlgorithmsSerial(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp,
    ClusteredInputLightList clusteredInputList,
    ClusteredLightListData cllData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clusteredInputList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cllData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr_EncodePreGeometryRenderingAlgorithmsSerial_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934690, XrefRangeEnd = 934720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodePreGeometryRenderingAlgorithmsAsync(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp,
    ClusteredInputLightList clusteredInputList,
    ClusteredLightListData cllData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clusteredInputList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cllData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr_EncodePreGeometryRenderingAlgorithmsAsync_Private_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934720, XrefRangeEnd = 934737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RenderSceneCameraWireframe(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr_RenderSceneCameraWireframe_Private_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934768, RefRangeEnd = 934769, XrefRangeStart = 934737, XrefRangeEnd = 934768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 934788, RefRangeEnd = 934790, XrefRangeStart = 934769, XrefRangeEnd = 934788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupTVECBuffer(CommandBuffer cmd, [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr_SetupTVECBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FrameStatsReport _frameStatsReport
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__frameStatsReport));
      return num == System.IntPtr.Zero ? (FrameStatsReport) null : Il2CppObjectPool.Get<FrameStatsReport>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__frameStatsReport), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IDevdbgRenderPipeline _devdbgRenderPipeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__devdbgRenderPipeline));
      return num == System.IntPtr.Zero ? (IDevdbgRenderPipeline) null : Il2CppObjectPool.Get<IDevdbgRenderPipeline>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__devdbgRenderPipeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<SceneRenderPipeline.TVECBufferData> _tveCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__tveCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<SceneRenderPipeline.TVECBufferData>) null : Il2CppObjectPool.Get<CBuffer<SceneRenderPipeline.TVECBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__tveCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScsRenderPipelineConfig _config
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__config));
      return num == System.IntPtr.Zero ? (ScsRenderPipelineConfig) null : Il2CppObjectPool.Get<ScsRenderPipelineConfig>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__config), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScsRenderPipelineResources _resources
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__resources));
      return num == System.IntPtr.Zero ? (ScsRenderPipelineResources) null : Il2CppObjectPool.Get<ScsRenderPipelineResources>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__resources), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IntegrateDfgLut _integrateDfgLut
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__integrateDfgLut));
      return num == System.IntPtr.Zero ? (IntegrateDfgLut) null : Il2CppObjectPool.Get<IntegrateDfgLut>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__integrateDfgLut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DecalStage _decalStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__decalStage));
      return num == System.IntPtr.Zero ? (DecalStage) null : Il2CppObjectPool.Get<DecalStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__decalStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LightingStage _lightingStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__lightingStage));
      return num == System.IntPtr.Zero ? (LightingStage) null : Il2CppObjectPool.Get<LightingStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__lightingStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GlobalIlluminationStage _globalIlluminationStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__globalIlluminationStage));
      return num == System.IntPtr.Zero ? (GlobalIlluminationStage) null : Il2CppObjectPool.Get<GlobalIlluminationStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__globalIlluminationStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe VolumetricStage _volumetricStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__volumetricStage));
      return num == System.IntPtr.Zero ? (VolumetricStage) null : Il2CppObjectPool.Get<VolumetricStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__volumetricStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DepthPrepass _depthPrepass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__depthPrepass));
      return num == System.IntPtr.Zero ? (DepthPrepass) null : Il2CppObjectPool.Get<DepthPrepass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__depthPrepass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DepthPyramidStage _depthPyramidStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__depthPyramidStage));
      return num == System.IntPtr.Zero ? (DepthPyramidStage) null : Il2CppObjectPool.Get<DepthPyramidStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__depthPyramidStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GeometryRenderingStage _geometryRenderingStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__geometryRenderingStage));
      return num == System.IntPtr.Zero ? (GeometryRenderingStage) null : Il2CppObjectPool.Get<GeometryRenderingStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__geometryRenderingStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FakeFogPass _fakeFogPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__fakeFogPass));
      return num == System.IntPtr.Zero ? (FakeFogPass) null : Il2CppObjectPool.Get<FakeFogPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__fakeFogPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DownsampleSceneDataPass _downsampleSceneDataStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__downsampleSceneDataStage));
      return num == System.IntPtr.Zero ? (DownsampleSceneDataPass) null : Il2CppObjectPool.Get<DownsampleSceneDataPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__downsampleSceneDataStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FirmamentStage _firmamentStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__firmamentStage));
      return num == System.IntPtr.Zero ? (FirmamentStage) null : Il2CppObjectPool.Get<FirmamentStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__firmamentStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PostProcessStage _postProcessStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__postProcessStage));
      return num == System.IntPtr.Zero ? (PostProcessStage) null : Il2CppObjectPool.Get<PostProcessStage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__postProcessStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClusteredLightListBuildPass _cllBuildPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__cllBuildPass));
      return num == System.IntPtr.Zero ? (ClusteredLightListBuildPass) null : Il2CppObjectPool.Get<ClusteredLightListBuildPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneRenderPipeline.NativeFieldInfoPtr__cllBuildPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TVECBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_time;
    private static readonly System.IntPtr NativeFieldInfoPtr_sinTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_cosTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_unity_DeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_tveCameraPosWs;
    [FieldOffset(0)]
    public Vector4 time;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 sinTime;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 cosTime;
    [FieldOffset(48 /*0x30*/)]
    public Vector4 unity_DeltaTime;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 timeParameters;
    [FieldOffset(80 /*0x50*/)]
    public Vector4 tveCameraPosWs;

    static TVECBufferData()
    {
      Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, nameof (TVECBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr);
      SceneRenderPipeline.TVECBufferData.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr, nameof (time));
      SceneRenderPipeline.TVECBufferData.NativeFieldInfoPtr_sinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr, nameof (sinTime));
      SceneRenderPipeline.TVECBufferData.NativeFieldInfoPtr_cosTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr, nameof (cosTime));
      SceneRenderPipeline.TVECBufferData.NativeFieldInfoPtr_unity_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr, nameof (unity_DeltaTime));
      SceneRenderPipeline.TVECBufferData.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr, nameof (timeParameters));
      SceneRenderPipeline.TVECBufferData.NativeFieldInfoPtr_tveCameraPosWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr, nameof (tveCameraPosWs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneRenderPipeline.TVECBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
