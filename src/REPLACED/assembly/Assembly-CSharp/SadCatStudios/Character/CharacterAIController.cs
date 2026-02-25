// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterAIController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using BehaviorDesigner.Runtime;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.AI;
using SadCatStudios.Animation;
using SadCatStudios.Combat;
using SadCatStudios.FSM;
using SadCatStudios.MovementPhysics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterAIController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_decisionDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorAddedDecisions;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorLockedDecisions;
  private static readonly System.IntPtr NativeFieldInfoPtr_AppointedDecision;
  private static readonly System.IntPtr NativeFieldInfoPtr_Waypoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_basePhysics;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_combatController;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathTracker;
  private static readonly System.IntPtr NativeFieldInfoPtr_uniqueContextProvider;
  private static readonly System.IntPtr NativeFieldInfoPtr_launchReceiveHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_stunController;
  private static readonly System.IntPtr NativeFieldInfoPtr_storedDecision;
  private static readonly System.IntPtr NativeFieldInfoPtr_appointedDecision;
  private static readonly System.IntPtr NativeFieldInfoPtr_availableAttacks;
  private static readonly System.IntPtr NativeFieldInfoPtr_behaviorTree;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyData;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_onFrontline;
  private static readonly System.IntPtr NativeFieldInfoPtr_FrontlineChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackRange_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OnFrontline_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsReady_Public_Boolean_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsStoredDecision_Public_Boolean_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAttackInSelectionRange_Public_Boolean_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailableAttacks_Public_get_List_1_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EnemyData_Public_get_EnemyData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CombatController_Public_get_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_FrontlineChanged_Public_add_Void_Action_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_FrontlineChanged_Public_rem_Void_Action_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AttackData_Public_AttackData_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_EnemyData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToNextDecision_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PerformAppointedDecision_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalmDownAgent_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToDefaultState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StoreDecision_Public_Void_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AppointDecision_Public_Void_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanRunAction_Public_Boolean_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAttacking_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasDecision_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasAppointedDecision_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRunning_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRunning_Public_Boolean_AIDecision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAvailable_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableAI_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToFrontline_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMovePoint_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMovePointCloseToTarget_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeOffenceToken_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsOnPlane_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CooldownTimer_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedsToCalmDown_Public_Boolean_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterAIController()
  {
    Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterAIController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr);
    CharacterAIController.NativeFieldInfoPtr_decisionDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (decisionDictionary));
    CharacterAIController.NativeFieldInfoPtr_attackDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (attackDictionary));
    CharacterAIController.NativeFieldInfoPtr_armorAddedDecisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (armorAddedDecisions));
    CharacterAIController.NativeFieldInfoPtr_armorLockedDecisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (armorLockedDecisions));
    CharacterAIController.NativeFieldInfoPtr_AppointedDecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (AppointedDecision));
    CharacterAIController.NativeFieldInfoPtr_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (Waypoint));
    CharacterAIController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (stateController));
    CharacterAIController.NativeFieldInfoPtr_basePhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (basePhysics));
    CharacterAIController.NativeFieldInfoPtr_sensorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (sensorController));
    CharacterAIController.NativeFieldInfoPtr_armorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (armorController));
    CharacterAIController.NativeFieldInfoPtr_combatController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (combatController));
    CharacterAIController.NativeFieldInfoPtr_deathTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (deathTracker));
    CharacterAIController.NativeFieldInfoPtr_uniqueContextProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (uniqueContextProvider));
    CharacterAIController.NativeFieldInfoPtr_launchReceiveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (launchReceiveHandler));
    CharacterAIController.NativeFieldInfoPtr_stunController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (stunController));
    CharacterAIController.NativeFieldInfoPtr_storedDecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (storedDecision));
    CharacterAIController.NativeFieldInfoPtr_appointedDecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (appointedDecision));
    CharacterAIController.NativeFieldInfoPtr_availableAttacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (availableAttacks));
    CharacterAIController.NativeFieldInfoPtr_behaviorTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (behaviorTree));
    CharacterAIController.NativeFieldInfoPtr_enemyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (enemyData));
    CharacterAIController.NativeFieldInfoPtr_attackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (attackRange));
    CharacterAIController.NativeFieldInfoPtr_onFrontline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (onFrontline));
    CharacterAIController.NativeFieldInfoPtr_FrontlineChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, nameof (FrontlineChanged));
    CharacterAIController.NativeMethodInfoPtr_get_AttackRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674669);
    CharacterAIController.NativeMethodInfoPtr_get_OnFrontline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674670);
    CharacterAIController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674671);
    CharacterAIController.NativeMethodInfoPtr_IsReady_Public_Boolean_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674672);
    CharacterAIController.NativeMethodInfoPtr_IsStoredDecision_Public_Boolean_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674673);
    CharacterAIController.NativeMethodInfoPtr_IsAttackInSelectionRange_Public_Boolean_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674674);
    CharacterAIController.NativeMethodInfoPtr_get_AvailableAttacks_Public_get_List_1_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674675);
    CharacterAIController.NativeMethodInfoPtr_get_EnemyData_Public_get_EnemyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674676);
    CharacterAIController.NativeMethodInfoPtr_get_CombatController_Public_get_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674677);
    CharacterAIController.NativeMethodInfoPtr_add_FrontlineChanged_Public_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674678);
    CharacterAIController.NativeMethodInfoPtr_remove_FrontlineChanged_Public_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674679);
    CharacterAIController.NativeMethodInfoPtr_AttackData_Public_AttackData_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674680);
    CharacterAIController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674681);
    CharacterAIController.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674682);
    CharacterAIController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674683);
    CharacterAIController.NativeMethodInfoPtr_Init_Public_Void_EnemyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674684);
    CharacterAIController.NativeMethodInfoPtr_SwitchToNextDecision_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674685);
    CharacterAIController.NativeMethodInfoPtr_PerformAppointedDecision_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674686);
    CharacterAIController.NativeMethodInfoPtr_CalmDownAgent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674687);
    CharacterAIController.NativeMethodInfoPtr_SwitchToDefaultState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674688);
    CharacterAIController.NativeMethodInfoPtr_StoreDecision_Public_Void_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674689);
    CharacterAIController.NativeMethodInfoPtr_AppointDecision_Public_Void_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674690);
    CharacterAIController.NativeMethodInfoPtr_SendEvent_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674691);
    CharacterAIController.NativeMethodInfoPtr_CanRunAction_Public_Boolean_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674692);
    CharacterAIController.NativeMethodInfoPtr_IsAttacking_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674693);
    CharacterAIController.NativeMethodInfoPtr_HasDecision_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674694);
    CharacterAIController.NativeMethodInfoPtr_HasAppointedDecision_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674695);
    CharacterAIController.NativeMethodInfoPtr_IsRunning_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674696);
    CharacterAIController.NativeMethodInfoPtr_IsRunning_Public_Boolean_AIDecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674697);
    CharacterAIController.NativeMethodInfoPtr_IsAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674698);
    CharacterAIController.NativeMethodInfoPtr_EnableAI_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674699);
    CharacterAIController.NativeMethodInfoPtr_MoveToFrontline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674700);
    CharacterAIController.NativeMethodInfoPtr_SetMovePoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674701);
    CharacterAIController.NativeMethodInfoPtr_SetMovePointCloseToTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674702);
    CharacterAIController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674703);
    CharacterAIController.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674704);
    CharacterAIController.NativeMethodInfoPtr_FreeOffenceToken_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674705);
    CharacterAIController.NativeMethodInfoPtr_IsOnPlane_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674706);
    CharacterAIController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674707);
    CharacterAIController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674708);
    CharacterAIController.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674709);
    CharacterAIController.NativeMethodInfoPtr_CooldownTimer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674710);
    CharacterAIController.NativeMethodInfoPtr_NeedsToCalmDown_Public_Boolean_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674711);
    CharacterAIController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, 100674712);
  }

  public unsafe float AttackRange
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112756, XrefRangeEnd = 112762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_get_AttackRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool OnFrontline
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_get_OnFrontline_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsDead
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 112766, RefRangeEnd = 112768, XrefRangeStart = 112762, XrefRangeEnd = 112766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112773, RefRangeEnd = 112774, XrefRangeStart = 112768, XrefRangeEnd = 112773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsReady(CharacterAIController.AIDecision decision)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &decision
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsReady_Public_Boolean_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112774, RefRangeEnd = 112775, XrefRangeStart = 112774, XrefRangeEnd = 112774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsStoredDecision(CharacterAIController.AIDecision decision)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &decision
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsStoredDecision_Public_Boolean_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112781, RefRangeEnd = 112782, XrefRangeStart = 112775, XrefRangeEnd = 112781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsAttackInSelectionRange(CharacterAIController.AIDecision decision)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &decision
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsAttackInSelectionRange_Public_Boolean_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe List<CharacterAIController.AIDecision> AvailableAttacks
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 72966, RefRangeEnd = 72967, XrefRangeStart = 72966, XrefRangeEnd = 72967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_get_AvailableAttacks_Public_get_List_1_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<CharacterAIController.AIDecision>) null : Il2CppObjectPool.Get<List<CharacterAIController.AIDecision>>(num3);
    }
  }

  public unsafe EnemyData EnemyData
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_get_EnemyData_Public_get_EnemyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnemyData) null : Il2CppObjectPool.Get<EnemyData>(num3);
    }
  }

  public unsafe EnemyCombatController CombatController
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_get_CombatController_Public_get_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnemyCombatController) null : Il2CppObjectPool.Get<EnemyCombatController>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112787, RefRangeEnd = 112788, XrefRangeStart = 112782, XrefRangeEnd = 112787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_FrontlineChanged(Il2CppSystem.Action<bool> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_add_FrontlineChanged_Public_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112793, RefRangeEnd = 112794, XrefRangeStart = 112788, XrefRangeEnd = 112793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_FrontlineChanged(Il2CppSystem.Action<bool> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_remove_FrontlineChanged_Public_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112800, RefRangeEnd = 112801, XrefRangeStart = 112794, XrefRangeEnd = 112800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SadCatStudios.Combat.AttackData AttackData(CharacterAIController.AIDecision decision)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &decision
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_AttackData_Public_AttackData_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (SadCatStudios.Combat.AttackData) null : Il2CppObjectPool.Get<SadCatStudios.Combat.AttackData>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112801, XrefRangeEnd = 112831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112831, XrefRangeEnd = 112835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112835, XrefRangeEnd = 112842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Init(EnemyData enemyData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemyData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_Init_Public_Void_EnemyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 112866, RefRangeEnd = 112869, XrefRangeStart = 112842, XrefRangeEnd = 112866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToNextDecision(MeshClip outClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outClip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_SwitchToNextDecision_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112869, RefRangeEnd = 112870, XrefRangeStart = 112869, XrefRangeEnd = 112869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PerformAppointedDecision()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_PerformAppointedDecision_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112873, RefRangeEnd = 112874, XrefRangeStart = 112870, XrefRangeEnd = 112873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalmDownAgent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_CalmDownAgent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 112874, RefRangeEnd = 112876, XrefRangeStart = 112874, XrefRangeEnd = 112874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToDefaultState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_SwitchToDefaultState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void StoreDecision(CharacterAIController.AIDecision aiDecision)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aiDecision
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_StoreDecision_Public_Void_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 112884, RefRangeEnd = 112886, XrefRangeStart = 112876, XrefRangeEnd = 112884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AppointDecision(CharacterAIController.AIDecision aiDecision)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aiDecision
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_AppointDecision_Public_Void_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 112888, RefRangeEnd = 112890, XrefRangeStart = 112886, XrefRangeEnd = 112888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendEvent(string eventName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(eventName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_SendEvent_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 112904, RefRangeEnd = 112907, XrefRangeStart = 112890, XrefRangeEnd = 112904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanRunAction(CharacterAIController.AIDecision actionType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &actionType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_CanRunAction_Public_Boolean_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112907, XrefRangeEnd = 112912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsAttacking()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsAttacking_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112912, RefRangeEnd = 112913, XrefRangeStart = 112912, XrefRangeEnd = 112912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasDecision()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_HasDecision_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112913, RefRangeEnd = 112914, XrefRangeStart = 112913, XrefRangeEnd = 112913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasAppointedDecision()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_HasAppointedDecision_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 112915, RefRangeEnd = 112917, XrefRangeStart = 112914, XrefRangeEnd = 112915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsRunning()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsRunning_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 112922, RefRangeEnd = 112926, XrefRangeStart = 112917, XrefRangeEnd = 112922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsRunning(CharacterAIController.AIDecision actionType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &actionType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsRunning_Public_Boolean_AIDecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112942, RefRangeEnd = 112943, XrefRangeStart = 112926, XrefRangeEnd = 112942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsAvailable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 112945, RefRangeEnd = 112948, XrefRangeStart = 112943, XrefRangeEnd = 112945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableAI(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_EnableAI_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112953, RefRangeEnd = 112954, XrefRangeStart = 112948, XrefRangeEnd = 112953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToFrontline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_MoveToFrontline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 112955, RefRangeEnd = 112957, XrefRangeStart = 112954, XrefRangeEnd = 112955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetMovePoint(Vector3 waypoint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &waypoint
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_SetMovePoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112957, XrefRangeEnd = 112961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetMovePointCloseToTarget()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_SetMovePointCloseToTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112961, XrefRangeEnd = 112967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnection(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 112972, RefRangeEnd = 112973, XrefRangeStart = 112967, XrefRangeEnd = 112972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeOffenceToken()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_FreeOffenceToken_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 112983, RefRangeEnd = 112985, XrefRangeStart = 112973, XrefRangeEnd = 112983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsOnPlane()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_IsOnPlane_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112985, XrefRangeEnd = 112996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnKill(DeathType deathType = DeathType.Undefined)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deathType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112996, XrefRangeEnd = 113004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnRespawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113004, XrefRangeEnd = 113006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113006, XrefRangeEnd = 113010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CooldownTimer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_CooldownTimer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 113016, RefRangeEnd = 113019, XrefRangeStart = 113010, XrefRangeEnd = 113016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool NeedsToCalmDown(SadCatStudios.FSM.State keepThisState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keepThisState)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr_NeedsToCalmDown_Public_Boolean_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAIController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAIController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DecisionDictionary decisionDictionary
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_decisionDictionary));
      return num == System.IntPtr.Zero ? (DecisionDictionary) null : Il2CppObjectPool.Get<DecisionDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_decisionDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackDictionary attackDictionary
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_attackDictionary));
      return num == System.IntPtr.Zero ? (AttackDictionary) null : Il2CppObjectPool.Get<AttackDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_attackDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DecisionDictionary armorAddedDecisions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_armorAddedDecisions));
      return num == System.IntPtr.Zero ? (DecisionDictionary) null : Il2CppObjectPool.Get<DecisionDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_armorAddedDecisions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CharacterAIController.AIDecision> armorLockedDecisions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_armorLockedDecisions));
      return num == System.IntPtr.Zero ? (List<CharacterAIController.AIDecision>) null : Il2CppObjectPool.Get<List<CharacterAIController.AIDecision>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_armorLockedDecisions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAIController.AIDecision AppointedDecision
  {
    get
    {
      return *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_AppointedDecision));
    }
    [param: In] set
    {
      *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_AppointedDecision)) = value;
    }
  }

  public unsafe Vector3 Waypoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_Waypoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_Waypoint)) = value;
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BasePhysics basePhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_basePhysics));
      return num == System.IntPtr.Zero ? (BasePhysics) null : Il2CppObjectPool.Get<BasePhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_basePhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterSensorController sensorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_sensorController));
      return num == System.IntPtr.Zero ? (CharacterSensorController) null : Il2CppObjectPool.Get<CharacterSensorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_sensorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterArmorController armorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_armorController));
      return num == System.IntPtr.Zero ? (CharacterArmorController) null : Il2CppObjectPool.Get<CharacterArmorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_armorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnemyCombatController combatController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_combatController));
      return num == System.IntPtr.Zero ? (EnemyCombatController) null : Il2CppObjectPool.Get<EnemyCombatController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_combatController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IDeathTracker deathTracker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_deathTracker));
      return num == System.IntPtr.Zero ? (IDeathTracker) null : Il2CppObjectPool.Get<IDeathTracker>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_deathTracker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IDecisionContextProvider uniqueContextProvider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_uniqueContextProvider));
      return num == System.IntPtr.Zero ? (IDecisionContextProvider) null : Il2CppObjectPool.Get<IDecisionContextProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_uniqueContextProvider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterLaunchReceiveHandler launchReceiveHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_launchReceiveHandler));
      return num == System.IntPtr.Zero ? (CharacterLaunchReceiveHandler) null : Il2CppObjectPool.Get<CharacterLaunchReceiveHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_launchReceiveHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterStunController stunController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_stunController));
      return num == System.IntPtr.Zero ? (CharacterStunController) null : Il2CppObjectPool.Get<CharacterStunController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_stunController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAIController.AIDecision storedDecision
  {
    get
    {
      return *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_storedDecision));
    }
    [param: In] set
    {
      *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_storedDecision)) = value;
    }
  }

  public unsafe CharacterAIController.AIDecision appointedDecision
  {
    get
    {
      return *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_appointedDecision));
    }
    [param: In] set
    {
      *(CharacterAIController.AIDecision*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_appointedDecision)) = value;
    }
  }

  public unsafe List<CharacterAIController.AIDecision> availableAttacks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_availableAttacks));
      return num == System.IntPtr.Zero ? (List<CharacterAIController.AIDecision>) null : Il2CppObjectPool.Get<List<CharacterAIController.AIDecision>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_availableAttacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BehaviorTree behaviorTree
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_behaviorTree));
      return num == System.IntPtr.Zero ? (BehaviorTree) null : Il2CppObjectPool.Get<BehaviorTree>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_behaviorTree), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnemyData enemyData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_enemyData));
      return num == System.IntPtr.Zero ? (EnemyData) null : Il2CppObjectPool.Get<EnemyData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_enemyData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float attackRange
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_attackRange));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_attackRange)) = value;
    }
  }

  public unsafe bool onFrontline
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_onFrontline));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_onFrontline)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<bool> FrontlineChanged
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_FrontlineChanged));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController.NativeFieldInfoPtr_FrontlineChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum AIDecision
  {
    None,
    Stop,
    TurnAround,
    Move,
    MoveBack,
    Run,
    Attack,
    Block,
    Evade,
    Riposte,
    Grab,
    HeavyAttack,
    SpecialAttack,
    Roll,
    Shoot,
    Taunt,
    JumpOut,
    SpecialAttack_2,
    UniqueContextual,
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterAIController+<CooldownTimer>d__71")]
  public sealed class _CooldownTimer_d__71(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

    static _CooldownTimer_d__71()
    {
      Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, "<CooldownTimer>d__71");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr);
      CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, "<>1__state");
      CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, "<>2__current");
      CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, "<>4__this");
      CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, 100674713);
      CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, 100674714);
      CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, 100674715);
      CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, 100674716);
      CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, 100674717);
      CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr, 100674718);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CooldownTimer_d__71(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAIController._CooldownTimer_d__71>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112731, XrefRangeEnd = 112732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112732, XrefRangeEnd = 112737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController._CooldownTimer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAIController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._CooldownTimer_d__71.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterAIController+<Start>d__43")]
  public sealed class _Start_d__43(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

    static _Start_d__43()
    {
      Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAIController>.NativeClassPtr, "<Start>d__43");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr);
      CharacterAIController._Start_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, "<>1__state");
      CharacterAIController._Start_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, "<>2__current");
      CharacterAIController._Start_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, "<>4__this");
      CharacterAIController._Start_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, 100674719);
      CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, 100674720);
      CharacterAIController._Start_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, 100674721);
      CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, 100674722);
      CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, 100674723);
      CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr, 100674724);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Start_d__43(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAIController._Start_d__43>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAIController._Start_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112737, XrefRangeEnd = 112751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController._Start_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112751, XrefRangeEnd = 112756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAIController._Start_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._Start_d__43.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._Start_d__43.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._Start_d__43.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._Start_d__43.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAIController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._Start_d__43.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAIController._Start_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
