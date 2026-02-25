// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.Hacking.TrafficPuzzle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using SadCatStudios.Character;
using SadCatStudios.Vehicles;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Environment.Hacking;

public class TrafficPuzzle(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_carLanes;
  private static readonly System.IntPtr NativeFieldInfoPtr_crowdTrackerLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_crowdTrackerRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_droneController;
  private static readonly System.IntPtr NativeFieldInfoPtr_droneKillTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_carsStoppingCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_carsStoppedCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_carsResumedCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedCrowdEnoughLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedCrowdNotEnoughLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedCrowdEnoughRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedCrowdNotEnoughRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_nCountsAsCrowd;
  private static readonly System.IntPtr NativeFieldInfoPtr_vehicleController;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerInside;
  private static readonly System.IntPtr NativeFieldInfoPtr_killTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_roadCollider;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PausedChangedLeft_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PausedChangedRight_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopTraffic_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPlayerInTraffic_Private_UniTaskVoid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopTrafficAsync_Private_UniTaskVoid_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TrafficPuzzle()
  {
    Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment.Hacking", nameof (TrafficPuzzle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr);
    TrafficPuzzle.NativeFieldInfoPtr_carLanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (carLanes));
    TrafficPuzzle.NativeFieldInfoPtr_crowdTrackerLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (crowdTrackerLeft));
    TrafficPuzzle.NativeFieldInfoPtr_crowdTrackerRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (crowdTrackerRight));
    TrafficPuzzle.NativeFieldInfoPtr_droneController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (droneController));
    TrafficPuzzle.NativeFieldInfoPtr_droneKillTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (droneKillTimer));
    TrafficPuzzle.NativeFieldInfoPtr_carsStoppingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (carsStoppingCallback));
    TrafficPuzzle.NativeFieldInfoPtr_carsStoppedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (carsStoppedCallback));
    TrafficPuzzle.NativeFieldInfoPtr_carsResumedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (carsResumedCallback));
    TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdEnoughLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (pausedCrowdEnoughLeft));
    TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdNotEnoughLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (pausedCrowdNotEnoughLeft));
    TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdEnoughRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (pausedCrowdEnoughRight));
    TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdNotEnoughRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (pausedCrowdNotEnoughRight));
    TrafficPuzzle.NativeFieldInfoPtr_nCountsAsCrowd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (nCountsAsCrowd));
    TrafficPuzzle.NativeFieldInfoPtr_vehicleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (vehicleController));
    TrafficPuzzle.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (cancel));
    TrafficPuzzle.NativeFieldInfoPtr_playerInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (playerInside));
    TrafficPuzzle.NativeFieldInfoPtr_killTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (killTimer));
    TrafficPuzzle.NativeFieldInfoPtr_playerHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (playerHealth));
    TrafficPuzzle.NativeFieldInfoPtr_roadCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, nameof (roadCollider));
    TrafficPuzzle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676292);
    TrafficPuzzle.NativeMethodInfoPtr_PausedChangedLeft_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676293);
    TrafficPuzzle.NativeMethodInfoPtr_PausedChangedRight_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676294);
    TrafficPuzzle.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676295);
    TrafficPuzzle.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676296);
    TrafficPuzzle.NativeMethodInfoPtr_StopTraffic_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676297);
    TrafficPuzzle.NativeMethodInfoPtr_CheckPlayerInTraffic_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676298);
    TrafficPuzzle.NativeMethodInfoPtr_StopTrafficAsync_Private_UniTaskVoid_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676299);
    TrafficPuzzle.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676300);
    TrafficPuzzle.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676301);
    TrafficPuzzle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, 100676302);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122701, XrefRangeEnd = 122730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122730, XrefRangeEnd = 122732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PausedChangedLeft(int n)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &n
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_PausedChangedLeft_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122732, XrefRangeEnd = 122734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PausedChangedRight(int n)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &n
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_PausedChangedRight_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122734, XrefRangeEnd = 122744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122744, XrefRangeEnd = 122747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerExit(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122747, XrefRangeEnd = 122751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopTraffic(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_StopTraffic_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122751, XrefRangeEnd = 122754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid CheckPlayerInTraffic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_CheckPlayerInTraffic_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122754, XrefRangeEnd = 122757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid StopTrafficAsync(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_StopTrafficAsync_Private_UniTaskVoid_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122757, XrefRangeEnd = 122764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122764, XrefRangeEnd = 122785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TrafficPuzzle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<CarLane> carLanes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carLanes));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CarLane>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CarLane>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carLanes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CrowdTracker crowdTrackerLeft
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_crowdTrackerLeft));
      return num == System.IntPtr.Zero ? (CrowdTracker) null : Il2CppObjectPool.Get<CrowdTracker>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_crowdTrackerLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CrowdTracker crowdTrackerRight
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_crowdTrackerRight));
      return num == System.IntPtr.Zero ? (CrowdTracker) null : Il2CppObjectPool.Get<CrowdTracker>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_crowdTrackerRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlyingDroneAIController droneController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_droneController));
      return num == System.IntPtr.Zero ? (FlyingDroneAIController) null : Il2CppObjectPool.Get<FlyingDroneAIController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_droneController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float droneKillTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_droneKillTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_droneKillTimer)) = value;
    }
  }

  public unsafe UnityEvent carsStoppingCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carsStoppingCallback));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carsStoppingCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent carsStoppedCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carsStoppedCallback));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carsStoppedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent carsResumedCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carsResumedCallback));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_carsResumedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent pausedCrowdEnoughLeft
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdEnoughLeft));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdEnoughLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent pausedCrowdNotEnoughLeft
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdNotEnoughLeft));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdNotEnoughLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent pausedCrowdEnoughRight
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdEnoughRight));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdEnoughRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent pausedCrowdNotEnoughRight
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdNotEnoughRight));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_pausedCrowdNotEnoughRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int nCountsAsCrowd
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_nCountsAsCrowd));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_nCountsAsCrowd)) = value;
    }
  }

  public unsafe FlyingVehicleController vehicleController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_vehicleController));
      return num == System.IntPtr.Zero ? (FlyingVehicleController) null : Il2CppObjectPool.Get<FlyingVehicleController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_vehicleController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CancellationTokenSource cancel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_cancel));
      return num == System.IntPtr.Zero ? (CancellationTokenSource) null : Il2CppObjectPool.Get<CancellationTokenSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_cancel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool playerInside
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_playerInside));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_playerInside)) = value;
    }
  }

  public unsafe float killTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_killTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_killTimer)) = value;
    }
  }

  public unsafe CharacterHealthController playerHealth
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_playerHealth));
      return num == System.IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_playerHealth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoxCollider roadCollider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_roadCollider));
      return num == System.IntPtr.Zero ? (BoxCollider) null : Il2CppObjectPool.Get<BoxCollider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle.NativeFieldInfoPtr_roadCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.TrafficPuzzle+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__26_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StopTrafficAsync_b__26_0_Internal_Boolean_CarLane_0;

    static __c()
    {
      Il2CppClassPointerStore<TrafficPuzzle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficPuzzle.__c>.NativeClassPtr);
      TrafficPuzzle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle.__c>.NativeClassPtr, "<>9");
      TrafficPuzzle.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle.__c>.NativeClassPtr, "<>9__26_0");
      TrafficPuzzle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle.__c>.NativeClassPtr, 100676304);
      TrafficPuzzle.__c.NativeMethodInfoPtr__StopTrafficAsync_b__26_0_Internal_Boolean_CarLane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle.__c>.NativeClassPtr, 100676305);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficPuzzle.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122590, XrefRangeEnd = 122592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _StopTrafficAsync_b__26_0(CarLane l)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle.__c.NativeMethodInfoPtr__StopTrafficAsync_b__26_0_Internal_Boolean_CarLane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe TrafficPuzzle.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(TrafficPuzzle.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (TrafficPuzzle.__c) null : Il2CppObjectPool.Get<TrafficPuzzle.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrafficPuzzle.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CarLane, bool> __9__26_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(TrafficPuzzle.__c.NativeFieldInfoPtr___9__26_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<CarLane, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<CarLane, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrafficPuzzle.__c.NativeFieldInfoPtr___9__26_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.TrafficPuzzle+<CheckPlayerInTraffic>d__25")]
  public sealed class _CheckPlayerInTraffic_d__25 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _CheckPlayerInTraffic_d__25()
    {
      Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, "<CheckPlayerInTraffic>d__25");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr);
      TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr, "<>1__state");
      TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr, "<>t__builder");
      TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr, "<>4__this");
      TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr, "<>u__1");
      TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr, 100676306);
      TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr, 100676307);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122592, XrefRangeEnd = 122621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _CheckPlayerInTraffic_d__25(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _CheckPlayerInTraffic_d__25()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficPuzzle._CheckPlayerInTraffic_d__25>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TrafficPuzzle __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (TrafficPuzzle) null : Il2CppObjectPool.Get<TrafficPuzzle>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._CheckPlayerInTraffic_d__25.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.TrafficPuzzle+<StopTrafficAsync>d__26")]
  public sealed class _StopTrafficAsync_d__26 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_time;
    private static readonly System.IntPtr NativeFieldInfoPtr__token_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__minX_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__maxX_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__crowdSpawnerLeft_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__crowdSpawnerRight_5__6;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__7;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _StopTrafficAsync_d__26()
    {
      Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrafficPuzzle>.NativeClassPtr, "<StopTrafficAsync>d__26");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr);
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<>1__state");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<>t__builder");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<>4__this");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, nameof (time));
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__token_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<token>5__2");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__minX_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<minX>5__3");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__maxX_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<maxX>5__4");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__crowdSpawnerLeft_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<crowdSpawnerLeft>5__5");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__crowdSpawnerRight_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<crowdSpawnerRight>5__6");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__timer_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<timer>5__7");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<>u__1");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, "<>u__2");
      TrafficPuzzle._StopTrafficAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, 100676308);
      TrafficPuzzle._StopTrafficAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr, 100676309);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122621, XrefRangeEnd = 122701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle._StopTrafficAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrafficPuzzle._StopTrafficAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _StopTrafficAsync_d__26(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _StopTrafficAsync_d__26()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficPuzzle._StopTrafficAsync_d__26>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TrafficPuzzle __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (TrafficPuzzle) null : Il2CppObjectPool.Get<TrafficPuzzle>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr_time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr_time)) = value;
      }
    }

    public CancellationToken _token_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__token_5__2);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__token_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float _minX_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__minX_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__minX_5__3)) = value;
      }
    }

    public unsafe float _maxX_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__maxX_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__maxX_5__4)) = value;
      }
    }

    public unsafe CrowdSpawner _crowdSpawnerLeft_5__5
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__crowdSpawnerLeft_5__5));
        return num == System.IntPtr.Zero ? (CrowdSpawner) null : Il2CppObjectPool.Get<CrowdSpawner>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__crowdSpawnerLeft_5__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CrowdSpawner _crowdSpawnerRight_5__6
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__crowdSpawnerRight_5__6));
        return num == System.IntPtr.Zero ? (CrowdSpawner) null : Il2CppObjectPool.Get<CrowdSpawner>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__crowdSpawnerRight_5__6), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__7
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__timer_5__7));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr__timer_5__7)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__2
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___u__2));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrafficPuzzle._StopTrafficAsync_d__26.NativeFieldInfoPtr___u__2)) = value;
      }
    }
  }
}
