// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterInteractionController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using MessagePipe;
using SadCatStudios.Animation;
using SadCatStudios.Combat;
using SadCatStudios.Environment;
using SadCatStudios.Foundation.Events;
using SadCatStudios.FSM;
using SadCatStudios.MovementPhysics;
using SadCatStudios.Triggers;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterInteractionController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_enterPositionThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_smoothEnterTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterStandClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitStandClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterCrouchClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitCrouchClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterSideClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitSideClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_valveClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_frontToIdle;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterScanSide;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitScanSide;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterScanFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitScanFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterDialogueDefalt;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitDialogueDefault;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterDoorPortalGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitDoorPortalGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterSideDoorPortalGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_movableGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_carryPickUpGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_carryPlugInGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_carryPlugOutGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_flareGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_bridgeMoveUpGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_bridgeMoveDownGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_bridgeMoveUpEnterClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_bridgeMoveDownEnterClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionAllowedInStates;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_basePhysics;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_movableContoller;
  private static readonly System.IntPtr NativeFieldInfoPtr_carryController;
  private static readonly System.IntPtr NativeFieldInfoPtr_col;
  private static readonly System.IntPtr NativeFieldInfoPtr_boundariesController;
  private static readonly System.IntPtr NativeFieldInfoPtr_bridgeController;
  private static readonly System.IntPtr NativeFieldInfoPtr_grabController;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_canInteract;
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionInProgress;
  private static readonly System.IntPtr NativeFieldInfoPtr_isMovingToPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_currZoneActive;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastInteractionZone;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastMaxZone;
  private static readonly System.IntPtr NativeFieldInfoPtr_knownZones;
  private static readonly System.IntPtr NativeFieldInfoPtr_knownInteractableZones;
  private static readonly System.IntPtr NativeFieldInfoPtr_zoneColliders;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptVisible;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptIsFor;
  private static readonly System.IntPtr NativeFieldInfoPtr_showPromptPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_hidePromptPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_isDead;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StateController_Public_get_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CarryController_Public_get_CharacterCarryingController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BridgeController_Public_get_CharacterBridgeController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCarrying_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartInteraction_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmInteraction_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetInteraction_Public_Void_InteractionZone_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetInteraction_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanInteract_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InteractionInProgress_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionZone_Public_InteractionZone_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Public_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPhysics_Public_BasePhysics_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStateController_Public_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowPrompt_Public_Void_Transform_IBounds_Vector3_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetPrompt_Public_UniTask_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PressPrompt_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessInteractionStatus_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FakeInputMoveToPointCoro_Private_IEnumerator_Transform_Transform_Transform_Boolean_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FakeInputMoveToPoint_Public_Void_Transform_Transform_Transform_Boolean_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInteraction_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Interact_Public_Void_IInteractable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayEnterClip_Public_Single_InteractionEnterType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayDialogueEnterClip_Public_Single_DialogEnterType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayButtonClip_Public_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayValveClip_Public_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayExitClip_Public_Single_InteractionEnterType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayDialogueExitClip_Public_Single_DialogEnterType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayFrontExitClip_Public_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToMovableState_Public_Void_MovableObjectPhysics_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToBridgeState_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToCarryState_Public_Void_CarryableObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToPlugOutState_Public_Void_CarryableBattery_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToPlugInState_Public_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToPortalEnterState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToPortalSideDoorEnterState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToPortalExitState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToIdleState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnOffState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnOnState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPlane_Public_Void_Plane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Break_Public_Void_InteractionZone_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsZoneInteractable_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayClip_Private_Single_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToState_Private_Void_FSMGraph_MeshClip_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveObjectFromKnown_Public_Void_InteractionZone_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsTouchingInteractionZone_Public_Boolean_InteractionZone_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BoundsInside_Private_Boolean_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__66_0_Private_Void_ResetToCheckpointEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__66_1_Private_Void_GameStateChangedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_byref___c__DisplayClass82_0_0;

  static CharacterInteractionController()
  {
    Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterInteractionController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr);
    CharacterInteractionController.NativeFieldInfoPtr_enterPositionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterPositionThreshold));
    CharacterInteractionController.NativeFieldInfoPtr_smoothEnterTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (smoothEnterTime));
    CharacterInteractionController.NativeFieldInfoPtr_enterStandClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterStandClip));
    CharacterInteractionController.NativeFieldInfoPtr_exitStandClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (exitStandClip));
    CharacterInteractionController.NativeFieldInfoPtr_enterCrouchClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterCrouchClip));
    CharacterInteractionController.NativeFieldInfoPtr_exitCrouchClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (exitCrouchClip));
    CharacterInteractionController.NativeFieldInfoPtr_enterSideClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterSideClip));
    CharacterInteractionController.NativeFieldInfoPtr_exitSideClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (exitSideClip));
    CharacterInteractionController.NativeFieldInfoPtr_buttonClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (buttonClip));
    CharacterInteractionController.NativeFieldInfoPtr_valveClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (valveClip));
    CharacterInteractionController.NativeFieldInfoPtr_frontToIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (frontToIdle));
    CharacterInteractionController.NativeFieldInfoPtr_enterScanSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterScanSide));
    CharacterInteractionController.NativeFieldInfoPtr_exitScanSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (exitScanSide));
    CharacterInteractionController.NativeFieldInfoPtr_enterScanFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterScanFront));
    CharacterInteractionController.NativeFieldInfoPtr_exitScanFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (exitScanFront));
    CharacterInteractionController.NativeFieldInfoPtr_enterDialogueDefalt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterDialogueDefalt));
    CharacterInteractionController.NativeFieldInfoPtr_exitDialogueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (exitDialogueDefault));
    CharacterInteractionController.NativeFieldInfoPtr_enterDoorPortalGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterDoorPortalGraph));
    CharacterInteractionController.NativeFieldInfoPtr_exitDoorPortalGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (exitDoorPortalGraph));
    CharacterInteractionController.NativeFieldInfoPtr_enterSideDoorPortalGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (enterSideDoorPortalGraph));
    CharacterInteractionController.NativeFieldInfoPtr_movableGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (movableGraph));
    CharacterInteractionController.NativeFieldInfoPtr_carryPickUpGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (carryPickUpGraph));
    CharacterInteractionController.NativeFieldInfoPtr_carryPlugInGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (carryPlugInGraph));
    CharacterInteractionController.NativeFieldInfoPtr_carryPlugOutGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (carryPlugOutGraph));
    CharacterInteractionController.NativeFieldInfoPtr_flareGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (flareGraph));
    CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveUpGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (bridgeMoveUpGraph));
    CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveDownGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (bridgeMoveDownGraph));
    CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveUpEnterClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (bridgeMoveUpEnterClip));
    CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveDownEnterClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (bridgeMoveDownEnterClip));
    CharacterInteractionController.NativeFieldInfoPtr_interactionAllowedInStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (interactionAllowedInStates));
    CharacterInteractionController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (stateController));
    CharacterInteractionController.NativeFieldInfoPtr_basePhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (basePhysics));
    CharacterInteractionController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (rotationController));
    CharacterInteractionController.NativeFieldInfoPtr_movableContoller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (movableContoller));
    CharacterInteractionController.NativeFieldInfoPtr_carryController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (carryController));
    CharacterInteractionController.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (col));
    CharacterInteractionController.NativeFieldInfoPtr_boundariesController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (boundariesController));
    CharacterInteractionController.NativeFieldInfoPtr_bridgeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (bridgeController));
    CharacterInteractionController.NativeFieldInfoPtr_grabController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (grabController));
    CharacterInteractionController.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (walkController));
    CharacterInteractionController.NativeFieldInfoPtr_canInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (canInteract));
    CharacterInteractionController.NativeFieldInfoPtr_interactionInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (interactionInProgress));
    CharacterInteractionController.NativeFieldInfoPtr_isMovingToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (isMovingToPoint));
    CharacterInteractionController.NativeFieldInfoPtr_currZoneActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (currZoneActive));
    CharacterInteractionController.NativeFieldInfoPtr_lastInteractionZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (lastInteractionZone));
    CharacterInteractionController.NativeFieldInfoPtr_lastMaxZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (lastMaxZone));
    CharacterInteractionController.NativeFieldInfoPtr_knownZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (knownZones));
    CharacterInteractionController.NativeFieldInfoPtr_knownInteractableZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (knownInteractableZones));
    CharacterInteractionController.NativeFieldInfoPtr_zoneColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (zoneColliders));
    CharacterInteractionController.NativeFieldInfoPtr_promptVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (promptVisible));
    CharacterInteractionController.NativeFieldInfoPtr_promptIsFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (promptIsFor));
    CharacterInteractionController.NativeFieldInfoPtr_showPromptPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (showPromptPublisher));
    CharacterInteractionController.NativeFieldInfoPtr_hidePromptPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (hidePromptPublisher));
    CharacterInteractionController.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (eventDisposable));
    CharacterInteractionController.NativeFieldInfoPtr_isDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, nameof (isDead));
    CharacterInteractionController.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675259);
    CharacterInteractionController.NativeMethodInfoPtr_get_StateController_Public_get_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675260);
    CharacterInteractionController.NativeMethodInfoPtr_get_CarryController_Public_get_CharacterCarryingController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675261);
    CharacterInteractionController.NativeMethodInfoPtr_get_BridgeController_Public_get_CharacterBridgeController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675262);
    CharacterInteractionController.NativeMethodInfoPtr_get_IsCarrying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675263);
    CharacterInteractionController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675264);
    CharacterInteractionController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675265);
    CharacterInteractionController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675266);
    CharacterInteractionController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675267);
    CharacterInteractionController.NativeMethodInfoPtr_StartInteraction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675268);
    CharacterInteractionController.NativeMethodInfoPtr_ConfirmInteraction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675269);
    CharacterInteractionController.NativeMethodInfoPtr_ResetInteraction_Public_Void_InteractionZone_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675270);
    CharacterInteractionController.NativeMethodInfoPtr_ResetInteraction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675271);
    CharacterInteractionController.NativeMethodInfoPtr_CanInteract_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675272);
    CharacterInteractionController.NativeMethodInfoPtr_InteractionInProgress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675273);
    CharacterInteractionController.NativeMethodInfoPtr_GetInteractionZone_Public_InteractionZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675274);
    CharacterInteractionController.NativeMethodInfoPtr_GetTransform_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675275);
    CharacterInteractionController.NativeMethodInfoPtr_GetPhysics_Public_BasePhysics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675276);
    CharacterInteractionController.NativeMethodInfoPtr_GetStateController_Public_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675277);
    CharacterInteractionController.NativeMethodInfoPtr_ShowPrompt_Public_Void_Transform_IBounds_Vector3_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675278);
    CharacterInteractionController.NativeMethodInfoPtr_ResetPrompt_Public_UniTask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675279);
    CharacterInteractionController.NativeMethodInfoPtr_PressPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675280);
    CharacterInteractionController.NativeMethodInfoPtr_ProcessInteractionStatus_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675281);
    CharacterInteractionController.NativeMethodInfoPtr_FakeInputMoveToPointCoro_Private_IEnumerator_Transform_Transform_Transform_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675282);
    CharacterInteractionController.NativeMethodInfoPtr_FakeInputMoveToPoint_Public_Void_Transform_Transform_Transform_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675283);
    CharacterInteractionController.NativeMethodInfoPtr_UpdateInteraction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675284);
    CharacterInteractionController.NativeMethodInfoPtr_Interact_Public_Void_IInteractable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675285);
    CharacterInteractionController.NativeMethodInfoPtr_PlayEnterClip_Public_Single_InteractionEnterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675286);
    CharacterInteractionController.NativeMethodInfoPtr_PlayDialogueEnterClip_Public_Single_DialogEnterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675287);
    CharacterInteractionController.NativeMethodInfoPtr_PlayButtonClip_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675288);
    CharacterInteractionController.NativeMethodInfoPtr_PlayValveClip_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675289);
    CharacterInteractionController.NativeMethodInfoPtr_PlayExitClip_Public_Single_InteractionEnterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675290);
    CharacterInteractionController.NativeMethodInfoPtr_PlayDialogueExitClip_Public_Single_DialogEnterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675291);
    CharacterInteractionController.NativeMethodInfoPtr_PlayFrontExitClip_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675292);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToMovableState_Public_Void_MovableObjectPhysics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675293);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToBridgeState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675294);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToCarryState_Public_Void_CarryableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675295);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToPlugOutState_Public_Void_CarryableBattery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675296);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToPlugInState_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675297);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToPortalEnterState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675298);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToPortalSideDoorEnterState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675299);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToPortalExitState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675300);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToIdleState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675301);
    CharacterInteractionController.NativeMethodInfoPtr_TurnOffState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675302);
    CharacterInteractionController.NativeMethodInfoPtr_TurnOnState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675303);
    CharacterInteractionController.NativeMethodInfoPtr_Rotate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675304);
    CharacterInteractionController.NativeMethodInfoPtr_SetPlane_Public_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675305);
    CharacterInteractionController.NativeMethodInfoPtr_Break_Public_Void_InteractionZone_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675306);
    CharacterInteractionController.NativeMethodInfoPtr_IsZoneInteractable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675307);
    CharacterInteractionController.NativeMethodInfoPtr_PlayClip_Private_Single_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675308);
    CharacterInteractionController.NativeMethodInfoPtr_SwitchToState_Private_Void_FSMGraph_MeshClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675309);
    CharacterInteractionController.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675310);
    CharacterInteractionController.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675311);
    CharacterInteractionController.NativeMethodInfoPtr_RemoveObjectFromKnown_Public_Void_InteractionZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675312);
    CharacterInteractionController.NativeMethodInfoPtr_IsTouchingInteractionZone_Public_Boolean_InteractionZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675313);
    CharacterInteractionController.NativeMethodInfoPtr_BoundsInside_Private_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675314);
    CharacterInteractionController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675315);
    CharacterInteractionController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675316);
    CharacterInteractionController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675317);
    CharacterInteractionController.NativeMethodInfoPtr__Start_b__66_0_Private_Void_ResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675318);
    CharacterInteractionController.NativeMethodInfoPtr__Start_b__66_1_Private_Void_GameStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675319);
    CharacterInteractionController.NativeMethodInfoPtr_Method_Private_Boolean_byref___c__DisplayClass82_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, 100675320);
  }

  public unsafe float Rotation
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 116500, RefRangeEnd = 116502, XrefRangeStart = 116499, XrefRangeEnd = 116500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe StateController StateController
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_get_StateController_Public_get_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num3);
    }
  }

  public unsafe CharacterCarryingController CarryController
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_get_CarryController_Public_get_CharacterCarryingController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CharacterCarryingController) null : Il2CppObjectPool.Get<CharacterCarryingController>(num3);
    }
  }

  public unsafe CharacterBridgeController BridgeController
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_get_BridgeController_Public_get_CharacterBridgeController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CharacterBridgeController) null : Il2CppObjectPool.Get<CharacterBridgeController>(num3);
    }
  }

  public unsafe bool IsCarrying
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 116502, RefRangeEnd = 116504, XrefRangeStart = 116502, XrefRangeEnd = 116502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_get_IsCarrying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116504, XrefRangeEnd = 116534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116534, XrefRangeEnd = 116541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116541, XrefRangeEnd = 116587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116587, XrefRangeEnd = 116590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116606, RefRangeEnd = 116607, XrefRangeStart = 116590, XrefRangeEnd = 116606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartInteraction()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_StartInteraction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 116607, RefRangeEnd = 116611, XrefRangeStart = 116607, XrefRangeEnd = 116607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ConfirmInteraction()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_ConfirmInteraction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 116634, RefRangeEnd = 116644, XrefRangeStart = 116611, XrefRangeEnd = 116634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetInteraction(InteractionZone zone, bool processReactivate = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) zone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &processReactivate;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_ResetInteraction_Public_Void_InteractionZone_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116650, RefRangeEnd = 116651, XrefRangeStart = 116644, XrefRangeEnd = 116650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetInteraction()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_ResetInteraction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe bool CanInteract()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_CanInteract_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool InteractionInProgress()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_InteractionInProgress_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe InteractionZone GetInteractionZone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_GetInteractionZone_Public_InteractionZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (InteractionZone) null : Il2CppObjectPool.Get<InteractionZone>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22243, XrefRangeEnd = 22246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform GetTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_GetTransform_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(0)]
  public unsafe BasePhysics GetPhysics()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_GetPhysics_Public_BasePhysics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BasePhysics) null : Il2CppObjectPool.Get<BasePhysics>(num3);
  }

  [CallerCount(0)]
  public unsafe StateController GetStateController()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_GetStateController_Public_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116655, RefRangeEnd = 116656, XrefRangeStart = 116651, XrefRangeEnd = 116655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPrompt(
    Transform atTransform,
    UIPromtFollow.IBounds bounds,
    Vector3 offset,
    bool needMarker,
    string text = "%Action%")
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) atTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bounds);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &needMarker;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_ShowPrompt_Public_Void_Transform_IBounds_Vector3_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 116672, RefRangeEnd = 116678, XrefRangeStart = 116656, XrefRangeEnd = 116672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask ResetPrompt(bool manual = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &manual
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_ResetPrompt_Public_UniTask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 116681, RefRangeEnd = 116683, XrefRangeStart = 116678, XrefRangeEnd = 116681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PressPrompt()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PressPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116836, RefRangeEnd = 116837, XrefRangeStart = 116683, XrefRangeEnd = 116836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessInteractionStatus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_ProcessInteractionStatus_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116837, XrefRangeEnd = 116841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FakeInputMoveToPointCoro(
    Transform zone,
    Transform activationPoint,
    Transform turnToPoint,
    bool stopAtPoint,
    Il2CppSystem.Action action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) zone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) activationPoint);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) turnToPoint);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stopAtPoint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_FakeInputMoveToPointCoro_Private_IEnumerator_Transform_Transform_Transform_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116841, XrefRangeEnd = 116851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FakeInputMoveToPoint(
    Transform zone,
    Transform activationPoint = null,
    Transform turnToPoint = null,
    bool stopAtPoint = true,
    Il2CppSystem.Action action = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) zone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) activationPoint);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) turnToPoint);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stopAtPoint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_FakeInputMoveToPoint_Public_Void_Transform_Transform_Transform_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116851, XrefRangeEnd = 116852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateInteraction()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_UpdateInteraction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116857, RefRangeEnd = 116858, XrefRangeStart = 116852, XrefRangeEnd = 116857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Interact(IInteractable interactable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactable)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_Interact_Public_Void_IInteractable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 116863, RefRangeEnd = 116867, XrefRangeStart = 116858, XrefRangeEnd = 116863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayEnterClip(InteractionEnterType enterType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enterType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayEnterClip_Public_Single_InteractionEnterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116867, XrefRangeEnd = 116872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayDialogueEnterClip(InteractionDialogZone.DialogEnterType enterType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enterType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayDialogueEnterClip_Public_Single_DialogEnterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 116873, RefRangeEnd = 116876, XrefRangeStart = 116872, XrefRangeEnd = 116873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayButtonClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayButtonClip_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116877, RefRangeEnd = 116878, XrefRangeStart = 116876, XrefRangeEnd = 116877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayValveClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayValveClip_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 116883, RefRangeEnd = 116890, XrefRangeStart = 116878, XrefRangeEnd = 116883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayExitClip(InteractionEnterType enterType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enterType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayExitClip_Public_Single_InteractionEnterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116895, RefRangeEnd = 116896, XrefRangeStart = 116890, XrefRangeEnd = 116895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayDialogueExitClip(InteractionDialogZone.DialogEnterType enterType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enterType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayDialogueExitClip_Public_Single_DialogEnterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116897, RefRangeEnd = 116898, XrefRangeStart = 116896, XrefRangeEnd = 116897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayFrontExitClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayFrontExitClip_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116898, XrefRangeEnd = 116899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToMovableState(MovableObjectPhysics movableObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) movableObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToMovableState_Public_Void_MovableObjectPhysics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116900, RefRangeEnd = 116901, XrefRangeStart = 116899, XrefRangeEnd = 116900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToBridgeState(bool isUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isUp
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToBridgeState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116901, XrefRangeEnd = 116910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToCarryState(CarryableObject carryObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) carryObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToCarryState_Public_Void_CarryableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116910, XrefRangeEnd = 116919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToPlugOutState(CarryableBattery carryBattery)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) carryBattery)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToPlugOutState_Public_Void_CarryableBattery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116923, RefRangeEnd = 116924, XrefRangeStart = 116919, XrefRangeEnd = 116923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator SwitchToPlugInState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToPlugInState_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 116924, RefRangeEnd = 116926, XrefRangeStart = 116924, XrefRangeEnd = 116924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToPortalEnterState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToPortalEnterState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116926, RefRangeEnd = 116927, XrefRangeStart = 116926, XrefRangeEnd = 116926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToPortalSideDoorEnterState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToPortalSideDoorEnterState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116929, RefRangeEnd = 116930, XrefRangeStart = 116927, XrefRangeEnd = 116929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToPortalExitState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToPortalExitState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 116931, RefRangeEnd = 116934, XrefRangeStart = 116930, XrefRangeEnd = 116931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToIdleState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToIdleState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116936, RefRangeEnd = 116937, XrefRangeStart = 116934, XrefRangeEnd = 116936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnOffState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_TurnOffState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116939, RefRangeEnd = 116940, XrefRangeStart = 116937, XrefRangeEnd = 116939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnOnState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_TurnOnState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 116942, RefRangeEnd = 116944, XrefRangeStart = 116940, XrefRangeEnd = 116942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Rotate(float dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dir
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_Rotate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetPlane(Plane plane)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &plane
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SetPlane_Public_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 116947, RefRangeEnd = 116960, XrefRangeStart = 116944, XrefRangeEnd = 116947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Break(InteractionZone zone, bool resetToDefaultFSM = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) zone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resetToDefaultFSM;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_Break_Public_Void_InteractionZone_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116970, RefRangeEnd = 116971, XrefRangeStart = 116960, XrefRangeEnd = 116970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsZoneInteractable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_IsZoneInteractable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116971, XrefRangeEnd = 116972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float PlayClip(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_PlayClip_Private_Single_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void SwitchToState(FSMGraph graph, MeshClip clip = null, bool cancelable = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graph);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cancelable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_SwitchToState_Private_Void_FSMGraph_MeshClip_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116972, XrefRangeEnd = 117001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117001, XrefRangeEnd = 117005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerExit(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 117014, RefRangeEnd = 117018, XrefRangeStart = 117005, XrefRangeEnd = 117014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveObjectFromKnown(InteractionZone zone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) zone)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_RemoveObjectFromKnown_Public_Void_InteractionZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117022, RefRangeEnd = 117023, XrefRangeStart = 117018, XrefRangeEnd = 117022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsTouchingInteractionZone(InteractionZone zone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) zone)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_IsTouchingInteractionZone_Public_Boolean_InteractionZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 117025, RefRangeEnd = 117027, XrefRangeStart = 117023, XrefRangeEnd = 117025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool BoundsInside(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_BoundsInside_Private_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117027, XrefRangeEnd = 117030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnKill(DeathType deathType = DeathType.Undefined)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deathType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117030, XrefRangeEnd = 117036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnRespawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117036, XrefRangeEnd = 117053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterInteractionController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void _Start_b__66_0(ResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr__Start_b__66_0_Private_Void_ResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117053, XrefRangeEnd = 117054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__66_1(GameStateChangedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr__Start_b__66_1_Private_Void_GameStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 117059, RefRangeEnd = 117062, XrefRangeStart = 117054, XrefRangeEnd = 117059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Method_Private_Boolean_byref___c__DisplayClass82_0_0(
    ref CharacterInteractionController.__c__DisplayClass82_0 _param1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param1)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.NativeMethodInfoPtr_Method_Private_Boolean_byref___c__DisplayClass82_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float enterPositionThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterPositionThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterPositionThreshold)) = value;
    }
  }

  public unsafe float smoothEnterTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_smoothEnterTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_smoothEnterTime)) = value;
    }
  }

  public unsafe MeshClip enterStandClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterStandClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterStandClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip exitStandClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitStandClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitStandClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip enterCrouchClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterCrouchClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterCrouchClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip exitCrouchClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitCrouchClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitCrouchClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip enterSideClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterSideClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterSideClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip exitSideClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitSideClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitSideClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip buttonClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_buttonClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_buttonClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip valveClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_valveClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_valveClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip frontToIdle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_frontToIdle));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_frontToIdle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip enterScanSide
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterScanSide));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterScanSide), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip exitScanSide
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitScanSide));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitScanSide), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip enterScanFront
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterScanFront));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterScanFront), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip exitScanFront
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitScanFront));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitScanFront), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip enterDialogueDefalt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterDialogueDefalt));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterDialogueDefalt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip exitDialogueDefault
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitDialogueDefault));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitDialogueDefault), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph enterDoorPortalGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterDoorPortalGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterDoorPortalGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph exitDoorPortalGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitDoorPortalGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_exitDoorPortalGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph enterSideDoorPortalGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterSideDoorPortalGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_enterSideDoorPortalGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph movableGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_movableGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_movableGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph carryPickUpGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryPickUpGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryPickUpGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph carryPlugInGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryPlugInGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryPlugInGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph carryPlugOutGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryPlugOutGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryPlugOutGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph flareGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_flareGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_flareGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph bridgeMoveUpGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveUpGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveUpGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph bridgeMoveDownGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveDownGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveDownGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip bridgeMoveUpEnterClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveUpEnterClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveUpEnterClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip bridgeMoveDownEnterClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveDownEnterClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeMoveDownEnterClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<SadCatStudios.FSM.State> interactionAllowedInStates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_interactionAllowedInStates));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SadCatStudios.FSM.State>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SadCatStudios.FSM.State>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_interactionAllowedInStates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BasePhysics basePhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_basePhysics));
      return num == System.IntPtr.Zero ? (BasePhysics) null : Il2CppObjectPool.Get<BasePhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_basePhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterMovableContoller movableContoller
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_movableContoller));
      return num == System.IntPtr.Zero ? (CharacterMovableContoller) null : Il2CppObjectPool.Get<CharacterMovableContoller>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_movableContoller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterCarryingController carryController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryController));
      return num == System.IntPtr.Zero ? (CharacterCarryingController) null : Il2CppObjectPool.Get<CharacterCarryingController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_carryController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoxCollider col
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_col));
      return num == System.IntPtr.Zero ? (BoxCollider) null : Il2CppObjectPool.Get<BoxCollider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterBoundariesController boundariesController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_boundariesController));
      return num == System.IntPtr.Zero ? (CharacterBoundariesController) null : Il2CppObjectPool.Get<CharacterBoundariesController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_boundariesController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterBridgeController bridgeController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeController));
      return num == System.IntPtr.Zero ? (CharacterBridgeController) null : Il2CppObjectPool.Get<CharacterBridgeController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_bridgeController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController grabController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_grabController));
      return num == System.IntPtr.Zero ? (CharacterGrabController) null : Il2CppObjectPool.Get<CharacterGrabController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_grabController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool canInteract
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_canInteract));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_canInteract)) = value;
    }
  }

  public unsafe bool interactionInProgress
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_interactionInProgress));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_interactionInProgress)) = value;
    }
  }

  public unsafe bool isMovingToPoint
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_isMovingToPoint));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_isMovingToPoint)) = value;
    }
  }

  public unsafe bool currZoneActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_currZoneActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_currZoneActive)) = value;
    }
  }

  public unsafe InteractionZone lastInteractionZone
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_lastInteractionZone));
      return num == System.IntPtr.Zero ? (InteractionZone) null : Il2CppObjectPool.Get<InteractionZone>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_lastInteractionZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InteractionZone lastMaxZone
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_lastMaxZone));
      return num == System.IntPtr.Zero ? (InteractionZone) null : Il2CppObjectPool.Get<InteractionZone>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_lastMaxZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<InteractionZone> knownZones
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_knownZones));
      return num == System.IntPtr.Zero ? (List<InteractionZone>) null : Il2CppObjectPool.Get<List<InteractionZone>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_knownZones), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<InteractionZone> knownInteractableZones
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_knownInteractableZones));
      return num == System.IntPtr.Zero ? (List<InteractionZone>) null : Il2CppObjectPool.Get<List<InteractionZone>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_knownInteractableZones), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<InteractionZone, Collider> zoneColliders
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_zoneColliders));
      return num == System.IntPtr.Zero ? (Dictionary<InteractionZone, Collider>) null : Il2CppObjectPool.Get<Dictionary<InteractionZone, Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_zoneColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool promptVisible
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_promptVisible));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_promptVisible)) = value;
    }
  }

  public unsafe InteractionZone promptIsFor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_promptIsFor));
      return num == System.IntPtr.Zero ? (InteractionZone) null : Il2CppObjectPool.Get<InteractionZone>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_promptIsFor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<ShowTutorialPromptEvent> showPromptPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_showPromptPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<ShowTutorialPromptEvent>) null : Il2CppObjectPool.Get<IPublisher<ShowTutorialPromptEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_showPromptPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<HideTutorialPromptEvent> hidePromptPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_hidePromptPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<HideTutorialPromptEvent>) null : Il2CppObjectPool.Get<IPublisher<HideTutorialPromptEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_hidePromptPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isDead
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_isDead));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.NativeFieldInfoPtr_isDead)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__81_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__110_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ProcessInteractionStatus_b__81_0_Internal_Int32_InteractionZone_InteractionZone_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnTriggerEnter_b__110_0_Internal_Int32_InteractionZone_InteractionZone_0;

    static __c()
    {
      Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr);
      CharacterInteractionController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr, "<>9");
      CharacterInteractionController.__c.NativeFieldInfoPtr___9__81_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr, "<>9__81_0");
      CharacterInteractionController.__c.NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr, "<>9__110_0");
      CharacterInteractionController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr, 100675322);
      CharacterInteractionController.__c.NativeMethodInfoPtr__ProcessInteractionStatus_b__81_0_Internal_Int32_InteractionZone_InteractionZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr, 100675323);
      CharacterInteractionController.__c.NativeMethodInfoPtr__OnTriggerEnter_b__110_0_Internal_Int32_InteractionZone_InteractionZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr, 100675324);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116330, XrefRangeEnd = 116331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _ProcessInteractionStatus_b__81_0(InteractionZone a, InteractionZone b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c.NativeMethodInfoPtr__ProcessInteractionStatus_b__81_0_Internal_Int32_InteractionZone_InteractionZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _OnTriggerEnter_b__110_0(InteractionZone a, InteractionZone b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c.NativeMethodInfoPtr__OnTriggerEnter_b__110_0_Internal_Int32_InteractionZone_InteractionZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CharacterInteractionController.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterInteractionController.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CharacterInteractionController.__c) null : Il2CppObjectPool.Get<CharacterInteractionController.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterInteractionController.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<InteractionZone> __9__81_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterInteractionController.__c.NativeFieldInfoPtr___9__81_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<InteractionZone>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<InteractionZone>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterInteractionController.__c.NativeFieldInfoPtr___9__81_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<InteractionZone> __9__110_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterInteractionController.__c.NativeFieldInfoPtr___9__110_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<InteractionZone>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<InteractionZone>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterInteractionController.__c.NativeFieldInfoPtr___9__110_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<>c__DisplayClass68_0")]
  public sealed class __c__DisplayClass68_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__bridgeZone_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

    static __c__DisplayClass68_0()
    {
      Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<>c__DisplayClass68_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass68_0>.NativeClassPtr);
      CharacterInteractionController.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass68_0>.NativeClassPtr, "<>4__this");
      CharacterInteractionController.__c__DisplayClass68_0.NativeFieldInfoPtr__bridgeZone_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass68_0>.NativeClassPtr, "<bridgeZone>5__2");
      CharacterInteractionController.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass68_0>.NativeClassPtr, 100675325);
      CharacterInteractionController.__c__DisplayClass68_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass68_0>.NativeClassPtr, 100675326);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass68_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass68_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116331, XrefRangeEnd = 116337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Internal_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass68_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe CharacterInteractionController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InteractionBridgeZone _bridgeZone_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass68_0.NativeFieldInfoPtr__bridgeZone_5__2));
        return num == System.IntPtr.Zero ? (InteractionBridgeZone) null : Il2CppObjectPool.Get<InteractionBridgeZone>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass68_0.NativeFieldInfoPtr__bridgeZone_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<>c__DisplayClass82_0")]
  public sealed class __c__DisplayClass82_0 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_timer;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

    static __c__DisplayClass82_0()
    {
      Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<>c__DisplayClass82_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass82_0>.NativeClassPtr);
      CharacterInteractionController.__c__DisplayClass82_0.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass82_0>.NativeClassPtr, nameof (timer));
      CharacterInteractionController.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass82_0>.NativeClassPtr, "<>4__this");
    }

    public __c__DisplayClass82_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass82_0()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass82_0>.NativeClassPtr))
    {
    }

    public unsafe float timer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass82_0.NativeFieldInfoPtr_timer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass82_0.NativeFieldInfoPtr_timer)) = value;
      }
    }

    public unsafe CharacterInteractionController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<>c__DisplayClass83_0")]
  public sealed class __c__DisplayClass83_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_zone;
    private static readonly System.IntPtr NativeFieldInfoPtr_activationPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_turnToPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_stopAtPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_action;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

    static __c__DisplayClass83_0()
    {
      Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<>c__DisplayClass83_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr);
      CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
      CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, nameof (zone));
      CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_activationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, nameof (activationPoint));
      CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_turnToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, nameof (turnToPoint));
      CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_stopAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, nameof (stopAtPoint));
      CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, nameof (action));
      CharacterInteractionController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, 100675327);
      CharacterInteractionController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, 100675328 /*0x06002F00*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass83_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116346, XrefRangeEnd = 116350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe CharacterInteractionController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform zone
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_zone));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_zone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform activationPoint
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_activationPoint));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_activationPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform turnToPoint
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_turnToPoint));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_turnToPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool stopAtPoint
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_stopAtPoint));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_stopAtPoint)) = value;
      }
    }

    public unsafe Il2CppSystem.Action action
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_action));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<>c__DisplayClass83_0+<<FakeInputMoveToPoint>g__Walk|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
      {
        Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0>.NativeClassPtr, "<<FakeInputMoveToPoint>g__Walk|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675329);
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675330);
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675331);
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675332);
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675333);
        CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675334);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116337, XrefRangeEnd = 116341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116341, XrefRangeEnd = 116346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CharacterInteractionController.__c__DisplayClass83_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (CharacterInteractionController.__c__DisplayClass83_0) null : Il2CppObjectPool.Get<CharacterInteractionController.__c__DisplayClass83_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<>c__DisplayClass96_0")]
  public sealed class __c__DisplayClass96_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_carryBattery;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

    static __c__DisplayClass96_0()
    {
      Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<>c__DisplayClass96_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr);
      CharacterInteractionController.__c__DisplayClass96_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr, "<>4__this");
      CharacterInteractionController.__c__DisplayClass96_0.NativeFieldInfoPtr_carryBattery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr, nameof (carryBattery));
      CharacterInteractionController.__c__DisplayClass96_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr, 100675335);
      CharacterInteractionController.__c__DisplayClass96_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr, 100675336);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass96_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116359, XrefRangeEnd = 116363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe CharacterInteractionController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CarryableBattery carryBattery
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.NativeFieldInfoPtr_carryBattery));
        return num == System.IntPtr.Zero ? (CarryableBattery) null : Il2CppObjectPool.Get<CarryableBattery>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.NativeFieldInfoPtr_carryBattery), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<>c__DisplayClass96_0+<<SwitchToPlugOutState>g__WaitForPlugOut|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
      {
        Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0>.NativeClassPtr, "<<SwitchToPlugOutState>g__WaitForPlugOut|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675337);
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675338);
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675339);
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675340);
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675341);
        CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675342);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116350, XrefRangeEnd = 116354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116354, XrefRangeEnd = 116359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CharacterInteractionController.__c__DisplayClass96_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (CharacterInteractionController.__c__DisplayClass96_0) null : Il2CppObjectPool.Get<CharacterInteractionController.__c__DisplayClass96_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController.__c__DisplayClass96_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<FakeInputMoveToPointCoro>d__82")]
  public sealed class _FakeInputMoveToPointCoro_d__82(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_activationPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_zone;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr_stopAtPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_turnToPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_action;
    private static readonly System.IntPtr NativeFieldInfoPtr__target_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__currentlyRight_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__velocity_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _FakeInputMoveToPointCoro_d__82()
    {
      Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<FakeInputMoveToPointCoro>d__82");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr);
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, "<>1__state");
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, "<>2__current");
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, "<>4__this");
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_activationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, nameof (activationPoint));
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, nameof (zone));
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, "<>8__1");
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_stopAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, nameof (stopAtPoint));
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_turnToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, nameof (turnToPoint));
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, nameof (action));
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__target_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, "<target>5__2");
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__currentlyRight_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, "<currentlyRight>5__3");
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__velocity_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, "<velocity>5__4");
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, 100675343);
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, 100675344);
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, 100675345);
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, 100675346);
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, 100675347);
      CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr, 100675348);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _FakeInputMoveToPointCoro_d__82(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController._FakeInputMoveToPointCoro_d__82>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116363, XrefRangeEnd = 116456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116456, XrefRangeEnd = 116461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterInteractionController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform activationPoint
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_activationPoint));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_activationPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform zone
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_zone));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_zone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CharacterInteractionController.__c__DisplayClass82_0 __8__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___8__1);
        return new CharacterInteractionController.__c__DisplayClass82_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass82_0>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr___8__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterInteractionController.__c__DisplayClass82_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool stopAtPoint
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_stopAtPoint));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_stopAtPoint)) = value;
      }
    }

    public unsafe Transform turnToPoint
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_turnToPoint));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_turnToPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action action
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_action));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _target_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__target_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__target_5__2)) = value;
      }
    }

    public unsafe bool _currentlyRight_5__3
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__currentlyRight_5__3));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__currentlyRight_5__3)) = value;
      }
    }

    public unsafe Vector3 _velocity_5__4
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__velocity_5__4));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._FakeInputMoveToPointCoro_d__82.NativeFieldInfoPtr__velocity_5__4)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<ResetPrompt>d__79")]
  public sealed class _ResetPrompt_d__79 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_manual;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _ResetPrompt_d__79()
    {
      Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<ResetPrompt>d__79");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr);
      CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr, "<>1__state");
      CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr, "<>t__builder");
      CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr, "<>4__this");
      CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr_manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr, nameof (manual));
      CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr, "<>u__1");
      CharacterInteractionController._ResetPrompt_d__79.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr, 100675349);
      CharacterInteractionController._ResetPrompt_d__79.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr, 100675350);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 116486, RefRangeEnd = 116489, XrefRangeStart = 116461, XrefRangeEnd = 116486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._ResetPrompt_d__79.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._ResetPrompt_d__79.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _ResetPrompt_d__79(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _ResetPrompt_d__79()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController._ResetPrompt_d__79>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CharacterInteractionController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool manual
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr_manual));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr_manual)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._ResetPrompt_d__79.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterInteractionController+<SwitchToPlugInState>d__97")]
  public sealed class _SwitchToPlugInState_d__97(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

    static _SwitchToPlugInState_d__97()
    {
      Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInteractionController>.NativeClassPtr, "<SwitchToPlugInState>d__97");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr);
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, "<>1__state");
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, "<>2__current");
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, "<>4__this");
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, 100675351);
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, 100675352);
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, 100675353);
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, 100675354);
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, 100675355);
      CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr, 100675356);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _SwitchToPlugInState_d__97(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInteractionController._SwitchToPlugInState_d__97>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116489, XrefRangeEnd = 116494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116494, XrefRangeEnd = 116499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterInteractionController._SwitchToPlugInState_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterInteractionController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterInteractionController._SwitchToPlugInState_d__97.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
