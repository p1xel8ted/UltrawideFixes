// Decompiled with JetBrains decompiler
// Type: UnityEngine.QualitySettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class QualitySettings(System.IntPtr pointer) : Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_activeQualityLevelChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_desiredColorSpace_Public_Static_get_ColorSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0;
  private static readonly QualitySettings.get_shadowsDelegate get_shadowsDelegateField;
  private static readonly QualitySettings.set_shadowsDelegate set_shadowsDelegateField;
  private static readonly QualitySettings.get_shadowProjectionDelegate get_shadowProjectionDelegateField;
  private static readonly QualitySettings.set_shadowProjectionDelegate set_shadowProjectionDelegateField;
  private static readonly QualitySettings.get_shadowCascadesDelegate get_shadowCascadesDelegateField;
  private static readonly QualitySettings.set_shadowCascadesDelegate set_shadowCascadesDelegateField;
  private static readonly QualitySettings.get_shadowDistanceDelegate get_shadowDistanceDelegateField;
  private static readonly QualitySettings.set_shadowDistanceDelegate set_shadowDistanceDelegateField;
  private static readonly QualitySettings.get_shadowResolutionDelegate get_shadowResolutionDelegateField;
  private static readonly QualitySettings.set_shadowResolutionDelegate set_shadowResolutionDelegateField;
  private static readonly QualitySettings.get_shadowmaskModeDelegate get_shadowmaskModeDelegateField;
  private static readonly QualitySettings.set_shadowmaskModeDelegate set_shadowmaskModeDelegateField;
  private static readonly QualitySettings.get_shadowNearPlaneOffsetDelegate get_shadowNearPlaneOffsetDelegateField;
  private static readonly QualitySettings.set_shadowNearPlaneOffsetDelegate set_shadowNearPlaneOffsetDelegateField;
  private static readonly QualitySettings.get_shadowCascade2SplitDelegate get_shadowCascade2SplitDelegateField;
  private static readonly QualitySettings.set_shadowCascade2SplitDelegate set_shadowCascade2SplitDelegateField;
  private static readonly QualitySettings.get_lodBiasDelegate get_lodBiasDelegateField;
  private static readonly QualitySettings.set_lodBiasDelegate set_lodBiasDelegateField;
  private static readonly QualitySettings.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;
  private static readonly QualitySettings.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;
  private static readonly QualitySettings.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;
  private static readonly QualitySettings.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;
  private static readonly QualitySettings.get_globalTextureMipmapLimitDelegate get_globalTextureMipmapLimitDelegateField;
  private static readonly QualitySettings.set_globalTextureMipmapLimitDelegate set_globalTextureMipmapLimitDelegateField;
  private static readonly QualitySettings.get_maximumLODLevelDelegate get_maximumLODLevelDelegateField;
  private static readonly QualitySettings.set_maximumLODLevelDelegate set_maximumLODLevelDelegateField;
  private static readonly QualitySettings.get_enableLODCrossFadeDelegate get_enableLODCrossFadeDelegateField;
  private static readonly QualitySettings.set_enableLODCrossFadeDelegate set_enableLODCrossFadeDelegateField;
  private static readonly QualitySettings.get_particleRaycastBudgetDelegate get_particleRaycastBudgetDelegateField;
  private static readonly QualitySettings.set_particleRaycastBudgetDelegate set_particleRaycastBudgetDelegateField;
  private static readonly QualitySettings.get_softParticlesDelegate get_softParticlesDelegateField;
  private static readonly QualitySettings.set_softParticlesDelegate set_softParticlesDelegateField;
  private static readonly QualitySettings.get_softVegetationDelegate get_softVegetationDelegateField;
  private static readonly QualitySettings.set_softVegetationDelegate set_softVegetationDelegateField;
  private static readonly QualitySettings.get_realtimeGICPUUsageDelegate get_realtimeGICPUUsageDelegateField;
  private static readonly QualitySettings.set_realtimeGICPUUsageDelegate set_realtimeGICPUUsageDelegateField;
  private static readonly QualitySettings.get_antiAliasingDelegate get_antiAliasingDelegateField;
  private static readonly QualitySettings.set_antiAliasingDelegate set_antiAliasingDelegateField;
  private static readonly QualitySettings.get_asyncUploadTimeSliceDelegate get_asyncUploadTimeSliceDelegateField;
  private static readonly QualitySettings.set_asyncUploadTimeSliceDelegate set_asyncUploadTimeSliceDelegateField;
  private static readonly QualitySettings.get_asyncUploadBufferSizeDelegate get_asyncUploadBufferSizeDelegateField;
  private static readonly QualitySettings.set_asyncUploadBufferSizeDelegate set_asyncUploadBufferSizeDelegateField;
  private static readonly QualitySettings.get_asyncUploadPersistentBufferDelegate get_asyncUploadPersistentBufferDelegateField;
  private static readonly QualitySettings.set_asyncUploadPersistentBufferDelegate set_asyncUploadPersistentBufferDelegateField;
  private static readonly QualitySettings.SetLODSettingsDelegate SetLODSettingsDelegateField;
  private static readonly QualitySettings.get_realtimeReflectionProbesDelegate get_realtimeReflectionProbesDelegateField;
  private static readonly QualitySettings.set_realtimeReflectionProbesDelegate set_realtimeReflectionProbesDelegateField;
  private static readonly QualitySettings.get_billboardsFaceCameraPositionDelegate get_billboardsFaceCameraPositionDelegateField;
  private static readonly QualitySettings.set_billboardsFaceCameraPositionDelegate set_billboardsFaceCameraPositionDelegateField;
  private static readonly QualitySettings.get_useLegacyDetailDistributionDelegate get_useLegacyDetailDistributionDelegateField;
  private static readonly QualitySettings.set_useLegacyDetailDistributionDelegate set_useLegacyDetailDistributionDelegateField;
  private static readonly QualitySettings.get_resolutionScalingFixedDPIFactorDelegate get_resolutionScalingFixedDPIFactorDelegateField;
  private static readonly QualitySettings.set_resolutionScalingFixedDPIFactorDelegate set_resolutionScalingFixedDPIFactorDelegateField;
  private static readonly QualitySettings.get_terrainQualityOverridesDelegate get_terrainQualityOverridesDelegateField;
  private static readonly QualitySettings.set_terrainQualityOverridesDelegate set_terrainQualityOverridesDelegateField;
  private static readonly QualitySettings.get_terrainPixelErrorDelegate get_terrainPixelErrorDelegateField;
  private static readonly QualitySettings.set_terrainPixelErrorDelegate set_terrainPixelErrorDelegateField;
  private static readonly QualitySettings.get_terrainDetailDensityScaleDelegate get_terrainDetailDensityScaleDelegateField;
  private static readonly QualitySettings.set_terrainDetailDensityScaleDelegate set_terrainDetailDensityScaleDelegateField;
  private static readonly QualitySettings.get_terrainBasemapDistanceDelegate get_terrainBasemapDistanceDelegateField;
  private static readonly QualitySettings.set_terrainBasemapDistanceDelegate set_terrainBasemapDistanceDelegateField;
  private static readonly QualitySettings.get_terrainDetailDistanceDelegate get_terrainDetailDistanceDelegateField;
  private static readonly QualitySettings.set_terrainDetailDistanceDelegate set_terrainDetailDistanceDelegateField;
  private static readonly QualitySettings.get_terrainTreeDistanceDelegate get_terrainTreeDistanceDelegateField;
  private static readonly QualitySettings.set_terrainTreeDistanceDelegate set_terrainTreeDistanceDelegateField;
  private static readonly QualitySettings.get_terrainBillboardStartDelegate get_terrainBillboardStartDelegateField;
  private static readonly QualitySettings.set_terrainBillboardStartDelegate set_terrainBillboardStartDelegateField;
  private static readonly QualitySettings.get_terrainFadeLengthDelegate get_terrainFadeLengthDelegateField;
  private static readonly QualitySettings.set_terrainFadeLengthDelegate set_terrainFadeLengthDelegateField;
  private static readonly QualitySettings.get_terrainMaxTreesDelegate get_terrainMaxTreesDelegateField;
  private static readonly QualitySettings.set_terrainMaxTreesDelegate set_terrainMaxTreesDelegateField;
  private static readonly QualitySettings.get_blendWeightsDelegate get_blendWeightsDelegateField;
  private static readonly QualitySettings.set_blendWeightsDelegate set_blendWeightsDelegateField;
  private static readonly QualitySettings.get_skinWeightsDelegate get_skinWeightsDelegateField;
  private static readonly QualitySettings.set_skinWeightsDelegate set_skinWeightsDelegateField;
  private static readonly QualitySettings.get_countDelegate get_countDelegateField;
  private static readonly QualitySettings.GetStrippedMaximumLODLevelDelegate GetStrippedMaximumLODLevelDelegateField;
  private static readonly QualitySettings.SetStrippedMaximumLODLevelDelegate SetStrippedMaximumLODLevelDelegateField;
  private static readonly QualitySettings.get_streamingMipmapsActiveDelegate get_streamingMipmapsActiveDelegateField;
  private static readonly QualitySettings.set_streamingMipmapsActiveDelegate set_streamingMipmapsActiveDelegateField;
  private static readonly QualitySettings.get_streamingMipmapsMemoryBudgetDelegate get_streamingMipmapsMemoryBudgetDelegateField;
  private static readonly QualitySettings.set_streamingMipmapsMemoryBudgetDelegate set_streamingMipmapsMemoryBudgetDelegateField;
  private static readonly QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate get_streamingMipmapsRenderersPerFrameDelegateField;
  private static readonly QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate set_streamingMipmapsRenderersPerFrameDelegateField;
  private static readonly QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate get_streamingMipmapsMaxLevelReductionDelegateField;
  private static readonly QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate set_streamingMipmapsMaxLevelReductionDelegateField;
  private static readonly QualitySettings.get_streamingMipmapsAddAllCamerasDelegate get_streamingMipmapsAddAllCamerasDelegateField;
  private static readonly QualitySettings.set_streamingMipmapsAddAllCamerasDelegate set_streamingMipmapsAddAllCamerasDelegateField;
  private static readonly QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate get_streamingMipmapsMaxFileIORequestsDelegateField;
  private static readonly QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate set_streamingMipmapsMaxFileIORequestsDelegateField;
  private static readonly QualitySettings.get_maxQueuedFramesDelegate get_maxQueuedFramesDelegateField;
  private static readonly QualitySettings.set_maxQueuedFramesDelegate set_maxQueuedFramesDelegateField;
  private static readonly QualitySettings.GetQualityLevelDelegate GetQualityLevelDelegateField;
  private static readonly QualitySettings.SetQualityLevelDelegate SetQualityLevelDelegateField;
  private static readonly QualitySettings.get_namesDelegate get_namesDelegateField;
  private static readonly QualitySettings.get_shadowCascade4Split_InjectedDelegate get_shadowCascade4Split_InjectedDelegateField;
  private static readonly QualitySettings.set_shadowCascade4Split_InjectedDelegate set_shadowCascade4Split_InjectedDelegateField;
  private static readonly QualitySettings.get_INTERNAL_renderPipeline_InjectedDelegate get_INTERNAL_renderPipeline_InjectedDelegateField;
  private static readonly QualitySettings.set_INTERNAL_renderPipeline_InjectedDelegate set_INTERNAL_renderPipeline_InjectedDelegateField;
  private static readonly QualitySettings.InternalGetRenderPipelineAssetAt_InjectedDelegate InternalGetRenderPipelineAssetAt_InjectedDelegateField;
  private static readonly QualitySettings.GetQualitySettings_InjectedDelegate GetQualitySettings_InjectedDelegateField;

  static QualitySettings()
  {
    Il2CppClassPointerStore<QualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (QualitySettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr);
    QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, nameof (activeQualityLevelChanged));
    QualitySettings.NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664810);
    QualitySettings.NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664811);
    QualitySettings.NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664812);
    QualitySettings.NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664813);
    QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664814);
    QualitySettings.NativeMethodInfoPtr_get_desiredColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664815);
    QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664816 /*0x060005F0*/);
    QualitySettings.get_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowsDelegate>("UnityEngine.QualitySettings::get_shadows");
    QualitySettings.set_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowsDelegate>("UnityEngine.QualitySettings::set_shadows");
    QualitySettings.get_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowProjectionDelegate>("UnityEngine.QualitySettings::get_shadowProjection");
    QualitySettings.set_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowProjectionDelegate>("UnityEngine.QualitySettings::set_shadowProjection");
    QualitySettings.get_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascadesDelegate>("UnityEngine.QualitySettings::get_shadowCascades");
    QualitySettings.set_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascadesDelegate>("UnityEngine.QualitySettings::set_shadowCascades");
    QualitySettings.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowDistanceDelegate>("UnityEngine.QualitySettings::get_shadowDistance");
    QualitySettings.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowDistanceDelegate>("UnityEngine.QualitySettings::set_shadowDistance");
    QualitySettings.get_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowResolutionDelegate>("UnityEngine.QualitySettings::get_shadowResolution");
    QualitySettings.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowResolutionDelegate>("UnityEngine.QualitySettings::set_shadowResolution");
    QualitySettings.get_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowmaskModeDelegate>("UnityEngine.QualitySettings::get_shadowmaskMode");
    QualitySettings.set_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowmaskModeDelegate>("UnityEngine.QualitySettings::set_shadowmaskMode");
    QualitySettings.get_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::get_shadowNearPlaneOffset");
    QualitySettings.set_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::set_shadowNearPlaneOffset");
    QualitySettings.get_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::get_shadowCascade2Split");
    QualitySettings.set_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::set_shadowCascade2Split");
    QualitySettings.get_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_lodBiasDelegate>("UnityEngine.QualitySettings::get_lodBias");
    QualitySettings.set_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_lodBiasDelegate>("UnityEngine.QualitySettings::set_lodBias");
    QualitySettings.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.get_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::get_anisotropicFiltering");
    QualitySettings.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.set_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::set_anisotropicFiltering");
    QualitySettings.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_masterTextureLimitDelegate>("UnityEngine.QualitySettings::get_masterTextureLimit");
    QualitySettings.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_masterTextureLimitDelegate>("UnityEngine.QualitySettings::set_masterTextureLimit");
    QualitySettings.get_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::get_globalTextureMipmapLimit");
    QualitySettings.set_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::set_globalTextureMipmapLimit");
    QualitySettings.get_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maximumLODLevelDelegate>("UnityEngine.QualitySettings::get_maximumLODLevel");
    QualitySettings.set_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maximumLODLevelDelegate>("UnityEngine.QualitySettings::set_maximumLODLevel");
    QualitySettings.get_enableLODCrossFadeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_enableLODCrossFadeDelegate>("UnityEngine.QualitySettings::get_enableLODCrossFade");
    QualitySettings.set_enableLODCrossFadeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_enableLODCrossFadeDelegate>("UnityEngine.QualitySettings::set_enableLODCrossFade");
    QualitySettings.get_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::get_particleRaycastBudget");
    QualitySettings.set_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::set_particleRaycastBudget");
    QualitySettings.get_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softParticlesDelegate>("UnityEngine.QualitySettings::get_softParticles");
    QualitySettings.set_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softParticlesDelegate>("UnityEngine.QualitySettings::set_softParticles");
    QualitySettings.get_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softVegetationDelegate>("UnityEngine.QualitySettings::get_softVegetation");
    QualitySettings.set_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softVegetationDelegate>("UnityEngine.QualitySettings::set_softVegetation");
    QualitySettings.get_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::get_realtimeGICPUUsage");
    QualitySettings.set_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::set_realtimeGICPUUsage");
    QualitySettings.get_antiAliasingDelegateField = IL2CPP.ResolveICall<QualitySettings.get_antiAliasingDelegate>("UnityEngine.QualitySettings::get_antiAliasing");
    QualitySettings.set_antiAliasingDelegateField = IL2CPP.ResolveICall<QualitySettings.set_antiAliasingDelegate>("UnityEngine.QualitySettings::set_antiAliasing");
    QualitySettings.get_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::get_asyncUploadTimeSlice");
    QualitySettings.set_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::set_asyncUploadTimeSlice");
    QualitySettings.get_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::get_asyncUploadBufferSize");
    QualitySettings.set_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::set_asyncUploadBufferSize");
    QualitySettings.get_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::get_asyncUploadPersistentBuffer");
    QualitySettings.set_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::set_asyncUploadPersistentBuffer");
    QualitySettings.SetLODSettingsDelegateField = IL2CPP.ResolveICall<QualitySettings.SetLODSettingsDelegate>("UnityEngine.QualitySettings::SetLODSettings");
    QualitySettings.get_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::get_realtimeReflectionProbes");
    QualitySettings.set_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::set_realtimeReflectionProbes");
    QualitySettings.get_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::get_billboardsFaceCameraPosition");
    QualitySettings.set_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::set_billboardsFaceCameraPosition");
    QualitySettings.get_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::get_useLegacyDetailDistribution");
    QualitySettings.set_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::set_useLegacyDetailDistribution");
    QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::get_resolutionScalingFixedDPIFactor");
    QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::set_resolutionScalingFixedDPIFactor");
    QualitySettings.get_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::get_terrainQualityOverrides");
    QualitySettings.set_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::set_terrainQualityOverrides");
    QualitySettings.get_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::get_terrainPixelError");
    QualitySettings.set_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::set_terrainPixelError");
    QualitySettings.get_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::get_terrainDetailDensityScale");
    QualitySettings.set_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::set_terrainDetailDensityScale");
    QualitySettings.get_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::get_terrainBasemapDistance");
    QualitySettings.set_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::set_terrainBasemapDistance");
    QualitySettings.get_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::get_terrainDetailDistance");
    QualitySettings.set_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::set_terrainDetailDistance");
    QualitySettings.get_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::get_terrainTreeDistance");
    QualitySettings.set_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::set_terrainTreeDistance");
    QualitySettings.get_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::get_terrainBillboardStart");
    QualitySettings.set_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::set_terrainBillboardStart");
    QualitySettings.get_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::get_terrainFadeLength");
    QualitySettings.set_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::set_terrainFadeLength");
    QualitySettings.get_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::get_terrainMaxTrees");
    QualitySettings.set_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::set_terrainMaxTrees");
    QualitySettings.get_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_blendWeightsDelegate>("UnityEngine.QualitySettings::get_blendWeights");
    QualitySettings.set_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_blendWeightsDelegate>("UnityEngine.QualitySettings::set_blendWeights");
    QualitySettings.get_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_skinWeightsDelegate>("UnityEngine.QualitySettings::get_skinWeights");
    QualitySettings.set_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_skinWeightsDelegate>("UnityEngine.QualitySettings::set_skinWeights");
    QualitySettings.get_countDelegateField = IL2CPP.ResolveICall<QualitySettings.get_countDelegate>("UnityEngine.QualitySettings::get_count");
    QualitySettings.GetStrippedMaximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.GetStrippedMaximumLODLevelDelegate>("UnityEngine.QualitySettings::GetStrippedMaximumLODLevel");
    QualitySettings.SetStrippedMaximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.SetStrippedMaximumLODLevelDelegate>("UnityEngine.QualitySettings::SetStrippedMaximumLODLevel");
    QualitySettings.get_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsActive");
    QualitySettings.set_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsActive");
    QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMemoryBudget");
    QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMemoryBudget");
    QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsRenderersPerFrame");
    QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsRenderersPerFrame");
    QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxLevelReduction");
    QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxLevelReduction");
    QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsAddAllCameras");
    QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsAddAllCameras");
    QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxFileIORequests");
    QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxFileIORequests");
    QualitySettings.get_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::get_maxQueuedFrames");
    QualitySettings.set_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::set_maxQueuedFrames");
    QualitySettings.GetQualityLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.GetQualityLevelDelegate>("UnityEngine.QualitySettings::GetQualityLevel");
    QualitySettings.SetQualityLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.SetQualityLevelDelegate>("UnityEngine.QualitySettings::SetQualityLevel");
    QualitySettings.get_namesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_namesDelegate>("UnityEngine.QualitySettings::get_names");
    QualitySettings.get_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::get_shadowCascade4Split_Injected");
    QualitySettings.set_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::set_shadowCascade4Split_Injected");
    QualitySettings.get_INTERNAL_renderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.get_INTERNAL_renderPipeline_InjectedDelegate>("UnityEngine.QualitySettings::get_INTERNAL_renderPipeline_Injected");
    QualitySettings.set_INTERNAL_renderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.set_INTERNAL_renderPipeline_InjectedDelegate>("UnityEngine.QualitySettings::set_INTERNAL_renderPipeline_Injected");
    QualitySettings.InternalGetRenderPipelineAssetAt_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.InternalGetRenderPipelineAssetAt_InjectedDelegate>("UnityEngine.QualitySettings::InternalGetRenderPipelineAssetAt_Injected");
    QualitySettings.GetQualitySettings_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.GetQualitySettings_InjectedDelegate>("UnityEngine.QualitySettings::GetQualitySettings_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423854, XrefRangeEnd = 423856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnActiveQualityLevelChanged(
    int previousQualityLevel,
    int currentQualityLevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &previousQualityLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentQualityLevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int pixelLightCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423856, XrefRangeEnd = 423858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423858, XrefRangeEnd = 423860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe int vSyncCount
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 423862, RefRangeEnd = 423864, XrefRangeStart = 423860, XrefRangeEnd = 423862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 423866, RefRangeEnd = 423868, XrefRangeStart = 423864, XrefRangeEnd = 423866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe ColorSpace desiredColorSpace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_desiredColorSpace_Public_Static_get_ColorSpace_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe ColorSpace activeColorSpace
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 423870, RefRangeEnd = 423883, XrefRangeStart = 423868, XrefRangeEnd = 423870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Il2CppSystem.Action<int, int> activeQualityLevelChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<int, int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int, int>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [SpecialName]
  public static void add_activeQualityLevelChanged(Il2CppSystem.Action<int, int> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_activeQualityLevelChanged(Il2CppSystem.Action<int, int> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void IncreaseLevel(bool applyExpensiveChanges)
  {
    QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() + 1, applyExpensiveChanges);
  }

  public static void DecreaseLevel(bool applyExpensiveChanges)
  {
    QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() - 1, applyExpensiveChanges);
  }

  public static void SetQualityLevel(int index) => QualitySettings.SetQualityLevel(index, true);

  public static void IncreaseLevel() => QualitySettings.IncreaseLevel(false);

  public static void DecreaseLevel() => QualitySettings.DecreaseLevel(false);

  public static QualityLevel currentLevel
  {
    get => (QualityLevel) QualitySettings.GetQualityLevel();
    set => QualitySettings.SetQualityLevel((int) value, true);
  }

  public static void ForEach(Il2CppSystem.Action callback)
  {
    if (callback == null)
      return;
    int qualityLevel = QualitySettings.GetQualityLevel();
    try
    {
      for (int index = 0; index < QualitySettings.count; ++index)
      {
        QualitySettings.SetQualityLevel(index, false);
        callback.Invoke();
      }
    }
    finally
    {
      QualitySettings.SetQualityLevel(qualityLevel, false);
    }
  }

  public static void ForEach(Il2CppSystem.Action<int, string> callback)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static ShadowQuality shadows
  {
    get => QualitySettings.get_shadowsDelegateField();
    set => QualitySettings.set_shadowsDelegateField(value);
  }

  public static ShadowProjection shadowProjection
  {
    get => QualitySettings.get_shadowProjectionDelegateField();
    set => QualitySettings.set_shadowProjectionDelegateField(value);
  }

  public static int shadowCascades
  {
    get => QualitySettings.get_shadowCascadesDelegateField();
    set => QualitySettings.set_shadowCascadesDelegateField(value);
  }

  public static float shadowDistance
  {
    get => QualitySettings.get_shadowDistanceDelegateField();
    set => QualitySettings.set_shadowDistanceDelegateField(value);
  }

  public static ShadowResolution shadowResolution
  {
    get => QualitySettings.get_shadowResolutionDelegateField();
    set => QualitySettings.set_shadowResolutionDelegateField(value);
  }

  public static ShadowmaskMode shadowmaskMode
  {
    get => QualitySettings.get_shadowmaskModeDelegateField();
    set => QualitySettings.set_shadowmaskModeDelegateField(value);
  }

  public static float shadowNearPlaneOffset
  {
    get => QualitySettings.get_shadowNearPlaneOffsetDelegateField();
    set => QualitySettings.set_shadowNearPlaneOffsetDelegateField(value);
  }

  public static float shadowCascade2Split
  {
    get => QualitySettings.get_shadowCascade2SplitDelegateField();
    set => QualitySettings.set_shadowCascade2SplitDelegateField(value);
  }

  public static Vector3 shadowCascade4Split
  {
    get
    {
      Vector3 ret;
      QualitySettings.get_shadowCascade4Split_Injected(out ret);
      return ret;
    }
    set => QualitySettings.set_shadowCascade4Split_Injected(ref value);
  }

  public static float lodBias
  {
    get => QualitySettings.get_lodBiasDelegateField();
    set => QualitySettings.set_lodBiasDelegateField(value);
  }

  public static AnisotropicFiltering anisotropicFiltering
  {
    get => QualitySettings.get_anisotropicFilteringDelegateField();
    set => QualitySettings.set_anisotropicFilteringDelegateField(value);
  }

  public static int masterTextureLimit
  {
    get => QualitySettings.get_masterTextureLimitDelegateField();
    set => QualitySettings.set_masterTextureLimitDelegateField(value);
  }

  public static int globalTextureMipmapLimit
  {
    get => QualitySettings.get_globalTextureMipmapLimitDelegateField();
    set => QualitySettings.set_globalTextureMipmapLimitDelegateField(value);
  }

  public static int maximumLODLevel
  {
    get => QualitySettings.get_maximumLODLevelDelegateField();
    set => QualitySettings.set_maximumLODLevelDelegateField(value);
  }

  public static bool enableLODCrossFade
  {
    get => QualitySettings.get_enableLODCrossFadeDelegateField();
    set => QualitySettings.set_enableLODCrossFadeDelegateField(value);
  }

  public static int particleRaycastBudget
  {
    get => QualitySettings.get_particleRaycastBudgetDelegateField();
    set => QualitySettings.set_particleRaycastBudgetDelegateField(value);
  }

  public static bool softParticles
  {
    get => QualitySettings.get_softParticlesDelegateField();
    set => QualitySettings.set_softParticlesDelegateField(value);
  }

  public static bool softVegetation
  {
    get => QualitySettings.get_softVegetationDelegateField();
    set => QualitySettings.set_softVegetationDelegateField(value);
  }

  public static int realtimeGICPUUsage
  {
    get => QualitySettings.get_realtimeGICPUUsageDelegateField();
    set => QualitySettings.set_realtimeGICPUUsageDelegateField(value);
  }

  public static int antiAliasing
  {
    get => QualitySettings.get_antiAliasingDelegateField();
    set => QualitySettings.set_antiAliasingDelegateField(value);
  }

  public static int asyncUploadTimeSlice
  {
    get => QualitySettings.get_asyncUploadTimeSliceDelegateField();
    set => QualitySettings.set_asyncUploadTimeSliceDelegateField(value);
  }

  public static int asyncUploadBufferSize
  {
    get => QualitySettings.get_asyncUploadBufferSizeDelegateField();
    set => QualitySettings.set_asyncUploadBufferSizeDelegateField(value);
  }

  public static bool asyncUploadPersistentBuffer
  {
    get => QualitySettings.get_asyncUploadPersistentBufferDelegateField();
    set => QualitySettings.set_asyncUploadPersistentBufferDelegateField(value);
  }

  public static void SetLODSettings(float lodBias, int maximumLODLevel, bool setDirty = default (bool))
  {
    QualitySettings.SetLODSettingsDelegateField(lodBias, maximumLODLevel, setDirty);
  }

  public static bool realtimeReflectionProbes
  {
    get => QualitySettings.get_realtimeReflectionProbesDelegateField();
    set => QualitySettings.set_realtimeReflectionProbesDelegateField(value);
  }

  public static bool billboardsFaceCameraPosition
  {
    get => QualitySettings.get_billboardsFaceCameraPositionDelegateField();
    set => QualitySettings.set_billboardsFaceCameraPositionDelegateField(value);
  }

  public static bool useLegacyDetailDistribution
  {
    get => QualitySettings.get_useLegacyDetailDistributionDelegateField();
    set => QualitySettings.set_useLegacyDetailDistributionDelegateField(value);
  }

  public static float resolutionScalingFixedDPIFactor
  {
    get => QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField();
    set => QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField(value);
  }

  public static TerrainQualityOverrides terrainQualityOverrides
  {
    get => QualitySettings.get_terrainQualityOverridesDelegateField();
    set => QualitySettings.set_terrainQualityOverridesDelegateField(value);
  }

  public static float terrainPixelError
  {
    get => QualitySettings.get_terrainPixelErrorDelegateField();
    set => QualitySettings.set_terrainPixelErrorDelegateField(value);
  }

  public static float terrainDetailDensityScale
  {
    get => QualitySettings.get_terrainDetailDensityScaleDelegateField();
    set => QualitySettings.set_terrainDetailDensityScaleDelegateField(value);
  }

  public static float terrainBasemapDistance
  {
    get => QualitySettings.get_terrainBasemapDistanceDelegateField();
    set => QualitySettings.set_terrainBasemapDistanceDelegateField(value);
  }

  public static float terrainDetailDistance
  {
    get => QualitySettings.get_terrainDetailDistanceDelegateField();
    set => QualitySettings.set_terrainDetailDistanceDelegateField(value);
  }

  public static float terrainTreeDistance
  {
    get => QualitySettings.get_terrainTreeDistanceDelegateField();
    set => QualitySettings.set_terrainTreeDistanceDelegateField(value);
  }

  public static float terrainBillboardStart
  {
    get => QualitySettings.get_terrainBillboardStartDelegateField();
    set => QualitySettings.set_terrainBillboardStartDelegateField(value);
  }

  public static float terrainFadeLength
  {
    get => QualitySettings.get_terrainFadeLengthDelegateField();
    set => QualitySettings.set_terrainFadeLengthDelegateField(value);
  }

  public static float terrainMaxTrees
  {
    get => QualitySettings.get_terrainMaxTreesDelegateField();
    set => QualitySettings.set_terrainMaxTreesDelegateField(value);
  }

  public static ScriptableObject INTERNAL_renderPipeline
  {
    get
    {
      return Unmarshal.UnmarshalUnityObject<ScriptableObject>(QualitySettings.get_INTERNAL_renderPipeline_Injected());
    }
    set
    {
      QualitySettings.set_INTERNAL_renderPipeline_Injected(Object.MarshalledUnityObject.Marshal<ScriptableObject>(value));
    }
  }

  public static RenderPipelineAsset renderPipeline
  {
    get => QualitySettings.INTERNAL_renderPipeline.TryCast<RenderPipelineAsset>();
    set => QualitySettings.INTERNAL_renderPipeline = (ScriptableObject) value;
  }

  public static ScriptableObject InternalGetRenderPipelineAssetAt(int index)
  {
    return Unmarshal.UnmarshalUnityObject<ScriptableObject>(QualitySettings.InternalGetRenderPipelineAssetAt_Injected(index));
  }

  public static RenderPipelineAsset GetRenderPipelineAssetAt(int index)
  {
    if (index < 0 || index >= ((Il2CppArrayBase) QualitySettings.names).Length)
      throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Format("{0} is out of range [0..{1}[", (Il2CppSystem.Object) nameof (index), (Il2CppSystem.Object) (System.ValueType) ((Il2CppArrayBase) QualitySettings.names).Length));
    return QualitySettings.InternalGetRenderPipelineAssetAt(index).TryCast<RenderPipelineAsset>();
  }

  public static BlendWeights blendWeights
  {
    get => QualitySettings.get_blendWeightsDelegateField();
    set => QualitySettings.set_blendWeightsDelegateField(value);
  }

  public static SkinWeights skinWeights
  {
    get => QualitySettings.get_skinWeightsDelegateField();
    set => QualitySettings.set_skinWeightsDelegateField(value);
  }

  public static int count => QualitySettings.get_countDelegateField();

  public static int GetStrippedMaximumLODLevel()
  {
    return QualitySettings.GetStrippedMaximumLODLevelDelegateField();
  }

  public static void SetStrippedMaximumLODLevel(int maximumLODLevel)
  {
    QualitySettings.SetStrippedMaximumLODLevelDelegateField(maximumLODLevel);
  }

  public static bool streamingMipmapsActive
  {
    get => QualitySettings.get_streamingMipmapsActiveDelegateField();
    set => QualitySettings.set_streamingMipmapsActiveDelegateField(value);
  }

  public static float streamingMipmapsMemoryBudget
  {
    get => QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField();
    set => QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField(value);
  }

  public static int streamingMipmapsRenderersPerFrame
  {
    get => QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField();
    set => QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField(value);
  }

  public static int streamingMipmapsMaxLevelReduction
  {
    get => QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField();
    set => QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField(value);
  }

  public static bool streamingMipmapsAddAllCameras
  {
    get => QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField();
    set => QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField(value);
  }

  public static int streamingMipmapsMaxFileIORequests
  {
    get => QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField();
    set => QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField(value);
  }

  public static int maxQueuedFrames
  {
    get => QualitySettings.get_maxQueuedFramesDelegateField();
    set => QualitySettings.set_maxQueuedFramesDelegateField(value);
  }

  public static int GetQualityLevel() => QualitySettings.GetQualityLevelDelegateField();

  public static Object GetQualitySettings()
  {
    return Unmarshal.UnmarshalUnityObject<Object>(QualitySettings.GetQualitySettings_Injected());
  }

  public static void SetQualityLevel(int index, bool applyExpensiveChanges)
  {
    QualitySettings.SetQualityLevelDelegateField(index, applyExpensiveChanges);
  }

  public static Il2CppStringArray names
  {
    get
    {
      System.IntPtr num = QualitySettings.get_namesDelegateField();
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
  }

  public static void get_shadowCascade4Split_Injected(out Vector3 ret)
  {
    QualitySettings.get_shadowCascade4Split_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void set_shadowCascade4Split_Injected([In] ref Vector3 value)
  {
    QualitySettings.set_shadowCascade4Split_InjectedDelegateField((System.IntPtr) ref value);
  }

  public static System.IntPtr get_INTERNAL_renderPipeline_Injected()
  {
    return QualitySettings.get_INTERNAL_renderPipeline_InjectedDelegateField();
  }

  public static void set_INTERNAL_renderPipeline_Injected(System.IntPtr value)
  {
    QualitySettings.set_INTERNAL_renderPipeline_InjectedDelegateField(value);
  }

  public static System.IntPtr InternalGetRenderPipelineAssetAt_Injected(int index)
  {
    return QualitySettings.InternalGetRenderPipelineAssetAt_InjectedDelegateField(index);
  }

  public static System.IntPtr GetQualitySettings_Injected()
  {
    return QualitySettings.GetQualitySettings_InjectedDelegateField();
  }

  private delegate ShadowQuality get_shadowsDelegate();

  private delegate void set_shadowsDelegate(ShadowQuality value);

  private delegate ShadowProjection get_shadowProjectionDelegate();

  private delegate void set_shadowProjectionDelegate(ShadowProjection value);

  private delegate int get_shadowCascadesDelegate();

  private delegate void set_shadowCascadesDelegate(int value);

  private delegate float get_shadowDistanceDelegate();

  private delegate void set_shadowDistanceDelegate(float value);

  private delegate ShadowResolution get_shadowResolutionDelegate();

  private delegate void set_shadowResolutionDelegate(ShadowResolution value);

  private delegate ShadowmaskMode get_shadowmaskModeDelegate();

  private delegate void set_shadowmaskModeDelegate(ShadowmaskMode value);

  private delegate float get_shadowNearPlaneOffsetDelegate();

  private delegate void set_shadowNearPlaneOffsetDelegate(float value);

  private delegate float get_shadowCascade2SplitDelegate();

  private delegate void set_shadowCascade2SplitDelegate(float value);

  private delegate float get_lodBiasDelegate();

  private delegate void set_lodBiasDelegate(float value);

  private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

  private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

  private delegate int get_masterTextureLimitDelegate();

  private delegate void set_masterTextureLimitDelegate(int value);

  private delegate int get_globalTextureMipmapLimitDelegate();

  private delegate void set_globalTextureMipmapLimitDelegate(int value);

  private delegate int get_maximumLODLevelDelegate();

  private delegate void set_maximumLODLevelDelegate(int value);

  private delegate bool get_enableLODCrossFadeDelegate();

  private delegate void set_enableLODCrossFadeDelegate(bool value);

  private delegate int get_particleRaycastBudgetDelegate();

  private delegate void set_particleRaycastBudgetDelegate(int value);

  private delegate bool get_softParticlesDelegate();

  private delegate void set_softParticlesDelegate(bool value);

  private delegate bool get_softVegetationDelegate();

  private delegate void set_softVegetationDelegate(bool value);

  private delegate int get_realtimeGICPUUsageDelegate();

  private delegate void set_realtimeGICPUUsageDelegate(int value);

  private delegate int get_antiAliasingDelegate();

  private delegate void set_antiAliasingDelegate(int value);

  private delegate int get_asyncUploadTimeSliceDelegate();

  private delegate void set_asyncUploadTimeSliceDelegate(int value);

  private delegate int get_asyncUploadBufferSizeDelegate();

  private delegate void set_asyncUploadBufferSizeDelegate(int value);

  private delegate bool get_asyncUploadPersistentBufferDelegate();

  private delegate void set_asyncUploadPersistentBufferDelegate(bool value);

  private delegate void SetLODSettingsDelegate(float lodBias, int maximumLODLevel, bool setDirty = default (bool));

  private delegate bool get_realtimeReflectionProbesDelegate();

  private delegate void set_realtimeReflectionProbesDelegate(bool value);

  private delegate bool get_billboardsFaceCameraPositionDelegate();

  private delegate void set_billboardsFaceCameraPositionDelegate(bool value);

  private delegate bool get_useLegacyDetailDistributionDelegate();

  private delegate void set_useLegacyDetailDistributionDelegate(bool value);

  private delegate float get_resolutionScalingFixedDPIFactorDelegate();

  private delegate void set_resolutionScalingFixedDPIFactorDelegate(float value);

  private delegate TerrainQualityOverrides get_terrainQualityOverridesDelegate();

  private delegate void set_terrainQualityOverridesDelegate(TerrainQualityOverrides value);

  private delegate float get_terrainPixelErrorDelegate();

  private delegate void set_terrainPixelErrorDelegate(float value);

  private delegate float get_terrainDetailDensityScaleDelegate();

  private delegate void set_terrainDetailDensityScaleDelegate(float value);

  private delegate float get_terrainBasemapDistanceDelegate();

  private delegate void set_terrainBasemapDistanceDelegate(float value);

  private delegate float get_terrainDetailDistanceDelegate();

  private delegate void set_terrainDetailDistanceDelegate(float value);

  private delegate float get_terrainTreeDistanceDelegate();

  private delegate void set_terrainTreeDistanceDelegate(float value);

  private delegate float get_terrainBillboardStartDelegate();

  private delegate void set_terrainBillboardStartDelegate(float value);

  private delegate float get_terrainFadeLengthDelegate();

  private delegate void set_terrainFadeLengthDelegate(float value);

  private delegate float get_terrainMaxTreesDelegate();

  private delegate void set_terrainMaxTreesDelegate(float value);

  private delegate BlendWeights get_blendWeightsDelegate();

  private delegate void set_blendWeightsDelegate(BlendWeights value);

  private delegate SkinWeights get_skinWeightsDelegate();

  private delegate void set_skinWeightsDelegate(SkinWeights value);

  private delegate int get_countDelegate();

  private delegate int GetStrippedMaximumLODLevelDelegate();

  private delegate void SetStrippedMaximumLODLevelDelegate(int maximumLODLevel);

  private delegate bool get_streamingMipmapsActiveDelegate();

  private delegate void set_streamingMipmapsActiveDelegate(bool value);

  private delegate float get_streamingMipmapsMemoryBudgetDelegate();

  private delegate void set_streamingMipmapsMemoryBudgetDelegate(float value);

  private delegate int get_streamingMipmapsRenderersPerFrameDelegate();

  private delegate void set_streamingMipmapsRenderersPerFrameDelegate(int value);

  private delegate int get_streamingMipmapsMaxLevelReductionDelegate();

  private delegate void set_streamingMipmapsMaxLevelReductionDelegate(int value);

  private delegate bool get_streamingMipmapsAddAllCamerasDelegate();

  private delegate void set_streamingMipmapsAddAllCamerasDelegate(bool value);

  private delegate int get_streamingMipmapsMaxFileIORequestsDelegate();

  private delegate void set_streamingMipmapsMaxFileIORequestsDelegate(int value);

  private delegate int get_maxQueuedFramesDelegate();

  private delegate void set_maxQueuedFramesDelegate(int value);

  private delegate int GetQualityLevelDelegate();

  private delegate void SetQualityLevelDelegate(int index, bool applyExpensiveChanges);

  private delegate System.IntPtr get_namesDelegate();

  private delegate void get_shadowCascade4Split_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void set_shadowCascade4Split_InjectedDelegate([In] System.IntPtr value);

  private delegate System.IntPtr get_INTERNAL_renderPipeline_InjectedDelegate();

  private delegate void set_INTERNAL_renderPipeline_InjectedDelegate(System.IntPtr value);

  private delegate System.IntPtr InternalGetRenderPipelineAssetAt_InjectedDelegate(int index);

  private delegate System.IntPtr GetQualitySettings_InjectedDelegate();
}
