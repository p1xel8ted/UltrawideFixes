// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.OverrideStateZoneTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Triggers;

public class OverrideStateZoneTrigger(IntPtr pointer) : ZoneTrigger(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_stateOverride;
  private static readonly IntPtr NativeFieldInfoPtr_enterFromIdle;
  private static readonly IntPtr NativeFieldInfoPtr_abilityController;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnterCallback_Protected_Virtual_Void_Collider_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnExitCallback_Protected_Virtual_Void_Collider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OverrideStateZoneTrigger()
  {
    Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (OverrideStateZoneTrigger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr);
    OverrideStateZoneTrigger.NativeFieldInfoPtr_stateOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr, nameof (stateOverride));
    OverrideStateZoneTrigger.NativeFieldInfoPtr_enterFromIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr, nameof (enterFromIdle));
    OverrideStateZoneTrigger.NativeFieldInfoPtr_abilityController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr, nameof (abilityController));
    OverrideStateZoneTrigger.NativeMethodInfoPtr_OnEnterCallback_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr, 100671833);
    OverrideStateZoneTrigger.NativeMethodInfoPtr_OnExitCallback_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr, 100671834);
    OverrideStateZoneTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr, 100671835);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96504, XrefRangeEnd = 96514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnterCallback(Collider playerCollider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerCollider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OverrideStateZoneTrigger.NativeMethodInfoPtr_OnEnterCallback_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96514, XrefRangeEnd = 96519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnExitCallback(Collider playerCollider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerCollider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OverrideStateZoneTrigger.NativeMethodInfoPtr_OnExitCallback_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OverrideStateZoneTrigger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideStateZoneTrigger>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OverrideStateZoneTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StateOverride stateOverride
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverrideStateZoneTrigger.NativeFieldInfoPtr_stateOverride));
      return num == IntPtr.Zero ? (StateOverride) null : Il2CppObjectPool.Get<StateOverride>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OverrideStateZoneTrigger.NativeFieldInfoPtr_stateOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool enterFromIdle
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverrideStateZoneTrigger.NativeFieldInfoPtr_enterFromIdle));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverrideStateZoneTrigger.NativeFieldInfoPtr_enterFromIdle)) = value;
    }
  }

  public unsafe AbilityStateController abilityController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverrideStateZoneTrigger.NativeFieldInfoPtr_abilityController));
      return num == IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OverrideStateZoneTrigger.NativeFieldInfoPtr_abilityController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
