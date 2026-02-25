// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineSmoothPath
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineSmoothPath(System.IntPtr pointer) : CinemachinePathBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Looped;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Waypoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlPoints1;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlPoints2;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsLoopedCache;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinPos_Public_Virtual_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxPos_Public_Virtual_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Looped_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Virtual_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateDistanceCache_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateControlPoints_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundingIndices_Private_Single_Single_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalPosition_Public_Virtual_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalTangent_Public_Virtual_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Virtual_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RollAroundForward_Private_Static_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineSmoothPath()
  {
    Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineSmoothPath));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr);
    CinemachineSmoothPath.NativeFieldInfoPtr_m_Looped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, nameof (m_Looped));
    CinemachineSmoothPath.NativeFieldInfoPtr_m_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, nameof (m_Waypoints));
    CinemachineSmoothPath.NativeFieldInfoPtr_m_ControlPoints1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, nameof (m_ControlPoints1));
    CinemachineSmoothPath.NativeFieldInfoPtr_m_ControlPoints2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, nameof (m_ControlPoints2));
    CinemachineSmoothPath.NativeFieldInfoPtr_m_IsLoopedCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, nameof (m_IsLoopedCache));
    CinemachineSmoothPath.NativeMethodInfoPtr_get_MinPos_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663586);
    CinemachineSmoothPath.NativeMethodInfoPtr_get_MaxPos_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663587);
    CinemachineSmoothPath.NativeMethodInfoPtr_get_Looped_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663588);
    CinemachineSmoothPath.NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663589);
    CinemachineSmoothPath.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663590);
    CinemachineSmoothPath.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663591);
    CinemachineSmoothPath.NativeMethodInfoPtr_InvalidateDistanceCache_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663592);
    CinemachineSmoothPath.NativeMethodInfoPtr_UpdateControlPoints_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663593);
    CinemachineSmoothPath.NativeMethodInfoPtr_GetBoundingIndices_Private_Single_Single_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663594);
    CinemachineSmoothPath.NativeMethodInfoPtr_EvaluateLocalPosition_Public_Virtual_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663595);
    CinemachineSmoothPath.NativeMethodInfoPtr_EvaluateLocalTangent_Public_Virtual_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663596);
    CinemachineSmoothPath.NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Virtual_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663597);
    CinemachineSmoothPath.NativeMethodInfoPtr_RollAroundForward_Private_Static_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663598);
    CinemachineSmoothPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, 100663599);
  }

  public override unsafe float MinPos
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_get_MinPos_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe float MaxPos
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_get_MaxPos_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe bool Looped
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_get_Looped_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe int DistanceCacheSampleStepsPerSegment
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939559, XrefRangeEnd = 939568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939568, XrefRangeEnd = 939569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void InvalidateDistanceCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_InvalidateDistanceCache_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 939585, RefRangeEnd = 939588, XrefRangeStart = 939569, XrefRangeEnd = 939585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateControlPoints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.NativeMethodInfoPtr_UpdateControlPoints_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 939594, RefRangeEnd = 939597, XrefRangeStart = 939588, XrefRangeEnd = 939594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetBoundingIndices(float pos, out int indexA, out int indexB)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref indexA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref indexB;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.NativeMethodInfoPtr_GetBoundingIndices_Private_Single_Single_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939597, XrefRangeEnd = 939603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 EvaluateLocalPosition(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_EvaluateLocalPosition_Public_Virtual_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939603, XrefRangeEnd = 939609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 EvaluateLocalTangent(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_EvaluateLocalTangent_Public_Virtual_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939609, XrefRangeEnd = 939619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Quaternion EvaluateLocalOrientation(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineSmoothPath.NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Virtual_Quaternion_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion RollAroundForward(float angle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &angle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.NativeMethodInfoPtr_RollAroundForward_Private_Static_Quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939619, XrefRangeEnd = 939626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineSmoothPath()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool m_Looped
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_Looped));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_Looped)) = value;
    }
  }

  public unsafe Il2CppStructArray<CinemachineSmoothPath.Waypoint> m_Waypoints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_Waypoints));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachineSmoothPath.Waypoint>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachineSmoothPath.Waypoint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_Waypoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<CinemachineSmoothPath.Waypoint> m_ControlPoints1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_ControlPoints1));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachineSmoothPath.Waypoint>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachineSmoothPath.Waypoint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_ControlPoints1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<CinemachineSmoothPath.Waypoint> m_ControlPoints2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_ControlPoints2));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachineSmoothPath.Waypoint>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachineSmoothPath.Waypoint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_ControlPoints2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_IsLoopedCache
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_IsLoopedCache));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineSmoothPath.NativeFieldInfoPtr_m_IsLoopedCache)) = value;
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Waypoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeFieldInfoPtr_roll;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AsVector4_Internal_get_Vector4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromVector4_Internal_Static_Waypoint_Vector4_0;
    [FieldOffset(0)]
    public Vector3 position;
    [FieldOffset(12)]
    public float roll;

    static Waypoint()
    {
      Il2CppClassPointerStore<CinemachineSmoothPath.Waypoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineSmoothPath>.NativeClassPtr, nameof (Waypoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineSmoothPath.Waypoint>.NativeClassPtr);
      CinemachineSmoothPath.Waypoint.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineSmoothPath.Waypoint>.NativeClassPtr, nameof (position));
      CinemachineSmoothPath.Waypoint.NativeFieldInfoPtr_roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineSmoothPath.Waypoint>.NativeClassPtr, nameof (roll));
      CinemachineSmoothPath.Waypoint.NativeMethodInfoPtr_get_AsVector4_Internal_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath.Waypoint>.NativeClassPtr, 100663600 /*0x06000130*/);
      CinemachineSmoothPath.Waypoint.NativeMethodInfoPtr_FromVector4_Internal_Static_Waypoint_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineSmoothPath.Waypoint>.NativeClassPtr, 100663601);
    }

    public unsafe Vector4 AsVector4
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.Waypoint.NativeMethodInfoPtr_get_AsVector4_Internal_get_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    public static unsafe CinemachineSmoothPath.Waypoint FromVector4(Vector4 v)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &v
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineSmoothPath.Waypoint.NativeMethodInfoPtr_FromVector4_Internal_Static_Waypoint_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineSmoothPath.Waypoint*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineSmoothPath.Waypoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
