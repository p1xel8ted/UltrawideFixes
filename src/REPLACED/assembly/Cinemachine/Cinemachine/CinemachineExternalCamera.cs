// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineExternalCamera
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

public class CinemachineExternalCamera(IntPtr pointer) : CinemachineVirtualCameraBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_LookAt;
  private static readonly IntPtr NativeFieldInfoPtr_m_Camera;
  private static readonly IntPtr NativeFieldInfoPtr_m_State;
  private static readonly IntPtr NativeFieldInfoPtr__Follow_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_m_BlendHint;
  private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineExternalCamera()
  {
    Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineExternalCamera));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr);
    CinemachineExternalCamera.NativeFieldInfoPtr_m_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, nameof (m_LookAt));
    CinemachineExternalCamera.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, nameof (m_Camera));
    CinemachineExternalCamera.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, nameof (m_State));
    CinemachineExternalCamera.NativeFieldInfoPtr__Follow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, "<Follow>k__BackingField");
    CinemachineExternalCamera.NativeFieldInfoPtr_m_BlendHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, nameof (m_BlendHint));
    CinemachineExternalCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, 100663490 /*0x060000C2*/);
    CinemachineExternalCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, 100663491 /*0x060000C3*/);
    CinemachineExternalCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, 100663492 /*0x060000C4*/);
    CinemachineExternalCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, 100663493 /*0x060000C5*/);
    CinemachineExternalCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, 100663494 /*0x060000C6*/);
    CinemachineExternalCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, 100663495 /*0x060000C7*/);
    CinemachineExternalCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr, 100663496 /*0x060000C8*/);
  }

  public override unsafe CameraState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineExternalCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
  }

  public override unsafe Transform LookAt
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 72967, RefRangeEnd = 72968, XrefRangeStart = 72967, XrefRangeEnd = 72968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineExternalCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineExternalCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe Transform Follow
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineExternalCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineExternalCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938786, XrefRangeEnd = 938829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &worldUp;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineExternalCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938829, XrefRangeEnd = 938834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineExternalCamera()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineExternalCamera>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineExternalCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform m_LookAt
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_LookAt));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_LookAt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Camera m_Camera
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_Camera));
      return num == IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CameraState m_State
  {
    get
    {
      IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_State);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe Transform _Follow_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr__Follow_k__BackingField));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr__Follow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase.BlendHint m_BlendHint
  {
    get
    {
      return *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_BlendHint));
    }
    [param: In] set
    {
      *(CinemachineVirtualCameraBase.BlendHint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineExternalCamera.NativeFieldInfoPtr_m_BlendHint)) = value;
    }
  }
}
