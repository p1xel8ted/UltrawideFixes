// Decompiled with JetBrains decompiler
// Type: Cinemachine.Cinemachine3rdPersonFollow
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

public class Cinemachine3rdPersonFollow(IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Damping;
  private static readonly IntPtr NativeFieldInfoPtr_ShoulderOffset;
  private static readonly IntPtr NativeFieldInfoPtr_VerticalArmLength;
  private static readonly IntPtr NativeFieldInfoPtr_CameraSide;
  private static readonly IntPtr NativeFieldInfoPtr_CameraDistance;
  private static readonly IntPtr NativeFieldInfoPtr_CameraCollisionFilter;
  private static readonly IntPtr NativeFieldInfoPtr_IgnoreTag;
  private static readonly IntPtr NativeFieldInfoPtr_CameraRadius;
  private static readonly IntPtr NativeFieldInfoPtr_DampingIntoCollision;
  private static readonly IntPtr NativeFieldInfoPtr_DampingFromCollision;
  private static readonly IntPtr NativeFieldInfoPtr_m_PreviousFollowTargetPosition;
  private static readonly IntPtr NativeFieldInfoPtr_m_DampingCorrection;
  private static readonly IntPtr NativeFieldInfoPtr_m_CamPosCollisionCorrection;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_PositionCamera_Private_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRigPositions_Public_Void_byref_Vector3_byref_Vector3_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHeading_Internal_Static_Quaternion_Quaternion_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRawRigPositions_Private_Void_Vector3_Quaternion_Quaternion_byref_Vector3_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResolveCollisions_Private_Vector3_Vector3_Vector3_Single_Single_byref_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Cinemachine3rdPersonFollow()
  {
    Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (Cinemachine3rdPersonFollow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr);
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (Damping));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_ShoulderOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (ShoulderOffset));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_VerticalArmLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (VerticalArmLength));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (CameraSide));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (CameraDistance));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraCollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (CameraCollisionFilter));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_IgnoreTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (IgnoreTag));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (CameraRadius));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_DampingIntoCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (DampingIntoCollision));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_DampingFromCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (DampingFromCollision));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_PreviousFollowTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (m_PreviousFollowTargetPosition));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_DampingCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (m_DampingCorrection));
    Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_CamPosCollisionCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, nameof (m_CamPosCollisionCorrection));
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663714);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663715);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663716);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663717);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663718);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663719);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663720);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663721);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_PositionCamera_Private_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663722);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetRigPositions_Public_Void_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663723);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetHeading_Internal_Static_Quaternion_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663724);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetRawRigPositions_Private_Void_Vector3_Quaternion_Quaternion_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663725);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr_ResolveCollisions_Private_Vector3_Vector3_Vector3_Single_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663726);
    Cinemachine3rdPersonFollow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr, 100663727);
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940987, XrefRangeEnd = 940988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940988, XrefRangeEnd = 940992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940992, XrefRangeEnd = 940994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cinemachine3rdPersonFollow.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cinemachine3rdPersonFollow.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940994, XrefRangeEnd = 940996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cinemachine3rdPersonFollow.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940996, XrefRangeEnd = 941002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positionDelta;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cinemachine3rdPersonFollow.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941020, RefRangeEnd = 941021, XrefRangeStart = 941002, XrefRangeEnd = 941020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PositionCamera(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_PositionCamera_Private_Void_byref_CameraState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941021, XrefRangeEnd = 941027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) ref root;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref shoulder;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref hand;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetRigPositions_Public_Void_byref_Vector3_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 941036, RefRangeEnd = 941038, XrefRangeStart = 941027, XrefRangeEnd = 941036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion GetHeading(Quaternion targetRot, Vector3 up)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &targetRot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &up;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetHeading_Internal_Static_Quaternion_Quaternion_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941041, RefRangeEnd = 941042, XrefRangeStart = 941038, XrefRangeEnd = 941041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetRawRigPositions(
    Vector3 root,
    Quaternion targetRot,
    Quaternion heading,
    out Vector3 shoulder,
    out Vector3 hand)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &root;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &targetRot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &heading;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref shoulder;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) ref hand;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_GetRawRigPositions_Private_Void_Vector3_Quaternion_Quaternion_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 941054, RefRangeEnd = 941057, XrefRangeStart = 941042, XrefRangeEnd = 941054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ResolveCollisions(
    Vector3 root,
    Vector3 tip,
    float deltaTime,
    float cameraRadius,
    ref float collisionCorrection)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &root;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &tip;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &cameraRadius;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) ref collisionCorrection;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr_ResolveCollisions_Private_Vector3_Vector3_Vector3_Single_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941057, XrefRangeEnd = 941059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cinemachine3rdPersonFollow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cinemachine3rdPersonFollow>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cinemachine3rdPersonFollow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 Damping
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_Damping));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_Damping)) = value;
    }
  }

  public unsafe Vector3 ShoulderOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_ShoulderOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_ShoulderOffset)) = value;
    }
  }

  public unsafe float VerticalArmLength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_VerticalArmLength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_VerticalArmLength)) = value;
    }
  }

  public unsafe float CameraSide
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraSide));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraSide)) = value;
    }
  }

  public unsafe float CameraDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraDistance)) = value;
    }
  }

  public unsafe LayerMask CameraCollisionFilter
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraCollisionFilter));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraCollisionFilter)) = value;
    }
  }

  public unsafe string IgnoreTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_IgnoreTag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_IgnoreTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float CameraRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_CameraRadius)) = value;
    }
  }

  public unsafe float DampingIntoCollision
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_DampingIntoCollision));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_DampingIntoCollision)) = value;
    }
  }

  public unsafe float DampingFromCollision
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_DampingFromCollision));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_DampingFromCollision)) = value;
    }
  }

  public unsafe Vector3 m_PreviousFollowTargetPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_PreviousFollowTargetPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_PreviousFollowTargetPosition)) = value;
    }
  }

  public unsafe Vector3 m_DampingCorrection
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_DampingCorrection));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_DampingCorrection)) = value;
    }
  }

  public unsafe float m_CamPosCollisionCorrection
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_CamPosCollisionCorrection));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cinemachine3rdPersonFollow.NativeFieldInfoPtr_m_CamPosCollisionCorrection)) = value;
    }
  }
}
