// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.WaypointPatrolSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Vehicles;

[Serializable]
public class WaypointPatrolSegment(IntPtr pointer) : MoveSegment(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_waypoint;
  private static readonly IntPtr NativeFieldInfoPtr_smoothTime;
  private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static WaypointPatrolSegment()
  {
    Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (WaypointPatrolSegment));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr);
    WaypointPatrolSegment.NativeFieldInfoPtr_waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr, nameof (waypoint));
    WaypointPatrolSegment.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr, nameof (smoothTime));
    WaypointPatrolSegment.NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr, 100673077);
    WaypointPatrolSegment.NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr, 100673078);
    WaypointPatrolSegment.NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr, 100673079);
    WaypointPatrolSegment.NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr, 100673080);
    WaypointPatrolSegment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr, 100673081);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Enter(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WaypointPatrolSegment.NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105880, XrefRangeEnd = 105881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Handle(FlyingVehicleController vehicleController, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WaypointPatrolSegment.NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105881, XrefRangeEnd = 105889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool HasEnded(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WaypointPatrolSegment.NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PlayAt(FlyingVehicleController vehicleController, float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &t;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WaypointPatrolSegment.NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaypointPatrolSegment()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaypointPatrolSegment>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaypointPatrolSegment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform waypoint
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointPatrolSegment.NativeFieldInfoPtr_waypoint));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaypointPatrolSegment.NativeFieldInfoPtr_waypoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float smoothTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointPatrolSegment.NativeFieldInfoPtr_smoothTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaypointPatrolSegment.NativeFieldInfoPtr_smoothTime)) = value;
    }
  }
}
