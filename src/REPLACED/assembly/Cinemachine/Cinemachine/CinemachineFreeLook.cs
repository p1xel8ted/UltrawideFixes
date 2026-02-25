// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineFreeLook
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

public class CinemachineFreeLook(System.IntPtr pointer) : CinemachineVirtualCameraBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookAt;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Follow;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CommonLens;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Lens;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Transitions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyBlendHint;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_YAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_YAxisRecentering;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_XAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Heading;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RecenterToTargetHeading;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SplineCurvature;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Orbits;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyHeadingBias;
  private static readonly System.IntPtr NativeFieldInfoPtr_mUseLegacyRigDefinitions;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsDestroyed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_State;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Rigs;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOrbitals;
  private static readonly System.IntPtr NativeFieldInfoPtr_mBlendA;
  private static readonly System.IntPtr NativeFieldInfoPtr_mBlendB;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreateRigOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_DestroyRigOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedXAxisHeading;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastHeadingUpdateFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedOrbits;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedTension;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedKnots;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedCtrl1;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedCtrl2;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRig_Public_CinemachineVirtualCamera_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RigsAreCreated_Internal_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RigNames_Public_Static_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PreviousStateIsValid_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PreviousStateIsValid_Public_Virtual_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetYAxisClosestValue_Private_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SteepestDescent_Private_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateRigCache_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyRigs_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRigs_Private_Il2CppReferenceArray_1_CinemachineVirtualCamera_Il2CppReferenceArray_1_CinemachineVirtualCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRigCache_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocateExistingRigs_Private_List_1_CinemachineVirtualCamera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateXAxisHeading_Private_Single_CinemachineOrbitalTransposer_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushSettingsToRigs_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetYAxisValue_Private_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateNewState_Private_CameraState_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPositionForCameraFromInput_Public_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCachedSpline_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass47_0_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass47_0_PDM_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Single_byref___c__DisplayClass47_0_PDM_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Single_byref___c__DisplayClass47_0_byref___c__DisplayClass47_1_PDM_0;

  static CinemachineFreeLook()
  {
    Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineFreeLook));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr);
    CinemachineFreeLook.NativeFieldInfoPtr_m_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_LookAt));
    CinemachineFreeLook.NativeFieldInfoPtr_m_Follow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_Follow));
    CinemachineFreeLook.NativeFieldInfoPtr_m_CommonLens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_CommonLens));
    CinemachineFreeLook.NativeFieldInfoPtr_m_Lens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_Lens));
    CinemachineFreeLook.NativeFieldInfoPtr_m_Transitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_Transitions));
    CinemachineFreeLook.NativeFieldInfoPtr_m_LegacyBlendHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_LegacyBlendHint));
    CinemachineFreeLook.NativeFieldInfoPtr_m_YAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_YAxis));
    CinemachineFreeLook.NativeFieldInfoPtr_m_YAxisRecentering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_YAxisRecentering));
    CinemachineFreeLook.NativeFieldInfoPtr_m_XAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_XAxis));
    CinemachineFreeLook.NativeFieldInfoPtr_m_Heading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_Heading));
    CinemachineFreeLook.NativeFieldInfoPtr_m_RecenterToTargetHeading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_RecenterToTargetHeading));
    CinemachineFreeLook.NativeFieldInfoPtr_m_BindingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_BindingMode));
    CinemachineFreeLook.NativeFieldInfoPtr_m_SplineCurvature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_SplineCurvature));
    CinemachineFreeLook.NativeFieldInfoPtr_m_Orbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_Orbits));
    CinemachineFreeLook.NativeFieldInfoPtr_m_LegacyHeadingBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_LegacyHeadingBias));
    CinemachineFreeLook.NativeFieldInfoPtr_mUseLegacyRigDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (mUseLegacyRigDefinitions));
    CinemachineFreeLook.NativeFieldInfoPtr_mIsDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (mIsDestroyed));
    CinemachineFreeLook.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_State));
    CinemachineFreeLook.NativeFieldInfoPtr_m_Rigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_Rigs));
    CinemachineFreeLook.NativeFieldInfoPtr_mOrbitals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (mOrbitals));
    CinemachineFreeLook.NativeFieldInfoPtr_mBlendA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (mBlendA));
    CinemachineFreeLook.NativeFieldInfoPtr_mBlendB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (mBlendB));
    CinemachineFreeLook.NativeFieldInfoPtr_CreateRigOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (CreateRigOverride));
    CinemachineFreeLook.NativeFieldInfoPtr_DestroyRigOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (DestroyRigOverride));
    CinemachineFreeLook.NativeFieldInfoPtr_m_CachedXAxisHeading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_CachedXAxisHeading));
    CinemachineFreeLook.NativeFieldInfoPtr_m_LastHeadingUpdateFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_LastHeadingUpdateFrame));
    CinemachineFreeLook.NativeFieldInfoPtr_m_CachedOrbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_CachedOrbits));
    CinemachineFreeLook.NativeFieldInfoPtr_m_CachedTension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_CachedTension));
    CinemachineFreeLook.NativeFieldInfoPtr_m_CachedKnots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_CachedKnots));
    CinemachineFreeLook.NativeFieldInfoPtr_m_CachedCtrl1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_CachedCtrl1));
    CinemachineFreeLook.NativeFieldInfoPtr_m_CachedCtrl2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (m_CachedCtrl2));
    CinemachineFreeLook.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663502 /*0x060000CE*/);
    CinemachineFreeLook.NativeMethodInfoPtr_GetRig_Public_CinemachineVirtualCamera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663503 /*0x060000CF*/);
    CinemachineFreeLook.NativeMethodInfoPtr_get_RigsAreCreated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663504 /*0x060000D0*/);
    CinemachineFreeLook.NativeMethodInfoPtr_get_RigNames_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663505 /*0x060000D1*/);
    CinemachineFreeLook.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663506 /*0x060000D2*/);
    CinemachineFreeLook.NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663507 /*0x060000D3*/);
    CinemachineFreeLook.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663508 /*0x060000D4*/);
    CinemachineFreeLook.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663509 /*0x060000D5*/);
    CinemachineFreeLook.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663510 /*0x060000D6*/);
    CinemachineFreeLook.NativeMethodInfoPtr_get_PreviousStateIsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663511 /*0x060000D7*/);
    CinemachineFreeLook.NativeMethodInfoPtr_set_PreviousStateIsValid_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663512 /*0x060000D8*/);
    CinemachineFreeLook.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663513 /*0x060000D9*/);
    CinemachineFreeLook.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663514 /*0x060000DA*/);
    CinemachineFreeLook.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663515 /*0x060000DB*/);
    CinemachineFreeLook.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663516 /*0x060000DC*/);
    CinemachineFreeLook.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663517 /*0x060000DD*/);
    CinemachineFreeLook.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663518 /*0x060000DE*/);
    CinemachineFreeLook.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663519 /*0x060000DF*/);
    CinemachineFreeLook.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663520 /*0x060000E0*/);
    CinemachineFreeLook.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663521 /*0x060000E1*/);
    CinemachineFreeLook.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663522 /*0x060000E2*/);
    CinemachineFreeLook.NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663523 /*0x060000E3*/);
    CinemachineFreeLook.NativeMethodInfoPtr_GetYAxisClosestValue_Private_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663524 /*0x060000E4*/);
    CinemachineFreeLook.NativeMethodInfoPtr_SteepestDescent_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663525 /*0x060000E5*/);
    CinemachineFreeLook.NativeMethodInfoPtr_InvalidateRigCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663526 /*0x060000E6*/);
    CinemachineFreeLook.NativeMethodInfoPtr_DestroyRigs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663527 /*0x060000E7*/);
    CinemachineFreeLook.NativeMethodInfoPtr_CreateRigs_Private_Il2CppReferenceArray_1_CinemachineVirtualCamera_Il2CppReferenceArray_1_CinemachineVirtualCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663528 /*0x060000E8*/);
    CinemachineFreeLook.NativeMethodInfoPtr_UpdateRigCache_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663529 /*0x060000E9*/);
    CinemachineFreeLook.NativeMethodInfoPtr_LocateExistingRigs_Private_List_1_CinemachineVirtualCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663530 /*0x060000EA*/);
    CinemachineFreeLook.NativeMethodInfoPtr_UpdateXAxisHeading_Private_Single_CinemachineOrbitalTransposer_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663531 /*0x060000EB*/);
    CinemachineFreeLook.NativeMethodInfoPtr_PushSettingsToRigs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663532 /*0x060000EC*/);
    CinemachineFreeLook.NativeMethodInfoPtr_GetYAxisValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663533 /*0x060000ED*/);
    CinemachineFreeLook.NativeMethodInfoPtr_CalculateNewState_Private_CameraState_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663534 /*0x060000EE*/);
    CinemachineFreeLook.NativeMethodInfoPtr_GetLocalPositionForCameraFromInput_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663535 /*0x060000EF*/);
    CinemachineFreeLook.NativeMethodInfoPtr_UpdateCachedSpline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663536 /*0x060000F0*/);
    CinemachineFreeLook.NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663537 /*0x060000F1*/);
    CinemachineFreeLook.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663538 /*0x060000F2*/);
    CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663539 /*0x060000F3*/);
    CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass47_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663540 /*0x060000F4*/);
    CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Single_byref___c__DisplayClass47_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663541 /*0x060000F5*/);
    CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Void_Single_byref___c__DisplayClass47_0_byref___c__DisplayClass47_1_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, 100663542 /*0x060000F6*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938868, XrefRangeEnd = 938878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938878, XrefRangeEnd = 938879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineVirtualCamera GetRig(int i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_GetRig_Public_CinemachineVirtualCamera_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineVirtualCamera) null : Il2CppObjectPool.Get<CinemachineVirtualCamera>(num3);
  }

  public unsafe bool RigsAreCreated
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_get_RigsAreCreated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Il2CppStringArray RigNames
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 938888, RefRangeEnd = 938895, XrefRangeStart = 938879, XrefRangeEnd = 938888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_get_RigNames_Public_Static_get_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938895, XrefRangeEnd = 938901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938901, XrefRangeEnd = 938906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateInputAxisProvider()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938906, XrefRangeEnd = 938921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnTransformChildrenChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938921, XrefRangeEnd = 938923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe bool PreviousStateIsValid
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_get_PreviousStateIsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938923, XrefRangeEnd = 938927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_set_PreviousStateIsValid_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938927, XrefRangeEnd = 938928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dominantChildOnly;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938928, XrefRangeEnd = 938931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938931, XrefRangeEnd = 938937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938937, XrefRangeEnd = 938972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938972, XrefRangeEnd = 938999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RequiresUserInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_RequiresUserInput_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939023, RefRangeEnd = 939024, XrefRangeStart = 938999, XrefRangeEnd = 939023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cameraPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_GetYAxisClosestValue_Private_Single_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939032, RefRangeEnd = 939033, XrefRangeStart = 939024, XrefRangeEnd = 939032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float SteepestDescent(Vector3 cameraOffset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &cameraOffset
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_SteepestDescent_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void InvalidateRigCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_InvalidateRigCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939100, RefRangeEnd = 939101, XrefRangeStart = 939033, XrefRangeEnd = 939100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroyRigs()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_DestroyRigs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939101, XrefRangeEnd = 939189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<CinemachineVirtualCamera> CreateRigs(
    Il2CppReferenceArray<CinemachineVirtualCamera> copyFrom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyFrom)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_CreateRigs_Private_Il2CppReferenceArray_1_CinemachineVirtualCamera_Il2CppReferenceArray_1_CinemachineVirtualCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCamera>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCamera>>(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 939194, RefRangeEnd = 939199, XrefRangeStart = 939189, XrefRangeEnd = 939194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool UpdateRigCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_UpdateRigCache_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939199, XrefRangeEnd = 939256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<CinemachineVirtualCamera> LocateExistingRigs(bool forceOrbital)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &forceOrbital
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_LocateExistingRigs_Private_List_1_CinemachineVirtualCamera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<CinemachineVirtualCamera>) null : Il2CppObjectPool.Get<List<CinemachineVirtualCamera>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939256, XrefRangeEnd = 939268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float UpdateXAxisHeading(
    CinemachineOrbitalTransposer orbital,
    float deltaTime,
    Vector3 up)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) orbital);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_UpdateXAxisHeading_Private_Single_CinemachineOrbitalTransposer_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 939283, RefRangeEnd = 939285, XrefRangeStart = 939268, XrefRangeEnd = 939283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PushSettingsToRigs()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_PushSettingsToRigs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe float GetYAxisValue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_GetYAxisValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939285, XrefRangeEnd = 939292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_CalculateNewState_Private_CameraState_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CameraState(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 939294, RefRangeEnd = 939296, XrefRangeStart = 939292, XrefRangeEnd = 939294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetLocalPositionForCameraFromInput(float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &t
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_GetLocalPositionForCameraFromInput_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 939315, RefRangeEnd = 939318, XrefRangeStart = 939296, XrefRangeEnd = 939315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCachedSpline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_UpdateCachedSpline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939318, XrefRangeEnd = 939326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFreeLook.NativeMethodInfoPtr_OnBeforeSerialize_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939326, XrefRangeEnd = 939350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineFreeLook()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 939354, RefRangeEnd = 939366, XrefRangeStart = 939350, XrefRangeEnd = 939354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Method_Private_Single_Single_byref___c__DisplayClass47_0_0(
    float input,
    ref CinemachineFreeLook.__c__DisplayClass47_0 _param2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass47_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939366, XrefRangeEnd = 939368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Method_Private_Single_Single_byref___c__DisplayClass47_0_PDM_0(
    float input,
    ref CinemachineFreeLook.__c__DisplayClass47_0 _param2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass47_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939368, XrefRangeEnd = 939372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Method_Private_Single_byref___c__DisplayClass47_0_PDM_0(
    ref CinemachineFreeLook.__c__DisplayClass47_0 _param1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param1)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Single_byref___c__DisplayClass47_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939372, XrefRangeEnd = 939373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Method_Private_Void_Single_byref___c__DisplayClass47_0_byref___c__DisplayClass47_1_PDM_0(
    float referenceAngle,
    ref CinemachineFreeLook.__c__DisplayClass47_0 _param2,
    ref CinemachineFreeLook.__c__DisplayClass47_1 _param3)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &referenceAngle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param2);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.NativeMethodInfoPtr_Method_Private_Void_Single_byref___c__DisplayClass47_0_byref___c__DisplayClass47_1_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform m_LookAt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LookAt));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LookAt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform m_Follow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Follow));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Follow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_CommonLens
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CommonLens));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CommonLens)) = value;
    }
  }

  public unsafe LensSettings m_Lens
  {
    get
    {
      return *(LensSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Lens));
    }
    [param: In] set
    {
      *(LensSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Lens)) = value;
    }
  }

  public CinemachineVirtualCameraBase.TransitionParams m_Transitions
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Transitions);
      return new CinemachineVirtualCameraBase.TransitionParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Transitions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineVirtualCameraBase.TransitionParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint
  {
    get
    {
      return *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LegacyBlendHint));
    }
    [param: In] set
    {
      *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LegacyBlendHint)) = value;
    }
  }

  public AxisState m_YAxis
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_YAxis);
      return new AxisState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_YAxis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe AxisState.Recentering m_YAxisRecentering
  {
    get
    {
      return *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_YAxisRecentering));
    }
    [param: In] set
    {
      *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_YAxisRecentering)) = value;
    }
  }

  public AxisState m_XAxis
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_XAxis);
      return new AxisState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_XAxis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CinemachineOrbitalTransposer.Heading m_Heading
  {
    get
    {
      return *(CinemachineOrbitalTransposer.Heading*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Heading));
    }
    [param: In] set
    {
      *(CinemachineOrbitalTransposer.Heading*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Heading)) = value;
    }
  }

  public unsafe AxisState.Recentering m_RecenterToTargetHeading
  {
    get
    {
      return *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_RecenterToTargetHeading));
    }
    [param: In] set
    {
      *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_RecenterToTargetHeading)) = value;
    }
  }

  public unsafe CinemachineTransposer.BindingMode m_BindingMode
  {
    get
    {
      return *(CinemachineTransposer.BindingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_BindingMode));
    }
    [param: In] set
    {
      *(CinemachineTransposer.BindingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_BindingMode)) = value;
    }
  }

  public unsafe float m_SplineCurvature
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_SplineCurvature));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_SplineCurvature)) = value;
    }
  }

  public unsafe Il2CppStructArray<CinemachineFreeLook.Orbit> m_Orbits
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Orbits));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachineFreeLook.Orbit>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachineFreeLook.Orbit>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Orbits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_LegacyHeadingBias
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LegacyHeadingBias));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LegacyHeadingBias)) = value;
    }
  }

  public unsafe bool mUseLegacyRigDefinitions
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mUseLegacyRigDefinitions));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mUseLegacyRigDefinitions)) = value;
    }
  }

  public unsafe bool mIsDestroyed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mIsDestroyed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mIsDestroyed)) = value;
    }
  }

  public CameraState m_State
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_State);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCamera> m_Rigs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Rigs));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCamera>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCamera>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_Rigs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineOrbitalTransposer> mOrbitals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mOrbitals));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineOrbitalTransposer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineOrbitalTransposer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mOrbitals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineBlend mBlendA
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mBlendA));
      return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mBlendA), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineBlend mBlendB
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mBlendB));
      return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_mBlendB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemachineFreeLook.CreateRigDelegate CreateRigOverride
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineFreeLook.NativeFieldInfoPtr_CreateRigOverride, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineFreeLook.CreateRigDelegate) null : Il2CppObjectPool.Get<CinemachineFreeLook.CreateRigDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineFreeLook.NativeFieldInfoPtr_CreateRigOverride, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineFreeLook.NativeFieldInfoPtr_DestroyRigOverride, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineFreeLook.DestroyRigDelegate) null : Il2CppObjectPool.Get<CinemachineFreeLook.DestroyRigDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineFreeLook.NativeFieldInfoPtr_DestroyRigOverride, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_CachedXAxisHeading
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedXAxisHeading));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedXAxisHeading)) = value;
    }
  }

  public unsafe float m_LastHeadingUpdateFrame
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LastHeadingUpdateFrame));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_LastHeadingUpdateFrame)) = value;
    }
  }

  public unsafe Il2CppStructArray<CinemachineFreeLook.Orbit> m_CachedOrbits
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedOrbits));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachineFreeLook.Orbit>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachineFreeLook.Orbit>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedOrbits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_CachedTension
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedTension));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedTension)) = value;
    }
  }

  public unsafe Il2CppStructArray<Vector4> m_CachedKnots
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedKnots));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedKnots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector4> m_CachedCtrl1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedCtrl1));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedCtrl1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector4> m_CachedCtrl2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedCtrl2));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.NativeFieldInfoPtr_m_CachedCtrl2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Orbit
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Radius;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
    [FieldOffset(0)]
    public float m_Height;
    [FieldOffset(4)]
    public float m_Radius;

    static Orbit()
    {
      Il2CppClassPointerStore<CinemachineFreeLook.Orbit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (Orbit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFreeLook.Orbit>.NativeClassPtr);
      CinemachineFreeLook.Orbit.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook.Orbit>.NativeClassPtr, nameof (m_Height));
      CinemachineFreeLook.Orbit.NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook.Orbit>.NativeClassPtr, nameof (m_Radius));
      CinemachineFreeLook.Orbit.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook.Orbit>.NativeClassPtr, 100663543 /*0x060000F7*/);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 21792, RefRangeEnd = 21797, XrefRangeStart = 21792, XrefRangeEnd = 21797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Orbit(float h, float r)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &h;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.Orbit.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineFreeLook.Orbit>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class CreateRigDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_CinemachineVirtualCamera_CinemachineFreeLook_String_CinemachineVirtualCamera_0;

    static CreateRigDelegate()
    {
      Il2CppClassPointerStore<CinemachineFreeLook.CreateRigDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (CreateRigDelegate));
      CinemachineFreeLook.CreateRigDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook.CreateRigDelegate>.NativeClassPtr, 100663544 /*0x060000F8*/);
      CinemachineFreeLook.CreateRigDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_CinemachineVirtualCamera_CinemachineFreeLook_String_CinemachineVirtualCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook.CreateRigDelegate>.NativeClassPtr, 100663545 /*0x060000F9*/);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 938866, RefRangeEnd = 938868, XrefRangeStart = 938857, XrefRangeEnd = 938866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateRigDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFreeLook.CreateRigDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.CreateRigDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe CinemachineVirtualCamera Invoke(
      CinemachineFreeLook vcam,
      string name,
      CinemachineVirtualCamera copyFrom)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyFrom);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.CreateRigDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_CinemachineVirtualCamera_CinemachineFreeLook_String_CinemachineVirtualCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineVirtualCamera) null : Il2CppObjectPool.Get<CinemachineVirtualCamera>(num3);
    }

    public static implicit operator CinemachineFreeLook.CreateRigDelegate(
      [In] System.Func<CinemachineFreeLook, string, CinemachineVirtualCamera, CinemachineVirtualCamera> obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineFreeLook.CreateRigDelegate>((System.Delegate) obj0);
    }

    public static CinemachineFreeLook.CreateRigDelegate operator +(
      [In] CinemachineFreeLook.CreateRigDelegate obj0,
      [In] CinemachineFreeLook.CreateRigDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineFreeLook.CreateRigDelegate>();
    }

    public static CinemachineFreeLook.CreateRigDelegate operator -(
      [In] CinemachineFreeLook.CreateRigDelegate obj0,
      [In] CinemachineFreeLook.CreateRigDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineFreeLook.CreateRigDelegate) @delegate : @delegate.Cast<CinemachineFreeLook.CreateRigDelegate>();
    }
  }

  public sealed class DestroyRigDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameObject_0;

    static DestroyRigDelegate()
    {
      Il2CppClassPointerStore<CinemachineFreeLook.DestroyRigDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, nameof (DestroyRigDelegate));
      CinemachineFreeLook.DestroyRigDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook.DestroyRigDelegate>.NativeClassPtr, 100663546 /*0x060000FA*/);
      CinemachineFreeLook.DestroyRigDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFreeLook.DestroyRigDelegate>.NativeClassPtr, 100663547 /*0x060000FB*/);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 416874, RefRangeEnd = 416875, XrefRangeStart = 416874, XrefRangeEnd = 416875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyRigDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFreeLook.DestroyRigDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.DestroyRigDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(GameObject rig)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rig)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFreeLook.DestroyRigDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator CinemachineFreeLook.DestroyRigDelegate([In] System.Action<GameObject> obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineFreeLook.DestroyRigDelegate>((System.Delegate) obj0);
    }

    public static CinemachineFreeLook.DestroyRigDelegate operator +(
      [In] CinemachineFreeLook.DestroyRigDelegate obj0,
      [In] CinemachineFreeLook.DestroyRigDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineFreeLook.DestroyRigDelegate>();
    }

    public static CinemachineFreeLook.DestroyRigDelegate operator -(
      [In] CinemachineFreeLook.DestroyRigDelegate obj0,
      [In] CinemachineFreeLook.DestroyRigDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineFreeLook.DestroyRigDelegate) @delegate : @delegate.Cast<CinemachineFreeLook.DestroyRigDelegate>();
    }
  }

  [ObfuscatedName("Cinemachine.CinemachineFreeLook+<>c__DisplayClass47_0")]
  public sealed class __c__DisplayClass47_0 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraOffset;

    static __c__DisplayClass47_0()
    {
      Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, "<>c__DisplayClass47_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_0>.NativeClassPtr);
      CinemachineFreeLook.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_0>.NativeClassPtr, "<>4__this");
      CinemachineFreeLook.__c__DisplayClass47_0.NativeFieldInfoPtr_cameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_0>.NativeClassPtr, nameof (cameraOffset));
    }

    public __c__DisplayClass47_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass47_0()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_0>.NativeClassPtr))
    {
    }

    public unsafe CinemachineFreeLook __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CinemachineFreeLook) null : Il2CppObjectPool.Get<CinemachineFreeLook>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 cameraOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.__c__DisplayClass47_0.NativeFieldInfoPtr_cameraOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFreeLook.__c__DisplayClass47_0.NativeFieldInfoPtr_cameraOffset)) = value;
      }
    }
  }

  [ObfuscatedName("Cinemachine.CinemachineFreeLook+<>c__DisplayClass47_1")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass47_1
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_bestAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_best;
    [FieldOffset(0)]
    public float bestAngle;
    [FieldOffset(4)]
    public float best;

    static __c__DisplayClass47_1()
    {
      Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineFreeLook>.NativeClassPtr, "<>c__DisplayClass47_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_1>.NativeClassPtr);
      CinemachineFreeLook.__c__DisplayClass47_1.NativeFieldInfoPtr_bestAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_1>.NativeClassPtr, nameof (bestAngle));
      CinemachineFreeLook.__c__DisplayClass47_1.NativeFieldInfoPtr_best = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_1>.NativeClassPtr, nameof (best));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineFreeLook.__c__DisplayClass47_1>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
