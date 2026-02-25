// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D.AddForce
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D;

public class AddForce(IntPtr pointer) : BehaviorDesigner.Runtime.Tasks.Action(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_targetGameObject;
  private static readonly IntPtr NativeFieldInfoPtr_force;
  private static readonly IntPtr NativeFieldInfoPtr_rigidbody2D;
  private static readonly IntPtr NativeFieldInfoPtr_prevGameObject;
  private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AddForce()
  {
    Il2CppClassPointerStore<AddForce>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D", nameof (AddForce));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddForce>.NativeClassPtr);
    AddForce.NativeFieldInfoPtr_targetGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddForce>.NativeClassPtr, nameof (targetGameObject));
    AddForce.NativeFieldInfoPtr_force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddForce>.NativeClassPtr, nameof (force));
    AddForce.NativeFieldInfoPtr_rigidbody2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddForce>.NativeClassPtr, nameof (rigidbody2D));
    AddForce.NativeFieldInfoPtr_prevGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddForce>.NativeClassPtr, nameof (prevGameObject));
    AddForce.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddForce>.NativeClassPtr, 100674442);
    AddForce.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddForce>.NativeClassPtr, 100674443);
    AddForce.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddForce>.NativeClassPtr, 100674444);
    AddForce.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddForce>.NativeClassPtr, 100674445);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407277, XrefRangeEnd = 407288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddForce.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407288, XrefRangeEnd = 407298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe TaskStatus OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddForce.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407298, XrefRangeEnd = 407301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddForce.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddForce()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddForce>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddForce.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SharedGameObject targetGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_targetGameObject));
      return num == IntPtr.Zero ? (SharedGameObject) null : Il2CppObjectPool.Get<SharedGameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_targetGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SharedVector2 force
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_force));
      return num == IntPtr.Zero ? (SharedVector2) null : Il2CppObjectPool.Get<SharedVector2>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_force), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Rigidbody2D rigidbody2D
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_rigidbody2D));
      return num == IntPtr.Zero ? (Rigidbody2D) null : Il2CppObjectPool.Get<Rigidbody2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_rigidbody2D), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject prevGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_prevGameObject));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddForce.NativeFieldInfoPtr_prevGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
