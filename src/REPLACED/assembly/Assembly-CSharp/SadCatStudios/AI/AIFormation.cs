// Decompiled with JetBrains decompiler
// Type: SadCatStudios.AI.AIFormation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using SadCatStudios.Combat;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.AI;

public class AIFormation(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_minWanderingDist;
  private static readonly System.IntPtr NativeFieldInfoPtr_waypointsOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_borderOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackSelectionDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_allowSelectionDistanceFallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemiesConfigs;
  private static readonly System.IntPtr NativeFieldInfoPtr_availableAgents;
  private static readonly System.IntPtr NativeFieldInfoPtr_availableConfigs;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftWingAgents;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightWingAgents;
  private static readonly System.IntPtr NativeFieldInfoPtr_initiativeCandidates;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionCandidates;
  private static readonly System.IntPtr NativeFieldInfoPtr_distanceComparer;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackToken;
  private static readonly System.IntPtr NativeFieldInfoPtr_combatSequencer;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetAttackSender;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallbackTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallbackTarget;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinDistanceToTarget_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_WaypointsOffset_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BorderOffset_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EnemiesConfigs_Public_get_List_1_EnemyData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Transform_CombatSequencerBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessWingsCycles_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaypointsCycle_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AttacksCycle_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequestMovePoints_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AttackSelection_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasFreeAttackTokens_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterAgent_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterAgent_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeOffenceToken_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetAllAgents_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PauseAllAgents_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalmDownAllAgents_Public_Void_String_CharacterAIController_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEventToAllAgents_Public_Void_String_CharacterAIController_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveAllAgents_Public_Void_CharacterAIController_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_KillAllAgents_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEventInPoint_Public_Void_String_CharacterAIController_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_List_1_CharacterAIController_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_List_1_CharacterAIController_byref___c__DisplayClass35_0_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_byref___c__DisplayClass35_0_0;

  static AIFormation()
  {
    Il2CppClassPointerStore<AIFormation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.AI", nameof (AIFormation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIFormation>.NativeClassPtr);
    AIFormation.NativeFieldInfoPtr_minWanderingDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (minWanderingDist));
    AIFormation.NativeFieldInfoPtr_waypointsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (waypointsOffset));
    AIFormation.NativeFieldInfoPtr_borderOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (borderOffset));
    AIFormation.NativeFieldInfoPtr_attackSelectionDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (attackSelectionDepth));
    AIFormation.NativeFieldInfoPtr_allowSelectionDistanceFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (allowSelectionDistanceFallback));
    AIFormation.NativeFieldInfoPtr_enemiesConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (enemiesConfigs));
    AIFormation.NativeFieldInfoPtr_availableAgents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (availableAgents));
    AIFormation.NativeFieldInfoPtr_availableConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (availableConfigs));
    AIFormation.NativeFieldInfoPtr_leftWingAgents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (leftWingAgents));
    AIFormation.NativeFieldInfoPtr_rightWingAgents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (rightWingAgents));
    AIFormation.NativeFieldInfoPtr_initiativeCandidates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (initiativeCandidates));
    AIFormation.NativeFieldInfoPtr_actionCandidates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (actionCandidates));
    AIFormation.NativeFieldInfoPtr_distanceComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (distanceComparer));
    AIFormation.NativeFieldInfoPtr_attackToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (attackToken));
    AIFormation.NativeFieldInfoPtr_combatSequencer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (combatSequencer));
    AIFormation.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (targetTransform));
    AIFormation.NativeFieldInfoPtr_targetAttackSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (targetAttackSender));
    AIFormation.NativeFieldInfoPtr_fallbackTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (fallbackTimer));
    AIFormation.NativeFieldInfoPtr_fallbackTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (fallbackTarget));
    AIFormation.NativeMethodInfoPtr_get_MinDistanceToTarget_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677819);
    AIFormation.NativeMethodInfoPtr_get_WaypointsOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677820);
    AIFormation.NativeMethodInfoPtr_get_BorderOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677821);
    AIFormation.NativeMethodInfoPtr_get_EnemiesConfigs_Public_get_List_1_EnemyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677822);
    AIFormation.NativeMethodInfoPtr_Init_Public_Void_Transform_CombatSequencerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677823);
    AIFormation.NativeMethodInfoPtr_ProcessWingsCycles_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677824);
    AIFormation.NativeMethodInfoPtr_WaypointsCycle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677825);
    AIFormation.NativeMethodInfoPtr_AttacksCycle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677826);
    AIFormation.NativeMethodInfoPtr_RequestMovePoints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677827);
    AIFormation.NativeMethodInfoPtr_AttackSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677828);
    AIFormation.NativeMethodInfoPtr_HasFreeAttackTokens_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677829);
    AIFormation.NativeMethodInfoPtr_RegisterAgent_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677830);
    AIFormation.NativeMethodInfoPtr_UnregisterAgent_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677831);
    AIFormation.NativeMethodInfoPtr_FreeOffenceToken_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677832);
    AIFormation.NativeMethodInfoPtr_ResetAllAgents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677833);
    AIFormation.NativeMethodInfoPtr_PauseAllAgents_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677834);
    AIFormation.NativeMethodInfoPtr_CalmDownAllAgents_Public_Void_String_CharacterAIController_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677835);
    AIFormation.NativeMethodInfoPtr_SendEventToAllAgents_Public_Void_String_CharacterAIController_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677836);
    AIFormation.NativeMethodInfoPtr_MoveAllAgents_Public_Void_CharacterAIController_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677837);
    AIFormation.NativeMethodInfoPtr_KillAllAgents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677838);
    AIFormation.NativeMethodInfoPtr_SendEventInPoint_Public_Void_String_CharacterAIController_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677839);
    AIFormation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677840);
    AIFormation.NativeMethodInfoPtr_Method_Private_Void_List_1_CharacterAIController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677841);
    AIFormation.NativeMethodInfoPtr_Method_Private_Void_List_1_CharacterAIController_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677842);
    AIFormation.NativeMethodInfoPtr_Method_Private_Void_Boolean_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, 100677843);
  }

  public unsafe int MinDistanceToTarget
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_get_MinDistanceToTarget_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int WaypointsOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_get_WaypointsOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int BorderOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_get_BorderOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe List<EnemyData> EnemiesConfigs
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_get_EnemiesConfigs_Public_get_List_1_EnemyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<EnemyData>) null : Il2CppObjectPool.Get<List<EnemyData>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131748, RefRangeEnd = 131749, XrefRangeStart = 131704, XrefRangeEnd = 131748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(Transform targetTransform, CombatSequencerBase combatSequencer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatSequencer);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_Init_Public_Void_Transform_CombatSequencerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131806, RefRangeEnd = 131807, XrefRangeStart = 131749, XrefRangeEnd = 131806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessWingsCycles(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_ProcessWingsCycles_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131840 /*0x020300*/, RefRangeEnd = 131841, XrefRangeStart = 131807, XrefRangeEnd = 131840 /*0x020300*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void WaypointsCycle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_WaypointsCycle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131841, XrefRangeEnd = 131845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AttacksCycle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_AttacksCycle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131869, RefRangeEnd = 131871, XrefRangeStart = 131845, XrefRangeEnd = 131869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RequestMovePoints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_RequestMovePoints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131913, RefRangeEnd = 131915, XrefRangeStart = 131871, XrefRangeEnd = 131913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AttackSelection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_AttackSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe bool HasFreeAttackTokens()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_HasFreeAttackTokens_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131915, XrefRangeEnd = 131927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterAgent(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_RegisterAgent_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131927, XrefRangeEnd = 131933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterAgent(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_UnregisterAgent_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131933, XrefRangeEnd = 131934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeOffenceToken(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_FreeOffenceToken_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131949, RefRangeEnd = 131951, XrefRangeStart = 131934, XrefRangeEnd = 131949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetAllAgents()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_ResetAllAgents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131951, XrefRangeEnd = 131970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PauseAllAgents(CharacterAIController excludeAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_PauseAllAgents_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131990, RefRangeEnd = 131992, XrefRangeStart = 131970, XrefRangeEnd = 131990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalmDownAllAgents(
    string eventName,
    CharacterAIController excludeAgent,
    SadCatStudios.FSM.State keepThisState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keepThisState);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_CalmDownAllAgents_Public_Void_String_CharacterAIController_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132012, RefRangeEnd = 132013, XrefRangeStart = 131992, XrefRangeEnd = 132012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendEventToAllAgents(
    string eventName,
    CharacterAIController excludeAgent,
    SadCatStudios.FSM.State keepThisState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keepThisState);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_SendEventToAllAgents_Public_Void_String_CharacterAIController_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132035, RefRangeEnd = 132036, XrefRangeStart = 132013, XrefRangeEnd = 132035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveAllAgents(CharacterAIController excludeAgent, SadCatStudios.FSM.State keepThisState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keepThisState);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_MoveAllAgents_Public_Void_CharacterAIController_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132036, XrefRangeEnd = 132048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void KillAllAgents()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_KillAllAgents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132070, RefRangeEnd = 132071, XrefRangeStart = 132048, XrefRangeEnd = 132070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendEventInPoint(
    string eventName,
    CharacterAIController excludeAgent,
    Vector3 point,
    float radius)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &point;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_SendEventInPoint_Public_Void_String_CharacterAIController_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132071, XrefRangeEnd = 132116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AIFormation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIFormation>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132157, RefRangeEnd = 132159, XrefRangeStart = 132116, XrefRangeEnd = 132157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Method_Private_Void_List_1_CharacterAIController_Int32_0(
    List<CharacterAIController> wing,
    int wingSide)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wing);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wingSide;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_Method_Private_Void_List_1_CharacterAIController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132178, RefRangeEnd = 132180, XrefRangeStart = 132159, XrefRangeEnd = 132178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Method_Private_Void_List_1_CharacterAIController_byref___c__DisplayClass35_0_0(
    List<CharacterAIController> wing,
    ref AIFormation.__c__DisplayClass35_0 _param2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wing);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param2);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_Method_Private_Void_List_1_CharacterAIController_byref___c__DisplayClass35_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132229, RefRangeEnd = 132231, XrefRangeStart = 132180, XrefRangeEnd = 132229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Method_Private_Void_Boolean_byref___c__DisplayClass35_0_0(
    bool allowFallback,
    ref AIFormation.__c__DisplayClass35_0 _param2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &allowFallback;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param2);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIFormation.NativeMethodInfoPtr_Method_Private_Void_Boolean_byref___c__DisplayClass35_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int minWanderingDist
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_minWanderingDist));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_minWanderingDist)) = value;
    }
  }

  public unsafe int waypointsOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_waypointsOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_waypointsOffset)) = value;
    }
  }

  public unsafe int borderOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_borderOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_borderOffset)) = value;
    }
  }

  public unsafe int attackSelectionDepth
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_attackSelectionDepth));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_attackSelectionDepth)) = value;
    }
  }

  public unsafe bool allowSelectionDistanceFallback
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_allowSelectionDistanceFallback));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_allowSelectionDistanceFallback)) = value;
    }
  }

  public unsafe List<EnemyData> enemiesConfigs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_enemiesConfigs));
      return num == System.IntPtr.Zero ? (List<EnemyData>) null : Il2CppObjectPool.Get<List<EnemyData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_enemiesConfigs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<CharacterAIController> availableAgents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_availableAgents));
      return num == System.IntPtr.Zero ? (HashSet<CharacterAIController>) null : Il2CppObjectPool.Get<HashSet<CharacterAIController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_availableAgents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<EnemyData> availableConfigs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_availableConfigs));
      return num == System.IntPtr.Zero ? (HashSet<EnemyData>) null : Il2CppObjectPool.Get<HashSet<EnemyData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_availableConfigs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CharacterAIController> leftWingAgents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_leftWingAgents));
      return num == System.IntPtr.Zero ? (List<CharacterAIController>) null : Il2CppObjectPool.Get<List<CharacterAIController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_leftWingAgents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CharacterAIController> rightWingAgents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_rightWingAgents));
      return num == System.IntPtr.Zero ? (List<CharacterAIController>) null : Il2CppObjectPool.Get<List<CharacterAIController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_rightWingAgents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Il2CppSystem.ValueTuple<CharacterAIController, int>> initiativeCandidates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_initiativeCandidates));
      return num == System.IntPtr.Zero ? (List<Il2CppSystem.ValueTuple<CharacterAIController, int>>) null : Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<CharacterAIController, int>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_initiativeCandidates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<AIFormation.AttackCandidate> actionCandidates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_actionCandidates));
      return num == System.IntPtr.Zero ? (List<AIFormation.AttackCandidate>) null : Il2CppObjectPool.Get<List<AIFormation.AttackCandidate>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_actionCandidates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AIFormation.DistanceComparer distanceComparer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_distanceComparer));
      return num == System.IntPtr.Zero ? (AIFormation.DistanceComparer) null : Il2CppObjectPool.Get<AIFormation.DistanceComparer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_distanceComparer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public AIFormation.AttackToken attackToken
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_attackToken);
      return new AIFormation.AttackToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_attackToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe CombatSequencerBase combatSequencer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_combatSequencer));
      return num == System.IntPtr.Zero ? (CombatSequencerBase) null : Il2CppObjectPool.Get<CombatSequencerBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_combatSequencer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform targetTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_targetTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAttackSender targetAttackSender
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_targetAttackSender));
      return num == System.IntPtr.Zero ? (CharacterAttackSender) null : Il2CppObjectPool.Get<CharacterAttackSender>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_targetAttackSender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float fallbackTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_fallbackTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_fallbackTimer)) = value;
    }
  }

  public unsafe float fallbackTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_fallbackTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.NativeFieldInfoPtr_fallbackTarget)) = value;
    }
  }

  public class DistanceComparer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CharacterAIController_CharacterAIController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DistanceComparer()
    {
      Il2CppClassPointerStore<AIFormation.DistanceComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (DistanceComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIFormation.DistanceComparer>.NativeClassPtr);
      AIFormation.DistanceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CharacterAIController_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.DistanceComparer>.NativeClassPtr, 100677844);
      AIFormation.DistanceComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.DistanceComparer>.NativeClassPtr, 100677845);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131679, XrefRangeEnd = 131690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(CharacterAIController x, CharacterAIController y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.DistanceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CharacterAIController_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DistanceComparer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIFormation.DistanceComparer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIFormation.DistanceComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public sealed class AttackToken : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_lastAttackCandidate;
    private static readonly System.IntPtr NativeFieldInfoPtr_active;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Void_AttackCandidate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Void_CharacterAIController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

    static AttackToken()
    {
      Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (AttackToken));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr);
      AIFormation.AttackToken.NativeFieldInfoPtr_lastAttackCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, nameof (lastAttackCandidate));
      AIFormation.AttackToken.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, nameof (active));
      AIFormation.AttackToken.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, 100677846);
      AIFormation.AttackToken.NativeMethodInfoPtr_Send_Public_Void_AttackCandidate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, 100677847);
      AIFormation.AttackToken.NativeMethodInfoPtr_Free_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, 100677848);
      AIFormation.AttackToken.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr, 100677849);
    }

    public unsafe bool Active
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 64585, RefRangeEnd = 64591, XrefRangeStart = 64585, XrefRangeEnd = 64591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackToken.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131690, XrefRangeEnd = 131691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Send(AIFormation.AttackCandidate attackCandidate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) attackCandidate))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackToken.NativeMethodInfoPtr_Send_Public_Void_AttackCandidate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 131702, RefRangeEnd = 131704, XrefRangeStart = 131691, XrefRangeEnd = 131702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Free(CharacterAIController agent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) agent)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackToken.NativeMethodInfoPtr_Free_Public_Void_CharacterAIController_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void Free()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackToken.NativeMethodInfoPtr_Free_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public AttackToken(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AttackToken()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIFormation.AttackToken>.NativeClassPtr))
    {
    }

    public AIFormation.AttackCandidate lastAttackCandidate
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackToken.NativeFieldInfoPtr_lastAttackCandidate);
        return new AIFormation.AttackCandidate(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackToken.NativeFieldInfoPtr_lastAttackCandidate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool active
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackToken.NativeFieldInfoPtr_active));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackToken.NativeFieldInfoPtr_active)) = value;
      }
    }
  }

  public sealed class AttackCandidate : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_agent;
    private static readonly System.IntPtr NativeFieldInfoPtr_decision;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_CharacterAIController_AIDecision_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Weight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Agent_Public_get_CharacterAIController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Decision_Public_get_AIDecision_0;

    static AttackCandidate()
    {
      Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, nameof (AttackCandidate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr);
      AIFormation.AttackCandidate.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, nameof (weight));
      AIFormation.AttackCandidate.NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, nameof (agent));
      AIFormation.AttackCandidate.NativeFieldInfoPtr_decision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, nameof (decision));
      AIFormation.AttackCandidate.NativeMethodInfoPtr__ctor_Public_Void_Single_CharacterAIController_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, 100677850);
      AIFormation.AttackCandidate.NativeMethodInfoPtr_get_Weight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, 100677851);
      AIFormation.AttackCandidate.NativeMethodInfoPtr_get_Agent_Public_get_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, 100677852);
      AIFormation.AttackCandidate.NativeMethodInfoPtr_get_Decision_Public_get_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr, 100677853);
    }

    [CallerCount(0)]
    public unsafe AttackCandidate(
      float weight,
      CharacterAIController agent,
      CharacterAIController.AIDecision decision)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &weight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) agent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &decision;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackCandidate.NativeMethodInfoPtr__ctor_Public_Void_Single_CharacterAIController_AIDecision_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float Weight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackCandidate.NativeMethodInfoPtr_get_Weight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe CharacterAIController Agent
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackCandidate.NativeMethodInfoPtr_get_Agent_Public_get_CharacterAIController_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num3);
      }
    }

    public unsafe CharacterAIController.AIDecision Decision
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIFormation.AttackCandidate.NativeMethodInfoPtr_get_Decision_Public_get_AIDecision_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(CharacterAIController.AIDecision*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public AttackCandidate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AttackCandidate()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIFormation.AttackCandidate>.NativeClassPtr))
    {
    }

    public unsafe float weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackCandidate.NativeFieldInfoPtr_weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackCandidate.NativeFieldInfoPtr_weight)) = value;
      }
    }

    public unsafe CharacterAIController agent
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackCandidate.NativeFieldInfoPtr_agent));
        return num == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackCandidate.NativeFieldInfoPtr_agent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAIController.AIDecision decision
    {
      get
      {
        return *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackCandidate.NativeFieldInfoPtr_decision));
      }
      [param: In] set
      {
        *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.AttackCandidate.NativeFieldInfoPtr_decision)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.AI.AIFormation+<>c__DisplayClass35_0")]
  public sealed class __c__DisplayClass35_0 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_totalWeight;

    static __c__DisplayClass35_0()
    {
      Il2CppClassPointerStore<AIFormation.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIFormation>.NativeClassPtr, "<>c__DisplayClass35_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIFormation.__c__DisplayClass35_0>.NativeClassPtr);
      AIFormation.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
      AIFormation.__c__DisplayClass35_0.NativeFieldInfoPtr_totalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFormation.__c__DisplayClass35_0>.NativeClassPtr, nameof (totalWeight));
    }

    public __c__DisplayClass35_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass35_0()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIFormation.__c__DisplayClass35_0>.NativeClassPtr))
    {
    }

    public unsafe AIFormation __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AIFormation) null : Il2CppObjectPool.Get<AIFormation>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float totalWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.__c__DisplayClass35_0.NativeFieldInfoPtr_totalWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIFormation.__c__DisplayClass35_0.NativeFieldInfoPtr_totalWeight)) = value;
      }
    }
  }
}
