// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineClearShot
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineClearShot(System.IntPtr pointer) : CinemachineVirtualCameraBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookAt;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Follow;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShowDebugText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildCameras;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActivateAfter;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MinDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RandomizeChoice;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomBlends;
  private static readonly System.IntPtr NativeFieldInfoPtr__LiveChild_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_State;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActivationTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPendingActivationTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPendingCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActiveBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRandomizeNow;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RandomizedChilden;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TransitioningFrom;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LiveChild_Public_get_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LiveChild_Public_set_Void_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGuiHandler_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateListOfChildren_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetRandomization_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateListOfChildren_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ChooseCurrentCamera_Private_ICinemachineCamera_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Randomize_Private_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineClearShot()
  {
    Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineClearShot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr);
    CinemachineClearShot.NativeFieldInfoPtr_m_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_LookAt));
    CinemachineClearShot.NativeFieldInfoPtr_m_Follow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_Follow));
    CinemachineClearShot.NativeFieldInfoPtr_m_ShowDebugText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_ShowDebugText));
    CinemachineClearShot.NativeFieldInfoPtr_m_ChildCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_ChildCameras));
    CinemachineClearShot.NativeFieldInfoPtr_m_ActivateAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_ActivateAfter));
    CinemachineClearShot.NativeFieldInfoPtr_m_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_MinDuration));
    CinemachineClearShot.NativeFieldInfoPtr_m_RandomizeChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_RandomizeChoice));
    CinemachineClearShot.NativeFieldInfoPtr_m_DefaultBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_DefaultBlend));
    CinemachineClearShot.NativeFieldInfoPtr_m_CustomBlends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_CustomBlends));
    CinemachineClearShot.NativeFieldInfoPtr__LiveChild_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, "<LiveChild>k__BackingField");
    CinemachineClearShot.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_State));
    CinemachineClearShot.NativeFieldInfoPtr_mActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (mActivationTime));
    CinemachineClearShot.NativeFieldInfoPtr_mPendingActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (mPendingActivationTime));
    CinemachineClearShot.NativeFieldInfoPtr_mPendingCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (mPendingCamera));
    CinemachineClearShot.NativeFieldInfoPtr_mActiveBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (mActiveBlend));
    CinemachineClearShot.NativeFieldInfoPtr_mRandomizeNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (mRandomizeNow));
    CinemachineClearShot.NativeFieldInfoPtr_m_RandomizedChilden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_RandomizedChilden));
    CinemachineClearShot.NativeFieldInfoPtr_m_TransitioningFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (m_TransitioningFrom));
    CinemachineClearShot.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663405 /*0x0600006D*/);
    CinemachineClearShot.NativeMethodInfoPtr_get_LiveChild_Public_get_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663406 /*0x0600006E*/);
    CinemachineClearShot.NativeMethodInfoPtr_set_LiveChild_Public_set_Void_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663407 /*0x0600006F*/);
    CinemachineClearShot.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663408 /*0x06000070*/);
    CinemachineClearShot.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663409 /*0x06000071*/);
    CinemachineClearShot.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663410 /*0x06000072*/);
    CinemachineClearShot.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663411 /*0x06000073*/);
    CinemachineClearShot.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663412 /*0x06000074*/);
    CinemachineClearShot.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663413 /*0x06000075*/);
    CinemachineClearShot.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663414 /*0x06000076*/);
    CinemachineClearShot.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663415 /*0x06000077*/);
    CinemachineClearShot.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663416 /*0x06000078*/);
    CinemachineClearShot.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663417 /*0x06000079*/);
    CinemachineClearShot.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663418 /*0x0600007A*/);
    CinemachineClearShot.NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663419 /*0x0600007B*/);
    CinemachineClearShot.NativeMethodInfoPtr_OnGuiHandler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663420 /*0x0600007C*/);
    CinemachineClearShot.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663421 /*0x0600007D*/);
    CinemachineClearShot.NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663422 /*0x0600007E*/);
    CinemachineClearShot.NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663423 /*0x0600007F*/);
    CinemachineClearShot.NativeMethodInfoPtr_InvalidateListOfChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663424 /*0x06000080*/);
    CinemachineClearShot.NativeMethodInfoPtr_ResetRandomization_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663425 /*0x06000081*/);
    CinemachineClearShot.NativeMethodInfoPtr_UpdateListOfChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663426 /*0x06000082*/);
    CinemachineClearShot.NativeMethodInfoPtr_ChooseCurrentCamera_Private_ICinemachineCamera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663427 /*0x06000083*/);
    CinemachineClearShot.NativeMethodInfoPtr_Randomize_Private_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663428 /*0x06000084*/);
    CinemachineClearShot.NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663429 /*0x06000085*/);
    CinemachineClearShot.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663430 /*0x06000086*/);
    CinemachineClearShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, 100663431 /*0x06000087*/);
  }

  public override unsafe string Description
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937841, XrefRangeEnd = 937854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_get_LiveChild_Public_get_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_set_LiveChild_Public_set_Void_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe CameraState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
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
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public override unsafe Transform LookAt
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937854, XrefRangeEnd = 937857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937857, XrefRangeEnd = 937860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937860, XrefRangeEnd = 937905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937905, XrefRangeEnd = 937928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937928, XrefRangeEnd = 937940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937940, XrefRangeEnd = 937941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTransformChildrenChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937941, XrefRangeEnd = 937960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnGuiHandler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_OnGuiHandler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool IsBlending
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num3);
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> ChildCameras
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937960, XrefRangeEnd = 937961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num3);
    }
  }

  [CallerCount(0)]
  public unsafe void InvalidateListOfChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_InvalidateListOfChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ResetRandomization()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_ResetRandomization_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 937984 /*0x0E5000*/, RefRangeEnd = 937989, XrefRangeStart = 937961, XrefRangeEnd = 937984 /*0x0E5000*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateListOfChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_UpdateListOfChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938019, RefRangeEnd = 938020, XrefRangeStart = 937989, XrefRangeEnd = 938019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &worldUp
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_ChooseCurrentCamera_Private_ICinemachineCamera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938056, RefRangeEnd = 938057, XrefRangeStart = 938020, XrefRangeEnd = 938056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> Randomize(
    Il2CppReferenceArray<CinemachineVirtualCameraBase> src)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_Randomize_Private_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938057, XrefRangeEnd = 938077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlendDefinition LookupBlend(
    ICinemachineCamera fromKey,
    ICinemachineCamera toKey)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toKey);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CinemachineBlendDefinition(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938077, XrefRangeEnd = 938079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineClearShot.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938079, XrefRangeEnd = 938085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineClearShot()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform m_LookAt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_LookAt));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_LookAt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform m_Follow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_Follow));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_Follow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_ShowDebugText
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_ShowDebugText));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_ShowDebugText)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> m_ChildCameras
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_ChildCameras));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_ChildCameras), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_ActivateAfter
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_ActivateAfter));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_ActivateAfter)) = value;
    }
  }

  public unsafe float m_MinDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_MinDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_MinDuration)) = value;
    }
  }

  public unsafe bool m_RandomizeChoice
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_RandomizeChoice));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_RandomizeChoice)) = value;
    }
  }

  public CinemachineBlendDefinition m_DefaultBlend
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_DefaultBlend);
      return new CinemachineBlendDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_DefaultBlend), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CinemachineBlenderSettings m_CustomBlends
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_CustomBlends));
      return num == System.IntPtr.Zero ? (CinemachineBlenderSettings) null : Il2CppObjectPool.Get<CinemachineBlenderSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_CustomBlends), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineCamera _LiveChild_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr__LiveChild_k__BackingField));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr__LiveChild_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CameraState m_State
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_State);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe float mActivationTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mActivationTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mActivationTime)) = value;
    }
  }

  public unsafe float mPendingActivationTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mPendingActivationTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mPendingActivationTime)) = value;
    }
  }

  public unsafe ICinemachineCamera mPendingCamera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mPendingCamera));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mPendingCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineBlend mActiveBlend
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mActiveBlend));
      return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mActiveBlend), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool mRandomizeNow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mRandomizeNow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_mRandomizeNow)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> m_RandomizedChilden
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_RandomizedChilden));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_RandomizedChilden), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineCamera m_TransitioningFrom
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_TransitioningFrom));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineClearShot.NativeFieldInfoPtr_m_TransitioningFrom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Pair
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_a;
    private static readonly System.IntPtr NativeFieldInfoPtr_b;
    [FieldOffset(0)]
    public int a;
    [FieldOffset(4)]
    public float b;

    static Pair()
    {
      Il2CppClassPointerStore<CinemachineClearShot.Pair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, nameof (Pair));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineClearShot.Pair>.NativeClassPtr);
      CinemachineClearShot.Pair.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot.Pair>.NativeClassPtr, nameof (a));
      CinemachineClearShot.Pair.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot.Pair>.NativeClassPtr, nameof (b));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineClearShot.Pair>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("Cinemachine.CinemachineClearShot+<>c")]
  [Serializable]
  public new sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__49_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Randomize_b__49_0_Internal_Int32_Pair_Pair_0;

    static __c()
    {
      Il2CppClassPointerStore<CinemachineClearShot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineClearShot>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineClearShot.__c>.NativeClassPtr);
      CinemachineClearShot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot.__c>.NativeClassPtr, "<>9");
      CinemachineClearShot.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineClearShot.__c>.NativeClassPtr, "<>9__49_0");
      CinemachineClearShot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot.__c>.NativeClassPtr, 100663433 /*0x06000089*/);
      CinemachineClearShot.__c.NativeMethodInfoPtr__Randomize_b__49_0_Internal_Int32_Pair_Pair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineClearShot.__c>.NativeClassPtr, 100663434 /*0x0600008A*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineClearShot.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe int _Randomize_b__49_0(CinemachineClearShot.Pair p1, CinemachineClearShot.Pair p2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &p1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineClearShot.__c.NativeMethodInfoPtr__Randomize_b__49_0_Internal_Int32_Pair_Pair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CinemachineClearShot.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineClearShot.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CinemachineClearShot.__c) null : Il2CppObjectPool.Get<CinemachineClearShot.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineClearShot.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<CinemachineClearShot.Pair> __9__49_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineClearShot.__c.NativeFieldInfoPtr___9__49_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<CinemachineClearShot.Pair>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<CinemachineClearShot.Pair>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineClearShot.__c.NativeFieldInfoPtr___9__49_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
