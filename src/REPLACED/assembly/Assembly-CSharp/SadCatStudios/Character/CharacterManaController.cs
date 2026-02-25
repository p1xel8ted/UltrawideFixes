// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterManaController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using MessagePipe;
using SadCatStudios.Combat;
using SadCatStudios.Foundation.Events;
using SadCatStudios.FSM;
using SadCatStudios.Quests;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterManaController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cellPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_cellCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaDrainDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaDrainSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_mana;
  private static readonly System.IntPtr NativeFieldInfoPtr_currMaxValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_fillSoundEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_chargeAdded;
  private static readonly System.IntPtr NativeFieldInfoPtr_chargeFilled;
  private static readonly System.IntPtr NativeFieldInfoPtr_chargeNotEnough;
  private static readonly System.IntPtr NativeFieldInfoPtr_drained;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaGenerateUpgrade;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickaxeGenerateUpgrade;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_drainCoroutine;
  private static readonly System.IntPtr NativeFieldInfoPtr_cheatState;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasNotified;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ManaPool_Public_get_FloatReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NotEnoughMana_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToggleGodMode_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMana_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetMana_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMana_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCurrentAndMaxMana_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrainMana_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterManaController()
  {
    Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterManaController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr);
    CharacterManaController.NativeFieldInfoPtr_cellPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (cellPool));
    CharacterManaController.NativeFieldInfoPtr_cellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (cellCount));
    CharacterManaController.NativeFieldInfoPtr_manaDrainDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (manaDrainDelay));
    CharacterManaController.NativeFieldInfoPtr_manaDrainSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (manaDrainSpeed));
    CharacterManaController.NativeFieldInfoPtr_mana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (mana));
    CharacterManaController.NativeFieldInfoPtr_currMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (currMaxValue));
    CharacterManaController.NativeFieldInfoPtr_fillSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (fillSoundEvent));
    CharacterManaController.NativeFieldInfoPtr_chargeAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (chargeAdded));
    CharacterManaController.NativeFieldInfoPtr_chargeFilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (chargeFilled));
    CharacterManaController.NativeFieldInfoPtr_chargeNotEnough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (chargeNotEnough));
    CharacterManaController.NativeFieldInfoPtr_drained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (drained));
    CharacterManaController.NativeFieldInfoPtr_manaGenerateUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (manaGenerateUpgrade));
    CharacterManaController.NativeFieldInfoPtr_pickaxeGenerateUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (pickaxeGenerateUpgrade));
    CharacterManaController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (stateController));
    CharacterManaController.NativeFieldInfoPtr_drainCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (drainCoroutine));
    CharacterManaController.NativeFieldInfoPtr_cheatState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (cheatState));
    CharacterManaController.NativeFieldInfoPtr_hasNotified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, nameof (hasNotified));
    CharacterManaController.NativeMethodInfoPtr_get_ManaPool_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675389);
    CharacterManaController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675390);
    CharacterManaController.NativeMethodInfoPtr_NotEnoughMana_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675391);
    CharacterManaController.NativeMethodInfoPtr_ToggleGodMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675392);
    CharacterManaController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675393);
    CharacterManaController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675394);
    CharacterManaController.NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675395);
    CharacterManaController.NativeMethodInfoPtr_ApplyMana_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675396);
    CharacterManaController.NativeMethodInfoPtr_ResetMana_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675397);
    CharacterManaController.NativeMethodInfoPtr_ProcessMana_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675398);
    CharacterManaController.NativeMethodInfoPtr_UpdateCurrentAndMaxMana_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675399);
    CharacterManaController.NativeMethodInfoPtr_DrainMana_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675400);
    CharacterManaController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675401);
    CharacterManaController.NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675402);
    CharacterManaController.NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675403);
    CharacterManaController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, 100675404);
  }

  public unsafe FloatReference ManaPool
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_get_ManaPool_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117232, XrefRangeEnd = 117260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117265, RefRangeEnd = 117266, XrefRangeStart = 117260, XrefRangeEnd = 117265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NotEnoughMana()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_NotEnoughMana_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117266, XrefRangeEnd = 117268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleGodMode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ToggleGodMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117268, XrefRangeEnd = 117291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnectedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessReceivedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 117301, RefRangeEnd = 117303, XrefRangeStart = 117291, XrefRangeEnd = 117301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessSentAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ProcessSentAttack_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117307, RefRangeEnd = 117308, XrefRangeStart = 117303, XrefRangeEnd = 117307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyMana(float delta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delta
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ApplyMana_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117308, XrefRangeEnd = 117313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetMana()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ResetMana_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117313, XrefRangeEnd = 117314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float ProcessMana(float delta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delta
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ProcessMana_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117314, XrefRangeEnd = 117318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCurrentAndMaxMana()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_UpdateCurrentAndMaxMana_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 117322, RefRangeEnd = 117324, XrefRangeStart = 117318, XrefRangeEnd = 117322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator DrainMana()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_DrainMana_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117324, XrefRangeEnd = 117330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117330, XrefRangeEnd = 117333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Upgrade(string upgradedValue, UpgradeConfig config)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(upgradedValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) config);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_Upgrade_Public_Virtual_Final_New_Void_String_UpgradeConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ResetUpgrades()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr_ResetUpgrades_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117333, XrefRangeEnd = 117334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterManaController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterManaController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference cellPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_cellPool));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_cellPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference cellCount
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_cellCount));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_cellCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference manaDrainDelay
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_manaDrainDelay));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_manaDrainDelay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference manaDrainSpeed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_manaDrainSpeed));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_manaDrainSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference mana
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_mana));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_mana), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float currMaxValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_currMaxValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_currMaxValue)) = value;
    }
  }

  public unsafe EventReference fillSoundEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_fillSoundEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_fillSoundEvent)) = value;
    }
  }

  public unsafe IPublisher<ManaChargeAdded> chargeAdded
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_chargeAdded));
      return num == System.IntPtr.Zero ? (IPublisher<ManaChargeAdded>) null : Il2CppObjectPool.Get<IPublisher<ManaChargeAdded>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_chargeAdded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<ManaChargeFilled> chargeFilled
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_chargeFilled));
      return num == System.IntPtr.Zero ? (IPublisher<ManaChargeFilled>) null : Il2CppObjectPool.Get<IPublisher<ManaChargeFilled>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_chargeFilled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<ManaChargeNotEnough> chargeNotEnough
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_chargeNotEnough));
      return num == System.IntPtr.Zero ? (IPublisher<ManaChargeNotEnough>) null : Il2CppObjectPool.Get<IPublisher<ManaChargeNotEnough>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_chargeNotEnough), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<ManaDrained> drained
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_drained));
      return num == System.IntPtr.Zero ? (IPublisher<ManaDrained>) null : Il2CppObjectPool.Get<IPublisher<ManaDrained>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_drained), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float manaGenerateUpgrade
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_manaGenerateUpgrade));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_manaGenerateUpgrade)) = value;
    }
  }

  public unsafe float pickaxeGenerateUpgrade
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_pickaxeGenerateUpgrade));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_pickaxeGenerateUpgrade)) = value;
    }
  }

  public unsafe AbilityStateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Coroutine drainCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_drainCoroutine));
      return num == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_drainCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CheatState cheatState
  {
    get
    {
      return *(CheatState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_cheatState));
    }
    [param: In] set
    {
      *(CheatState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_cheatState)) = value;
    }
  }

  public unsafe bool hasNotified
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_hasNotified));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController.NativeFieldInfoPtr_hasNotified)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterManaController+<DrainMana>d__29")]
  public sealed class _DrainMana_d__29(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__targetValue_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _DrainMana_d__29()
    {
      Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterManaController>.NativeClassPtr, "<DrainMana>d__29");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr);
      CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, "<>1__state");
      CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, "<>2__current");
      CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, "<>4__this");
      CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, "<timer>5__2");
      CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr__targetValue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, "<targetValue>5__3");
      CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, 100675405);
      CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, 100675406);
      CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, 100675407);
      CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, 100675408);
      CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, 100675409);
      CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr, 100675410);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _DrainMana_d__29(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterManaController._DrainMana_d__29>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117218, XrefRangeEnd = 117227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117227, XrefRangeEnd = 117232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterManaController._DrainMana_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterManaController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterManaController) null : Il2CppObjectPool.Get<CharacterManaController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }

    public unsafe float _targetValue_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr__targetValue_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterManaController._DrainMana_d__29.NativeFieldInfoPtr__targetValue_5__3)) = value;
      }
    }
  }
}
