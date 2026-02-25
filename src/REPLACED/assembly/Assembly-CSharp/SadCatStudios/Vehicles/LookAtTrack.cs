// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.LookAtTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Vehicles;

[Serializable]
public class LookAtTrack(IntPtr pointer) : LookSegment(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_lookPath;
  private static readonly IntPtr NativeFieldInfoPtr_trackTime;
  private static readonly IntPtr NativeFieldInfoPtr_mirror;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LookAtTrack()
  {
    Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (LookAtTrack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr);
    LookAtTrack.NativeFieldInfoPtr_lookPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, nameof (lookPath));
    LookAtTrack.NativeFieldInfoPtr_trackTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, nameof (trackTime));
    LookAtTrack.NativeFieldInfoPtr_mirror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, nameof (mirror));
    LookAtTrack.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, nameof (timer));
    LookAtTrack.NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, 100673082);
    LookAtTrack.NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, 100673083);
    LookAtTrack.NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, 100673084);
    LookAtTrack.NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, 100673085);
    LookAtTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr, 100673086);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105889, RefRangeEnd = 105890, XrefRangeStart = 105889, XrefRangeEnd = 105889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Enter(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookAtTrack.NativeMethodInfoPtr_Enter_Public_Virtual_Void_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105890, XrefRangeEnd = 105893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Handle(FlyingVehicleController vehicleController, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookAtTrack.NativeMethodInfoPtr_Handle_Public_Virtual_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookAtTrack.NativeMethodInfoPtr_HasEnded_Public_Virtual_Boolean_FlyingVehicleController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105893, XrefRangeEnd = 105894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PlayAt(FlyingVehicleController vehicleController, float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &t;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookAtTrack.NativeMethodInfoPtr_PlayAt_Public_Virtual_Void_FlyingVehicleController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LookAtTrack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtTrack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LookAtTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineSmoothPath lookPath
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_lookPath));
      return num == IntPtr.Zero ? (CinemachineSmoothPath) null : Il2CppObjectPool.Get<CinemachineSmoothPath>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_lookPath), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float trackTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_trackTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_trackTime)) = value;
    }
  }

  public unsafe bool mirror
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_mirror));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_mirror)) = value;
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtTrack.NativeFieldInfoPtr_timer)) = value;
    }
  }
}
