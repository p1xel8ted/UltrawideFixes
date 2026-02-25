// Decompiled with JetBrains decompiler
// Type: Cinemachine.Cinemachine3rdPersonAim
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

public class Cinemachine3rdPersonAim(IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_AimCollisionFilter;
  private static readonly IntPtr NativeFieldInfoPtr_IgnoreTag;
  private static readonly IntPtr NativeFieldInfoPtr_AimDistance;
  private static readonly IntPtr NativeFieldInfoPtr_AimTargetReticle;
  private static readonly IntPtr NativeFieldInfoPtr__AimTarget_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_AimTarget_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AimTarget_Private_set_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_DrawReticle_Private_Void_CinemachineBrain_0;
  private static readonly IntPtr NativeMethodInfoPtr_ComputeLookAtPoint_Private_Vector3_Vector3_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_ComputeAimTarget_Private_Vector3_Vector3_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Cinemachine3rdPersonAim()
  {
    Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (Cinemachine3rdPersonAim));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr);
    Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimCollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, nameof (AimCollisionFilter));
    Cinemachine3rdPersonAim.NativeFieldInfoPtr_IgnoreTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, nameof (IgnoreTag));
    Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, nameof (AimDistance));
    Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimTargetReticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, nameof (AimTargetReticle));
    Cinemachine3rdPersonAim.NativeFieldInfoPtr__AimTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, "<AimTarget>k__BackingField");
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_get_AimTarget_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663319 /*0x06000017*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_set_AimTarget_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663320 /*0x06000018*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663321 /*0x06000019*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663322 /*0x0600001A*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663323 /*0x0600001B*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_DrawReticle_Private_Void_CinemachineBrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663324 /*0x0600001C*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_ComputeLookAtPoint_Private_Vector3_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663325 /*0x0600001D*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_ComputeAimTarget_Private_Vector3_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663326 /*0x0600001E*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663327 /*0x0600001F*/);
    Cinemachine3rdPersonAim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr, 100663328 /*0x06000020*/);
  }

  public unsafe Vector3 AimTarget
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 110977, RefRangeEnd = 110978, XrefRangeStart = 110977, XrefRangeEnd = 110978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr_get_AimTarget_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr_set_AimTarget_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936756, XrefRangeEnd = 936758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936758, XrefRangeEnd = 936779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool OnTransitionFromCamera(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &worldUp;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cinemachine3rdPersonAim.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936779, XrefRangeEnd = 936816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawReticle(CinemachineBrain brain)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brain)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr_DrawReticle_Private_Void_CinemachineBrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936830, RefRangeEnd = 936831, XrefRangeStart = 936816, XrefRangeEnd = 936830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &camPos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr_ComputeLookAtPoint_Private_Vector3_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936831, XrefRangeEnd = 936839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &cameraLookAt;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr_ComputeAimTarget_Private_Vector3_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936839, XrefRangeEnd = 936858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState state,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stage;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cinemachine3rdPersonAim.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936858, XrefRangeEnd = 936860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cinemachine3rdPersonAim()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cinemachine3rdPersonAim>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonAim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask AimCollisionFilter
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimCollisionFilter));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimCollisionFilter)) = value;
    }
  }

  public unsafe string IgnoreTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_IgnoreTag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_IgnoreTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float AimDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimDistance)) = value;
    }
  }

  public unsafe RectTransform AimTargetReticle
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimTargetReticle));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr_AimTargetReticle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 _AimTarget_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr__AimTarget_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonAim.NativeFieldInfoPtr__AimTarget_k__BackingField)) = value;
    }
  }
}
