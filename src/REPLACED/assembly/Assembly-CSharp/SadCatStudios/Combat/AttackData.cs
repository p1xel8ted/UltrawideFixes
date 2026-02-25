// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.AttackData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Effects;
using SadCatStudios.Foundation;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class AttackData(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_attributes;
  private static readonly System.IntPtr NativeFieldInfoPtr_healthDamage;
  private static readonly System.IntPtr NativeFieldInfoPtr_gruntHealthDamageMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_fastHealthDamageMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_shooterHealthDamageMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_tankHealthDamageMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossHealthDamageMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_perfectHitDamageMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_perfectHitManaGenerateMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorDamage;
  private static readonly System.IntPtr NativeFieldInfoPtr_poiseDamage;
  private static readonly System.IntPtr NativeFieldInfoPtr_healthRecovery;
  private static readonly System.IntPtr NativeFieldInfoPtr_poiseResistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_pushDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_magnetDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaGenerate;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaSpend;
  private static readonly System.IntPtr NativeFieldInfoPtr_overdriveGenerate;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackStartRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackCooldown;
  private static readonly System.IntPtr NativeFieldInfoPtr_stunDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackSelectionRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackOrigin;
  private static readonly System.IntPtr NativeFieldInfoPtr_forwardCounterVariants;
  private static readonly System.IntPtr NativeFieldInfoPtr_backCounterVariants;
  private static readonly System.IntPtr NativeFieldInfoPtr_launchImpactEvents;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitImpactEvents;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockedGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyModifiers;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_AttackType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_AttackProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HealthDamage_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PoiseDamage_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HealthRecovery_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MagnetDistance_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackOrigin_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ForwardCounter_Public_get_CounterVariant_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BackCounter_Public_get_CounterVariant_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetId_Public_Virtual_Final_New_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHealthRecovery_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHealthDamage_Public_Virtual_Final_New_Single_EnemyDataType_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPoiseDamage_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPoiseResistance_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPushDistance_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAttackType_Public_Virtual_Final_New_AttackType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_AttackProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeLaunchImpactEvents_Public_Virtual_Final_New_Void_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeHitImpactEvents_Public_Virtual_Final_New_Void_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetManaGenerate_Public_Virtual_Final_New_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetManaSpend_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOverdriveGenerate_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInvinsibilityDuration_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMagnetDistance_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAttackRange_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAttackCooldown_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStunDuration_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArmorDamage_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAttackStartRange_Public_Virtual_Final_New_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInSelectionRange_Public_Virtual_Final_New_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockedGraph_Public_Virtual_Final_New_FSMGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RangedStart_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AttackData()
  {
    Il2CppClassPointerStore<AttackData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (AttackData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackData>.NativeClassPtr);
    AttackData.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (title));
    AttackData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (type));
    AttackData.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (attributes));
    AttackData.NativeFieldInfoPtr_healthDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (healthDamage));
    AttackData.NativeFieldInfoPtr_gruntHealthDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (gruntHealthDamageMultiplier));
    AttackData.NativeFieldInfoPtr_fastHealthDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (fastHealthDamageMultiplier));
    AttackData.NativeFieldInfoPtr_shooterHealthDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (shooterHealthDamageMultiplier));
    AttackData.NativeFieldInfoPtr_tankHealthDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (tankHealthDamageMultiplier));
    AttackData.NativeFieldInfoPtr_bossHealthDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (bossHealthDamageMultiplier));
    AttackData.NativeFieldInfoPtr_perfectHitDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (perfectHitDamageMultiplier));
    AttackData.NativeFieldInfoPtr_perfectHitManaGenerateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (perfectHitManaGenerateMultiplier));
    AttackData.NativeFieldInfoPtr_armorDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (armorDamage));
    AttackData.NativeFieldInfoPtr_poiseDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (poiseDamage));
    AttackData.NativeFieldInfoPtr_healthRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (healthRecovery));
    AttackData.NativeFieldInfoPtr_poiseResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (poiseResistance));
    AttackData.NativeFieldInfoPtr_pushDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (pushDistance));
    AttackData.NativeFieldInfoPtr_magnetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (magnetDistance));
    AttackData.NativeFieldInfoPtr_manaGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (manaGenerate));
    AttackData.NativeFieldInfoPtr_manaSpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (manaSpend));
    AttackData.NativeFieldInfoPtr_overdriveGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (overdriveGenerate));
    AttackData.NativeFieldInfoPtr_attackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (attackRange));
    AttackData.NativeFieldInfoPtr_attackStartRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (attackStartRange));
    AttackData.NativeFieldInfoPtr_attackCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (attackCooldown));
    AttackData.NativeFieldInfoPtr_stunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (stunDuration));
    AttackData.NativeFieldInfoPtr_attackSelectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (attackSelectionRange));
    AttackData.NativeFieldInfoPtr_attackOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (attackOrigin));
    AttackData.NativeFieldInfoPtr_forwardCounterVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (forwardCounterVariants));
    AttackData.NativeFieldInfoPtr_backCounterVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (backCounterVariants));
    AttackData.NativeFieldInfoPtr_launchImpactEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (launchImpactEvents));
    AttackData.NativeFieldInfoPtr_hitImpactEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (hitImpactEvents));
    AttackData.NativeFieldInfoPtr_blockedGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (blockedGraph));
    AttackData.NativeFieldInfoPtr_difficultyModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (difficultyModifiers));
    AttackData.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677644);
    AttackData.NativeMethodInfoPtr_get_Type_Public_get_AttackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677645);
    AttackData.NativeMethodInfoPtr_get_Attributes_Public_get_AttackProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677646);
    AttackData.NativeMethodInfoPtr_get_HealthDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677647);
    AttackData.NativeMethodInfoPtr_get_PoiseDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677648);
    AttackData.NativeMethodInfoPtr_get_HealthRecovery_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677649);
    AttackData.NativeMethodInfoPtr_get_MagnetDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677650);
    AttackData.NativeMethodInfoPtr_get_AttackOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677651);
    AttackData.NativeMethodInfoPtr_get_ForwardCounter_Public_get_CounterVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677652);
    AttackData.NativeMethodInfoPtr_get_BackCounter_Public_get_CounterVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677653);
    AttackData.NativeMethodInfoPtr_GetId_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677654);
    AttackData.NativeMethodInfoPtr_GetHealthRecovery_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677655);
    AttackData.NativeMethodInfoPtr_GetHealthDamage_Public_Virtual_Final_New_Single_EnemyDataType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677656);
    AttackData.NativeMethodInfoPtr_GetPoiseDamage_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677657);
    AttackData.NativeMethodInfoPtr_GetPoiseResistance_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677658);
    AttackData.NativeMethodInfoPtr_GetPushDistance_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677659);
    AttackData.NativeMethodInfoPtr_GetAttackType_Public_Virtual_Final_New_AttackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677660);
    AttackData.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_AttackProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677661);
    AttackData.NativeMethodInfoPtr_InvokeLaunchImpactEvents_Public_Virtual_Final_New_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677662);
    AttackData.NativeMethodInfoPtr_InvokeHitImpactEvents_Public_Virtual_Final_New_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677663);
    AttackData.NativeMethodInfoPtr_GetManaGenerate_Public_Virtual_Final_New_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677664);
    AttackData.NativeMethodInfoPtr_GetManaSpend_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677665);
    AttackData.NativeMethodInfoPtr_GetOverdriveGenerate_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677666);
    AttackData.NativeMethodInfoPtr_GetInvinsibilityDuration_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677667);
    AttackData.NativeMethodInfoPtr_GetMagnetDistance_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677668);
    AttackData.NativeMethodInfoPtr_GetAttackRange_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677669);
    AttackData.NativeMethodInfoPtr_GetAttackCooldown_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677670);
    AttackData.NativeMethodInfoPtr_GetStunDuration_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677671);
    AttackData.NativeMethodInfoPtr_GetArmorDamage_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677672);
    AttackData.NativeMethodInfoPtr_GetAttackStartRange_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677673);
    AttackData.NativeMethodInfoPtr_IsInSelectionRange_Public_Virtual_Final_New_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677674);
    AttackData.NativeMethodInfoPtr_GetBlockedGraph_Public_Virtual_Final_New_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677675);
    AttackData.NativeMethodInfoPtr_RangedStart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677676);
    AttackData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData>.NativeClassPtr, 100677677);
  }

  public unsafe string Title
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe AttackType Type
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_Type_Public_get_AttackType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AttackType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AttackProperties Attributes
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_Attributes_Public_get_AttackProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AttackProperties*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float HealthDamage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_HealthDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float PoiseDamage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_PoiseDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float HealthRecovery
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_HealthRecovery_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MagnetDistance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_MagnetDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 AttackOrigin
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_AttackOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe CounterVariant ForwardCounter
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 130915, RefRangeEnd = 130916, XrefRangeStart = 130909, XrefRangeEnd = 130915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_ForwardCounter_Public_get_CounterVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CounterVariant) null : Il2CppObjectPool.Get<CounterVariant>(num3);
    }
  }

  public unsafe CounterVariant BackCounter
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 130921, RefRangeEnd = 130922, XrefRangeStart = 130916, XrefRangeEnd = 130921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_get_BackCounter_Public_get_CounterVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CounterVariant) null : Il2CppObjectPool.Get<CounterVariant>(num3);
    }
  }

  [CallerCount(28)]
  [CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string GetId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetId_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetHealthRecovery()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetHealthRecovery_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130944, RefRangeEnd = 130945, XrefRangeStart = 130922, XrefRangeEnd = 130944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float GetHealthDamage(EnemyData.EnemyDataType enemyType = EnemyData.EnemyDataType.Grunt, bool isPerfect = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &enemyType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isPerfect;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetHealthDamage_Public_Virtual_Final_New_Single_EnemyDataType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetPoiseDamage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetPoiseDamage_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetPoiseResistance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetPoiseResistance_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetPushDistance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetPushDistance_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe AttackType GetAttackType()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetAttackType_Public_Virtual_Final_New_AttackType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AttackType*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe AttackProperties GetAttributes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_AttackProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AttackProperties*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130959, RefRangeEnd = 130961, XrefRangeStart = 130945, XrefRangeEnd = 130959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void InvokeLaunchImpactEvents(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_InvokeLaunchImpactEvents_Public_Virtual_Final_New_Void_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130975, RefRangeEnd = 130977, XrefRangeStart = 130961, XrefRangeEnd = 130975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void InvokeHitImpactEvents(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_InvokeHitImpactEvents_Public_Virtual_Final_New_Void_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130977, RefRangeEnd = 130978, XrefRangeStart = 130977, XrefRangeEnd = 130977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float GetManaGenerate(bool isPerfect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isPerfect
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetManaGenerate_Public_Virtual_Final_New_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetManaSpend()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetManaSpend_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetOverdriveGenerate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetOverdriveGenerate_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetInvinsibilityDuration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetInvinsibilityDuration_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetMagnetDistance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetMagnetDistance_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetAttackRange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetAttackRange_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetAttackCooldown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetAttackCooldown_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetStunDuration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetStunDuration_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetArmorDamage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetArmorDamage_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetAttackStartRange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetAttackStartRange_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130978, RefRangeEnd = 130979, XrefRangeStart = 130978, XrefRangeEnd = 130978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsInSelectionRange(float targetDistance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetDistance
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_IsInSelectionRange_Public_Virtual_Final_New_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe FSMGraph GetBlockedGraph()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_GetBlockedGraph_Public_Virtual_Final_New_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130982, RefRangeEnd = 130983, XrefRangeStart = 130979, XrefRangeEnd = 130982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool RangedStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr_RangedStart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130983, XrefRangeEnd = 130994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe AttackType type
  {
    get
    {
      return *(AttackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(AttackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe AttackProperties attributes
  {
    get
    {
      return *(AttackProperties*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attributes));
    }
    [param: In] set
    {
      *(AttackProperties*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attributes)) = value;
    }
  }

  public unsafe float healthDamage
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_healthDamage));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_healthDamage)) = value;
    }
  }

  public unsafe float gruntHealthDamageMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_gruntHealthDamageMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_gruntHealthDamageMultiplier)) = value;
    }
  }

  public unsafe float fastHealthDamageMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_fastHealthDamageMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_fastHealthDamageMultiplier)) = value;
    }
  }

  public unsafe float shooterHealthDamageMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_shooterHealthDamageMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_shooterHealthDamageMultiplier)) = value;
    }
  }

  public unsafe float tankHealthDamageMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_tankHealthDamageMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_tankHealthDamageMultiplier)) = value;
    }
  }

  public unsafe float bossHealthDamageMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_bossHealthDamageMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_bossHealthDamageMultiplier)) = value;
    }
  }

  public unsafe float perfectHitDamageMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_perfectHitDamageMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_perfectHitDamageMultiplier)) = value;
    }
  }

  public unsafe float perfectHitManaGenerateMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_perfectHitManaGenerateMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_perfectHitManaGenerateMultiplier)) = value;
    }
  }

  public unsafe float armorDamage
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_armorDamage));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_armorDamage)) = value;
    }
  }

  public unsafe float poiseDamage
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_poiseDamage));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_poiseDamage)) = value;
    }
  }

  public unsafe float healthRecovery
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_healthRecovery));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_healthRecovery)) = value;
    }
  }

  public unsafe float poiseResistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_poiseResistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_poiseResistance)) = value;
    }
  }

  public unsafe float pushDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_pushDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_pushDistance)) = value;
    }
  }

  public unsafe float magnetDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_magnetDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_magnetDistance)) = value;
    }
  }

  public unsafe float manaGenerate
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_manaGenerate));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_manaGenerate)) = value;
    }
  }

  public unsafe float manaSpend
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_manaSpend));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_manaSpend)) = value;
    }
  }

  public unsafe float overdriveGenerate
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_overdriveGenerate));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_overdriveGenerate)) = value;
    }
  }

  public unsafe float attackRange
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackRange));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackRange)) = value;
    }
  }

  public unsafe float attackStartRange
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackStartRange));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackStartRange)) = value;
    }
  }

  public unsafe float attackCooldown
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackCooldown));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackCooldown)) = value;
    }
  }

  public unsafe float stunDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_stunDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_stunDuration)) = value;
    }
  }

  public unsafe Vector2 attackSelectionRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackSelectionRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackSelectionRange)) = value;
    }
  }

  public unsafe Vector3 attackOrigin
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackOrigin));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_attackOrigin)) = value;
    }
  }

  public unsafe List<CounterVariant> forwardCounterVariants
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_forwardCounterVariants));
      return num == System.IntPtr.Zero ? (List<CounterVariant>) null : Il2CppObjectPool.Get<List<CounterVariant>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_forwardCounterVariants), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CounterVariant> backCounterVariants
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_backCounterVariants));
      return num == System.IntPtr.Zero ? (List<CounterVariant>) null : Il2CppObjectPool.Get<List<CounterVariant>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_backCounterVariants), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ImpactEvent> launchImpactEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_launchImpactEvents));
      return num == System.IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_launchImpactEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ImpactEvent> hitImpactEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_hitImpactEvents));
      return num == System.IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_hitImpactEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph blockedGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_blockedGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_blockedGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackData.DifficultyDictionary difficultyModifiers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_difficultyModifiers));
      return num == System.IntPtr.Zero ? (AttackData.DifficultyDictionary) null : Il2CppObjectPool.Get<AttackData.DifficultyDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackData.NativeFieldInfoPtr_difficultyModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class DifficultyModifiers(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageDifference;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DifficultyModifiers()
    {
      Il2CppClassPointerStore<AttackData.DifficultyModifiers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (DifficultyModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackData.DifficultyModifiers>.NativeClassPtr);
      AttackData.DifficultyModifiers.NativeFieldInfoPtr_DamageDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackData.DifficultyModifiers>.NativeClassPtr, nameof (DamageDifference));
      AttackData.DifficultyModifiers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData.DifficultyModifiers>.NativeClassPtr, 100677678);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DifficultyModifiers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackData.DifficultyModifiers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttackData.DifficultyModifiers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float DamageDifference
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.DifficultyModifiers.NativeFieldInfoPtr_DamageDifference));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackData.DifficultyModifiers.NativeFieldInfoPtr_DamageDifference)) = value;
      }
    }
  }

  [Serializable]
  public class DifficultyDictionary(System.IntPtr pointer) : 
    UnitySerializedDictionary<DifficultyLevel, AttackData.DifficultyModifiers>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DifficultyDictionary()
    {
      Il2CppClassPointerStore<AttackData.DifficultyDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttackData>.NativeClassPtr, nameof (DifficultyDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackData.DifficultyDictionary>.NativeClassPtr);
      AttackData.DifficultyDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackData.DifficultyDictionary>.NativeClassPtr, 100677679);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130906, XrefRangeEnd = 130909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DifficultyDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackData.DifficultyDictionary>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttackData.DifficultyDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
