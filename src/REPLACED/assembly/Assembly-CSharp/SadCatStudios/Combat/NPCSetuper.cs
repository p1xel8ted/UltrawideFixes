// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.NPCSetuper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class NPCSetuper(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_idleContainer;
  private static readonly IntPtr NativeFieldInfoPtr_idleGraph;
  private static readonly IntPtr NativeFieldInfoPtr_renderers;
  private static readonly IntPtr NativeFieldInfoPtr_outsideEnemy;
  private static readonly IntPtr NativeFieldInfoPtr_outsideTeleport;
  private static readonly IntPtr NativeFieldInfoPtr_visibleOnBackline;
  private static readonly IntPtr NativeFieldInfoPtr_combatZoneCollider;
  private static readonly IntPtr NativeFieldInfoPtr_enemyCollider;
  private static readonly IntPtr NativeFieldInfoPtr_enemyHurtbox;
  private static readonly IntPtr NativeFieldInfoPtr_enemyPhysics;
  private static readonly IntPtr NativeFieldInfoPtr_replaceEnemy;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_animationController;
  private static readonly IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly IntPtr NativeMethodInfoPtr_get_IdleGraph_Public_get_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_OutsideEnemy_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetuperActivate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetuperReset_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RandomizeSetup_Public_Void_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_TurnAround_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_InitCalmIdle_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CombatIdles_Private_List_1_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static NPCSetuper()
  {
    Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (NPCSetuper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr);
    NPCSetuper.NativeFieldInfoPtr_idleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (idleContainer));
    NPCSetuper.NativeFieldInfoPtr_idleGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (idleGraph));
    NPCSetuper.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (renderers));
    NPCSetuper.NativeFieldInfoPtr_outsideEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (outsideEnemy));
    NPCSetuper.NativeFieldInfoPtr_outsideTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (outsideTeleport));
    NPCSetuper.NativeFieldInfoPtr_visibleOnBackline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (visibleOnBackline));
    NPCSetuper.NativeFieldInfoPtr_combatZoneCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (combatZoneCollider));
    NPCSetuper.NativeFieldInfoPtr_enemyCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (enemyCollider));
    NPCSetuper.NativeFieldInfoPtr_enemyHurtbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (enemyHurtbox));
    NPCSetuper.NativeFieldInfoPtr_enemyPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (enemyPhysics));
    NPCSetuper.NativeFieldInfoPtr_replaceEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (replaceEnemy));
    NPCSetuper.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (rotationController));
    NPCSetuper.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (animationController));
    NPCSetuper.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, nameof (hitboxController));
    NPCSetuper.NativeMethodInfoPtr_get_IdleGraph_Public_get_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677730);
    NPCSetuper.NativeMethodInfoPtr_get_OutsideEnemy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677731);
    NPCSetuper.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677732);
    NPCSetuper.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677733);
    NPCSetuper.NativeMethodInfoPtr_SetuperActivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677734);
    NPCSetuper.NativeMethodInfoPtr_SetuperReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677735);
    NPCSetuper.NativeMethodInfoPtr_RandomizeSetup_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677736);
    NPCSetuper.NativeMethodInfoPtr_TurnAround_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677737);
    NPCSetuper.NativeMethodInfoPtr_InitCalmIdle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677738);
    NPCSetuper.NativeMethodInfoPtr_CombatIdles_Private_List_1_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677739);
    NPCSetuper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr, 100677740);
  }

  public unsafe FSMGraph IdleGraph
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_get_IdleGraph_Public_get_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
    }
  }

  public unsafe bool OutsideEnemy
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_get_OutsideEnemy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131125, XrefRangeEnd = 131143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131143, XrefRangeEnd = 131149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131173, RefRangeEnd = 131174, XrefRangeStart = 131149, XrefRangeEnd = 131173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetuperActivate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_SetuperActivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131174, XrefRangeEnd = 131179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetuperReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_SetuperReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131179, XrefRangeEnd = 131199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RandomizeSetup(bool outsideEnemy, bool teleport = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &outsideEnemy;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &teleport;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_RandomizeSetup_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131199, XrefRangeEnd = 131201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnAround()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_TurnAround_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131201, XrefRangeEnd = 131208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitCalmIdle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_InitCalmIdle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131208, XrefRangeEnd = 131212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<FSMGraph> CombatIdles()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr_CombatIdles_Private_List_1_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (List<FSMGraph>) null : Il2CppObjectPool.Get<List<FSMGraph>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131212, XrefRangeEnd = 131213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NPCSetuper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSetuper>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NPCSetuper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CombatIdleContainer idleContainer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_idleContainer));
      return num == IntPtr.Zero ? (CombatIdleContainer) null : Il2CppObjectPool.Get<CombatIdleContainer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_idleContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph idleGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_idleGraph));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_idleGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Renderer> renderers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_renderers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Renderer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool outsideEnemy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_outsideEnemy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_outsideEnemy)) = value;
    }
  }

  public unsafe bool outsideTeleport
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_outsideTeleport));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_outsideTeleport)) = value;
    }
  }

  public unsafe bool visibleOnBackline
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_visibleOnBackline));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_visibleOnBackline)) = value;
    }
  }

  public unsafe Collider combatZoneCollider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_combatZoneCollider));
      return num == IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_combatZoneCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider enemyCollider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_enemyCollider));
      return num == IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_enemyCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider enemyHurtbox
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_enemyHurtbox));
      return num == IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_enemyHurtbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PersonPhysics enemyPhysics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_enemyPhysics));
      return num == IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_enemyPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe NPCSetuper replaceEnemy
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_replaceEnemy));
      return num == IntPtr.Zero ? (NPCSetuper) null : Il2CppObjectPool.Get<NPCSetuper>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_replaceEnemy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_animationController));
      return num == IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_hitboxController));
      return num == IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCSetuper.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
