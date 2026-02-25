// Decompiled with JetBrains decompiler
// Type: TrajectoryDrawer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TrajectoryDrawer(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_jumpHeight;
  private static readonly IntPtr NativeFieldInfoPtr_jumpDistance;
  private static readonly IntPtr NativeFieldInfoPtr_jumpAcceleration;
  private static readonly IntPtr NativeFieldInfoPtr_jumpFriction;
  private static readonly IntPtr NativeFieldInfoPtr_apexTime;
  private static readonly IntPtr NativeFieldInfoPtr_totalDuration;
  private static readonly IntPtr NativeFieldInfoPtr_fallStart;
  private static readonly IntPtr NativeFieldInfoPtr_fallGravity;
  private static readonly IntPtr NativeFieldInfoPtr_airFriction;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_xStep;
  private static readonly IntPtr NativeFieldInfoPtr_jumpVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_gravity;
  private static readonly IntPtr NativeFieldInfoPtr_trajectoryPoints;
  private static readonly IntPtr NativeFieldInfoPtr_fallPoints;
  private static readonly IntPtr NativeFieldInfoPtr_drawPoint;
  private static readonly IntPtr NativeFieldInfoPtr_rightEuler;
  private static readonly IntPtr NativeFieldInfoPtr_leftEuler;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalculateTrajectry_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DrawDirection_Private_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TrajectoryDrawer()
  {
    Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TrajectoryDrawer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr);
    TrajectoryDrawer.NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (jumpHeight));
    TrajectoryDrawer.NativeFieldInfoPtr_jumpDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (jumpDistance));
    TrajectoryDrawer.NativeFieldInfoPtr_jumpAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (jumpAcceleration));
    TrajectoryDrawer.NativeFieldInfoPtr_jumpFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (jumpFriction));
    TrajectoryDrawer.NativeFieldInfoPtr_apexTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (apexTime));
    TrajectoryDrawer.NativeFieldInfoPtr_totalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (totalDuration));
    TrajectoryDrawer.NativeFieldInfoPtr_fallStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (fallStart));
    TrajectoryDrawer.NativeFieldInfoPtr_fallGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (fallGravity));
    TrajectoryDrawer.NativeFieldInfoPtr_airFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (airFriction));
    TrajectoryDrawer.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (offset));
    TrajectoryDrawer.NativeFieldInfoPtr_xStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (xStep));
    TrajectoryDrawer.NativeFieldInfoPtr_jumpVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (jumpVelocity));
    TrajectoryDrawer.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (gravity));
    TrajectoryDrawer.NativeFieldInfoPtr_trajectoryPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (trajectoryPoints));
    TrajectoryDrawer.NativeFieldInfoPtr_fallPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (fallPoints));
    TrajectoryDrawer.NativeFieldInfoPtr_drawPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (drawPoint));
    TrajectoryDrawer.NativeFieldInfoPtr_rightEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (rightEuler));
    TrajectoryDrawer.NativeFieldInfoPtr_leftEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, nameof (leftEuler));
    TrajectoryDrawer.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, 100663746);
    TrajectoryDrawer.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, 100663747);
    TrajectoryDrawer.NativeMethodInfoPtr_CalculateTrajectry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, 100663748);
    TrajectoryDrawer.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, 100663749);
    TrajectoryDrawer.NativeMethodInfoPtr_DrawDirection_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, 100663750);
    TrajectoryDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr, 100663751);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrajectoryDrawer.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22509, XrefRangeEnd = 22514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrajectoryDrawer.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22514, XrefRangeEnd = 22541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculateTrajectry()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrajectoryDrawer.NativeMethodInfoPtr_CalculateTrajectry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22541, XrefRangeEnd = 22543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrajectoryDrawer.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22580, RefRangeEnd = 22582, XrefRangeStart = 22543, XrefRangeEnd = 22580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawDirection(Vector3 euler)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &euler
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrajectoryDrawer.NativeMethodInfoPtr_DrawDirection_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22582, XrefRangeEnd = 22593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TrajectoryDrawer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrajectoryDrawer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrajectoryDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference jumpHeight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpHeight));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpHeight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpDistance));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpAcceleration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpAcceleration));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpAcceleration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpFriction
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpFriction));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpFriction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float apexTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_apexTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_apexTime)) = value;
    }
  }

  public unsafe FloatReference totalDuration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_totalDuration));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_totalDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference fallStart
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_fallStart));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_fallStart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference fallGravity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_fallGravity));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_fallGravity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference airFriction
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_airFriction));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_airFriction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe float xStep
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_xStep));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_xStep)) = value;
    }
  }

  public unsafe float jumpVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_jumpVelocity)) = value;
    }
  }

  public unsafe float gravity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_gravity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_gravity)) = value;
    }
  }

  public unsafe List<Vector3> trajectoryPoints
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_trajectoryPoints));
      return num == IntPtr.Zero ? (List<Vector3>) null : Il2CppObjectPool.Get<List<Vector3>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_trajectoryPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Vector3> fallPoints
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_fallPoints));
      return num == IntPtr.Zero ? (List<Vector3>) null : Il2CppObjectPool.Get<List<Vector3>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_fallPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 drawPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_drawPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_drawPoint)) = value;
    }
  }

  public unsafe Vector3 rightEuler
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_rightEuler));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_rightEuler)) = value;
    }
  }

  public unsafe Vector3 leftEuler
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_leftEuler));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrajectoryDrawer.NativeFieldInfoPtr_leftEuler)) = value;
    }
  }
}
