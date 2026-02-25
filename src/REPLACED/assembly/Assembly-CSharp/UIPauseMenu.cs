// Decompiled with JetBrains decompiler
// Type: UIPauseMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using MessagePipe;
using Rewired;
using SadCatStudios.Foundation.Events;
using SadCatStudios.UI;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class UIPauseMenu(System.IntPtr pointer) : UISubmenuHandler(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_continueButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_checkpointButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_settingsButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_skipButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_submenuDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_menuAndBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_versionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastSaveText;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastSaveLoca;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_unpausedPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_beginResetPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_skipPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonList;
  private static readonly System.IntPtr NativeFieldInfoPtr_waitingForDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_keyboardHelper;
  private static readonly System.IntPtr NativeFieldInfoPtr_gamepadHelper;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnterSubmenu_Public_Virtual_Void_SubmenuActions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupMenuButtons_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowPauseMenu_Private_Void_GamePausedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HidePauseMenu_Private_Void_GameUnpausedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActionWithSubmenuDelay_Private_UniTaskVoid_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueButton_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RestartFromCheckpointButton_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RestartFromCheckpoint_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SkipCutscene_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RestartFromInitial_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromTopLevel_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToTopLevel_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExitMenu_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___n__0_Private_Void_SubmenuActions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__RestartFromCheckpoint_b__32_0_Private_UniTask_0;

  static UIPauseMenu()
  {
    Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UIPauseMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr);
    UIPauseMenu.NativeFieldInfoPtr_continueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (continueButton));
    UIPauseMenu.NativeFieldInfoPtr_checkpointButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (checkpointButton));
    UIPauseMenu.NativeFieldInfoPtr_settingsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (settingsButton));
    UIPauseMenu.NativeFieldInfoPtr_exitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (exitButton));
    UIPauseMenu.NativeFieldInfoPtr_debugButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (debugButton));
    UIPauseMenu.NativeFieldInfoPtr_skipButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (skipButton));
    UIPauseMenu.NativeFieldInfoPtr_submenuDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (submenuDelay));
    UIPauseMenu.NativeFieldInfoPtr_menuAndBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (menuAndBackground));
    UIPauseMenu.NativeFieldInfoPtr_pauseMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (pauseMenu));
    UIPauseMenu.NativeFieldInfoPtr_versionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (versionText));
    UIPauseMenu.NativeFieldInfoPtr_lastSaveText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (lastSaveText));
    UIPauseMenu.NativeFieldInfoPtr_lastSaveLoca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (lastSaveLoca));
    UIPauseMenu.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (eventDisposable));
    UIPauseMenu.NativeFieldInfoPtr_unpausedPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (unpausedPublisher));
    UIPauseMenu.NativeFieldInfoPtr_beginResetPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (beginResetPublisher));
    UIPauseMenu.NativeFieldInfoPtr_skipPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (skipPublisher));
    UIPauseMenu.NativeFieldInfoPtr_buttonList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (buttonList));
    UIPauseMenu.NativeFieldInfoPtr_waitingForDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (waitingForDelay));
    UIPauseMenu.NativeFieldInfoPtr_keyboardHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (keyboardHelper));
    UIPauseMenu.NativeFieldInfoPtr_gamepadHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, nameof (gamepadHelper));
    UIPauseMenu.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663471 /*0x060000AF*/);
    UIPauseMenu.NativeMethodInfoPtr_EnterSubmenu_Public_Virtual_Void_SubmenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663472 /*0x060000B0*/);
    UIPauseMenu.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663473 /*0x060000B1*/);
    UIPauseMenu.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663474 /*0x060000B2*/);
    UIPauseMenu.NativeMethodInfoPtr_SetupMenuButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663475 /*0x060000B3*/);
    UIPauseMenu.NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663476 /*0x060000B4*/);
    UIPauseMenu.NativeMethodInfoPtr_ShowPauseMenu_Private_Void_GamePausedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663477 /*0x060000B5*/);
    UIPauseMenu.NativeMethodInfoPtr_HidePauseMenu_Private_Void_GameUnpausedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663478 /*0x060000B6*/);
    UIPauseMenu.NativeMethodInfoPtr_ActionWithSubmenuDelay_Private_UniTaskVoid_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663479 /*0x060000B7*/);
    UIPauseMenu.NativeMethodInfoPtr_ContinueButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663480 /*0x060000B8*/);
    UIPauseMenu.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663481 /*0x060000B9*/);
    UIPauseMenu.NativeMethodInfoPtr_RestartFromCheckpointButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663482 /*0x060000BA*/);
    UIPauseMenu.NativeMethodInfoPtr_RestartFromCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663483 /*0x060000BB*/);
    UIPauseMenu.NativeMethodInfoPtr_SkipCutscene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663484 /*0x060000BC*/);
    UIPauseMenu.NativeMethodInfoPtr_RestartFromInitial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663485 /*0x060000BD*/);
    UIPauseMenu.NativeMethodInfoPtr_FromTopLevel_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663486 /*0x060000BE*/);
    UIPauseMenu.NativeMethodInfoPtr_ToTopLevel_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663487 /*0x060000BF*/);
    UIPauseMenu.NativeMethodInfoPtr_ExitMenu_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663488 /*0x060000C0*/);
    UIPauseMenu.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663489 /*0x060000C1*/);
    UIPauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663490 /*0x060000C2*/);
    UIPauseMenu.NativeMethodInfoPtr___n__0_Private_Void_SubmenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663491 /*0x060000C3*/);
    UIPauseMenu.NativeMethodInfoPtr__RestartFromCheckpoint_b__32_0_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, 100663492 /*0x060000C4*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19796, XrefRangeEnd = 19891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19891, XrefRangeEnd = 19905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void EnterSubmenu(UISubmenuHandler.SubmenuActions action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPauseMenu.NativeMethodInfoPtr_EnterSubmenu_Public_Virtual_Void_SubmenuActions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19905, XrefRangeEnd = 19914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19914, XrefRangeEnd = 19928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 19967, RefRangeEnd = 19969, XrefRangeStart = 19928, XrefRangeEnd = 19967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupMenuButtons()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_SetupMenuButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19969, XrefRangeEnd = 19985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerChanged(Player _player, Controller _controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _controller);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19985, XrefRangeEnd = 19998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPauseMenu(GamePausedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_ShowPauseMenu_Private_Void_GamePausedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19998, XrefRangeEnd = 20004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HidePauseMenu(GameUnpausedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_HidePauseMenu_Private_Void_GameUnpausedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 20007, RefRangeEnd = 20009, XrefRangeStart = 20004, XrefRangeEnd = 20007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid ActionWithSubmenuDelay(Il2CppSystem.Action action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_ActionWithSubmenuDelay_Private_UniTaskVoid_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20009, XrefRangeEnd = 20017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContinueButton()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_ContinueButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20017, XrefRangeEnd = 20021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Continue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20021, XrefRangeEnd = 20029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestartFromCheckpointButton()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_RestartFromCheckpointButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 20043, RefRangeEnd = 20044, XrefRangeStart = 20029, XrefRangeEnd = 20043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestartFromCheckpoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_RestartFromCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20044, XrefRangeEnd = 20052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SkipCutscene()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_SkipCutscene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20052, XrefRangeEnd = 20075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestartFromInitial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_RestartFromInitial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20075, XrefRangeEnd = 20077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void FromTopLevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPauseMenu.NativeMethodInfoPtr_FromTopLevel_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20077, XrefRangeEnd = 20080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ToTopLevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPauseMenu.NativeMethodInfoPtr_ToTopLevel_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ExitMenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPauseMenu.NativeMethodInfoPtr_ExitMenu_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20080, XrefRangeEnd = 20084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Exit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20084, XrefRangeEnd = 20085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIPauseMenu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20085, XrefRangeEnd = 20086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void __n__0(UISubmenuHandler.SubmenuActions action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr___n__0_Private_Void_SubmenuActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20086, XrefRangeEnd = 20102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask _RestartFromCheckpoint_b__32_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.NativeMethodInfoPtr__RestartFromCheckpoint_b__32_0_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  public unsafe UnityEngine.UI.Button continueButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_continueButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_continueButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button checkpointButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_checkpointButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_checkpointButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button settingsButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_settingsButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_settingsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button exitButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_exitButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_exitButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button debugButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_debugButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_debugButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button skipButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_skipButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_skipButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float submenuDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_submenuDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_submenuDelay)) = value;
    }
  }

  public unsafe RectTransform menuAndBackground
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_menuAndBackground));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_menuAndBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject pauseMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_pauseMenu));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_pauseMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text versionText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_versionText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_versionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIGlyphText lastSaveText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_lastSaveText));
      return num == System.IntPtr.Zero ? (UIGlyphText) null : Il2CppObjectPool.Get<UIGlyphText>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_lastSaveText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef lastSaveLoca
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_lastSaveLoca));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_lastSaveLoca), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<GameUnpausedEvent> unpausedPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_unpausedPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<GameUnpausedEvent>) null : Il2CppObjectPool.Get<IPublisher<GameUnpausedEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_unpausedPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<BeginResetToCheckpointEvent> beginResetPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_beginResetPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<BeginResetToCheckpointEvent>) null : Il2CppObjectPool.Get<IPublisher<BeginResetToCheckpointEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_beginResetPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<SkipCutsceneEvent> skipPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_skipPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<SkipCutsceneEvent>) null : Il2CppObjectPool.Get<IPublisher<SkipCutsceneEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_skipPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<UnityEngine.UI.Button> buttonList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_buttonList));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UnityEngine.UI.Button>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.UI.Button>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_buttonList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool waitingForDelay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_waitingForDelay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_waitingForDelay)) = value;
    }
  }

  public unsafe GameObject keyboardHelper
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_keyboardHelper));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_keyboardHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject gamepadHelper
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_gamepadHelper));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.NativeFieldInfoPtr_gamepadHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("UIPauseMenu+<<RestartFromCheckpoint>b__32_0>d")]
  public sealed class __RestartFromCheckpoint_b__32_0_d : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static __RestartFromCheckpoint_b__32_0_d()
    {
      Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, "<<RestartFromCheckpoint>b__32_0>d");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr);
      UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr, "<>1__state");
      UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr, "<>t__builder");
      UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr, "<>4__this");
      UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr, 100663493 /*0x060000C5*/);
      UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr, 100663494 /*0x060000C6*/);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 16708, RefRangeEnd = 16710, XrefRangeStart = 16702, XrefRangeEnd = 16708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16710, XrefRangeEnd = 16711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public __RestartFromCheckpoint_b__32_0_d(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __RestartFromCheckpoint_b__32_0_d()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPauseMenu.__RestartFromCheckpoint_b__32_0_d>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UIPauseMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIPauseMenu) null : Il2CppObjectPool.Get<UIPauseMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__RestartFromCheckpoint_b__32_0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UIPauseMenu+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__32_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__34_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RestartFromCheckpoint_b__32_1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RestartFromInitial_b__34_0_Internal_Void_AsyncOperation_0;

    static __c()
    {
      Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr);
      UIPauseMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr, "<>9");
      UIPauseMenu.__c.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr, "<>9__32_1");
      UIPauseMenu.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr, "<>9__34_0");
      UIPauseMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr, 100663496 /*0x060000C8*/);
      UIPauseMenu.__c.NativeMethodInfoPtr__RestartFromCheckpoint_b__32_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr, 100663497 /*0x060000C9*/);
      UIPauseMenu.__c.NativeMethodInfoPtr__RestartFromInitial_b__34_0_Internal_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr, 100663498 /*0x060000CA*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16711, XrefRangeEnd = 16712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPauseMenu.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19716, XrefRangeEnd = 19736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RestartFromCheckpoint_b__32_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.__c.NativeMethodInfoPtr__RestartFromCheckpoint_b__32_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19736, XrefRangeEnd = 19762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RestartFromInitial_b__34_0(AsyncOperation _op)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _op)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.__c.NativeMethodInfoPtr__RestartFromInitial_b__34_0_Internal_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe UIPauseMenu.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIPauseMenu.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UIPauseMenu.__c) null : Il2CppObjectPool.Get<UIPauseMenu.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIPauseMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action __9__32_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIPauseMenu.__c.NativeFieldInfoPtr___9__32_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIPauseMenu.__c.NativeFieldInfoPtr___9__32_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<AsyncOperation> __9__34_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIPauseMenu.__c.NativeFieldInfoPtr___9__34_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<AsyncOperation>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<AsyncOperation>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIPauseMenu.__c.NativeFieldInfoPtr___9__34_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UIPauseMenu+<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_action;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EnterSubmenu_b__0_Internal_Void_0;

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<UIPauseMenu.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPauseMenu.__c__DisplayClass21_0>.NativeClassPtr);
      UIPauseMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
      UIPauseMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu.__c__DisplayClass21_0>.NativeClassPtr, nameof (action));
      UIPauseMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu.__c__DisplayClass21_0>.NativeClassPtr, 100663499 /*0x060000CB*/);
      UIPauseMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__EnterSubmenu_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu.__c__DisplayClass21_0>.NativeClassPtr, 100663500 /*0x060000CC*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPauseMenu.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19762, XrefRangeEnd = 19764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _EnterSubmenu_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__EnterSubmenu_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UIPauseMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIPauseMenu) null : Il2CppObjectPool.Get<UIPauseMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISubmenuHandler.SubmenuActions action
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_action));
        return num == System.IntPtr.Zero ? (UISubmenuHandler.SubmenuActions) null : Il2CppObjectPool.Get<UISubmenuHandler.SubmenuActions>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UIPauseMenu+<ActionWithSubmenuDelay>d__28")]
  public sealed class _ActionWithSubmenuDelay_d__28 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_action;
    private static readonly System.IntPtr NativeFieldInfoPtr__disabledColor_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _ActionWithSubmenuDelay_d__28()
    {
      Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPauseMenu>.NativeClassPtr, "<ActionWithSubmenuDelay>d__28");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr);
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, "<>1__state");
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, "<>t__builder");
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, "<>4__this");
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, nameof (action));
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr__disabledColor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, "<disabledColor>5__2");
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, "<>u__1");
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, 100663501 /*0x060000CD*/);
      UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr, 100663502 /*0x060000CE*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19764, XrefRangeEnd = 19796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _ActionWithSubmenuDelay_d__28(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _ActionWithSubmenuDelay_d__28()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPauseMenu._ActionWithSubmenuDelay_d__28>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UIPauseMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIPauseMenu) null : Il2CppObjectPool.Get<UIPauseMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action action
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr_action));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color _disabledColor_5__2
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr__disabledColor_5__2));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr__disabledColor_5__2)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPauseMenu._ActionWithSubmenuDelay_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
