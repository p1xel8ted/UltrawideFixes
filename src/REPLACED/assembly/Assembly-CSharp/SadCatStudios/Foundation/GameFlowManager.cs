// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.GameFlowManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using MessagePipe;
using SadCatStudios.Foundation.Events;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation;

public class GameFlowManager(System.IntPtr pointer) : LocalSingletonBehaviour<GameFlowManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_resetPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_init;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultSpawn;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultFSM;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultAbilities;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultArticyItems;
  private static readonly System.IntPtr NativeFieldInfoPtr_serializedSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_serializedSetCopy;
  private static readonly System.IntPtr NativeFieldInfoPtr_serializedSetDiff;
  private static readonly System.IntPtr NativeFieldInfoPtr_sortedInitializtaionList;
  private static readonly System.IntPtr NativeFieldInfoPtr_flowState;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsResetting_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__StartedResetting_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_LastCheckpointSender;
  private static readonly System.IntPtr NativeFieldInfoPtr_LastSaveTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FlowState_Public_get_GameFlowState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FlowState_Public_set_Void_GameFlowState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultFSM_Public_get_FSMGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultAbilities_Public_get_Abilities_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultArticyItems_Public_get_IEnumerable_1_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsResetting_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsResetting_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartedResetting_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartedResetting_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultSpawn_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerDefaultFSM_Public_Void_FSMGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultAbilities_Public_Void_Abilities_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultArticyItems_Public_Void_IEnumerable_1_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForLoading_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetFlow_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterController_Public_Void_GameFlowSerializer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterController_Public_Void_GameFlowSerializer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadWithDelay_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForReset_Private_IEnumerator_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoLoadAndInit_Public_IEnumerator_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__33_0_Private_Void_BeginResetToCheckpointEvent_0;

  static GameFlowManager()
  {
    Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (GameFlowManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr);
    GameFlowManager.NativeFieldInfoPtr_resetPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (resetPublisher));
    GameFlowManager.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (eventDisposable));
    GameFlowManager.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (init));
    GameFlowManager.NativeFieldInfoPtr_defaultSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (defaultSpawn));
    GameFlowManager.NativeFieldInfoPtr_defaultFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (defaultFSM));
    GameFlowManager.NativeFieldInfoPtr_defaultAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (defaultAbilities));
    GameFlowManager.NativeFieldInfoPtr_defaultArticyItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (defaultArticyItems));
    GameFlowManager.NativeFieldInfoPtr_serializedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (serializedSet));
    GameFlowManager.NativeFieldInfoPtr_serializedSetCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (serializedSetCopy));
    GameFlowManager.NativeFieldInfoPtr_serializedSetDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (serializedSetDiff));
    GameFlowManager.NativeFieldInfoPtr_sortedInitializtaionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (sortedInitializtaionList));
    GameFlowManager.NativeFieldInfoPtr_flowState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (flowState));
    GameFlowManager.NativeFieldInfoPtr__IsResetting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<IsResetting>k__BackingField");
    GameFlowManager.NativeFieldInfoPtr__StartedResetting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<StartedResetting>k__BackingField");
    GameFlowManager.NativeFieldInfoPtr_LastCheckpointSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (LastCheckpointSender));
    GameFlowManager.NativeFieldInfoPtr_LastSaveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, nameof (LastSaveTime));
    GameFlowManager.NativeMethodInfoPtr_get_FlowState_Public_get_GameFlowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671105);
    GameFlowManager.NativeMethodInfoPtr_set_FlowState_Public_set_Void_GameFlowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671106);
    GameFlowManager.NativeMethodInfoPtr_get_DefaultFSM_Public_get_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671107);
    GameFlowManager.NativeMethodInfoPtr_get_DefaultAbilities_Public_get_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671108);
    GameFlowManager.NativeMethodInfoPtr_get_DefaultArticyItems_Public_get_IEnumerable_1_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671109);
    GameFlowManager.NativeMethodInfoPtr_get_IsResetting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671110);
    GameFlowManager.NativeMethodInfoPtr_set_IsResetting_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671111);
    GameFlowManager.NativeMethodInfoPtr_get_StartedResetting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671112);
    GameFlowManager.NativeMethodInfoPtr_set_StartedResetting_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671113);
    GameFlowManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671114);
    GameFlowManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671115);
    GameFlowManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671116);
    GameFlowManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671117);
    GameFlowManager.NativeMethodInfoPtr_SetDefaultSpawn_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671118);
    GameFlowManager.NativeMethodInfoPtr_SetPlayerDefaultFSM_Public_Void_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671119);
    GameFlowManager.NativeMethodInfoPtr_SetDefaultAbilities_Public_Void_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671120);
    GameFlowManager.NativeMethodInfoPtr_SetDefaultArticyItems_Public_Void_IEnumerable_1_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671121);
    GameFlowManager.NativeMethodInfoPtr_WaitForLoading_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671122);
    GameFlowManager.NativeMethodInfoPtr_ResetFlow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671123);
    GameFlowManager.NativeMethodInfoPtr_RegisterController_Public_Void_GameFlowSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671124);
    GameFlowManager.NativeMethodInfoPtr_UnregisterController_Public_Void_GameFlowSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671125);
    GameFlowManager.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671126);
    GameFlowManager.NativeMethodInfoPtr_Save_Public_Void_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671127);
    GameFlowManager.NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671128);
    GameFlowManager.NativeMethodInfoPtr_LoadWithDelay_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671129);
    GameFlowManager.NativeMethodInfoPtr_WaitForReset_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671130);
    GameFlowManager.NativeMethodInfoPtr_DoLoadAndInit_Public_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671131);
    GameFlowManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671132);
    GameFlowManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671133);
    GameFlowManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671134);
    GameFlowManager.NativeMethodInfoPtr__Start_b__33_0_Private_Void_BeginResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, 100671135);
  }

  public unsafe GameFlowState FlowState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_get_FlowState_Public_get_GameFlowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameFlowState) null : Il2CppObjectPool.Get<GameFlowState>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_set_FlowState_Public_set_Void_GameFlowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe FSMGraph DefaultFSM
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_get_DefaultFSM_Public_get_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
    }
  }

  public unsafe Abilities DefaultAbilities
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_get_DefaultAbilities_Public_get_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Abilities*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe IEnumerable<ArticyRef> DefaultArticyItems
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_get_DefaultArticyItems_Public_get_IEnumerable_1_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerable<ArticyRef>) null : Il2CppObjectPool.Get<IEnumerable<ArticyRef>>(num3);
    }
  }

  public unsafe bool IsResetting
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 67512, RefRangeEnd = 67513, XrefRangeStart = 67512, XrefRangeEnd = 67513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_get_IsResetting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_set_IsResetting_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool StartedResetting
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_get_StartedResetting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_set_StartedResetting_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91228, XrefRangeEnd = 91242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameFlowManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91242, XrefRangeEnd = 91243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91243, XrefRangeEnd = 91247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91247, XrefRangeEnd = 91250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameFlowManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetDefaultSpawn(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_SetDefaultSpawn_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetPlayerDefaultFSM(FSMGraph graph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graph)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_SetPlayerDefaultFSM_Public_Void_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetDefaultAbilities(Abilities abilities)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &abilities
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_SetDefaultAbilities_Public_Void_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDefaultArticyItems(IEnumerable<ArticyRef> upgrades)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrades)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_SetDefaultArticyItems_Public_Void_IEnumerable_1_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91254, RefRangeEnd = 91255, XrefRangeStart = 91250, XrefRangeEnd = 91254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForLoading()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_WaitForLoading_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91255, XrefRangeEnd = 91261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetFlow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_ResetFlow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91265, RefRangeEnd = 91266, XrefRangeStart = 91261, XrefRangeEnd = 91265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterController(GameFlowSerializer serializedBehavior)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializedBehavior)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_RegisterController_Public_Void_GameFlowSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91270, RefRangeEnd = 91271, XrefRangeStart = 91266, XrefRangeEnd = 91270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterController(GameFlowSerializer serializedBehavior)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializedBehavior)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_UnregisterController_Public_Void_GameFlowSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Vector3 PlayerPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 91304, RefRangeEnd = 91314, XrefRangeStart = 91271, XrefRangeEnd = 91304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Save(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_Save_Public_Void_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91314, XrefRangeEnd = 91320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoadWithDelay(float delay)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delay
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_LoadWithDelay_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91320, XrefRangeEnd = 91324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForReset(float delay = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delay
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_WaitForReset_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91328, RefRangeEnd = 91329, XrefRangeStart = 91324, XrefRangeEnd = 91328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator DoLoadAndInit(bool dontLoadPlayer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dontLoadPlayer
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_DoLoadAndInit_Public_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91329, XrefRangeEnd = 91330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnApplicationQuit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91330, XrefRangeEnd = 91353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameFlowManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91353, XrefRangeEnd = 91357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91357, XrefRangeEnd = 91375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__33_0(BeginResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowManager.NativeMethodInfoPtr__Start_b__33_0_Private_Void_BeginResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe IPublisher<ResetToCheckpointEvent> resetPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_resetPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<ResetToCheckpointEvent>) null : Il2CppObjectPool.Get<IPublisher<ResetToCheckpointEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_resetPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool init
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_init));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_init)) = value;
    }
  }

  public unsafe Vector3 defaultSpawn
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultSpawn));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultSpawn)) = value;
    }
  }

  public unsafe FSMGraph defaultFSM
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultFSM));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultFSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Abilities defaultAbilities
  {
    get
    {
      return *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultAbilities));
    }
    [param: In] set
    {
      *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultAbilities)) = value;
    }
  }

  public unsafe IEnumerable<ArticyRef> defaultArticyItems
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultArticyItems));
      return num == System.IntPtr.Zero ? (IEnumerable<ArticyRef>) null : Il2CppObjectPool.Get<IEnumerable<ArticyRef>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_defaultArticyItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<GameFlowSerializer> serializedSet
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_serializedSet));
      return num == System.IntPtr.Zero ? (HashSet<GameFlowSerializer>) null : Il2CppObjectPool.Get<HashSet<GameFlowSerializer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_serializedSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<GameFlowSerializer> serializedSetCopy
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_serializedSetCopy));
      return num == System.IntPtr.Zero ? (HashSet<GameFlowSerializer>) null : Il2CppObjectPool.Get<HashSet<GameFlowSerializer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_serializedSetCopy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<GameFlowSerializer> serializedSetDiff
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_serializedSetDiff));
      return num == System.IntPtr.Zero ? (HashSet<GameFlowSerializer>) null : Il2CppObjectPool.Get<HashSet<GameFlowSerializer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_serializedSetDiff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameFlowSerializer> sortedInitializtaionList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_sortedInitializtaionList));
      return num == System.IntPtr.Zero ? (List<GameFlowSerializer>) null : Il2CppObjectPool.Get<List<GameFlowSerializer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_sortedInitializtaionList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameFlowState flowState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_flowState));
      return num == System.IntPtr.Zero ? (GameFlowState) null : Il2CppObjectPool.Get<GameFlowState>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_flowState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _IsResetting_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr__IsResetting_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr__IsResetting_k__BackingField)) = value;
    }
  }

  public unsafe bool _StartedResetting_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr__StartedResetting_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr__StartedResetting_k__BackingField)) = value;
    }
  }

  public unsafe ICheckpointSender LastCheckpointSender
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_LastCheckpointSender));
      return num == System.IntPtr.Zero ? (ICheckpointSender) null : Il2CppObjectPool.Get<ICheckpointSender>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_LastCheckpointSender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float LastSaveTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_LastSaveTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.NativeFieldInfoPtr_LastSaveTime)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<<DoAwake>g__DoLoad|31_0>d")]
  public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique(
    System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__statePromise_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique()
    {
      Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<<DoAwake>g__DoLoad|31_0>d");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr);
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, "<>1__state");
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, "<>2__current");
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, "<>4__this");
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr__statePromise_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, "<statePromise>5__2");
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, 100671136);
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, 100671137);
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, 100671138);
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, 100671139);
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, 100671140);
      GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr, 100671141);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique(
      int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91025, XrefRangeEnd = 91037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91037, XrefRangeEnd = 91042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFlowManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GameFlowManager) null : Il2CppObjectPool.Get<GameFlowManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Promise<GameFlowState> _statePromise_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr__statePromise_5__2));
        return num == System.IntPtr.Zero ? (Promise<GameFlowState>) null : Il2CppObjectPool.Get<Promise<GameFlowState>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaPr1GaObObUnique.NativeFieldInfoPtr__statePromise_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__48_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__DoLoadAndInit_b__48_1_Internal_Int32_GameFlowSerializer_GameFlowSerializer_0;

    static __c()
    {
      Il2CppClassPointerStore<GameFlowManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager.__c>.NativeClassPtr);
      GameFlowManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c>.NativeClassPtr, "<>9");
      GameFlowManager.__c.NativeFieldInfoPtr___9__48_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c>.NativeClassPtr, "<>9__48_1");
      GameFlowManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c>.NativeClassPtr, 100671143);
      GameFlowManager.__c.NativeMethodInfoPtr__DoLoadAndInit_b__48_1_Internal_Int32_GameFlowSerializer_GameFlowSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c>.NativeClassPtr, 100671144);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91042, XrefRangeEnd = 91044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _DoLoadAndInit_b__48_1(GameFlowSerializer a, GameFlowSerializer b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c.NativeMethodInfoPtr__DoLoadAndInit_b__48_1_Internal_Int32_GameFlowSerializer_GameFlowSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe GameFlowManager.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GameFlowManager.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GameFlowManager.__c) null : Il2CppObjectPool.Get<GameFlowManager.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameFlowManager.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<GameFlowSerializer> __9__48_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GameFlowManager.__c.NativeFieldInfoPtr___9__48_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<GameFlowSerializer>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<GameFlowSerializer>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameFlowManager.__c.NativeFieldInfoPtr___9__48_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<>c__DisplayClass48_0")]
  public sealed class __c__DisplayClass48_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_dontLoadPlayer;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_HashSet_1_GameFlowSerializer_0;

    static __c__DisplayClass48_0()
    {
      Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<>c__DisplayClass48_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr);
      GameFlowManager.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr, "<>4__this");
      GameFlowManager.__c__DisplayClass48_0.NativeFieldInfoPtr_dontLoadPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr, nameof (dontLoadPlayer));
      GameFlowManager.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr, 100671145);
      GameFlowManager.__c__DisplayClass48_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_HashSet_1_GameFlowSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr, 100671146);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass48_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 91116, RefRangeEnd = 91117, XrefRangeStart = 91112, XrefRangeEnd = 91116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_HashSet_1_GameFlowSerializer_0(
      HashSet<GameFlowSerializer> fromSet)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromSet)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_HashSet_1_GameFlowSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe GameFlowManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GameFlowManager) null : Il2CppObjectPool.Get<GameFlowManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool dontLoadPlayer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.NativeFieldInfoPtr_dontLoadPlayer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.NativeFieldInfoPtr_dontLoadPlayer)) = value;
      }
    }

    [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<>c__DisplayClass48_0+<<DoLoadAndInit>g__LoadAndInit|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_fromSet;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique()
      {
        Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0>.NativeClassPtr, "<<DoLoadAndInit>g__LoadAndInit|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr);
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, "<>1__state");
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, "<>2__current");
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, "<>4__this");
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr_fromSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, nameof (fromSet));
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, "<>7__wrap1");
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, 100671147);
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, 100671148);
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, 100671149);
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, 100671150);
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, 100671151);
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, 100671152);
        GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr, 100671153);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 91049, RefRangeEnd = 91050, XrefRangeStart = 91044, XrefRangeEnd = 91049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91050, XrefRangeEnd = 91104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91104, XrefRangeEnd = 91107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void __m__Finally1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91107, XrefRangeEnd = 91112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameFlowManager.__c__DisplayClass48_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (GameFlowManager.__c__DisplayClass48_0) null : Il2CppObjectPool.Get<GameFlowManager.__c__DisplayClass48_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe HashSet<GameFlowSerializer> fromSet
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr_fromSet));
          return num == System.IntPtr.Zero ? (HashSet<GameFlowSerializer>) null : Il2CppObjectPool.Get<HashSet<GameFlowSerializer>>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr_fromSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public List<GameFlowSerializer>.Enumerator __7__wrap1
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___7__wrap1);
          return new List<GameFlowSerializer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<GameFlowSerializer>.Enumerator>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GafrEn1GaObUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<GameFlowSerializer>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<DoLoadAndInit>d__48")]
  public sealed class _DoLoadAndInit_d__48(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_dontLoadPlayer;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr__triedLoading_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _DoLoadAndInit_d__48()
    {
      Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<DoLoadAndInit>d__48");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr);
      GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, "<>1__state");
      GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, "<>2__current");
      GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, "<>4__this");
      GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr_dontLoadPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, nameof (dontLoadPlayer));
      GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, "<>8__1");
      GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr__triedLoading_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, "<triedLoading>5__2");
      GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, 100671154);
      GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, 100671155);
      GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, 100671156);
      GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, 100671157);
      GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, 100671158);
      GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr, 100671159);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _DoLoadAndInit_d__48(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager._DoLoadAndInit_d__48>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91117, XrefRangeEnd = 91181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91181, XrefRangeEnd = 91186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._DoLoadAndInit_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFlowManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GameFlowManager) null : Il2CppObjectPool.Get<GameFlowManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool dontLoadPlayer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr_dontLoadPlayer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr_dontLoadPlayer)) = value;
      }
    }

    public unsafe GameFlowManager.__c__DisplayClass48_0 __8__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___8__1));
        return num == System.IntPtr.Zero ? (GameFlowManager.__c__DisplayClass48_0) null : Il2CppObjectPool.Get<GameFlowManager.__c__DisplayClass48_0>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _triedLoading_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr__triedLoading_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._DoLoadAndInit_d__48.NativeFieldInfoPtr__triedLoading_5__2)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<Start>d__33")]
  public sealed class _Start_d__33(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

    static _Start_d__33()
    {
      Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<Start>d__33");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr);
      GameFlowManager._Start_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, "<>1__state");
      GameFlowManager._Start_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, "<>2__current");
      GameFlowManager._Start_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, "<>4__this");
      GameFlowManager._Start_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, 100671160);
      GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, 100671161);
      GameFlowManager._Start_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, 100671162);
      GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, 100671163);
      GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, 100671164);
      GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr, 100671165);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Start_d__33(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager._Start_d__33>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._Start_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91186, XrefRangeEnd = 91198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._Start_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91198, XrefRangeEnd = 91203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._Start_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._Start_d__33.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._Start_d__33.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._Start_d__33.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._Start_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFlowManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._Start_d__33.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GameFlowManager) null : Il2CppObjectPool.Get<GameFlowManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._Start_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<WaitForLoading>d__39")]
  public sealed class _WaitForLoading_d__39(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

    static _WaitForLoading_d__39()
    {
      Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<WaitForLoading>d__39");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr);
      GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, "<>1__state");
      GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, "<>2__current");
      GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, "<>4__this");
      GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, 100671166);
      GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, 100671167);
      GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, 100671168);
      GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, 100671169);
      GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, 100671170);
      GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr, 100671171);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForLoading_d__39(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager._WaitForLoading_d__39>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91203, XrefRangeEnd = 91205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91205, XrefRangeEnd = 91210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForLoading_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFlowManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GameFlowManager) null : Il2CppObjectPool.Get<GameFlowManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForLoading_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowManager+<WaitForReset>d__47")]
  public sealed class _WaitForReset_d__47(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForReset_d__47()
    {
      Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowManager>.NativeClassPtr, "<WaitForReset>d__47");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr);
      GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, "<>1__state");
      GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, "<>2__current");
      GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, "<>4__this");
      GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, nameof (delay));
      GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, 100671172);
      GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, 100671173);
      GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, 100671174);
      GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, 100671175);
      GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, 100671176);
      GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr, 100671177);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForReset_d__47(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowManager._WaitForReset_d__47>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91210, XrefRangeEnd = 91223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91223, XrefRangeEnd = 91228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowManager._WaitForReset_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFlowManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GameFlowManager) null : Il2CppObjectPool.Get<GameFlowManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowManager._WaitForReset_d__47.NativeFieldInfoPtr_delay)) = value;
      }
    }
  }
}
