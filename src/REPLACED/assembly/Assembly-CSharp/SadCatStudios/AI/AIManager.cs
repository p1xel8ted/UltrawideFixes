// Decompiled with JetBrains decompiler
// Type: SadCatStudios.AI.AIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using BehaviorDesigner.Runtime;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using SadCatStudios.Combat;
using SadCatStudios.Foundation.Events;
using SadCatStudios.FSM;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.AI;

public class AIManager(System.IntPtr pointer) : LocalSingletonBehaviour<AIManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerDeathState;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyAimState;
  private static readonly System.IntPtr NativeFieldInfoPtr_waypointMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_formations;
  private static readonly System.IntPtr NativeFieldInfoPtr_overdriveState;
  private static readonly System.IntPtr NativeFieldInfoPtr_overdriveOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_BacklineOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_combatSequencer;
  private static readonly System.IntPtr NativeFieldInfoPtr_combatTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_roleCooldown;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleBackline;
  private static readonly System.IntPtr NativeFieldInfoPtr_MoveOutEventName;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_behaviorManager;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Target_Public_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CombatTimer_Public_get_CombatTimer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RoleCooldown_Public_Boolean_EnemyData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOverdriveState_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AdditionalOffset_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetStateController_Public_get_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InBorders_Public_Boolean_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToggleDebug_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActivateCombatSequence_Public_Void_CombatSequencerBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchMasterAIForGameState_Private_Void_GameStateChangedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetAllAgents_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_KillAllAgents_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBackline_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalmDownAllFrontlineAgents_Public_Void_String_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveAllFrontlineAgents_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEventFrontlineAgents_Public_Void_String_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEventInPoint_Public_Void_String_CharacterAIController_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableBehavior_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendAttackToken_Public_Void_CharacterAIController_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequestMovePoints_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetPos_Public_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterAgent_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterAgent_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeOffenceToken_Public_Void_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AgentFormation_Private_AIFormation_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartRoleCooldown_Public_Void_EnemyData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForRoleCooldown_Private_IEnumerator_EnemyData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_PlayerFinisherEndEvent_0;

  static AIManager()
  {
    Il2CppClassPointerStore<AIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.AI", nameof (AIManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIManager>.NativeClassPtr);
    AIManager.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (playerReference));
    AIManager.NativeFieldInfoPtr_playerDeathState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (playerDeathState));
    AIManager.NativeFieldInfoPtr_enemyAimState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (enemyAimState));
    AIManager.NativeFieldInfoPtr_waypointMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (waypointMask));
    AIManager.NativeFieldInfoPtr_formations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (formations));
    AIManager.NativeFieldInfoPtr_overdriveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (overdriveState));
    AIManager.NativeFieldInfoPtr_overdriveOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (overdriveOffset));
    AIManager.NativeFieldInfoPtr_eventRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (eventRadius));
    AIManager.NativeFieldInfoPtr_BacklineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (BacklineOffset));
    AIManager.NativeFieldInfoPtr_combatSequencer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (combatSequencer));
    AIManager.NativeFieldInfoPtr_combatTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (combatTimer));
    AIManager.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (targetTransform));
    AIManager.NativeFieldInfoPtr_roleCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (roleCooldown));
    AIManager.NativeFieldInfoPtr_visibleBackline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (visibleBackline));
    AIManager.NativeFieldInfoPtr_MoveOutEventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (MoveOutEventName));
    AIManager.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (eventDisposable));
    AIManager.NativeFieldInfoPtr_debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (debugMode));
    AIManager.NativeFieldInfoPtr_behaviorManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager>.NativeClassPtr, nameof (behaviorManager));
    AIManager.NativeMethodInfoPtr_get_Target_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677865);
    AIManager.NativeMethodInfoPtr_get_CombatTimer_Public_get_CombatTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677866);
    AIManager.NativeMethodInfoPtr_RoleCooldown_Public_Boolean_EnemyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677867);
    AIManager.NativeMethodInfoPtr_get_IsOverdriveState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677868);
    AIManager.NativeMethodInfoPtr_get_AdditionalOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677869);
    AIManager.NativeMethodInfoPtr_get_TargetStateController_Public_get_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677870);
    AIManager.NativeMethodInfoPtr_InBorders_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677871);
    AIManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677872);
    AIManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677873);
    AIManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677874);
    AIManager.NativeMethodInfoPtr_ToggleDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677875);
    AIManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677876);
    AIManager.NativeMethodInfoPtr_ActivateCombatSequence_Public_Void_CombatSequencerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677877);
    AIManager.NativeMethodInfoPtr_SwitchMasterAIForGameState_Private_Void_GameStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677878);
    AIManager.NativeMethodInfoPtr_ResetAllAgents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677879);
    AIManager.NativeMethodInfoPtr_KillAllAgents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677880);
    AIManager.NativeMethodInfoPtr_UpdateBackline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677881);
    AIManager.NativeMethodInfoPtr_CalmDownAllFrontlineAgents_Public_Void_String_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677882);
    AIManager.NativeMethodInfoPtr_MoveAllFrontlineAgents_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677883);
    AIManager.NativeMethodInfoPtr_SendEventFrontlineAgents_Public_Void_String_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677884);
    AIManager.NativeMethodInfoPtr_SendEventInPoint_Public_Void_String_CharacterAIController_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677885);
    AIManager.NativeMethodInfoPtr_EnableBehavior_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677886);
    AIManager.NativeMethodInfoPtr_SendAttackToken_Public_Void_CharacterAIController_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677887);
    AIManager.NativeMethodInfoPtr_RequestMovePoints_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677888 /*0x06003900*/);
    AIManager.NativeMethodInfoPtr_GetTargetPos_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677889);
    AIManager.NativeMethodInfoPtr_RegisterAgent_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677890);
    AIManager.NativeMethodInfoPtr_UnregisterAgent_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677891);
    AIManager.NativeMethodInfoPtr_FreeOffenceToken_Public_Void_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677892);
    AIManager.NativeMethodInfoPtr_AgentFormation_Private_AIFormation_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677893);
    AIManager.NativeMethodInfoPtr_StartRoleCooldown_Public_Void_EnemyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677894);
    AIManager.NativeMethodInfoPtr_WaitForRoleCooldown_Private_IEnumerator_EnemyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677895);
    AIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677896);
    AIManager.NativeMethodInfoPtr__Start_b__31_0_Private_Void_PlayerFinisherEndEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager>.NativeClassPtr, 100677898);
  }

  public unsafe Transform Target
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_get_Target_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public unsafe CombatTimer CombatTimer
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_get_CombatTimer_Public_get_CombatTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CombatTimer) null : Il2CppObjectPool.Get<CombatTimer>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132258, RefRangeEnd = 132259, XrefRangeStart = 132254, XrefRangeEnd = 132258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool RoleCooldown(EnemyData role)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) role)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_RoleCooldown_Public_Boolean_EnemyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool IsOverdriveState
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132259, XrefRangeEnd = 132268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_get_IsOverdriveState_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float AdditionalOffset
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132268, XrefRangeEnd = 132276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_get_AdditionalOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe StateController TargetStateController
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132276, XrefRangeEnd = 132280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_get_TargetStateController_Public_get_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132280, XrefRangeEnd = 132281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InBorders(float posX, float size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &posX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_InBorders_Public_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132281, XrefRangeEnd = 132288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AIManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132288, XrefRangeEnd = 132326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132326, XrefRangeEnd = 132329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AIManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132329, XrefRangeEnd = 132334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleDebug()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_ToggleDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132334, XrefRangeEnd = 132355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132364, RefRangeEnd = 132365, XrefRangeStart = 132355, XrefRangeEnd = 132364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActivateCombatSequence(CombatSequencerBase combatSequencer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatSequencer)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_ActivateCombatSequence_Public_Void_CombatSequencerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132365, XrefRangeEnd = 132368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchMasterAIForGameState(GameStateChangedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_SwitchMasterAIForGameState_Private_Void_GameStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132368, XrefRangeEnd = 132370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetAllAgents()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_ResetAllAgents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132370, XrefRangeEnd = 132383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void KillAllAgents()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_KillAllAgents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132400, RefRangeEnd = 132401, XrefRangeStart = 132383, XrefRangeEnd = 132400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateBackline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_UpdateBackline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132403, RefRangeEnd = 132405, XrefRangeStart = 132401, XrefRangeEnd = 132403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalmDownAllFrontlineAgents(
    string eventName,
    CharacterAIController excludeAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_CalmDownAllFrontlineAgents_Public_Void_String_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132407, RefRangeEnd = 132408, XrefRangeStart = 132405, XrefRangeEnd = 132407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveAllFrontlineAgents(CharacterAIController excludeAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_MoveAllFrontlineAgents_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132410, RefRangeEnd = 132411, XrefRangeStart = 132408, XrefRangeEnd = 132410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendEventFrontlineAgents(string eventName, CharacterAIController excludeAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_SendEventFrontlineAgents_Public_Void_String_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132411, XrefRangeEnd = 132413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendEventInPoint(
    string eventName,
    CharacterAIController excludeAgent,
    Vector3 point)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludeAgent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &point;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_SendEventInPoint_Public_Void_String_CharacterAIController_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132415, RefRangeEnd = 132417, XrefRangeStart = 132413, XrefRangeEnd = 132415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableBehavior(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_EnableBehavior_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendAttackToken(
    CharacterAIController agent,
    CharacterAIController.AIDecision actionType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) agent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionType;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_SendAttackToken_Public_Void_CharacterAIController_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132417, XrefRangeEnd = 132424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RequestMovePoints(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_RequestMovePoints_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132424, XrefRangeEnd = 132425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetTargetPos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_GetTargetPos_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132446, RefRangeEnd = 132447, XrefRangeStart = 132425, XrefRangeEnd = 132446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterAgent(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_RegisterAgent_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 132457, RefRangeEnd = 132460, XrefRangeStart = 132447, XrefRangeEnd = 132457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterAgent(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_UnregisterAgent_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 132467, RefRangeEnd = 132472, XrefRangeStart = 132460, XrefRangeEnd = 132467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeOffenceToken(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_FreeOffenceToken_Public_Void_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132472, XrefRangeEnd = 132476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AIFormation AgentFormation(CharacterAIController aiAgent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aiAgent)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_AgentFormation_Private_AIFormation_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AIFormation) null : Il2CppObjectPool.Get<AIFormation>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132481, RefRangeEnd = 132483, XrefRangeStart = 132476, XrefRangeEnd = 132481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartRoleCooldown(EnemyData role)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) role)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_StartRoleCooldown_Public_Void_EnemyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132483, XrefRangeEnd = 132487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForRoleCooldown(EnemyData role)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) role)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr_WaitForRoleCooldown_Private_IEnumerator_EnemyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132487, XrefRangeEnd = 132502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AIManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132502, XrefRangeEnd = 132504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__31_0(PlayerFinisherEndEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AIManager.NativeMethodInfoPtr__Start_b__31_0_Private_Void_PlayerFinisherEndEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_playerReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State playerDeathState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_playerDeathState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_playerDeathState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State enemyAimState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_enemyAimState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_enemyAimState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask waypointMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_waypointMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_waypointMask)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<AIFormation> formations
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_formations));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<AIFormation>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<AIFormation>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_formations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State overdriveState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_overdriveState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_overdriveState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float overdriveOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_overdriveOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_overdriveOffset)) = value;
    }
  }

  public unsafe float eventRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_eventRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_eventRadius)) = value;
    }
  }

  public unsafe float BacklineOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_BacklineOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_BacklineOffset)) = value;
    }
  }

  public unsafe CombatSequencerBase combatSequencer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_combatSequencer));
      return num == System.IntPtr.Zero ? (CombatSequencerBase) null : Il2CppObjectPool.Get<CombatSequencerBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_combatSequencer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CombatTimer combatTimer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_combatTimer));
      return num == System.IntPtr.Zero ? (CombatTimer) null : Il2CppObjectPool.Get<CombatTimer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_combatTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform targetTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_targetTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<EnemyData> roleCooldown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_roleCooldown));
      return num == System.IntPtr.Zero ? (HashSet<EnemyData>) null : Il2CppObjectPool.Get<HashSet<EnemyData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_roleCooldown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<EnemyCombatController> visibleBackline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_visibleBackline));
      return num == System.IntPtr.Zero ? (List<EnemyCombatController>) null : Il2CppObjectPool.Get<List<EnemyCombatController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_visibleBackline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string MoveOutEventName
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(AIManager.NativeFieldInfoPtr_MoveOutEventName, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AIManager.NativeFieldInfoPtr_MoveOutEventName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool debugMode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_debugMode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_debugMode)) = value;
    }
  }

  public unsafe BehaviorManager behaviorManager
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_behaviorManager));
      return num == System.IntPtr.Zero ? (BehaviorManager) null : Il2CppObjectPool.Get<BehaviorManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager.NativeFieldInfoPtr_behaviorManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.AI.AIManager+<WaitForRoleCooldown>d__53")]
  public sealed class _WaitForRoleCooldown_d__53(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_role;
    private static readonly System.IntPtr NativeFieldInfoPtr__cooldown_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForRoleCooldown_d__53()
    {
      Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIManager>.NativeClassPtr, "<WaitForRoleCooldown>d__53");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr);
      AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, "<>1__state");
      AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, "<>2__current");
      AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, "<>4__this");
      AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr_role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, nameof (role));
      AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr__cooldown_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, "<cooldown>5__2");
      AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, 100677899);
      AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, 100677900);
      AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, 100677901);
      AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, 100677902);
      AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, 100677903);
      AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr, 100677904);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForRoleCooldown_d__53(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIManager._WaitForRoleCooldown_d__53>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132236, XrefRangeEnd = 132249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132249, XrefRangeEnd = 132254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AIManager._WaitForRoleCooldown_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AIManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AIManager) null : Il2CppObjectPool.Get<AIManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EnemyData role
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr_role));
        return num == System.IntPtr.Zero ? (EnemyData) null : Il2CppObjectPool.Get<EnemyData>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr_role), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _cooldown_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr__cooldown_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AIManager._WaitForRoleCooldown_d__53.NativeFieldInfoPtr__cooldown_5__2)) = value;
      }
    }
  }
}
