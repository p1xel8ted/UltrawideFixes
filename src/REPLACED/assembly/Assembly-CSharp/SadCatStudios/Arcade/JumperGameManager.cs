// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.JumperGameManager
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
using Il2CppSystem.Runtime.CompilerServices;
using Replaced.Scripts.UI;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class JumperGameManager(System.IntPtr pointer) : LocalSingletonBehaviour<JumperGameManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_screenCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_postProcessMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialDistortionStrength;
  private static readonly System.IntPtr NativeFieldInfoPtr_timer;
  private static readonly System.IntPtr NativeFieldInfoPtr_score;
  private static readonly System.IntPtr NativeFieldInfoPtr_lives;
  private static readonly System.IntPtr NativeFieldInfoPtr_mainMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_howToPlay;
  private static readonly System.IntPtr NativeFieldInfoPtr_scoreScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameplayScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_topPanel;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameplayControls;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseControls;
  private static readonly System.IntPtr NativeFieldInfoPtr_scoreMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerScoreArticyVar;
  private static readonly System.IntPtr NativeFieldInfoPtr_flyingScorePool;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumperController;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_successEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpSpawnPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_secondSeagull;
  private static readonly System.IntPtr NativeFieldInfoPtr_secondSeagullStageAppearance;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameplayScreenWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameplayTimeSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScoreBase;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScoreStageIncrement;
  private static readonly System.IntPtr NativeFieldInfoPtr_speedIncrement;
  private static readonly System.IntPtr NativeFieldInfoPtr_appearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_dissapearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_glitchEffectSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_highwaySound;
  private static readonly System.IntPtr NativeFieldInfoPtr_kickSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_coin;
  private static readonly System.IntPtr NativeFieldInfoPtr_music;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOther;
  private static readonly System.IntPtr NativeFieldInfoPtr_glitchEffectInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_highwayInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_coinInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_musicInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickUpInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOtherInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr__LeftEdge_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RightEdge_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_stageCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_distortionStrength;
  private static readonly System.IntPtr NativeFieldInfoPtr_DistortionStrengthID;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftEdge_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LeftEdge_Private_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RightEdge_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RightEdge_Private_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BorderCheck_Public_Boolean_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGameplay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGameplayTimeScale_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextSuccessfulStage_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PickUp_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTimeout_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeath_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SpawnPickUp_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IncreaseDifficulty_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unpause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddScore_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndGameplay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGameplayInput_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JumperGameManager()
  {
    Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (JumperGameManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr);
    JumperGameManager.NativeFieldInfoPtr_screenCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (screenCamera));
    JumperGameManager.NativeFieldInfoPtr_postProcessMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (postProcessMaterial));
    JumperGameManager.NativeFieldInfoPtr_initialDistortionStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (initialDistortionStrength));
    JumperGameManager.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (timer));
    JumperGameManager.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (score));
    JumperGameManager.NativeFieldInfoPtr_lives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (lives));
    JumperGameManager.NativeFieldInfoPtr_mainMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (mainMenu));
    JumperGameManager.NativeFieldInfoPtr_howToPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (howToPlay));
    JumperGameManager.NativeFieldInfoPtr_scoreScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (scoreScreen));
    JumperGameManager.NativeFieldInfoPtr_gameplayScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (gameplayScreen));
    JumperGameManager.NativeFieldInfoPtr_pauseScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (pauseScreen));
    JumperGameManager.NativeFieldInfoPtr_timeoutScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (timeoutScreen));
    JumperGameManager.NativeFieldInfoPtr_topPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (topPanel));
    JumperGameManager.NativeFieldInfoPtr_gameplayControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (gameplayControls));
    JumperGameManager.NativeFieldInfoPtr_pauseControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (pauseControls));
    JumperGameManager.NativeFieldInfoPtr_scoreMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (scoreMenu));
    JumperGameManager.NativeFieldInfoPtr_playerScoreArticyVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (playerScoreArticyVar));
    JumperGameManager.NativeFieldInfoPtr_flyingScorePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (flyingScorePool));
    JumperGameManager.NativeFieldInfoPtr_jumperController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (jumperController));
    JumperGameManager.NativeFieldInfoPtr_pickUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (pickUp));
    JumperGameManager.NativeFieldInfoPtr_pickUpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (pickUpEffect));
    JumperGameManager.NativeFieldInfoPtr_successEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (successEffect));
    JumperGameManager.NativeFieldInfoPtr_pickUpSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (pickUpSpawnPoints));
    JumperGameManager.NativeFieldInfoPtr_secondSeagull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (secondSeagull));
    JumperGameManager.NativeFieldInfoPtr_secondSeagullStageAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (secondSeagullStageAppearance));
    JumperGameManager.NativeFieldInfoPtr_gameplayScreenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (gameplayScreenWidth));
    JumperGameManager.NativeFieldInfoPtr_GameplayTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (GameplayTimeSeconds));
    JumperGameManager.NativeFieldInfoPtr_ScoreBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (ScoreBase));
    JumperGameManager.NativeFieldInfoPtr_ScoreStageIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (ScoreStageIncrement));
    JumperGameManager.NativeFieldInfoPtr_speedIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (speedIncrement));
    JumperGameManager.NativeFieldInfoPtr_appearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (appearEffect));
    JumperGameManager.NativeFieldInfoPtr_dissapearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (dissapearEffect));
    JumperGameManager.NativeFieldInfoPtr_glitchEffectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (glitchEffectSound));
    JumperGameManager.NativeFieldInfoPtr_highwaySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (highwaySound));
    JumperGameManager.NativeFieldInfoPtr_kickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (kickSound));
    JumperGameManager.NativeFieldInfoPtr_coin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (coin));
    JumperGameManager.NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (music));
    JumperGameManager.NativeFieldInfoPtr_pickUpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (pickUpSound));
    JumperGameManager.NativeFieldInfoPtr_timeoutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (timeoutSound));
    JumperGameManager.NativeFieldInfoPtr_muteOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (muteOther));
    JumperGameManager.NativeFieldInfoPtr_glitchEffectInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (glitchEffectInstance));
    JumperGameManager.NativeFieldInfoPtr_highwayInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (highwayInstance));
    JumperGameManager.NativeFieldInfoPtr_coinInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (coinInstance));
    JumperGameManager.NativeFieldInfoPtr_musicInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (musicInstance));
    JumperGameManager.NativeFieldInfoPtr_pickUpInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (pickUpInstance));
    JumperGameManager.NativeFieldInfoPtr_timeoutInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (timeoutInstance));
    JumperGameManager.NativeFieldInfoPtr_muteOtherInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (muteOtherInstance));
    JumperGameManager.NativeFieldInfoPtr__LeftEdge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, "<LeftEdge>k__BackingField");
    JumperGameManager.NativeFieldInfoPtr__RightEdge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, "<RightEdge>k__BackingField");
    JumperGameManager.NativeFieldInfoPtr_stageCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (stageCounter));
    JumperGameManager.NativeFieldInfoPtr_distortionStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (distortionStrength));
    JumperGameManager.NativeFieldInfoPtr_DistortionStrengthID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, nameof (DistortionStrengthID));
    JumperGameManager.NativeMethodInfoPtr_get_LeftEdge_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676698);
    JumperGameManager.NativeMethodInfoPtr_set_LeftEdge_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676699);
    JumperGameManager.NativeMethodInfoPtr_get_RightEdge_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676700);
    JumperGameManager.NativeMethodInfoPtr_set_RightEdge_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676701);
    JumperGameManager.NativeMethodInfoPtr_BorderCheck_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676702);
    JumperGameManager.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676703);
    JumperGameManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676704);
    JumperGameManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676705);
    JumperGameManager.NativeMethodInfoPtr_StartGameplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676706);
    JumperGameManager.NativeMethodInfoPtr_SetGameplayTimeScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676707);
    JumperGameManager.NativeMethodInfoPtr_NextSuccessfulStage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676708);
    JumperGameManager.NativeMethodInfoPtr_PickUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676709);
    JumperGameManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676710);
    JumperGameManager.NativeMethodInfoPtr_OnTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676711);
    JumperGameManager.NativeMethodInfoPtr_OnDeath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676712);
    JumperGameManager.NativeMethodInfoPtr_SpawnPickUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676713);
    JumperGameManager.NativeMethodInfoPtr_IncreaseDifficulty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676714);
    JumperGameManager.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676715);
    JumperGameManager.NativeMethodInfoPtr_Unpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676716);
    JumperGameManager.NativeMethodInfoPtr_AddScore_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676717);
    JumperGameManager.NativeMethodInfoPtr_EndGameplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676718);
    JumperGameManager.NativeMethodInfoPtr_OnGameplayInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676719);
    JumperGameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, 100676720);
  }

  public unsafe Vector3 LeftEdge
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_get_LeftEdge_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_set_LeftEdge_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 RightEdge
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_get_RightEdge_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_set_RightEdge_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe bool BorderCheck(Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &position
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_BorderCheck_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool gameplayActive
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125895, XrefRangeEnd = 125897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125897, XrefRangeEnd = 125948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125948, XrefRangeEnd = 125977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JumperGameManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125977, XrefRangeEnd = 125981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGameplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_StartGameplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125981, XrefRangeEnd = 125982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGameplayTimeScale()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_SetGameplayTimeScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125982, XrefRangeEnd = 125987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextSuccessfulStage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_NextSuccessfulStage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125987, XrefRangeEnd = 125995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PickUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_PickUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125995, XrefRangeEnd = 126017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126017, XrefRangeEnd = 126019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTimeout()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_OnTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126019, XrefRangeEnd = 126023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDeath()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_OnDeath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126030, RefRangeEnd = 126033, XrefRangeStart = 126023, XrefRangeEnd = 126030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SpawnPickUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_SpawnPickUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126033, XrefRangeEnd = 126037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void IncreaseDifficulty()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_IncreaseDifficulty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126037, XrefRangeEnd = 126045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 126053, RefRangeEnd = 126055, XrefRangeStart = 126045, XrefRangeEnd = 126053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unpause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_Unpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126059, RefRangeEnd = 126060, XrefRangeStart = 126055, XrefRangeEnd = 126059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddScore(int score)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &score
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_AddScore_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 126064, RefRangeEnd = 126066, XrefRangeStart = 126060, XrefRangeEnd = 126064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndGameplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_EndGameplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnGameplayInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr_OnGameplayInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126066, XrefRangeEnd = 126069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JumperGameManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperGameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Camera screenCamera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_screenCamera));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_screenCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material postProcessMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_postProcessMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_postProcessMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float initialDistortionStrength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_initialDistortionStrength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_initialDistortionStrength)) = value;
    }
  }

  public unsafe ArcadeTimer timer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timer));
      return num == System.IntPtr.Zero ? (ArcadeTimer) null : Il2CppObjectPool.Get<ArcadeTimer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArcadeScore score
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_score));
      return num == System.IntPtr.Zero ? (ArcadeScore) null : Il2CppObjectPool.Get<ArcadeScore>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArcadeLives lives
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_lives));
      return num == System.IntPtr.Zero ? (ArcadeLives) null : Il2CppObjectPool.Get<ArcadeLives>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_lives), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHunterMainMenu mainMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_mainMenu));
      return num == System.IntPtr.Zero ? (UIHunterMainMenu) null : Il2CppObjectPool.Get<UIHunterMainMenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_mainMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject howToPlay
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_howToPlay));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_howToPlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject scoreScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_scoreScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_scoreScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject gameplayScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_gameplayScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_gameplayScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject pauseScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pauseScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pauseScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject timeoutScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timeoutScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timeoutScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject topPanel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_topPanel));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_topPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> gameplayControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_gameplayControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_gameplayControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> pauseControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pauseControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pauseControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UISubmenu scoreMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_scoreMenu));
      return num == System.IntPtr.Zero ? (UISubmenu) null : Il2CppObjectPool.Get<UISubmenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_scoreMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string playerScoreArticyVar
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_playerScoreArticyVar)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_playerScoreArticyVar), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ArcadeFlyingScorePool flyingScorePool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_flyingScorePool));
      return num == System.IntPtr.Zero ? (ArcadeFlyingScorePool) null : Il2CppObjectPool.Get<ArcadeFlyingScorePool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_flyingScorePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JumperController jumperController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_jumperController));
      return num == System.IntPtr.Zero ? (JumperController) null : Il2CppObjectPool.Get<JumperController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_jumperController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject pickUp
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUp));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem pickUpEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem successEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_successEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_successEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Transform> pickUpSpawnPoints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpSpawnPoints));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject secondSeagull
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_secondSeagull));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_secondSeagull), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int secondSeagullStageAppearance
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_secondSeagullStageAppearance));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_secondSeagullStageAppearance)) = value;
    }
  }

  public unsafe int gameplayScreenWidth
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_gameplayScreenWidth));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_gameplayScreenWidth)) = value;
    }
  }

  public unsafe int GameplayTimeSeconds
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_GameplayTimeSeconds));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_GameplayTimeSeconds)) = value;
    }
  }

  public unsafe int ScoreBase
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_ScoreBase));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_ScoreBase)) = value;
    }
  }

  public unsafe int ScoreStageIncrement
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_ScoreStageIncrement));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_ScoreStageIncrement)) = value;
    }
  }

  public unsafe float speedIncrement
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_speedIncrement));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_speedIncrement)) = value;
    }
  }

  public unsafe ParticleSystem appearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_appearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_appearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem dissapearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_dissapearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_dissapearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference glitchEffectSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_glitchEffectSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_glitchEffectSound)) = value;
    }
  }

  public unsafe EventReference highwaySound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_highwaySound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_highwaySound)) = value;
    }
  }

  public unsafe EventReference kickSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_kickSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_kickSound)) = value;
    }
  }

  public unsafe EventReference coin
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_coin));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_coin)) = value;
    }
  }

  public unsafe EventReference music
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_music));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_music)) = value;
    }
  }

  public unsafe EventReference pickUpSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpSound)) = value;
    }
  }

  public unsafe EventReference timeoutSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timeoutSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timeoutSound)) = value;
    }
  }

  public unsafe EventReference muteOther
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_muteOther));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_muteOther)) = value;
    }
  }

  public unsafe EventInstance glitchEffectInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_glitchEffectInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_glitchEffectInstance)) = value;
    }
  }

  public unsafe EventInstance highwayInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_highwayInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_highwayInstance)) = value;
    }
  }

  public unsafe EventInstance coinInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_coinInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_coinInstance)) = value;
    }
  }

  public unsafe EventInstance musicInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_musicInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_musicInstance)) = value;
    }
  }

  public unsafe EventInstance pickUpInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_pickUpInstance)) = value;
    }
  }

  public unsafe EventInstance timeoutInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timeoutInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_timeoutInstance)) = value;
    }
  }

  public unsafe EventInstance muteOtherInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_muteOtherInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_muteOtherInstance)) = value;
    }
  }

  public unsafe Vector3 _LeftEdge_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr__LeftEdge_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr__LeftEdge_k__BackingField)) = value;
    }
  }

  public unsafe Vector3 _RightEdge_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr__RightEdge_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr__RightEdge_k__BackingField)) = value;
    }
  }

  public unsafe int stageCounter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_stageCounter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_stageCounter)) = value;
    }
  }

  public unsafe float distortionStrength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_distortionStrength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager.NativeFieldInfoPtr_distortionStrength)) = value;
    }
  }

  public static unsafe int DistortionStrengthID
  {
    get
    {
      int distortionStrengthId;
      IL2CPP.il2cpp_field_static_get_value(JumperGameManager.NativeFieldInfoPtr_DistortionStrengthID, (void*) &distortionStrengthId);
      return distortionStrengthId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JumperGameManager.NativeFieldInfoPtr_DistortionStrengthID, (void*) &value);
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.JumperGameManager+<EndGameplay>d__74")]
  public sealed class _EndGameplay_d__74 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _EndGameplay_d__74()
    {
      Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, "<EndGameplay>d__74");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr);
      JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr, "<>1__state");
      JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr, "<>t__builder");
      JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr, "<>4__this");
      JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr, "<>u__1");
      JumperGameManager._EndGameplay_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr, 100676722);
      JumperGameManager._EndGameplay_d__74.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr, 100676723);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125799, XrefRangeEnd = 125859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JumperGameManager._EndGameplay_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(JumperGameManager._EndGameplay_d__74.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _EndGameplay_d__74(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _EndGameplay_d__74()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumperGameManager._EndGameplay_d__74>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe JumperGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (JumperGameManager) null : Il2CppObjectPool.Get<JumperGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._EndGameplay_d__74.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.JumperGameManager+<StartGameplay>d__62")]
  public sealed class _StartGameplay_d__62 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _StartGameplay_d__62()
    {
      Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JumperGameManager>.NativeClassPtr, "<StartGameplay>d__62");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr);
      JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr, "<>1__state");
      JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr, "<>t__builder");
      JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr, "<>4__this");
      JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr, "<>u__1");
      JumperGameManager._StartGameplay_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr, 100676724);
      JumperGameManager._StartGameplay_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr, 100676725);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125859, XrefRangeEnd = 125895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JumperGameManager._StartGameplay_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(JumperGameManager._StartGameplay_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _StartGameplay_d__62(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _StartGameplay_d__62()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumperGameManager._StartGameplay_d__62>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe JumperGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (JumperGameManager) null : Il2CppObjectPool.Get<JumperGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperGameManager._StartGameplay_d__62.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
