// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineOrbitalTransposer
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine.Utility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineOrbitalTransposer(System.IntPtr pointer) : CinemachineTransposer(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Heading;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RecenterToTargetHeading;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_XAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyHeightOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyHeadingBias;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HeadingIsSlave;
  private static readonly System.IntPtr NativeFieldInfoPtr_HeadingUpdater;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastTargetPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_mHeadingTracker;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetRigidBody;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastCameraPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastHeading;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHeading_Public_Single_Single_Vector3_byref_AxisState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHeading_Public_Single_Single_Vector3_byref_AxisState_byref_Recentering_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisClosestValue_Public_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Public_Virtual_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetHeading_Private_Single_Single_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineOrbitalTransposer()
  {
    Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineOrbitalTransposer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr);
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_Heading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_Heading));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_RecenterToTargetHeading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_RecenterToTargetHeading));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_XAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_XAxis));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_LegacyRadius));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_LegacyHeightOffset));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyHeadingBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_LegacyHeadingBias));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_HeadingIsSlave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_HeadingIsSlave));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_HeadingUpdater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (HeadingUpdater));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_LastTargetPosition));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_mHeadingTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (mHeadingTracker));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_TargetRigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_TargetRigidBody));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_PreviousTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_PreviousTarget));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_LastCameraPosition));
    CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastHeading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (m_LastHeading));
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663797);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_UpdateHeading_Public_Single_Single_Vector3_byref_AxisState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663798);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_UpdateHeading_Public_Single_Single_Vector3_byref_AxisState_byref_Recentering_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663799);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663800);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663801);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663802);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663803);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663804);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_GetAxisClosestValue_Public_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663805);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663806);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_GetTargetCameraPosition_Public_Virtual_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663807);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663808 /*0x06000200*/);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr_GetTargetHeading_Private_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663809 /*0x06000201*/);
    CinemachineOrbitalTransposer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, 100663810 /*0x06000202*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941612, XrefRangeEnd = 941616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941616, XrefRangeEnd = 941617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) axis);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.NativeMethodInfoPtr_UpdateHeading_Public_Single_Single_Vector3_byref_AxisState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 941626, RefRangeEnd = 941629, XrefRangeStart = 941617, XrefRangeEnd = 941626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float UpdateHeading(
    float deltaTime,
    Vector3 up,
    ref AxisState axis,
    ref AxisState.Recentering recentering,
    bool isLive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) axis);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref recentering;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isLive;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.NativeMethodInfoPtr_UpdateHeading_Public_Single_Single_Vector3_byref_AxisState_byref_Recentering_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941629, XrefRangeEnd = 941640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941640, XrefRangeEnd = 941649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateInputAxisProvider()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941649, XrefRangeEnd = 941655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941655, XrefRangeEnd = 941659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineOrbitalTransposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941659, XrefRangeEnd = 941672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool OnTransitionFromCamera(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime,
    ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) transitionParams);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineOrbitalTransposer.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 941692, RefRangeEnd = 941694, XrefRangeStart = 941672, XrefRangeEnd = 941692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAxisClosestValue(Vector3 cameraPos, Vector3 up)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cameraPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.NativeMethodInfoPtr_GetAxisClosestValue_Public_Single_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941694, XrefRangeEnd = 941739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineOrbitalTransposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941739, XrefRangeEnd = 941748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetTargetCameraPosition(Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &worldUp
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineOrbitalTransposer.NativeMethodInfoPtr_GetTargetCameraPosition_Public_Virtual_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public override unsafe bool RequiresUserInput
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineOrbitalTransposer.NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941785, RefRangeEnd = 941786, XrefRangeStart = 941748, XrefRangeEnd = 941785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetTargetHeading(float currentHeading, Quaternion targetOrientation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &currentHeading;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetOrientation;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.NativeMethodInfoPtr_GetTargetHeading_Private_Single_Single_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941786, XrefRangeEnd = 941816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineOrbitalTransposer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineOrbitalTransposer.Heading m_Heading
  {
    get
    {
      return *(CinemachineOrbitalTransposer.Heading*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_Heading));
    }
    [param: In] set
    {
      *(CinemachineOrbitalTransposer.Heading*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_Heading)) = value;
    }
  }

  public unsafe AxisState.Recentering m_RecenterToTargetHeading
  {
    get
    {
      return *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_RecenterToTargetHeading));
    }
    [param: In] set
    {
      *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_RecenterToTargetHeading)) = value;
    }
  }

  public AxisState m_XAxis
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_XAxis);
      return new AxisState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_XAxis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe float m_LegacyRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyRadius)) = value;
    }
  }

  public unsafe float m_LegacyHeightOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyHeightOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyHeightOffset)) = value;
    }
  }

  public unsafe float m_LegacyHeadingBias
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyHeadingBias));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LegacyHeadingBias)) = value;
    }
  }

  public unsafe bool m_HeadingIsSlave
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_HeadingIsSlave));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_HeadingIsSlave)) = value;
    }
  }

  public unsafe CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_HeadingUpdater));
      return num == System.IntPtr.Zero ? (CinemachineOrbitalTransposer.UpdateHeadingDelegate) null : Il2CppObjectPool.Get<CinemachineOrbitalTransposer.UpdateHeadingDelegate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_HeadingUpdater), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 m_LastTargetPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastTargetPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastTargetPosition)) = value;
    }
  }

  public unsafe HeadingTracker mHeadingTracker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_mHeadingTracker));
      return num == System.IntPtr.Zero ? (HeadingTracker) null : Il2CppObjectPool.Get<HeadingTracker>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_mHeadingTracker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Rigidbody m_TargetRigidBody
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_TargetRigidBody));
      return num == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_TargetRigidBody), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform m_PreviousTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_PreviousTarget));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_PreviousTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 m_LastCameraPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastCameraPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastCameraPosition)) = value;
    }
  }

  public unsafe float m_LastHeading
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastHeading));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineOrbitalTransposer.NativeFieldInfoPtr_m_LastHeading)) = value;
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Heading
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Definition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VelocityFilterStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Bias;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HeadingDefinition_Int32_Single_0;
    [FieldOffset(0)]
    public CinemachineOrbitalTransposer.Heading.HeadingDefinition m_Definition;
    [FieldOffset(4)]
    public int m_VelocityFilterStrength;
    [FieldOffset(8)]
    public float m_Bias;

    static Heading()
    {
      Il2CppClassPointerStore<CinemachineOrbitalTransposer.Heading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (Heading));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineOrbitalTransposer.Heading>.NativeClassPtr);
      CinemachineOrbitalTransposer.Heading.NativeFieldInfoPtr_m_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer.Heading>.NativeClassPtr, nameof (m_Definition));
      CinemachineOrbitalTransposer.Heading.NativeFieldInfoPtr_m_VelocityFilterStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer.Heading>.NativeClassPtr, nameof (m_VelocityFilterStrength));
      CinemachineOrbitalTransposer.Heading.NativeFieldInfoPtr_m_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer.Heading>.NativeClassPtr, nameof (m_Bias));
      CinemachineOrbitalTransposer.Heading.NativeMethodInfoPtr__ctor_Public_Void_HeadingDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer.Heading>.NativeClassPtr, 100663811 /*0x06000203*/);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 159369, RefRangeEnd = 159373, XrefRangeStart = 159369, XrefRangeEnd = 159373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Heading(
      CinemachineOrbitalTransposer.Heading.HeadingDefinition def,
      int filterStrength,
      float bias)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &def;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &filterStrength;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bias;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.Heading.NativeMethodInfoPtr__ctor_Public_Void_HeadingDefinition_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineOrbitalTransposer.Heading>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum HeadingDefinition
    {
      PositionDelta,
      Velocity,
      TargetForward,
      WorldForward,
    }
  }

  public sealed class UpdateHeadingDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_CinemachineOrbitalTransposer_Single_Vector3_0;

    static UpdateHeadingDelegate()
    {
      Il2CppClassPointerStore<CinemachineOrbitalTransposer.UpdateHeadingDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, nameof (UpdateHeadingDelegate));
      CinemachineOrbitalTransposer.UpdateHeadingDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer.UpdateHeadingDelegate>.NativeClassPtr, 100663812 /*0x06000204*/);
      CinemachineOrbitalTransposer.UpdateHeadingDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_CinemachineOrbitalTransposer_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer.UpdateHeadingDelegate>.NativeClassPtr, 100663813 /*0x06000205*/);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 941604, RefRangeEnd = 941605, XrefRangeStart = 941595, XrefRangeEnd = 941604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateHeadingDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineOrbitalTransposer.UpdateHeadingDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.UpdateHeadingDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe float Invoke(
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.UpdateHeadingDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_CinemachineOrbitalTransposer_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static implicit operator CinemachineOrbitalTransposer.UpdateHeadingDelegate(
      [In] System.Func<CinemachineOrbitalTransposer, float, Vector3, float> obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineOrbitalTransposer.UpdateHeadingDelegate>((System.Delegate) obj0);
    }

    public static CinemachineOrbitalTransposer.UpdateHeadingDelegate operator +(
      [In] CinemachineOrbitalTransposer.UpdateHeadingDelegate obj0,
      [In] CinemachineOrbitalTransposer.UpdateHeadingDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineOrbitalTransposer.UpdateHeadingDelegate>();
    }

    public static CinemachineOrbitalTransposer.UpdateHeadingDelegate operator -(
      [In] CinemachineOrbitalTransposer.UpdateHeadingDelegate obj0,
      [In] CinemachineOrbitalTransposer.UpdateHeadingDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineOrbitalTransposer.UpdateHeadingDelegate) @delegate : @delegate.Cast<CinemachineOrbitalTransposer.UpdateHeadingDelegate>();
    }
  }

  [ObfuscatedName("Cinemachine.CinemachineOrbitalTransposer+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__30_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__30_0_Internal_Single_CinemachineOrbitalTransposer_Single_Vector3_0;

    static __c()
    {
      Il2CppClassPointerStore<CinemachineOrbitalTransposer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineOrbitalTransposer>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineOrbitalTransposer.__c>.NativeClassPtr);
      CinemachineOrbitalTransposer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer.__c>.NativeClassPtr, "<>9");
      CinemachineOrbitalTransposer.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineOrbitalTransposer.__c>.NativeClassPtr, "<>9__30_0");
      CinemachineOrbitalTransposer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer.__c>.NativeClassPtr, 100663815 /*0x06000207*/);
      CinemachineOrbitalTransposer.__c.NativeMethodInfoPtr___ctor_b__30_0_Internal_Single_CinemachineOrbitalTransposer_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineOrbitalTransposer.__c>.NativeClassPtr, 100663816 /*0x06000208*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineOrbitalTransposer.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941605, XrefRangeEnd = 941612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float __ctor_b__30_0(
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineOrbitalTransposer.__c.NativeMethodInfoPtr___ctor_b__30_0_Internal_Single_CinemachineOrbitalTransposer_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CinemachineOrbitalTransposer.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineOrbitalTransposer.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CinemachineOrbitalTransposer.__c) null : Il2CppObjectPool.Get<CinemachineOrbitalTransposer.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineOrbitalTransposer.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe CinemachineOrbitalTransposer.UpdateHeadingDelegate __9__30_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineOrbitalTransposer.__c.NativeFieldInfoPtr___9__30_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CinemachineOrbitalTransposer.UpdateHeadingDelegate) null : Il2CppObjectPool.Get<CinemachineOrbitalTransposer.UpdateHeadingDelegate>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineOrbitalTransposer.__c.NativeFieldInfoPtr___9__30_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
