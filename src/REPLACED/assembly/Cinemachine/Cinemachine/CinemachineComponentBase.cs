// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineComponentBase
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

public class CinemachineComponentBase(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Epsilon;
  private static readonly IntPtr NativeFieldInfoPtr_m_vcamOwner;
  private static readonly IntPtr NativeMethodInfoPtr_get_VirtualCamera_Public_get_CinemachineVirtualCameraBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FollowTarget_Public_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LookAtTarget_Public_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AbstractFollowTargetGroup_Public_get_ICinemachineTargetGroup_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FollowTargetGroup_Public_get_CinemachineTargetGroup_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FollowTargetPosition_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FollowTargetRotation_Public_get_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AbstractLookAtTargetGroup_Public_get_ICinemachineTargetGroup_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LookAtTargetGroup_Public_get_CinemachineTargetGroup_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LookAtTargetPosition_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LookAtTargetRotation_Public_get_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_VcamState_Public_get_CameraState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_New_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Stage_Public_Abstract_Virtual_New_get_Stage_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BodyAppliesAfterAim_Public_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Abstract_Virtual_New_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_New_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_New_Void_Transform_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_New_Void_Vector3_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static CinemachineComponentBase()
  {
    Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineComponentBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr);
    CinemachineComponentBase.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, nameof (Epsilon));
    CinemachineComponentBase.NativeFieldInfoPtr_m_vcamOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, nameof (m_vcamOwner));
    CinemachineComponentBase.NativeMethodInfoPtr_get_VirtualCamera_Public_get_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663939);
    CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTarget_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663940);
    CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTarget_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663941);
    CinemachineComponentBase.NativeMethodInfoPtr_get_AbstractFollowTargetGroup_Public_get_ICinemachineTargetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663942);
    CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTargetGroup_Public_get_CinemachineTargetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663943);
    CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTargetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663944);
    CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTargetRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663945);
    CinemachineComponentBase.NativeMethodInfoPtr_get_AbstractLookAtTargetGroup_Public_get_ICinemachineTargetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663946);
    CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTargetGroup_Public_get_CinemachineTargetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663947);
    CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTargetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663948);
    CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTargetRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663949);
    CinemachineComponentBase.NativeMethodInfoPtr_get_VcamState_Public_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663950);
    CinemachineComponentBase.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663951);
    CinemachineComponentBase.NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_New_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663952 /*0x06000290*/);
    CinemachineComponentBase.NativeMethodInfoPtr_get_Stage_Public_Abstract_Virtual_New_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663953);
    CinemachineComponentBase.NativeMethodInfoPtr_get_BodyAppliesAfterAim_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663954);
    CinemachineComponentBase.NativeMethodInfoPtr_MutateCameraState_Public_Abstract_Virtual_New_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663955);
    CinemachineComponentBase.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_New_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663956);
    CinemachineComponentBase.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_New_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663957);
    CinemachineComponentBase.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_New_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663958);
    CinemachineComponentBase.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663959);
    CinemachineComponentBase.NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663960);
    CinemachineComponentBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr, 100663961);
  }

  public unsafe CinemachineVirtualCameraBase VirtualCamera
  {
    [CallerCount(69), CachedScanResults(RefRangeStart = 942827, RefRangeEnd = 942896, XrefRangeStart = 942808, XrefRangeEnd = 942827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_VirtualCamera_Public_get_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num3);
    }
  }

  public unsafe Transform FollowTarget
  {
    [CallerCount(18), CachedScanResults(RefRangeStart = 942901, RefRangeEnd = 942919, XrefRangeStart = 942896, XrefRangeEnd = 942901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTarget_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public unsafe Transform LookAtTarget
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 942924, RefRangeEnd = 942929, XrefRangeStart = 942919, XrefRangeEnd = 942924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTarget_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public unsafe ICinemachineTargetGroup AbstractFollowTargetGroup
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 942934, RefRangeEnd = 942935, XrefRangeStart = 942929, XrefRangeEnd = 942934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_AbstractFollowTargetGroup_Public_get_ICinemachineTargetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ICinemachineTargetGroup) null : Il2CppObjectPool.Get<ICinemachineTargetGroup>(num3);
    }
  }

  public unsafe CinemachineTargetGroup FollowTargetGroup
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942935, XrefRangeEnd = 942942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTargetGroup_Public_get_CinemachineTargetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (CinemachineTargetGroup) null : Il2CppObjectPool.Get<CinemachineTargetGroup>(num3);
    }
  }

  public unsafe Vector3 FollowTargetPosition
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 942956, RefRangeEnd = 942969, XrefRangeStart = 942942, XrefRangeEnd = 942956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTargetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Quaternion FollowTargetRotation
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 942983, RefRangeEnd = 942991, XrefRangeStart = 942969, XrefRangeEnd = 942983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_FollowTargetRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ICinemachineTargetGroup AbstractLookAtTargetGroup
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 942992, RefRangeEnd = 942993, XrefRangeStart = 942991, XrefRangeEnd = 942992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_AbstractLookAtTargetGroup_Public_get_ICinemachineTargetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ICinemachineTargetGroup) null : Il2CppObjectPool.Get<ICinemachineTargetGroup>(num3);
    }
  }

  public unsafe CinemachineTargetGroup LookAtTargetGroup
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942993, XrefRangeEnd = 942996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTargetGroup_Public_get_CinemachineTargetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (CinemachineTargetGroup) null : Il2CppObjectPool.Get<CinemachineTargetGroup>(num3);
    }
  }

  public unsafe Vector3 LookAtTargetPosition
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 943010, RefRangeEnd = 943011, XrefRangeStart = 942996, XrefRangeEnd = 943010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTargetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Quaternion LookAtTargetRotation
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 943025, RefRangeEnd = 943026, XrefRangeStart = 943011, XrefRangeEnd = 943025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_LookAtTargetRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe CameraState VcamState
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 943037, RefRangeEnd = 943046, XrefRangeStart = 943026, XrefRangeEnd = 943037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr_get_VcamState_Public_get_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
  }

  public virtual unsafe bool IsValid
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_New_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_get_Stage_Public_Abstract_Virtual_New_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe bool BodyAppliesAfterAim
  {
    [CallerCount(194), CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_get_BodyAppliesAfterAim_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_MutateCameraState_Public_Abstract_Virtual_New_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(194)]
  [CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool OnTransitionFromCamera(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime,
    ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &worldUp;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) transitionParams);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_New_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positionDelta;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_New_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rot;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_New_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe bool RequiresUserInput
  {
    [CallerCount(194), CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComponentBase.NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineComponentBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineComponentBase>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineComponentBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float Epsilon
  {
    get
    {
      float epsilon;
      IL2CPP.il2cpp_field_static_get_value(CinemachineComponentBase.NativeFieldInfoPtr_Epsilon, (void*) &epsilon);
      return epsilon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineComponentBase.NativeFieldInfoPtr_Epsilon, (void*) &value);
    }
  }

  public unsafe CinemachineVirtualCameraBase m_vcamOwner
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComponentBase.NativeFieldInfoPtr_m_vcamOwner));
      return num == IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComponentBase.NativeFieldInfoPtr_m_vcamOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
