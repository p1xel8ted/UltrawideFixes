// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineBrain
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
namespace Cinemachine;

public class CinemachineBrain(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShowDebugText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShowCameraFrustum;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldUpOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendUpdateMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomBlends;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutputCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraCutEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraActivatedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSoloCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPhysicsCoroutine;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastFrameUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_mWaitForFixedUpdate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFrameStack;
  private static readonly System.IntPtr NativeFieldInfoPtr_mNextFrameId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCurrentLiveCameras;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDefaultLinearAnimationCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActiveCameraPreviousFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActiveCameraPreviousFrameGameObject;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentCameraState_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputCamera_Public_get_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ControlledObject_Public_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ControlledObject_Public_set_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SoloCamera_Public_Static_get_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SoloCamera_Public_Static_set_Void_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSoloGUIColor_Public_Static_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultWorldUp_Public_Virtual_Final_New_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSceneUnloaded_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGuiHandler_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AfterPhysics_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ManualUpdate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectiveDeltaTime_Private_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVirtualCameras_Private_Void_UpdateFilter_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveVirtualCamera_Public_get_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeepCamBFromBlend_Private_Static_ICinemachineCamera_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLiveInBlend_Public_Boolean_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveBlend_Public_set_Void_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBrainFrame_Private_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraOverride_Public_Virtual_Final_New_Int32_Int32_ICinemachineCamera_ICinemachineCamera_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseCameraOverride_Public_Virtual_Final_New_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessActiveCamera_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFrame0_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCurrentBlend_Public_Void_byref_CinemachineBlend_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLive_Public_Boolean_ICinemachineCamera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCameraState_Public_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentCameraState_Private_set_Void_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TopCameraFromPriorityQueue_Protected_Virtual_New_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushStateToUnityCamera_Private_Void_byref_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineBrain()
  {
    Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineBrain));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr);
    CinemachineBrain.NativeFieldInfoPtr_m_ShowDebugText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_ShowDebugText));
    CinemachineBrain.NativeFieldInfoPtr_m_ShowCameraFrustum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_ShowCameraFrustum));
    CinemachineBrain.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_IgnoreTimeScale));
    CinemachineBrain.NativeFieldInfoPtr_m_WorldUpOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_WorldUpOverride));
    CinemachineBrain.NativeFieldInfoPtr_m_UpdateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_UpdateMethod));
    CinemachineBrain.NativeFieldInfoPtr_m_BlendUpdateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_BlendUpdateMethod));
    CinemachineBrain.NativeFieldInfoPtr_m_DefaultBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_DefaultBlend));
    CinemachineBrain.NativeFieldInfoPtr_m_CustomBlends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_CustomBlends));
    CinemachineBrain.NativeFieldInfoPtr_m_OutputCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_OutputCamera));
    CinemachineBrain.NativeFieldInfoPtr_m_TargetOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_TargetOverride));
    CinemachineBrain.NativeFieldInfoPtr_m_CameraCutEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_CameraCutEvent));
    CinemachineBrain.NativeFieldInfoPtr_m_CameraActivatedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_CameraActivatedEvent));
    CinemachineBrain.NativeFieldInfoPtr_mSoloCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mSoloCamera));
    CinemachineBrain.NativeFieldInfoPtr_mPhysicsCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mPhysicsCoroutine));
    CinemachineBrain.NativeFieldInfoPtr_m_LastFrameUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (m_LastFrameUpdated));
    CinemachineBrain.NativeFieldInfoPtr_mWaitForFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mWaitForFixedUpdate));
    CinemachineBrain.NativeFieldInfoPtr_mFrameStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mFrameStack));
    CinemachineBrain.NativeFieldInfoPtr_mNextFrameId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mNextFrameId));
    CinemachineBrain.NativeFieldInfoPtr_mCurrentLiveCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mCurrentLiveCameras));
    CinemachineBrain.NativeFieldInfoPtr_mDefaultLinearAnimationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mDefaultLinearAnimationCurve));
    CinemachineBrain.NativeFieldInfoPtr_mActiveCameraPreviousFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mActiveCameraPreviousFrame));
    CinemachineBrain.NativeFieldInfoPtr_mActiveCameraPreviousFrameGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (mActiveCameraPreviousFrameGameObject));
    CinemachineBrain.NativeFieldInfoPtr__CurrentCameraState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, "<CurrentCameraState>k__BackingField");
    CinemachineBrain.NativeMethodInfoPtr_get_OutputCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663356 /*0x0600003C*/);
    CinemachineBrain.NativeMethodInfoPtr_get_ControlledObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663357 /*0x0600003D*/);
    CinemachineBrain.NativeMethodInfoPtr_set_ControlledObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663358 /*0x0600003E*/);
    CinemachineBrain.NativeMethodInfoPtr_get_SoloCamera_Public_Static_get_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663359 /*0x0600003F*/);
    CinemachineBrain.NativeMethodInfoPtr_set_SoloCamera_Public_Static_set_Void_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663360 /*0x06000040*/);
    CinemachineBrain.NativeMethodInfoPtr_GetSoloGUIColor_Public_Static_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663361 /*0x06000041*/);
    CinemachineBrain.NativeMethodInfoPtr_get_DefaultWorldUp_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663362 /*0x06000042*/);
    CinemachineBrain.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663363 /*0x06000043*/);
    CinemachineBrain.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663364 /*0x06000044*/);
    CinemachineBrain.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663365 /*0x06000045*/);
    CinemachineBrain.NativeMethodInfoPtr_OnSceneUnloaded_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663366 /*0x06000046*/);
    CinemachineBrain.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663367 /*0x06000047*/);
    CinemachineBrain.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663368 /*0x06000048*/);
    CinemachineBrain.NativeMethodInfoPtr_OnGuiHandler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663369 /*0x06000049*/);
    CinemachineBrain.NativeMethodInfoPtr_AfterPhysics_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663370 /*0x0600004A*/);
    CinemachineBrain.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663371 /*0x0600004B*/);
    CinemachineBrain.NativeMethodInfoPtr_ManualUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663372 /*0x0600004C*/);
    CinemachineBrain.NativeMethodInfoPtr_GetEffectiveDeltaTime_Private_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663373 /*0x0600004D*/);
    CinemachineBrain.NativeMethodInfoPtr_UpdateVirtualCameras_Private_Void_UpdateFilter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663374 /*0x0600004E*/);
    CinemachineBrain.NativeMethodInfoPtr_get_ActiveVirtualCamera_Public_get_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663375 /*0x0600004F*/);
    CinemachineBrain.NativeMethodInfoPtr_DeepCamBFromBlend_Private_Static_ICinemachineCamera_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663376 /*0x06000050*/);
    CinemachineBrain.NativeMethodInfoPtr_IsLiveInBlend_Public_Boolean_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663377 /*0x06000051*/);
    CinemachineBrain.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663378 /*0x06000052*/);
    CinemachineBrain.NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663379 /*0x06000053*/);
    CinemachineBrain.NativeMethodInfoPtr_set_ActiveBlend_Public_set_Void_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663380 /*0x06000054*/);
    CinemachineBrain.NativeMethodInfoPtr_GetBrainFrame_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663381 /*0x06000055*/);
    CinemachineBrain.NativeMethodInfoPtr_SetCameraOverride_Public_Virtual_Final_New_Int32_Int32_ICinemachineCamera_ICinemachineCamera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663382 /*0x06000056*/);
    CinemachineBrain.NativeMethodInfoPtr_ReleaseCameraOverride_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663383 /*0x06000057*/);
    CinemachineBrain.NativeMethodInfoPtr_ProcessActiveCamera_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663384 /*0x06000058*/);
    CinemachineBrain.NativeMethodInfoPtr_UpdateFrame0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663385 /*0x06000059*/);
    CinemachineBrain.NativeMethodInfoPtr_ComputeCurrentBlend_Public_Void_byref_CinemachineBlend_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663386 /*0x0600005A*/);
    CinemachineBrain.NativeMethodInfoPtr_IsLive_Public_Boolean_ICinemachineCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663387 /*0x0600005B*/);
    CinemachineBrain.NativeMethodInfoPtr_get_CurrentCameraState_Public_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663388 /*0x0600005C*/);
    CinemachineBrain.NativeMethodInfoPtr_set_CurrentCameraState_Private_set_Void_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663389 /*0x0600005D*/);
    CinemachineBrain.NativeMethodInfoPtr_TopCameraFromPriorityQueue_Protected_Virtual_New_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663390 /*0x0600005E*/);
    CinemachineBrain.NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663391 /*0x0600005F*/);
    CinemachineBrain.NativeMethodInfoPtr_PushStateToUnityCamera_Private_Void_byref_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663392 /*0x06000060*/);
    CinemachineBrain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, 100663393 /*0x06000061*/);
  }

  public unsafe Camera OutputCamera
  {
    [CallerCount(14), CachedScanResults(RefRangeStart = 937090, RefRangeEnd = 937104, XrefRangeStart = 937078, XrefRangeEnd = 937090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_OutputCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num3);
    }
  }

  public unsafe GameObject ControlledObject
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 937109, RefRangeEnd = 937113, XrefRangeStart = 937104, XrefRangeEnd = 937109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_ControlledObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937113, XrefRangeEnd = 937117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_set_ControlledObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe ICinemachineCamera SoloCamera
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937117, XrefRangeEnd = 937121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_SoloCamera_Public_Static_get_ICinemachineCamera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937121, XrefRangeEnd = 937138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_set_SoloCamera_Public_Static_set_Void_ICinemachineCamera_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public static unsafe Color GetSoloGUIColor()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_GetSoloGUIColor_Public_Static_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe Vector3 DefaultWorldUp
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 937147, RefRangeEnd = 937154, XrefRangeStart = 937138, XrefRangeEnd = 937147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_DefaultWorldUp_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937154, XrefRangeEnd = 937221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937221, XrefRangeEnd = 937263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937263, XrefRangeEnd = 937266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnSceneLoaded(Scene scene, LoadSceneMode mode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &scene;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937266, XrefRangeEnd = 937269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnSceneUnloaded(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_OnSceneUnloaded_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937269, XrefRangeEnd = 937274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937274, XrefRangeEnd = 937275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937275, XrefRangeEnd = 937335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnGuiHandler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_OnGuiHandler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937335, XrefRangeEnd = 937339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator AfterPhysics()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_AfterPhysics_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937339, XrefRangeEnd = 937340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 937372, RefRangeEnd = 937375, XrefRangeStart = 937340, XrefRangeEnd = 937372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ManualUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_ManualUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 937397, RefRangeEnd = 937400, XrefRangeStart = 937375, XrefRangeEnd = 937397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetEffectiveDeltaTime(bool fixedDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fixedDelta
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_GetEffectiveDeltaTime_Private_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 937441, RefRangeEnd = 937444, XrefRangeStart = 937400, XrefRangeEnd = 937441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateVirtualCameras(
    CinemachineCore.UpdateFilter updateFilter,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateFilter;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_UpdateVirtualCameras_Private_Void_UpdateFilter_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ICinemachineCamera ActiveVirtualCamera
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 937458, RefRangeEnd = 937461, XrefRangeStart = 937444, XrefRangeEnd = 937458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_ActiveVirtualCamera_Public_get_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937461, XrefRangeEnd = 937466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blend)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_DeepCamBFromBlend_Private_Static_ICinemachineCamera_CinemachineBlend_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 937475, RefRangeEnd = 937477, XrefRangeStart = 937466, XrefRangeEnd = 937475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsLiveInBlend(ICinemachineCamera vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_IsLiveInBlend_Public_Boolean_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool IsBlending
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 937478, RefRangeEnd = 937482, XrefRangeStart = 937477, XrefRangeEnd = 937478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_IsBlending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe CinemachineBlend ActiveBlend
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 937490, RefRangeEnd = 937496, XrefRangeStart = 937482, XrefRangeEnd = 937490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_ActiveBlend_Public_get_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937496, XrefRangeEnd = 937499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_set_ActiveBlend_Public_set_Void_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937499, XrefRangeEnd = 937511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetBrainFrame(int withId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &withId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_GetBrainFrame_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937511, XrefRangeEnd = 937543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int SetCameraOverride(
    int overrideId,
    ICinemachineCamera camA,
    ICinemachineCamera camB,
    float weightB,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &overrideId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camA);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camB);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &weightB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_SetCameraOverride_Public_Virtual_Final_New_Int32_Int32_ICinemachineCamera_ICinemachineCamera_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937543, XrefRangeEnd = 937548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReleaseCameraOverride(int overrideId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &overrideId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_ReleaseCameraOverride_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 937593, RefRangeEnd = 937595, XrefRangeStart = 937548, XrefRangeEnd = 937593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessActiveCamera(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_ProcessActiveCamera_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 937655, RefRangeEnd = 937657, XrefRangeStart = 937595, XrefRangeEnd = 937655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateFrame0(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_UpdateFrame0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 937690, RefRangeEnd = 937691, XrefRangeStart = 937657, XrefRangeEnd = 937690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ComputeCurrentBlend(
    ref CinemachineBlend outputBlend,
    int numTopLayersToExclude)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputBlend);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numTopLayersToExclude;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_ComputeCurrentBlend_Public_Void_byref_CinemachineBlend_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    ref CinemachineBlend local = ref outputBlend;
    System.IntPtr pointer = ptr;
    CinemachineBlend cinemachineBlend = pointer == System.IntPtr.Zero ? (CinemachineBlend) null : new CinemachineBlend(pointer);
    local = cinemachineBlend;
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 937714, RefRangeEnd = 937718, XrefRangeStart = 937691, XrefRangeEnd = 937714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dominantChildOnly;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_IsLive_Public_Boolean_ICinemachineCamera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe CameraState CurrentCameraState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_get_CurrentCameraState_Public_get_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_set_CurrentCameraState_Private_set_Void_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937718, XrefRangeEnd = 937740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ICinemachineCamera TopCameraFromPriorityQueue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineBrain.NativeMethodInfoPtr_TopCameraFromPriorityQueue_Protected_Virtual_New_ICinemachineCamera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937740, XrefRangeEnd = 937760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlendDefinition LookupBlend(
    ICinemachineCamera fromKey,
    ICinemachineCamera toKey)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toKey);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_LookupBlend_Private_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CinemachineBlendDefinition(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 937812, RefRangeEnd = 937813, XrefRangeStart = 937760, XrefRangeEnd = 937812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PushStateToUnityCamera(ref CameraState state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr_PushStateToUnityCamera_Private_Void_byref_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937813, XrefRangeEnd = 937841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBrain()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool m_ShowDebugText
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_ShowDebugText));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_ShowDebugText)) = value;
    }
  }

  public unsafe bool m_ShowCameraFrustum
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_ShowCameraFrustum));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_ShowCameraFrustum)) = value;
    }
  }

  public unsafe bool m_IgnoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_IgnoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_IgnoreTimeScale)) = value;
    }
  }

  public unsafe Transform m_WorldUpOverride
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_WorldUpOverride));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_WorldUpOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineBrain.UpdateMethod m_UpdateMethod
  {
    get
    {
      return *(CinemachineBrain.UpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_UpdateMethod));
    }
    [param: In] set
    {
      *(CinemachineBrain.UpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_UpdateMethod)) = value;
    }
  }

  public unsafe CinemachineBrain.BrainUpdateMethod m_BlendUpdateMethod
  {
    get
    {
      return *(CinemachineBrain.BrainUpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_BlendUpdateMethod));
    }
    [param: In] set
    {
      *(CinemachineBrain.BrainUpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_BlendUpdateMethod)) = value;
    }
  }

  public CinemachineBlendDefinition m_DefaultBlend
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_DefaultBlend);
      return new CinemachineBlendDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_DefaultBlend), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CinemachineBlenderSettings m_CustomBlends
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_CustomBlends));
      return num == System.IntPtr.Zero ? (CinemachineBlenderSettings) null : Il2CppObjectPool.Get<CinemachineBlenderSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_CustomBlends), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Camera m_OutputCamera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_OutputCamera));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_OutputCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject m_TargetOverride
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_TargetOverride));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_TargetOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineBrain.BrainEvent m_CameraCutEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_CameraCutEvent));
      return num == System.IntPtr.Zero ? (CinemachineBrain.BrainEvent) null : Il2CppObjectPool.Get<CinemachineBrain.BrainEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_CameraCutEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineBrain.VcamActivatedEvent m_CameraActivatedEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_CameraActivatedEvent));
      return num == System.IntPtr.Zero ? (CinemachineBrain.VcamActivatedEvent) null : Il2CppObjectPool.Get<CinemachineBrain.VcamActivatedEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_CameraActivatedEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ICinemachineCamera mSoloCamera
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineBrain.NativeFieldInfoPtr_mSoloCamera, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineBrain.NativeFieldInfoPtr_mSoloCamera, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Coroutine mPhysicsCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mPhysicsCoroutine));
      return num == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mPhysicsCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_LastFrameUpdated
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_LastFrameUpdated));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_m_LastFrameUpdated)) = value;
    }
  }

  public unsafe WaitForFixedUpdate mWaitForFixedUpdate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mWaitForFixedUpdate));
      return num == System.IntPtr.Zero ? (WaitForFixedUpdate) null : Il2CppObjectPool.Get<WaitForFixedUpdate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mWaitForFixedUpdate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CinemachineBrain.BrainFrame> mFrameStack
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mFrameStack));
      return num == System.IntPtr.Zero ? (List<CinemachineBrain.BrainFrame>) null : Il2CppObjectPool.Get<List<CinemachineBrain.BrainFrame>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mFrameStack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int mNextFrameId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mNextFrameId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mNextFrameId)) = value;
    }
  }

  public unsafe CinemachineBlend mCurrentLiveCameras
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mCurrentLiveCameras));
      return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mCurrentLiveCameras), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe AnimationCurve mDefaultLinearAnimationCurve
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineBrain.NativeFieldInfoPtr_mDefaultLinearAnimationCurve, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineBrain.NativeFieldInfoPtr_mDefaultLinearAnimationCurve, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineCamera mActiveCameraPreviousFrame
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mActiveCameraPreviousFrame));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mActiveCameraPreviousFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject mActiveCameraPreviousFrameGameObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mActiveCameraPreviousFrameGameObject));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr_mActiveCameraPreviousFrameGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CameraState _CurrentCameraState_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr__CurrentCameraState_k__BackingField);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.NativeFieldInfoPtr__CurrentCameraState_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public enum UpdateMethod
  {
    FixedUpdate,
    LateUpdate,
    SmartUpdate,
    ManualUpdate,
  }

  public enum BrainUpdateMethod
  {
    FixedUpdate,
    LateUpdate,
  }

  [Serializable]
  public class BrainEvent(System.IntPtr pointer) : UnityEvent<CinemachineBrain>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static BrainEvent()
    {
      Il2CppClassPointerStore<CinemachineBrain.BrainEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (BrainEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBrain.BrainEvent>.NativeClassPtr);
      CinemachineBrain.BrainEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain.BrainEvent>.NativeClassPtr, 100663395 /*0x06000063*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937037, XrefRangeEnd = 937040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BrainEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBrain.BrainEvent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.BrainEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class VcamActivatedEvent(System.IntPtr pointer) : 
    UnityEvent<ICinemachineCamera, ICinemachineCamera>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VcamActivatedEvent()
    {
      Il2CppClassPointerStore<CinemachineBrain.VcamActivatedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (VcamActivatedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBrain.VcamActivatedEvent>.NativeClassPtr);
      CinemachineBrain.VcamActivatedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain.VcamActivatedEvent>.NativeClassPtr, 100663396 /*0x06000064*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937040, XrefRangeEnd = 937043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VcamActivatedEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBrain.VcamActivatedEvent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.VcamActivatedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public class BrainFrame(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_id;
    private static readonly System.IntPtr NativeFieldInfoPtr_blend;
    private static readonly System.IntPtr NativeFieldInfoPtr_workingBlend;
    private static readonly System.IntPtr NativeFieldInfoPtr_workingBlendSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_deltaTimeOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_blendStartPosition;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static BrainFrame()
    {
      Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, nameof (BrainFrame));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr);
      CinemachineBrain.BrainFrame.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, nameof (id));
      CinemachineBrain.BrainFrame.NativeFieldInfoPtr_blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, nameof (blend));
      CinemachineBrain.BrainFrame.NativeFieldInfoPtr_workingBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, nameof (workingBlend));
      CinemachineBrain.BrainFrame.NativeFieldInfoPtr_workingBlendSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, nameof (workingBlendSource));
      CinemachineBrain.BrainFrame.NativeFieldInfoPtr_deltaTimeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, nameof (deltaTimeOverride));
      CinemachineBrain.BrainFrame.NativeFieldInfoPtr_blendStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, nameof (blendStartPosition));
      CinemachineBrain.BrainFrame.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, 100663397 /*0x06000065*/);
      CinemachineBrain.BrainFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr, 100663398 /*0x06000066*/);
    }

    public unsafe bool Active
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937043, XrefRangeEnd = 937045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.BrainFrame.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 937057, RefRangeEnd = 937062, XrefRangeStart = 937045, XrefRangeEnd = 937057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BrainFrame()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBrain.BrainFrame>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain.BrainFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int id
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_id));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_id)) = value;
      }
    }

    public unsafe CinemachineBlend blend
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_blend));
        return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_blend), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CinemachineBlend workingBlend
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_workingBlend));
        return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_workingBlend), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlendSourceVirtualCamera workingBlendSource
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_workingBlendSource));
        return num == System.IntPtr.Zero ? (BlendSourceVirtualCamera) null : Il2CppObjectPool.Get<BlendSourceVirtualCamera>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_workingBlendSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float deltaTimeOverride
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_deltaTimeOverride));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_deltaTimeOverride)) = value;
      }
    }

    public unsafe float blendStartPosition
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_blendStartPosition));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain.BrainFrame.NativeFieldInfoPtr_blendStartPosition)) = value;
      }
    }
  }

  [ObfuscatedName("Cinemachine.CinemachineBrain+<AfterPhysics>d__38")]
  public sealed class _AfterPhysics_d__38(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _AfterPhysics_d__38()
    {
      Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineBrain>.NativeClassPtr, "<AfterPhysics>d__38");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr);
      CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, "<>1__state");
      CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, "<>2__current");
      CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, "<>4__this");
      CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, 100663399 /*0x06000067*/);
      CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, 100663400 /*0x06000068*/);
      CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, 100663401 /*0x06000069*/);
      CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, 100663402 /*0x0600006A*/);
      CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, 100663403 /*0x0600006B*/);
      CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr, 100663404 /*0x0600006C*/);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _AfterPhysics_d__38(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBrain._AfterPhysics_d__38>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937062, XrefRangeEnd = 937073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937073, XrefRangeEnd = 937078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBrain._AfterPhysics_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CinemachineBrain __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CinemachineBrain) null : Il2CppObjectPool.Get<CinemachineBrain>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBrain._AfterPhysics_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
