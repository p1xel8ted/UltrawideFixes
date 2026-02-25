// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineTargetGroup
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

public class CinemachineTargetGroup(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PositionMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RotationMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Targets;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxWeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WeightSum;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AveragePos;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundingBox;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundingSphere;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdateFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ValidMembers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MemberValidity;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BoundingBox_Public_Virtual_Final_New_get_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BoundingBox_Private_set_Void_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Sphere_Public_Virtual_Final_New_get_BoundingSphere_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Sphere_Private_set_Void_BoundingSphere_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddMember_Public_Void_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMember_Public_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMember_Public_Int32_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetWeightedBoundsForMember_Public_BoundingSphere_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetViewSpaceBoundingBox_Public_Virtual_Final_New_Bounds_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CachedCountIsValid_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IndexIsValid_Private_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WeightedMemberBoundsForValidMember_Private_Static_BoundingSphere_byref_Target_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMemberValidity_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAveragePosition_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBoundingBox_Private_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBoundingSphere_Private_BoundingSphere_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAverageOrientation_Private_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetViewSpaceAngularBounds_Public_Virtual_Final_New_Void_Matrix4x4_byref_Vector2_byref_Vector2_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineTargetGroup()
  {
    Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineTargetGroup));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr);
    CinemachineTargetGroup.NativeFieldInfoPtr_m_PositionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_PositionMode));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_RotationMode));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_UpdateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_UpdateMethod));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_Targets));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_MaxWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_MaxWeight));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_WeightSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_WeightSum));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_AveragePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_AveragePos));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_BoundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_BoundingBox));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_BoundingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_BoundingSphere));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_LastUpdateFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_LastUpdateFrame));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_ValidMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_ValidMembers));
    CinemachineTargetGroup.NativeFieldInfoPtr_m_MemberValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (m_MemberValidity));
    CinemachineTargetGroup.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663648 /*0x06000160*/);
    CinemachineTargetGroup.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663649);
    CinemachineTargetGroup.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663650);
    CinemachineTargetGroup.NativeMethodInfoPtr_get_BoundingBox_Public_Virtual_Final_New_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663651);
    CinemachineTargetGroup.NativeMethodInfoPtr_set_BoundingBox_Private_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663652);
    CinemachineTargetGroup.NativeMethodInfoPtr_get_Sphere_Public_Virtual_Final_New_get_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663653);
    CinemachineTargetGroup.NativeMethodInfoPtr_set_Sphere_Private_set_Void_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663654);
    CinemachineTargetGroup.NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663655);
    CinemachineTargetGroup.NativeMethodInfoPtr_AddMember_Public_Void_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663656);
    CinemachineTargetGroup.NativeMethodInfoPtr_RemoveMember_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663657);
    CinemachineTargetGroup.NativeMethodInfoPtr_FindMember_Public_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663658);
    CinemachineTargetGroup.NativeMethodInfoPtr_GetWeightedBoundsForMember_Public_BoundingSphere_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663659);
    CinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceBoundingBox_Public_Virtual_Final_New_Bounds_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663660);
    CinemachineTargetGroup.NativeMethodInfoPtr_get_CachedCountIsValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663661);
    CinemachineTargetGroup.NativeMethodInfoPtr_IndexIsValid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663662);
    CinemachineTargetGroup.NativeMethodInfoPtr_WeightedMemberBoundsForValidMember_Private_Static_BoundingSphere_byref_Target_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663663);
    CinemachineTargetGroup.NativeMethodInfoPtr_DoUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663664 /*0x06000170*/);
    CinemachineTargetGroup.NativeMethodInfoPtr_UpdateMemberValidity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663665);
    CinemachineTargetGroup.NativeMethodInfoPtr_CalculateAveragePosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663666);
    CinemachineTargetGroup.NativeMethodInfoPtr_CalculateBoundingBox_Private_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663667);
    CinemachineTargetGroup.NativeMethodInfoPtr_CalculateBoundingSphere_Private_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663668);
    CinemachineTargetGroup.NativeMethodInfoPtr_CalculateAverageOrientation_Private_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663669);
    CinemachineTargetGroup.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663670);
    CinemachineTargetGroup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663671);
    CinemachineTargetGroup.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663672);
    CinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceAngularBounds_Public_Virtual_Final_New_Void_Matrix4x4_byref_Vector2_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663673);
    CinemachineTargetGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, 100663674);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940292, XrefRangeEnd = 940293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940293, XrefRangeEnd = 940296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe Transform Transform
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22243, XrefRangeEnd = 22246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public virtual unsafe Bounds BoundingBox
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940296, XrefRangeEnd = 940298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_get_BoundingBox_Public_Virtual_Final_New_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_set_BoundingBox_Private_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe BoundingSphere Sphere
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940298, XrefRangeEnd = 940300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_get_Sphere_Public_Virtual_Final_New_get_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(BoundingSphere*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_set_Sphere_Private_set_Void_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool IsEmpty
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940300, XrefRangeEnd = 940303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940303, XrefRangeEnd = 940309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddMember(Transform t, float weight, float radius)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_AddMember_Public_Void_Transform_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940309, XrefRangeEnd = 940314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveMember(Transform t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_RemoveMember_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940314, XrefRangeEnd = 940318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int FindMember(Transform t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_FindMember_Public_Int32_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940318, XrefRangeEnd = 940328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoundingSphere GetWeightedBoundsForMember(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_GetWeightedBoundsForMember_Public_BoundingSphere_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(BoundingSphere*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940328, XrefRangeEnd = 940347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Bounds GetViewSpaceBoundingBox(Matrix4x4 observer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &observer
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceBoundingBox_Public_Virtual_Final_New_Bounds_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool CachedCountIsValid
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 940348, RefRangeEnd = 940350, XrefRangeStart = 940347, XrefRangeEnd = 940348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_get_CachedCountIsValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940350, XrefRangeEnd = 940351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IndexIsValid(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_IndexIsValid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 940360, RefRangeEnd = 940366, XrefRangeStart = 940351, XrefRangeEnd = 940360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BoundingSphere WeightedMemberBoundsForValidMember(
    ref CinemachineTargetGroup.Target t,
    Vector3 avgPos,
    float maxWeight)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) t);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &avgPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxWeight;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_WeightedMemberBoundsForValidMember_Private_Static_BoundingSphere_byref_Target_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(BoundingSphere*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 940380, RefRangeEnd = 940391, XrefRangeStart = 940366, XrefRangeEnd = 940380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DoUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_DoUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940422, RefRangeEnd = 940423, XrefRangeStart = 940391, XrefRangeEnd = 940422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateMemberValidity()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_UpdateMemberValidity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940430, RefRangeEnd = 940431, XrefRangeStart = 940423, XrefRangeEnd = 940430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 CalculateAveragePosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_CalculateAveragePosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940440, RefRangeEnd = 940441, XrefRangeStart = 940431, XrefRangeEnd = 940440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Bounds CalculateBoundingBox()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_CalculateBoundingBox_Private_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940455, RefRangeEnd = 940456, XrefRangeStart = 940441, XrefRangeEnd = 940455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoundingSphere CalculateBoundingSphere()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_CalculateBoundingSphere_Private_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(BoundingSphere*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940472, RefRangeEnd = 940473, XrefRangeStart = 940456, XrefRangeEnd = 940472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Quaternion CalculateAverageOrientation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_CalculateAverageOrientation_Private_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940473, XrefRangeEnd = 940474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940474, XrefRangeEnd = 940479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940479, XrefRangeEnd = 940480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940480, XrefRangeEnd = 940517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void GetViewSpaceAngularBounds(
    Matrix4x4 observer,
    out Vector2 minAngles,
    out Vector2 maxAngles,
    out Vector2 zRange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &observer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref minAngles;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref maxAngles;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref zRange;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceAngularBounds_Public_Virtual_Final_New_Void_Matrix4x4_byref_Vector2_byref_Vector2_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940517, XrefRangeEnd = 940533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineTargetGroup()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTargetGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineTargetGroup.PositionMode m_PositionMode
  {
    get
    {
      return *(CinemachineTargetGroup.PositionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_PositionMode));
    }
    [param: In] set
    {
      *(CinemachineTargetGroup.PositionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_PositionMode)) = value;
    }
  }

  public unsafe CinemachineTargetGroup.RotationMode m_RotationMode
  {
    get
    {
      return *(CinemachineTargetGroup.RotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_RotationMode));
    }
    [param: In] set
    {
      *(CinemachineTargetGroup.RotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_RotationMode)) = value;
    }
  }

  public unsafe CinemachineTargetGroup.UpdateMethod m_UpdateMethod
  {
    get
    {
      return *(CinemachineTargetGroup.UpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_UpdateMethod));
    }
    [param: In] set
    {
      *(CinemachineTargetGroup.UpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_UpdateMethod)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CinemachineTargetGroup.Target> m_Targets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_Targets));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineTargetGroup.Target>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineTargetGroup.Target>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_Targets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_MaxWeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_MaxWeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_MaxWeight)) = value;
    }
  }

  public unsafe float m_WeightSum
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_WeightSum));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_WeightSum)) = value;
    }
  }

  public unsafe Vector3 m_AveragePos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_AveragePos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_AveragePos)) = value;
    }
  }

  public unsafe Bounds m_BoundingBox
  {
    get
    {
      return *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_BoundingBox));
    }
    [param: In] set
    {
      *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_BoundingBox)) = value;
    }
  }

  public unsafe BoundingSphere m_BoundingSphere
  {
    get
    {
      return *(BoundingSphere*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_BoundingSphere));
    }
    [param: In] set
    {
      *(BoundingSphere*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_BoundingSphere)) = value;
    }
  }

  public unsafe int m_LastUpdateFrame
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_LastUpdateFrame));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_LastUpdateFrame)) = value;
    }
  }

  public unsafe List<int> m_ValidMembers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_ValidMembers));
      return num == System.IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_ValidMembers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<bool> m_MemberValidity
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_MemberValidity));
      return num == System.IntPtr.Zero ? (List<bool>) null : Il2CppObjectPool.Get<List<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.NativeFieldInfoPtr_m_MemberValidity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Target : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeFieldInfoPtr_weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_radius;

    static Target()
    {
      Il2CppClassPointerStore<CinemachineTargetGroup.Target>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineTargetGroup>.NativeClassPtr, nameof (Target));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTargetGroup.Target>.NativeClassPtr);
      CinemachineTargetGroup.Target.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup.Target>.NativeClassPtr, nameof (target));
      CinemachineTargetGroup.Target.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup.Target>.NativeClassPtr, nameof (weight));
      CinemachineTargetGroup.Target.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTargetGroup.Target>.NativeClassPtr, nameof (radius));
    }

    public Target(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Target()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTargetGroup.Target>.NativeClassPtr))
    {
    }

    public unsafe Transform target
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.Target.NativeFieldInfoPtr_target));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.Target.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.Target.NativeFieldInfoPtr_weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.Target.NativeFieldInfoPtr_weight)) = value;
      }
    }

    public unsafe float radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.Target.NativeFieldInfoPtr_radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTargetGroup.Target.NativeFieldInfoPtr_radius)) = value;
      }
    }
  }

  public enum PositionMode
  {
    GroupCenter,
    GroupAverage,
  }

  public enum RotationMode
  {
    Manual,
    GroupAverage,
  }

  public enum UpdateMethod
  {
    Update,
    FixedUpdate,
    LateUpdate,
  }
}
