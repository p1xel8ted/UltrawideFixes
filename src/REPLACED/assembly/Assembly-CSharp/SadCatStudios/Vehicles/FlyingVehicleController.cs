// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.FlyingVehicleController
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

#nullable disable
namespace SadCatStudios.Vehicles;

public class FlyingVehicleController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeFieldInfoPtr_animationSmoothTime;
  private static readonly IntPtr NativeFieldInfoPtr_animationMagnitudeFactor;
  private static readonly IntPtr NativeFieldInfoPtr_soundEvent;
  private static readonly IntPtr NativeFieldInfoPtr_velocity;
  private static readonly IntPtr NativeFieldInfoPtr_moveVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_lastPos;
  private static readonly IntPtr NativeFieldInfoPtr_targetPos;
  private static readonly IntPtr NativeFieldInfoPtr_smoothTime;
  private static readonly IntPtr NativeFieldInfoPtr_soundInstance;
  private static readonly IntPtr NativeFieldInfoPtr_Vertical;
  private static readonly IntPtr NativeFieldInfoPtr_Horizontal;
  private static readonly IntPtr NativeFieldInfoPtr_Forward;
  private static readonly IntPtr NativeFieldInfoPtr_DroneMovementFMODParam;
  private static readonly IntPtr NativeMethodInfoPtr_get_speed_Private_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MoveVelocity_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FlyingVehicleController()
  {
    Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (FlyingVehicleController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr);
    FlyingVehicleController.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (animator));
    FlyingVehicleController.NativeFieldInfoPtr_animationSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (animationSmoothTime));
    FlyingVehicleController.NativeFieldInfoPtr_animationMagnitudeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (animationMagnitudeFactor));
    FlyingVehicleController.NativeFieldInfoPtr_soundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (soundEvent));
    FlyingVehicleController.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (velocity));
    FlyingVehicleController.NativeFieldInfoPtr_moveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (moveVelocity));
    FlyingVehicleController.NativeFieldInfoPtr_lastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (lastPos));
    FlyingVehicleController.NativeFieldInfoPtr_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (targetPos));
    FlyingVehicleController.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (smoothTime));
    FlyingVehicleController.NativeFieldInfoPtr_soundInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (soundInstance));
    FlyingVehicleController.NativeFieldInfoPtr_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (Vertical));
    FlyingVehicleController.NativeFieldInfoPtr_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (Horizontal));
    FlyingVehicleController.NativeFieldInfoPtr_Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (Forward));
    FlyingVehicleController.NativeFieldInfoPtr_DroneMovementFMODParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, nameof (DroneMovementFMODParam));
    FlyingVehicleController.NativeMethodInfoPtr_get_speed_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673035);
    FlyingVehicleController.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673036);
    FlyingVehicleController.NativeMethodInfoPtr_get_MoveVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673037);
    FlyingVehicleController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673038);
    FlyingVehicleController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673039);
    FlyingVehicleController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673040);
    FlyingVehicleController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673041);
    FlyingVehicleController.NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673042);
    FlyingVehicleController.NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673043);
    FlyingVehicleController.NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673044);
    FlyingVehicleController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673045);
    FlyingVehicleController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673046);
    FlyingVehicleController.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673047);
    FlyingVehicleController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr, 100673048);
  }

  public unsafe float speed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105775, XrefRangeEnd = 105776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_get_speed_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 Velocity
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105776, XrefRangeEnd = 105778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 MoveVelocity
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_get_MoveVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105778, XrefRangeEnd = 105789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105789, XrefRangeEnd = 105792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105792, XrefRangeEnd = 105838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 105842, RefRangeEnd = 105844, XrefRangeStart = 105838, XrefRangeEnd = 105842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveTo(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &pos
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105844, RefRangeEnd = 105845, XrefRangeStart = 105844, XrefRangeEnd = 105844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveTo(Vector3 pos, float smoothTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &smoothTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105845, XrefRangeEnd = 105848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveTo(Vector3 startPos, Vector3 endPos, float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &startPos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &endPos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &t;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_MoveTo_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105850, RefRangeEnd = 105851, XrefRangeStart = 105848, XrefRangeEnd = 105850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LookAt(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &pos
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 105860, RefRangeEnd = 105868, XrefRangeStart = 105851, XrefRangeEnd = 105860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LookAt(Vector3 pos, float speed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &speed;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105868, XrefRangeEnd = 105869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlyingVehicleController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyingVehicleController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingVehicleController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Animator animator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_animator));
      return num == IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float animationSmoothTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_animationSmoothTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_animationSmoothTime)) = value;
    }
  }

  public unsafe float animationMagnitudeFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_animationMagnitudeFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_animationMagnitudeFactor)) = value;
    }
  }

  public unsafe EventReference soundEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_soundEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_soundEvent)) = value;
    }
  }

  public unsafe Vector3 velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe Vector3 moveVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_moveVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_moveVelocity)) = value;
    }
  }

  public unsafe Vector3 lastPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_lastPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_lastPos)) = value;
    }
  }

  public unsafe Vector3 targetPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_targetPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_targetPos)) = value;
    }
  }

  public unsafe float smoothTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_smoothTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_smoothTime)) = value;
    }
  }

  public unsafe EventInstance soundInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_soundInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingVehicleController.NativeFieldInfoPtr_soundInstance)) = value;
    }
  }

  public static unsafe int Vertical
  {
    get
    {
      int vertical;
      IL2CPP.il2cpp_field_static_get_value(FlyingVehicleController.NativeFieldInfoPtr_Vertical, (void*) &vertical);
      return vertical;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlyingVehicleController.NativeFieldInfoPtr_Vertical, (void*) &value);
    }
  }

  public static unsafe int Horizontal
  {
    get
    {
      int horizontal;
      IL2CPP.il2cpp_field_static_get_value(FlyingVehicleController.NativeFieldInfoPtr_Horizontal, (void*) &horizontal);
      return horizontal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlyingVehicleController.NativeFieldInfoPtr_Horizontal, (void*) &value);
    }
  }

  public static unsafe int Forward
  {
    get
    {
      int forward;
      IL2CPP.il2cpp_field_static_get_value(FlyingVehicleController.NativeFieldInfoPtr_Forward, (void*) &forward);
      return forward;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlyingVehicleController.NativeFieldInfoPtr_Forward, (void*) &value);
    }
  }

  public static unsafe string DroneMovementFMODParam
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FlyingVehicleController.NativeFieldInfoPtr_DroneMovementFMODParam, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlyingVehicleController.NativeFieldInfoPtr_DroneMovementFMODParam, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
