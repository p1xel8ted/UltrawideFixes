// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.BasicActions.CurvedVerticalMotionAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Actions.BasicActions;

public class CurvedVerticalMotionAction(IntPtr pointer) : ActionObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_motionNode;
  private static readonly IntPtr NativeFieldInfoPtr_walkController;
  private static readonly IntPtr NativeFieldInfoPtr_animationController;
  private static readonly IntPtr NativeFieldInfoPtr_transform;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeFieldInfoPtr_duration;
  private static readonly IntPtr NativeFieldInfoPtr_start;
  private static readonly IntPtr NativeFieldInfoPtr_prev;
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_curvePerc;
  private static readonly IntPtr NativeFieldInfoPtr_started;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Act_Public_Virtual_Void_0;

  static CurvedVerticalMotionAction()
  {
    Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.BasicActions", nameof (CurvedVerticalMotionAction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr);
    CurvedVerticalMotionAction.NativeFieldInfoPtr_motionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (motionNode));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (walkController));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (animationController));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (transform));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (timer));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (duration));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (start));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (prev));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (target));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_curvePerc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (curvePerc));
    CurvedVerticalMotionAction.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, nameof (started));
    CurvedVerticalMotionAction.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, 100674460);
    CurvedVerticalMotionAction.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, 100674461);
    CurvedVerticalMotionAction.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, 100674462);
    CurvedVerticalMotionAction.NativeMethodInfoPtr_Act_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr, 100674463);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 111071, RefRangeEnd = 111074, XrefRangeStart = 111071, XrefRangeEnd = 111074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurvedVerticalMotionAction(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedVerticalMotionAction>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CurvedVerticalMotionAction.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112115, XrefRangeEnd = 112125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedVerticalMotionAction.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112125, XrefRangeEnd = 112131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedVerticalMotionAction.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112131, XrefRangeEnd = 112137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Act()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedVerticalMotionAction.NativeMethodInfoPtr_Act_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CurvedVerticalMotionActionNode motionNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_motionNode));
      return num == IntPtr.Zero ? (CurvedVerticalMotionActionNode) null : Il2CppObjectPool.Get<CurvedVerticalMotionActionNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_motionNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_walkController));
      return num == IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_animationController));
      return num == IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform transform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_transform));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_timer)) = value;
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe float start
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_start));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_start)) = value;
    }
  }

  public unsafe float prev
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_prev));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_prev)) = value;
    }
  }

  public unsafe float target
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_target));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_target)) = value;
    }
  }

  public unsafe float curvePerc
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_curvePerc));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_curvePerc)) = value;
    }
  }

  public unsafe bool started
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_started));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedVerticalMotionAction.NativeFieldInfoPtr_started)) = value;
    }
  }
}
