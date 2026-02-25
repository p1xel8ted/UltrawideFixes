// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator.InterruptMatchTarget
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
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator;

public class InterruptMatchTarget(IntPtr pointer) : BehaviorDesigner.Runtime.Tasks.Action(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_targetGameObject;
  private static readonly IntPtr NativeFieldInfoPtr_completeMatch;
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeFieldInfoPtr_prevGameObject;
  private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InterruptMatchTarget()
  {
    Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator", nameof (InterruptMatchTarget));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr);
    InterruptMatchTarget.NativeFieldInfoPtr_targetGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, nameof (targetGameObject));
    InterruptMatchTarget.NativeFieldInfoPtr_completeMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, nameof (completeMatch));
    InterruptMatchTarget.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, nameof (animator));
    InterruptMatchTarget.NativeFieldInfoPtr_prevGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, nameof (prevGameObject));
    InterruptMatchTarget.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, 100675454);
    InterruptMatchTarget.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, 100675455);
    InterruptMatchTarget.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, 100675456);
    InterruptMatchTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr, 100675457);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412439, XrefRangeEnd = 412450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InterruptMatchTarget.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412450, XrefRangeEnd = 412457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe TaskStatus OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InterruptMatchTarget.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe void OnReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InterruptMatchTarget.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412457, XrefRangeEnd = 412458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InterruptMatchTarget()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterruptMatchTarget>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InterruptMatchTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SharedGameObject targetGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_targetGameObject));
      return num == IntPtr.Zero ? (SharedGameObject) null : Il2CppObjectPool.Get<SharedGameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_targetGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool completeMatch
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_completeMatch));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_completeMatch)) = value;
    }
  }

  public unsafe Animator animator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_animator));
      return num == IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject prevGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_prevGameObject));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InterruptMatchTarget.NativeFieldInfoPtr_prevGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
