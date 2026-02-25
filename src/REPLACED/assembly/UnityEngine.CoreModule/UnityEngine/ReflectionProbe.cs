// Decompiled with JetBrains decompiler
// Type: UnityEngine.ReflectionProbe
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class ReflectionProbe(System.IntPtr pointer) : Behaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_reflectionProbeChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_registeredDefaultReflectionSetActions;
  private static readonly System.IntPtr NativeFieldInfoPtr_registeredDefaultReflectionTextureActions;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0;
  private static readonly ReflectionProbe.UpdateCachedStateDelegate UpdateCachedStateDelegateField;
  private static readonly ReflectionProbe.get_minBakedCubemapResolutionDelegate get_minBakedCubemapResolutionDelegateField;
  private static readonly ReflectionProbe.get_maxBakedCubemapResolutionDelegate get_maxBakedCubemapResolutionDelegateField;
  private static readonly ReflectionProbe.get_type_InjectedDelegate get_type_InjectedDelegateField;
  private static readonly ReflectionProbe.set_type_InjectedDelegate set_type_InjectedDelegateField;
  private static readonly ReflectionProbe.get_size_InjectedDelegate get_size_InjectedDelegateField;
  private static readonly ReflectionProbe.set_size_InjectedDelegate set_size_InjectedDelegateField;
  private static readonly ReflectionProbe.get_center_InjectedDelegate get_center_InjectedDelegateField;
  private static readonly ReflectionProbe.set_center_InjectedDelegate set_center_InjectedDelegateField;
  private static readonly ReflectionProbe.get_nearClipPlane_InjectedDelegate get_nearClipPlane_InjectedDelegateField;
  private static readonly ReflectionProbe.set_nearClipPlane_InjectedDelegate set_nearClipPlane_InjectedDelegateField;
  private static readonly ReflectionProbe.get_farClipPlane_InjectedDelegate get_farClipPlane_InjectedDelegateField;
  private static readonly ReflectionProbe.set_farClipPlane_InjectedDelegate set_farClipPlane_InjectedDelegateField;
  private static readonly ReflectionProbe.get_intensity_InjectedDelegate get_intensity_InjectedDelegateField;
  private static readonly ReflectionProbe.set_intensity_InjectedDelegate set_intensity_InjectedDelegateField;
  private static readonly ReflectionProbe.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;
  private static readonly ReflectionProbe.get_hdr_InjectedDelegate get_hdr_InjectedDelegateField;
  private static readonly ReflectionProbe.set_hdr_InjectedDelegate set_hdr_InjectedDelegateField;
  private static readonly ReflectionProbe.get_renderDynamicObjects_InjectedDelegate get_renderDynamicObjects_InjectedDelegateField;
  private static readonly ReflectionProbe.set_renderDynamicObjects_InjectedDelegate set_renderDynamicObjects_InjectedDelegateField;
  private static readonly ReflectionProbe.get_shadowDistance_InjectedDelegate get_shadowDistance_InjectedDelegateField;
  private static readonly ReflectionProbe.set_shadowDistance_InjectedDelegate set_shadowDistance_InjectedDelegateField;
  private static readonly ReflectionProbe.get_resolution_InjectedDelegate get_resolution_InjectedDelegateField;
  private static readonly ReflectionProbe.set_resolution_InjectedDelegate set_resolution_InjectedDelegateField;
  private static readonly ReflectionProbe.get_cullingMask_InjectedDelegate get_cullingMask_InjectedDelegateField;
  private static readonly ReflectionProbe.set_cullingMask_InjectedDelegate set_cullingMask_InjectedDelegateField;
  private static readonly ReflectionProbe.get_clearFlags_InjectedDelegate get_clearFlags_InjectedDelegateField;
  private static readonly ReflectionProbe.set_clearFlags_InjectedDelegate set_clearFlags_InjectedDelegateField;
  private static readonly ReflectionProbe.get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;
  private static readonly ReflectionProbe.set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;
  private static readonly ReflectionProbe.get_blendDistance_InjectedDelegate get_blendDistance_InjectedDelegateField;
  private static readonly ReflectionProbe.set_blendDistance_InjectedDelegate set_blendDistance_InjectedDelegateField;
  private static readonly ReflectionProbe.get_boxProjection_InjectedDelegate get_boxProjection_InjectedDelegateField;
  private static readonly ReflectionProbe.set_boxProjection_InjectedDelegate set_boxProjection_InjectedDelegateField;
  private static readonly ReflectionProbe.get_mode_InjectedDelegate get_mode_InjectedDelegateField;
  private static readonly ReflectionProbe.set_mode_InjectedDelegate set_mode_InjectedDelegateField;
  private static readonly ReflectionProbe.get_importance_InjectedDelegate get_importance_InjectedDelegateField;
  private static readonly ReflectionProbe.set_importance_InjectedDelegate set_importance_InjectedDelegateField;
  private static readonly ReflectionProbe.get_refreshMode_InjectedDelegate get_refreshMode_InjectedDelegateField;
  private static readonly ReflectionProbe.set_refreshMode_InjectedDelegate set_refreshMode_InjectedDelegateField;
  private static readonly ReflectionProbe.get_timeSlicingMode_InjectedDelegate get_timeSlicingMode_InjectedDelegateField;
  private static readonly ReflectionProbe.set_timeSlicingMode_InjectedDelegate set_timeSlicingMode_InjectedDelegateField;
  private static readonly ReflectionProbe.get_bakedTexture_InjectedDelegate get_bakedTexture_InjectedDelegateField;
  private static readonly ReflectionProbe.set_bakedTexture_InjectedDelegate set_bakedTexture_InjectedDelegateField;
  private static readonly ReflectionProbe.get_customBakedTexture_InjectedDelegate get_customBakedTexture_InjectedDelegateField;
  private static readonly ReflectionProbe.set_customBakedTexture_InjectedDelegate set_customBakedTexture_InjectedDelegateField;
  private static readonly ReflectionProbe.get_realtimeTexture_InjectedDelegate get_realtimeTexture_InjectedDelegateField;
  private static readonly ReflectionProbe.set_realtimeTexture_InjectedDelegate set_realtimeTexture_InjectedDelegateField;
  private static readonly ReflectionProbe.get_texture_InjectedDelegate get_texture_InjectedDelegateField;
  private static readonly ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate get_textureHDRDecodeValues_InjectedDelegateField;
  private static readonly ReflectionProbe.Reset_InjectedDelegate Reset_InjectedDelegateField;
  private static readonly ReflectionProbe.IsFinishedRendering_InjectedDelegate IsFinishedRendering_InjectedDelegateField;
  private static readonly ReflectionProbe.ScheduleRender_InjectedDelegate ScheduleRender_InjectedDelegateField;
  private static readonly ReflectionProbe.BlendCubemap_InjectedDelegate BlendCubemap_InjectedDelegateField;
  private static readonly ReflectionProbe.get_defaultTexture_InjectedDelegate get_defaultTexture_InjectedDelegateField;

  static ReflectionProbe()
  {
    Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ReflectionProbe));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr);
    ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, nameof (reflectionProbeChanged));
    ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, nameof (registeredDefaultReflectionSetActions));
    ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, nameof (registeredDefaultReflectionTextureActions));
    ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664361);
    ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664362);
    ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664363);
    ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664365);
    ReflectionProbe.UpdateCachedStateDelegateField = IL2CPP.ResolveICall<ReflectionProbe.UpdateCachedStateDelegate>("UnityEngine.ReflectionProbe::UpdateCachedState");
    ReflectionProbe.get_minBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_minBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_minBakedCubemapResolution");
    ReflectionProbe.get_maxBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_maxBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_maxBakedCubemapResolution");
    ReflectionProbe.get_type_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_type_InjectedDelegate>("UnityEngine.ReflectionProbe::get_type_Injected");
    ReflectionProbe.set_type_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_type_InjectedDelegate>("UnityEngine.ReflectionProbe::set_type_Injected");
    ReflectionProbe.get_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_size_InjectedDelegate>("UnityEngine.ReflectionProbe::get_size_Injected");
    ReflectionProbe.set_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_size_InjectedDelegate>("UnityEngine.ReflectionProbe::set_size_Injected");
    ReflectionProbe.get_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_center_InjectedDelegate>("UnityEngine.ReflectionProbe::get_center_Injected");
    ReflectionProbe.set_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_center_InjectedDelegate>("UnityEngine.ReflectionProbe::set_center_Injected");
    ReflectionProbe.get_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_nearClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::get_nearClipPlane_Injected");
    ReflectionProbe.set_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_nearClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::set_nearClipPlane_Injected");
    ReflectionProbe.get_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_farClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::get_farClipPlane_Injected");
    ReflectionProbe.set_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_farClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::set_farClipPlane_Injected");
    ReflectionProbe.get_intensity_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_intensity_InjectedDelegate>("UnityEngine.ReflectionProbe::get_intensity_Injected");
    ReflectionProbe.set_intensity_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_intensity_InjectedDelegate>("UnityEngine.ReflectionProbe::set_intensity_Injected");
    ReflectionProbe.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bounds_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bounds_Injected");
    ReflectionProbe.get_hdr_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_hdr_InjectedDelegate>("UnityEngine.ReflectionProbe::get_hdr_Injected");
    ReflectionProbe.set_hdr_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_hdr_InjectedDelegate>("UnityEngine.ReflectionProbe::set_hdr_Injected");
    ReflectionProbe.get_renderDynamicObjects_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_renderDynamicObjects_InjectedDelegate>("UnityEngine.ReflectionProbe::get_renderDynamicObjects_Injected");
    ReflectionProbe.set_renderDynamicObjects_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_renderDynamicObjects_InjectedDelegate>("UnityEngine.ReflectionProbe::set_renderDynamicObjects_Injected");
    ReflectionProbe.get_shadowDistance_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_shadowDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::get_shadowDistance_Injected");
    ReflectionProbe.set_shadowDistance_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_shadowDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::set_shadowDistance_Injected");
    ReflectionProbe.get_resolution_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_resolution_InjectedDelegate>("UnityEngine.ReflectionProbe::get_resolution_Injected");
    ReflectionProbe.set_resolution_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_resolution_InjectedDelegate>("UnityEngine.ReflectionProbe::set_resolution_Injected");
    ReflectionProbe.get_cullingMask_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_cullingMask_InjectedDelegate>("UnityEngine.ReflectionProbe::get_cullingMask_Injected");
    ReflectionProbe.set_cullingMask_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_cullingMask_InjectedDelegate>("UnityEngine.ReflectionProbe::set_cullingMask_Injected");
    ReflectionProbe.get_clearFlags_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_clearFlags_InjectedDelegate>("UnityEngine.ReflectionProbe::get_clearFlags_Injected");
    ReflectionProbe.set_clearFlags_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_clearFlags_InjectedDelegate>("UnityEngine.ReflectionProbe::set_clearFlags_Injected");
    ReflectionProbe.get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::get_backgroundColor_Injected");
    ReflectionProbe.set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::set_backgroundColor_Injected");
    ReflectionProbe.get_blendDistance_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_blendDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::get_blendDistance_Injected");
    ReflectionProbe.set_blendDistance_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_blendDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::set_blendDistance_Injected");
    ReflectionProbe.get_boxProjection_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_boxProjection_InjectedDelegate>("UnityEngine.ReflectionProbe::get_boxProjection_Injected");
    ReflectionProbe.set_boxProjection_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_boxProjection_InjectedDelegate>("UnityEngine.ReflectionProbe::set_boxProjection_Injected");
    ReflectionProbe.get_mode_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_mode_InjectedDelegate>("UnityEngine.ReflectionProbe::get_mode_Injected");
    ReflectionProbe.set_mode_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_mode_InjectedDelegate>("UnityEngine.ReflectionProbe::set_mode_Injected");
    ReflectionProbe.get_importance_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_importance_InjectedDelegate>("UnityEngine.ReflectionProbe::get_importance_Injected");
    ReflectionProbe.set_importance_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_importance_InjectedDelegate>("UnityEngine.ReflectionProbe::set_importance_Injected");
    ReflectionProbe.get_refreshMode_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_refreshMode_InjectedDelegate>("UnityEngine.ReflectionProbe::get_refreshMode_Injected");
    ReflectionProbe.set_refreshMode_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_refreshMode_InjectedDelegate>("UnityEngine.ReflectionProbe::set_refreshMode_Injected");
    ReflectionProbe.get_timeSlicingMode_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_timeSlicingMode_InjectedDelegate>("UnityEngine.ReflectionProbe::get_timeSlicingMode_Injected");
    ReflectionProbe.set_timeSlicingMode_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_timeSlicingMode_InjectedDelegate>("UnityEngine.ReflectionProbe::set_timeSlicingMode_Injected");
    ReflectionProbe.get_bakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bakedTexture_Injected");
    ReflectionProbe.set_bakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_bakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::set_bakedTexture_Injected");
    ReflectionProbe.get_customBakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_customBakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_customBakedTexture_Injected");
    ReflectionProbe.set_customBakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_customBakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::set_customBakedTexture_Injected");
    ReflectionProbe.get_realtimeTexture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_realtimeTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_realtimeTexture_Injected");
    ReflectionProbe.set_realtimeTexture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_realtimeTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::set_realtimeTexture_Injected");
    ReflectionProbe.get_texture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_texture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_texture_Injected");
    ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_textureHDRDecodeValues_Injected");
    ReflectionProbe.Reset_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.Reset_InjectedDelegate>("UnityEngine.ReflectionProbe::Reset_Injected");
    ReflectionProbe.IsFinishedRendering_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.IsFinishedRendering_InjectedDelegate>("UnityEngine.ReflectionProbe::IsFinishedRendering_Injected");
    ReflectionProbe.ScheduleRender_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ScheduleRender_InjectedDelegate>("UnityEngine.ReflectionProbe::ScheduleRender_Injected");
    ReflectionProbe.BlendCubemap_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.BlendCubemap_InjectedDelegate>("UnityEngine.ReflectionProbe::BlendCubemap_Injected");
    ReflectionProbe.get_defaultTexture_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_defaultTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_defaultTexture_Injected");
  }

  public static unsafe Vector4 defaultTextureHDRDecodeValues
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 419656, RefRangeEnd = 419657, XrefRangeStart = 419651, XrefRangeEnd = 419656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419657, XrefRangeEnd = 419661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CallReflectionProbeEvent(
    ReflectionProbe probe,
    ReflectionProbe.ReflectionProbeEvent probeEvent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) probe);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &probeEvent;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419661, XrefRangeEnd = 419679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CallSetDefaultReflection(Texture defaultReflectionCubemap)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultReflectionCubemap)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419679, XrefRangeEnd = 419681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppSystem.Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, Il2CppSystem.Action<Texture>> registeredDefaultReflectionSetActions
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<int, Il2CppSystem.Action<Texture>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppSystem.Action<Texture>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<Il2CppSystem.Action<Texture>> registeredDefaultReflectionTextureActions
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<Il2CppSystem.Action<Texture>>) null : Il2CppObjectPool.Get<List<Il2CppSystem.Action<Texture>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public ReflectionProbeType type
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_type_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_type_Injected(_unity_self, value);
    }
  }

  public Vector3 size
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      ReflectionProbe.get_size_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_size_Injected(_unity_self, ref value);
    }
  }

  public Vector3 center
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      ReflectionProbe.get_center_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_center_Injected(_unity_self, ref value);
    }
  }

  public float nearClipPlane
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_nearClipPlane_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_nearClipPlane_Injected(_unity_self, value);
    }
  }

  public float farClipPlane
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_farClipPlane_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_farClipPlane_Injected(_unity_self, value);
    }
  }

  public float intensity
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_intensity_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_intensity_Injected(_unity_self, value);
    }
  }

  public Bounds bounds
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Bounds ret;
      ReflectionProbe.get_bounds_Injected(_unity_self, out ret);
      return ret;
    }
  }

  public bool hdr
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_hdr_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_hdr_Injected(_unity_self, value);
    }
  }

  public bool renderDynamicObjects
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_renderDynamicObjects_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_renderDynamicObjects_Injected(_unity_self, value);
    }
  }

  public float shadowDistance
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_shadowDistance_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_shadowDistance_Injected(_unity_self, value);
    }
  }

  public int resolution
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_resolution_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_resolution_Injected(_unity_self, value);
    }
  }

  public int cullingMask
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_cullingMask_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_cullingMask_Injected(_unity_self, value);
    }
  }

  public ReflectionProbeClearFlags clearFlags
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_clearFlags_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_clearFlags_Injected(_unity_self, value);
    }
  }

  public Color backgroundColor
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Color ret;
      ReflectionProbe.get_backgroundColor_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_backgroundColor_Injected(_unity_self, ref value);
    }
  }

  public float blendDistance
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_blendDistance_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_blendDistance_Injected(_unity_self, value);
    }
  }

  public bool boxProjection
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_boxProjection_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_boxProjection_Injected(_unity_self, value);
    }
  }

  public ReflectionProbeMode mode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_mode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_mode_Injected(_unity_self, value);
    }
  }

  public int importance
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_importance_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_importance_Injected(_unity_self, value);
    }
  }

  public ReflectionProbeRefreshMode refreshMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_refreshMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_refreshMode_Injected(_unity_self, value);
    }
  }

  public ReflectionProbeTimeSlicingMode timeSlicingMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ReflectionProbe.get_timeSlicingMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_timeSlicingMode_Injected(_unity_self, value);
    }
  }

  public Texture bakedTexture
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Texture>(ReflectionProbe.get_bakedTexture_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_bakedTexture_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(value));
    }
  }

  public Texture customBakedTexture
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Texture>(ReflectionProbe.get_customBakedTexture_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_customBakedTexture_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(value));
    }
  }

  public RenderTexture realtimeTexture
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<RenderTexture>(ReflectionProbe.get_realtimeTexture_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ReflectionProbe.set_realtimeTexture_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<RenderTexture>(value));
    }
  }

  public Texture texture
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Texture>(ReflectionProbe.get_texture_Injected(_unity_self));
    }
  }

  public Vector4 textureHDRDecodeValues
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector4 ret;
      ReflectionProbe.get_textureHDRDecodeValues_Injected(_unity_self, out ret);
      return ret;
    }
  }

  public void Reset()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ReflectionProbe.Reset_Injected(_unity_self);
  }

  public int RenderProbe() => this.RenderProbe((RenderTexture) null);

  public int RenderProbe(RenderTexture targetTexture)
  {
    return this.ScheduleRender(this.timeSlicingMode, targetTexture);
  }

  public bool IsFinishedRendering(int renderId)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ReflectionProbe.IsFinishedRendering_Injected(_unity_self, renderId);
  }

  public int ScheduleRender(
    ReflectionProbeTimeSlicingMode timeSlicingMode,
    RenderTexture targetTexture)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ReflectionProbe>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ReflectionProbe.ScheduleRender_Injected(_unity_self, timeSlicingMode, Object.MarshalledUnityObject.Marshal<RenderTexture>(targetTexture));
  }

  public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target)
  {
    return ReflectionProbe.BlendCubemap_Injected(Object.MarshalledUnityObject.Marshal<Texture>(src), Object.MarshalledUnityObject.Marshal<Texture>(dst), blend, Object.MarshalledUnityObject.Marshal<RenderTexture>(target));
  }

  public static void UpdateCachedState() => ReflectionProbe.UpdateCachedStateDelegateField();

  public static int minBakedCubemapResolution
  {
    get => ReflectionProbe.get_minBakedCubemapResolutionDelegateField();
  }

  public static int maxBakedCubemapResolution
  {
    get => ReflectionProbe.get_maxBakedCubemapResolutionDelegateField();
  }

  public static Texture defaultTexture
  {
    get => Unmarshal.UnmarshalUnityObject<Texture>(ReflectionProbe.get_defaultTexture_Injected());
  }

  [SpecialName]
  public static void add_reflectionProbeChanged(
    Il2CppSystem.Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_reflectionProbeChanged(
    Il2CppSystem.Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_defaultReflectionSet(Il2CppSystem.Action<Cubemap> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_defaultReflectionSet(Il2CppSystem.Action<Cubemap> value)
  {
    Il2CppSystem.Action<Texture> action;
    if (!ReflectionProbe.registeredDefaultReflectionSetActions.TryGetValue(value.Method.GetHashCode(), out action))
      return;
    ReflectionProbe.remove_defaultReflectionTexture(action);
    ReflectionProbe.registeredDefaultReflectionSetActions.Remove(value.Method.GetHashCode());
  }

  [SpecialName]
  public static void add_defaultReflectionTexture(Il2CppSystem.Action<Texture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_defaultReflectionTexture(Il2CppSystem.Action<Texture> value)
  {
    ReflectionProbe.registeredDefaultReflectionTextureActions.Remove(value);
  }

  public static ReflectionProbeType get_type_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_type_InjectedDelegateField(_unity_self);
  }

  public static void set_type_Injected(System.IntPtr _unity_self, ReflectionProbeType value)
  {
    ReflectionProbe.set_type_InjectedDelegateField(_unity_self, value);
  }

  public static void get_size_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    ReflectionProbe.get_size_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_size_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
  {
    ReflectionProbe.set_size_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static void get_center_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    ReflectionProbe.get_center_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_center_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
  {
    ReflectionProbe.set_center_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static float get_nearClipPlane_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_nearClipPlane_InjectedDelegateField(_unity_self);
  }

  public static void set_nearClipPlane_Injected(System.IntPtr _unity_self, float value)
  {
    ReflectionProbe.set_nearClipPlane_InjectedDelegateField(_unity_self, value);
  }

  public static float get_farClipPlane_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_farClipPlane_InjectedDelegateField(_unity_self);
  }

  public static void set_farClipPlane_Injected(System.IntPtr _unity_self, float value)
  {
    ReflectionProbe.set_farClipPlane_InjectedDelegateField(_unity_self, value);
  }

  public static float get_intensity_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_intensity_InjectedDelegateField(_unity_self);
  }

  public static void set_intensity_Injected(System.IntPtr _unity_self, float value)
  {
    ReflectionProbe.set_intensity_InjectedDelegateField(_unity_self, value);
  }

  public static void get_bounds_Injected(System.IntPtr _unity_self, out Bounds ret)
  {
    ReflectionProbe.get_bounds_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static bool get_hdr_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_hdr_InjectedDelegateField(_unity_self);
  }

  public static void set_hdr_Injected(System.IntPtr _unity_self, bool value)
  {
    ReflectionProbe.set_hdr_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_renderDynamicObjects_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_renderDynamicObjects_InjectedDelegateField(_unity_self);
  }

  public static void set_renderDynamicObjects_Injected(System.IntPtr _unity_self, bool value)
  {
    ReflectionProbe.set_renderDynamicObjects_InjectedDelegateField(_unity_self, value);
  }

  public static float get_shadowDistance_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_shadowDistance_InjectedDelegateField(_unity_self);
  }

  public static void set_shadowDistance_Injected(System.IntPtr _unity_self, float value)
  {
    ReflectionProbe.set_shadowDistance_InjectedDelegateField(_unity_self, value);
  }

  public static int get_resolution_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_resolution_InjectedDelegateField(_unity_self);
  }

  public static void set_resolution_Injected(System.IntPtr _unity_self, int value)
  {
    ReflectionProbe.set_resolution_InjectedDelegateField(_unity_self, value);
  }

  public static int get_cullingMask_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_cullingMask_InjectedDelegateField(_unity_self);
  }

  public static void set_cullingMask_Injected(System.IntPtr _unity_self, int value)
  {
    ReflectionProbe.set_cullingMask_InjectedDelegateField(_unity_self, value);
  }

  public static ReflectionProbeClearFlags get_clearFlags_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_clearFlags_InjectedDelegateField(_unity_self);
  }

  public static void set_clearFlags_Injected(System.IntPtr _unity_self, ReflectionProbeClearFlags value)
  {
    ReflectionProbe.set_clearFlags_InjectedDelegateField(_unity_self, value);
  }

  public static void get_backgroundColor_Injected(System.IntPtr _unity_self, out Color ret)
  {
    ReflectionProbe.get_backgroundColor_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_backgroundColor_Injected(System.IntPtr _unity_self, [In] ref Color value)
  {
    ReflectionProbe.set_backgroundColor_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static float get_blendDistance_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_blendDistance_InjectedDelegateField(_unity_self);
  }

  public static void set_blendDistance_Injected(System.IntPtr _unity_self, float value)
  {
    ReflectionProbe.set_blendDistance_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_boxProjection_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_boxProjection_InjectedDelegateField(_unity_self);
  }

  public static void set_boxProjection_Injected(System.IntPtr _unity_self, bool value)
  {
    ReflectionProbe.set_boxProjection_InjectedDelegateField(_unity_self, value);
  }

  public static ReflectionProbeMode get_mode_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_mode_InjectedDelegateField(_unity_self);
  }

  public static void set_mode_Injected(System.IntPtr _unity_self, ReflectionProbeMode value)
  {
    ReflectionProbe.set_mode_InjectedDelegateField(_unity_self, value);
  }

  public static int get_importance_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_importance_InjectedDelegateField(_unity_self);
  }

  public static void set_importance_Injected(System.IntPtr _unity_self, int value)
  {
    ReflectionProbe.set_importance_InjectedDelegateField(_unity_self, value);
  }

  public static ReflectionProbeRefreshMode get_refreshMode_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_refreshMode_InjectedDelegateField(_unity_self);
  }

  public static void set_refreshMode_Injected(System.IntPtr _unity_self, ReflectionProbeRefreshMode value)
  {
    ReflectionProbe.set_refreshMode_InjectedDelegateField(_unity_self, value);
  }

  public static ReflectionProbeTimeSlicingMode get_timeSlicingMode_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_timeSlicingMode_InjectedDelegateField(_unity_self);
  }

  public static void set_timeSlicingMode_Injected(
    System.IntPtr _unity_self,
    ReflectionProbeTimeSlicingMode value)
  {
    ReflectionProbe.set_timeSlicingMode_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_bakedTexture_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_bakedTexture_InjectedDelegateField(_unity_self);
  }

  public static void set_bakedTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    ReflectionProbe.set_bakedTexture_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_customBakedTexture_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_customBakedTexture_InjectedDelegateField(_unity_self);
  }

  public static void set_customBakedTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    ReflectionProbe.set_customBakedTexture_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_realtimeTexture_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_realtimeTexture_InjectedDelegateField(_unity_self);
  }

  public static void set_realtimeTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    ReflectionProbe.set_realtimeTexture_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_texture_Injected(System.IntPtr _unity_self)
  {
    return ReflectionProbe.get_texture_InjectedDelegateField(_unity_self);
  }

  public static void get_textureHDRDecodeValues_Injected(System.IntPtr _unity_self, out Vector4 ret)
  {
    ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void Reset_Injected(System.IntPtr _unity_self)
  {
    ReflectionProbe.Reset_InjectedDelegateField(_unity_self);
  }

  public static bool IsFinishedRendering_Injected(System.IntPtr _unity_self, int renderId)
  {
    return ReflectionProbe.IsFinishedRendering_InjectedDelegateField(_unity_self, renderId);
  }

  public static int ScheduleRender_Injected(
    System.IntPtr _unity_self,
    ReflectionProbeTimeSlicingMode timeSlicingMode,
    System.IntPtr targetTexture)
  {
    return ReflectionProbe.ScheduleRender_InjectedDelegateField(_unity_self, timeSlicingMode, targetTexture);
  }

  public static bool BlendCubemap_Injected(System.IntPtr src, System.IntPtr dst, float blend, System.IntPtr target)
  {
    return ReflectionProbe.BlendCubemap_InjectedDelegateField(src, dst, blend, target);
  }

  public static System.IntPtr get_defaultTexture_Injected()
  {
    return ReflectionProbe.get_defaultTexture_InjectedDelegateField();
  }

  public enum ReflectionProbeEvent
  {
    ReflectionProbeAdded,
    ReflectionProbeRemoved,
  }

  public sealed class \u003C\u003Ec__DisplayClass95_0
  {
  }

  public sealed class \u003C\u003Ec__DisplayClass98_0
  {
  }

  private delegate void UpdateCachedStateDelegate();

  private delegate int get_minBakedCubemapResolutionDelegate();

  private delegate int get_maxBakedCubemapResolutionDelegate();

  private delegate ReflectionProbeType get_type_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_type_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeType value);

  private delegate void get_size_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_size_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate void get_center_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_center_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate float get_nearClipPlane_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_nearClipPlane_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_farClipPlane_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_farClipPlane_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_intensity_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_intensity_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate void get_bounds_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate bool get_hdr_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_hdr_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate bool get_renderDynamicObjects_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_renderDynamicObjects_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate float get_shadowDistance_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_shadowDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate int get_resolution_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_resolution_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate int get_cullingMask_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_cullingMask_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate ReflectionProbeClearFlags get_clearFlags_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_clearFlags_InjectedDelegate(
    System.IntPtr _unity_self,
    ReflectionProbeClearFlags value);

  private delegate void get_backgroundColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_backgroundColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate float get_blendDistance_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_blendDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate bool get_boxProjection_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_boxProjection_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate ReflectionProbeMode get_mode_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_mode_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeMode value);

  private delegate int get_importance_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_importance_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate ReflectionProbeRefreshMode get_refreshMode_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_refreshMode_InjectedDelegate(
    System.IntPtr _unity_self,
    ReflectionProbeRefreshMode value);

  private delegate ReflectionProbeTimeSlicingMode get_timeSlicingMode_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_timeSlicingMode_InjectedDelegate(
    System.IntPtr _unity_self,
    ReflectionProbeTimeSlicingMode value);

  private delegate System.IntPtr get_bakedTexture_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_bakedTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate System.IntPtr get_customBakedTexture_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_customBakedTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate System.IntPtr get_realtimeTexture_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_realtimeTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate System.IntPtr get_texture_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void get_textureHDRDecodeValues_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void Reset_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool IsFinishedRendering_InjectedDelegate(System.IntPtr _unity_self, int renderId);

  private delegate int ScheduleRender_InjectedDelegate(
    System.IntPtr _unity_self,
    ReflectionProbeTimeSlicingMode timeSlicingMode,
    System.IntPtr targetTexture);

  private delegate bool BlendCubemap_InjectedDelegate(
    System.IntPtr src,
    System.IntPtr dst,
    float blend,
    System.IntPtr target);

  private delegate System.IntPtr get_defaultTexture_InjectedDelegate();
}
