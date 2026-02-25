// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachinePOV
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachinePOV(IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_RecenterTarget;
  private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAxis;
  private static readonly IntPtr NativeFieldInfoPtr_m_VerticalRecentering;
  private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAxis;
  private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalRecentering;
  private static readonly IntPtr NativeFieldInfoPtr_m_ApplyBeforeBody;
  private static readonly IntPtr NativeFieldInfoPtr_m_PreviousCameraRotation;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRecenterTarget_Public_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_NormalizeAngle_Private_Static_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetAxesForRotation_Private_Void_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachinePOV()
  {
    Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachinePOV));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr);
    CinemachinePOV.NativeFieldInfoPtr_m_RecenterTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, nameof (m_RecenterTarget));
    CinemachinePOV.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, nameof (m_VerticalAxis));
    CinemachinePOV.NativeFieldInfoPtr_m_VerticalRecentering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, nameof (m_VerticalRecentering));
    CinemachinePOV.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, nameof (m_HorizontalAxis));
    CinemachinePOV.NativeFieldInfoPtr_m_HorizontalRecentering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, nameof (m_HorizontalRecentering));
    CinemachinePOV.NativeFieldInfoPtr_m_ApplyBeforeBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, nameof (m_ApplyBeforeBody));
    CinemachinePOV.NativeFieldInfoPtr_m_PreviousCameraRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, nameof (m_PreviousCameraRotation));
    CinemachinePOV.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663817 /*0x06000209*/);
    CinemachinePOV.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663818 /*0x0600020A*/);
    CinemachinePOV.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663819 /*0x0600020B*/);
    CinemachinePOV.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663820 /*0x0600020C*/);
    CinemachinePOV.NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663821 /*0x0600020D*/);
    CinemachinePOV.NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663822 /*0x0600020E*/);
    CinemachinePOV.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663823 /*0x0600020F*/);
    CinemachinePOV.NativeMethodInfoPtr_GetRecenterTarget_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663824 /*0x06000210*/);
    CinemachinePOV.NativeMethodInfoPtr_NormalizeAngle_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663825);
    CinemachinePOV.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663826);
    CinemachinePOV.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663827);
    CinemachinePOV.NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663828);
    CinemachinePOV.NativeMethodInfoPtr_SetAxesForRotation_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663829);
    CinemachinePOV.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr, 100663830);
  }

  public override unsafe bool IsValid
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 106514, RefRangeEnd = 106518, XrefRangeStart = 106514, XrefRangeEnd = 106518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePOV.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 749, RefRangeEnd = 751, XrefRangeStart = 749, XrefRangeEnd = 751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePOV.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941816, XrefRangeEnd = 941820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePOV.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941820, XrefRangeEnd = 941831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePOV.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateInputAxisProvider()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePOV.NativeMethodInfoPtr_UpdateInputAxisProvider_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PrePipelineMutateCameraState(ref CameraState state, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePOV.NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941831, XrefRangeEnd = 941869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePOV.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941878, RefRangeEnd = 941879, XrefRangeStart = 941869, XrefRangeEnd = 941878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2 GetRecenterTarget()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePOV.NativeMethodInfoPtr_GetRecenterTarget_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941879, XrefRangeEnd = 941880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float NormalizeAngle(float angle)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &angle
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePOV.NativeMethodInfoPtr_NormalizeAngle_Private_Static_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941880, XrefRangeEnd = 941881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rot;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePOV.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941881, XrefRangeEnd = 941896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool OnTransitionFromCamera(
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
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePOV.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public override unsafe bool RequiresUserInput
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePOV.NativeMethodInfoPtr_get_RequiresUserInput_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 941923, RefRangeEnd = 941925, XrefRangeStart = 941896, XrefRangeEnd = 941923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetAxesForRotation(Quaternion targetRot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &targetRot
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePOV.NativeMethodInfoPtr_SetAxesForRotation_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941925, XrefRangeEnd = 941934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachinePOV()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachinePOV>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePOV.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachinePOV.RecenterTargetMode m_RecenterTarget
  {
    get
    {
      return *(CinemachinePOV.RecenterTargetMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_RecenterTarget));
    }
    [param: In] set
    {
      *(CinemachinePOV.RecenterTargetMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_RecenterTarget)) = value;
    }
  }

  public AxisState m_VerticalAxis
  {
    get
    {
      IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_VerticalAxis);
      return new AxisState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisState>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe AxisState.Recentering m_VerticalRecentering
  {
    get
    {
      return *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_VerticalRecentering));
    }
    [param: In] set
    {
      *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_VerticalRecentering)) = value;
    }
  }

  public AxisState m_HorizontalAxis
  {
    get
    {
      IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_HorizontalAxis);
      return new AxisState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisState>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe AxisState.Recentering m_HorizontalRecentering
  {
    get
    {
      return *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_HorizontalRecentering));
    }
    [param: In] set
    {
      *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_HorizontalRecentering)) = value;
    }
  }

  public unsafe bool m_ApplyBeforeBody
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_ApplyBeforeBody));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_ApplyBeforeBody)) = value;
    }
  }

  public unsafe Quaternion m_PreviousCameraRotation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_PreviousCameraRotation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePOV.NativeFieldInfoPtr_m_PreviousCameraRotation)) = value;
    }
  }

  public enum RecenterTargetMode
  {
    None,
    FollowTargetForward,
    LookAtTargetForward,
  }
}
