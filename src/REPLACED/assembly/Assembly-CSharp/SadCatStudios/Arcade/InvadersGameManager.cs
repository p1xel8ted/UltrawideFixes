// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.InvadersGameManager
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

public class InvadersGameManager(System.IntPtr pointer) : 
  LocalSingletonBehaviour<InvadersGameManager>(pointer)
{
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
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedControls;
  private static readonly System.IntPtr NativeFieldInfoPtr_scoreMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerScoreArticyVar;
  private static readonly System.IntPtr NativeFieldInfoPtr_flyingScorePool;
  private static readonly System.IntPtr NativeFieldInfoPtr_waveMovement;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerController;
  private static readonly System.IntPtr NativeFieldInfoPtr_bunkers;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameScreenRoot;
  private static readonly System.IntPtr NativeFieldInfoPtr_screenRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyExplosionVFX;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileExplosionVFX;
  private static readonly System.IntPtr NativeFieldInfoPtr_appearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_dissapearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_coin;
  private static readonly System.IntPtr NativeFieldInfoPtr_music;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyExplosionSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameoverSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOther;
  private static readonly System.IntPtr NativeFieldInfoPtr_musicInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOtherInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_onWavePause;
  private static readonly System.IntPtr NativeFieldInfoPtr_stage;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileExplosionPool;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GameOverYPos_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_WavePause_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Stage_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGameplay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetWavePause_Public_Void_Single_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddScore_Public_Void_Int32_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayEnemyExplosion_Public_Void_Vector3_EventReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayProjectileExplosion_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeath_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextStage_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unpause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndGameplay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InvadersGameManager()
  {
    Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (InvadersGameManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr);
    InvadersGameManager.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (score));
    InvadersGameManager.NativeFieldInfoPtr_lives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (lives));
    InvadersGameManager.NativeFieldInfoPtr_mainMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (mainMenu));
    InvadersGameManager.NativeFieldInfoPtr_howToPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (howToPlay));
    InvadersGameManager.NativeFieldInfoPtr_scoreScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (scoreScreen));
    InvadersGameManager.NativeFieldInfoPtr_gameplayScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (gameplayScreen));
    InvadersGameManager.NativeFieldInfoPtr_pauseScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (pauseScreen));
    InvadersGameManager.NativeFieldInfoPtr_timeoutScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (timeoutScreen));
    InvadersGameManager.NativeFieldInfoPtr_topPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (topPanel));
    InvadersGameManager.NativeFieldInfoPtr_gameplayControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (gameplayControls));
    InvadersGameManager.NativeFieldInfoPtr_pausedControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (pausedControls));
    InvadersGameManager.NativeFieldInfoPtr_scoreMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (scoreMenu));
    InvadersGameManager.NativeFieldInfoPtr_playerScoreArticyVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (playerScoreArticyVar));
    InvadersGameManager.NativeFieldInfoPtr_flyingScorePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (flyingScorePool));
    InvadersGameManager.NativeFieldInfoPtr_waveMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (waveMovement));
    InvadersGameManager.NativeFieldInfoPtr_playerController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (playerController));
    InvadersGameManager.NativeFieldInfoPtr_bunkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (bunkers));
    InvadersGameManager.NativeFieldInfoPtr_gameScreenRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (gameScreenRoot));
    InvadersGameManager.NativeFieldInfoPtr_screenRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (screenRadius));
    InvadersGameManager.NativeFieldInfoPtr_enemyExplosionVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (enemyExplosionVFX));
    InvadersGameManager.NativeFieldInfoPtr_projectileExplosionVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (projectileExplosionVFX));
    InvadersGameManager.NativeFieldInfoPtr_appearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (appearEffect));
    InvadersGameManager.NativeFieldInfoPtr_dissapearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (dissapearEffect));
    InvadersGameManager.NativeFieldInfoPtr_coin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (coin));
    InvadersGameManager.NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (music));
    InvadersGameManager.NativeFieldInfoPtr_enemyExplosionSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (enemyExplosionSound));
    InvadersGameManager.NativeFieldInfoPtr_gameoverSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (gameoverSound));
    InvadersGameManager.NativeFieldInfoPtr_muteOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (muteOther));
    InvadersGameManager.NativeFieldInfoPtr_musicInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (musicInstance));
    InvadersGameManager.NativeFieldInfoPtr_muteOtherInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (muteOtherInstance));
    InvadersGameManager.NativeFieldInfoPtr_onWavePause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (onWavePause));
    InvadersGameManager.NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (stage));
    InvadersGameManager.NativeFieldInfoPtr_projectileExplosionPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, nameof (projectileExplosionPool));
    InvadersGameManager.NativeMethodInfoPtr_get_GameOverYPos_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676597);
    InvadersGameManager.NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676598);
    InvadersGameManager.NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676599);
    InvadersGameManager.NativeMethodInfoPtr_get_WavePause_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676600);
    InvadersGameManager.NativeMethodInfoPtr_get_Stage_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676601);
    InvadersGameManager.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676602);
    InvadersGameManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676603);
    InvadersGameManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676604);
    InvadersGameManager.NativeMethodInfoPtr_StartGameplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676605);
    InvadersGameManager.NativeMethodInfoPtr_SetWavePause_Public_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676606);
    InvadersGameManager.NativeMethodInfoPtr_AddScore_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676607);
    InvadersGameManager.NativeMethodInfoPtr_PlayEnemyExplosion_Public_Void_Vector3_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676608 /*0x06003400*/);
    InvadersGameManager.NativeMethodInfoPtr_PlayProjectileExplosion_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676609);
    InvadersGameManager.NativeMethodInfoPtr_OnDeath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676610);
    InvadersGameManager.NativeMethodInfoPtr_NextStage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676611);
    InvadersGameManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676612);
    InvadersGameManager.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676613);
    InvadersGameManager.NativeMethodInfoPtr_Unpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676614);
    InvadersGameManager.NativeMethodInfoPtr_EndGameplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676615);
    InvadersGameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, 100676616);
  }

  public unsafe float GameOverYPos
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124707, XrefRangeEnd = 124709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_get_GameOverYPos_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float LeftEdge
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124709, XrefRangeEnd = 124711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float RightEdge
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124711, XrefRangeEnd = 124713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool WavePause
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_get_WavePause_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int Stage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_get_Stage_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool gameplayActive
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124713, XrefRangeEnd = 124714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124714, XrefRangeEnd = 124742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124742, XrefRangeEnd = 124749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InvadersGameManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124749, XrefRangeEnd = 124753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGameplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_StartGameplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 124757, RefRangeEnd = 124759, XrefRangeStart = 124753, XrefRangeEnd = 124757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWavePause(float pauseTime, Il2CppSystem.Action callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pauseTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_SetWavePause_Public_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124759, XrefRangeEnd = 124761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddScore(int score, Vector3 at)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &score;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &at;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_AddScore_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124761, XrefRangeEnd = 124770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayEnemyExplosion(Vector3 pos, EventReference overrideEvent = default (EventReference))
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideEvent;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_PlayEnemyExplosion_Public_Void_Vector3_EventReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124770, XrefRangeEnd = 124772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayProjectileExplosion(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_PlayProjectileExplosion_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124772, XrefRangeEnd = 124774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDeath()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_OnDeath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void NextStage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_NextStage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124774, XrefRangeEnd = 124795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124795, XrefRangeEnd = 124802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 124809, RefRangeEnd = 124811, XrefRangeStart = 124802, XrefRangeEnd = 124809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unpause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_Unpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 124815, RefRangeEnd = 124819, XrefRangeStart = 124811, XrefRangeEnd = 124815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndGameplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr_EndGameplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124819, XrefRangeEnd = 124822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvadersGameManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersGameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArcadeScore score
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_score));
      return num == System.IntPtr.Zero ? (ArcadeScore) null : Il2CppObjectPool.Get<ArcadeScore>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArcadeLives lives
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_lives));
      return num == System.IntPtr.Zero ? (ArcadeLives) null : Il2CppObjectPool.Get<ArcadeLives>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_lives), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHunterMainMenu mainMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_mainMenu));
      return num == System.IntPtr.Zero ? (UIHunterMainMenu) null : Il2CppObjectPool.Get<UIHunterMainMenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_mainMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject howToPlay
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_howToPlay));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_howToPlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject scoreScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_scoreScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_scoreScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject gameplayScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameplayScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameplayScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject pauseScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_pauseScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_pauseScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject timeoutScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_timeoutScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_timeoutScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject topPanel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_topPanel));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_topPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> gameplayControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameplayControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameplayControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> pausedControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_pausedControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_pausedControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UISubmenu scoreMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_scoreMenu));
      return num == System.IntPtr.Zero ? (UISubmenu) null : Il2CppObjectPool.Get<UISubmenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_scoreMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string playerScoreArticyVar
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_playerScoreArticyVar)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_playerScoreArticyVar), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ArcadeFlyingScorePool flyingScorePool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_flyingScorePool));
      return num == System.IntPtr.Zero ? (ArcadeFlyingScorePool) null : Il2CppObjectPool.Get<ArcadeFlyingScorePool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_flyingScorePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InvadersWaveMovement waveMovement
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_waveMovement));
      return num == System.IntPtr.Zero ? (InvadersWaveMovement) null : Il2CppObjectPool.Get<InvadersWaveMovement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_waveMovement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InvadersPlayerController playerController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_playerController));
      return num == System.IntPtr.Zero ? (InvadersPlayerController) null : Il2CppObjectPool.Get<InvadersPlayerController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_playerController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<InvadersDestructableBunker> bunkers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_bunkers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<InvadersDestructableBunker>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<InvadersDestructableBunker>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_bunkers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform gameScreenRoot
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameScreenRoot));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameScreenRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float screenRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_screenRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_screenRadius)) = value;
    }
  }

  public unsafe ParticleSystem enemyExplosionVFX
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_enemyExplosionVFX));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_enemyExplosionVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PoolableObject projectileExplosionVFX
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_projectileExplosionVFX));
      return num == System.IntPtr.Zero ? (PoolableObject) null : Il2CppObjectPool.Get<PoolableObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_projectileExplosionVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem appearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_appearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_appearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem dissapearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_dissapearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_dissapearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference coin
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_coin));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_coin)) = value;
    }
  }

  public unsafe EventReference music
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_music));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_music)) = value;
    }
  }

  public unsafe EventReference enemyExplosionSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_enemyExplosionSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_enemyExplosionSound)) = value;
    }
  }

  public unsafe EventReference gameoverSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameoverSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_gameoverSound)) = value;
    }
  }

  public unsafe EventReference muteOther
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_muteOther));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_muteOther)) = value;
    }
  }

  public unsafe EventInstance musicInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_musicInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_musicInstance)) = value;
    }
  }

  public unsafe EventInstance muteOtherInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_muteOtherInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_muteOtherInstance)) = value;
    }
  }

  public unsafe bool onWavePause
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_onWavePause));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_onWavePause)) = value;
    }
  }

  public unsafe int stage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_stage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_stage)) = value;
    }
  }

  public unsafe ObjectPool projectileExplosionPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_projectileExplosionPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager.NativeFieldInfoPtr_projectileExplosionPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.InvadersGameManager+<EndGameplay>d__57")]
  public sealed class _EndGameplay_d__57 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _EndGameplay_d__57()
    {
      Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, "<EndGameplay>d__57");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr);
      InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr, "<>1__state");
      InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr, "<>t__builder");
      InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr, "<>4__this");
      InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr, "<>u__1");
      InvadersGameManager._EndGameplay_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr, 100676617);
      InvadersGameManager._EndGameplay_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr, 100676618);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124585, XrefRangeEnd = 124648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersGameManager._EndGameplay_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(InvadersGameManager._EndGameplay_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _EndGameplay_d__57(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _EndGameplay_d__57()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersGameManager._EndGameplay_d__57>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe InvadersGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InvadersGameManager) null : Il2CppObjectPool.Get<InvadersGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._EndGameplay_d__57.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.InvadersGameManager+<SetWavePause>d__48")]
  public sealed class _SetWavePause_d__48 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_pauseTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_callback;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SetWavePause_d__48()
    {
      Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, "<SetWavePause>d__48");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr);
      InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, "<>1__state");
      InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, "<>t__builder");
      InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, "<>4__this");
      InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr_pauseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, nameof (pauseTime));
      InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, nameof (callback));
      InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, "<>u__1");
      InvadersGameManager._SetWavePause_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, 100676619);
      InvadersGameManager._SetWavePause_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr, 100676620);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124648, XrefRangeEnd = 124661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersGameManager._SetWavePause_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(InvadersGameManager._SetWavePause_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SetWavePause_d__48(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SetWavePause_d__48()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersGameManager._SetWavePause_d__48>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe InvadersGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InvadersGameManager) null : Il2CppObjectPool.Get<InvadersGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float pauseTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr_pauseTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr_pauseTime)) = value;
      }
    }

    public unsafe Il2CppSystem.Action callback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr_callback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._SetWavePause_d__48.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.InvadersGameManager+<StartGameplay>d__47")]
  public sealed class _StartGameplay_d__47 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _StartGameplay_d__47()
    {
      Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvadersGameManager>.NativeClassPtr, "<StartGameplay>d__47");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr);
      InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr, "<>1__state");
      InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr, "<>t__builder");
      InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr, "<>4__this");
      InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr, "<>u__1");
      InvadersGameManager._StartGameplay_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr, 100676621);
      InvadersGameManager._StartGameplay_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr, 100676622);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124661, XrefRangeEnd = 124707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersGameManager._StartGameplay_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(InvadersGameManager._StartGameplay_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _StartGameplay_d__47(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _StartGameplay_d__47()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersGameManager._StartGameplay_d__47>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe InvadersGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InvadersGameManager) null : Il2CppObjectPool.Get<InvadersGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersGameManager._StartGameplay_d__47.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
