// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineTrackedDolly
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

public class CinemachineTrackedDolly(System.IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Path;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PathPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PositionUnits;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PathOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_XDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_YDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ZDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PitchDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_YawDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RollDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AutoDolly;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousPathPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousOrientation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousCameraPosition;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraOrientationAtPathPoint_Private_Quaternion_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AngularDamping_Private_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineTrackedDolly()
  {
    Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineTrackedDolly));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr);
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_Path));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_PathPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_PathPosition));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_PositionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_PositionUnits));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_PathOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_PathOffset));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_XDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_XDamping));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_YDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_YDamping));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_ZDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_ZDamping));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_CameraUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_CameraUp));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_PitchDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_PitchDamping));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_YawDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_YawDamping));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_RollDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_RollDamping));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_AutoDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_AutoDolly));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousPathPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_PreviousPathPosition));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_PreviousOrientation));
    CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (m_PreviousCameraPosition));
    CinemachineTrackedDolly.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, 100663836);
    CinemachineTrackedDolly.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, 100663837);
    CinemachineTrackedDolly.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, 100663838);
    CinemachineTrackedDolly.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, 100663839);
    CinemachineTrackedDolly.NativeMethodInfoPtr_GetCameraOrientationAtPathPoint_Private_Quaternion_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, 100663840 /*0x06000220*/);
    CinemachineTrackedDolly.NativeMethodInfoPtr_get_AngularDamping_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, 100663841);
    CinemachineTrackedDolly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, 100663842);
  }

  public override unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941948, XrefRangeEnd = 941950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTrackedDolly.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTrackedDolly.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941950, XrefRangeEnd = 941954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTrackedDolly.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941954, XrefRangeEnd = 942001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTrackedDolly.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942017, RefRangeEnd = 942018, XrefRangeStart = 942001, XrefRangeEnd = 942017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pathOrientation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTrackedDolly.NativeMethodInfoPtr_GetCameraOrientationAtPathPoint_Private_Quaternion_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Vector3 AngularDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTrackedDolly.NativeMethodInfoPtr_get_AngularDamping_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942018, XrefRangeEnd = 942026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineTrackedDolly()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTrackedDolly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachinePathBase m_Path
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_Path));
      return num == System.IntPtr.Zero ? (CinemachinePathBase) null : Il2CppObjectPool.Get<CinemachinePathBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_Path), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_PathPosition
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PathPosition));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PathPosition)) = value;
    }
  }

  public unsafe CinemachinePathBase.PositionUnits m_PositionUnits
  {
    get
    {
      return *(CinemachinePathBase.PositionUnits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PositionUnits));
    }
    [param: In] set
    {
      *(CinemachinePathBase.PositionUnits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PositionUnits)) = value;
    }
  }

  public unsafe Vector3 m_PathOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PathOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PathOffset)) = value;
    }
  }

  public unsafe float m_XDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_XDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_XDamping)) = value;
    }
  }

  public unsafe float m_YDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_YDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_YDamping)) = value;
    }
  }

  public unsafe float m_ZDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_ZDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_ZDamping)) = value;
    }
  }

  public unsafe CinemachineTrackedDolly.CameraUpMode m_CameraUp
  {
    get
    {
      return *(CinemachineTrackedDolly.CameraUpMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_CameraUp));
    }
    [param: In] set
    {
      *(CinemachineTrackedDolly.CameraUpMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_CameraUp)) = value;
    }
  }

  public unsafe float m_PitchDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PitchDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PitchDamping)) = value;
    }
  }

  public unsafe float m_YawDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_YawDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_YawDamping)) = value;
    }
  }

  public unsafe float m_RollDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_RollDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_RollDamping)) = value;
    }
  }

  public unsafe CinemachineTrackedDolly.AutoDolly m_AutoDolly
  {
    get
    {
      return *(CinemachineTrackedDolly.AutoDolly*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_AutoDolly));
    }
    [param: In] set
    {
      *(CinemachineTrackedDolly.AutoDolly*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_AutoDolly)) = value;
    }
  }

  public unsafe float m_PreviousPathPosition
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousPathPosition));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousPathPosition)) = value;
    }
  }

  public unsafe Quaternion m_PreviousOrientation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousOrientation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousOrientation)) = value;
    }
  }

  public unsafe Vector3 m_PreviousCameraPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousCameraPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTrackedDolly.NativeFieldInfoPtr_m_PreviousCameraPosition)) = value;
    }
  }

  public enum CameraUpMode
  {
    Default,
    Path,
    PathNoRoll,
    FollowTarget,
    FollowTargetNoRoll,
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct AutoDolly
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PositionOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SearchRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SearchResolution;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Int32_Int32_0;
    [FieldOffset(0)]
    public bool m_Enabled;
    [FieldOffset(4)]
    public float m_PositionOffset;
    [FieldOffset(8)]
    public int m_SearchRadius;
    [FieldOffset(12)]
    public int m_SearchResolution;

    static AutoDolly()
    {
      Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineTrackedDolly>.NativeClassPtr, nameof (AutoDolly));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr);
      CinemachineTrackedDolly.AutoDolly.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr, nameof (m_Enabled));
      CinemachineTrackedDolly.AutoDolly.NativeFieldInfoPtr_m_PositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr, nameof (m_PositionOffset));
      CinemachineTrackedDolly.AutoDolly.NativeFieldInfoPtr_m_SearchRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr, nameof (m_SearchRadius));
      CinemachineTrackedDolly.AutoDolly.NativeFieldInfoPtr_m_SearchResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr, nameof (m_SearchResolution));
      CinemachineTrackedDolly.AutoDolly.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr, 100663843);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 941947, RefRangeEnd = 941948, XrefRangeStart = 941947, XrefRangeEnd = 941947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AutoDolly(
      bool enabled,
      float positionOffset,
      int searchRadius,
      int stepsPerSegment)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &enabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &searchRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stepsPerSegment;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineTrackedDolly.AutoDolly.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineTrackedDolly.AutoDolly>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
