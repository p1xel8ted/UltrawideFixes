// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineTransposer
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineTransposer(IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_BindingMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_FollowOffset;
  private static readonly IntPtr NativeFieldInfoPtr_m_XDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_YDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_ZDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_AngularDampingMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_PitchDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_YawDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_RollDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_AngularDamping;
  private static readonly IntPtr NativeFieldInfoPtr__HideOffsetInInspector_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_m_PreviousTargetPosition;
  private static readonly IntPtr NativeFieldInfoPtr_m_PreviousReferenceOrientation;
  private static readonly IntPtr NativeFieldInfoPtr_m_targetOrientationOnAssign;
  private static readonly IntPtr NativeFieldInfoPtr_m_PreviousOffset;
  private static readonly IntPtr NativeFieldInfoPtr_m_previousTarget;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_HideOffsetInInspector_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_HideOffsetInInspector_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveOffset_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_InitPrevFrameStateInfo_Protected_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrackTarget_Protected_Void_Single_Vector3_Vector3_byref_Vector3_byref_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetOffsetForMinimumTargetDistance_Protected_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Damping_Protected_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AngularDamping_Protected_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Public_Virtual_New_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetReferenceOrientation_Public_Quaternion_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineTransposer()
  {
    Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineTransposer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr);
    CinemachineTransposer.NativeFieldInfoPtr_m_BindingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_BindingMode));
    CinemachineTransposer.NativeFieldInfoPtr_m_FollowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_FollowOffset));
    CinemachineTransposer.NativeFieldInfoPtr_m_XDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_XDamping));
    CinemachineTransposer.NativeFieldInfoPtr_m_YDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_YDamping));
    CinemachineTransposer.NativeFieldInfoPtr_m_ZDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_ZDamping));
    CinemachineTransposer.NativeFieldInfoPtr_m_AngularDampingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_AngularDampingMode));
    CinemachineTransposer.NativeFieldInfoPtr_m_PitchDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_PitchDamping));
    CinemachineTransposer.NativeFieldInfoPtr_m_YawDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_YawDamping));
    CinemachineTransposer.NativeFieldInfoPtr_m_RollDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_RollDamping));
    CinemachineTransposer.NativeFieldInfoPtr_m_AngularDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_AngularDamping));
    CinemachineTransposer.NativeFieldInfoPtr__HideOffsetInInspector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, "<HideOffsetInInspector>k__BackingField");
    CinemachineTransposer.NativeFieldInfoPtr_m_PreviousTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_PreviousTargetPosition));
    CinemachineTransposer.NativeFieldInfoPtr_m_PreviousReferenceOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_PreviousReferenceOrientation));
    CinemachineTransposer.NativeFieldInfoPtr_m_targetOrientationOnAssign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_targetOrientationOnAssign));
    CinemachineTransposer.NativeFieldInfoPtr_m_PreviousOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_PreviousOffset));
    CinemachineTransposer.NativeFieldInfoPtr_m_previousTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, nameof (m_previousTarget));
    CinemachineTransposer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663844);
    CinemachineTransposer.NativeMethodInfoPtr_get_HideOffsetInInspector_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663845);
    CinemachineTransposer.NativeMethodInfoPtr_set_HideOffsetInInspector_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663846);
    CinemachineTransposer.NativeMethodInfoPtr_get_EffectiveOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663847);
    CinemachineTransposer.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663848);
    CinemachineTransposer.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663849);
    CinemachineTransposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663850);
    CinemachineTransposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663851);
    CinemachineTransposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663852);
    CinemachineTransposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663853);
    CinemachineTransposer.NativeMethodInfoPtr_InitPrevFrameStateInfo_Protected_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663854);
    CinemachineTransposer.NativeMethodInfoPtr_TrackTarget_Protected_Void_Single_Vector3_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663855);
    CinemachineTransposer.NativeMethodInfoPtr_GetOffsetForMinimumTargetDistance_Protected_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663856 /*0x06000230*/);
    CinemachineTransposer.NativeMethodInfoPtr_get_Damping_Protected_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663857);
    CinemachineTransposer.NativeMethodInfoPtr_get_AngularDamping_Protected_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663858);
    CinemachineTransposer.NativeMethodInfoPtr_GetTargetCameraPosition_Public_Virtual_New_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663859);
    CinemachineTransposer.NativeMethodInfoPtr_GetReferenceOrientation_Public_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663860);
    CinemachineTransposer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr, 100663861);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942026, RefRangeEnd = 942027, XrefRangeStart = 942026, XrefRangeEnd = 942026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool HideOffsetInInspector
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_get_HideOffsetInInspector_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_set_HideOffsetInInspector_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 EffectiveOffset
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 942027, RefRangeEnd = 942030, XrefRangeStart = 942027, XrefRangeEnd = 942027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_get_EffectiveOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942030, XrefRangeEnd = 942032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942032, XrefRangeEnd = 942034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942034, XrefRangeEnd = 942045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942050, RefRangeEnd = 942051, XrefRangeStart = 942045, XrefRangeEnd = 942050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positionDelta;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942056, RefRangeEnd = 942057, XrefRangeStart = 942051, XrefRangeEnd = 942056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rot;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 942086, RefRangeEnd = 942088, XrefRangeStart = 942057, XrefRangeEnd = 942086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_InitPrevFrameStateInfo_Protected_Void_byref_CameraState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 942132, RefRangeEnd = 942134, XrefRangeStart = 942088, XrefRangeEnd = 942132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TrackTarget(
    float deltaTime,
    Vector3 up,
    Vector3 desiredCameraOffset,
    out Vector3 outTargetPosition,
    out Quaternion outTargetOrient)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &deltaTime;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &up;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &desiredCameraOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref outTargetPosition;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) ref outTargetOrient;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_TrackTarget_Protected_Void_Single_Vector3_Vector3_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 942145, RefRangeEnd = 942147, XrefRangeStart = 942134, XrefRangeEnd = 942145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetOffsetForMinimumTargetDistance(
    Vector3 dampedTargetPos,
    Vector3 cameraOffset,
    Vector3 cameraFwd,
    Vector3 up,
    Vector3 actualTargetPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &dampedTargetPos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cameraOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &cameraFwd;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &up;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &actualTargetPos;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_GetOffsetForMinimumTargetDistance_Protected_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Vector3 Damping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_get_Damping_Protected_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 AngularDamping
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 942147, RefRangeEnd = 942148, XrefRangeStart = 942147, XrefRangeEnd = 942147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_get_AngularDamping_Protected_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942148, XrefRangeEnd = 942154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Vector3 GetTargetCameraPosition(Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &worldUp
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTransposer.NativeMethodInfoPtr_GetTargetCameraPosition_Public_Virtual_New_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 942175, RefRangeEnd = 942182, XrefRangeStart = 942154, XrefRangeEnd = 942175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Quaternion GetReferenceOrientation(Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &worldUp
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr_GetReferenceOrientation_Public_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942191, RefRangeEnd = 942192, XrefRangeStart = 942182, XrefRangeEnd = 942191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineTransposer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTransposer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTransposer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineTransposer.BindingMode m_BindingMode
  {
    get
    {
      return *(CinemachineTransposer.BindingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_BindingMode));
    }
    [param: In] set
    {
      *(CinemachineTransposer.BindingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_BindingMode)) = value;
    }
  }

  public unsafe Vector3 m_FollowOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_FollowOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_FollowOffset)) = value;
    }
  }

  public unsafe float m_XDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_XDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_XDamping)) = value;
    }
  }

  public unsafe float m_YDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_YDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_YDamping)) = value;
    }
  }

  public unsafe float m_ZDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_ZDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_ZDamping)) = value;
    }
  }

  public unsafe CinemachineTransposer.AngularDampingMode m_AngularDampingMode
  {
    get
    {
      return *(CinemachineTransposer.AngularDampingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_AngularDampingMode));
    }
    [param: In] set
    {
      *(CinemachineTransposer.AngularDampingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_AngularDampingMode)) = value;
    }
  }

  public unsafe float m_PitchDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PitchDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PitchDamping)) = value;
    }
  }

  public unsafe float m_YawDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_YawDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_YawDamping)) = value;
    }
  }

  public unsafe float m_RollDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_RollDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_RollDamping)) = value;
    }
  }

  public unsafe float m_AngularDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_AngularDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_AngularDamping)) = value;
    }
  }

  public unsafe bool _HideOffsetInInspector_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr__HideOffsetInInspector_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr__HideOffsetInInspector_k__BackingField)) = value;
    }
  }

  public unsafe Vector3 m_PreviousTargetPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PreviousTargetPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PreviousTargetPosition)) = value;
    }
  }

  public unsafe Quaternion m_PreviousReferenceOrientation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PreviousReferenceOrientation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PreviousReferenceOrientation)) = value;
    }
  }

  public unsafe Quaternion m_targetOrientationOnAssign
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_targetOrientationOnAssign));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_targetOrientationOnAssign)) = value;
    }
  }

  public unsafe Vector3 m_PreviousOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PreviousOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_PreviousOffset)) = value;
    }
  }

  public unsafe Transform m_previousTarget
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_previousTarget));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTransposer.NativeFieldInfoPtr_m_previousTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum BindingMode
  {
    LockToTargetOnAssign,
    LockToTargetWithWorldUp,
    LockToTargetNoRoll,
    LockToTarget,
    WorldSpace,
    SimpleFollowWithWorldUp,
  }

  public enum AngularDampingMode
  {
    Euler,
    Quaternion,
  }
}
