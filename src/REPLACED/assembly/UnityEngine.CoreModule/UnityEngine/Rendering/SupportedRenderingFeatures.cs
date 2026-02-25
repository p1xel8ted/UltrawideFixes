// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SupportedRenderingFeatures
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public class SupportedRenderingFeatures(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Active;
  private static readonly System.IntPtr NativeFieldInfoPtr__reflectionProbeModes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__mixedLightingModes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightmapsModes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__enlightenLightmapper_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__enlighten_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__skyOcclusion_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__motionVectors_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__receiveShadows_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__reflectionProbes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__rendererPriority_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__rendersUIOverlay_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesFog_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesLODBias_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__rendererProbes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__particleSystemInstancing_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ambientProbeBaking_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesShadowmask_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__supportsHDR_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__supportsClouds_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientProbeBaking_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultReflectionProbeBaking_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SupportedRenderingFeatures()
  {
    Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SupportedRenderingFeatures));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr);
    SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, nameof (s_Active));
    SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbeModes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultMixedLightingModes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<mixedLightingModes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapBakeTypes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapsModes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlightenLightmapper>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlighten>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__skyOcclusion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<skyOcclusion>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightProbeProxyVolumes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<motionVectors>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<receiveShadows>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbesBlendDistance>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererPriority>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendersUIOverlay>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnvironmentLighting>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesFog>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesRealtimeReflectionProbes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesOtherLightingSettings>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<editableMaterialRenderQueue>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLODBias>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesMaximumLODLevel>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnableLODCrossFade>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererProbes>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<particleSystemInstancing>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__ambientProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<ambientProbeBaking>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultReflectionProbeBaking>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesShadowmask>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystem>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<supportsHDR>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__supportsClouds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<supportsClouds>k__BackingField");
    SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystemWarningMessage>k__BackingField");
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670603);
    SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670604);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670605);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670606);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670607);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670608);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670609);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670610);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_ambientProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670611);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultReflectionProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670612);
    SupportedRenderingFeatures.NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670613);
    SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670614);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670615);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670616);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670617);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670618);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670619);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670620);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670621);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670622);
    SupportedRenderingFeatures.NativeMethodInfoPtr_IsDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670623);
    SupportedRenderingFeatures.NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670624);
    SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670625);
    SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100670626);
  }

  public static unsafe SupportedRenderingFeatures active
  {
    [CallerCount(20), CachedScanResults(RefRangeStart = 488760, RefRangeEnd = 488780, XrefRangeStart = 488748, XrefRangeEnd = 488760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SupportedRenderingFeatures) null : Il2CppObjectPool.Get<SupportedRenderingFeatures>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488780, XrefRangeEnd = 488784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SupportedRenderingFeatures.LightmapMixedBakeModes*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._defaultMixedLightingModes_k__BackingField = value;
  }

  public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SupportedRenderingFeatures.LightmapMixedBakeModes*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._mixedLightingModes_k__BackingField = value;
  }

  public unsafe LightmapBakeType lightmapBakeTypes
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LightmapBakeType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._lightmapBakeTypes_k__BackingField = value;
  }

  public unsafe LightmapsMode lightmapsModes
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LightmapsMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._lightmapsModes_k__BackingField = value;
  }

  public unsafe bool enlighten
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._enlighten_k__BackingField = value;
  }

  public unsafe bool rendersUIOverlay
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._rendersUIOverlay_k__BackingField = value;
  }

  public unsafe bool ambientProbeBaking
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_ambientProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._ambientProbeBaking_k__BackingField = value;
  }

  public unsafe bool defaultReflectionProbeBaking
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultReflectionProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._defaultReflectionProbeBaking_k__BackingField = value;
  }

  public unsafe bool overridesLightProbeSystem
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._overridesLightProbeSystem_k__BackingField = value;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488784, XrefRangeEnd = 488797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FallbackMixedLightingModeByRef(System.IntPtr fallbackModePtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fallbackModePtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488797, XrefRangeEnd = 488818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mixedMode
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488818, XrefRangeEnd = 488826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsMixedLightingModeSupportedByRef(
    MixedLightingMode mixedMode,
    System.IntPtr isSupportedPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &mixedMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSupportedPtr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 488843, RefRangeEnd = 488847, XrefRangeStart = 488826, XrefRangeEnd = 488843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &bakeType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488847, XrefRangeEnd = 488861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsLightmapBakeTypeSupportedByRef(
    LightmapBakeType bakeType,
    System.IntPtr isSupportedPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &bakeType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSupportedPtr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488861, XrefRangeEnd = 488866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsLightmapsModeSupportedByRef(LightmapsMode mode, System.IntPtr isSupportedPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &mode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSupportedPtr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488866, XrefRangeEnd = 488867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsLightmapperSupportedByRef(int lightmapper, System.IntPtr isSupportedPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lightmapper;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSupportedPtr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488867, XrefRangeEnd = 488872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsUIOverlayRenderedBySRP(System.IntPtr isSupportedPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isSupportedPtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488872, XrefRangeEnd = 488877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsAmbientProbeBakingSupported(System.IntPtr isSupportedPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isSupportedPtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488877, XrefRangeEnd = 488882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsDefaultReflectionProbeBakingSupported(System.IntPtr isSupportedPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isSupportedPtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488882, XrefRangeEnd = 488887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OverridesLightProbeSystem(System.IntPtr overridesPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &overridesPtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488887, XrefRangeEnd = 488888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FallbackLightmapperByRef(System.IntPtr lightmapperPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &lightmapperPtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488891, RefRangeEnd = 488892, XrefRangeStart = 488888, XrefRangeEnd = 488891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SupportedRenderingFeatures()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe SupportedRenderingFeatures s_Active
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (SupportedRenderingFeatures) null : Il2CppObjectPool.Get<SupportedRenderingFeatures>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SupportedRenderingFeatures.ReflectionProbeModes _reflectionProbeModes_k__BackingField
  {
    get
    {
      return *(SupportedRenderingFeatures.ReflectionProbeModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField));
    }
    [param: In] set
    {
      *(SupportedRenderingFeatures.ReflectionProbeModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField)) = value;
    }
  }

  public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _defaultMixedLightingModes_k__BackingField
  {
    get
    {
      return *(SupportedRenderingFeatures.LightmapMixedBakeModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField));
    }
    [param: In] set
    {
      *(SupportedRenderingFeatures.LightmapMixedBakeModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField)) = value;
    }
  }

  public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _mixedLightingModes_k__BackingField
  {
    get
    {
      return *(SupportedRenderingFeatures.LightmapMixedBakeModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField));
    }
    [param: In] set
    {
      *(SupportedRenderingFeatures.LightmapMixedBakeModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField)) = value;
    }
  }

  public unsafe LightmapBakeType _lightmapBakeTypes_k__BackingField
  {
    get
    {
      return *(LightmapBakeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField));
    }
    [param: In] set
    {
      *(LightmapBakeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField)) = value;
    }
  }

  public unsafe LightmapsMode _lightmapsModes_k__BackingField
  {
    get
    {
      return *(LightmapsMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField));
    }
    [param: In] set
    {
      *(LightmapsMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField)) = value;
    }
  }

  public unsafe bool _enlightenLightmapper_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField)) = value;
    }
  }

  public unsafe bool _enlighten_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField)) = value;
    }
  }

  public unsafe bool _skyOcclusion_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__skyOcclusion_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__skyOcclusion_k__BackingField)) = value;
    }
  }

  public unsafe bool _lightProbeProxyVolumes_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField)) = value;
    }
  }

  public unsafe bool _motionVectors_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField)) = value;
    }
  }

  public unsafe bool _receiveShadows_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField)) = value;
    }
  }

  public unsafe bool _reflectionProbes_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField)) = value;
    }
  }

  public unsafe bool _reflectionProbesBlendDistance_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField)) = value;
    }
  }

  public unsafe bool _rendererPriority_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField)) = value;
    }
  }

  public unsafe bool _rendersUIOverlay_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesEnvironmentLighting_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesFog_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesRealtimeReflectionProbes_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesOtherLightingSettings_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField)) = value;
    }
  }

  public unsafe bool _editableMaterialRenderQueue_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesLODBias_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesMaximumLODLevel_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesEnableLODCrossFade_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField)) = value;
    }
  }

  public unsafe bool _rendererProbes_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField)) = value;
    }
  }

  public unsafe bool _particleSystemInstancing_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField)) = value;
    }
  }

  public unsafe bool _ambientProbeBaking_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__ambientProbeBaking_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__ambientProbeBaking_k__BackingField)) = value;
    }
  }

  public unsafe bool _defaultReflectionProbeBaking_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesShadowmask_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField)) = value;
    }
  }

  public unsafe bool _overridesLightProbeSystem_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField)) = value;
    }
  }

  public unsafe bool _supportsHDR_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField)) = value;
    }
  }

  public unsafe bool _supportsClouds_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsClouds_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsClouds_k__BackingField)) = value;
    }
  }

  public unsafe string _overridesLightProbeSystemWarningMessage_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public SupportedRenderingFeatures.ReflectionProbeModes reflectionProbeModes
  {
    get => this._reflectionProbeModes_k__BackingField;
    set => this._reflectionProbeModes_k__BackingField = value;
  }

  public bool enlightenLightmapper
  {
    get => this._enlightenLightmapper_k__BackingField;
    set => this._enlightenLightmapper_k__BackingField = value;
  }

  public bool skyOcclusion
  {
    get => this._skyOcclusion_k__BackingField;
    set => this._skyOcclusion_k__BackingField = value;
  }

  public bool lightProbeProxyVolumes
  {
    get => this._lightProbeProxyVolumes_k__BackingField;
    set => this._lightProbeProxyVolumes_k__BackingField = value;
  }

  public bool motionVectors
  {
    get => this._motionVectors_k__BackingField;
    set => this._motionVectors_k__BackingField = value;
  }

  public bool receiveShadows
  {
    get => this._receiveShadows_k__BackingField;
    set => this._receiveShadows_k__BackingField = value;
  }

  public bool reflectionProbes
  {
    get => this._reflectionProbes_k__BackingField;
    set => this._reflectionProbes_k__BackingField = value;
  }

  public bool reflectionProbesBlendDistance
  {
    get => this._reflectionProbesBlendDistance_k__BackingField;
    set => this._reflectionProbesBlendDistance_k__BackingField = value;
  }

  public bool rendererPriority
  {
    get => this._rendererPriority_k__BackingField;
    set => this._rendererPriority_k__BackingField = value;
  }

  public bool overridesEnvironmentLighting
  {
    get => this._overridesEnvironmentLighting_k__BackingField;
    set => this._overridesEnvironmentLighting_k__BackingField = value;
  }

  public bool overridesFog
  {
    get => this._overridesFog_k__BackingField;
    set => this._overridesFog_k__BackingField = value;
  }

  public bool overridesRealtimeReflectionProbes
  {
    get => this._overridesRealtimeReflectionProbes_k__BackingField;
    set => this._overridesRealtimeReflectionProbes_k__BackingField = value;
  }

  public bool overridesOtherLightingSettings
  {
    get => this._overridesOtherLightingSettings_k__BackingField;
    set => this._overridesOtherLightingSettings_k__BackingField = value;
  }

  public bool editableMaterialRenderQueue
  {
    get => this._editableMaterialRenderQueue_k__BackingField;
    set => this._editableMaterialRenderQueue_k__BackingField = value;
  }

  public bool overridesLODBias
  {
    get => this._overridesLODBias_k__BackingField;
    set => this._overridesLODBias_k__BackingField = value;
  }

  public bool overridesMaximumLODLevel
  {
    get => this._overridesMaximumLODLevel_k__BackingField;
    set => this._overridesMaximumLODLevel_k__BackingField = value;
  }

  public bool overridesEnableLODCrossFade
  {
    get => this._overridesEnableLODCrossFade_k__BackingField;
    set => this._overridesEnableLODCrossFade_k__BackingField = value;
  }

  public bool rendererProbes
  {
    get => this._rendererProbes_k__BackingField;
    set => this._rendererProbes_k__BackingField = value;
  }

  public bool particleSystemInstancing
  {
    get => this._particleSystemInstancing_k__BackingField;
    set => this._particleSystemInstancing_k__BackingField = value;
  }

  public bool autoAmbientProbeBaking
  {
    get => this.ambientProbeBaking;
    set => this.ambientProbeBaking = value;
  }

  public bool autoDefaultReflectionProbeBaking
  {
    get => this.defaultReflectionProbeBaking;
    set => this.defaultReflectionProbeBaking = value;
  }

  public bool overridesShadowmask
  {
    get => this._overridesShadowmask_k__BackingField;
    set => this._overridesShadowmask_k__BackingField = value;
  }

  public bool supportsHDR
  {
    get => this._supportsHDR_k__BackingField;
    set => this._supportsHDR_k__BackingField = value;
  }

  public bool supportsClouds
  {
    get => this._supportsClouds_k__BackingField;
    set => this._supportsClouds_k__BackingField = value;
  }

  public string overridesLightProbeSystemWarningMessage
  {
    get => this._overridesLightProbeSystemWarningMessage_k__BackingField;
    set => this._overridesLightProbeSystemWarningMessage_k__BackingField = value;
  }

  public static unsafe MixedLightingMode FallbackMixedLightingMode()
  {
    MixedLightingMode mixedLightingMode;
    SupportedRenderingFeatures.FallbackMixedLightingModeByRef(new System.IntPtr((void*) &mixedLightingMode));
    return mixedLightingMode;
  }

  public static unsafe bool IsLightmapsModeSupported(LightmapsMode mode)
  {
    bool flag;
    SupportedRenderingFeatures.IsLightmapsModeSupportedByRef(mode, new System.IntPtr((void*) &flag));
    return flag;
  }

  public static unsafe bool IsLightmapperSupported(int lightmapper)
  {
    bool flag;
    SupportedRenderingFeatures.IsLightmapperSupportedByRef(lightmapper, new System.IntPtr((void*) &flag));
    return flag;
  }

  public static unsafe int FallbackLightmapper()
  {
    int num;
    SupportedRenderingFeatures.FallbackLightmapperByRef(new System.IntPtr((void*) &num));
    return num;
  }

  public bool terrainDetailUnsupported
  {
    get => true;
    set
    {
    }
  }

  [Flags]
  public enum ReflectionProbeModes
  {
    None = 0,
    Rotation = 1,
  }

  [Flags]
  public enum LightmapMixedBakeModes
  {
    None = 0,
    IndirectOnly = 1,
    Subtractive = 2,
    Shadowmask = 4,
  }
}
