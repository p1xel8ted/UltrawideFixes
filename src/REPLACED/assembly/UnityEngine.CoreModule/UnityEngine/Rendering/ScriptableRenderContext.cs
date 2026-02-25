// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ScriptableRenderContext
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering.RendererUtils;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ScriptableRenderContext
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kRenderTypeTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CullShadowCasters_Private_Static_Void_ScriptableRenderContext_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Internal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Internal_Private_RendererList_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Private_RendererList_Camera_GizmoSubset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Private_RendererList_Camera_UISubset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Private_RendererList_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CullShadowCasters_Public_Void_CullingResults_ShadowCastersCullingInfos_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererList_byref_ShadowDrawingSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererList_Camera_GizmoSubset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_UISubset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererList_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CullShadowCasters_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSortSettings_Injected_Private_Static_Void_IntPtr_byref_SortingSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_ComputeQueueType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_GizmoSubset_byref_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_UISubset_byref_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0;
  [FieldOffset(0)]
  public System.IntPtr m_Ptr;
  public const bool deprecateDrawXmethods = false;
  private static readonly ScriptableRenderContext.BeginRenderPass_InternalDelegate BeginRenderPass_InternalDelegateField;
  private static readonly ScriptableRenderContext.BeginSubPass_InternalDelegate BeginSubPass_InternalDelegateField;
  private static readonly ScriptableRenderContext.EndSubPass_InternalDelegate EndSubPass_InternalDelegateField;
  private static readonly ScriptableRenderContext.EndRenderPass_InternalDelegate EndRenderPass_InternalDelegateField;
  private static readonly ScriptableRenderContext.HasInvokeOnRenderObjectCallbacks_InternalDelegate HasInvokeOnRenderObjectCallbacks_InternalDelegateField;
  private static readonly ScriptableRenderContext.PushDisableApiRenderersDelegate PushDisableApiRenderersDelegateField;
  private static readonly ScriptableRenderContext.PopDisableApiRenderersDelegate PopDisableApiRenderersDelegateField;
  private static readonly ScriptableRenderContext.SubmitForRenderPassValidation_InternalDelegate SubmitForRenderPassValidation_InternalDelegateField;
  private static readonly ScriptableRenderContext.DrawShadows_InternalDelegate DrawShadows_InternalDelegateField;
  private static readonly ScriptableRenderContext.InvokeOnRenderObjectCallback_InternalDelegate InvokeOnRenderObjectCallback_InternalDelegateField;
  private static readonly ScriptableRenderContext.DrawRenderers_Internal_InjectedDelegate DrawRenderers_Internal_InjectedDelegateField;
  private static readonly ScriptableRenderContext.EmitGeometryForCamera_InjectedDelegate EmitGeometryForCamera_InjectedDelegateField;
  private static readonly ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate StereoEndRender_Internal_InjectedDelegateField;
  private static readonly ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate StartMultiEye_Internal_InjectedDelegateField;
  private static readonly ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate StopMultiEye_Internal_InjectedDelegateField;
  private static readonly ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate DrawSkybox_Internal_InjectedDelegateField;
  private static readonly ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate DrawGizmos_Internal_InjectedDelegateField;
  private static readonly ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegate DrawWireOverlay_Impl_InjectedDelegateField;
  private static readonly ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegate DrawUIOverlay_Internal_InjectedDelegateField;

  static ScriptableRenderContext()
  {
    Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ScriptableRenderContext));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr);
    ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, nameof (kRenderTypeTag));
    ScriptableRenderContext.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, nameof (m_Ptr));
    ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670504);
    ScriptableRenderContext.NativeMethodInfoPtr_Internal_CullShadowCasters_Private_Static_Void_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670505);
    ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670506);
    ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670507);
    ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670508);
    ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670509);
    ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670510);
    ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670511);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670512);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateShadowRendererList_Internal_Private_RendererList_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670513);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670514);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Private_RendererList_Camera_GizmoSubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670515);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Private_RendererList_Camera_UISubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670516);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Private_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670517);
    ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670518);
    ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670519);
    ScriptableRenderContext.NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670521);
    ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670522);
    ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670523);
    ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670524);
    ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670525);
    ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670526);
    ScriptableRenderContext.NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670527);
    ScriptableRenderContext.NativeMethodInfoPtr_CullShadowCasters_Public_Void_CullingResults_ShadowCastersCullingInfos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670528);
    ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670529);
    ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670530);
    ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670531);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670532);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670533);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererList_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670534);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670535);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670536);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670537);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererList_Camera_GizmoSubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670538);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_UISubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670539);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670540);
    ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670541);
    ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670542);
    ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670544);
    ScriptableRenderContext.NativeMethodInfoPtr_Internal_CullShadowCasters_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670545);
    ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Injected_Private_Static_Void_IntPtr_byref_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670546);
    ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670547);
    ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670548);
    ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670549);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670550);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateShadowRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670551);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670552);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_GizmoSubset_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670553);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_UISubset_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670554);
    ScriptableRenderContext.NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670555);
    ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100670556);
    ScriptableRenderContext.BeginRenderPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.BeginRenderPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::BeginRenderPass_Internal");
    ScriptableRenderContext.BeginSubPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.BeginSubPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::BeginSubPass_Internal");
    ScriptableRenderContext.EndSubPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EndSubPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EndSubPass_Internal");
    ScriptableRenderContext.EndRenderPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EndRenderPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EndRenderPass_Internal");
    ScriptableRenderContext.HasInvokeOnRenderObjectCallbacks_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.HasInvokeOnRenderObjectCallbacks_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::HasInvokeOnRenderObjectCallbacks_Internal");
    ScriptableRenderContext.PushDisableApiRenderersDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.PushDisableApiRenderersDelegate>("UnityEngine.Rendering.ScriptableRenderContext::PushDisableApiRenderers");
    ScriptableRenderContext.PopDisableApiRenderersDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.PopDisableApiRenderersDelegate>("UnityEngine.Rendering.ScriptableRenderContext::PopDisableApiRenderers");
    ScriptableRenderContext.SubmitForRenderPassValidation_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.SubmitForRenderPassValidation_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::SubmitForRenderPassValidation_Internal");
    ScriptableRenderContext.DrawShadows_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawShadows_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawShadows_Internal");
    ScriptableRenderContext.InvokeOnRenderObjectCallback_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.InvokeOnRenderObjectCallback_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::InvokeOnRenderObjectCallback_Internal");
    ScriptableRenderContext.DrawRenderers_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawRenderers_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawRenderers_Internal_Injected");
    ScriptableRenderContext.EmitGeometryForCamera_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EmitGeometryForCamera_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EmitGeometryForCamera_Injected");
    ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StereoEndRender_Internal_Injected");
    ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StartMultiEye_Internal_Injected");
    ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StopMultiEye_Internal_Injected");
    ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected");
    ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawGizmos_Internal_Injected");
    ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawWireOverlay_Impl_Injected");
    ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawUIOverlay_Internal_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488199, XrefRangeEnd = 488204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Cull(
    ref ScriptableCullingParameters parameters,
    ScriptableRenderContext renderLoop,
    System.IntPtr results)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderLoop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488204, XrefRangeEnd = 488209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CullShadowCasters(
    ScriptableRenderContext renderLoop,
    System.IntPtr context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &renderLoop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &context;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_CullShadowCasters_Private_Static_Void_ScriptableRenderContext_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488209, XrefRangeEnd = 488217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitializeSortSettings(
    Camera camera,
    out SortingSettings sortingSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sortingSettings;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488217, XrefRangeEnd = 488219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Submit_Internal()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Private_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488219, XrefRangeEnd = 488221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetCameras_Internal(Il2CppSystem.Type listType, Il2CppSystem.Object resultList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) listType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultList);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488221, XrefRangeEnd = 488227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commandBuffer)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488227, XrefRangeEnd = 488233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExecuteCommandBufferAsync_Internal(
    CommandBuffer commandBuffer,
    ComputeQueueType queueType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commandBuffer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &queueType;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488245, RefRangeEnd = 488246, XrefRangeStart = 488233, XrefRangeEnd = 488245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stereoSetup;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eye;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488251, RefRangeEnd = 488252, XrefRangeStart = 488246, XrefRangeEnd = 488251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateRendererList_Internal(
    System.IntPtr cullResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings,
    ShaderTagId tagName,
    bool isPassTagName,
    System.IntPtr tagValues,
    System.IntPtr stateBlocks,
    int stateCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) &cullResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref drawingSettings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref filteringSettings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tagName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isPassTagName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &tagValues;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &stateBlocks;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &stateCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488252, XrefRangeEnd = 488257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateShadowRendererList_Internal(System.IntPtr shadowDrawinSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &shadowDrawinSettings
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateShadowRendererList_Internal_Private_RendererList_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488257, XrefRangeEnd = 488266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateSkyboxRendererList_Internal(
    Camera camera,
    int mode,
    Matrix4x4 proj,
    Matrix4x4 view,
    Matrix4x4 projR,
    Matrix4x4 viewR)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &proj;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &view;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &projR;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &viewR;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488266, XrefRangeEnd = 488275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateGizmoRendererList_Internal(
    Camera camera,
    GizmoSubset gizmoSubset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gizmoSubset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Private_RendererList_Camera_GizmoSubset_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488275, XrefRangeEnd = 488284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateUIOverlayRendererList_Internal(Camera camera, UISubset uiSubset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uiSubset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Private_RendererList_Camera_UISubset_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488284, XrefRangeEnd = 488293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateWireOverlayRendererList_Internal(Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Private_RendererList_Camera_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488293, XrefRangeEnd = 488295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PrepareRendererListsAsync_Internal(Il2CppSystem.Object rendererLists)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rendererLists)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488295, XrefRangeEnd = 488300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererListStatus QueryRendererListStatus_Internal(RendererList handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererListStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488310, RefRangeEnd = 488311, XrefRangeStart = 488300, XrefRangeEnd = 488310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Submit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488321, RefRangeEnd = 488322, XrefRangeStart = 488311, XrefRangeEnd = 488321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetCameras(List<Camera> results)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 488342, RefRangeEnd = 488351, XrefRangeStart = 488322, XrefRangeEnd = 488342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExecuteCommandBuffer(CommandBuffer commandBuffer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commandBuffer)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 488371, RefRangeEnd = 488375, XrefRangeStart = 488351, XrefRangeEnd = 488371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExecuteCommandBufferAsync(
    CommandBuffer commandBuffer,
    ComputeQueueType queueType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commandBuffer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &queueType;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 488379, RefRangeEnd = 488383, XrefRangeStart = 488375, XrefRangeEnd = 488379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stereoSetup;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488387, RefRangeEnd = 488388, XrefRangeStart = 488383, XrefRangeEnd = 488387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stereoSetup;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eye;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 488397, RefRangeEnd = 488401, XrefRangeStart = 488388, XrefRangeEnd = 488397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CullingResults Cull(ref ScriptableCullingParameters parameters)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref parameters
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(CullingResults*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488416, RefRangeEnd = 488417, XrefRangeStart = 488401, XrefRangeEnd = 488416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CullShadowCasters(
    CullingResults cullingResults,
    ShadowCastersCullingInfos infos)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) infos));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CullShadowCasters_Public_Void_CullingResults_ShadowCastersCullingInfos_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488417, XrefRangeEnd = 488420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(ScriptableRenderContext other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488420, XrefRangeEnd = 488428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 488441, RefRangeEnd = 488448, XrefRangeStart = 488428, XrefRangeEnd = 488441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateRendererList(RendererListDesc desc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) desc))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488463, RefRangeEnd = 488465, XrefRangeStart = 488448, XrefRangeEnd = 488463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateRendererList(ref RendererListParams param)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) param)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 488474, RefRangeEnd = 488477, XrefRangeStart = 488465, XrefRangeEnd = 488474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateShadowRendererList(ref ShadowDrawingSettings settings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref settings
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererList_byref_ShadowDrawingSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488489, RefRangeEnd = 488490, XrefRangeStart = 488477, XrefRangeEnd = 488489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateSkyboxRendererList(
    Camera camera,
    Matrix4x4 projectionMatrixL,
    Matrix4x4 viewMatrixL,
    Matrix4x4 projectionMatrixR,
    Matrix4x4 viewMatrixR)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &projectionMatrixL;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &viewMatrixL;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &projectionMatrixR;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &viewMatrixR;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488506, RefRangeEnd = 488507, XrefRangeStart = 488490, XrefRangeEnd = 488506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateSkyboxRendererList(
    Camera camera,
    Matrix4x4 projectionMatrix,
    Matrix4x4 viewMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &projectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &viewMatrix;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488527, RefRangeEnd = 488528, XrefRangeStart = 488507, XrefRangeEnd = 488527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateSkyboxRendererList(Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488540, RefRangeEnd = 488541, XrefRangeStart = 488528, XrefRangeEnd = 488540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateGizmoRendererList(Camera camera, GizmoSubset gizmoSubset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gizmoSubset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererList_Camera_GizmoSubset_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488553, RefRangeEnd = 488554, XrefRangeStart = 488541, XrefRangeEnd = 488553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateUIOverlayRendererList(Camera camera, UISubset uiSubset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uiSubset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_UISubset_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488566, RefRangeEnd = 488567, XrefRangeStart = 488554, XrefRangeEnd = 488566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererList CreateWireOverlayRendererList(Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererList_Camera_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488572, RefRangeEnd = 488573, XrefRangeStart = 488567, XrefRangeEnd = 488572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PrepareRendererListsAsync(List<RendererList> rendererLists)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rendererLists)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488581, RefRangeEnd = 488582, XrefRangeStart = 488573, XrefRangeEnd = 488581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererListStatus QueryRendererListStatus(RendererList rendererList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rendererList
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererListStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488582, XrefRangeEnd = 488584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Cull_Injected(
    ref ScriptableCullingParameters parameters,
    [In] ref ScriptableRenderContext renderLoop,
    System.IntPtr results)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref renderLoop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488584, XrefRangeEnd = 488586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CullShadowCasters_Injected(
    [In] ref ScriptableRenderContext renderLoop,
    System.IntPtr context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref renderLoop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &context;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_CullShadowCasters_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488586, XrefRangeEnd = 488588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitializeSortSettings_Injected(
    System.IntPtr camera,
    out SortingSettings sortingSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sortingSettings;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Injected_Private_Static_Void_IntPtr_byref_SortingSettings_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488588, XrefRangeEnd = 488590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteCommandBuffer_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr commandBuffer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488590, XrefRangeEnd = 488592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteCommandBufferAsync_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr commandBuffer,
    ComputeQueueType queueType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &queueType;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_ComputeQueueType_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488592, XrefRangeEnd = 488594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetupCameraProperties_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    bool stereoSetup,
    int eye)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stereoSetup;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eye;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488594, XrefRangeEnd = 488596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateRendererList_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr cullResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings,
    [In] ref ShaderTagId tagName,
    bool isPassTagName,
    System.IntPtr tagValues,
    System.IntPtr stateBlocks,
    int stateCount,
    out RendererList ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[10];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cullResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref drawingSettings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref filteringSettings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tagName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &isPassTagName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tagValues;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &stateBlocks;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &stateCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488596, XrefRangeEnd = 488598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateShadowRendererList_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr shadowDrawinSettings,
    out RendererList ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowDrawinSettings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateShadowRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488598, XrefRangeEnd = 488600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateSkyboxRendererList_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    int mode,
    [In] ref Matrix4x4 proj,
    [In] ref Matrix4x4 view,
    [In] ref Matrix4x4 projR,
    [In] ref Matrix4x4 viewR,
    out RendererList ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref proj;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref view;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref projR;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewR;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488600, XrefRangeEnd = 488602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateGizmoRendererList_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    GizmoSubset gizmoSubset,
    out RendererList ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gizmoSubset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_GizmoSubset_byref_RendererList_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488602, XrefRangeEnd = 488604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateUIOverlayRendererList_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    UISubset uiSubset,
    out RendererList ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &uiSubset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_UISubset_byref_RendererList_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488604, XrefRangeEnd = 488606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateWireOverlayRendererList_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    out RendererList ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488606, XrefRangeEnd = 488608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RendererListStatus QueryRendererListStatus_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    [In] ref RendererList handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref handle;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererListStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe ShaderTagId kRenderTypeTag
  {
    get
    {
      ShaderTagId kRenderTypeTag;
      IL2CPP.il2cpp_field_static_get_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*) &kRenderTypeTag);
      return kRenderTypeTag;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*) &value);
    }
  }

  public static void BeginRenderPass_Internal(
    System.IntPtr self,
    int width,
    int height,
    int volumeDepth,
    int samples,
    System.IntPtr colors,
    int colorCount,
    int depthAttachmentIndex)
  {
    ScriptableRenderContext.BeginRenderPass_InternalDelegateField(self, width, height, volumeDepth, samples, colors, colorCount, depthAttachmentIndex);
  }

  public static void BeginSubPass_Internal(
    System.IntPtr self,
    System.IntPtr colors,
    int colorCount,
    System.IntPtr inputs,
    int inputCount,
    bool isDepthReadOnly,
    bool isStencilReadOnly)
  {
    ScriptableRenderContext.BeginSubPass_InternalDelegateField(self, colors, colorCount, inputs, inputCount, isDepthReadOnly, isStencilReadOnly);
  }

  public static void EndSubPass_Internal(System.IntPtr self)
  {
    ScriptableRenderContext.EndSubPass_InternalDelegateField(self);
  }

  public static void EndRenderPass_Internal(System.IntPtr self)
  {
    ScriptableRenderContext.EndRenderPass_InternalDelegateField(self);
  }

  public static bool HasInvokeOnRenderObjectCallbacks_Internal()
  {
    return ScriptableRenderContext.HasInvokeOnRenderObjectCallbacks_InternalDelegateField();
  }

  public static void PushDisableApiRenderers()
  {
    ScriptableRenderContext.PushDisableApiRenderersDelegateField();
  }

  public static void PopDisableApiRenderers()
  {
    ScriptableRenderContext.PopDisableApiRenderersDelegateField();
  }

  public bool SubmitForRenderPassValidation_Internal()
  {
    return ScriptableRenderContext.SubmitForRenderPassValidation_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void DrawRenderers_Internal(
    System.IntPtr cullResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings,
    ShaderTagId tagName,
    bool isPassTagName,
    System.IntPtr tagValues,
    System.IntPtr stateBlocks,
    int stateCount)
  {
    ScriptableRenderContext.DrawRenderers_Internal_Injected(ref this, cullResults, ref drawingSettings, ref filteringSettings, ref tagName, isPassTagName, tagValues, stateBlocks, stateCount);
  }

  public void DrawShadows_Internal(System.IntPtr shadowDrawingSettings)
  {
    ScriptableRenderContext.DrawShadows_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), shadowDrawingSettings);
  }

  public static void EmitGeometryForCamera(Camera camera)
  {
    ScriptableRenderContext.EmitGeometryForCamera_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<Camera>(camera));
  }

  public void StereoEndRender_Internal(Camera camera, int eye, bool isFinalPass)
  {
    if (camera == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Camera>(camera);
    if (camera1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    ScriptableRenderContext.StereoEndRender_Internal_Injected(ref this, camera1, eye, isFinalPass);
  }

  public void StartMultiEye_Internal(Camera camera, int eye)
  {
    if (camera == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Camera>(camera);
    if (camera1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    ScriptableRenderContext.StartMultiEye_Internal_Injected(ref this, camera1, eye);
  }

  public void StopMultiEye_Internal(Camera camera)
  {
    if (camera == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Camera>(camera);
    if (camera1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    ScriptableRenderContext.StopMultiEye_Internal_Injected(ref this, camera1);
  }

  public void DrawSkybox_Internal(Camera camera)
  {
    if (camera == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Camera>(camera);
    if (camera1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    ScriptableRenderContext.DrawSkybox_Internal_Injected(ref this, camera1);
  }

  public void InvokeOnRenderObjectCallback_Internal()
  {
    ScriptableRenderContext.InvokeOnRenderObjectCallback_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset)
  {
    if (camera == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Camera>(camera);
    if (camera1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    ScriptableRenderContext.DrawGizmos_Internal_Injected(ref this, camera1, gizmoSubset);
  }

  public void DrawWireOverlay_Impl(Camera camera)
  {
    if (camera == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Camera>(camera);
    if (camera1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    ScriptableRenderContext.DrawWireOverlay_Impl_Injected(ref this, camera1);
  }

  public void DrawUIOverlay_Internal(Camera camera)
  {
    if (camera == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Camera>(camera);
    if (camera1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) camera, nameof (camera));
    ScriptableRenderContext.DrawUIOverlay_Internal_Injected(ref this, camera1);
  }

  public System.IntPtr Internal_GetPtr() => this.m_Ptr;

  public unsafe void BeginRenderPass(
    int width,
    int height,
    int volumeDepth,
    int samples,
    NativeArray<AttachmentDescriptor> attachments,
    int depthAttachmentIndex = default (int))
  {
    ScriptableRenderContext.BeginRenderPass_Internal(this.m_Ptr, width, height, volumeDepth, samples, (System.IntPtr) attachments.GetUnsafeReadOnlyPtr<AttachmentDescriptor>(), ((NativeArray<AttachmentDescriptor>) ref attachments).Length, depthAttachmentIndex);
  }

  public unsafe void BeginRenderPass(
    int width,
    int height,
    int samples,
    NativeArray<AttachmentDescriptor> attachments,
    int depthAttachmentIndex = default (int))
  {
    ScriptableRenderContext.BeginRenderPass_Internal(this.m_Ptr, width, height, 1, samples, (System.IntPtr) attachments.GetUnsafeReadOnlyPtr<AttachmentDescriptor>(), ((NativeArray<AttachmentDescriptor>) ref attachments).Length, depthAttachmentIndex);
  }

  public ScopedRenderPass BeginScopedRenderPass(
    int width,
    int height,
    int samples,
    NativeArray<AttachmentDescriptor> attachments,
    int depthAttachmentIndex = default (int))
  {
    this.BeginRenderPass(width, height, samples, attachments, depthAttachmentIndex);
    return new ScopedRenderPass(this);
  }

  public unsafe void BeginSubPass(
    NativeArray<int> colors,
    NativeArray<int> inputs,
    bool isDepthReadOnly,
    bool isStencilReadOnly)
  {
    ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (System.IntPtr) colors.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref colors).Length, (System.IntPtr) inputs.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref inputs).Length, isDepthReadOnly, isStencilReadOnly);
  }

  public unsafe void BeginSubPass(
    NativeArray<int> colors,
    NativeArray<int> inputs,
    bool isDepthStencilReadOnly = default (bool))
  {
    ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (System.IntPtr) colors.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref colors).Length, (System.IntPtr) inputs.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref inputs).Length, isDepthStencilReadOnly, isDepthStencilReadOnly);
  }

  public unsafe void BeginSubPass(
    NativeArray<int> colors,
    bool isDepthReadOnly,
    bool isStencilReadOnly)
  {
    ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (System.IntPtr) colors.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref colors).Length, Il2CppSystem.IntPtr.Zero, 0, isDepthReadOnly, isStencilReadOnly);
  }

  public unsafe void BeginSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = default (bool))
  {
    ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (System.IntPtr) colors.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref colors).Length, Il2CppSystem.IntPtr.Zero, 0, isDepthStencilReadOnly, isDepthStencilReadOnly);
  }

  public ScopedSubPass BeginScopedSubPass(
    NativeArray<int> colors,
    NativeArray<int> inputs,
    bool isDepthReadOnly,
    bool isStencilReadOnly)
  {
    this.BeginSubPass(colors, inputs, isDepthReadOnly, isStencilReadOnly);
    return new ScopedSubPass(this);
  }

  public ScopedSubPass BeginScopedSubPass(
    NativeArray<int> colors,
    NativeArray<int> inputs,
    bool isDepthStencilReadOnly = default (bool))
  {
    this.BeginSubPass(colors, inputs, isDepthStencilReadOnly);
    return new ScopedSubPass(this);
  }

  public ScopedSubPass BeginScopedSubPass(
    NativeArray<int> colors,
    bool isDepthReadOnly,
    bool isStencilReadOnly)
  {
    this.BeginSubPass(colors, isDepthReadOnly, isStencilReadOnly);
    return new ScopedSubPass(this);
  }

  public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = default (bool))
  {
    this.BeginSubPass(colors, isDepthStencilReadOnly);
    return new ScopedSubPass(this);
  }

  public void EndSubPass() => ScriptableRenderContext.EndSubPass_Internal(this.m_Ptr);

  public void EndRenderPass() => ScriptableRenderContext.EndRenderPass_Internal(this.m_Ptr);

  public bool SubmitForRenderPassValidation() => this.SubmitForRenderPassValidation_Internal();

  public bool HasInvokeOnRenderObjectCallbacks()
  {
    return ScriptableRenderContext.HasInvokeOnRenderObjectCallbacks_Internal();
  }

  public void DrawRenderers(
    CullingResults cullingResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings)
  {
    this.DrawRenderers_Internal(cullingResults.ptr, ref drawingSettings, ref filteringSettings, ShaderTagId.none, false, Il2CppSystem.IntPtr.Zero, Il2CppSystem.IntPtr.Zero, 0);
  }

  public unsafe void DrawRenderers(
    CullingResults cullingResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings,
    ref RenderStateBlock stateBlock)
  {
    ShaderTagId shaderTagId = new ShaderTagId();
    fixed (RenderStateBlock* stateBlocks = &stateBlock)
      this.DrawRenderers_Internal(cullingResults.ptr, ref drawingSettings, ref filteringSettings, ShaderTagId.none, false, (System.IntPtr) (void*) &shaderTagId, (System.IntPtr) (void*) stateBlocks, 1);
  }

  public void DrawRenderers(
    CullingResults cullingResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings,
    NativeArray<ShaderTagId> renderTypes,
    NativeArray<RenderStateBlock> stateBlocks)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DrawRenderers(
    CullingResults cullingResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings,
    ShaderTagId tagName,
    bool isPassTagName,
    NativeArray<ShaderTagId> tagValues,
    NativeArray<RenderStateBlock> stateBlocks)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public unsafe void DrawShadows(ref ShadowDrawingSettings settings)
  {
    fixed (ShadowDrawingSettings* shadowDrawingSettings = &settings)
      this.DrawShadows_Internal((System.IntPtr) (void*) shadowDrawingSettings);
  }

  public void StereoEndRender(Camera camera) => this.StereoEndRender(camera, 0, true);

  public void StereoEndRender(Camera camera, int eye) => this.StereoEndRender(camera, eye, true);

  public void StereoEndRender(Camera camera, int eye, bool isFinalPass)
  {
    this.StereoEndRender_Internal(camera, eye, isFinalPass);
  }

  public void StartMultiEye(Camera camera) => this.StartMultiEye(camera, 0);

  public void StartMultiEye(Camera camera, int eye) => this.StartMultiEye_Internal(camera, eye);

  public void StopMultiEye(Camera camera) => this.StopMultiEye_Internal(camera);

  public void DrawSkybox(Camera camera) => this.DrawSkybox_Internal(camera);

  public void InvokeOnRenderObjectCallback() => this.InvokeOnRenderObjectCallback_Internal();

  public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset)
  {
    this.DrawGizmos_Internal(camera, gizmoSubset);
  }

  public void DrawWireOverlay(Camera camera) => this.DrawWireOverlay_Impl(camera);

  public void DrawUIOverlay(Camera camera) => this.DrawUIOverlay_Internal(camera);

  public unsafe void ValidateCullShadowCastersParameters(
    [In] ref CullingResults cullingResults,
    [In] ref ShadowCastersCullingInfos cullingInfos)
  {
    if (false)
      throw new UnityException("CullingResults is null");
    NativeArray<LightShadowCasterCullingInfo> perLightInfos1 = ((ShadowCastersCullingInfos) ref cullingInfos).perLightInfos;
    if (((NativeArray<LightShadowCasterCullingInfo>) ref perLightInfos1).Length == 0)
      return;
    NativeArray<VisibleLight> visibleLights1 = cullingResults.visibleLights;
    int length1 = ((NativeArray<VisibleLight>) ref visibleLights1).Length;
    NativeArray<LightShadowCasterCullingInfo> perLightInfos2 = ((ShadowCastersCullingInfos) ref cullingInfos).perLightInfos;
    int length2 = ((NativeArray<LightShadowCasterCullingInfo>) ref perLightInfos2).Length;
    if (length1 != length2)
    {
      NativeArray<VisibleLight> visibleLights2 = cullingResults.visibleLights;
      // ISSUE: variable of a boxed type
      __Boxed<int> length3 = (System.ValueType) ((NativeArray<VisibleLight>) ref visibleLights2).Length;
      perLightInfos2 = ((ShadowCastersCullingInfos) ref cullingInfos).perLightInfos;
      // ISSUE: variable of a boxed type
      __Boxed<int> length4 = (System.ValueType) ((NativeArray<LightShadowCasterCullingInfo>) ref perLightInfos2).Length;
      throw new UnityException(Il2CppSystem.String.Concat(Il2CppSystem.String.Format("CullingResults.visibleLights.Length ({0}) != ShadowCastersCullingInfos.perLightInfos.Length ({1}). ", (Il2CppSystem.Object) length3, (Il2CppSystem.Object) length4), "ShadowCastersCullingInfos.perLightInfos must have one entry per visible light."));
    }
    LightShadowCasterCullingInfo* unsafeReadOnlyPtr = (LightShadowCasterCullingInfo*) ((ShadowCastersCullingInfos) ref cullingInfos).perLightInfos.GetUnsafeReadOnlyPtr<LightShadowCasterCullingInfo>();
    int index = 0;
    // ISSUE: variable of a reference type
    LightShadowCasterCullingInfo& local;
    RangeInt splitRange;
    NativeArray<ShadowSplitData> splitBuffer;
    while (true)
    {
      int num1 = index;
      perLightInfos2 = ((ShadowCastersCullingInfos) ref cullingInfos).perLightInfos;
      int length5 = ((NativeArray<LightShadowCasterCullingInfo>) ref perLightInfos2).Length;
      if (num1 < length5)
      {
        // ISSUE: explicit reference operation
        local = @unsafeReadOnlyPtr[index];
        splitRange = local.splitRange;
        int start = splitRange.start;
        int length6 = splitRange.length;
        int num2 = start + length6;
        if (start != 0 || length6 != 0)
        {
          int num3;
          if (start >= 0)
          {
            int num4 = start;
            splitBuffer = ((ShadowCastersCullingInfos) ref cullingInfos).splitBuffer;
            int length7 = ((NativeArray<ShadowSplitData>) ref splitBuffer).Length;
            num3 = num4 <= length7 ? 1 : 0;
          }
          else
            num3 = 0;
          bool flag1 = num3 != 0;
          bool flag2 = length6 >= 0 && length6 <= 6;
          int num5;
          if (num2 >= start)
          {
            int num6 = num2;
            splitBuffer = ((ShadowCastersCullingInfos) ref cullingInfos).splitBuffer;
            int length8 = ((NativeArray<ShadowSplitData>) ref splitBuffer).Length;
            num5 = num6 <= length8 ? 1 : 0;
          }
          else
            num5 = 0;
          bool flag3 = num5 != 0;
          if (flag1 & flag2 & flag3)
          {
            if (length6 <= 0 || local.projectionType != BatchCullingProjectionType.Unknown)
            {
              if ((uint) local.splitExclusionMask >> length6 > 0U)
                goto label_20;
            }
            else
              goto label_18;
          }
          else
            break;
        }
        ++index;
      }
      else
        goto label_8;
    }
    string str0 = Il2CppSystem.String.Format("ShadowCastersCullingInfos.perLightInfos[{0}] is referring to an invalid memory location. ", (Il2CppSystem.Object) (System.ValueType) index);
    string str1 = Il2CppSystem.String.Format("splitRange.start ({0}) splitRange.length ({1}) ", (Il2CppSystem.Object) (System.ValueType) splitRange.start, (Il2CppSystem.Object) (System.ValueType) splitRange.length);
    splitBuffer = ((ShadowCastersCullingInfos) ref cullingInfos).splitBuffer;
    string str2 = Il2CppSystem.String.Format("ShadowCastersCullingInfos.splitBuffer.Length ({0}).", (Il2CppSystem.Object) (System.ValueType) ((NativeArray<ShadowSplitData>) ref splitBuffer).Length);
    throw new UnityException(Il2CppSystem.String.Concat(str0, str1, str2));
label_18:
    throw new UnityException(Il2CppSystem.String.Concat(Il2CppSystem.String.Format("ShadowCastersCullingInfos.perLightInfos[{0}].projectionType == {1}. ", (Il2CppSystem.Object) (System.ValueType) index, (Il2CppSystem.Object) (System.Enum) local.projectionType), Il2CppSystem.String.Format("The range however appears to be valid. splitRange.start ({0}) splitRange.length ({1}).", (Il2CppSystem.Object) (System.ValueType) splitRange.start, (Il2CppSystem.Object) (System.ValueType) splitRange.length)));
label_20:
    string str = Il2CppSystem.Convert.ToString((int) local.splitExclusionMask, 2);
    throw new UnityException(Il2CppSystem.String.Concat(Il2CppSystem.String.Format("ShadowCastersCullingInfos.perLightInfos[{0}].splitExclusionMask == 0b{1}. ", (Il2CppSystem.Object) (System.ValueType) index, (Il2CppSystem.Object) str), Il2CppSystem.String.Format("The highest bit set must be less than the split count. splitRange.start ({0}) splitRange.length ({1}).", (Il2CppSystem.Object) (System.ValueType) splitRange.start, (Il2CppSystem.Object) (System.ValueType) splitRange.length)));
label_8:;
  }

  public void Validate()
  {
  }

  public static bool operator ==(ScriptableRenderContext left, ScriptableRenderContext right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(ScriptableRenderContext left, ScriptableRenderContext right)
  {
    return !left.Equals(right);
  }

  public RendererList CreateUIOverlayRendererList(Camera camera)
  {
    return this.CreateUIOverlayRendererList_Internal(camera, UISubset.All);
  }

  public static void DrawRenderers_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr cullResults,
    ref DrawingSettings drawingSettings,
    ref FilteringSettings filteringSettings,
    [In] ref ShaderTagId tagName,
    bool isPassTagName,
    System.IntPtr tagValues,
    System.IntPtr stateBlocks,
    int stateCount)
  {
    ScriptableRenderContext.DrawRenderers_Internal_InjectedDelegateField((System.IntPtr) ref _unity_self, cullResults, (System.IntPtr) ref drawingSettings, (System.IntPtr) ref filteringSettings, (System.IntPtr) ref tagName, isPassTagName, tagValues, stateBlocks, stateCount);
  }

  public static void EmitGeometryForCamera_Injected(System.IntPtr camera)
  {
    ScriptableRenderContext.EmitGeometryForCamera_InjectedDelegateField(camera);
  }

  public static void StereoEndRender_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    int eye,
    bool isFinalPass)
  {
    ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField((System.IntPtr) ref _unity_self, camera, eye, isFinalPass);
  }

  public static void StartMultiEye_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    int eye)
  {
    ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField((System.IntPtr) ref _unity_self, camera, eye);
  }

  public static void StopMultiEye_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera)
  {
    ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField((System.IntPtr) ref _unity_self, camera);
  }

  public static void DrawSkybox_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera)
  {
    ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField((System.IntPtr) ref _unity_self, camera);
  }

  public static void DrawGizmos_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera,
    GizmoSubset gizmoSubset)
  {
    ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField((System.IntPtr) ref _unity_self, camera, gizmoSubset);
  }

  public static void DrawWireOverlay_Impl_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera)
  {
    ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegateField((System.IntPtr) ref _unity_self, camera);
  }

  public static void DrawUIOverlay_Internal_Injected(
    ref ScriptableRenderContext _unity_self,
    System.IntPtr camera)
  {
    ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegateField((System.IntPtr) ref _unity_self, camera);
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct CullShadowCastersContext
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cullResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_splitBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_splitBufferLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_perLightInfos;
    private static readonly System.IntPtr NativeFieldInfoPtr_perLightInfoCount;
    [FieldOffset(0)]
    public System.IntPtr cullResults;
    [FieldOffset(8)]
    public System.IntPtr splitBuffer;
    [FieldOffset(16 /*0x10*/)]
    public int splitBufferLength;
    [FieldOffset(24)]
    public System.IntPtr perLightInfos;
    [FieldOffset(32 /*0x20*/)]
    public int perLightInfoCount;

    static CullShadowCastersContext()
    {
      Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, nameof (CullShadowCastersContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr);
      ScriptableRenderContext.CullShadowCastersContext.NativeFieldInfoPtr_cullResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr, nameof (cullResults));
      ScriptableRenderContext.CullShadowCastersContext.NativeFieldInfoPtr_splitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr, nameof (splitBuffer));
      ScriptableRenderContext.CullShadowCastersContext.NativeFieldInfoPtr_splitBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr, nameof (splitBufferLength));
      ScriptableRenderContext.CullShadowCastersContext.NativeFieldInfoPtr_perLightInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr, nameof (perLightInfos));
      ScriptableRenderContext.CullShadowCastersContext.NativeFieldInfoPtr_perLightInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr, nameof (perLightInfoCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderContext.CullShadowCastersContext>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public enum SkyboxXRMode
  {
    Off,
    Enabled,
    LegacySinglePass,
  }

  private delegate void BeginRenderPass_InternalDelegate(
    System.IntPtr self,
    int width,
    int height,
    int volumeDepth,
    int samples,
    System.IntPtr colors,
    int colorCount,
    int depthAttachmentIndex);

  private delegate void BeginSubPass_InternalDelegate(
    System.IntPtr self,
    System.IntPtr colors,
    int colorCount,
    System.IntPtr inputs,
    int inputCount,
    bool isDepthReadOnly,
    bool isStencilReadOnly);

  private delegate void EndSubPass_InternalDelegate(System.IntPtr self);

  private delegate void EndRenderPass_InternalDelegate(System.IntPtr self);

  private delegate bool HasInvokeOnRenderObjectCallbacks_InternalDelegate();

  private delegate void PushDisableApiRenderersDelegate();

  private delegate void PopDisableApiRenderersDelegate();

  private delegate bool SubmitForRenderPassValidation_InternalDelegate(System.IntPtr _param1);

  private delegate void DrawShadows_InternalDelegate(System.IntPtr _param1, System.IntPtr shadowDrawingSettings);

  private delegate void InvokeOnRenderObjectCallback_InternalDelegate(System.IntPtr _param1);

  private delegate void DrawRenderers_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr cullResults,
    System.IntPtr drawingSettings,
    System.IntPtr filteringSettings,
    [In] System.IntPtr tagName,
    bool isPassTagName,
    System.IntPtr tagValues,
    System.IntPtr stateBlocks,
    int stateCount);

  private delegate void EmitGeometryForCamera_InjectedDelegate(System.IntPtr camera);

  private delegate void StereoEndRender_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr camera,
    int eye,
    bool isFinalPass);

  private delegate void StartMultiEye_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr camera,
    int eye);

  private delegate void StopMultiEye_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera);

  private delegate void DrawSkybox_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera);

  private delegate void DrawGizmos_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr camera,
    GizmoSubset gizmoSubset);

  private delegate void DrawWireOverlay_Impl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera);

  private delegate void DrawUIOverlay_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera);
}
