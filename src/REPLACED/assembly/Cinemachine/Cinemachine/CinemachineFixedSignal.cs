// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineFixedSignal
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

public class CinemachineFixedSignal(IntPtr pointer) : SignalSourceAsset(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_XCurve;
  private static readonly IntPtr NativeFieldInfoPtr_m_YCurve;
  private static readonly IntPtr NativeFieldInfoPtr_m_ZCurve;
  private static readonly IntPtr NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_AxisDuration_Private_Single_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSignal_Public_Virtual_Void_Single_byref_Vector3_byref_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_AxisValue_Private_Single_AnimationCurve_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineFixedSignal()
  {
    Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineFixedSignal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr);
    CinemachineFixedSignal.NativeFieldInfoPtr_m_XCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, nameof (m_XCurve));
    CinemachineFixedSignal.NativeFieldInfoPtr_m_YCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, nameof (m_YCurve));
    CinemachineFixedSignal.NativeFieldInfoPtr_m_ZCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, nameof (m_ZCurve));
    CinemachineFixedSignal.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, 100664246);
    CinemachineFixedSignal.NativeMethodInfoPtr_AxisDuration_Private_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, 100664247);
    CinemachineFixedSignal.NativeMethodInfoPtr_GetSignal_Public_Virtual_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, 100664248);
    CinemachineFixedSignal.NativeMethodInfoPtr_AxisValue_Private_Single_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, 100664249);
    CinemachineFixedSignal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr, 100664250);
  }

  public override unsafe float SignalDuration
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945366, XrefRangeEnd = 945369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFixedSignal.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 945375, RefRangeEnd = 945378, XrefRangeStart = 945369, XrefRangeEnd = 945375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float AxisDuration(AnimationCurve axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) axis)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFixedSignal.NativeMethodInfoPtr_AxisDuration_Private_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945378, XrefRangeEnd = 945388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void GetSignal(
    float timeSinceSignalStart,
    out Vector3 pos,
    out Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &timeSinceSignalStart;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref rot;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFixedSignal.NativeMethodInfoPtr_GetSignal_Public_Virtual_Void_Single_byref_Vector3_byref_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945388, XrefRangeEnd = 945390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float AxisValue(AnimationCurve axis, float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) axis);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &time;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFixedSignal.NativeMethodInfoPtr_AxisValue_Private_Single_AnimationCurve_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineFixedSignal()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFixedSignal>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFixedSignal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve m_XCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFixedSignal.NativeFieldInfoPtr_m_XCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFixedSignal.NativeFieldInfoPtr_m_XCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve m_YCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFixedSignal.NativeFieldInfoPtr_m_YCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFixedSignal.NativeFieldInfoPtr_m_YCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve m_ZCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFixedSignal.NativeFieldInfoPtr_m_ZCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFixedSignal.NativeFieldInfoPtr_m_ZCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
