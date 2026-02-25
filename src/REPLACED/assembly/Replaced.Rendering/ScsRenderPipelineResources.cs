// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ScsRenderPipelineResources
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ScsRenderPipelineResources(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_integrateDfgLutCompute;
  private static readonly IntPtr NativeFieldInfoPtr_integrateSpecularLdShader;
  private static readonly IntPtr NativeFieldInfoPtr_clusteredLightListBuildCompute;
  private static readonly IntPtr NativeFieldInfoPtr_clusteredLightListHeatmapShader;
  private static readonly IntPtr NativeFieldInfoPtr_texDfgLut;
  private static readonly IntPtr NativeFieldInfoPtr_texBlankSceneNormal;
  private static readonly IntPtr NativeFieldInfoPtr_texWhiteTexture2DArray;
  private static readonly IntPtr NativeFieldInfoPtr_texBlankGlobalIllumination;
  private static readonly IntPtr NativeFieldInfoPtr_generateDensityBufferLitCompute;
  private static readonly IntPtr NativeFieldInfoPtr_cameraScatteredLightIntegrationCompute;
  private static readonly IntPtr NativeFieldInfoPtr_texBlankScatteringTransmittance;
  private static readonly IntPtr NativeFieldInfoPtr_texVolumetric3DNoise;
  private static readonly IntPtr NativeFieldInfoPtr_texVolumetric3DCurlNoise;
  private static readonly IntPtr NativeFieldInfoPtr_texCelestialBodyBaseColor;
  private static readonly IntPtr NativeFieldInfoPtr_generateHIZCompute;
  private static readonly IntPtr NativeFieldInfoPtr_copyDepthShader;
  private static readonly IntPtr NativeFieldInfoPtr_downsampleSceneDataCompute;
  private static readonly IntPtr NativeFieldInfoPtr_radianceSourceGenerationCompute;
  private static readonly IntPtr NativeFieldInfoPtr_radianceSourceFilteringCompute;
  private static readonly IntPtr NativeFieldInfoPtr_ssdoEstimateCompute;
  private static readonly IntPtr NativeFieldInfoPtr_ssdoFilterCompute;
  private static readonly IntPtr NativeFieldInfoPtr_ssrTraceCompute;
  private static readonly IntPtr NativeFieldInfoPtr_ssrResolveCompute;
  private static readonly IntPtr NativeFieldInfoPtr_ssrFilterCompute;
  private static readonly IntPtr NativeFieldInfoPtr_ssrTemporalCompute;
  private static readonly IntPtr NativeFieldInfoPtr_resolveColorShader;
  private static readonly IntPtr NativeFieldInfoPtr_resolveDepthShader;
  private static readonly IntPtr NativeFieldInfoPtr_downsampleMaxDepth4x4;
  private static readonly IntPtr NativeFieldInfoPtr_skyAndCloudsShader;
  private static readonly IntPtr NativeFieldInfoPtr_upscaleSkyAndCloudsShader;
  private static readonly IntPtr NativeFieldInfoPtr_texLowFrequencyCloudNoise;
  private static readonly IntPtr NativeFieldInfoPtr_texCloudDetailNoise;
  private static readonly IntPtr NativeFieldInfoPtr_generateMipmapsSceneColorCompute;
  private static readonly IntPtr NativeFieldInfoPtr_colorGradingLutCompute;
  private static readonly IntPtr NativeFieldInfoPtr_taaCompute;
  private static readonly IntPtr NativeFieldInfoPtr_depthOfFieldComputeCocCompute;
  private static readonly IntPtr NativeFieldInfoPtr_depthOfFieldCocStabilizationCompute;
  private static readonly IntPtr NativeFieldInfoPtr_depthOfFieldRenderBokehShader;
  private static readonly IntPtr NativeFieldInfoPtr_depthOfFieldBokehTaa;
  private static readonly IntPtr NativeFieldInfoPtr_depthOfFieldDofBlurV3Compute;
  private static readonly IntPtr NativeFieldInfoPtr_depthOfFieldComposeDofImageShader;
  private static readonly IntPtr NativeFieldInfoPtr_depthOfFieldDebug;
  private static readonly IntPtr NativeFieldInfoPtr_bloomPrefilerCompute;
  private static readonly IntPtr NativeFieldInfoPtr_bloomBlurCompute;
  private static readonly IntPtr NativeFieldInfoPtr_finalBlitShader;
  private static readonly IntPtr NativeFieldInfoPtr_uiColorResolveCompute;
  private static readonly IntPtr NativeFieldInfoPtr_uiFinalShader;
  private static readonly IntPtr NativeFieldInfoPtr_singleColorShader;
  private static readonly IntPtr NativeFieldInfoPtr_presentShadowMapCascadesShader;
  private static readonly IntPtr NativeFieldInfoPtr_presentToCameraRTShader;
  private static readonly IntPtr NativeFieldInfoPtr_decalShader;
  private static readonly IntPtr NativeFieldInfoPtr_maskDecalShader;
  private static readonly IntPtr NativeFieldInfoPtr_pixelizationBlitShader;
  private static readonly IntPtr NativeFieldInfoPtr_lineRenderingShader;
  private static readonly IntPtr NativeFieldInfoPtr_gaussianBlurDevdbg;
  private static readonly IntPtr NativeFieldInfoPtr_previewCameraFinalBlitShader;
  private static readonly IntPtr NativeMethodInfoPtr_LogComputeShaderMessagesIfAny_Private_Static_Int32_String_ComputeShader_0;
  private static readonly IntPtr NativeMethodInfoPtr_ValidateResources_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ScsRenderPipelineResources()
  {
    Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ScsRenderPipelineResources));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr);
    ScsRenderPipelineResources.NativeFieldInfoPtr_integrateDfgLutCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (integrateDfgLutCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_integrateSpecularLdShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (integrateSpecularLdShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_clusteredLightListBuildCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (clusteredLightListBuildCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_clusteredLightListHeatmapShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (clusteredLightListHeatmapShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texDfgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texDfgLut));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankSceneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texBlankSceneNormal));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texWhiteTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texWhiteTexture2DArray));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texBlankGlobalIllumination));
    ScsRenderPipelineResources.NativeFieldInfoPtr_generateDensityBufferLitCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (generateDensityBufferLitCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_cameraScatteredLightIntegrationCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (cameraScatteredLightIntegrationCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankScatteringTransmittance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texBlankScatteringTransmittance));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texVolumetric3DNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texVolumetric3DNoise));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texVolumetric3DCurlNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texVolumetric3DCurlNoise));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texCelestialBodyBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texCelestialBodyBaseColor));
    ScsRenderPipelineResources.NativeFieldInfoPtr_generateHIZCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (generateHIZCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_copyDepthShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (copyDepthShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_downsampleSceneDataCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (downsampleSceneDataCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_radianceSourceGenerationCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (radianceSourceGenerationCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_radianceSourceFilteringCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (radianceSourceFilteringCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_ssdoEstimateCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (ssdoEstimateCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_ssdoFilterCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (ssdoFilterCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_ssrTraceCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (ssrTraceCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_ssrResolveCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (ssrResolveCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_ssrFilterCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (ssrFilterCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_ssrTemporalCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (ssrTemporalCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_resolveColorShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (resolveColorShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_resolveDepthShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (resolveDepthShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_downsampleMaxDepth4x4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (downsampleMaxDepth4x4));
    ScsRenderPipelineResources.NativeFieldInfoPtr_skyAndCloudsShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (skyAndCloudsShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_upscaleSkyAndCloudsShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (upscaleSkyAndCloudsShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texLowFrequencyCloudNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texLowFrequencyCloudNoise));
    ScsRenderPipelineResources.NativeFieldInfoPtr_texCloudDetailNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (texCloudDetailNoise));
    ScsRenderPipelineResources.NativeFieldInfoPtr_generateMipmapsSceneColorCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (generateMipmapsSceneColorCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_colorGradingLutCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (colorGradingLutCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_taaCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (taaCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldComputeCocCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (depthOfFieldComputeCocCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldCocStabilizationCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (depthOfFieldCocStabilizationCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldRenderBokehShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (depthOfFieldRenderBokehShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldBokehTaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (depthOfFieldBokehTaa));
    ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldDofBlurV3Compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (depthOfFieldDofBlurV3Compute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldComposeDofImageShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (depthOfFieldComposeDofImageShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (depthOfFieldDebug));
    ScsRenderPipelineResources.NativeFieldInfoPtr_bloomPrefilerCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (bloomPrefilerCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_bloomBlurCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (bloomBlurCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_finalBlitShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (finalBlitShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_uiColorResolveCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (uiColorResolveCompute));
    ScsRenderPipelineResources.NativeFieldInfoPtr_uiFinalShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (uiFinalShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_singleColorShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (singleColorShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_presentShadowMapCascadesShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (presentShadowMapCascadesShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_presentToCameraRTShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (presentToCameraRTShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_decalShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (decalShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_maskDecalShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (maskDecalShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_pixelizationBlitShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (pixelizationBlitShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_lineRenderingShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (lineRenderingShader));
    ScsRenderPipelineResources.NativeFieldInfoPtr_gaussianBlurDevdbg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (gaussianBlurDevdbg));
    ScsRenderPipelineResources.NativeFieldInfoPtr_previewCameraFinalBlitShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, nameof (previewCameraFinalBlitShader));
    ScsRenderPipelineResources.NativeMethodInfoPtr_LogComputeShaderMessagesIfAny_Private_Static_Int32_String_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, 100664336 /*0x06000410*/);
    ScsRenderPipelineResources.NativeMethodInfoPtr_ValidateResources_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, 100664337);
    ScsRenderPipelineResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr, 100664338);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int LogComputeShaderMessagesIfAny(string fieldName, ComputeShader compute)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineResources.NativeMethodInfoPtr_LogComputeShaderMessagesIfAny_Private_Static_Int32_String_ComputeShader_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936529, RefRangeEnd = 936530, XrefRangeStart = 936499, XrefRangeEnd = 936529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateResources()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineResources.NativeMethodInfoPtr_ValidateResources_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScsRenderPipelineResources()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScsRenderPipelineResources>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ComputeShader integrateDfgLutCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_integrateDfgLutCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_integrateDfgLutCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader integrateSpecularLdShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_integrateSpecularLdShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_integrateSpecularLdShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader clusteredLightListBuildCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_clusteredLightListBuildCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_clusteredLightListBuildCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader clusteredLightListHeatmapShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_clusteredLightListHeatmapShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_clusteredLightListHeatmapShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D texDfgLut
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texDfgLut));
      return num == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texDfgLut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D texBlankSceneNormal
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankSceneNormal));
      return num == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankSceneNormal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2DArray texWhiteTexture2DArray
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texWhiteTexture2DArray));
      return num == IntPtr.Zero ? (Texture2DArray) null : Il2CppObjectPool.Get<Texture2DArray>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texWhiteTexture2DArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2DArray texBlankGlobalIllumination
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankGlobalIllumination));
      return num == IntPtr.Zero ? (Texture2DArray) null : Il2CppObjectPool.Get<Texture2DArray>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankGlobalIllumination), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader generateDensityBufferLitCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_generateDensityBufferLitCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_generateDensityBufferLitCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader cameraScatteredLightIntegrationCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_cameraScatteredLightIntegrationCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_cameraScatteredLightIntegrationCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D texBlankScatteringTransmittance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankScatteringTransmittance));
      return num == IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texBlankScatteringTransmittance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D texVolumetric3DNoise
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texVolumetric3DNoise));
      return num == IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texVolumetric3DNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D texVolumetric3DCurlNoise
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texVolumetric3DCurlNoise));
      return num == IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texVolumetric3DCurlNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D texCelestialBodyBaseColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texCelestialBodyBaseColor));
      return num == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texCelestialBodyBaseColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader generateHIZCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_generateHIZCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_generateHIZCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader copyDepthShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_copyDepthShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_copyDepthShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader downsampleSceneDataCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_downsampleSceneDataCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_downsampleSceneDataCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader radianceSourceGenerationCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_radianceSourceGenerationCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_radianceSourceGenerationCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader radianceSourceFilteringCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_radianceSourceFilteringCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_radianceSourceFilteringCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader ssdoEstimateCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssdoEstimateCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssdoEstimateCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader ssdoFilterCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssdoFilterCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssdoFilterCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader ssrTraceCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrTraceCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrTraceCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader ssrResolveCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrResolveCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrResolveCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader ssrFilterCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrFilterCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrFilterCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader ssrTemporalCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrTemporalCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_ssrTemporalCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader resolveColorShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_resolveColorShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_resolveColorShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader resolveDepthShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_resolveDepthShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_resolveDepthShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader downsampleMaxDepth4x4
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_downsampleMaxDepth4x4));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_downsampleMaxDepth4x4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader skyAndCloudsShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_skyAndCloudsShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_skyAndCloudsShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader upscaleSkyAndCloudsShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_upscaleSkyAndCloudsShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_upscaleSkyAndCloudsShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D texLowFrequencyCloudNoise
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texLowFrequencyCloudNoise));
      return num == IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texLowFrequencyCloudNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D texCloudDetailNoise
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texCloudDetailNoise));
      return num == IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_texCloudDetailNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader generateMipmapsSceneColorCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_generateMipmapsSceneColorCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_generateMipmapsSceneColorCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader colorGradingLutCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_colorGradingLutCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_colorGradingLutCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader taaCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_taaCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_taaCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader depthOfFieldComputeCocCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldComputeCocCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldComputeCocCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader depthOfFieldCocStabilizationCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldCocStabilizationCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldCocStabilizationCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader depthOfFieldRenderBokehShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldRenderBokehShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldRenderBokehShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader depthOfFieldBokehTaa
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldBokehTaa));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldBokehTaa), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader depthOfFieldDofBlurV3Compute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldDofBlurV3Compute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldDofBlurV3Compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader depthOfFieldComposeDofImageShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldComposeDofImageShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldComposeDofImageShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader depthOfFieldDebug
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldDebug));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_depthOfFieldDebug), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader bloomPrefilerCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_bloomPrefilerCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_bloomPrefilerCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader bloomBlurCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_bloomBlurCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_bloomBlurCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader finalBlitShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_finalBlitShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_finalBlitShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader uiColorResolveCompute
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_uiColorResolveCompute));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_uiColorResolveCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader uiFinalShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_uiFinalShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_uiFinalShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader singleColorShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_singleColorShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_singleColorShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader presentShadowMapCascadesShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_presentShadowMapCascadesShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_presentShadowMapCascadesShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader presentToCameraRTShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_presentToCameraRTShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_presentToCameraRTShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader decalShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_decalShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_decalShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader maskDecalShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_maskDecalShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_maskDecalShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader pixelizationBlitShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_pixelizationBlitShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_pixelizationBlitShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader lineRenderingShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_lineRenderingShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_lineRenderingShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader gaussianBlurDevdbg
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_gaussianBlurDevdbg));
      return num == IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_gaussianBlurDevdbg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader previewCameraFinalBlitShader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_previewCameraFinalBlitShader));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineResources.NativeFieldInfoPtr_previewCameraFinalBlitShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
