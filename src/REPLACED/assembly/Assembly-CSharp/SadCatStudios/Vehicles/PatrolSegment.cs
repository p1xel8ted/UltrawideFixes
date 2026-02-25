// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.PatrolSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Vehicles;

[Serializable]
public class PatrolSegment(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_FlyingVehicleController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_FlyingVehicleController_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasEnded_Public_Abstract_Virtual_New_Boolean_FlyingVehicleController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayAt_Public_Abstract_Virtual_New_Void_FlyingVehicleController_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static PatrolSegment()
  {
    Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (PatrolSegment));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr);
    PatrolSegment.NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr, 100673050);
    PatrolSegment.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr, 100673051);
    PatrolSegment.NativeMethodInfoPtr_HasEnded_Public_Abstract_Virtual_New_Boolean_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr, 100673052);
    PatrolSegment.NativeMethodInfoPtr_PlayAt_Public_Abstract_Virtual_New_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr, 100673053);
    PatrolSegment.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr, 100673054);
  }

  [CallerCount(0)]
  public virtual unsafe void Enter(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolSegment.NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Handle(FlyingVehicleController vehicleController, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolSegment.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool HasEnded(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolSegment.NativeMethodInfoPtr_HasEnded_Public_Abstract_Virtual_New_Boolean_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void PlayAt(FlyingVehicleController vehicleController, float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolSegment.NativeMethodInfoPtr_PlayAt_Public_Abstract_Virtual_New_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PatrolSegment()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolSegment>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PatrolSegment.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
