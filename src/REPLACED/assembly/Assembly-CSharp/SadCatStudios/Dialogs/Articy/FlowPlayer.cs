// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Articy.Unity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using MessagePipe;
using SadCatStudios.Foundation;
using SadCatStudios.Foundation.Events;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowPlayer(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialDialogue;
  private static readonly System.IntPtr NativeFieldInfoPtr_cinemachineBrainGUID;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_onDialogStarted;
  private static readonly System.IntPtr NativeFieldInfoPtr_onDialogEnded;
  private static readonly System.IntPtr NativeFieldInfoPtr_dontSaveAfterDialogue;
  private static readonly System.IntPtr NativeFieldInfoPtr_autoSkipAfter;
  private static readonly System.IntPtr NativeFieldInfoPtr_dialogueEndPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_dialogueStartPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_textHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerLockHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_timelineHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_cinemachineHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_clipHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_idleHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveToPointHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_curvedMotionHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_timerHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_teleportHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_soundHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_portalHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_itemHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_pcInterfaceHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_boltUnityEventHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_articyFlowPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_flowGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseFlowGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
  private static readonly System.IntPtr NativeFieldInfoPtr_seenDialogueChoices;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastPausedObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerJustPaused;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockPromises;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TextHandler_Public_get_FlowTextHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerLockHandler_Public_get_FlowPlayerLockHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TimelineHandler_Public_get_FlowTimelineHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CinemachineHandler_Public_get_FlowCinemachineHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClipHandler_Public_get_FlowClipHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IdleHandler_Public_get_FlowIdleHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GameObjectHandler_Public_get_FlowGameObjectHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MoveToPointHandler_Public_get_FlowMoveToPointHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurvedMotionHandler_Public_get_FlowCurvedMotionHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FallHandler_Public_get_FlowFallHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TimerHandler_Public_get_FlowTimerHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TeleportHandler_Public_get_FlowTeleportHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SoundHandler_Public_get_FlowSoundHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PortalHandler_Public_get_FlowPortalHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemHandler_Public_get_FlowItemHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PCInterfaceHandler_Public_get_FlowPCInterfaceHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BoltUnityEventHandler_Public_get_FlowBoltUnityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartFlow_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunFlow_Public_UniTask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunHandlers_Private_UniTask_List_1_FlowElementBlock_DialogueFragment_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveAfterDialogue_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_GuidReference_0;

  static FlowPlayer()
  {
    Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowPlayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr);
    FlowPlayer.NativeFieldInfoPtr_tutorialDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (tutorialDialogue));
    FlowPlayer.NativeFieldInfoPtr_cinemachineBrainGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (cinemachineBrainGUID));
    FlowPlayer.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (playerReference));
    FlowPlayer.NativeFieldInfoPtr_onDialogStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (onDialogStarted));
    FlowPlayer.NativeFieldInfoPtr_onDialogEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (onDialogEnded));
    FlowPlayer.NativeFieldInfoPtr_dontSaveAfterDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (dontSaveAfterDialogue));
    FlowPlayer.NativeFieldInfoPtr_autoSkipAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (autoSkipAfter));
    FlowPlayer.NativeFieldInfoPtr_dialogueEndPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (dialogueEndPublisher));
    FlowPlayer.NativeFieldInfoPtr_dialogueStartPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (dialogueStartPublisher));
    FlowPlayer.NativeFieldInfoPtr_textHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (textHandler));
    FlowPlayer.NativeFieldInfoPtr_playerLockHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (playerLockHandler));
    FlowPlayer.NativeFieldInfoPtr_timelineHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (timelineHandler));
    FlowPlayer.NativeFieldInfoPtr_cinemachineHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (cinemachineHandler));
    FlowPlayer.NativeFieldInfoPtr_clipHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (clipHandler));
    FlowPlayer.NativeFieldInfoPtr_idleHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (idleHandler));
    FlowPlayer.NativeFieldInfoPtr_gameObjectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (gameObjectHandler));
    FlowPlayer.NativeFieldInfoPtr_moveToPointHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (moveToPointHandler));
    FlowPlayer.NativeFieldInfoPtr_curvedMotionHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (curvedMotionHandler));
    FlowPlayer.NativeFieldInfoPtr_fallHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (fallHandler));
    FlowPlayer.NativeFieldInfoPtr_timerHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (timerHandler));
    FlowPlayer.NativeFieldInfoPtr_teleportHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (teleportHandler));
    FlowPlayer.NativeFieldInfoPtr_soundHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (soundHandler));
    FlowPlayer.NativeFieldInfoPtr_portalHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (portalHandler));
    FlowPlayer.NativeFieldInfoPtr_itemHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (itemHandler));
    FlowPlayer.NativeFieldInfoPtr_pcInterfaceHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (pcInterfaceHandler));
    FlowPlayer.NativeFieldInfoPtr_boltUnityEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (boltUnityEventHandler));
    FlowPlayer.NativeFieldInfoPtr_articyFlowPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (articyFlowPlayer));
    FlowPlayer.NativeFieldInfoPtr_flowGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (flowGraph));
    FlowPlayer.NativeFieldInfoPtr_baseFlowGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (baseFlowGraph));
    FlowPlayer.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (saveData));
    FlowPlayer.NativeFieldInfoPtr_seenDialogueChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (seenDialogueChoices));
    FlowPlayer.NativeFieldInfoPtr_lastPausedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (lastPausedObject));
    FlowPlayer.NativeFieldInfoPtr_playerJustPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (playerJustPaused));
    FlowPlayer.NativeFieldInfoPtr_blockPromises = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (blockPromises));
    FlowPlayer.NativeMethodInfoPtr_get_TextHandler_Public_get_FlowTextHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672882);
    FlowPlayer.NativeMethodInfoPtr_get_PlayerLockHandler_Public_get_FlowPlayerLockHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672883);
    FlowPlayer.NativeMethodInfoPtr_get_TimelineHandler_Public_get_FlowTimelineHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672884);
    FlowPlayer.NativeMethodInfoPtr_get_CinemachineHandler_Public_get_FlowCinemachineHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672885);
    FlowPlayer.NativeMethodInfoPtr_get_ClipHandler_Public_get_FlowClipHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672886);
    FlowPlayer.NativeMethodInfoPtr_get_IdleHandler_Public_get_FlowIdleHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672887);
    FlowPlayer.NativeMethodInfoPtr_get_GameObjectHandler_Public_get_FlowGameObjectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672888);
    FlowPlayer.NativeMethodInfoPtr_get_MoveToPointHandler_Public_get_FlowMoveToPointHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672889);
    FlowPlayer.NativeMethodInfoPtr_get_CurvedMotionHandler_Public_get_FlowCurvedMotionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672890);
    FlowPlayer.NativeMethodInfoPtr_get_FallHandler_Public_get_FlowFallHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672891);
    FlowPlayer.NativeMethodInfoPtr_get_TimerHandler_Public_get_FlowTimerHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672892);
    FlowPlayer.NativeMethodInfoPtr_get_TeleportHandler_Public_get_FlowTeleportHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672893);
    FlowPlayer.NativeMethodInfoPtr_get_SoundHandler_Public_get_FlowSoundHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672894);
    FlowPlayer.NativeMethodInfoPtr_get_PortalHandler_Public_get_FlowPortalHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672895);
    FlowPlayer.NativeMethodInfoPtr_get_ItemHandler_Public_get_FlowItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672896);
    FlowPlayer.NativeMethodInfoPtr_get_PCInterfaceHandler_Public_get_FlowPCInterfaceHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672897);
    FlowPlayer.NativeMethodInfoPtr_get_BoltUnityEventHandler_Public_get_FlowBoltUnityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672898);
    FlowPlayer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672899);
    FlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672900);
    FlowPlayer.NativeMethodInfoPtr_StartFlow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672901);
    FlowPlayer.NativeMethodInfoPtr_RunFlow_Public_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672902);
    FlowPlayer.NativeMethodInfoPtr_RunHandlers_Private_UniTask_List_1_FlowElementBlock_DialogueFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672903);
    FlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672904);
    FlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672905);
    FlowPlayer.NativeMethodInfoPtr_SaveAfterDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672906);
    FlowPlayer.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672907);
    FlowPlayer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672908);
    FlowPlayer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672909);
    FlowPlayer.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672910);
    FlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672911);
    FlowPlayer.NativeMethodInfoPtr_Method_Internal_Static_Void_GuidReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, 100672912);
  }

  public unsafe FlowTextHandler TextHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104642, XrefRangeEnd = 104649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_TextHandler_Public_get_FlowTextHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowTextHandler) null : Il2CppObjectPool.Get<FlowTextHandler>(num3);
    }
  }

  public unsafe FlowPlayerLockHandler PlayerLockHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104649, XrefRangeEnd = 104665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_PlayerLockHandler_Public_get_FlowPlayerLockHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowPlayerLockHandler) null : Il2CppObjectPool.Get<FlowPlayerLockHandler>(num3);
    }
  }

  public unsafe FlowTimelineHandler TimelineHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104665, XrefRangeEnd = 104669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_TimelineHandler_Public_get_FlowTimelineHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowTimelineHandler) null : Il2CppObjectPool.Get<FlowTimelineHandler>(num3);
    }
  }

  public unsafe FlowCinemachineHandler CinemachineHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104669, XrefRangeEnd = 104676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_CinemachineHandler_Public_get_FlowCinemachineHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowCinemachineHandler) null : Il2CppObjectPool.Get<FlowCinemachineHandler>(num3);
    }
  }

  public unsafe FlowClipHandler ClipHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104676, XrefRangeEnd = 104680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_ClipHandler_Public_get_FlowClipHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowClipHandler) null : Il2CppObjectPool.Get<FlowClipHandler>(num3);
    }
  }

  public unsafe FlowIdleHandler IdleHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104680, XrefRangeEnd = 104684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_IdleHandler_Public_get_FlowIdleHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowIdleHandler) null : Il2CppObjectPool.Get<FlowIdleHandler>(num3);
    }
  }

  public unsafe FlowGameObjectHandler GameObjectHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104684, XrefRangeEnd = 104688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_GameObjectHandler_Public_get_FlowGameObjectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowGameObjectHandler) null : Il2CppObjectPool.Get<FlowGameObjectHandler>(num3);
    }
  }

  public unsafe FlowMoveToPointHandler MoveToPointHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104688, XrefRangeEnd = 104692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_MoveToPointHandler_Public_get_FlowMoveToPointHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowMoveToPointHandler) null : Il2CppObjectPool.Get<FlowMoveToPointHandler>(num3);
    }
  }

  public unsafe FlowCurvedMotionHandler CurvedMotionHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104692, XrefRangeEnd = 104696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_CurvedMotionHandler_Public_get_FlowCurvedMotionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowCurvedMotionHandler) null : Il2CppObjectPool.Get<FlowCurvedMotionHandler>(num3);
    }
  }

  public unsafe FlowFallHandler FallHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104696, XrefRangeEnd = 104700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_FallHandler_Public_get_FlowFallHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowFallHandler) null : Il2CppObjectPool.Get<FlowFallHandler>(num3);
    }
  }

  public unsafe FlowTimerHandler TimerHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104700, XrefRangeEnd = 104704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_TimerHandler_Public_get_FlowTimerHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowTimerHandler) null : Il2CppObjectPool.Get<FlowTimerHandler>(num3);
    }
  }

  public unsafe FlowTeleportHandler TeleportHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104704, XrefRangeEnd = 104708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_TeleportHandler_Public_get_FlowTeleportHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowTeleportHandler) null : Il2CppObjectPool.Get<FlowTeleportHandler>(num3);
    }
  }

  public unsafe FlowSoundHandler SoundHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104708, XrefRangeEnd = 104712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_SoundHandler_Public_get_FlowSoundHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowSoundHandler) null : Il2CppObjectPool.Get<FlowSoundHandler>(num3);
    }
  }

  public unsafe FlowPortalHandler PortalHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104712, XrefRangeEnd = 104719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_PortalHandler_Public_get_FlowPortalHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowPortalHandler) null : Il2CppObjectPool.Get<FlowPortalHandler>(num3);
    }
  }

  public unsafe FlowItemHandler ItemHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104719, XrefRangeEnd = 104723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_ItemHandler_Public_get_FlowItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowItemHandler) null : Il2CppObjectPool.Get<FlowItemHandler>(num3);
    }
  }

  public unsafe FlowPCInterfaceHandler PCInterfaceHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104723, XrefRangeEnd = 104727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_PCInterfaceHandler_Public_get_FlowPCInterfaceHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowPCInterfaceHandler) null : Il2CppObjectPool.Get<FlowPCInterfaceHandler>(num3);
    }
  }

  public unsafe FlowBoltUnityEventHandler BoltUnityEventHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104727, XrefRangeEnd = 104731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_get_BoltUnityEventHandler_Public_get_FlowBoltUnityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowBoltUnityEventHandler) null : Il2CppObjectPool.Get<FlowBoltUnityEventHandler>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104731, XrefRangeEnd = 104734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104734, XrefRangeEnd = 104745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104745, XrefRangeEnd = 104751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartFlow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_StartFlow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104751, XrefRangeEnd = 104756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask RunFlow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_RunFlow_Public_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 104761, RefRangeEnd = 104764, XrefRangeStart = 104756, XrefRangeEnd = 104761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask RunHandlers(
    List<FlowElementBlock> blocks,
    DialogueFragment dialogueFragment = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blocks);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dialogueFragment);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_RunHandlers_Private_UniTask_List_1_FlowElementBlock_DialogueFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  public virtual unsafe void OnFlowPlayerPaused(IFlowObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBranchesUpdated(IList<Branch> aBranches)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranches)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104764, XrefRangeEnd = 104769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SaveAfterDialogue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_SaveAfterDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104769, XrefRangeEnd = 104772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Vector3 PlayerPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104772, XrefRangeEnd = 104779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104779, XrefRangeEnd = 104790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104790, XrefRangeEnd = 104809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104809, XrefRangeEnd = 104826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowPlayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 104836, RefRangeEnd = 104838, XrefRangeStart = 104826, XrefRangeEnd = 104836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Internal_Static_Void_GuidReference_0<T>(GuidReference refToAssign) where T : MonoBehaviour
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) refToAssign)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayer.MethodInfoStoreGeneric_Method_Internal_Static_Void_GuidReference_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool tutorialDialogue
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_tutorialDialogue));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_tutorialDialogue)) = value;
    }
  }

  public unsafe GuidReference cinemachineBrainGUID
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_cinemachineBrainGUID));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_cinemachineBrainGUID), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_playerReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onDialogStarted
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_onDialogStarted));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_onDialogStarted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onDialogEnded
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_onDialogEnded));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_onDialogEnded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool dontSaveAfterDialogue
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_dontSaveAfterDialogue));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_dontSaveAfterDialogue)) = value;
    }
  }

  public unsafe float autoSkipAfter
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_autoSkipAfter));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_autoSkipAfter)) = value;
    }
  }

  public unsafe IPublisher<DialogueFlowEndEvent> dialogueEndPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_dialogueEndPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<DialogueFlowEndEvent>) null : Il2CppObjectPool.Get<IPublisher<DialogueFlowEndEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_dialogueEndPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<DialogueFlowStartEvent> dialogueStartPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_dialogueStartPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<DialogueFlowStartEvent>) null : Il2CppObjectPool.Get<IPublisher<DialogueFlowStartEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_dialogueStartPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowTextHandler textHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_textHandler));
      return num == System.IntPtr.Zero ? (FlowTextHandler) null : Il2CppObjectPool.Get<FlowTextHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_textHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowPlayerLockHandler playerLockHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_playerLockHandler));
      return num == System.IntPtr.Zero ? (FlowPlayerLockHandler) null : Il2CppObjectPool.Get<FlowPlayerLockHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_playerLockHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowTimelineHandler timelineHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_timelineHandler));
      return num == System.IntPtr.Zero ? (FlowTimelineHandler) null : Il2CppObjectPool.Get<FlowTimelineHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_timelineHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowCinemachineHandler cinemachineHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_cinemachineHandler));
      return num == System.IntPtr.Zero ? (FlowCinemachineHandler) null : Il2CppObjectPool.Get<FlowCinemachineHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_cinemachineHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowClipHandler clipHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_clipHandler));
      return num == System.IntPtr.Zero ? (FlowClipHandler) null : Il2CppObjectPool.Get<FlowClipHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_clipHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowIdleHandler idleHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_idleHandler));
      return num == System.IntPtr.Zero ? (FlowIdleHandler) null : Il2CppObjectPool.Get<FlowIdleHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_idleHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowGameObjectHandler gameObjectHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_gameObjectHandler));
      return num == System.IntPtr.Zero ? (FlowGameObjectHandler) null : Il2CppObjectPool.Get<FlowGameObjectHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_gameObjectHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowMoveToPointHandler moveToPointHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_moveToPointHandler));
      return num == System.IntPtr.Zero ? (FlowMoveToPointHandler) null : Il2CppObjectPool.Get<FlowMoveToPointHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_moveToPointHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowCurvedMotionHandler curvedMotionHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_curvedMotionHandler));
      return num == System.IntPtr.Zero ? (FlowCurvedMotionHandler) null : Il2CppObjectPool.Get<FlowCurvedMotionHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_curvedMotionHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowFallHandler fallHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_fallHandler));
      return num == System.IntPtr.Zero ? (FlowFallHandler) null : Il2CppObjectPool.Get<FlowFallHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_fallHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowTimerHandler timerHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_timerHandler));
      return num == System.IntPtr.Zero ? (FlowTimerHandler) null : Il2CppObjectPool.Get<FlowTimerHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_timerHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowTeleportHandler teleportHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_teleportHandler));
      return num == System.IntPtr.Zero ? (FlowTeleportHandler) null : Il2CppObjectPool.Get<FlowTeleportHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_teleportHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowSoundHandler soundHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_soundHandler));
      return num == System.IntPtr.Zero ? (FlowSoundHandler) null : Il2CppObjectPool.Get<FlowSoundHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_soundHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowPortalHandler portalHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_portalHandler));
      return num == System.IntPtr.Zero ? (FlowPortalHandler) null : Il2CppObjectPool.Get<FlowPortalHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_portalHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowItemHandler itemHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_itemHandler));
      return num == System.IntPtr.Zero ? (FlowItemHandler) null : Il2CppObjectPool.Get<FlowItemHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_itemHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowPCInterfaceHandler pcInterfaceHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_pcInterfaceHandler));
      return num == System.IntPtr.Zero ? (FlowPCInterfaceHandler) null : Il2CppObjectPool.Get<FlowPCInterfaceHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_pcInterfaceHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowBoltUnityEventHandler boltUnityEventHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_boltUnityEventHandler));
      return num == System.IntPtr.Zero ? (FlowBoltUnityEventHandler) null : Il2CppObjectPool.Get<FlowBoltUnityEventHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_boltUnityEventHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyFlowPlayer articyFlowPlayer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_articyFlowPlayer));
      return num == System.IntPtr.Zero ? (ArticyFlowPlayer) null : Il2CppObjectPool.Get<ArticyFlowPlayer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_articyFlowPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowGraph flowGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_flowGraph));
      return num == System.IntPtr.Zero ? (FlowGraph) null : Il2CppObjectPool.Get<FlowGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_flowGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowGraph baseFlowGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_baseFlowGraph));
      return num == System.IntPtr.Zero ? (FlowGraph) null : Il2CppObjectPool.Get<FlowGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_baseFlowGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowPlayer.FlowPlayerSaveData saveData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_saveData));
      return num == System.IntPtr.Zero ? (FlowPlayer.FlowPlayerSaveData) null : Il2CppObjectPool.Get<FlowPlayer.FlowPlayerSaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<ulong> seenDialogueChoices
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_seenDialogueChoices));
      return num == System.IntPtr.Zero ? (HashSet<ulong>) null : Il2CppObjectPool.Get<HashSet<ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_seenDialogueChoices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IFlowObject lastPausedObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_lastPausedObject));
      return num == System.IntPtr.Zero ? (IFlowObject) null : Il2CppObjectPool.Get<IFlowObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_lastPausedObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool playerJustPaused
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_playerJustPaused));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_playerJustPaused)) = value;
    }
  }

  public unsafe List<UniTask> blockPromises
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_blockPromises));
      return num == System.IntPtr.Zero ? (List<UniTask>) null : Il2CppObjectPool.Get<List<UniTask>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.NativeFieldInfoPtr_blockPromises), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class FlowPlayerSaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SeenDialogueChoices;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentDialogueId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static FlowPlayerSaveData()
    {
      Il2CppClassPointerStore<FlowPlayer.FlowPlayerSaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, nameof (FlowPlayerSaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayer.FlowPlayerSaveData>.NativeClassPtr);
      FlowPlayer.FlowPlayerSaveData.NativeFieldInfoPtr_SeenDialogueChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer.FlowPlayerSaveData>.NativeClassPtr, nameof (SeenDialogueChoices));
      FlowPlayer.FlowPlayerSaveData.NativeFieldInfoPtr_CurrentDialogueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer.FlowPlayerSaveData>.NativeClassPtr, nameof (CurrentDialogueId));
      FlowPlayer.FlowPlayerSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer.FlowPlayerSaveData>.NativeClassPtr, 100672913);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FlowPlayerSaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayer.FlowPlayerSaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPlayer.FlowPlayerSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppStructArray<ulong> SeenDialogueChoices
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.FlowPlayerSaveData.NativeFieldInfoPtr_SeenDialogueChoices));
        return num == System.IntPtr.Zero ? (Il2CppStructArray<ulong>) null : Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.FlowPlayerSaveData.NativeFieldInfoPtr_SeenDialogueChoices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ulong CurrentDialogueId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.FlowPlayerSaveData.NativeFieldInfoPtr_CurrentDialogueId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer.FlowPlayerSaveData.NativeFieldInfoPtr_CurrentDialogueId)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowPlayer+<RunFlow>d__72")]
  public sealed class _RunFlow_d__72 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__shouldExit_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__nextAfterBranching_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__3;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _RunFlow_d__72()
    {
      Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, "<RunFlow>d__72");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr);
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<>1__state");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<>t__builder");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<>4__this");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr__shouldExit_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<shouldExit>5__2");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr__nextAfterBranching_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<nextAfterBranching>5__3");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<>u__1");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<>u__2");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<>7__wrap3");
      FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, "<>u__3");
      FlowPlayer._RunFlow_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, 100672914);
      FlowPlayer._RunFlow_d__72.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr, 100672915);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 104591, RefRangeEnd = 104594, XrefRangeStart = 104381, XrefRangeEnd = 104591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPlayer._RunFlow_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowPlayer._RunFlow_d__72.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _RunFlow_d__72(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _RunFlow_d__72()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayer._RunFlow_d__72>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowPlayer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowPlayer) null : Il2CppObjectPool.Get<FlowPlayer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _shouldExit_5__2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr__shouldExit_5__2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr__shouldExit_5__2)) = value;
      }
    }

    public unsafe bool _nextAfterBranching_5__3
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr__nextAfterBranching_5__3));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr__nextAfterBranching_5__3)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__2
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__2));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__2)) = value;
      }
    }

    public unsafe IList<Branch> __7__wrap3
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___7__wrap3));
        return num == System.IntPtr.Zero ? (IList<Branch>) null : Il2CppObjectPool.Get<IList<Branch>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask<int>.Awaiter __u__3
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__3);
        return new UniTask<int>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunFlow_d__72.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowPlayer+<RunHandlers>d__73")]
  public sealed class _RunHandlers_d__73 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_blocks;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_dialogueFragment;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _RunHandlers_d__73()
    {
      Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr, "<RunHandlers>d__73");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr);
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, "<>1__state");
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, "<>t__builder");
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, nameof (blocks));
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, "<>4__this");
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr_dialogueFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, nameof (dialogueFragment));
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, "<>7__wrap1");
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, "<>7__wrap2");
      FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, "<>u__1");
      FlowPlayer._RunHandlers_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, 100672916);
      FlowPlayer._RunHandlers_d__73.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr, 100672917);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 104640, RefRangeEnd = 104642, XrefRangeStart = 104594, XrefRangeEnd = 104640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPlayer._RunHandlers_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowPlayer._RunHandlers_d__73.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _RunHandlers_d__73(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _RunHandlers_d__73()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayer._RunHandlers_d__73>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<FlowElementBlock> blocks
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr_blocks));
        return num == System.IntPtr.Zero ? (List<FlowElementBlock>) null : Il2CppObjectPool.Get<List<FlowElementBlock>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr_blocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FlowPlayer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowPlayer) null : Il2CppObjectPool.Get<FlowPlayer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DialogueFragment dialogueFragment
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr_dialogueFragment));
        return num == System.IntPtr.Zero ? (DialogueFragment) null : Il2CppObjectPool.Get<DialogueFragment>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr_dialogueFragment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Il2CppReferenceArray<FlowSequence>> __7__wrap1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___7__wrap1));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppReferenceArray<FlowSequence>>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<FlowSequence>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int __7__wrap2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___7__wrap2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___7__wrap2)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayer._RunHandlers_d__73.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_GuidReference_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(FlowPlayer.NativeMethodInfoPtr_Method_Internal_Static_Void_GuidReference_0, Il2CppClassPointerStore<FlowPlayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
