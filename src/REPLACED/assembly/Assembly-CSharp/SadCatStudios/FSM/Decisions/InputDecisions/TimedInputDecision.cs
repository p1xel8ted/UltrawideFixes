// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.InputDecisions.TimedInputDecision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Decisions.InputDecisions;

public class TimedInputDecision(IntPtr pointer) : DecisionObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_timedNode;
  private static readonly IntPtr NativeFieldInfoPtr_walkController;
  private static readonly IntPtr NativeFieldInfoPtr_physics;
  private static readonly IntPtr NativeFieldInfoPtr_transform;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeFieldInfoPtr_dir;
  private static readonly IntPtr NativeFieldInfoPtr_ray;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0;

  static TimedInputDecision()
  {
    Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.InputDecisions", nameof (TimedInputDecision));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr);
    TimedInputDecision.NativeFieldInfoPtr_timedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, nameof (timedNode));
    TimedInputDecision.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, nameof (walkController));
    TimedInputDecision.NativeFieldInfoPtr_physics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, nameof (physics));
    TimedInputDecision.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, nameof (transform));
    TimedInputDecision.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, nameof (timer));
    TimedInputDecision.NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, nameof (dir));
    TimedInputDecision.NativeFieldInfoPtr_ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, nameof (ray));
    TimedInputDecision.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, 100673530);
    TimedInputDecision.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, 100673531);
    TimedInputDecision.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, 100673532);
    TimedInputDecision.NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr, 100673533);
  }

  [CallerCount(173)]
  [CachedScanResults(RefRangeStart = 108560, RefRangeEnd = 108733, XrefRangeStart = 108560, XrefRangeEnd = 108733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TimedInputDecision(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedInputDecision>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimedInputDecision.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109905, XrefRangeEnd = 109915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TimedInputDecision.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TimedInputDecision.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109915, XrefRangeEnd = 109927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Reason()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TimedInputDecision.NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe TimedInputDecisionNode timedNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_timedNode));
      return num == IntPtr.Zero ? (TimedInputDecisionNode) null : Il2CppObjectPool.Get<TimedInputDecisionNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_timedNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_walkController));
      return num == IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PersonPhysics physics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_physics));
      return num == IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_physics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform transform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_transform));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_timer)) = value;
    }
  }

  public unsafe float dir
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_dir));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_dir)) = value;
    }
  }

  public unsafe Ray ray
  {
    get
    {
      return *(Ray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_ray));
    }
    [param: In] set
    {
      *(Ray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecision.NativeFieldInfoPtr_ray)) = value;
    }
  }
}
