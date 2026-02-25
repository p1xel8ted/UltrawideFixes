// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineStateDrivenCamera
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

public class CinemachineStateDrivenCamera(System.IntPtr pointer) : CinemachineVirtualCameraBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookAt;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Follow;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimatedTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShowDebugText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildCameras;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Instructions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomBlends;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParentHash;
  private static readonly System.IntPtr NativeFieldInfoPtr__LiveChild_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TransitioningFrom;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_State;
  private static readonly System.IntPtr NativeFieldInfoPtr_mHashCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActivationTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActiveInstruction;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPendingActivationTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPendingInstruction;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActiveBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInstructionDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_mStateParentLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_clipInfoList;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LiveChild_Public_get_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LiveChild_Public_set_Void_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGuiHandler_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateFakeHash_Public_Static_Int32_Int32_AnimationClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookupFakeHash_Private_Int32_Int32_AnimationClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateListOfChildren_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateListOfChildren_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateInstructions_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ChooseCurrentCamera_Private_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetClipHash_Private_Int32_Int32_List_1_AnimatorClipInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineStateDrivenCamera()
  {
    Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineStateDrivenCamera));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr);
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_LookAt));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_Follow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_Follow));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_AnimatedTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_AnimatedTarget));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_LayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_LayerIndex));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ShowDebugText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_ShowDebugText));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ChildCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_ChildCameras));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_Instructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_Instructions));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_DefaultBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_DefaultBlend));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_CustomBlends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_CustomBlends));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ParentHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_ParentHash));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr__LiveChild_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, "<LiveChild>k__BackingField");
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_TransitioningFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_TransitioningFrom));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_State));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mHashCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mHashCache));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mActivationTime));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActiveInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mActiveInstruction));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mPendingActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mPendingActivationTime));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mPendingInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mPendingInstruction));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActiveBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mActiveBlend));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mInstructionDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mInstructionDictionary));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_mStateParentLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (mStateParentLookup));
    CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_clipInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (m_clipInfoList));
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663602);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_LiveChild_Public_get_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663603);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_set_LiveChild_Public_set_Void_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663604);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663605);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663606);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663607);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663608);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663609);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663610);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663611);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663612);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663613);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663614);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663615);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663616 /*0x06000140*/);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663617);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnGuiHandler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663618);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663619);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663620);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663621);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_CreateFakeHash_Public_Static_Int32_Int32_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663622);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_LookupFakeHash_Private_Int32_Int32_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663623);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_InvalidateListOfChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663624);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_UpdateListOfChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663625);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_ValidateInstructions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663626);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_ChooseCurrentCamera_Private_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663627);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_GetClipHash_Private_Int32_Int32_List_1_AnimatorClipInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663628);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663629);
    CinemachineStateDrivenCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, 100663630);
  }

  public override unsafe string Description
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939626, XrefRangeEnd = 939639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ICinemachineCamera LiveChild
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_LiveChild_Public_get_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_set_LiveChild_Public_set_Void_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public override unsafe bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dominantChildOnly;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public override unsafe CameraState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
  }

  public override unsafe Transform LookAt
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe Transform Follow
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939639, XrefRangeEnd = 939642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939642, XrefRangeEnd = 939645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939645, XrefRangeEnd = 939647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTransitionFromCamera(
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939647, XrefRangeEnd = 939701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939701, XrefRangeEnd = 939724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939724, XrefRangeEnd = 939736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnTransformChildrenChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939736, XrefRangeEnd = 939755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnGuiHandler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_OnGuiHandler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> ChildCameras
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939755, XrefRangeEnd = 939756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num3);
    }
  }

  public unsafe bool IsBlending
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe CinemachineBlend ActiveBlend
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939756, XrefRangeEnd = 939762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CreateFakeHash(int parentHash, AnimationClip clip)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &parentHash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_CreateFakeHash_Public_Static_Int32_Int32_AnimationClip_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939789, RefRangeEnd = 939790, XrefRangeStart = 939762, XrefRangeEnd = 939789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int LookupFakeHash(int parentHash, AnimationClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &parentHash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_LookupFakeHash_Private_Int32_Int32_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void InvalidateListOfChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_InvalidateListOfChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 939814, RefRangeEnd = 939818, XrefRangeStart = 939790, XrefRangeEnd = 939814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateListOfChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_UpdateListOfChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939851, RefRangeEnd = 939852, XrefRangeStart = 939818, XrefRangeEnd = 939851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ValidateInstructions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_ValidateInstructions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939885, RefRangeEnd = 939886, XrefRangeStart = 939852, XrefRangeEnd = 939885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineVirtualCameraBase ChooseCurrentCamera()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_ChooseCurrentCamera_Private_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939902, RefRangeEnd = 939903, XrefRangeStart = 939886, XrefRangeEnd = 939902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetClipHash(int hash, List<AnimatorClipInfo> clips)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &hash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clips);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_GetClipHash_Private_Int32_Int32_List_1_AnimatorClipInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939903, XrefRangeEnd = 939923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlendDefinition LookupBlend(
    ICinemachineCamera fromKey,
    ICinemachineCamera toKey)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toKey);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CinemachineBlendDefinition(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939923, XrefRangeEnd = 939935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineStateDrivenCamera()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStateDrivenCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform m_LookAt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_LookAt));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_LookAt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform m_Follow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_Follow));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_Follow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Animator m_AnimatedTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_AnimatedTarget));
      return num == System.IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_AnimatedTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_LayerIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_LayerIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_LayerIndex)) = value;
    }
  }

  public unsafe bool m_ShowDebugText
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ShowDebugText));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ShowDebugText)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> m_ChildCameras
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ChildCameras));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ChildCameras), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineStateDrivenCamera.Instruction> m_Instructions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_Instructions));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineStateDrivenCamera.Instruction>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineStateDrivenCamera.Instruction>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_Instructions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CinemachineBlendDefinition m_DefaultBlend
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_DefaultBlend);
      return new CinemachineBlendDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_DefaultBlend), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CinemachineBlenderSettings m_CustomBlends
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_CustomBlends));
      return num == System.IntPtr.Zero ? (CinemachineBlenderSettings) null : Il2CppObjectPool.Get<CinemachineBlenderSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_CustomBlends), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<CinemachineStateDrivenCamera.ParentHash> m_ParentHash
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ParentHash));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachineStateDrivenCamera.ParentHash>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachineStateDrivenCamera.ParentHash>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_ParentHash), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineCamera _LiveChild_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr__LiveChild_k__BackingField));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr__LiveChild_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineCamera m_TransitioningFrom
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_TransitioningFrom));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_TransitioningFrom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CameraState m_State
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_State);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>> mHashCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mHashCache));
      return num == System.IntPtr.Zero ? (Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>) null : Il2CppObjectPool.Get<Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mHashCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float mActivationTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActivationTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActivationTime)) = value;
    }
  }

  public CinemachineStateDrivenCamera.Instruction mActiveInstruction
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActiveInstruction);
      return new CinemachineStateDrivenCamera.Instruction(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActiveInstruction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe float mPendingActivationTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mPendingActivationTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mPendingActivationTime)) = value;
    }
  }

  public CinemachineStateDrivenCamera.Instruction mPendingInstruction
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mPendingInstruction);
      return new CinemachineStateDrivenCamera.Instruction(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mPendingInstruction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CinemachineBlend mActiveBlend
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActiveBlend));
      return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mActiveBlend), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, int> mInstructionDictionary
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mInstructionDictionary));
      return num == System.IntPtr.Zero ? (Dictionary<int, int>) null : Il2CppObjectPool.Get<Dictionary<int, int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mInstructionDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, int> mStateParentLookup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mStateParentLookup));
      return num == System.IntPtr.Zero ? (Dictionary<int, int>) null : Il2CppObjectPool.Get<Dictionary<int, int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_mStateParentLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<AnimatorClipInfo> m_clipInfoList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_clipInfoList));
      return num == System.IntPtr.Zero ? (List<AnimatorClipInfo>) null : Il2CppObjectPool.Get<List<AnimatorClipInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.NativeFieldInfoPtr_m_clipInfoList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Instruction : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FullHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VirtualCamera;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ActivateAfter;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MinDuration;

    static Instruction()
    {
      Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (Instruction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr);
      CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_FullHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, nameof (m_FullHash));
      CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_VirtualCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, nameof (m_VirtualCamera));
      CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_ActivateAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, nameof (m_ActivateAfter));
      CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr, nameof (m_MinDuration));
    }

    public Instruction(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Instruction()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineStateDrivenCamera.Instruction>.NativeClassPtr))
    {
    }

    public unsafe int m_FullHash
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_FullHash));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_FullHash)) = value;
      }
    }

    public unsafe CinemachineVirtualCameraBase m_VirtualCamera
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_VirtualCamera));
        return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_VirtualCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float m_ActivateAfter
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_ActivateAfter));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_ActivateAfter)) = value;
      }
    }

    public unsafe float m_MinDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_MinDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStateDrivenCamera.Instruction.NativeFieldInfoPtr_m_MinDuration)) = value;
      }
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ParentHash
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Hash;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParentHash;
    [FieldOffset(0)]
    public int m_Hash;
    [FieldOffset(4)]
    public int m_ParentHash;

    static ParentHash()
    {
      Il2CppClassPointerStore<CinemachineStateDrivenCamera.ParentHash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (ParentHash));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineStateDrivenCamera.ParentHash>.NativeClassPtr);
      CinemachineStateDrivenCamera.ParentHash.NativeFieldInfoPtr_m_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.ParentHash>.NativeClassPtr, nameof (m_Hash));
      CinemachineStateDrivenCamera.ParentHash.NativeFieldInfoPtr_m_ParentHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.ParentHash>.NativeClassPtr, nameof (m_ParentHash));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineStateDrivenCamera.ParentHash>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct HashPair
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_parentHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_hash;
    [FieldOffset(0)]
    public int parentHash;
    [FieldOffset(4)]
    public int hash;

    static HashPair()
    {
      Il2CppClassPointerStore<CinemachineStateDrivenCamera.HashPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineStateDrivenCamera>.NativeClassPtr, nameof (HashPair));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineStateDrivenCamera.HashPair>.NativeClassPtr);
      CinemachineStateDrivenCamera.HashPair.NativeFieldInfoPtr_parentHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.HashPair>.NativeClassPtr, nameof (parentHash));
      CinemachineStateDrivenCamera.HashPair.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStateDrivenCamera.HashPair>.NativeClassPtr, nameof (hash));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineStateDrivenCamera.HashPair>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
