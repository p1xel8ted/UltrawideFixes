// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterHealthController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Combat;
using SadCatStudios.Quests;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterHealthController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cellPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_cellCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_recoveryPerSec;
  private static readonly System.IntPtr NativeFieldInfoPtr_recoveryDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_health;
  private static readonly System.IntPtr NativeFieldInfoPtr_currMaxHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialMaxHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_currCell;
  private static readonly System.IntPtr NativeFieldInfoPtr_recoverCoroutine;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyController;
  private static readonly System.IntPtr NativeFieldInfoPtr_cheatState;
  private static readonly System.IntPtr NativeFieldInfoPtr_HealthChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HealthPercent_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_HealthChanged_Public_add_Void_Action_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_HealthChanged_Public_rem_Void_Action_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToggleGodMode_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToggleOneHitMode_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyHealth_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCurrentAndMaxHealth_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HealToMax_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessHealth_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCell_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RecoverHealth_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDead_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterHealthController()
  {
    Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterHealthController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr);
    CharacterHealthController.NativeFieldInfoPtr_cellPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (cellPool));
    CharacterHealthController.NativeFieldInfoPtr_cellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (cellCount));
    CharacterHealthController.NativeFieldInfoPtr_recoveryPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (recoveryPerSec));
    CharacterHealthController.NativeFieldInfoPtr_recoveryDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (recoveryDelay));
    CharacterHealthController.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (health));
    CharacterHealthController.NativeFieldInfoPtr_currMaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (currMaxHealth));
    CharacterHealthController.NativeFieldInfoPtr_initialMaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (initialMaxHealth));
    CharacterHealthController.NativeFieldInfoPtr_currCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (currCell));
    CharacterHealthController.NativeFieldInfoPtr_recoverCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (recoverCoroutine));
    CharacterHealthController.NativeFieldInfoPtr_enemyController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (enemyController));
    CharacterHealthController.NativeFieldInfoPtr_cheatState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (cheatState));
    CharacterHealthController.NativeFieldInfoPtr_HealthChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, nameof (HealthChanged));
    CharacterHealthController.NativeMethodInfoPtr_get_HealthPercent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675184);
    CharacterHealthController.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675185);
    CharacterHealthController.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675186);
    CharacterHealthController.NativeMethodInfoPtr_add_HealthChanged_Public_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675187);
    CharacterHealthController.NativeMethodInfoPtr_remove_HealthChanged_Public_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675188);
    CharacterHealthController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675189);
    CharacterHealthController.NativeMethodInfoPtr_SetValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675190);
    CharacterHealthController.NativeMethodInfoPtr_Init_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675191);
    CharacterHealthController.NativeMethodInfoPtr_ToggleGodMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675192);
    CharacterHealthController.NativeMethodInfoPtr_ToggleOneHitMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675193);
    CharacterHealthController.NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675194);
    CharacterHealthController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675195);
    CharacterHealthController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675196);
    CharacterHealthController.NativeMethodInfoPtr_ApplyHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675197);
    CharacterHealthController.NativeMethodInfoPtr_UpdateCurrentAndMaxHealth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675198);
    CharacterHealthController.NativeMethodInfoPtr_HealToMax_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675199);
    CharacterHealthController.NativeMethodInfoPtr_ProcessHealth_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675200);
    CharacterHealthController.NativeMethodInfoPtr_CalculateCell_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675201);
    CharacterHealthController.NativeMethodInfoPtr_RecoverHealth_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675202);
    CharacterHealthController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675203);
    CharacterHealthController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675204);
    CharacterHealthController.NativeMethodInfoPtr_IsDead_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675205);
    CharacterHealthController.NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675206);
    CharacterHealthController.NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675207);
    CharacterHealthController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, 100675208);
  }

  public unsafe float HealthPercent
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 115861, RefRangeEnd = 115864, XrefRangeStart = 115859, XrefRangeEnd = 115861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_get_HealthPercent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float Health
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 115866, RefRangeEnd = 115876, XrefRangeStart = 115864, XrefRangeEnd = 115866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MaxHealth
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115876, XrefRangeEnd = 115881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_HealthChanged(Il2CppSystem.Action<float> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_add_HealthChanged_Public_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115886, RefRangeEnd = 115888, XrefRangeStart = 115881, XrefRangeEnd = 115886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_HealthChanged(Il2CppSystem.Action<float> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_remove_HealthChanged_Public_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115888, XrefRangeEnd = 115891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 115902, RefRangeEnd = 115914, XrefRangeStart = 115891, XrefRangeEnd = 115902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValue(float newVal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &newVal
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_SetValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115919, RefRangeEnd = 115921, XrefRangeStart = 115914, XrefRangeEnd = 115919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(float maxHealth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &maxHealth
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_Init_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ToggleGodMode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ToggleGodMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ToggleOneHitMode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ToggleOneHitMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessSentAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115921, XrefRangeEnd = 115930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnectedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115930, XrefRangeEnd = 115941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessReceivedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115943, RefRangeEnd = 115945, XrefRangeStart = 115941, XrefRangeEnd = 115943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyHealth(float delta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delta
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ApplyHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115945, XrefRangeEnd = 115949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCurrentAndMaxHealth()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_UpdateCurrentAndMaxHealth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115949, XrefRangeEnd = 115953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HealToMax()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_HealToMax_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 115958, RefRangeEnd = 115964, XrefRangeStart = 115953, XrefRangeEnd = 115958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float ProcessHealth(float delta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delta
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ProcessHealth_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115964, XrefRangeEnd = 115967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculateCell(float newHealth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &newHealth
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_CalculateCell_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115971, RefRangeEnd = 115973, XrefRangeStart = 115967, XrefRangeEnd = 115971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator RecoverHealth()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_RecoverHealth_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115973, XrefRangeEnd = 115974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnKill(DeathType deathType = DeathType.Undefined)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deathType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115982, RefRangeEnd = 115984, XrefRangeStart = 115974, XrefRangeEnd = 115982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnRespawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115985, RefRangeEnd = 115986, XrefRangeStart = 115984, XrefRangeEnd = 115985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsDead()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_IsDead_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115986, XrefRangeEnd = 115990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Upgrade(string upgradedValue, UpgradeConfig config)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(upgradedValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) config);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115990, XrefRangeEnd = 115994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ResetUpgrades()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115994, XrefRangeEnd = 115995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterHealthController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealthController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference cellPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_cellPool));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_cellPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference cellCount
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_cellCount));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_cellCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference recoveryPerSec
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_recoveryPerSec));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_recoveryPerSec), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference recoveryDelay
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_recoveryDelay));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_recoveryDelay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference health
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_health));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_health), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float currMaxHealth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_currMaxHealth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_currMaxHealth)) = value;
    }
  }

  public unsafe float initialMaxHealth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_initialMaxHealth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_initialMaxHealth)) = value;
    }
  }

  public unsafe int currCell
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_currCell));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_currCell)) = value;
    }
  }

  public unsafe Coroutine recoverCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_recoverCoroutine));
      return num == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_recoverCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnemyCombatController enemyController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_enemyController));
      return num == System.IntPtr.Zero ? (EnemyCombatController) null : Il2CppObjectPool.Get<EnemyCombatController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_enemyController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CheatState cheatState
  {
    get
    {
      return *(CheatState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_cheatState));
    }
    [param: In] set
    {
      *(CheatState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_cheatState)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<float> HealthChanged
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_HealthChanged));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController.NativeFieldInfoPtr_HealthChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterHealthController+<RecoverHealth>d__33")]
  public sealed class _RecoverHealth_d__33(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _RecoverHealth_d__33()
    {
      Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHealthController>.NativeClassPtr, "<RecoverHealth>d__33");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr);
      CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, "<>1__state");
      CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, "<>2__current");
      CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, "<>4__this");
      CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, "<timer>5__2");
      CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, 100675209);
      CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, 100675210);
      CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, 100675211);
      CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, 100675212);
      CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, 100675213);
      CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr, 100675214);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _RecoverHealth_d__33(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHealthController._RecoverHealth_d__33>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115846, XrefRangeEnd = 115854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115854, XrefRangeEnd = 115859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealthController._RecoverHealth_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHealthController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealthController._RecoverHealth_d__33.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }
}
