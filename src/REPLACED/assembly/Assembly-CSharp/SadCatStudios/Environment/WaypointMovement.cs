// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.WaypointMovement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Environment;

public class WaypointMovement(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeFieldInfoPtr_easeAmount;
  private static readonly IntPtr NativeFieldInfoPtr_movementSound;
  private static readonly IntPtr NativeFieldInfoPtr_stopSound;
  private static readonly IntPtr NativeFieldInfoPtr_callback;
  private static readonly IntPtr NativeFieldInfoPtr_movementInstance;
  private static readonly IntPtr NativeFieldInfoPtr_stopInstance;
  private static readonly IntPtr NativeFieldInfoPtr_isMoving;
  private static readonly IntPtr NativeFieldInfoPtr_startPos;
  private static readonly IntPtr NativeFieldInfoPtr_finalPos;
  private static readonly IntPtr NativeFieldInfoPtr_percentBetweenWaypoints;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_HasArrived_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CallToPoint_Public_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_CallToPoint_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveToPoint_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalculatePlatformMovement_Private_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Ease_Private_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static WaypointMovement()
  {
    Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (WaypointMovement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr);
    WaypointMovement.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (speed));
    WaypointMovement.NativeFieldInfoPtr_easeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (easeAmount));
    WaypointMovement.NativeFieldInfoPtr_movementSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (movementSound));
    WaypointMovement.NativeFieldInfoPtr_stopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (stopSound));
    WaypointMovement.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (callback));
    WaypointMovement.NativeFieldInfoPtr_movementInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (movementInstance));
    WaypointMovement.NativeFieldInfoPtr_stopInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (stopInstance));
    WaypointMovement.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (isMoving));
    WaypointMovement.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (startPos));
    WaypointMovement.NativeFieldInfoPtr_finalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (finalPos));
    WaypointMovement.NativeFieldInfoPtr_percentBetweenWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, nameof (percentBetweenWaypoints));
    WaypointMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676119);
    WaypointMovement.NativeMethodInfoPtr_get_HasArrived_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676120);
    WaypointMovement.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676121);
    WaypointMovement.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676122);
    WaypointMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676123);
    WaypointMovement.NativeMethodInfoPtr_CallToPoint_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676124);
    WaypointMovement.NativeMethodInfoPtr_CallToPoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676125);
    WaypointMovement.NativeMethodInfoPtr_MoveToPoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676126);
    WaypointMovement.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676127);
    WaypointMovement.NativeMethodInfoPtr_CalculatePlatformMovement_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676128);
    WaypointMovement.NativeMethodInfoPtr_Ease_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676129);
    WaypointMovement.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676130);
    WaypointMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr, 100676131);
  }

  public unsafe bool IsMoving
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool HasArrived
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_get_HasArrived_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121400, XrefRangeEnd = 121409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121409, XrefRangeEnd = 121413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121413, XrefRangeEnd = 121424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121424, XrefRangeEnd = 121426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CallToPoint(Transform targetPoint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetPoint)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_CallToPoint_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121426, XrefRangeEnd = 121427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CallToPoint(Vector3 targetPoint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &targetPoint
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_CallToPoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 121436, RefRangeEnd = 121438, XrefRangeStart = 121427, XrefRangeEnd = 121436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToPoint(Vector3 targetPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &targetPos
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_MoveToPoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121438, XrefRangeEnd = 121446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 121458, RefRangeEnd = 121459, XrefRangeStart = 121446, XrefRangeEnd = 121458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 CalculatePlatformMovement()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_CalculatePlatformMovement_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121459, XrefRangeEnd = 121461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Ease(float x)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &x
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_Ease_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaypointMovement()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaypointMovement>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe float easeAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_easeAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_easeAmount)) = value;
    }
  }

  public unsafe EventReference movementSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_movementSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_movementSound)) = value;
    }
  }

  public unsafe EventReference stopSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_stopSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_stopSound)) = value;
    }
  }

  public unsafe UnityEvent callback
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_callback));
      return num == IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventInstance movementInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_movementInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_movementInstance)) = value;
    }
  }

  public unsafe EventInstance stopInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_stopInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_stopInstance)) = value;
    }
  }

  public unsafe bool isMoving
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_isMoving));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_isMoving)) = value;
    }
  }

  public unsafe Vector3 startPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_startPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_startPos)) = value;
    }
  }

  public unsafe Vector3 finalPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_finalPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_finalPos)) = value;
    }
  }

  public unsafe float percentBetweenWaypoints
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_percentBetweenWaypoints));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointMovement.NativeFieldInfoPtr_percentBetweenWaypoints)) = value;
    }
  }
}
