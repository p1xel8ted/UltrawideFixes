// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Cooldown
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks;

public class Cooldown(IntPtr pointer) : Decorator(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_duration;
  private static readonly IntPtr NativeFieldInfoPtr_executionStatus;
  private static readonly IntPtr NativeFieldInfoPtr_cooldownTime;
  private static readonly IntPtr NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Cooldown()
  {
    Il2CppClassPointerStore<Cooldown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks", nameof (Cooldown));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cooldown>.NativeClassPtr);
    Cooldown.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, nameof (duration));
    Cooldown.NativeFieldInfoPtr_executionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, nameof (executionStatus));
    Cooldown.NativeFieldInfoPtr_cooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, nameof (cooldownTime));
    Cooldown.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, 100673970);
    Cooldown.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, 100673971);
    Cooldown.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, 100673972);
    Cooldown.NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, 100673973);
    Cooldown.NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, 100673974);
    Cooldown.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, 100673975);
    Cooldown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooldown>.NativeClassPtr, 100673976);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405125, XrefRangeEnd = 405126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanExecute()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cooldown.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe int CurrentChildIndex()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cooldown.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405126, XrefRangeEnd = 405127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnChildExecuted(TaskStatus childStatus)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &childStatus
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cooldown.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe TaskStatus OverrideStatus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cooldown.NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe TaskStatus OverrideStatus(TaskStatus status)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &status
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cooldown.NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe void OnEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Cooldown.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405127, XrefRangeEnd = 405129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cooldown()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cooldown>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cooldown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SharedFloat duration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cooldown.NativeFieldInfoPtr_duration));
      return num == IntPtr.Zero ? (SharedFloat) null : Il2CppObjectPool.Get<SharedFloat>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Cooldown.NativeFieldInfoPtr_duration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TaskStatus executionStatus
  {
    get
    {
      return *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cooldown.NativeFieldInfoPtr_executionStatus));
    }
    [param: In] set
    {
      *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cooldown.NativeFieldInfoPtr_executionStatus)) = value;
    }
  }

  public unsafe float cooldownTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cooldown.NativeFieldInfoPtr_cooldownTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cooldown.NativeFieldInfoPtr_cooldownTime)) = value;
    }
  }
}
