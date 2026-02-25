// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineVirtualCamera
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineVirtualCamera(System.IntPtr pointer) : CinemachineVirtualCameraBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookAt;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Follow;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Lens;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Transitions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyBlendHint;
  private static readonly System.IntPtr NativeFieldInfoPtr_PipelineName;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatePipelineOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_DestroyPipelineOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_State;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ComponentPipeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ComponentOwner;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCachedLookAtTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCachedLookAtTargetVcam;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyPipeline_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePipeline_Internal_Transform_CinemachineVirtualCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateComponentPipeline_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentOwner_Public_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentPipeline_Public_Il2CppReferenceArray_1_CinemachineComponentBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCinemachineComponent_Public_CinemachineComponentBase_Stage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCinemachineComponent_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCinemachineComponent_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyCinemachineComponent_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateComponentPipeline_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFlagsForHiddenChild_Internal_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateNewState_Private_CameraState_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetStateRawPosition_Internal_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineVirtualCamera()
  {
    Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineVirtualCamera));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr);
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_LookAt));
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_Follow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_Follow));
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_Lens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_Lens));
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_Transitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_Transitions));
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_LegacyBlendHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_LegacyBlendHint));
    CinemachineVirtualCamera.NativeFieldInfoPtr_PipelineName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (PipelineName));
    CinemachineVirtualCamera.NativeFieldInfoPtr_CreatePipelineOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (CreatePipelineOverride));
    CinemachineVirtualCamera.NativeFieldInfoPtr_DestroyPipelineOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (DestroyPipelineOverride));
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_State));
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_ComponentPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_ComponentPipeline));
    CinemachineVirtualCamera.NativeFieldInfoPtr_m_ComponentOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (m_ComponentOwner));
    CinemachineVirtualCamera.NativeFieldInfoPtr_mCachedLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (mCachedLookAtTarget));
    CinemachineVirtualCamera.NativeFieldInfoPtr_mCachedLookAtTargetVcam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (mCachedLookAtTargetVcam));
    CinemachineVirtualCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663675);
    CinemachineVirtualCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663676);
    CinemachineVirtualCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663677);
    CinemachineVirtualCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663678);
    CinemachineVirtualCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663679);
    CinemachineVirtualCamera.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663680 /*0x06000180*/);
    CinemachineVirtualCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663681);
    CinemachineVirtualCamera.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663682);
    CinemachineVirtualCamera.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663683);
    CinemachineVirtualCamera.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663684);
    CinemachineVirtualCamera.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663685);
    CinemachineVirtualCamera.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663686);
    CinemachineVirtualCamera.NativeMethodInfoPtr_DestroyPipeline_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663687);
    CinemachineVirtualCamera.NativeMethodInfoPtr_CreatePipeline_Internal_Transform_CinemachineVirtualCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663688);
    CinemachineVirtualCamera.NativeMethodInfoPtr_InvalidateComponentPipeline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663689);
    CinemachineVirtualCamera.NativeMethodInfoPtr_GetComponentOwner_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663690);
    CinemachineVirtualCamera.NativeMethodInfoPtr_GetComponentPipeline_Public_Il2CppReferenceArray_1_CinemachineComponentBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663691);
    CinemachineVirtualCamera.NativeMethodInfoPtr_GetCinemachineComponent_Public_CinemachineComponentBase_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663692);
    CinemachineVirtualCamera.NativeMethodInfoPtr_GetCinemachineComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663693);
    CinemachineVirtualCamera.NativeMethodInfoPtr_AddCinemachineComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663694);
    CinemachineVirtualCamera.NativeMethodInfoPtr_DestroyCinemachineComponent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663695);
    CinemachineVirtualCamera.NativeMethodInfoPtr_UpdateComponentPipeline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663696 /*0x06000190*/);
    CinemachineVirtualCamera.NativeMethodInfoPtr_SetFlagsForHiddenChild_Internal_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663697);
    CinemachineVirtualCamera.NativeMethodInfoPtr_CalculateNewState_Private_CameraState_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663698);
    CinemachineVirtualCamera.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663699);
    CinemachineVirtualCamera.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663700);
    CinemachineVirtualCamera.NativeMethodInfoPtr_SetStateRawPosition_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663701);
    CinemachineVirtualCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663702);
    CinemachineVirtualCamera.NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663703);
    CinemachineVirtualCamera.NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663704);
    CinemachineVirtualCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, 100663705);
  }

  public override unsafe CameraState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940537, XrefRangeEnd = 940540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940540, XrefRangeEnd = 940557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940557, XrefRangeEnd = 940583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940583, XrefRangeEnd = 940613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940613, XrefRangeEnd = 940618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 940618, RefRangeEnd = 940621, XrefRangeStart = 940618, XrefRangeEnd = 940618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTransformChildrenChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940621, XrefRangeEnd = 940623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 940692, RefRangeEnd = 940694, XrefRangeStart = 940623, XrefRangeEnd = 940692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroyPipeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_DestroyPipeline_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940721, RefRangeEnd = 940722, XrefRangeStart = 940694, XrefRangeEnd = 940721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform CreatePipeline(CinemachineVirtualCamera copyFrom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyFrom)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_CreatePipeline_Internal_Transform_CinemachineVirtualCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 940618, RefRangeEnd = 940621, XrefRangeStart = 940618, XrefRangeEnd = 940621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvalidateComponentPipeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_InvalidateComponentPipeline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940723, RefRangeEnd = 940724, XrefRangeStart = 940722, XrefRangeEnd = 940723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform GetComponentOwner()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_GetComponentOwner_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 940725, RefRangeEnd = 940727, XrefRangeStart = 940724, XrefRangeEnd = 940725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<CinemachineComponentBase> GetComponentPipeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_GetComponentPipeline_Public_Il2CppReferenceArray_1_CinemachineComponentBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineComponentBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineComponentBase>>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 940730, RefRangeEnd = 940733, XrefRangeStart = 940727, XrefRangeEnd = 940730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &stage
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_GetCinemachineComponent_Public_CinemachineComponentBase_Stage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineComponentBase) null : Il2CppObjectPool.Get<CinemachineComponentBase>(num3);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 940741, RefRangeEnd = 940749, XrefRangeStart = 940733, XrefRangeEnd = 940741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetCinemachineComponent<T>() where T : CinemachineComponentBase
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.MethodInfoStoreGeneric_GetCinemachineComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 940769, RefRangeEnd = 940775, XrefRangeStart = 940749, XrefRangeEnd = 940769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T AddCinemachineComponent<T>() where T : CinemachineComponentBase
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.MethodInfoStoreGeneric_AddCinemachineComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940775, XrefRangeEnd = 940786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroyCinemachineComponent<T>() where T : CinemachineComponentBase
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.MethodInfoStoreGeneric_DestroyCinemachineComponent_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 940858, RefRangeEnd = 940868, XrefRangeStart = 940786, XrefRangeEnd = 940858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateComponentPipeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_UpdateComponentPipeline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940868, XrefRangeEnd = 940878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetFlagsForHiddenChild(GameObject child)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_SetFlagsForHiddenChild_Internal_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940923, RefRangeEnd = 940924, XrefRangeStart = 940878, XrefRangeEnd = 940923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_CalculateNewState_Private_CameraState_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CameraState(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940924, XrefRangeEnd = 940934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940934, XrefRangeEnd = 940939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940939, RefRangeEnd = 940940, XrefRangeStart = 940939, XrefRangeEnd = 940939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetStateRawPosition(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr_SetStateRawPosition_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940940, XrefRangeEnd = 940965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940965, XrefRangeEnd = 940970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RequiresUserInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940970, XrefRangeEnd = 940978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineVirtualCamera.NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940978, XrefRangeEnd = 940987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineVirtualCamera()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform m_LookAt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_LookAt));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_LookAt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform m_Follow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_Follow));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_Follow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LensSettings m_Lens
  {
    get
    {
      return *(LensSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_Lens));
    }
    [param: In] set
    {
      *(LensSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_Lens)) = value;
    }
  }

  public CinemachineVirtualCameraBase.TransitionParams m_Transitions
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_Transitions);
      return new CinemachineVirtualCameraBase.TransitionParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_Transitions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint
  {
    get
    {
      return *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_LegacyBlendHint));
    }
    [param: In] set
    {
      *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_LegacyBlendHint)) = value;
    }
  }

  public static unsafe string PipelineName
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCamera.NativeFieldInfoPtr_PipelineName, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCamera.NativeFieldInfoPtr_PipelineName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCamera.NativeFieldInfoPtr_CreatePipelineOverride, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineVirtualCamera.CreatePipelineDelegate) null : Il2CppObjectPool.Get<CinemachineVirtualCamera.CreatePipelineDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCamera.NativeFieldInfoPtr_CreatePipelineOverride, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCamera.NativeFieldInfoPtr_DestroyPipelineOverride, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineVirtualCamera.DestroyPipelineDelegate) null : Il2CppObjectPool.Get<CinemachineVirtualCamera.DestroyPipelineDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCamera.NativeFieldInfoPtr_DestroyPipelineOverride, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CameraState m_State
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_State);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineComponentBase> m_ComponentPipeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_ComponentPipeline));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineComponentBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineComponentBase>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_ComponentPipeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform m_ComponentOwner
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_ComponentOwner));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_m_ComponentOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform mCachedLookAtTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_mCachedLookAtTarget));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_mCachedLookAtTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase mCachedLookAtTargetVcam
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_mCachedLookAtTargetVcam));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineVirtualCamera.NativeFieldInfoPtr_mCachedLookAtTargetVcam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class CreatePipelineDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Transform_CinemachineVirtualCamera_String_Il2CppReferenceArray_1_CinemachineComponentBase_0;

    static CreatePipelineDelegate()
    {
      Il2CppClassPointerStore<CinemachineVirtualCamera.CreatePipelineDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (CreatePipelineDelegate));
      CinemachineVirtualCamera.CreatePipelineDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera.CreatePipelineDelegate>.NativeClassPtr, 100663706);
      CinemachineVirtualCamera.CreatePipelineDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Transform_CinemachineVirtualCamera_String_Il2CppReferenceArray_1_CinemachineComponentBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera.CreatePipelineDelegate>.NativeClassPtr, 100663707);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 938866, RefRangeEnd = 938868, XrefRangeStart = 938866, XrefRangeEnd = 938868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreatePipelineDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineVirtualCamera.CreatePipelineDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.CreatePipelineDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe Transform Invoke(
      CinemachineVirtualCamera vcam,
      string name,
      Il2CppReferenceArray<CinemachineComponentBase> copyFrom)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyFrom);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.CreatePipelineDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Transform_CinemachineVirtualCamera_String_Il2CppReferenceArray_1_CinemachineComponentBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }

    public static implicit operator CinemachineVirtualCamera.CreatePipelineDelegate(
      [In] System.Func<CinemachineVirtualCamera, string, Il2CppReferenceArray<CinemachineComponentBase>, Transform> obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineVirtualCamera.CreatePipelineDelegate>((System.Delegate) obj0);
    }

    public static CinemachineVirtualCamera.CreatePipelineDelegate operator +(
      [In] CinemachineVirtualCamera.CreatePipelineDelegate obj0,
      [In] CinemachineVirtualCamera.CreatePipelineDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineVirtualCamera.CreatePipelineDelegate>();
    }

    public static CinemachineVirtualCamera.CreatePipelineDelegate operator -(
      [In] CinemachineVirtualCamera.CreatePipelineDelegate obj0,
      [In] CinemachineVirtualCamera.CreatePipelineDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineVirtualCamera.CreatePipelineDelegate) @delegate : @delegate.Cast<CinemachineVirtualCamera.CreatePipelineDelegate>();
    }
  }

  public sealed class DestroyPipelineDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameObject_0;

    static DestroyPipelineDelegate()
    {
      Il2CppClassPointerStore<CinemachineVirtualCamera.DestroyPipelineDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, nameof (DestroyPipelineDelegate));
      CinemachineVirtualCamera.DestroyPipelineDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera.DestroyPipelineDelegate>.NativeClassPtr, 100663708);
      CinemachineVirtualCamera.DestroyPipelineDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera.DestroyPipelineDelegate>.NativeClassPtr, 100663709);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 416874, RefRangeEnd = 416875, XrefRangeStart = 416874, XrefRangeEnd = 416875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyPipelineDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineVirtualCamera.DestroyPipelineDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.DestroyPipelineDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(GameObject pipeline)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pipeline)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.DestroyPipelineDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator CinemachineVirtualCamera.DestroyPipelineDelegate(
      [In] System.Action<GameObject> obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineVirtualCamera.DestroyPipelineDelegate>((System.Delegate) obj0);
    }

    public static CinemachineVirtualCamera.DestroyPipelineDelegate operator +(
      [In] CinemachineVirtualCamera.DestroyPipelineDelegate obj0,
      [In] CinemachineVirtualCamera.DestroyPipelineDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineVirtualCamera.DestroyPipelineDelegate>();
    }

    public static CinemachineVirtualCamera.DestroyPipelineDelegate operator -(
      [In] CinemachineVirtualCamera.DestroyPipelineDelegate obj0,
      [In] CinemachineVirtualCamera.DestroyPipelineDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineVirtualCamera.DestroyPipelineDelegate) @delegate : @delegate.Cast<CinemachineVirtualCamera.DestroyPipelineDelegate>();
    }
  }

  [ObfuscatedName("Cinemachine.CinemachineVirtualCamera+<>c")]
  [Serializable]
  public new sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__37_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__46_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UpdateComponentPipeline_b__37_0_Internal_Int32_CinemachineComponentBase_CinemachineComponentBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RequiresUserInput_b__46_0_Internal_Boolean_CinemachineComponentBase_0;

    static __c()
    {
      Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr);
      CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr, "<>9");
      CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr, "<>9__37_0");
      CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr, "<>9__46_0");
      CinemachineVirtualCamera.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr, 100663711);
      CinemachineVirtualCamera.__c.NativeMethodInfoPtr__UpdateComponentPipeline_b__37_0_Internal_Int32_CinemachineComponentBase_CinemachineComponentBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr, 100663712 /*0x060001A0*/);
      CinemachineVirtualCamera.__c.NativeMethodInfoPtr__RequiresUserInput_b__46_0_Internal_Boolean_CinemachineComponentBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr, 100663713);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineVirtualCamera.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe int _UpdateComponentPipeline_b__37_0(
      CinemachineComponentBase c1,
      CinemachineComponentBase c2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.__c.NativeMethodInfoPtr__UpdateComponentPipeline_b__37_0_Internal_Int32_CinemachineComponentBase_CinemachineComponentBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940533, XrefRangeEnd = 940537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RequiresUserInput_b__46_0(CinemachineComponentBase c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineVirtualCamera.__c.NativeMethodInfoPtr__RequiresUserInput_b__46_0_Internal_Boolean_CinemachineComponentBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CinemachineVirtualCamera.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CinemachineVirtualCamera.__c) null : Il2CppObjectPool.Get<CinemachineVirtualCamera.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<CinemachineComponentBase> __9__37_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9__37_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<CinemachineComponentBase>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<CinemachineComponentBase>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9__37_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CinemachineComponentBase, bool> __9__46_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9__46_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<CinemachineComponentBase, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<CinemachineComponentBase, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineVirtualCamera.__c.NativeFieldInfoPtr___9__46_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetCinemachineComponent_Public_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CinemachineVirtualCamera.NativeMethodInfoPtr_GetCinemachineComponent_Public_T_0, Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AddCinemachineComponent_Public_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CinemachineVirtualCamera.NativeMethodInfoPtr_AddCinemachineComponent_Public_T_0, Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_DestroyCinemachineComponent_Public_Void_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CinemachineVirtualCamera.NativeMethodInfoPtr_DestroyCinemachineComponent_Public_Void_0, Il2CppClassPointerStore<CinemachineVirtualCamera>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
