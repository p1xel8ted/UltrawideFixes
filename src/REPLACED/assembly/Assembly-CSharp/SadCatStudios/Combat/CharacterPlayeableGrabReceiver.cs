// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterPlayeableGrabReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterPlayeableGrabReceiver(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_animationController;
  private static readonly IntPtr NativeFieldInfoPtr_connectedGrabSender;
  private static readonly IntPtr NativeFieldInfoPtr_deathTracker;
  private static readonly IntPtr NativeFieldInfoPtr_deathController;
  private static readonly IntPtr NativeFieldInfoPtr_combatStats;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanBeGrabbed_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ConnectGrab_Public_Virtual_Final_New_Void_IGrabSender_GrabCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResolveConnection_Public_Virtual_Final_New_Void_GrabConnectionType_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveLaunch_Public_Virtual_Final_New_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_BreakGrab_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearConnection_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchFSM_Public_Virtual_Final_New_Void_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ReceiveAttack_b__11_0_Private_Void_0;

  static CharacterPlayeableGrabReceiver()
  {
    Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterPlayeableGrabReceiver));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr);
    CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, nameof (stateController));
    CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, nameof (rotationController));
    CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, nameof (animationController));
    CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_connectedGrabSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, nameof (connectedGrabSender));
    CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_deathTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, nameof (deathTracker));
    CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_deathController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, nameof (deathController));
    CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_combatStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, nameof (combatStats));
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677244);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_CanBeGrabbed_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677245);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ConnectGrab_Public_Virtual_Final_New_Void_IGrabSender_GrabCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677246);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ResolveConnection_Public_Virtual_Final_New_Void_GrabConnectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677247);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ReceiveAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677248);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ReceiveLaunch_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677249);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_BreakGrab_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677250);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ClearConnection_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677251);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_SwitchFSM_Public_Virtual_Final_New_Void_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677252);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677253);
    CharacterPlayeableGrabReceiver.NativeMethodInfoPtr__ReceiveAttack_b__11_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr, 100677254);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129110, XrefRangeEnd = 129128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CanBeGrabbed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_CanBeGrabbed_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129128, XrefRangeEnd = 129130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ConnectGrab(IGrabSender grabSender, GrabCastResult grabCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) grabSender);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) grabCastResult));
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ConnectGrab_Public_Virtual_Final_New_Void_IGrabSender_GrabCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ResolveConnection(GrabConnectionType connectionType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &connectionType
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ResolveConnection_Public_Virtual_Final_New_Void_GrabConnectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129130, XrefRangeEnd = 129145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReceiveAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ReceiveAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129145, XrefRangeEnd = 129146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReceiveLaunch(bool turnAround)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &turnAround
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ReceiveLaunch_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void BreakGrab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_BreakGrab_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ClearConnection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_ClearConnection_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void SwitchFSM(FSMGraph graph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graph)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr_SwitchFSM_Public_Virtual_Final_New_Void_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterPlayeableGrabReceiver()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPlayeableGrabReceiver>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129146, XrefRangeEnd = 129152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _ReceiveAttack_b__11_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPlayeableGrabReceiver.NativeMethodInfoPtr__ReceiveAttack_b__11_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_animationController));
      return num == IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IGrabSender connectedGrabSender
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_connectedGrabSender));
      return num == IntPtr.Zero ? (IGrabSender) null : Il2CppObjectPool.Get<IGrabSender>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_connectedGrabSender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IDeathTracker deathTracker
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_deathTracker));
      return num == IntPtr.Zero ? (IDeathTracker) null : Il2CppObjectPool.Get<IDeathTracker>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_deathTracker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IDeathController deathController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_deathController));
      return num == IntPtr.Zero ? (IDeathController) null : Il2CppObjectPool.Get<IDeathController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_deathController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ICombatStatsController> combatStats
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_combatStats));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ICombatStatsController>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ICombatStatsController>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPlayeableGrabReceiver.NativeFieldInfoPtr_combatStats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
