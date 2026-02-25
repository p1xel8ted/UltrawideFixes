// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GraphicsSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class GraphicsSettings(System.IntPtr pointer) : UnityEngine.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isScriptableRenderPipelineEnabled_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_currentRenderPipelineAssetType_Public_Static_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultShader_Internal_Static_Shader_DefaultShaderType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultMaterial_Internal_Static_Material_DefaultMaterialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Private_Static_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetCurrentRenderPipelineGlobalSettings_Private_Static_RenderPipelineGlobalSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentRenderPipelineGlobalSettings_Public_Static_Boolean_byref_RenderPipelineGlobalSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderPipelineSettings_Public_Static_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Injected_Private_Static_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly GraphicsSettings.get_transparencySortModeDelegate get_transparencySortModeDelegateField;
  private static readonly GraphicsSettings.set_transparencySortModeDelegate set_transparencySortModeDelegateField;
  private static readonly GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate get_realtimeDirectRectangularAreaLightsDelegateField;
  private static readonly GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate set_realtimeDirectRectangularAreaLightsDelegateField;
  private static readonly GraphicsSettings.set_lightsUseLinearIntensityDelegate set_lightsUseLinearIntensityDelegateField;
  private static readonly GraphicsSettings.get_lightsUseColorTemperatureDelegate get_lightsUseColorTemperatureDelegateField;
  private static readonly GraphicsSettings.set_lightsUseColorTemperatureDelegate set_lightsUseColorTemperatureDelegateField;
  private static readonly GraphicsSettings.get_defaultRenderingLayerMaskDelegate get_defaultRenderingLayerMaskDelegateField;
  private static readonly GraphicsSettings.set_defaultRenderingLayerMaskDelegate set_defaultRenderingLayerMaskDelegateField;
  private static readonly GraphicsSettings.get_defaultGateFitModeDelegate get_defaultGateFitModeDelegateField;
  private static readonly GraphicsSettings.set_defaultGateFitModeDelegate set_defaultGateFitModeDelegateField;
  private static readonly GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate get_useScriptableRenderPipelineBatchingDelegateField;
  private static readonly GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegate set_useScriptableRenderPipelineBatchingDelegateField;
  private static readonly GraphicsSettings.get_logWhenShaderIsCompiledDelegate get_logWhenShaderIsCompiledDelegateField;
  private static readonly GraphicsSettings.set_logWhenShaderIsCompiledDelegate set_logWhenShaderIsCompiledDelegateField;
  private static readonly GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate get_disableBuiltinCustomRenderTextureUpdateDelegateField;
  private static readonly GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate set_disableBuiltinCustomRenderTextureUpdateDelegateField;
  private static readonly GraphicsSettings.get_videoShadersIncludeModeDelegate get_videoShadersIncludeModeDelegateField;
  private static readonly GraphicsSettings.get_lightProbeOutsideHullStrategyDelegate get_lightProbeOutsideHullStrategyDelegateField;
  private static readonly GraphicsSettings.set_lightProbeOutsideHullStrategyDelegate set_lightProbeOutsideHullStrategyDelegateField;
  private static readonly GraphicsSettings.HasShaderDefineDelegate HasShaderDefineDelegateField;
  private static readonly GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate GetAllConfiguredRenderPipelinesDelegateField;
  private static readonly GraphicsSettings.SetShaderModeDelegate SetShaderModeDelegateField;
  private static readonly GraphicsSettings.GetShaderModeDelegate GetShaderModeDelegateField;
  private static readonly GraphicsSettings.get_cameraRelativeLightCullingDelegate get_cameraRelativeLightCullingDelegateField;
  private static readonly GraphicsSettings.set_cameraRelativeLightCullingDelegate set_cameraRelativeLightCullingDelegateField;
  private static readonly GraphicsSettings.get_cameraRelativeShadowCullingDelegate get_cameraRelativeShadowCullingDelegateField;
  private static readonly GraphicsSettings.set_cameraRelativeShadowCullingDelegate set_cameraRelativeShadowCullingDelegateField;
  private static readonly GraphicsSettings.Internal_RegisterRenderPipeline_InjectedDelegate Internal_RegisterRenderPipeline_InjectedDelegateField;
  private static readonly GraphicsSettings.Internal_UnregisterRenderPipeline_InjectedDelegate Internal_UnregisterRenderPipeline_InjectedDelegateField;
  private static readonly GraphicsSettings.get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField;
  private static readonly GraphicsSettings.set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField;
  private static readonly GraphicsSettings.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;
  private static readonly GraphicsSettings.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;
  private static readonly GraphicsSettings.get_INTERNAL_defaultRenderPipeline_InjectedDelegate get_INTERNAL_defaultRenderPipeline_InjectedDelegateField;
  private static readonly GraphicsSettings.set_INTERNAL_defaultRenderPipeline_InjectedDelegate set_INTERNAL_defaultRenderPipeline_InjectedDelegateField;
  private static readonly GraphicsSettings.GetGraphicsSettings_InjectedDelegate GetGraphicsSettings_InjectedDelegateField;
  private static readonly GraphicsSettings.SetCustomShader_InjectedDelegate SetCustomShader_InjectedDelegateField;
  private static readonly GraphicsSettings.GetCustomShader_InjectedDelegate GetCustomShader_InjectedDelegateField;

  static GraphicsSettings()
  {
    Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GraphicsSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
    GraphicsSettings.NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (s_CurrentRenderPipelineGlobalSettings));
    GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669685);
    GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669686);
    GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669687);
    GraphicsSettings.NativeMethodInfoPtr_get_isScriptableRenderPipelineEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669688);
    GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipelineAssetType_Public_Static_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669689);
    GraphicsSettings.NativeMethodInfoPtr_GetDefaultShader_Internal_Static_Shader_DefaultShaderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669690);
    GraphicsSettings.NativeMethodInfoPtr_GetDefaultMaterial_Internal_Static_Material_DefaultMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669691);
    GraphicsSettings.NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Private_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669692);
    GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669693);
    GraphicsSettings.NativeMethodInfoPtr_Internal_GetCurrentRenderPipelineGlobalSettings_Private_Static_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669694);
    GraphicsSettings.NativeMethodInfoPtr_TryGetCurrentRenderPipelineGlobalSettings_Public_Static_Boolean_byref_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669695);
    GraphicsSettings.NativeMethodInfoPtr_GetRenderPipelineSettings_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669696 /*0x06001900*/);
    GraphicsSettings.NativeMethodInfoPtr_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669697);
    GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669699);
    GraphicsSettings.NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100669700);
    GraphicsSettings.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortMode");
    GraphicsSettings.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortMode");
    GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::get_realtimeDirectRectangularAreaLights");
    GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::set_realtimeDirectRectangularAreaLights");
    GraphicsSettings.set_lightsUseLinearIntensityDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightsUseLinearIntensityDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightsUseLinearIntensity");
    GraphicsSettings.get_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightsUseColorTemperature");
    GraphicsSettings.set_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightsUseColorTemperature");
    GraphicsSettings.get_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultRenderingLayerMask");
    GraphicsSettings.set_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::set_defaultRenderingLayerMask");
    GraphicsSettings.get_defaultGateFitModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_defaultGateFitModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultGateFitMode");
    GraphicsSettings.set_defaultGateFitModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_defaultGateFitModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_defaultGateFitMode");
    GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_useScriptableRenderPipelineBatching");
    GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_useScriptableRenderPipelineBatching");
    GraphicsSettings.get_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::get_logWhenShaderIsCompiled");
    GraphicsSettings.set_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::set_logWhenShaderIsCompiled");
    GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::get_disableBuiltinCustomRenderTextureUpdate");
    GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::set_disableBuiltinCustomRenderTextureUpdate");
    GraphicsSettings.get_videoShadersIncludeModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_videoShadersIncludeModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_videoShadersIncludeMode");
    GraphicsSettings.get_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightProbeOutsideHullStrategy");
    GraphicsSettings.set_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightProbeOutsideHullStrategy");
    GraphicsSettings.HasShaderDefineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.HasShaderDefineDelegate>("UnityEngine.Rendering.GraphicsSettings::HasShaderDefine");
    GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate>("UnityEngine.Rendering.GraphicsSettings::GetAllConfiguredRenderPipelines");
    GraphicsSettings.SetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::SetShaderMode");
    GraphicsSettings.GetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::GetShaderMode");
    GraphicsSettings.get_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeLightCulling");
    GraphicsSettings.set_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeLightCulling");
    GraphicsSettings.get_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeShadowCulling");
    GraphicsSettings.set_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeShadowCulling");
    GraphicsSettings.Internal_RegisterRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.Internal_RegisterRenderPipeline_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::Internal_RegisterRenderPipeline_Injected");
    GraphicsSettings.Internal_UnregisterRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.Internal_UnregisterRenderPipeline_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::Internal_UnregisterRenderPipeline_Injected");
    GraphicsSettings.get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_currentRenderPipelineGlobalSettings_Injected");
    GraphicsSettings.set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_currentRenderPipelineGlobalSettings_Injected");
    GraphicsSettings.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortAxis_Injected");
    GraphicsSettings.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortAxis_Injected");
    GraphicsSettings.get_INTERNAL_defaultRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_INTERNAL_defaultRenderPipeline_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_defaultRenderPipeline_Injected");
    GraphicsSettings.set_INTERNAL_defaultRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_INTERNAL_defaultRenderPipeline_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline_Injected");
    GraphicsSettings.GetGraphicsSettings_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetGraphicsSettings_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::GetGraphicsSettings_Injected");
    GraphicsSettings.SetCustomShader_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetCustomShader_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::SetCustomShader_Injected");
    GraphicsSettings.GetCustomShader_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetCustomShader_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::GetCustomShader_Injected");
  }

  public static unsafe bool lightsUseLinearIntensity
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 482338, RefRangeEnd = 482345, XrefRangeStart = 482336, XrefRangeEnd = 482338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => GraphicsSettings.set_lightsUseLinearIntensityDelegateField(value);
  }

  public static unsafe ScriptableObject INTERNAL_currentRenderPipeline
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 482353, RefRangeEnd = 482357, XrefRangeStart = 482345, XrefRangeEnd = 482353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ScriptableObject) null : Il2CppObjectPool.Get<ScriptableObject>(num3);
    }
  }

  public static unsafe RenderPipelineAsset currentRenderPipeline
  {
    [CallerCount(25), CachedScanResults(RefRangeStart = 482363, RefRangeEnd = 482388, XrefRangeStart = 482357, XrefRangeEnd = 482363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (RenderPipelineAsset) null : Il2CppObjectPool.Get<RenderPipelineAsset>(num3);
    }
  }

  public static unsafe bool isScriptableRenderPipelineEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482388, XrefRangeEnd = 482396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_isScriptableRenderPipelineEnabled_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Il2CppSystem.Type currentRenderPipelineAssetType
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 482411, RefRangeEnd = 482414, XrefRangeStart = 482396, XrefRangeEnd = 482411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipelineAssetType_Public_Static_get_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482414, XrefRangeEnd = 482423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Shader GetDefaultShader(DefaultShaderType type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &type
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_GetDefaultShader_Internal_Static_Shader_DefaultShaderType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482423, XrefRangeEnd = 482432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Material GetDefaultMaterial(DefaultMaterialType type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &type
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_GetDefaultMaterial_Internal_Static_Material_DefaultMaterialType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 482451, RefRangeEnd = 482454, XrefRangeStart = 482432, XrefRangeEnd = 482451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UnityEngine.Object Internal_GetSettingsForRenderPipeline(
    string renderpipelineName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(renderpipelineName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Private_Static_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 482464, RefRangeEnd = 482465, XrefRangeStart = 482454, XrefRangeEnd = 482464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (RenderPipelineGlobalSettings) null : Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482465, XrefRangeEnd = 482480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_Internal_GetCurrentRenderPipelineGlobalSettings_Private_Static_RenderPipelineGlobalSettings_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (RenderPipelineGlobalSettings) null : Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 482510, RefRangeEnd = 482512, XrefRangeStart = 482480, XrefRangeEnd = 482510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetCurrentRenderPipelineGlobalSettings(
    out RenderPipelineGlobalSettings asset)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_TryGetCurrentRenderPipelineGlobalSettings_Public_Static_Boolean_byref_RenderPipelineGlobalSettings_0, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref RenderPipelineGlobalSettings local = ref asset;
    System.IntPtr pointer = zero;
    RenderPipelineGlobalSettings pipelineGlobalSettings = pointer == System.IntPtr.Zero ? (RenderPipelineGlobalSettings) null : new RenderPipelineGlobalSettings(pointer);
    local = pipelineGlobalSettings;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 482529, RefRangeEnd = 482537, XrefRangeStart = 482512, XrefRangeEnd = 482529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T GetRenderPipelineSettings<T>() where T : class
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_GetRenderPipelineSettings_Public_Static_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 482550, RefRangeEnd = 482554, XrefRangeStart = 482537, XrefRangeEnd = 482550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetRenderPipelineSettings<T>(out T settings) where T : class
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref settings;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref settings;
      System.IntPtr num3 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num3, false, false);
      local2 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482554, XrefRangeEnd = 482556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr get_INTERNAL_currentRenderPipeline_Injected()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Injected_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482556, XrefRangeEnd = 482558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr Internal_GetSettingsForRenderPipeline_Injected(
    ref ManagedSpanWrapper renderpipelineName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref renderpipelineName
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Il2CppSystem.Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GraphicsSettings.NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Lazy<RenderPipelineGlobalSettings>) null : Il2CppObjectPool.Get<Il2CppSystem.Lazy<RenderPipelineGlobalSettings>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GraphicsSettings.NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe void Internal_RegisterRenderPipeline(
    string renderpipelineName,
    UnityEngine.Object settings)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(renderpipelineName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = renderpipelineName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      GraphicsSettings.Internal_RegisterRenderPipeline_Injected(ref managedSpanWrapper, UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(settings));
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void Internal_UnregisterRenderPipeline(string renderpipelineName)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(renderpipelineName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = renderpipelineName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      GraphicsSettings.Internal_UnregisterRenderPipeline_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static UnityEngine.Object INTERNAL_currentRenderPipelineGlobalSettings
  {
    get
    {
      return Unmarshal.UnmarshalUnityObject<UnityEngine.Object>(GraphicsSettings.get_INTERNAL_currentRenderPipelineGlobalSettings_Injected());
    }
    set
    {
      GraphicsSettings.set_INTERNAL_currentRenderPipelineGlobalSettings_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(value));
    }
  }

  public static RenderPipelineGlobalSettings currentRenderPipelineGlobalSettings
  {
    get
    {
      return GraphicsSettings.INTERNAL_currentRenderPipelineGlobalSettings.TryCast<RenderPipelineGlobalSettings>();
    }
    set => GraphicsSettings.INTERNAL_currentRenderPipelineGlobalSettings = (UnityEngine.Object) value;
  }

  public static void CheckRenderPipelineType(Il2CppSystem.Type renderPipelineType)
  {
    if (renderPipelineType == (Il2CppSystem.Type) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (renderPipelineType));
    if (!Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderPipeline>()).IsAssignableFrom(renderPipelineType))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} must be a valid {1}", (Il2CppSystem.Object) renderPipelineType, (Il2CppSystem.Object) "RenderPipeline"));
  }

  public static void UpdateGraphicsSettings(
    RenderPipelineGlobalSettings newSettings,
    Il2CppSystem.Type renderPipelineType)
  {
    GraphicsSettings.CheckRenderPipelineType(renderPipelineType);
    if ((UnityEngine.Object) newSettings != (UnityEngine.Object) null)
      GraphicsSettings.Internal_RegisterRenderPipeline(renderPipelineType.FullName, (UnityEngine.Object) newSettings);
    else
      GraphicsSettings.Internal_UnregisterRenderPipeline(renderPipelineType.FullName);
  }

  public static void RegisterRenderPipelineSettings(
    Il2CppSystem.Type renderPipelineType,
    RenderPipelineGlobalSettings settings)
  {
    GraphicsSettings.CheckRenderPipelineType(renderPipelineType);
    GraphicsSettings.Internal_RegisterRenderPipeline(renderPipelineType.FullName, (UnityEngine.Object) settings);
  }

  public static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) where T : RenderPipeline
  {
    GraphicsSettings.Internal_RegisterRenderPipeline(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).FullName, (UnityEngine.Object) settings);
  }

  public static void UnregisterRenderPipelineSettings<T>() where T : RenderPipeline
  {
    GraphicsSettings.Internal_UnregisterRenderPipeline(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).FullName);
  }

  public static void UnregisterRenderPipelineSettings(Il2CppSystem.Type renderPipelineType)
  {
    GraphicsSettings.CheckRenderPipelineType(renderPipelineType);
    GraphicsSettings.Internal_UnregisterRenderPipeline(renderPipelineType.FullName);
  }

  public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline(Il2CppSystem.Type renderPipelineType)
  {
    GraphicsSettings.CheckRenderPipelineType(renderPipelineType);
    return GraphicsSettings.Internal_GetSettingsForRenderPipeline(renderPipelineType.FullName).TryCast<RenderPipelineGlobalSettings>();
  }

  public static TransparencySortMode transparencySortMode
  {
    get => GraphicsSettings.get_transparencySortModeDelegateField();
    set => GraphicsSettings.set_transparencySortModeDelegateField(value);
  }

  public static Vector3 transparencySortAxis
  {
    get
    {
      Vector3 ret;
      GraphicsSettings.get_transparencySortAxis_Injected(out ret);
      return ret;
    }
    set => GraphicsSettings.set_transparencySortAxis_Injected(ref value);
  }

  public static bool realtimeDirectRectangularAreaLights
  {
    get => GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField();
    set => GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField(value);
  }

  public static bool lightsUseColorTemperature
  {
    get => GraphicsSettings.get_lightsUseColorTemperatureDelegateField();
    set => GraphicsSettings.set_lightsUseColorTemperatureDelegateField(value);
  }

  public static uint defaultRenderingLayerMask
  {
    get => GraphicsSettings.get_defaultRenderingLayerMaskDelegateField();
    set => GraphicsSettings.set_defaultRenderingLayerMaskDelegateField(value);
  }

  public static Camera.GateFitMode defaultGateFitMode
  {
    get => GraphicsSettings.get_defaultGateFitModeDelegateField();
    set => GraphicsSettings.set_defaultGateFitModeDelegateField(value);
  }

  public static bool useScriptableRenderPipelineBatching
  {
    get => GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField();
    set => GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegateField(value);
  }

  public static bool logWhenShaderIsCompiled
  {
    get => GraphicsSettings.get_logWhenShaderIsCompiledDelegateField();
    set => GraphicsSettings.set_logWhenShaderIsCompiledDelegateField(value);
  }

  public static bool disableBuiltinCustomRenderTextureUpdate
  {
    get => GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField();
    set => GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField(value);
  }

  public static VideoShadersIncludeMode videoShadersIncludeMode
  {
    get => GraphicsSettings.get_videoShadersIncludeModeDelegateField();
  }

  public static LightProbeOutsideHullStrategy lightProbeOutsideHullStrategy
  {
    get => GraphicsSettings.get_lightProbeOutsideHullStrategyDelegateField();
    set => GraphicsSettings.set_lightProbeOutsideHullStrategyDelegateField(value);
  }

  public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
  {
    return GraphicsSettings.HasShaderDefineDelegateField(tier, defineHash);
  }

  public static bool HasShaderDefine(BuiltinShaderDefine defineHash)
  {
    return GraphicsSettings.HasShaderDefine(Graphics.activeTier, defineHash);
  }

  public static RenderPipelineAsset renderPipelineAsset
  {
    get => GraphicsSettings.defaultRenderPipeline;
    set => GraphicsSettings.defaultRenderPipeline = value;
  }

  public static ScriptableObject INTERNAL_defaultRenderPipeline
  {
    get
    {
      return Unmarshal.UnmarshalUnityObject<ScriptableObject>(GraphicsSettings.get_INTERNAL_defaultRenderPipeline_Injected());
    }
    set
    {
      GraphicsSettings.set_INTERNAL_defaultRenderPipeline_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<ScriptableObject>(value));
    }
  }

  public static RenderPipelineAsset defaultRenderPipeline
  {
    get => GraphicsSettings.INTERNAL_defaultRenderPipeline.TryCast<RenderPipelineAsset>();
    set => GraphicsSettings.INTERNAL_defaultRenderPipeline = (ScriptableObject) value;
  }

  public static Il2CppReferenceArray<ScriptableObject> GetAllConfiguredRenderPipelines()
  {
    System.IntPtr num = GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField();
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ScriptableObject>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(num);
  }

  public static Il2CppReferenceArray<RenderPipelineAsset> allConfiguredRenderPipelines
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
  }

  public static UnityEngine.Object GetGraphicsSettings()
  {
    return Unmarshal.UnmarshalUnityObject<UnityEngine.Object>(GraphicsSettings.GetGraphicsSettings_Injected());
  }

  public static void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode)
  {
    GraphicsSettings.SetShaderModeDelegateField(type, mode);
  }

  public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
  {
    return GraphicsSettings.GetShaderModeDelegateField(type);
  }

  public static void SetCustomShader(BuiltinShaderType type, Shader shader)
  {
    GraphicsSettings.SetCustomShader_Injected(type, UnityEngine.Object.MarshalledUnityObject.Marshal<Shader>(shader));
  }

  public static Shader GetCustomShader(BuiltinShaderType type)
  {
    return Unmarshal.UnmarshalUnityObject<Shader>(GraphicsSettings.GetCustomShader_Injected(type));
  }

  public static bool cameraRelativeLightCulling
  {
    get => GraphicsSettings.get_cameraRelativeLightCullingDelegateField();
    set => GraphicsSettings.set_cameraRelativeLightCullingDelegateField(value);
  }

  public static bool cameraRelativeShadowCulling
  {
    get => GraphicsSettings.get_cameraRelativeShadowCullingDelegateField();
    set => GraphicsSettings.set_cameraRelativeShadowCullingDelegateField(value);
  }

  public static void Internal_RegisterRenderPipeline_Injected(
    ref ManagedSpanWrapper renderpipelineName,
    System.IntPtr settings)
  {
    GraphicsSettings.Internal_RegisterRenderPipeline_InjectedDelegateField((System.IntPtr) ref renderpipelineName, settings);
  }

  public static void Internal_UnregisterRenderPipeline_Injected(
    ref ManagedSpanWrapper renderpipelineName)
  {
    GraphicsSettings.Internal_UnregisterRenderPipeline_InjectedDelegateField((System.IntPtr) ref renderpipelineName);
  }

  public static System.IntPtr get_INTERNAL_currentRenderPipelineGlobalSettings_Injected()
  {
    return GraphicsSettings.get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField();
  }

  public static void set_INTERNAL_currentRenderPipelineGlobalSettings_Injected(System.IntPtr value)
  {
    GraphicsSettings.set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField(value);
  }

  public static void get_transparencySortAxis_Injected(out Vector3 ret)
  {
    GraphicsSettings.get_transparencySortAxis_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void set_transparencySortAxis_Injected([In] ref Vector3 value)
  {
    GraphicsSettings.set_transparencySortAxis_InjectedDelegateField((System.IntPtr) ref value);
  }

  public static System.IntPtr get_INTERNAL_defaultRenderPipeline_Injected()
  {
    return GraphicsSettings.get_INTERNAL_defaultRenderPipeline_InjectedDelegateField();
  }

  public static void set_INTERNAL_defaultRenderPipeline_Injected(System.IntPtr value)
  {
    GraphicsSettings.set_INTERNAL_defaultRenderPipeline_InjectedDelegateField(value);
  }

  public static System.IntPtr GetGraphicsSettings_Injected()
  {
    return GraphicsSettings.GetGraphicsSettings_InjectedDelegateField();
  }

  public static void SetCustomShader_Injected(BuiltinShaderType type, System.IntPtr shader)
  {
    GraphicsSettings.SetCustomShader_InjectedDelegateField(type, shader);
  }

  public static System.IntPtr GetCustomShader_Injected(BuiltinShaderType type)
  {
    return GraphicsSettings.GetCustomShader_InjectedDelegateField(type);
  }

  [ObfuscatedName("UnityEngine.Rendering.GraphicsSettings+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__93_0_Internal_RenderPipelineGlobalSettings_0;

    static __c()
    {
      Il2CppClassPointerStore<GraphicsSettings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings.__c>.NativeClassPtr);
      GraphicsSettings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings.__c>.NativeClassPtr, "<>9");
      GraphicsSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings.__c>.NativeClassPtr, 100669702);
      GraphicsSettings.__c.NativeMethodInfoPtr___cctor_b__93_0_Internal_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings.__c>.NativeClassPtr, 100669703);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsSettings.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482318, XrefRangeEnd = 482336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RenderPipelineGlobalSettings __cctor_b__93_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.__c.NativeMethodInfoPtr___cctor_b__93_0_Internal_RenderPipelineGlobalSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (RenderPipelineGlobalSettings) null : Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(num3);
    }

    public static unsafe GraphicsSettings.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GraphicsSettings.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GraphicsSettings.__c) null : Il2CppObjectPool.Get<GraphicsSettings.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphicsSettings.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetRenderPipelineSettings_Public_Static_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_GetRenderPipelineSettings_Public_Static_T_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }

  private delegate TransparencySortMode get_transparencySortModeDelegate();

  private delegate void set_transparencySortModeDelegate(TransparencySortMode value);

  private delegate bool get_realtimeDirectRectangularAreaLightsDelegate();

  private delegate void set_realtimeDirectRectangularAreaLightsDelegate(bool value);

  private delegate void set_lightsUseLinearIntensityDelegate(bool value);

  private delegate bool get_lightsUseColorTemperatureDelegate();

  private delegate void set_lightsUseColorTemperatureDelegate(bool value);

  private delegate uint get_defaultRenderingLayerMaskDelegate();

  private delegate void set_defaultRenderingLayerMaskDelegate(uint value);

  private delegate Camera.GateFitMode get_defaultGateFitModeDelegate();

  private delegate void set_defaultGateFitModeDelegate(Camera.GateFitMode value);

  private delegate bool get_useScriptableRenderPipelineBatchingDelegate();

  private delegate void set_useScriptableRenderPipelineBatchingDelegate(bool value);

  private delegate bool get_logWhenShaderIsCompiledDelegate();

  private delegate void set_logWhenShaderIsCompiledDelegate(bool value);

  private delegate bool get_disableBuiltinCustomRenderTextureUpdateDelegate();

  private delegate void set_disableBuiltinCustomRenderTextureUpdateDelegate(bool value);

  private delegate VideoShadersIncludeMode get_videoShadersIncludeModeDelegate();

  private delegate LightProbeOutsideHullStrategy get_lightProbeOutsideHullStrategyDelegate();

  private delegate void set_lightProbeOutsideHullStrategyDelegate(
    LightProbeOutsideHullStrategy value);

  private delegate bool HasShaderDefineDelegate(GraphicsTier tier, BuiltinShaderDefine defineHash);

  private delegate System.IntPtr GetAllConfiguredRenderPipelinesDelegate();

  private delegate void SetShaderModeDelegate(BuiltinShaderType type, BuiltinShaderMode mode);

  private delegate BuiltinShaderMode GetShaderModeDelegate(BuiltinShaderType type);

  private delegate bool get_cameraRelativeLightCullingDelegate();

  private delegate void set_cameraRelativeLightCullingDelegate(bool value);

  private delegate bool get_cameraRelativeShadowCullingDelegate();

  private delegate void set_cameraRelativeShadowCullingDelegate(bool value);

  private delegate void Internal_RegisterRenderPipeline_InjectedDelegate(
    System.IntPtr renderpipelineName,
    System.IntPtr settings);

  private delegate void Internal_UnregisterRenderPipeline_InjectedDelegate(System.IntPtr renderpipelineName);

  private delegate System.IntPtr get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate();

  private delegate void set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate(
    System.IntPtr value);

  private delegate void get_transparencySortAxis_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void set_transparencySortAxis_InjectedDelegate([In] System.IntPtr value);

  private delegate System.IntPtr get_INTERNAL_defaultRenderPipeline_InjectedDelegate();

  private delegate void set_INTERNAL_defaultRenderPipeline_InjectedDelegate(System.IntPtr value);

  private delegate System.IntPtr GetGraphicsSettings_InjectedDelegate();

  private delegate void SetCustomShader_InjectedDelegate(BuiltinShaderType type, System.IntPtr shader);

  private delegate System.IntPtr GetCustomShader_InjectedDelegate(BuiltinShaderType type);
}
