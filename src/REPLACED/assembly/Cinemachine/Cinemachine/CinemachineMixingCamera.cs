// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineMixingCamera
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

public class CinemachineMixingCamera(IntPtr pointer) : CinemachineVirtualCameraBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_MaxCameras;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight0;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight1;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight2;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight3;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight4;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight5;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight6;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight7;
  private static readonly IntPtr NativeFieldInfoPtr_m_State;
  private static readonly IntPtr NativeFieldInfoPtr__LiveChild_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__LookAt_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__Follow_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_m_ChildCameras;
  private static readonly IntPtr NativeFieldInfoPtr_m_indexMap;
  private static readonly IntPtr NativeMethodInfoPtr_GetWeight_Public_Single_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Public_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetWeight_Public_Single_CinemachineVirtualCameraBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Public_Void_CinemachineVirtualCameraBase_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LiveChild_Private_get_ICinemachineCamera_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LiveChild_Private_set_Void_ICinemachineCamera_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_InvalidateListOfChildren_Protected_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ValidateListOfChildren_Protected_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineMixingCamera()
  {
    Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineMixingCamera));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr);
    CinemachineMixingCamera.NativeFieldInfoPtr_MaxCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (MaxCameras));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight0));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight1));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight2));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight3));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight4));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight5));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight6));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_Weight7));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_State));
    CinemachineMixingCamera.NativeFieldInfoPtr__LiveChild_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, "<LiveChild>k__BackingField");
    CinemachineMixingCamera.NativeFieldInfoPtr__LookAt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, "<LookAt>k__BackingField");
    CinemachineMixingCamera.NativeFieldInfoPtr__Follow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, "<Follow>k__BackingField");
    CinemachineMixingCamera.NativeFieldInfoPtr_m_ChildCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_ChildCameras));
    CinemachineMixingCamera.NativeFieldInfoPtr_m_indexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, nameof (m_indexMap));
    CinemachineMixingCamera.NativeMethodInfoPtr_GetWeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663548 /*0x060000FC*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_SetWeight_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663549 /*0x060000FD*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_GetWeight_Public_Single_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663550 /*0x060000FE*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_SetWeight_Public_Void_CinemachineVirtualCameraBase_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663551 /*0x060000FF*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_get_LiveChild_Private_get_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663552 /*0x06000100*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_set_LiveChild_Private_set_Void_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663553 /*0x06000101*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663554 /*0x06000102*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663555 /*0x06000103*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663556 /*0x06000104*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663557 /*0x06000105*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663558 /*0x06000106*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663559 /*0x06000107*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663560 /*0x06000108*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663561 /*0x06000109*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663562 /*0x0600010A*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663563 /*0x0600010B*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663564 /*0x0600010C*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663565 /*0x0600010D*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_InvalidateListOfChildren_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663566 /*0x0600010E*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_ValidateListOfChildren_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663567 /*0x0600010F*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663568 /*0x06000110*/);
    CinemachineMixingCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663569);
    CinemachineMixingCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr, 100663570);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 939375, RefRangeEnd = 939378, XrefRangeStart = 939373, XrefRangeEnd = 939375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetWeight(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_GetWeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 939380, RefRangeEnd = 939382, XrefRangeStart = 939378, XrefRangeEnd = 939380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWeight(int index, float w)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &w;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_SetWeight_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939382, XrefRangeEnd = 939400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetWeight(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_GetWeight_Public_Single_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939400, XrefRangeEnd = 939418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWeight(CinemachineVirtualCameraBase vcam, float w)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &w;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_SetWeight_Public_Void_CinemachineVirtualCameraBase_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ICinemachineCamera LiveChild
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_get_LiveChild_Private_get_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_set_LiveChild_Private_set_Void_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe CameraState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_get_State_Public_Virtual_get_CameraState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
  }

  public override unsafe Transform LookAt
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_set_LookAt_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_set_Follow_Public_Virtual_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939418, XrefRangeEnd = 939421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positionDelta;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939421, XrefRangeEnd = 939424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rot;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939424, XrefRangeEnd = 939425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnTransformChildrenChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_OnTransformChildrenChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939425, XrefRangeEnd = 939428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939428, XrefRangeEnd = 939431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dominantChildOnly;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Boolean_ICinemachineCamera_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> ChildCameras
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 939432, RefRangeEnd = 939434, XrefRangeStart = 939431, XrefRangeEnd = 939432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_get_ChildCameras_Public_get_Il2CppReferenceArray_1_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num3);
    }
  }

  [CallerCount(0)]
  public unsafe void InvalidateListOfChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_InvalidateListOfChildren_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 939467, RefRangeEnd = 939475, XrefRangeStart = 939434, XrefRangeEnd = 939467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ValidateListOfChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr_ValidateListOfChildren_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939475, XrefRangeEnd = 939478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTransitionFromCamera(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &worldUp;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Void_ICinemachineCamera_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939478, XrefRangeEnd = 939489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &worldUp;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineMixingCamera.NativeMethodInfoPtr_InternalUpdateCameraState_Public_Virtual_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939489, XrefRangeEnd = 939494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineMixingCamera()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineMixingCamera>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixingCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int MaxCameras
  {
    get
    {
      int maxCameras;
      IL2CPP.il2cpp_field_static_get_value(CinemachineMixingCamera.NativeFieldInfoPtr_MaxCameras, (void*) &maxCameras);
      return maxCameras;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineMixingCamera.NativeFieldInfoPtr_MaxCameras, (void*) &value);
    }
  }

  public unsafe float m_Weight0
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight0));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight0)) = value;
    }
  }

  public unsafe float m_Weight1
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight1));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight1)) = value;
    }
  }

  public unsafe float m_Weight2
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight2));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight2)) = value;
    }
  }

  public unsafe float m_Weight3
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight3));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight3)) = value;
    }
  }

  public unsafe float m_Weight4
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight4));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight4)) = value;
    }
  }

  public unsafe float m_Weight5
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight5));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight5)) = value;
    }
  }

  public unsafe float m_Weight6
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight6));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight6)) = value;
    }
  }

  public unsafe float m_Weight7
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight7));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_Weight7)) = value;
    }
  }

  public CameraState m_State
  {
    get
    {
      IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_State);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe ICinemachineCamera _LiveChild_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr__LiveChild_k__BackingField));
      return num == IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr__LiveChild_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform _LookAt_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr__LookAt_k__BackingField));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr__LookAt_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform _Follow_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr__Follow_k__BackingField));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr__Follow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineVirtualCameraBase> m_ChildCameras
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_ChildCameras));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineVirtualCameraBase>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_ChildCameras), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<CinemachineVirtualCameraBase, int> m_indexMap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_indexMap));
      return num == IntPtr.Zero ? (Dictionary<CinemachineVirtualCameraBase, int>) null : Il2CppObjectPool.Get<Dictionary<CinemachineVirtualCameraBase, int>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixingCamera.NativeFieldInfoPtr_m_indexMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
