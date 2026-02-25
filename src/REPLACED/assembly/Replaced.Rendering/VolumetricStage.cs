// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumetricStage
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

public class VolumetricStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCameraScatteredLightResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexBlankScatteringExtinctionDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__texBlankScatteringTransmittance;
  private static readonly System.IntPtr NativeFieldInfoPtr__noiseTextureMipmapLevelCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__generateDensityBufferLitPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__cameraScatteredLightIntegrationPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__mediumManager;
  private static readonly System.IntPtr NativeFieldInfoPtr__cullingResults;
  private static readonly System.IntPtr NativeFieldInfoPtr__vbuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ParticipatingMediumManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeFrame_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeFrame_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeVolumetricPasses_Private_Void_CommandBuffer_SceneFrame_byref_MediumCullingResult_byref_VolumetricParams_byref_VBufferParams_byref_VolumetricSampleData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_CameraType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_0;

  static VolumetricStage()
  {
    Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumetricStage));
    VolumetricStage.NativeFieldInfoPtr_kSidTexCameraScatteredLightResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (kSidTexCameraScatteredLightResult));
    VolumetricStage.NativeFieldInfoPtr_kTexBlankScatteringExtinctionDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (kTexBlankScatteringExtinctionDesc));
    VolumetricStage.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_cbuffer));
    VolumetricStage.NativeFieldInfoPtr__texBlankScatteringTransmittance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_texBlankScatteringTransmittance));
    VolumetricStage.NativeFieldInfoPtr__noiseTextureMipmapLevelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_noiseTextureMipmapLevelCount));
    VolumetricStage.NativeFieldInfoPtr__generateDensityBufferLitPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_generateDensityBufferLitPass));
    VolumetricStage.NativeFieldInfoPtr__cameraScatteredLightIntegrationPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_cameraScatteredLightIntegrationPass));
    VolumetricStage.NativeFieldInfoPtr__mediumManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_mediumManager));
    VolumetricStage.NativeFieldInfoPtr__cullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_cullingResults));
    VolumetricStage.NativeFieldInfoPtr__vbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (_vbuffer));
    VolumetricStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ParticipatingMediumManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664285);
    VolumetricStage.NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664286);
    VolumetricStage.NativeMethodInfoPtr_EncodeFrame_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664287);
    VolumetricStage.NativeMethodInfoPtr_EncodeFrame_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664288 /*0x060003E0*/);
    VolumetricStage.NativeMethodInfoPtr_EncodeVolumetricPasses_Private_Void_CommandBuffer_SceneFrame_byref_MediumCullingResult_byref_VolumetricParams_byref_VBufferParams_byref_VolumetricSampleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664289);
    VolumetricStage.NativeMethodInfoPtr_EndFrame_Public_Void_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664290);
    VolumetricStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664291);
    VolumetricStage.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, 100664292);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936024, XrefRangeEnd = 936053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VolumetricStage(
    ScsRenderPipelineResources resources,
    ParticipatingMediumManager mediumManager)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mediumManager);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ParticipatingMediumManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936070, RefRangeEnd = 936071, XrefRangeStart = 936053, XrefRangeEnd = 936070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginFrame(
    CommandBuffer cmd,
    Vector3Int volumeSize,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &volumeSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936071, XrefRangeEnd = 936080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeFrame(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr_EncodeFrame_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 936127, RefRangeEnd = 936130, XrefRangeStart = 936080, XrefRangeEnd = 936127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeFrame(CommandBuffer cmd, SceneFrame frame, [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr_EncodeFrame_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936157, RefRangeEnd = 936158, XrefRangeStart = 936130, XrefRangeEnd = 936157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeVolumetricPasses(
    CommandBuffer cmd,
    SceneFrame frame,
    [In] ref MediumCullingResult mediumCullingResult,
    [In] ref VolumetricParams volumetric,
    [In] ref VBufferParams vbuffer,
    [In] ref VolumetricSampleData volumetricSampleData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mediumCullingResult);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumetric;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref vbuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumetricSampleData;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr_EncodeVolumetricPasses_Private_Void_CommandBuffer_SceneFrame_byref_MediumCullingResult_byref_VolumetricParams_byref_VBufferParams_byref_VolumetricSampleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void EndFrame(CameraType cameraType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &cameraType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr_EndFrame_Public_Void_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936158, XrefRangeEnd = 936175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936216, RefRangeEnd = 936217, XrefRangeStart = 936175, XrefRangeEnd = 936216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref VBufferParams vbuffer,
    [In] ref VolumetricParams volumetric)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vbuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumetric;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricStage.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexCameraScatteredLightResult
  {
    get
    {
      int scatteredLightResult;
      IL2CPP.il2cpp_field_static_get_value(VolumetricStage.NativeFieldInfoPtr_kSidTexCameraScatteredLightResult, (void*) &scatteredLightResult);
      return scatteredLightResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VolumetricStage.NativeFieldInfoPtr_kSidTexCameraScatteredLightResult, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor kTexBlankScatteringExtinctionDesc
  {
    get
    {
      RenderTextureDescriptor scatteringExtinctionDesc;
      IL2CPP.il2cpp_field_static_get_value(VolumetricStage.NativeFieldInfoPtr_kTexBlankScatteringExtinctionDesc, (void*) &scatteringExtinctionDesc);
      return scatteringExtinctionDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VolumetricStage.NativeFieldInfoPtr_kTexBlankScatteringExtinctionDesc, (void*) &value);
    }
  }

  public unsafe CBuffer<VolumetricStage.CommonVolumetricCBuffer> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<VolumetricStage.CommonVolumetricCBuffer>) null : Il2CppObjectPool.Get<CBuffer<VolumetricStage.CommonVolumetricCBuffer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D _texBlankScatteringTransmittance
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__texBlankScatteringTransmittance));
      return num == System.IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__texBlankScatteringTransmittance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float _noiseTextureMipmapLevelCount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__noiseTextureMipmapLevelCount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__noiseTextureMipmapLevelCount)) = value;
    }
  }

  public unsafe GenerateDensityBufferLitPass _generateDensityBufferLitPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__generateDensityBufferLitPass));
      return num == System.IntPtr.Zero ? (GenerateDensityBufferLitPass) null : Il2CppObjectPool.Get<GenerateDensityBufferLitPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__generateDensityBufferLitPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CameraScatteredLightIntegrationPass _cameraScatteredLightIntegrationPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__cameraScatteredLightIntegrationPass));
      return num == System.IntPtr.Zero ? (CameraScatteredLightIntegrationPass) null : Il2CppObjectPool.Get<CameraScatteredLightIntegrationPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__cameraScatteredLightIntegrationPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticipatingMediumManager _mediumManager
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__mediumManager));
      return num == System.IntPtr.Zero ? (ParticipatingMediumManager) null : Il2CppObjectPool.Get<ParticipatingMediumManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__mediumManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Il2CppSystem.Nullable<MediumCullingResult> _cullingResults
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__cullingResults);
      return new Il2CppSystem.Nullable<MediumCullingResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<MediumCullingResult>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__cullingResults), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<MediumCullingResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<VBufferParams> _vbuffer
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__vbuffer);
      return new Il2CppSystem.Nullable<VBufferParams>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<VBufferParams>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumetricStage.NativeFieldInfoPtr__vbuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<VBufferParams>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct CommonVolumetricCBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_volumeSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumeSizeRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumeProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumeViewPositionWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumeViewForwardWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_index2DepthParams;
    private static readonly System.IntPtr NativeFieldInfoPtr_depth2IndexParams;
    private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneLeftTopWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneRightSpanWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneDownSpanWs;
    [FieldOffset(0)]
    public Vector4 volumeSize;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 volumeSizeRcp;
    [FieldOffset(32 /*0x20*/)]
    public Matrix4x4 volumeProjectionViewMatrix;
    [FieldOffset(96 /*0x60*/)]
    public Vector4 volumeViewPositionWs;
    [FieldOffset(112 /*0x70*/)]
    public Vector4 volumeViewForwardWs;
    [FieldOffset(128 /*0x80*/)]
    public Vector4 index2DepthParams;
    [FieldOffset(144 /*0x90*/)]
    public Vector4 depth2IndexParams;
    [FieldOffset(160 /*0xA0*/)]
    public Vector4 nearPlaneLeftTopWs;
    [FieldOffset(176 /*0xB0*/)]
    public Vector4 nearPlaneRightSpanWs;
    [FieldOffset(192 /*0xC0*/)]
    public Vector4 nearPlaneDownSpanWs;

    static CommonVolumetricCBuffer()
    {
      Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricStage>.NativeClassPtr, nameof (CommonVolumetricCBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr);
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_volumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (volumeSize));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_volumeSizeRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (volumeSizeRcp));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_volumeProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (volumeProjectionViewMatrix));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_volumeViewPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (volumeViewPositionWs));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_volumeViewForwardWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (volumeViewForwardWs));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_index2DepthParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (index2DepthParams));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_depth2IndexParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (depth2IndexParams));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_nearPlaneLeftTopWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (nearPlaneLeftTopWs));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_nearPlaneRightSpanWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (nearPlaneRightSpanWs));
      VolumetricStage.CommonVolumetricCBuffer.NativeFieldInfoPtr_nearPlaneDownSpanWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, nameof (nearPlaneDownSpanWs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumetricStage.CommonVolumetricCBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
