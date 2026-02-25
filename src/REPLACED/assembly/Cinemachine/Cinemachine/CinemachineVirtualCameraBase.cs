// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineVirtualCameraBase
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineVirtualCameraBase(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExcludedPropertiesInInspector;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LockStageInInspector;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ValidatingStreamVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OnValidateCalled;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StreamingVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Priority;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActivationId;
  private static readonly System.IntPtr NativeFieldInfoPtr_FollowTargetAttachment;
  private static readonly System.IntPtr NativeFieldInfoPtr_LookAtTargetAttachment;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StandbyUpdate;
  private static readonly System.IntPtr NativeFieldInfoPtr__mExtensions_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PreviousStateIsValid_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WasStarted;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSlaveStatusUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_parentVcam;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_QueuePriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_blendStartPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedFollowTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedFollowTargetVcam;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedFollowTargetGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedLookAtTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedLookAtTargetVcam;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedLookAtTargetGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr__FollowTargetChanged_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LookAtTargetChanged_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ValidatingStreamVersion_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ValidatingStreamVersion_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddExtension_Public_Virtual_New_Void_CinemachineExtension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveExtension_Public_Virtual_New_Void_CinemachineExtension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mExtensions_Internal_get_List_1_CinemachineExtension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_mExtensions_Private_set_Void_List_1_CinemachineExtension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokePostPipelineStageCallback_Protected_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokePrePipelineMutateCameraStateCallback_Protected_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnTransitionInExtensions_Protected_Boolean_ICinemachineCamera_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Priority_Public_Virtual_Final_New_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPositionBlendMethod_Protected_Void_byref_CameraState_BlendHint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VirtualCameraGameObject_Public_Virtual_Final_New_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentCamera_Public_Virtual_Final_New_get_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLiveChild_Public_Virtual_New_Boolean_ICinemachineCamera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAt_Public_Abstract_Virtual_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LookAt_Public_Abstract_Virtual_New_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Follow_Public_Abstract_Virtual_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Follow_Public_Abstract_Virtual_New_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PreviousStateIsValid_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PreviousStateIsValid_Public_Virtual_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraState_Public_Virtual_Final_New_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalUpdateCameraState_Public_Abstract_Virtual_New_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_New_Void_ICinemachineCamera_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureStarted_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputAxisProvider_Public_IInputAxisProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSlaveStatus_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveLookAt_Public_Transform_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveFollow_Public_Transform_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVcamPoolStatus_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToTopOfPrioritySubqueue_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_New_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_New_Void_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInheritPosition_Private_Boolean_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBlend_Protected_CinemachineBlend_ICinemachineCamera_ICinemachineCamera_CinemachineBlendDefinition_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullStateFromVirtualCamera_Protected_CameraState_Vector3_byref_LensSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateCachedTargets_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FollowTargetChanged_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FollowTargetChanged_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAtTargetChanged_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LookAtTargetChanged_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTargetCache_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AbstractFollowTargetGroup_Public_get_ICinemachineTargetGroup_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FollowTargetAsVcam_Public_get_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AbstractLookAtTargetGroup_Public_get_ICinemachineTargetGroup_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAtTargetAsVcam_Public_get_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LegacyUpgrade_FamOrAssem_Virtual_New_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelDamping_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static CinemachineVirtualCameraBase()
  {
    Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineVirtualCameraBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr);
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ExcludedPropertiesInInspector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_ExcludedPropertiesInInspector));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_LockStageInInspector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_LockStageInInspector));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ValidatingStreamVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_ValidatingStreamVersion));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_OnValidateCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_OnValidateCalled));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_StreamingVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_StreamingVersion));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_Priority));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ActivationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_ActivationId));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_FollowTargetAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (FollowTargetAttachment));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_LookAtTargetAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (LookAtTargetAttachment));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_StandbyUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_StandbyUpdate));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr__mExtensions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, "<mExtensions>k__BackingField");
    CinemachineVirtualCameraBase.NativeFieldInfoPtr__PreviousStateIsValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, "<PreviousStateIsValid>k__BackingField");
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_WasStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_WasStarted));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_mSlaveStatusUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (mSlaveStatusUpdated));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_parentVcam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_parentVcam));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_QueuePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_QueuePriority));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_blendStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_blendStartPosition));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_CachedFollowTarget));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTargetVcam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_CachedFollowTargetVcam));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTargetGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_CachedFollowTargetGroup));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_CachedLookAtTarget));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTargetVcam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_CachedLookAtTargetVcam));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTargetGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (m_CachedLookAtTargetGroup));
    CinemachineVirtualCameraBase.NativeFieldInfoPtr__FollowTargetChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, "<FollowTargetChanged>k__BackingField");
    CinemachineVirtualCameraBase.NativeFieldInfoPtr__LookAtTargetChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, "<LookAtTargetChanged>k__BackingField");
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_ValidatingStreamVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664050);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_ValidatingStreamVersion_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664051);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664052);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664053);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664054);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664055);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664056);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664057);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664058);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_AddExtension_Public_Virtual_New_Void_CinemachineExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664059);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_RemoveExtension_Public_Virtual_New_Void_CinemachineExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664060);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_mExtensions_Internal_get_List_1_CinemachineExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664061);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_mExtensions_Private_set_Void_List_1_CinemachineExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664062);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvokePostPipelineStageCallback_Protected_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664063);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvokePrePipelineMutateCameraStateCallback_Protected_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664064 /*0x06000300*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvokeOnTransitionInExtensions_Protected_Boolean_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664065 /*0x06000301*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664066 /*0x06000302*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664067 /*0x06000303*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664068 /*0x06000304*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_Priority_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664069 /*0x06000305*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_ApplyPositionBlendMethod_Protected_Void_byref_CameraState_BlendHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664070 /*0x06000306*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_VirtualCameraGameObject_Public_Virtual_Final_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664071 /*0x06000307*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_IsValid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664072 /*0x06000308*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664073 /*0x06000309*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_ParentCamera_Public_Virtual_Final_New_get_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664074 /*0x0600030A*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_New_Boolean_ICinemachineCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664075 /*0x0600030B*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_LookAt_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664076 /*0x0600030C*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_LookAt_Public_Abstract_Virtual_New_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664077 /*0x0600030D*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Follow_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664078 /*0x0600030E*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_Follow_Public_Abstract_Virtual_New_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664079 /*0x0600030F*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_PreviousStateIsValid_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664080 /*0x06000310*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_PreviousStateIsValid_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664081);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateCameraState_Public_Virtual_Final_New_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664082);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Abstract_Virtual_New_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664083);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_New_Void_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664084);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664085);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664086);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664087);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664088);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_EnsureStarted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664089);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_GetInputAxisProvider_Public_IInputAxisProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664090);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664091);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664092);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664093);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664094);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateSlaveStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664095);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_ResolveLookAt_Public_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664096 /*0x06000320*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_ResolveFollow_Public_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664097);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateVcamPoolStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664098);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_MoveToTopOfPrioritySubqueue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664099);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_New_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664100);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_New_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664101);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_GetInheritPosition_Private_Boolean_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664102);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_CreateBlend_Protected_CinemachineBlend_ICinemachineCamera_ICinemachineCamera_CinemachineBlendDefinition_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664103);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_PullStateFromVirtualCamera_Protected_CameraState_Vector3_byref_LensSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664104);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvalidateCachedTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664105);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_FollowTargetChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664106);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_FollowTargetChanged_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664107);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_LookAtTargetChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664108);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_LookAtTargetChanged_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664109);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateTargetCache_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664110);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_AbstractFollowTargetGroup_Public_get_ICinemachineTargetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664111);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_FollowTargetAsVcam_Public_get_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664112 /*0x06000330*/);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_AbstractLookAtTargetGroup_Public_get_ICinemachineTargetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664113);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_LookAtTargetAsVcam_Public_get_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664114);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664115);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664116);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_LegacyUpgrade_FamOrAssem_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664117);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664118);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr_CancelDamping_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664119);
    CinemachineVirtualCameraBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, 100664120);
  }

  public unsafe int ValidatingStreamVersion
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 943745, RefRangeEnd = 943746, XrefRangeStart = 943744, XrefRangeEnd = 943745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_ValidatingStreamVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_ValidatingStreamVersion_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943751, RefRangeEnd = 943752, XrefRangeStart = 943746, XrefRangeEnd = 943751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 943755, RefRangeEnd = 943758, XrefRangeStart = 943752, XrefRangeEnd = 943755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 943763, RefRangeEnd = 943767, XrefRangeStart = 943758, XrefRangeEnd = 943763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 DetachedFollowTargetDamp(
    Vector3 initial,
    Vector3 dampTime,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943770, RefRangeEnd = 943771, XrefRangeStart = 943767, XrefRangeEnd = 943770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedFollowTargetDamp_Public_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 943774, RefRangeEnd = 943780, XrefRangeStart = 943771, XrefRangeEnd = 943774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943780, XrefRangeEnd = 943785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 DetachedLookAtTargetDamp(
    Vector3 initial,
    Vector3 dampTime,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943785, XrefRangeEnd = 943788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_DetachedLookAtTargetDamp_Public_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943788, XrefRangeEnd = 943801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void AddExtension(CinemachineExtension extension)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) extension)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_AddExtension_Public_Virtual_New_Void_CinemachineExtension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943801, XrefRangeEnd = 943804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void RemoveExtension(CinemachineExtension extension)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) extension)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_RemoveExtension_Public_Virtual_New_Void_CinemachineExtension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<CinemachineExtension> mExtensions
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_mExtensions_Internal_get_List_1_CinemachineExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<CinemachineExtension>) null : Il2CppObjectPool.Get<List<CinemachineExtension>>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_mExtensions_Private_set_Void_List_1_CinemachineExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 943832, RefRangeEnd = 943841, XrefRangeStart = 943804, XrefRangeEnd = 943832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvokePostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState newState,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvokePostPipelineStageCallback_Protected_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943869, RefRangeEnd = 943870, XrefRangeStart = 943841, XrefRangeEnd = 943869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvokePrePipelineMutateCameraStateCallback(
    CinemachineVirtualCameraBase vcam,
    ref CameraState newState,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvokePrePipelineMutateCameraStateCallback_Protected_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 943884, RefRangeEnd = 943890, XrefRangeStart = 943870, XrefRangeEnd = 943884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InvokeOnTransitionInExtensions(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvokeOnTransitionInExtensions_Protected_Boolean_ICinemachineCamera_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe string Name
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 222004, RefRangeEnd = 222009, XrefRangeStart = 222004, XrefRangeEnd = 222009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string Description
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943890, XrefRangeEnd = 943892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe int Priority
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 123416, RefRangeEnd = 123429, XrefRangeStart = 123416, XrefRangeEnd = 123429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_Priority_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 943892, RefRangeEnd = 943895, XrefRangeStart = 943892, XrefRangeEnd = 943892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyPositionBlendMethod(
    ref CameraState state,
    CinemachineVirtualCameraBase.BlendHint hint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hint;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_ApplyPositionBlendMethod_Protected_Void_byref_CameraState_BlendHint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe GameObject VirtualCameraGameObject
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943895, XrefRangeEnd = 943900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_VirtualCameraGameObject_Public_Virtual_Final_New_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
  }

  public virtual unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943900, XrefRangeEnd = 943904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_IsValid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe CameraState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_CameraState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
  }

  public virtual unsafe ICinemachineCamera ParentCamera
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 943909, RefRangeEnd = 943911, XrefRangeStart = 943904, XrefRangeEnd = 943909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_ParentCamera_Public_Virtual_Final_New_get_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
    }
  }

  [CallerCount(194)]
  [CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dominantChildOnly;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_New_Boolean_ICinemachineCamera_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe Transform LookAt
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_LookAt_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_LookAt_Public_Abstract_Virtual_New_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Transform Follow
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_Follow_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_Follow_Public_Abstract_Virtual_New_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool PreviousStateIsValid
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_PreviousStateIsValid_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_PreviousStateIsValid_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 943916, RefRangeEnd = 943920, XrefRangeStart = 943911, XrefRangeEnd = 943916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateCameraState_Public_Virtual_Final_New_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Abstract_Virtual_New_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 943922, RefRangeEnd = 943928, XrefRangeStart = 943920, XrefRangeEnd = 943922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnTransitionFromCamera(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_New_Void_ICinemachineCamera_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943944, RefRangeEnd = 943946, XrefRangeStart = 943928, XrefRangeEnd = 943944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943946, XrefRangeEnd = 943956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnTransformParentChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943960, RefRangeEnd = 943961, XrefRangeStart = 943956, XrefRangeEnd = 943960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RequiresUserInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943965, RefRangeEnd = 943967, XrefRangeStart = 943961, XrefRangeEnd = 943965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnsureStarted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_EnsureStarted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 943974, RefRangeEnd = 943980, XrefRangeStart = 943967, XrefRangeEnd = 943974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AxisState.IInputAxisProvider GetInputAxisProvider()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_GetInputAxisProvider_Public_IInputAxisProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AxisState.IInputAxisProvider) null : Il2CppObjectPool.Get<AxisState.IInputAxisProvider>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 943984, RefRangeEnd = 943987, XrefRangeStart = 943980, XrefRangeEnd = 943984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944019, RefRangeEnd = 944025, XrefRangeStart = 943987, XrefRangeEnd = 944019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 944032, RefRangeEnd = 944035, XrefRangeStart = 944025, XrefRangeEnd = 944032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944035, XrefRangeEnd = 944036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 944045, RefRangeEnd = 944053, XrefRangeStart = 944036, XrefRangeEnd = 944045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateSlaveStatus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateSlaveStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944066, RefRangeEnd = 944072, XrefRangeStart = 944053, XrefRangeEnd = 944066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform ResolveLookAt(Transform localLookAt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localLookAt)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_ResolveLookAt_Public_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944085, RefRangeEnd = 944091, XrefRangeStart = 944072, XrefRangeEnd = 944085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform ResolveFollow(Transform localFollow)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localFollow)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_ResolveFollow_Public_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 944113, RefRangeEnd = 944120, XrefRangeStart = 944091, XrefRangeEnd = 944113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateVcamPoolStatus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateVcamPoolStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944120, XrefRangeEnd = 944121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToTopOfPrioritySubqueue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_MoveToTopOfPrioritySubqueue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944126, RefRangeEnd = 944132, XrefRangeStart = 944121, XrefRangeEnd = 944126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_New_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944137, RefRangeEnd = 944143, XrefRangeStart = 944132, XrefRangeEnd = 944137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_New_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944143, XrefRangeEnd = 944146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetInheritPosition(ICinemachineCamera cam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_GetInheritPosition_Private_Boolean_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 944170, RefRangeEnd = 944173, XrefRangeStart = 944146, XrefRangeEnd = 944170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlend CreateBlend(
    ICinemachineCamera camA,
    ICinemachineCamera camB,
    CinemachineBlendDefinition blendDef,
    CinemachineBlend activeBlend)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camA);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camB);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) blendDef));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) activeBlend);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_CreateBlend_Protected_CinemachineBlend_ICinemachineCamera_ICinemachineCamera_CinemachineBlendDefinition_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 944196, RefRangeEnd = 944200, XrefRangeStart = 944173, XrefRangeEnd = 944196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lens;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_PullStateFromVirtualCamera_Protected_CameraState_Vector3_byref_LensSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CameraState(pointer);
  }

  [CallerCount(0)]
  public unsafe void InvalidateCachedTargets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_InvalidateCachedTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool FollowTargetChanged
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_FollowTargetChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_FollowTargetChanged_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool LookAtTargetChanged
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_LookAtTargetChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_set_LookAtTargetChanged_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 944225, RefRangeEnd = 944227, XrefRangeStart = 944200, XrefRangeEnd = 944225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateTargetCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_UpdateTargetCache_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ICinemachineTargetGroup AbstractFollowTargetGroup
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_AbstractFollowTargetGroup_Public_get_ICinemachineTargetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ICinemachineTargetGroup) null : Il2CppObjectPool.Get<ICinemachineTargetGroup>(num3);
    }
  }

  public unsafe CinemachineVirtualCameraBase FollowTargetAsVcam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_FollowTargetAsVcam_Public_get_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num3);
    }
  }

  public unsafe ICinemachineTargetGroup AbstractLookAtTargetGroup
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_AbstractLookAtTargetGroup_Public_get_ICinemachineTargetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ICinemachineTargetGroup) null : Il2CppObjectPool.Get<ICinemachineTargetGroup>(num3);
    }
  }

  public unsafe CinemachineVirtualCameraBase LookAtTargetAsVcam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_get_LookAtTargetAsVcam_Public_get_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num3);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944227, XrefRangeEnd = 944234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LegacyUpgrade(int streamedVersion)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &streamedVersion
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_LegacyUpgrade_FamOrAssem_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCameraBase.NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944234, XrefRangeEnd = 944244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CancelDamping(bool updateNow = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &updateNow
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr_CancelDamping_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 944252, RefRangeEnd = 944259, XrefRangeStart = 944244, XrefRangeEnd = 944252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineVirtualCameraBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStringArray m_ExcludedPropertiesInInspector
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ExcludedPropertiesInInspector));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ExcludedPropertiesInInspector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<CinemachineCore.Stage> m_LockStageInInspector
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_LockStageInInspector));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachineCore.Stage>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachineCore.Stage>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_LockStageInInspector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_ValidatingStreamVersion
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ValidatingStreamVersion));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ValidatingStreamVersion)) = value;
    }
  }

  public unsafe bool m_OnValidateCalled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_OnValidateCalled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_OnValidateCalled)) = value;
    }
  }

  public unsafe int m_StreamingVersion
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_StreamingVersion));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_StreamingVersion)) = value;
    }
  }

  public unsafe int m_Priority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_Priority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_Priority)) = value;
    }
  }

  public unsafe int m_ActivationId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ActivationId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_ActivationId)) = value;
    }
  }

  public unsafe float FollowTargetAttachment
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_FollowTargetAttachment));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_FollowTargetAttachment)) = value;
    }
  }

  public unsafe float LookAtTargetAttachment
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_LookAtTargetAttachment));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_LookAtTargetAttachment)) = value;
    }
  }

  public unsafe CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate
  {
    get
    {
      return *(CinemachineVirtualCameraBase.StandbyUpdateMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_StandbyUpdate));
    }
    [param: In] set
    {
      *(CinemachineVirtualCameraBase.StandbyUpdateMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_StandbyUpdate)) = value;
    }
  }

  public unsafe List<CinemachineExtension> _mExtensions_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__mExtensions_k__BackingField));
      return num == System.IntPtr.Zero ? (List<CinemachineExtension>) null : Il2CppObjectPool.Get<List<CinemachineExtension>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__mExtensions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _PreviousStateIsValid_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__PreviousStateIsValid_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__PreviousStateIsValid_k__BackingField)) = value;
    }
  }

  public unsafe bool m_WasStarted
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_WasStarted));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_WasStarted)) = value;
    }
  }

  public unsafe bool mSlaveStatusUpdated
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_mSlaveStatusUpdated));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_mSlaveStatusUpdated)) = value;
    }
  }

  public unsafe CinemachineVirtualCameraBase m_parentVcam
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_parentVcam));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_parentVcam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_QueuePriority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_QueuePriority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_QueuePriority)) = value;
    }
  }

  public unsafe float m_blendStartPosition
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_blendStartPosition));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_blendStartPosition)) = value;
    }
  }

  public unsafe Transform m_CachedFollowTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTarget));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase m_CachedFollowTargetVcam
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTargetVcam));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTargetVcam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineTargetGroup m_CachedFollowTargetGroup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTargetGroup));
      return num == System.IntPtr.Zero ? (ICinemachineTargetGroup) null : Il2CppObjectPool.Get<ICinemachineTargetGroup>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedFollowTargetGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform m_CachedLookAtTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTarget));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase m_CachedLookAtTargetVcam
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTargetVcam));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTargetVcam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineTargetGroup m_CachedLookAtTargetGroup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTargetGroup));
      return num == System.IntPtr.Zero ? (ICinemachineTargetGroup) null : Il2CppObjectPool.Get<ICinemachineTargetGroup>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr_m_CachedLookAtTargetGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _FollowTargetChanged_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__FollowTargetChanged_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__FollowTargetChanged_k__BackingField)) = value;
    }
  }

  public unsafe bool _LookAtTargetChanged_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__LookAtTargetChanged_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.NativeFieldInfoPtr__LookAtTargetChanged_k__BackingField)) = value;
    }
  }

  public enum StandbyUpdateMode
  {
    Never,
    Always,
    RoundRobin,
  }

  public enum BlendHint
  {
    None,
    SphericalPosition,
    CylindricalPosition,
    ScreenSpaceAimWhenTargetsDiffer,
  }

  [Serializable]
  public sealed class TransitionParams : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendHint;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_InheritPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OnCameraLive;

    static TransitionParams()
    {
      Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, nameof (TransitionParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr);
      CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_BlendHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr, nameof (m_BlendHint));
      CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_InheritPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr, nameof (m_InheritPosition));
      CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_OnCameraLive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr, nameof (m_OnCameraLive));
    }

    public TransitionParams(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TransitionParams()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr))
    {
    }

    public unsafe CinemachineVirtualCameraBase.BlendHint m_BlendHint
    {
      get
      {
        return *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_BlendHint));
      }
      [param: In] set
      {
        *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_BlendHint)) = value;
      }
    }

    public unsafe bool m_InheritPosition
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_InheritPosition));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_InheritPosition)) = value;
      }
    }

    public unsafe CinemachineBrain.VcamActivatedEvent m_OnCameraLive
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_OnCameraLive));
        return num == System.IntPtr.Zero ? (CinemachineBrain.VcamActivatedEvent) null : Il2CppObjectPool.Get<CinemachineBrain.VcamActivatedEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCameraBase.TransitionParams.NativeFieldInfoPtr_m_OnCameraLive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Cinemachine.CinemachineVirtualCameraBase+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__66_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RequiresUserInput_b__66_0_Internal_Boolean_CinemachineExtension_0;

    static __c()
    {
      Il2CppClassPointerStore<CinemachineVirtualCameraBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineVirtualCameraBase>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineVirtualCameraBase.__c>.NativeClassPtr);
      CinemachineVirtualCameraBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase.__c>.NativeClassPtr, "<>9");
      CinemachineVirtualCameraBase.__c.NativeFieldInfoPtr___9__66_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCameraBase.__c>.NativeClassPtr, "<>9__66_0");
      CinemachineVirtualCameraBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase.__c>.NativeClassPtr, 100664122);
      CinemachineVirtualCameraBase.__c.NativeMethodInfoPtr__RequiresUserInput_b__66_0_Internal_Boolean_CinemachineExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCameraBase.__c>.NativeClassPtr, 100664123);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineVirtualCameraBase.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943740, XrefRangeEnd = 943744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RequiresUserInput_b__66_0(CinemachineExtension extension)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) extension)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCameraBase.__c.NativeMethodInfoPtr__RequiresUserInput_b__66_0_Internal_Boolean_CinemachineExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CinemachineVirtualCameraBase.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCameraBase.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CinemachineVirtualCameraBase.__c) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCameraBase.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CinemachineExtension, bool> __9__66_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCameraBase.__c.NativeFieldInfoPtr___9__66_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<CinemachineExtension, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<CinemachineExtension, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCameraBase.__c.NativeFieldInfoPtr___9__66_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
