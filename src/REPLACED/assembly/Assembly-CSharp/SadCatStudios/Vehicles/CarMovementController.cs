// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.CarMovementController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Vehicles;

public class CarMovementController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_carStartupCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_carInclineRotationCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_speedupTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_carSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialRot;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastMeasuredSpeeds;
  private static readonly System.IntPtr NativeFieldInfoPtr_speedTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr__Lane_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_StopAtCrossing;
  private static readonly System.IntPtr NativeFieldInfoPtr_animator;
  private static readonly System.IntPtr NativeFieldInfoPtr_startHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_stopHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_speedHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_startMoveHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_stopMovementHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_stopIdleHash;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Lane_Public_get_CarLane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Lane_Public_set_Void_CarLane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CarStopped_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MaxSpeed_Private_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CarInFront_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CarSpeedup_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CarSlowdown_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CarMoveWithSpeed_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedToStopAtCrossing_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToIncline_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToEnd_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeFromLane_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CarMovementController()
  {
    Il2CppClassPointerStore<CarMovementController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (CarMovementController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr);
    CarMovementController.NativeFieldInfoPtr_carStartupCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (carStartupCurve));
    CarMovementController.NativeFieldInfoPtr_carInclineRotationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (carInclineRotationCurve));
    CarMovementController.NativeFieldInfoPtr_speedupTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (speedupTimer));
    CarMovementController.NativeFieldInfoPtr_carSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (carSpeed));
    CarMovementController.NativeFieldInfoPtr_initialPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (initialPos));
    CarMovementController.NativeFieldInfoPtr_initialRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (initialRot));
    CarMovementController.NativeFieldInfoPtr_lastMeasuredSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (lastMeasuredSpeeds));
    CarMovementController.NativeFieldInfoPtr_speedTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (speedTimer));
    CarMovementController.NativeFieldInfoPtr__Lane_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, "<Lane>k__BackingField");
    CarMovementController.NativeFieldInfoPtr_StopAtCrossing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (StopAtCrossing));
    CarMovementController.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (animator));
    CarMovementController.NativeFieldInfoPtr_startHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (startHash));
    CarMovementController.NativeFieldInfoPtr_stopHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (stopHash));
    CarMovementController.NativeFieldInfoPtr_speedHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (speedHash));
    CarMovementController.NativeFieldInfoPtr_startMoveHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (startMoveHash));
    CarMovementController.NativeFieldInfoPtr_movementHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (movementHash));
    CarMovementController.NativeFieldInfoPtr_stopMovementHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (stopMovementHash));
    CarMovementController.NativeFieldInfoPtr_stopIdleHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, nameof (stopIdleHash));
    CarMovementController.NativeMethodInfoPtr_get_Lane_Public_get_CarLane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672982);
    CarMovementController.NativeMethodInfoPtr_set_Lane_Public_set_Void_CarLane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672983);
    CarMovementController.NativeMethodInfoPtr_get_CarStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672984);
    CarMovementController.NativeMethodInfoPtr_MaxSpeed_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672985);
    CarMovementController.NativeMethodInfoPtr_CarInFront_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672986);
    CarMovementController.NativeMethodInfoPtr_CarSpeedup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672987);
    CarMovementController.NativeMethodInfoPtr_CarSlowdown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672988);
    CarMovementController.NativeMethodInfoPtr_CarMoveWithSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672989);
    CarMovementController.NativeMethodInfoPtr_NeedToStopAtCrossing_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672990);
    CarMovementController.NativeMethodInfoPtr_ToIncline_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672991);
    CarMovementController.NativeMethodInfoPtr_ToEnd_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672992);
    CarMovementController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672993);
    CarMovementController.NativeMethodInfoPtr_InitializeFromLane_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672994);
    CarMovementController.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672995);
    CarMovementController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, 100672996);
  }

  public unsafe CarLane Lane
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_get_Lane_Public_get_CarLane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CarLane) null : Il2CppObjectPool.Get<CarLane>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_set_Lane_Public_set_Void_CarLane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool CarStopped
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_get_CarStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105321, XrefRangeEnd = 105325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float MaxSpeed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_MaxSpeed_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105325, XrefRangeEnd = 105332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CarInFront()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_CarInFront_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105332, XrefRangeEnd = 105341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CarSpeedup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_CarSpeedup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105341, XrefRangeEnd = 105350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CarSlowdown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_CarSlowdown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105350, XrefRangeEnd = 105409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CarMoveWithSpeed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_CarMoveWithSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 105413, RefRangeEnd = 105415, XrefRangeStart = 105409, XrefRangeEnd = 105413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool NeedToStopAtCrossing()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_NeedToStopAtCrossing_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105415, XrefRangeEnd = 105419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ToIncline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_ToIncline_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105419, XrefRangeEnd = 105423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ToEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_ToEnd_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105423, XrefRangeEnd = 105430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105430, XrefRangeEnd = 105441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeFromLane()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_InitializeFromLane_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105441, XrefRangeEnd = 105445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105445, XrefRangeEnd = 105473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CarMovementController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarMovementController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve carStartupCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_carStartupCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_carStartupCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve carInclineRotationCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_carInclineRotationCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_carInclineRotationCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float speedupTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_speedupTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_speedupTimer)) = value;
    }
  }

  public unsafe float carSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_carSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_carSpeed)) = value;
    }
  }

  public unsafe Vector3 initialPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_initialPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_initialPos)) = value;
    }
  }

  public unsafe Quaternion initialRot
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_initialRot));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_initialRot)) = value;
    }
  }

  public unsafe LinkedList<float> lastMeasuredSpeeds
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_lastMeasuredSpeeds));
      return num == System.IntPtr.Zero ? (LinkedList<float>) null : Il2CppObjectPool.Get<LinkedList<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_lastMeasuredSpeeds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float speedTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_speedTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_speedTimer)) = value;
    }
  }

  public unsafe CarLane _Lane_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr__Lane_k__BackingField));
      return num == System.IntPtr.Zero ? (CarLane) null : Il2CppObjectPool.Get<CarLane>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr__Lane_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool StopAtCrossing
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_StopAtCrossing));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_StopAtCrossing)) = value;
    }
  }

  public unsafe Animator animator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_animator));
      return num == System.IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int startHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_startHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_startHash)) = value;
    }
  }

  public unsafe int stopHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_stopHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_stopHash)) = value;
    }
  }

  public unsafe int speedHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_speedHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_speedHash)) = value;
    }
  }

  public unsafe int startMoveHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_startMoveHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_startMoveHash)) = value;
    }
  }

  public unsafe int movementHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_movementHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_movementHash)) = value;
    }
  }

  public unsafe int stopMovementHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_stopMovementHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_stopMovementHash)) = value;
    }
  }

  public unsafe int stopIdleHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_stopIdleHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController.NativeFieldInfoPtr_stopIdleHash)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Vehicles.CarMovementController+<ToEnd>d__30")]
  public sealed class _ToEnd_d__30(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__rotation_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__initialRotation_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__initialPos_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _ToEnd_d__30()
    {
      Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, "<ToEnd>d__30");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr);
      CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, "<>1__state");
      CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, "<>2__current");
      CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, "<>4__this");
      CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__rotation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, "<rotation>5__2");
      CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__initialRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, "<initialRotation>5__3");
      CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__initialPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, "<initialPos>5__4");
      CarMovementController._ToEnd_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, 100672997);
      CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, 100672998);
      CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, 100672999);
      CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, 100673000);
      CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, 100673001);
      CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr, 100673002);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ToEnd_d__30(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarMovementController._ToEnd_d__30>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToEnd_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105278, XrefRangeEnd = 105310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105310, XrefRangeEnd = 105315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CarMovementController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CarMovementController) null : Il2CppObjectPool.Get<CarMovementController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Quaternion _rotation_5__2
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__rotation_5__2));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__rotation_5__2)) = value;
      }
    }

    public unsafe Quaternion _initialRotation_5__3
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__initialRotation_5__3));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__initialRotation_5__3)) = value;
      }
    }

    public unsafe Vector3 _initialPos_5__4
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__initialPos_5__4));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToEnd_d__30.NativeFieldInfoPtr__initialPos_5__4)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Vehicles.CarMovementController+<ToIncline>d__29")]
  public sealed class _ToIncline_d__29(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _ToIncline_d__29()
    {
      Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarMovementController>.NativeClassPtr, "<ToIncline>d__29");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr);
      CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, "<>1__state");
      CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, "<>2__current");
      CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, "<>4__this");
      CarMovementController._ToIncline_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, 100673003);
      CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, 100673004);
      CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, 100673005);
      CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, 100673006);
      CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, 100673007);
      CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr, 100673008);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ToIncline_d__29(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarMovementController._ToIncline_d__29>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToIncline_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105315, XrefRangeEnd = 105316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105316, XrefRangeEnd = 105321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarMovementController._ToIncline_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CarMovementController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CarMovementController) null : Il2CppObjectPool.Get<CarMovementController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarMovementController._ToIncline_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
