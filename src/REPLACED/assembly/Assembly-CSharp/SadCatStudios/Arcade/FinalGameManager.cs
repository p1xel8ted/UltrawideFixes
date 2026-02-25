// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.FinalGameManager
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
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class FinalGameManager(System.IntPtr pointer) : LocalSingletonBehaviour<FinalGameManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_timer;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameplayScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutScreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_topPanel;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameplayControls;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedControls;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerController;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameScreenRoot;
  private static readonly System.IntPtr NativeFieldInfoPtr_screenRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyExplosionVFX;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileExplosionVFX;
  private static readonly System.IntPtr NativeFieldInfoPtr_appearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_dissapearEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_music;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyExplosionSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameoverSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOther;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameplayTimeSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameplayRemoveTimeSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_stages;
  private static readonly System.IntPtr NativeFieldInfoPtr_musicInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_muteOtherInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_onWavePause;
  private static readonly System.IntPtr NativeFieldInfoPtr_StageIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileExplosionPool;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GameOverYPos_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_WavePause_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGameplay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetWavePause_Public_Void_Single_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayEnemyExplosion_Public_Void_Vector3_EventReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayProjectileExplosion_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeath_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unpause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndFailure_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndGameplay_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FinalGameManager()
  {
    Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (FinalGameManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr);
    FinalGameManager.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (timer));
    FinalGameManager.NativeFieldInfoPtr_gameplayScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (gameplayScreen));
    FinalGameManager.NativeFieldInfoPtr_pauseScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (pauseScreen));
    FinalGameManager.NativeFieldInfoPtr_timeoutScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (timeoutScreen));
    FinalGameManager.NativeFieldInfoPtr_topPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (topPanel));
    FinalGameManager.NativeFieldInfoPtr_gameplayControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (gameplayControls));
    FinalGameManager.NativeFieldInfoPtr_pausedControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (pausedControls));
    FinalGameManager.NativeFieldInfoPtr_playerController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (playerController));
    FinalGameManager.NativeFieldInfoPtr_gameScreenRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (gameScreenRoot));
    FinalGameManager.NativeFieldInfoPtr_screenRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (screenRadius));
    FinalGameManager.NativeFieldInfoPtr_enemyExplosionVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (enemyExplosionVFX));
    FinalGameManager.NativeFieldInfoPtr_projectileExplosionVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (projectileExplosionVFX));
    FinalGameManager.NativeFieldInfoPtr_appearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (appearEffect));
    FinalGameManager.NativeFieldInfoPtr_dissapearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (dissapearEffect));
    FinalGameManager.NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (music));
    FinalGameManager.NativeFieldInfoPtr_enemyExplosionSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (enemyExplosionSound));
    FinalGameManager.NativeFieldInfoPtr_gameoverSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (gameoverSound));
    FinalGameManager.NativeFieldInfoPtr_muteOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (muteOther));
    FinalGameManager.NativeFieldInfoPtr_GameplayTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (GameplayTimeSeconds));
    FinalGameManager.NativeFieldInfoPtr_GameplayRemoveTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (GameplayRemoveTimeSeconds));
    FinalGameManager.NativeFieldInfoPtr_stages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (stages));
    FinalGameManager.NativeFieldInfoPtr_musicInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (musicInstance));
    FinalGameManager.NativeFieldInfoPtr_muteOtherInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (muteOtherInstance));
    FinalGameManager.NativeFieldInfoPtr_onWavePause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (onWavePause));
    FinalGameManager.NativeFieldInfoPtr_StageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (StageIndex));
    FinalGameManager.NativeFieldInfoPtr_projectileExplosionPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (projectileExplosionPool));
    FinalGameManager.NativeMethodInfoPtr_get_GameOverYPos_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676457);
    FinalGameManager.NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676458);
    FinalGameManager.NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676459);
    FinalGameManager.NativeMethodInfoPtr_get_WavePause_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676460);
    FinalGameManager.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676461);
    FinalGameManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676462);
    FinalGameManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676463);
    FinalGameManager.NativeMethodInfoPtr_StartGameplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676464);
    FinalGameManager.NativeMethodInfoPtr_SetWavePause_Public_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676465);
    FinalGameManager.NativeMethodInfoPtr_PlayEnemyExplosion_Public_Void_Vector3_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676466);
    FinalGameManager.NativeMethodInfoPtr_PlayProjectileExplosion_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676467);
    FinalGameManager.NativeMethodInfoPtr_OnDeath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676468);
    FinalGameManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676469);
    FinalGameManager.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676470);
    FinalGameManager.NativeMethodInfoPtr_Unpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676471);
    FinalGameManager.NativeMethodInfoPtr_EndFailure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676472);
    FinalGameManager.NativeMethodInfoPtr_EndGameplay_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676473);
    FinalGameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, 100676474);
  }

  public unsafe float GameOverYPos
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123580, XrefRangeEnd = 123582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_get_GameOverYPos_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float LeftEdge
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123582, XrefRangeEnd = 123584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float RightEdge
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123584, XrefRangeEnd = 123586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_get_WavePause_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool gameplayActive
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123586, XrefRangeEnd = 123587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_get_gameplayActive_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123587, XrefRangeEnd = 123600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123600, XrefRangeEnd = 123611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FinalGameManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123611, XrefRangeEnd = 123615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGameplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_StartGameplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123615, XrefRangeEnd = 123619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWavePause(float pauseTime, Il2CppSystem.Action callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pauseTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_SetWavePause_Public_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123619, XrefRangeEnd = 123628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayEnemyExplosion(Vector3 pos, EventReference overrideEvent = default (EventReference))
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideEvent;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_PlayEnemyExplosion_Public_Void_Vector3_EventReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123628, XrefRangeEnd = 123630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayProjectileExplosion(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_PlayProjectileExplosion_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123630, XrefRangeEnd = 123633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDeath()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_OnDeath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123633, XrefRangeEnd = 123646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123646, XrefRangeEnd = 123653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123653, XrefRangeEnd = 123660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unpause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_Unpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123660, XrefRangeEnd = 123661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndFailure()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_EndFailure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 123665, RefRangeEnd = 123667, XrefRangeStart = 123661, XrefRangeEnd = 123665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndGameplay(bool success)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &success
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr_EndGameplay_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123667, XrefRangeEnd = 123670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalGameManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalGameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArcadeTimer timer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_timer));
      return num == System.IntPtr.Zero ? (ArcadeTimer) null : Il2CppObjectPool.Get<ArcadeTimer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject gameplayScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameplayScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameplayScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject pauseScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_pauseScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_pauseScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject timeoutScreen
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_timeoutScreen));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_timeoutScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject topPanel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_topPanel));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_topPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> gameplayControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameplayControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameplayControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> pausedControls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_pausedControls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_pausedControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FinalPlayerController playerController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_playerController));
      return num == System.IntPtr.Zero ? (FinalPlayerController) null : Il2CppObjectPool.Get<FinalPlayerController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_playerController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform gameScreenRoot
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameScreenRoot));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameScreenRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float screenRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_screenRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_screenRadius)) = value;
    }
  }

  public unsafe ParticleSystem enemyExplosionVFX
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_enemyExplosionVFX));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_enemyExplosionVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PoolableObject projectileExplosionVFX
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_projectileExplosionVFX));
      return num == System.IntPtr.Zero ? (PoolableObject) null : Il2CppObjectPool.Get<PoolableObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_projectileExplosionVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem appearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_appearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_appearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem dissapearEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_dissapearEffect));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_dissapearEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference music
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_music));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_music)) = value;
    }
  }

  public unsafe EventReference enemyExplosionSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_enemyExplosionSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_enemyExplosionSound)) = value;
    }
  }

  public unsafe EventReference gameoverSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameoverSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_gameoverSound)) = value;
    }
  }

  public unsafe EventReference muteOther
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_muteOther));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_muteOther)) = value;
    }
  }

  public unsafe int GameplayTimeSeconds
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_GameplayTimeSeconds));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_GameplayTimeSeconds)) = value;
    }
  }

  public unsafe int GameplayRemoveTimeSeconds
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_GameplayRemoveTimeSeconds));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_GameplayRemoveTimeSeconds)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<FinalGameManager.FinalGameStage> stages
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_stages));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<FinalGameManager.FinalGameStage>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<FinalGameManager.FinalGameStage>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_stages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventInstance musicInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_musicInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_musicInstance)) = value;
    }
  }

  public unsafe EventInstance muteOtherInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_muteOtherInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_muteOtherInstance)) = value;
    }
  }

  public unsafe bool onWavePause
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_onWavePause));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_onWavePause)) = value;
    }
  }

  public unsafe int StageIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_StageIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_StageIndex)) = value;
    }
  }

  public unsafe ObjectPool projectileExplosionPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_projectileExplosionPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.NativeFieldInfoPtr_projectileExplosionPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class FinalGameStage : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Activate;

    static FinalGameStage()
    {
      Il2CppClassPointerStore<FinalGameManager.FinalGameStage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, nameof (FinalGameStage));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalGameManager.FinalGameStage>.NativeClassPtr);
      FinalGameManager.FinalGameStage.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager.FinalGameStage>.NativeClassPtr, nameof (Time));
      FinalGameManager.FinalGameStage.NativeFieldInfoPtr_Activate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager.FinalGameStage>.NativeClassPtr, nameof (Activate));
    }

    public FinalGameStage(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public FinalGameStage()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalGameManager.FinalGameStage>.NativeClassPtr))
    {
    }

    public unsafe int Time
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.FinalGameStage.NativeFieldInfoPtr_Time));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.FinalGameStage.NativeFieldInfoPtr_Time)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> Activate
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.FinalGameStage.NativeFieldInfoPtr_Activate));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager.FinalGameStage.NativeFieldInfoPtr_Activate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.FinalGameManager+<EndGameplay>d__48")]
  public sealed class _EndGameplay_d__48 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_success;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _EndGameplay_d__48()
    {
      Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, "<EndGameplay>d__48");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr);
      FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr, "<>1__state");
      FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr, "<>t__builder");
      FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr, "<>4__this");
      FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr, nameof (success));
      FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr, "<>u__1");
      FinalGameManager._EndGameplay_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr, 100676475);
      FinalGameManager._EndGameplay_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr, 100676476);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123476, XrefRangeEnd = 123515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalGameManager._EndGameplay_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FinalGameManager._EndGameplay_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _EndGameplay_d__48(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _EndGameplay_d__48()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalGameManager._EndGameplay_d__48>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FinalGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FinalGameManager) null : Il2CppObjectPool.Get<FinalGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool success
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr_success));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr_success)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._EndGameplay_d__48.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.FinalGameManager+<SetWavePause>d__40")]
  public sealed class _SetWavePause_d__40 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_pauseTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_callback;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SetWavePause_d__40()
    {
      Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, "<SetWavePause>d__40");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr);
      FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, "<>1__state");
      FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, "<>t__builder");
      FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, "<>4__this");
      FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr_pauseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, nameof (pauseTime));
      FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, nameof (callback));
      FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, "<>u__1");
      FinalGameManager._SetWavePause_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, 100676477);
      FinalGameManager._SetWavePause_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr, 100676478);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123515, XrefRangeEnd = 123528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalGameManager._SetWavePause_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FinalGameManager._SetWavePause_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SetWavePause_d__40(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SetWavePause_d__40()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalGameManager._SetWavePause_d__40>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FinalGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FinalGameManager) null : Il2CppObjectPool.Get<FinalGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float pauseTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr_pauseTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr_pauseTime)) = value;
      }
    }

    public unsafe Il2CppSystem.Action callback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr_callback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._SetWavePause_d__40.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.FinalGameManager+<StartGameplay>d__39")]
  public sealed class _StartGameplay_d__39 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _StartGameplay_d__39()
    {
      Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalGameManager>.NativeClassPtr, "<StartGameplay>d__39");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr);
      FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr, "<>1__state");
      FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr, "<>t__builder");
      FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr, "<>4__this");
      FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr, "<>u__1");
      FinalGameManager._StartGameplay_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr, 100676479);
      FinalGameManager._StartGameplay_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr, 100676480);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123528, XrefRangeEnd = 123580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalGameManager._StartGameplay_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FinalGameManager._StartGameplay_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _StartGameplay_d__39(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _StartGameplay_d__39()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalGameManager._StartGameplay_d__39>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FinalGameManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FinalGameManager) null : Il2CppObjectPool.Get<FinalGameManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalGameManager._StartGameplay_d__39.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
