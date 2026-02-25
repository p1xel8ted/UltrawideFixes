// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterMeleeHitReceiveHandler
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

public class CharacterMeleeHitReceiveHandler(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_hitGraphs;
  private static readonly IntPtr NativeFieldInfoPtr_shouldRotateTowardsSender;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_poiseController;
  private static readonly IntPtr NativeFieldInfoPtr_boundariesController;
  private static readonly IntPtr NativeFieldInfoPtr_lastAttack;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastAttack_Public_get_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterMeleeHitReceiveHandler()
  {
    Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterMeleeHitReceiveHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr);
    CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_hitGraphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, nameof (hitGraphs));
    CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_shouldRotateTowardsSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, nameof (shouldRotateTowardsSender));
    CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, nameof (stateController));
    CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, nameof (rotationController));
    CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_poiseController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, nameof (poiseController));
    CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_boundariesController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, nameof (boundariesController));
    CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_lastAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, nameof (lastAttack));
    CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_get_LastAttack_Public_get_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, 100677575);
    CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, 100677576);
    CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, 100677577);
    CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, 100677578);
    CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr, 100677579);
  }

  public unsafe AttackObject LastAttack
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_get_LastAttack_Public_get_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130693, XrefRangeEnd = 130705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130705, XrefRangeEnd = 130706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130706, XrefRangeEnd = 130710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnection(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterMeleeHitReceiveHandler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMeleeHitReceiveHandler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeHitReceiveHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<FSMGraph> hitGraphs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_hitGraphs));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<FSMGraph>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<FSMGraph>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_hitGraphs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool shouldRotateTowardsSender
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_shouldRotateTowardsSender));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_shouldRotateTowardsSender)) = value;
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterPoiseController poiseController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_poiseController));
      return num == IntPtr.Zero ? (CharacterPoiseController) null : Il2CppObjectPool.Get<CharacterPoiseController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_poiseController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterBoundariesController boundariesController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_boundariesController));
      return num == IntPtr.Zero ? (CharacterBoundariesController) null : Il2CppObjectPool.Get<CharacterBoundariesController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_boundariesController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject lastAttack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_lastAttack));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeHitReceiveHandler.NativeFieldInfoPtr_lastAttack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
