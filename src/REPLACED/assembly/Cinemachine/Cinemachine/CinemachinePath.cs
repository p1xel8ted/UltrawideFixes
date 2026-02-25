// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachinePath
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

public class CinemachinePath(System.IntPtr pointer) : CinemachinePathBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Looped;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Waypoints;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinPos_Public_Virtual_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxPos_Public_Virtual_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Looped_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Virtual_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundingIndices_Private_Single_Single_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalPosition_Public_Virtual_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalTangent_Public_Virtual_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Virtual_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRoll_Internal_Single_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RollAroundForward_Private_Static_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachinePath()
  {
    Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachinePath));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr);
    CinemachinePath.NativeFieldInfoPtr_m_Looped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, nameof (m_Looped));
    CinemachinePath.NativeFieldInfoPtr_m_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, nameof (m_Waypoints));
    CinemachinePath.NativeMethodInfoPtr_get_MinPos_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663571);
    CinemachinePath.NativeMethodInfoPtr_get_MaxPos_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663572);
    CinemachinePath.NativeMethodInfoPtr_get_Looped_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663573);
    CinemachinePath.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663574);
    CinemachinePath.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663575);
    CinemachinePath.NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663576);
    CinemachinePath.NativeMethodInfoPtr_GetBoundingIndices_Private_Single_Single_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663577);
    CinemachinePath.NativeMethodInfoPtr_EvaluateLocalPosition_Public_Virtual_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663578);
    CinemachinePath.NativeMethodInfoPtr_EvaluateLocalTangent_Public_Virtual_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663579);
    CinemachinePath.NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Virtual_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663580);
    CinemachinePath.NativeMethodInfoPtr_GetRoll_Internal_Single_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663581);
    CinemachinePath.NativeMethodInfoPtr_RollAroundForward_Private_Static_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663582);
    CinemachinePath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, 100663583);
  }

  public override unsafe float MinPos
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePath.NativeMethodInfoPtr_get_MinPos_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePath.NativeMethodInfoPtr_get_MaxPos_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePath.NativeMethodInfoPtr_get_Looped_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939494, XrefRangeEnd = 939503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePath.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePath.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe int DistanceCacheSampleStepsPerSegment
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePath.NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 939523, RefRangeEnd = 939526, XrefRangeStart = 939503, XrefRangeEnd = 939523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetBoundingIndices(float pos, out int indexA, out int indexB)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref indexA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref indexB;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePath.NativeMethodInfoPtr_GetBoundingIndices_Private_Single_Single_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939526, XrefRangeEnd = 939531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 EvaluateLocalPosition(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePath.NativeMethodInfoPtr_EvaluateLocalPosition_Public_Virtual_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939531, XrefRangeEnd = 939536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 EvaluateLocalTangent(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePath.NativeMethodInfoPtr_EvaluateLocalTangent_Public_Virtual_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939536, XrefRangeEnd = 939547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Quaternion EvaluateLocalOrientation(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePath.NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Virtual_Quaternion_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939547, XrefRangeEnd = 939550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetRoll(int indexA, int indexB, float standardizedPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &indexA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &indexB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &standardizedPos;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePath.NativeMethodInfoPtr_GetRoll_Internal_Single_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939550, XrefRangeEnd = 939552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion RollAroundForward(float angle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &angle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePath.NativeMethodInfoPtr_RollAroundForward_Private_Static_Quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939552, XrefRangeEnd = 939559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachinePath()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool m_Looped
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePath.NativeFieldInfoPtr_m_Looped));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePath.NativeFieldInfoPtr_m_Looped)) = value;
    }
  }

  public unsafe Il2CppStructArray<CinemachinePath.Waypoint> m_Waypoints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePath.NativeFieldInfoPtr_m_Waypoints));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<CinemachinePath.Waypoint>) null : Il2CppObjectPool.Get<Il2CppStructArray<CinemachinePath.Waypoint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePath.NativeFieldInfoPtr_m_Waypoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Waypoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeFieldInfoPtr_tangent;
    private static readonly System.IntPtr NativeFieldInfoPtr_roll;
    [FieldOffset(0)]
    public Vector3 position;
    [FieldOffset(12)]
    public Vector3 tangent;
    [FieldOffset(24)]
    public float roll;

    static Waypoint()
    {
      Il2CppClassPointerStore<CinemachinePath.Waypoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachinePath>.NativeClassPtr, nameof (Waypoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachinePath.Waypoint>.NativeClassPtr);
      CinemachinePath.Waypoint.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePath.Waypoint>.NativeClassPtr, nameof (position));
      CinemachinePath.Waypoint.NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePath.Waypoint>.NativeClassPtr, nameof (tangent));
      CinemachinePath.Waypoint.NativeFieldInfoPtr_roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePath.Waypoint>.NativeClassPtr, nameof (roll));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachinePath.Waypoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
