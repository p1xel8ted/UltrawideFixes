// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.BasicActions.HorizontalMovementActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Actions.BasicActions;

public class HorizontalMovementActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeFieldInfoPtr_speedCurve;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreColliders;
  private static readonly IntPtr NativeFieldInfoPtr_safetyMeasures;
  private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpeedCurve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreColliders_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SafetyMeasures_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static HorizontalMovementActionNode()
  {
    Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.BasicActions", nameof (HorizontalMovementActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr);
    HorizontalMovementActionNode.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, nameof (speed));
    HorizontalMovementActionNode.NativeFieldInfoPtr_speedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, nameof (speedCurve));
    HorizontalMovementActionNode.NativeFieldInfoPtr_ignoreColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, nameof (ignoreColliders));
    HorizontalMovementActionNode.NativeFieldInfoPtr_safetyMeasures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, nameof (safetyMeasures));
    HorizontalMovementActionNode.NativeMethodInfoPtr_get_Speed_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, 100674486);
    HorizontalMovementActionNode.NativeMethodInfoPtr_get_SpeedCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, 100674487);
    HorizontalMovementActionNode.NativeMethodInfoPtr_get_IgnoreColliders_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, 100674488);
    HorizontalMovementActionNode.NativeMethodInfoPtr_get_SafetyMeasures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, 100674489);
    HorizontalMovementActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, 100674490);
    HorizontalMovementActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr, 100674491);
  }

  public unsafe FloatReference Speed
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HorizontalMovementActionNode.NativeMethodInfoPtr_get_Speed_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe AnimationCurve SpeedCurve
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HorizontalMovementActionNode.NativeMethodInfoPtr_get_SpeedCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe bool IgnoreColliders
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HorizontalMovementActionNode.NativeMethodInfoPtr_get_IgnoreColliders_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool SafetyMeasures
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HorizontalMovementActionNode.NativeMethodInfoPtr_get_SafetyMeasures_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112193, XrefRangeEnd = 112197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HorizontalMovementActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112197, XrefRangeEnd = 112198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HorizontalMovementActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalMovementActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HorizontalMovementActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference speed
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_speed));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_speed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve speedCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_speedCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_speedCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ignoreColliders
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_ignoreColliders));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_ignoreColliders)) = value;
    }
  }

  public unsafe bool safetyMeasures
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_safetyMeasures));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalMovementActionNode.NativeFieldInfoPtr_safetyMeasures)) = value;
    }
  }
}
