// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterDeathController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Combat;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterDeathController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_deathTypeDictionary;
  private static readonly IntPtr NativeFieldInfoPtr_deathState;
  private static readonly IntPtr NativeFieldInfoPtr_deathHandlers;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_healthController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_isDead;
  private static readonly IntPtr NativeFieldInfoPtr_debugMode;
  private static readonly IntPtr NativeFieldInfoPtr_killConfirm;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_KillConfirm_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDead_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetDeath_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToggleDebugMode_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterDeathController()
  {
    Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterDeathController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr);
    CharacterDeathController.NativeFieldInfoPtr_deathTypeDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (deathTypeDictionary));
    CharacterDeathController.NativeFieldInfoPtr_deathState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (deathState));
    CharacterDeathController.NativeFieldInfoPtr_deathHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (deathHandlers));
    CharacterDeathController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (stateController));
    CharacterDeathController.NativeFieldInfoPtr_healthController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (healthController));
    CharacterDeathController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (rotationController));
    CharacterDeathController.NativeFieldInfoPtr_isDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (isDead));
    CharacterDeathController.NativeFieldInfoPtr_debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (debugMode));
    CharacterDeathController.NativeFieldInfoPtr_killConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, nameof (killConfirm));
    CharacterDeathController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674977);
    CharacterDeathController.NativeMethodInfoPtr_get_KillConfirm_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674978);
    CharacterDeathController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674979);
    CharacterDeathController.NativeMethodInfoPtr_SetDead_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674980);
    CharacterDeathController.NativeMethodInfoPtr_ResetDeath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674981);
    CharacterDeathController.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674982);
    CharacterDeathController.NativeMethodInfoPtr_ToggleDebugMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674983);
    CharacterDeathController.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674984);
    CharacterDeathController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674985);
    CharacterDeathController.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674986);
    CharacterDeathController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr, 100674987);
  }

  public unsafe bool IsDead
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool KillConfirm
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_get_KillConfirm_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114454, XrefRangeEnd = 114466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 114466, RefRangeEnd = 114468, XrefRangeStart = 114466, XrefRangeEnd = 114466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDead()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_SetDead_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 109810, RefRangeEnd = 109812, XrefRangeStart = 109810, XrefRangeEnd = 109812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetDeath()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_ResetDeath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 114483, RefRangeEnd = 114489, XrefRangeStart = 114468, XrefRangeEnd = 114483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Kill(DeathType deathType = DeathType.Undefined)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &deathType
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ToggleDebugMode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_ToggleDebugMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114496, XrefRangeStart = 114489, XrefRangeEnd = 114494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Respawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114496, XrefRangeEnd = 114497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114497, XrefRangeEnd = 114508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnection(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114508, XrefRangeEnd = 114515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterDeathController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDeathController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeathController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DeathTypeDictionary deathTypeDictionary
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_deathTypeDictionary));
      return num == IntPtr.Zero ? (DeathTypeDictionary) null : Il2CppObjectPool.Get<DeathTypeDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_deathTypeDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State deathState
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_deathState));
      return num == IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_deathState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IDeathHandler> deathHandlers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_deathHandlers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<IDeathHandler>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IDeathHandler>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_deathHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHealthController healthController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_healthController));
      return num == IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_healthController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isDead
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_isDead));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_isDead)) = value;
    }
  }

  public unsafe bool debugMode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_debugMode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_debugMode)) = value;
    }
  }

  public unsafe bool killConfirm
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_killConfirm));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeathController.NativeFieldInfoPtr_killConfirm)) = value;
    }
  }
}
