// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.LedgeActions.SnapToGroundAction
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
namespace SadCatStudios.FSM.Actions.LedgeActions;

public class SnapToGroundAction(IntPtr pointer) : ActionObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_skinWidth;
  private static readonly IntPtr NativeFieldInfoPtr_snapRadius;
  private static readonly IntPtr NativeFieldInfoPtr_snapNode;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly IntPtr NativeFieldInfoPtr_transform;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Act_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SnapToGroundSphereCast_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SnapToGroundRaycast_Private_Void_0;

  static SnapToGroundAction()
  {
    Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.LedgeActions", nameof (SnapToGroundAction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr);
    SnapToGroundAction.NativeFieldInfoPtr_skinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, nameof (skinWidth));
    SnapToGroundAction.NativeFieldInfoPtr_snapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, nameof (snapRadius));
    SnapToGroundAction.NativeFieldInfoPtr_snapNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, nameof (snapNode));
    SnapToGroundAction.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, nameof (rotationController));
    SnapToGroundAction.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, nameof (personPhysics));
    SnapToGroundAction.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, nameof (transform));
    SnapToGroundAction.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, 100673910);
    SnapToGroundAction.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, 100673911);
    SnapToGroundAction.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, 100673912);
    SnapToGroundAction.NativeMethodInfoPtr_Exit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, 100673913);
    SnapToGroundAction.NativeMethodInfoPtr_Act_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, 100673914);
    SnapToGroundAction.NativeMethodInfoPtr_SnapToGroundSphereCast_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, 100673915);
    SnapToGroundAction.NativeMethodInfoPtr_SnapToGroundRaycast_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr, 100673916);
  }

  [CallerCount(173)]
  [CachedScanResults(RefRangeStart = 108560, RefRangeEnd = 108733, XrefRangeStart = 108560, XrefRangeEnd = 108733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SnapToGroundAction(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnapToGroundAction>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SnapToGroundAction.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110782, XrefRangeEnd = 110794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SnapToGroundAction.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110794, XrefRangeEnd = 110795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SnapToGroundAction.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110795, XrefRangeEnd = 110796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Exit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SnapToGroundAction.NativeMethodInfoPtr_Exit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110796, XrefRangeEnd = 110797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Act()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SnapToGroundAction.NativeMethodInfoPtr_Act_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110818, RefRangeEnd = 110820, XrefRangeStart = 110797, XrefRangeEnd = 110818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SnapToGroundSphereCast()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SnapToGroundAction.NativeMethodInfoPtr_SnapToGroundSphereCast_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110841, RefRangeEnd = 110842, XrefRangeStart = 110820, XrefRangeEnd = 110841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SnapToGroundRaycast()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SnapToGroundAction.NativeMethodInfoPtr_SnapToGroundRaycast_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float skinWidth
  {
    get
    {
      float skinWidth;
      IL2CPP.il2cpp_field_static_get_value(SnapToGroundAction.NativeFieldInfoPtr_skinWidth, (void*) &skinWidth);
      return skinWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SnapToGroundAction.NativeFieldInfoPtr_skinWidth, (void*) &value);
    }
  }

  public static unsafe float snapRadius
  {
    get
    {
      float snapRadius;
      IL2CPP.il2cpp_field_static_get_value(SnapToGroundAction.NativeFieldInfoPtr_snapRadius, (void*) &snapRadius);
      return snapRadius;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SnapToGroundAction.NativeFieldInfoPtr_snapRadius, (void*) &value);
    }
  }

  public unsafe SnapToGroundActionNode snapNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_snapNode));
      return num == IntPtr.Zero ? (SnapToGroundActionNode) null : Il2CppObjectPool.Get<SnapToGroundActionNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_snapNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_personPhysics));
      return num == IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform transform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_transform));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnapToGroundAction.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
