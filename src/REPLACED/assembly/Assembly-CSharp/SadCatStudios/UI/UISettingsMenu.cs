// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UISettingsMenu
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
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Rewired;
using SadCatStudios.Foundation;
using SadCatStudios.Foundation.Events;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI;

public class UISettingsMenu(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_languageDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyLevels;
  private static readonly System.IntPtr NativeFieldInfoPtr_subtitleSizeSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_subtitleBackgroundOpacitySlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_simplifiedFontDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_fullscreenDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_vsyncLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_resolutionDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_refreshDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_vsyncDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_brightnessSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_masterSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_musicSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_sfxSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_audioDeviceDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_vibrationSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraShake;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyChangeConfirmation;
  private static readonly System.IntPtr NativeFieldInfoPtr_controllerNotConnectedMsg;
  private static readonly System.IntPtr NativeFieldInfoPtr_disableIfControllerNotConnected;
  private static readonly System.IntPtr NativeFieldInfoPtr_resolutionDirty;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyDirty;
  private static readonly System.IntPtr NativeFieldInfoPtr_subscribedToController;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_controlElementsMain;
  private static readonly System.IntPtr NativeFieldInfoPtr_controlElementsSub;
  private static readonly System.IntPtr NativeFieldInfoPtr_controlElementsBlock;
  private static readonly System.IntPtr NativeFieldInfoPtr_menusToReset;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_refreshRates;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateResolution_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetToDefaults_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DifficultyChanged_Private_UniTaskVoid_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FinishedReset_Private_Void_ResetToCheckpointEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableControlElements_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateControlElements_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckControllerConnected_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Single_Action_1_Single_Slider_0;

  static UISettingsMenu()
  {
    Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UISettingsMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr);
    UISettingsMenu.NativeFieldInfoPtr_pauseMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (pauseMenu));
    UISettingsMenu.NativeFieldInfoPtr_languageDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (languageDropdown));
    UISettingsMenu.NativeFieldInfoPtr_difficultyDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (difficultyDropdown));
    UISettingsMenu.NativeFieldInfoPtr_difficultyLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (difficultyLevels));
    UISettingsMenu.NativeFieldInfoPtr_subtitleSizeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (subtitleSizeSlider));
    UISettingsMenu.NativeFieldInfoPtr_subtitleBackgroundOpacitySlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (subtitleBackgroundOpacitySlider));
    UISettingsMenu.NativeFieldInfoPtr_simplifiedFontDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (simplifiedFontDropdown));
    UISettingsMenu.NativeFieldInfoPtr_fullscreenDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (fullscreenDropdown));
    UISettingsMenu.NativeFieldInfoPtr_vsyncLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (vsyncLabel));
    UISettingsMenu.NativeFieldInfoPtr_resolutionDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (resolutionDropdown));
    UISettingsMenu.NativeFieldInfoPtr_refreshDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (refreshDropdown));
    UISettingsMenu.NativeFieldInfoPtr_vsyncDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (vsyncDropdown));
    UISettingsMenu.NativeFieldInfoPtr_brightnessSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (brightnessSlider));
    UISettingsMenu.NativeFieldInfoPtr_masterSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (masterSlider));
    UISettingsMenu.NativeFieldInfoPtr_musicSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (musicSlider));
    UISettingsMenu.NativeFieldInfoPtr_sfxSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (sfxSlider));
    UISettingsMenu.NativeFieldInfoPtr_audioDeviceDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (audioDeviceDropdown));
    UISettingsMenu.NativeFieldInfoPtr_vibrationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (vibrationSlider));
    UISettingsMenu.NativeFieldInfoPtr_cameraShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (cameraShake));
    UISettingsMenu.NativeFieldInfoPtr_difficultyChangeConfirmation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (difficultyChangeConfirmation));
    UISettingsMenu.NativeFieldInfoPtr_controllerNotConnectedMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (controllerNotConnectedMsg));
    UISettingsMenu.NativeFieldInfoPtr_disableIfControllerNotConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (disableIfControllerNotConnected));
    UISettingsMenu.NativeFieldInfoPtr_resolutionDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (resolutionDirty));
    UISettingsMenu.NativeFieldInfoPtr_difficultyDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (difficultyDirty));
    UISettingsMenu.NativeFieldInfoPtr_subscribedToController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (subscribedToController));
    UISettingsMenu.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (eventDisposable));
    UISettingsMenu.NativeFieldInfoPtr_controlElementsMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (controlElementsMain));
    UISettingsMenu.NativeFieldInfoPtr_controlElementsSub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (controlElementsSub));
    UISettingsMenu.NativeFieldInfoPtr_controlElementsBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (controlElementsBlock));
    UISettingsMenu.NativeFieldInfoPtr_menusToReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (menusToReset));
    UISettingsMenu.NativeFieldInfoPtr_elementBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (elementBuilder));
    UISettingsMenu.NativeFieldInfoPtr_refreshRates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (refreshRates));
    UISettingsMenu.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672229);
    UISettingsMenu.NativeMethodInfoPtr_UpdateResolution_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672230);
    UISettingsMenu.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672231);
    UISettingsMenu.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672232);
    UISettingsMenu.NativeMethodInfoPtr_ResetToDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672233);
    UISettingsMenu.NativeMethodInfoPtr_DifficultyChanged_Private_UniTaskVoid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672234);
    UISettingsMenu.NativeMethodInfoPtr_FinishedReset_Private_Void_ResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672235);
    UISettingsMenu.NativeMethodInfoPtr_ApplySettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672236);
    UISettingsMenu.NativeMethodInfoPtr_EnableControlElements_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672237);
    UISettingsMenu.NativeMethodInfoPtr_UpdateControlElements_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672238);
    UISettingsMenu.NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672239);
    UISettingsMenu.NativeMethodInfoPtr_CheckControllerConnected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672240);
    UISettingsMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672241);
    UISettingsMenu.NativeMethodInfoPtr_Method_Internal_Static_Void_Single_Action_1_Single_Slider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, 100672242);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99631, XrefRangeEnd = 99635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99648, RefRangeEnd = 99649, XrefRangeStart = 99635, XrefRangeEnd = 99648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateResolution()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_UpdateResolution_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100075, RefRangeEnd = 100076, XrefRangeStart = 99649, XrefRangeEnd = 100075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100076, XrefRangeEnd = 100089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100089, XrefRangeEnd = 100110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetToDefaults()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_ResetToDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100110, XrefRangeEnd = 100113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid DifficultyChanged(int i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_DifficultyChanged_Private_UniTaskVoid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100113, XrefRangeEnd = 100128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FinishedReset(ResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_FinishedReset_Private_Void_ResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100128, XrefRangeEnd = 100136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplySettings()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_ApplySettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100136, XrefRangeEnd = 100138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableControlElements(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_EnableControlElements_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100172, RefRangeEnd = 100173, XrefRangeStart = 100138, XrefRangeEnd = 100172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateControlElements(bool isSub)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isSub
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_UpdateControlElements_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100173, XrefRangeEnd = 100174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerChanged(Player player, Controller controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100201, RefRangeEnd = 100202, XrefRangeStart = 100174, XrefRangeEnd = 100201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckControllerConnected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_CheckControllerConnected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100202, XrefRangeEnd = 100237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISettingsMenu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 100251, RefRangeEnd = 100258, XrefRangeStart = 100237, XrefRangeEnd = 100251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Internal_Static_Void_Single_Action_1_Single_Slider_0(
    float savedValue,
    Il2CppSystem.Action<float> setSliderValue,
    Slider slider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &savedValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) setSliderValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.NativeMethodInfoPtr_Method_Internal_Static_Void_Single_Action_1_Single_Slider_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UIPauseMenu pauseMenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_pauseMenu));
      return num == System.IntPtr.Zero ? (UIPauseMenu) null : Il2CppObjectPool.Get<UIPauseMenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_pauseMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect languageDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_languageDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_languageDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect difficultyDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<SadCatStudios.Foundation.DifficultyLevel> difficultyLevels
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyLevels));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SadCatStudios.Foundation.DifficultyLevel>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SadCatStudios.Foundation.DifficultyLevel>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyLevels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider subtitleSizeSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_subtitleSizeSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_subtitleSizeSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider subtitleBackgroundOpacitySlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_subtitleBackgroundOpacitySlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_subtitleBackgroundOpacitySlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect simplifiedFontDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_simplifiedFontDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_simplifiedFontDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect fullscreenDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_fullscreenDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_fullscreenDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text vsyncLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_vsyncLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_vsyncLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect resolutionDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_resolutionDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_resolutionDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect refreshDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_refreshDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_refreshDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect vsyncDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_vsyncDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_vsyncDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider brightnessSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_brightnessSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_brightnessSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider masterSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_masterSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_masterSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider musicSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_musicSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_musicSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider sfxSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_sfxSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_sfxSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect audioDeviceDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_audioDeviceDropdown));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_audioDeviceDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider vibrationSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_vibrationSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_vibrationSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect cameraShake
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_cameraShake));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_cameraShake), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIConfirmationWindow difficultyChangeConfirmation
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyChangeConfirmation));
      return num == System.IntPtr.Zero ? (UIConfirmationWindow) null : Il2CppObjectPool.Get<UIConfirmationWindow>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyChangeConfirmation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text controllerNotConnectedMsg
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controllerNotConnectedMsg));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controllerNotConnectedMsg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GameObject> disableIfControllerNotConnected
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_disableIfControllerNotConnected));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_disableIfControllerNotConnected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool resolutionDirty
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_resolutionDirty));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_resolutionDirty)) = value;
    }
  }

  public unsafe bool difficultyDirty
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyDirty));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_difficultyDirty)) = value;
    }
  }

  public unsafe bool subscribedToController
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_subscribedToController));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_subscribedToController)) = value;
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<UISettingsMenu.ControlElement> controlElementsMain
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controlElementsMain));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UISettingsMenu.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UISettingsMenu.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controlElementsMain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<UISettingsMenu.ControlElement> controlElementsSub
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controlElementsSub));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UISettingsMenu.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UISettingsMenu.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controlElementsSub), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject controlElementsBlock
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controlElementsBlock));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_controlElementsBlock), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UISettingsMenu.MenuToResetKind menusToReset
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_menusToReset));
      return num == System.IntPtr.Zero ? (UISettingsMenu.MenuToResetKind) null : Il2CppObjectPool.Get<UISettingsMenu.MenuToResetKind>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_menusToReset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder elementBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_elementBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_elementBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> refreshRates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_refreshRates));
      return num == System.IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.NativeFieldInfoPtr_refreshRates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ControlElement(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NameRef;
    private static readonly System.IntPtr NativeFieldInfoPtr_Action;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ControlElement()
    {
      Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (ControlElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr);
      UISettingsMenu.ControlElement.NativeFieldInfoPtr_NameRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr, nameof (NameRef));
      UISettingsMenu.ControlElement.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr, nameof (Action));
      UISettingsMenu.ControlElement.NativeFieldInfoPtr_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr, nameof (TextElement));
      UISettingsMenu.ControlElement.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr, nameof (Button));
      UISettingsMenu.ControlElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr, 100672243);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ControlElement()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu.ControlElement>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.ControlElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ArticyRef NameRef
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_NameRef));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_NameRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string Action
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_Action)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_Action), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe UIGlyphText TextElement
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_TextElement));
        return num == System.IntPtr.Zero ? (UIGlyphText) null : Il2CppObjectPool.Get<UIGlyphText>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_TextElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEngine.UI.Button Button
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_Button));
        return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.ControlElement.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class MenuToResetKind(System.IntPtr pointer) : 
    UnitySerializedDictionary<GameObject, GlobalState.ResetMenu>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MenuToResetKind()
    {
      Il2CppClassPointerStore<UISettingsMenu.MenuToResetKind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, nameof (MenuToResetKind));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu.MenuToResetKind>.NativeClassPtr);
      UISettingsMenu.MenuToResetKind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.MenuToResetKind>.NativeClassPtr, 100672244);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99455, XrefRangeEnd = 99458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MenuToResetKind()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu.MenuToResetKind>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.MenuToResetKind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UISettingsMenu+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_8;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_10;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_11;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_12;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_13;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_14;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_15;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__36_16;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_2_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_8_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_9_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_10_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_11_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_12_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_13_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_14_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_15_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__36_16_Internal_Void_Single_0;

    static __c()
    {
      Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr);
      UISettingsMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_2");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_8");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_9");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_10");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_11");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_12");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_13");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_14");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_15");
      UISettingsMenu.__c.NativeFieldInfoPtr___9__36_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, "<>9__36_16");
      UISettingsMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672246);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672247);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_8_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672248);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_9_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672249);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_10_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672250);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_11_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672251);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_12_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672252);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_13_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672253);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_14_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672254);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_15_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672255);
      UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_16_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr, 100672256 /*0x06002300*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99458, XrefRangeEnd = 99468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_2(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99468, XrefRangeEnd = 99472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_8(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &newValue
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_8_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99472, XrefRangeEnd = 99478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_9(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_9_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99478, XrefRangeEnd = 99484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_10(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_10_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99484, XrefRangeEnd = 99490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_11(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_11_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99490, XrefRangeEnd = 99496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_12(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_12_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99496, XrefRangeEnd = 99498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_13(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_13_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99498, XrefRangeEnd = 99500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_14(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_14_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99500, XrefRangeEnd = 99508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_15(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_15_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99508, XrefRangeEnd = 99516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__36_16(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c.NativeMethodInfoPtr__Start_b__36_16_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe UISettingsMenu.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UISettingsMenu.__c) null : Il2CppObjectPool.Get<UISettingsMenu.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe UnityAction<int> __9__36_2
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_2, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UnityAction<int>) null : Il2CppObjectPool.Get<UnityAction<int>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__36_8
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_8, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_8, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__36_9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__36_10
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_10, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_10, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__36_11
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_11, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_11, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe UnityAction<int> __9__36_12
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_12, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UnityAction<int>) null : Il2CppObjectPool.Get<UnityAction<int>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_12, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__36_13
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_13, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_13, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe UnityAction<int> __9__36_14
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_14, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UnityAction<int>) null : Il2CppObjectPool.Get<UnityAction<int>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_14, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__36_15
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_15, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_15, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__36_16
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_16, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UISettingsMenu.__c.NativeFieldInfoPtr___9__36_16, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UISettingsMenu+<>c__DisplayClass36_0")]
  public sealed class __c__DisplayClass36_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_languages;
    private static readonly System.IntPtr NativeFieldInfoPtr_modes;
    private static readonly System.IntPtr NativeFieldInfoPtr_resolutionValues;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__17_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__3_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__4_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__5_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__6_Internal_Void_Int32_0;

    static __c__DisplayClass36_0()
    {
      Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, "<>c__DisplayClass36_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr);
      UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
      UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_languages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, nameof (languages));
      UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_modes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, nameof (modes));
      UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_resolutionValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, nameof (resolutionValues));
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672257);
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__17_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672258);
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672259);
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672260);
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672261);
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__4_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672262);
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__5_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672263);
      UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__6_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr, 100672264);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass36_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99516, XrefRangeEnd = 99523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__17(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__17_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99523, XrefRangeEnd = 99530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__0(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99530, XrefRangeEnd = 99532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__1(int _)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99532, XrefRangeEnd = 99537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__3(int newMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &newMode
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99537, XrefRangeEnd = 99542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__4(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__4_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99542, XrefRangeEnd = 99547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__5(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__5_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99547, XrefRangeEnd = 99549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__6(int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_0.NativeMethodInfoPtr__Start_b__6_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UISettingsMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UISettingsMenu) null : Il2CppObjectPool.Get<UISettingsMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ArticyLanguage> languages
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_languages));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArticyLanguage>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArticyLanguage>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_languages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<FullScreenMode> modes
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_modes));
        return num == System.IntPtr.Zero ? (List<FullScreenMode>) null : Il2CppObjectPool.Get<List<FullScreenMode>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_modes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Il2CppSystem.ValueTuple<int, int>> resolutionValues
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_resolutionValues));
        return num == System.IntPtr.Zero ? (List<Il2CppSystem.ValueTuple<int, int>>) null : Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, int>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_0.NativeFieldInfoPtr_resolutionValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UISettingsMenu+<>c__DisplayClass36_1")]
  public sealed class __c__DisplayClass36_1(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_thisRes;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__18_Internal_Boolean_ValueTuple_2_Int32_Int32_0;

    static __c__DisplayClass36_1()
    {
      Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, "<>c__DisplayClass36_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_1>.NativeClassPtr);
      UISettingsMenu.__c__DisplayClass36_1.NativeFieldInfoPtr_thisRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_1>.NativeClassPtr, nameof (thisRes));
      UISettingsMenu.__c__DisplayClass36_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_1>.NativeClassPtr, 100672265);
      UISettingsMenu.__c__DisplayClass36_1.NativeMethodInfoPtr__Start_b__18_Internal_Boolean_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_1>.NativeClassPtr, 100672266);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass36_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99549, XrefRangeEnd = 99550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Start_b__18(Il2CppSystem.ValueTuple<int, int> resNm)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) resNm))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_1.NativeMethodInfoPtr__Start_b__18_Internal_Boolean_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Resolution thisRes
    {
      get
      {
        return *(Resolution*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_1.NativeFieldInfoPtr_thisRes));
      }
      [param: In] set
      {
        *(Resolution*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_1.NativeFieldInfoPtr_thisRes)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UISettingsMenu+<>c__DisplayClass36_2")]
  public sealed class __c__DisplayClass36_2(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_setSliderValue;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__19_Internal_Void_Single_0;

    static __c__DisplayClass36_2()
    {
      Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, "<>c__DisplayClass36_2");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_2>.NativeClassPtr);
      UISettingsMenu.__c__DisplayClass36_2.NativeFieldInfoPtr_setSliderValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_2>.NativeClassPtr, nameof (setSliderValue));
      UISettingsMenu.__c__DisplayClass36_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_2>.NativeClassPtr, 100672267);
      UISettingsMenu.__c__DisplayClass36_2.NativeMethodInfoPtr__Start_b__19_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_2>.NativeClassPtr, 100672268);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass36_2()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu.__c__DisplayClass36_2>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99550, XrefRangeEnd = 99551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__19(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &newValue
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu.__c__DisplayClass36_2.NativeMethodInfoPtr__Start_b__19_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppSystem.Action<float> setSliderValue
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_2.NativeFieldInfoPtr_setSliderValue));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu.__c__DisplayClass36_2.NativeFieldInfoPtr_setSliderValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UISettingsMenu+<DifficultyChanged>d__39")]
  public sealed class _DifficultyChanged_d__39 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_i;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _DifficultyChanged_d__39()
    {
      Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, "<DifficultyChanged>d__39");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr);
      UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr, "<>1__state");
      UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr, "<>t__builder");
      UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr, "<>4__this");
      UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr, nameof (i));
      UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr, "<>u__1");
      UISettingsMenu._DifficultyChanged_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr, 100672269);
      UISettingsMenu._DifficultyChanged_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr, 100672270);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99551, XrefRangeEnd = 99600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu._DifficultyChanged_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu._DifficultyChanged_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _DifficultyChanged_d__39(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _DifficultyChanged_d__39()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu._DifficultyChanged_d__39>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UISettingsMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UISettingsMenu) null : Il2CppObjectPool.Get<UISettingsMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int i
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr_i));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr_i)) = value;
      }
    }

    public UniTask<bool>.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___u__1);
        return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._DifficultyChanged_d__39.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UISettingsMenu+<OnEnable>d__34")]
  public sealed class _OnEnable_d__34 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _OnEnable_d__34()
    {
      Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISettingsMenu>.NativeClassPtr, "<OnEnable>d__34");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr);
      UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr, "<>1__state");
      UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr, "<>t__builder");
      UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr, "<>4__this");
      UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr, "<>u__1");
      UISettingsMenu._OnEnable_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr, 100672271);
      UISettingsMenu._OnEnable_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr, 100672272);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99600, XrefRangeEnd = 99631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu._OnEnable_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(UISettingsMenu._OnEnable_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _OnEnable_d__34(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _OnEnable_d__34()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISettingsMenu._OnEnable_d__34>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UISettingsMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UISettingsMenu) null : Il2CppObjectPool.Get<UISettingsMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISettingsMenu._OnEnable_d__34.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }
}
