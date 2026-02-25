// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.LookIdleSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Vehicles;

[Serializable]
public class LookIdleSegment(IntPtr pointer) : LookSegment(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_time;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LookIdleSegment()
  {
    Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (LookIdleSegment));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr);
    LookIdleSegment.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr, nameof (time));
    LookIdleSegment.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr, nameof (timer));
    LookIdleSegment.NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr, 100673067);
    LookIdleSegment.NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr, 100673068);
    LookIdleSegment.NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr, 100673069);
    LookIdleSegment.NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr, 100673070);
    LookIdleSegment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr, 100673071);
  }

  [CallerCount(0)]
  public override unsafe void Enter(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookIdleSegment.NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void Handle(FlyingVehicleController vehicleController, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookIdleSegment.NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe bool HasEnded(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookIdleSegment.NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookIdleSegment.NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LookIdleSegment()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookIdleSegment>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LookIdleSegment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float time
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookIdleSegment.NativeFieldInfoPtr_time));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookIdleSegment.NativeFieldInfoPtr_time)) = value;
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookIdleSegment.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookIdleSegment.NativeFieldInfoPtr_timer)) = value;
    }
  }
}
