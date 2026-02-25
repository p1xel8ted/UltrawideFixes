// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterHealingAbilityController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using FMODUnity;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Combat;
using SadCatStudios.Foundation;
using SadCatStudios.Foundation.Events;
using SadCatStudios.Quests;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterHealingAbilityController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_healingData;
  private static readonly System.IntPtr NativeFieldInfoPtr_healingReadyPercentage;
  private static readonly System.IntPtr NativeFieldInfoPtr_healingSlots;
  private static readonly System.IntPtr NativeFieldInfoPtr_healPromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialTargetCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialHealthThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_healingSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_autoHealUsed;
  private static readonly System.IntPtr NativeFieldInfoPtr_healthController;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseHealingData;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialShown;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FastHealingAvailable_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefillOnCombatState_Private_Void_GameStateChangedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefillHealingSlots_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHealingSlots_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanHeal_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Heal_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessReadyPercentage_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForHealing_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterHealingAbilityController()
  {
    Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterHealingAbilityController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr);
    CharacterHealingAbilityController.NativeFieldInfoPtr_healingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (healingData));
    CharacterHealingAbilityController.NativeFieldInfoPtr_healingReadyPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (healingReadyPercentage));
    CharacterHealingAbilityController.NativeFieldInfoPtr_healingSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (healingSlots));
    CharacterHealingAbilityController.NativeFieldInfoPtr_healPromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (healPromptRef));
    CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialTargetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (tutorialTargetCount));
    CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialHealthThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (tutorialHealthThreshold));
    CharacterHealingAbilityController.NativeFieldInfoPtr_healingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (healingSound));
    CharacterHealingAbilityController.NativeFieldInfoPtr_autoHealUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (autoHealUsed));
    CharacterHealingAbilityController.NativeFieldInfoPtr_healthController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (healthController));
    CharacterHealingAbilityController.NativeFieldInfoPtr_baseHealingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (baseHealingData));
    CharacterHealingAbilityController.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (eventDisposable));
    CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (tutorialShown));
    CharacterHealingAbilityController.NativeMethodInfoPtr_get_FastHealingAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675156);
    CharacterHealingAbilityController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675157);
    CharacterHealingAbilityController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675158);
    CharacterHealingAbilityController.NativeMethodInfoPtr_DoDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675159);
    CharacterHealingAbilityController.NativeMethodInfoPtr_RefillOnCombatState_Private_Void_GameStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675160);
    CharacterHealingAbilityController.NativeMethodInfoPtr_RefillHealingSlots_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675161);
    CharacterHealingAbilityController.NativeMethodInfoPtr_UpdateHealingSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675162);
    CharacterHealingAbilityController.NativeMethodInfoPtr_CanHeal_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675163);
    CharacterHealingAbilityController.NativeMethodInfoPtr_Heal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675164);
    CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessReadyPercentage_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675165);
    CharacterHealingAbilityController.NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675166);
    CharacterHealingAbilityController.NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675167);
    CharacterHealingAbilityController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675168);
    CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675169);
    CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675170);
    CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675171);
    CharacterHealingAbilityController.NativeMethodInfoPtr_WaitForHealing_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675172);
    CharacterHealingAbilityController.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675173);
    CharacterHealingAbilityController.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675174);
    CharacterHealingAbilityController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675175);
    CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675176);
    CharacterHealingAbilityController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, 100675177);
  }

  public unsafe bool FastHealingAvailable
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_get_FastHealingAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115730, XrefRangeEnd = 115733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115733, XrefRangeEnd = 115753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115753, XrefRangeEnd = 115756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_DoDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115756, XrefRangeEnd = 115757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefillOnCombatState(GameStateChangedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_RefillOnCombatState_Private_Void_GameStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 115764, RefRangeEnd = 115767, XrefRangeStart = 115757, XrefRangeEnd = 115764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefillHealingSlots()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_RefillHealingSlots_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115772, RefRangeEnd = 115774, XrefRangeStart = 115767, XrefRangeEnd = 115772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateHealingSlots()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_UpdateHealingSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115776, RefRangeEnd = 115777, XrefRangeStart = 115774, XrefRangeEnd = 115776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanHeal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_CanHeal_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115788, RefRangeEnd = 115789, XrefRangeStart = 115777, XrefRangeEnd = 115788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Heal(bool manualHeal = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &manualHeal
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_Heal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115789, XrefRangeEnd = 115791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessReadyPercentage(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessReadyPercentage_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ResetUpgrades()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115791, XrefRangeEnd = 115811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Upgrade(string upgradedValue, UpgradeConfig config)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(upgradedValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) config);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115811, XrefRangeEnd = 115814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnectedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115814, XrefRangeEnd = 115826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessReceivedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115826, XrefRangeEnd = 115830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForHealing()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_WaitForHealing_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115830, XrefRangeEnd = 115832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115832, XrefRangeEnd = 115834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115834, XrefRangeEnd = 115835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115835, XrefRangeEnd = 115845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnection(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115845, XrefRangeEnd = 115846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterHealingAbilityController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CharacterHealingAbilityController.HealingData healingData
  {
    get
    {
      return *(CharacterHealingAbilityController.HealingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingData));
    }
    [param: In] set
    {
      *(CharacterHealingAbilityController.HealingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingData)) = value;
    }
  }

  public unsafe FloatReference healingReadyPercentage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingReadyPercentage));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingReadyPercentage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference healingSlots
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingSlots));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingSlots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef healPromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healPromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healPromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int tutorialTargetCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialTargetCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialTargetCount)) = value;
    }
  }

  public unsafe FloatReference tutorialHealthThreshold
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialHealthThreshold));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialHealthThreshold), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference healingSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healingSound)) = value;
    }
  }

  public unsafe bool autoHealUsed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_autoHealUsed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_autoHealUsed)) = value;
    }
  }

  public unsafe CharacterHealthController healthController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healthController));
      return num == System.IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_healthController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHealingAbilityController.HealingData baseHealingData
  {
    get
    {
      return *(CharacterHealingAbilityController.HealingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_baseHealingData));
    }
    [param: In] set
    {
      *(CharacterHealingAbilityController.HealingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_baseHealingData)) = value;
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int tutorialShown
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialShown));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController.NativeFieldInfoPtr_tutorialShown)) = value;
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct HealingData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealingPerUse;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealingSlots;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoHeal;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoHealPerUse;
    private static readonly System.IntPtr NativeFieldInfoPtr_FastHeal;
    [FieldOffset(0)]
    public float HealingPerUse;
    [FieldOffset(4)]
    public float HealingSlots;
    [FieldOffset(8)]
    public bool AutoHeal;
    [FieldOffset(12)]
    public float AutoHealPerUse;
    [FieldOffset(16 /*0x10*/)]
    public bool FastHeal;

    static HealingData()
    {
      Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, nameof (HealingData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr);
      CharacterHealingAbilityController.HealingData.NativeFieldInfoPtr_HealingPerUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr, nameof (HealingPerUse));
      CharacterHealingAbilityController.HealingData.NativeFieldInfoPtr_HealingSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr, nameof (HealingSlots));
      CharacterHealingAbilityController.HealingData.NativeFieldInfoPtr_AutoHeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr, nameof (AutoHeal));
      CharacterHealingAbilityController.HealingData.NativeFieldInfoPtr_AutoHealPerUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr, nameof (AutoHealPerUse));
      CharacterHealingAbilityController.HealingData.NativeFieldInfoPtr_FastHeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr, nameof (FastHeal));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHealingAbilityController.HealingData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterHealingAbilityController+<WaitForHealing>d__30")]
  public sealed class _WaitForHealing_d__30(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForHealing_d__30()
    {
      Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHealingAbilityController>.NativeClassPtr, "<WaitForHealing>d__30");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr);
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, "<>1__state");
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, "<>2__current");
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, "<>4__this");
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, 100675178);
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, 100675179);
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, 100675180);
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, 100675181);
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, 100675182);
      CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr, 100675183);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForHealing_d__30(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHealingAbilityController._WaitForHealing_d__30>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115718, XrefRangeEnd = 115725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115725, XrefRangeEnd = 115730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHealingAbilityController._WaitForHealing_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHealingAbilityController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterHealingAbilityController) null : Il2CppObjectPool.Get<CharacterHealingAbilityController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHealingAbilityController._WaitForHealing_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
