// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.HunterGameFlow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Replaced.Scripts.UI;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class HunterGameFlow(System.IntPtr pointer) : LocalSingletonBehaviour<HunterGameFlow>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_volunteerCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_timer;
  private static readonly System.IntPtr NativeFieldInfoPtr_score;
  private static readonly System.IntPtr NativeFieldInfoPtr_mainMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_howToPlay;
  private static readonly System.IntPtr NativeFieldInfoPtr_scoreScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameplayScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_rallyStage;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationStage;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_topPanel;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameplayControls;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseControls;
  private static readonly System.IntPtr NativeFieldInfoPtr_scoreMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerScoreArticyVar;
  private static readonly System.IntPtr NativeFieldInfoPtr_flyingScorePool;
  private static readonly System.IntPtr NativeFieldInfoPtr_car;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUps;
  private static readonly System.IntPtr NativeFieldInfoPtr_arrowController;
  private static readonly System.IntPtr NativeFieldInfoPtr_parkingTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_organs;
  private static readonly System.IntPtr NativeFieldInfoPtr_organsSlots;
  private static readonly System.IntPtr NativeFieldInfoPtr_failColors;
  private static readonly System.IntPtr NativeFieldInfoPtr_donorSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_recipientSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_organDragger;
  private static readonly System.IntPtr NativeFieldInfoPtr_appearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_dissapearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_coin;
  private static readonly System.IntPtr NativeFieldInfoPtr_music;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationSuccessSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationFailSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationBackgroundSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOther;
  private static readonly System.IntPtr NativeFieldInfoPtr_coinInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_musicInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationSuccessInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationFailInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_operationBackgroundInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOtherInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_carStartingPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_stage;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameplayTimeSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScoreBase;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameplayAdditionalTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastOrganIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGameplay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndGameplay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unpause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SpawnPickUp_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShufflePickUps_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SpawnParking_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BodyPickUp_Public_Void_BodyPickUp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SpawnOrgansPair_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OperationSuccess_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OperationFailure_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToOperationStage_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToRallyStage_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static HunterGameFlow()
  {
    Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (HunterGameFlow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr);
    HunterGameFlow.NativeFieldInfoPtr_volunteerCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (volunteerCounter));
    HunterGameFlow.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (timer));
    HunterGameFlow.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (score));
    HunterGameFlow.NativeFieldInfoPtr_mainMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (mainMenu));
    HunterGameFlow.NativeFieldInfoPtr_howToPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (howToPlay));
    HunterGameFlow.NativeFieldInfoPtr_scoreScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (scoreScreen));
    HunterGameFlow.NativeFieldInfoPtr_gameplayScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (gameplayScreen));
    HunterGameFlow.NativeFieldInfoPtr_rallyStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (rallyStage));
    HunterGameFlow.NativeFieldInfoPtr_operationStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationStage));
    HunterGameFlow.NativeFieldInfoPtr_pauseScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (pauseScreen));
    HunterGameFlow.NativeFieldInfoPtr_timeoutScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (timeoutScreen));
    HunterGameFlow.NativeFieldInfoPtr_topPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (topPanel));
    HunterGameFlow.NativeFieldInfoPtr_pickUpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (pickUpEffect));
    HunterGameFlow.NativeFieldInfoPtr_operationEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationEffect));
    HunterGameFlow.NativeFieldInfoPtr_gameplayControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (gameplayControls));
    HunterGameFlow.NativeFieldInfoPtr_pauseControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (pauseControls));
    HunterGameFlow.NativeFieldInfoPtr_scoreMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (scoreMenu));
    HunterGameFlow.NativeFieldInfoPtr_playerScoreArticyVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (playerScoreArticyVar));
    HunterGameFlow.NativeFieldInfoPtr_flyingScorePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (flyingScorePool));
    HunterGameFlow.NativeFieldInfoPtr_car = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (car));
    HunterGameFlow.NativeFieldInfoPtr_pickUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (pickUps));
    HunterGameFlow.NativeFieldInfoPtr_arrowController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (arrowController));
    HunterGameFlow.NativeFieldInfoPtr_parkingTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (parkingTrigger));
    HunterGameFlow.NativeFieldInfoPtr_organs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (organs));
    HunterGameFlow.NativeFieldInfoPtr_organsSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (organsSlots));
    HunterGameFlow.NativeFieldInfoPtr_failColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (failColors));
    HunterGameFlow.NativeFieldInfoPtr_donorSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (donorSprite));
    HunterGameFlow.NativeFieldInfoPtr_recipientSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (recipientSprite));
    HunterGameFlow.NativeFieldInfoPtr_organDragger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (organDragger));
    HunterGameFlow.NativeFieldInfoPtr_appearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (appearEffect));
    HunterGameFlow.NativeFieldInfoPtr_dissapearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (dissapearEffect));
    HunterGameFlow.NativeFieldInfoPtr_coin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (coin));
    HunterGameFlow.NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (music));
    HunterGameFlow.NativeFieldInfoPtr_pickUpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (pickUpSound));
    HunterGameFlow.NativeFieldInfoPtr_operationSuccessSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationSuccessSound));
    HunterGameFlow.NativeFieldInfoPtr_operationFailSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationFailSound));
    HunterGameFlow.NativeFieldInfoPtr_operationBackgroundSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationBackgroundSound));
    HunterGameFlow.NativeFieldInfoPtr_timeoutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (timeoutSound));
    HunterGameFlow.NativeFieldInfoPtr_muteOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (muteOther));
    HunterGameFlow.NativeFieldInfoPtr_coinInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (coinInstance));
    HunterGameFlow.NativeFieldInfoPtr_musicInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (musicInstance));
    HunterGameFlow.NativeFieldInfoPtr_pickUpInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (pickUpInstance));
    HunterGameFlow.NativeFieldInfoPtr_operationSuccessInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationSuccessInstance));
    HunterGameFlow.NativeFieldInfoPtr_operationFailInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationFailInstance));
    HunterGameFlow.NativeFieldInfoPtr_operationBackgroundInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (operationBackgroundInstance));
    HunterGameFlow.NativeFieldInfoPtr_timeoutInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (timeoutInstance));
    HunterGameFlow.NativeFieldInfoPtr_muteOtherInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (muteOtherInstance));
    HunterGameFlow.NativeFieldInfoPtr_carStartingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (carStartingPosition));
    HunterGameFlow.NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (stage));
    HunterGameFlow.NativeFieldInfoPtr_pickUpIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (pickUpIndex));
    HunterGameFlow.NativeFieldInfoPtr_GameplayTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (GameplayTimeSeconds));
    HunterGameFlow.NativeFieldInfoPtr_ScoreBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (ScoreBase));
    HunterGameFlow.NativeFieldInfoPtr_GameplayAdditionalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (GameplayAdditionalTime));
    HunterGameFlow.NativeFieldInfoPtr_lastOrganIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, nameof (lastOrganIndex));
    HunterGameFlow.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676543);
    HunterGameFlow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676544);
    HunterGameFlow.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676545);
    HunterGameFlow.NativeMethodInfoPtr_StartGameplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676546);
    HunterGameFlow.NativeMethodInfoPtr_EndGameplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676547);
    HunterGameFlow.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676548);
    HunterGameFlow.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676549);
    HunterGameFlow.NativeMethodInfoPtr_Unpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676550);
    HunterGameFlow.NativeMethodInfoPtr_SpawnPickUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676551);
    HunterGameFlow.NativeMethodInfoPtr_ShufflePickUps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676552);
    HunterGameFlow.NativeMethodInfoPtr_SpawnParking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676553);
    HunterGameFlow.NativeMethodInfoPtr_BodyPickUp_Public_Void_BodyPickUp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676554);
    HunterGameFlow.NativeMethodInfoPtr_SpawnOrgansPair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676555);
    HunterGameFlow.NativeMethodInfoPtr_OperationSuccess_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676556);
    HunterGameFlow.NativeMethodInfoPtr_OperationFailure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676557);
    HunterGameFlow.NativeMethodInfoPtr_SwitchToOperationStage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676558);
    HunterGameFlow.NativeMethodInfoPtr_SwitchToRallyStage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676559);
    HunterGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, 100676560);
  }

  public unsafe bool gameplayActive
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124224, XrefRangeEnd = 124226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124226, XrefRangeEnd = 124256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124256, XrefRangeEnd = 124275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HunterGameFlow.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124275, XrefRangeEnd = 124279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGameplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_StartGameplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124279, XrefRangeEnd = 124283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndGameplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_EndGameplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124283, XrefRangeEnd = 124307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124307, XrefRangeEnd = 124314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 124321, RefRangeEnd = 124323, XrefRangeStart = 124314, XrefRangeEnd = 124321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unpause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_Unpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 124332, RefRangeEnd = 124335, XrefRangeStart = 124323, XrefRangeEnd = 124332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SpawnPickUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_SpawnPickUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124363, RefRangeEnd = 124364, XrefRangeStart = 124335, XrefRangeEnd = 124363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShufflePickUps()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_ShufflePickUps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124364, XrefRangeEnd = 124367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SpawnParking()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_SpawnParking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124386, RefRangeEnd = 124387, XrefRangeStart = 124367, XrefRangeEnd = 124386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BodyPickUp(SadCatStudios.Arcade.BodyPickUp body)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) body)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_BodyPickUp_Public_Void_BodyPickUp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 124404, RefRangeEnd = 124406, XrefRangeStart = 124387, XrefRangeEnd = 124404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SpawnOrgansPair()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_SpawnOrgansPair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124421, RefRangeEnd = 124422, XrefRangeStart = 124406, XrefRangeEnd = 124421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OperationSuccess(Vector3 slotPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &slotPosition
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_OperationSuccess_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124422, XrefRangeEnd = 124426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OperationFailure()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_OperationFailure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124426, XrefRangeEnd = 124430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToOperationStage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_SwitchToOperationStage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 124434, RefRangeEnd = 124436, XrefRangeStart = 124430, XrefRangeEnd = 124434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchToRallyStage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr_SwitchToRallyStage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124436, XrefRangeEnd = 124439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HunterGameFlow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HunterGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArcadeCounter volunteerCounter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_volunteerCounter));
      return num == System.IntPtr.Zero ? (ArcadeCounter) null : Il2CppObjectPool.Get<ArcadeCounter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_volunteerCounter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArcadeTimer timer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timer));
      return num == System.IntPtr.Zero ? (ArcadeTimer) null : Il2CppObjectPool.Get<ArcadeTimer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArcadeScore score
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_score));
      return num == System.IntPtr.Zero ? (ArcadeScore) null : Il2CppObjectPool.Get<ArcadeScore>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHunterMainMenu mainMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_mainMenu));
      return num == System.IntPtr.Zero ? (UIHunterMainMenu) null : Il2CppObjectPool.Get<UIHunterMainMenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_mainMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject howToPlay
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_howToPlay));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_howToPlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject scoreScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_scoreScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_scoreScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject gameplayScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_gameplayScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_gameplayScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject rallyStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_rallyStage));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_rallyStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject operationStage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationStage));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationStage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject pauseScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pauseScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pauseScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject timeoutScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timeoutScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timeoutScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject topPanel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_topPanel));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_topPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem pickUpEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem operationEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> gameplayControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_gameplayControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_gameplayControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> pauseControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pauseControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pauseControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UISubmenu scoreMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_scoreMenu));
      return num == System.IntPtr.Zero ? (UISubmenu) null : Il2CppObjectPool.Get<UISubmenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_scoreMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string playerScoreArticyVar
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_playerScoreArticyVar)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_playerScoreArticyVar), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ArcadeFlyingScorePool flyingScorePool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_flyingScorePool));
      return num == System.IntPtr.Zero ? (ArcadeFlyingScorePool) null : Il2CppObjectPool.Get<ArcadeFlyingScorePool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_flyingScorePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform car
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_car));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_car), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SadCatStudios.Arcade.BodyPickUp> pickUps
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUps));
      return num == System.IntPtr.Zero ? (List<SadCatStudios.Arcade.BodyPickUp>) null : Il2CppObjectPool.Get<List<SadCatStudios.Arcade.BodyPickUp>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUps), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArrowController arrowController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_arrowController));
      return num == System.IntPtr.Zero ? (ArrowController) null : Il2CppObjectPool.Get<ArrowController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_arrowController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParkingTrigger parkingTrigger
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_parkingTrigger));
      return num == System.IntPtr.Zero ? (ParkingTrigger) null : Il2CppObjectPool.Get<ParkingTrigger>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_parkingTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> organs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_organs));
      return num == System.IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_organs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> organsSlots
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_organsSlots));
      return num == System.IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_organsSlots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Color> failColors
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_failColors));
      return num == System.IntPtr.Zero ? (List<Color>) null : Il2CppObjectPool.Get<List<Color>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_failColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer donorSprite
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_donorSprite));
      return num == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_donorSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer recipientSprite
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_recipientSprite));
      return num == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_recipientSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe OrganDragger organDragger
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_organDragger));
      return num == System.IntPtr.Zero ? (OrganDragger) null : Il2CppObjectPool.Get<OrganDragger>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_organDragger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem appearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_appearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_appearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem dissapearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_dissapearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_dissapearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference coin
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_coin));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_coin)) = value;
    }
  }

  public unsafe EventReference music
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_music));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_music)) = value;
    }
  }

  public unsafe EventReference pickUpSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpSound)) = value;
    }
  }

  public unsafe EventReference operationSuccessSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationSuccessSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationSuccessSound)) = value;
    }
  }

  public unsafe EventReference operationFailSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationFailSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationFailSound)) = value;
    }
  }

  public unsafe EventReference operationBackgroundSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationBackgroundSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationBackgroundSound)) = value;
    }
  }

  public unsafe EventReference timeoutSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timeoutSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timeoutSound)) = value;
    }
  }

  public unsafe EventReference muteOther
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_muteOther));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_muteOther)) = value;
    }
  }

  public unsafe EventInstance coinInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_coinInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_coinInstance)) = value;
    }
  }

  public unsafe EventInstance musicInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_musicInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_musicInstance)) = value;
    }
  }

  public unsafe EventInstance pickUpInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpInstance)) = value;
    }
  }

  public unsafe EventInstance operationSuccessInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationSuccessInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationSuccessInstance)) = value;
    }
  }

  public unsafe EventInstance operationFailInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationFailInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationFailInstance)) = value;
    }
  }

  public unsafe EventInstance operationBackgroundInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationBackgroundInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_operationBackgroundInstance)) = value;
    }
  }

  public unsafe EventInstance timeoutInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timeoutInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_timeoutInstance)) = value;
    }
  }

  public unsafe EventInstance muteOtherInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_muteOtherInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_muteOtherInstance)) = value;
    }
  }

  public unsafe Vector3 carStartingPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_carStartingPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_carStartingPosition)) = value;
    }
  }

  public unsafe int stage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_stage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_stage)) = value;
    }
  }

  public unsafe int pickUpIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_pickUpIndex)) = value;
    }
  }

  public unsafe int GameplayTimeSeconds
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_GameplayTimeSeconds));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_GameplayTimeSeconds)) = value;
    }
  }

  public unsafe int ScoreBase
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_ScoreBase));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_ScoreBase)) = value;
    }
  }

  public unsafe int GameplayAdditionalTime
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_GameplayAdditionalTime));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_GameplayAdditionalTime)) = value;
    }
  }

  public unsafe int lastOrganIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_lastOrganIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow.NativeFieldInfoPtr_lastOrganIndex)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.HunterGameFlow+<EndGameplay>d__59")]
  public sealed class _EndGameplay_d__59 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _EndGameplay_d__59()
    {
      Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, "<EndGameplay>d__59");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr);
      HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr, "<>1__state");
      HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr, "<>t__builder");
      HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr, "<>4__this");
      HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr, "<>u__1");
      HunterGameFlow._EndGameplay_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr, 100676561);
      HunterGameFlow._EndGameplay_d__59.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr, 100676562);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124032, XrefRangeEnd = 124091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._EndGameplay_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._EndGameplay_d__59.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _EndGameplay_d__59(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _EndGameplay_d__59()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HunterGameFlow._EndGameplay_d__59>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe HunterGameFlow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (HunterGameFlow) null : Il2CppObjectPool.Get<HunterGameFlow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._EndGameplay_d__59.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.HunterGameFlow+<OperationFailure>d__69")]
  public sealed class _OperationFailure_d__69 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__donorColor_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__recipientColor_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _OperationFailure_d__69()
    {
      Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, "<OperationFailure>d__69");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr);
      HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, "<>1__state");
      HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, "<>t__builder");
      HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, "<>4__this");
      HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr__donorColor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, "<donorColor>5__2");
      HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr__recipientColor_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, "<recipientColor>5__3");
      HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, "<>7__wrap3");
      HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, "<>u__1");
      HunterGameFlow._OperationFailure_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, 100676563);
      HunterGameFlow._OperationFailure_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr, 100676564);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124091, XrefRangeEnd = 124134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._OperationFailure_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._OperationFailure_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _OperationFailure_d__69(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _OperationFailure_d__69()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HunterGameFlow._OperationFailure_d__69>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe HunterGameFlow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (HunterGameFlow) null : Il2CppObjectPool.Get<HunterGameFlow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color _donorColor_5__2
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr__donorColor_5__2));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr__donorColor_5__2)) = value;
      }
    }

    public unsafe Color _recipientColor_5__3
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr__recipientColor_5__3));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr__recipientColor_5__3)) = value;
      }
    }

    public List<Color>.Enumerator __7__wrap3
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___7__wrap3);
        return new List<Color>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Color>.Enumerator>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Color>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._OperationFailure_d__69.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.HunterGameFlow+<StartGameplay>d__58")]
  public sealed class _StartGameplay_d__58 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _StartGameplay_d__58()
    {
      Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, "<StartGameplay>d__58");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr);
      HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr, "<>1__state");
      HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr, "<>t__builder");
      HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr, "<>4__this");
      HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr, "<>u__1");
      HunterGameFlow._StartGameplay_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr, 100676565);
      HunterGameFlow._StartGameplay_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr, 100676566);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124134, XrefRangeEnd = 124175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._StartGameplay_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._StartGameplay_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _StartGameplay_d__58(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _StartGameplay_d__58()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HunterGameFlow._StartGameplay_d__58>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe HunterGameFlow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (HunterGameFlow) null : Il2CppObjectPool.Get<HunterGameFlow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._StartGameplay_d__58.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.HunterGameFlow+<SwitchToOperationStage>d__70")]
  public sealed class _SwitchToOperationStage_d__70 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SwitchToOperationStage_d__70()
    {
      Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, "<SwitchToOperationStage>d__70");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr);
      HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr, "<>1__state");
      HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr, "<>t__builder");
      HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr, "<>4__this");
      HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr, "<>u__1");
      HunterGameFlow._SwitchToOperationStage_d__70.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr, 100676567);
      HunterGameFlow._SwitchToOperationStage_d__70.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr, 100676568);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124175, XrefRangeEnd = 124199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._SwitchToOperationStage_d__70.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._SwitchToOperationStage_d__70.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SwitchToOperationStage_d__70(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SwitchToOperationStage_d__70()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HunterGameFlow._SwitchToOperationStage_d__70>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe HunterGameFlow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (HunterGameFlow) null : Il2CppObjectPool.Get<HunterGameFlow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToOperationStage_d__70.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.HunterGameFlow+<SwitchToRallyStage>d__71")]
  public sealed class _SwitchToRallyStage_d__71 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SwitchToRallyStage_d__71()
    {
      Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HunterGameFlow>.NativeClassPtr, "<SwitchToRallyStage>d__71");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr);
      HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr, "<>1__state");
      HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr, "<>t__builder");
      HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr, "<>4__this");
      HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr, "<>u__1");
      HunterGameFlow._SwitchToRallyStage_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr, 100676569);
      HunterGameFlow._SwitchToRallyStage_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr, 100676570);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124199, XrefRangeEnd = 124224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._SwitchToRallyStage_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(HunterGameFlow._SwitchToRallyStage_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SwitchToRallyStage_d__71(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SwitchToRallyStage_d__71()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HunterGameFlow._SwitchToRallyStage_d__71>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe HunterGameFlow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (HunterGameFlow) null : Il2CppObjectPool.Get<HunterGameFlow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HunterGameFlow._SwitchToRallyStage_d__71.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
