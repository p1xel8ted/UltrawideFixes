// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.PatrolBlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Vehicles;

[Serializable]
public class PatrolBlock(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MoveSegment;
  private static readonly System.IntPtr NativeFieldInfoPtr_LookSegment;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Handle_Public_Void_FlyingVehicleController_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasEnded_Public_Boolean_FlyingVehicleController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayAt_Public_Void_FlyingVehicleController_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PatrolBlock()
  {
    Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (PatrolBlock));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr);
    PatrolBlock.NativeFieldInfoPtr_MoveSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr, nameof (MoveSegment));
    PatrolBlock.NativeFieldInfoPtr_LookSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr, nameof (LookSegment));
    PatrolBlock.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr, 100673057);
    PatrolBlock.NativeMethodInfoPtr_Handle_Public_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr, 100673058);
    PatrolBlock.NativeMethodInfoPtr_HasEnded_Public_Boolean_FlyingVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr, 100673059);
    PatrolBlock.NativeMethodInfoPtr_PlayAt_Public_Void_FlyingVehicleController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr, 100673060);
    PatrolBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr, 100673061);
  }

  [CallerCount(0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PatrolBlock.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105869, XrefRangeEnd = 105870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Handle(FlyingVehicleController vehicleController, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PatrolBlock.NativeMethodInfoPtr_Handle_Public_Void_FlyingVehicleController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe bool HasEnded(FlyingVehicleController vehicleController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PatrolBlock.NativeMethodInfoPtr_HasEnded_Public_Boolean_FlyingVehicleController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105870, XrefRangeEnd = 105871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayAt(FlyingVehicleController vehicleController, float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vehicleController);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PatrolBlock.NativeMethodInfoPtr_PlayAt_Public_Void_FlyingVehicleController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PatrolBlock()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolBlock>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PatrolBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MoveSegment MoveSegment
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolBlock.NativeFieldInfoPtr_MoveSegment));
      return num == System.IntPtr.Zero ? (MoveSegment) null : Il2CppObjectPool.Get<MoveSegment>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolBlock.NativeFieldInfoPtr_MoveSegment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LookSegment LookSegment
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolBlock.NativeFieldInfoPtr_LookSegment));
      return num == System.IntPtr.Zero ? (LookSegment) null : Il2CppObjectPool.Get<LookSegment>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolBlock.NativeFieldInfoPtr_LookSegment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
