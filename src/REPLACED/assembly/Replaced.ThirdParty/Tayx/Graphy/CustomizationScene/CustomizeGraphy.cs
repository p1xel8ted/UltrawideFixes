// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.CustomizationScene.CustomizeGraphy
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.CustomizationScene;

public class CustomizeGraphy(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_colorPicker;
  private static readonly IntPtr NativeFieldInfoPtr_m_backgroundToggle;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyModeDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_backgroundColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphModulePositionDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsModuleStateDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_goodInputField;
  private static readonly IntPtr NativeFieldInfoPtr_m_cautionInputField;
  private static readonly IntPtr NativeFieldInfoPtr_m_goodColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_cautionColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_criticalColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMinMaxSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsGraphResolutionSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsTextUpdateRateSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramModuleStateDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_reservedColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_allocatedColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_monoColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramGraphResolutionSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramTextUpdateRateSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioModuleStateDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphColorButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_findAudioListenerDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_fttWindowDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_spectrumSizeSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphResolutionSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioTextUpdateRateSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_advancedModulePositionDropdown;
  private static readonly IntPtr NativeFieldInfoPtr_m_advancedModuleToggle;
  private static readonly IntPtr NativeFieldInfoPtr_m_musicButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_sfxButton;
  private static readonly IntPtr NativeFieldInfoPtr_m_musicVolumeSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_sfxVolumeSlider;
  private static readonly IntPtr NativeFieldInfoPtr_m_musicAudioSource;
  private static readonly IntPtr NativeFieldInfoPtr_m_sfxAudioSource;
  private static readonly IntPtr NativeFieldInfoPtr_m_sfxAudioClips;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetupCallbacks_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToggleMusic_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayRandomSFX_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_0_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_1_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_30_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_2_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_3_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_4_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_5_Private_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_6_Private_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_7_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_31_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_8_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_32_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_9_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_33_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_10_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_11_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_12_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_13_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_14_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_34_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_15_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_35_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_16_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_36_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_17_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_18_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_19_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_20_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_37_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_21_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_22_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_23_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_24_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_25_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_26_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_27_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_28_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetupCallbacks_b__38_29_Private_Void_Single_0;

  static CustomizeGraphy()
  {
    Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.CustomizationScene", nameof (CustomizeGraphy));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr);
    CustomizeGraphy.NativeFieldInfoPtr_m_colorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_colorPicker));
    CustomizeGraphy.NativeFieldInfoPtr_m_backgroundToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_backgroundToggle));
    CustomizeGraphy.NativeFieldInfoPtr_m_graphyModeDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_graphyModeDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_backgroundColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_backgroundColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_graphModulePositionDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_graphModulePositionDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_fpsModuleStateDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_fpsModuleStateDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_goodInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_goodInputField));
    CustomizeGraphy.NativeFieldInfoPtr_m_cautionInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_cautionInputField));
    CustomizeGraphy.NativeFieldInfoPtr_m_goodColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_goodColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_cautionColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_cautionColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_criticalColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_criticalColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_timeToResetMinMaxSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_timeToResetMinMaxSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_fpsGraphResolutionSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_fpsGraphResolutionSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_fpsTextUpdateRateSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_fpsTextUpdateRateSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_ramModuleStateDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_ramModuleStateDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_reservedColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_reservedColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_allocatedColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_allocatedColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_monoColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_monoColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_ramGraphResolutionSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_ramGraphResolutionSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_ramTextUpdateRateSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_ramTextUpdateRateSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_audioModuleStateDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_audioModuleStateDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_audioGraphColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_audioGraphColorButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_findAudioListenerDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_findAudioListenerDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_fttWindowDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_fttWindowDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_spectrumSizeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_spectrumSizeSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_audioGraphResolutionSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_audioGraphResolutionSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_audioTextUpdateRateSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_audioTextUpdateRateSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_advancedModulePositionDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_advancedModulePositionDropdown));
    CustomizeGraphy.NativeFieldInfoPtr_m_advancedModuleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_advancedModuleToggle));
    CustomizeGraphy.NativeFieldInfoPtr_m_musicButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_musicButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_sfxButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_sfxButton));
    CustomizeGraphy.NativeFieldInfoPtr_m_musicVolumeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_musicVolumeSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_sfxVolumeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_sfxVolumeSlider));
    CustomizeGraphy.NativeFieldInfoPtr_m_musicAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_musicAudioSource));
    CustomizeGraphy.NativeFieldInfoPtr_m_sfxAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_sfxAudioSource));
    CustomizeGraphy.NativeFieldInfoPtr_m_sfxAudioClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_sfxAudioClips));
    CustomizeGraphy.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, nameof (m_graphyManager));
    CustomizeGraphy.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663681);
    CustomizeGraphy.NativeMethodInfoPtr_SetupCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663682);
    CustomizeGraphy.NativeMethodInfoPtr_ToggleMusic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663683);
    CustomizeGraphy.NativeMethodInfoPtr_PlayRandomSFX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663684);
    CustomizeGraphy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663685);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663686);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663687);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_30_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663688);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_2_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663689);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663690);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_4_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663691);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_5_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663692);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_6_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663693);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663694);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_31_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663695);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663696 /*0x06000190*/);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_32_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663697);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663698);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_33_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663699);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_10_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663700);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_11_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663701);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_12_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663702);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_13_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663703);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_14_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663704);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_34_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663705);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_15_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663706);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_35_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663707);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_16_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663708);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_36_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663709);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_17_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663710);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_18_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663711);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_19_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663712 /*0x060001A0*/);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_20_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663713);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_37_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663714);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_21_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663715);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_22_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663716);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_23_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663717);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_24_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663718);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_25_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663719);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_26_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663720);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_27_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663721);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_28_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663722);
    CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_29_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr, 100663723);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363482, XrefRangeEnd = 363489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 363745, RefRangeEnd = 363746, XrefRangeStart = 363489, XrefRangeEnd = 363745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCallbacks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr_SetupCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363746, XrefRangeEnd = 363750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleMusic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr_ToggleMusic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363750, XrefRangeEnd = 363757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayRandomSFX()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr_PlayRandomSFX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363757, XrefRangeEnd = 363764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomizeGraphy()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizeGraphy>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363764, XrefRangeEnd = 363769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_0(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363769, XrefRangeEnd = 363779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363779, XrefRangeEnd = 363787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_30(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_30_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363787, XrefRangeEnd = 363796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_2(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_2_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363796, XrefRangeEnd = 363800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_3(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363800, XrefRangeEnd = 363802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_4(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_4_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363802, XrefRangeEnd = 363804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_5(string value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_5_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363804, XrefRangeEnd = 363806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_6(string value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_6_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363806, XrefRangeEnd = 363816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_7()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363816, XrefRangeEnd = 363821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_31(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_31_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363821, XrefRangeEnd = 363831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_8()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363831, XrefRangeEnd = 363836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_32(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_32_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363836, XrefRangeEnd = 363846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_9()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363846, XrefRangeEnd = 363851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_33(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_33_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363851, XrefRangeEnd = 363853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_10(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_10_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363853, XrefRangeEnd = 363855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_11(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_11_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363855, XrefRangeEnd = 363857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_12(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_12_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363857, XrefRangeEnd = 363859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_13(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_13_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363859, XrefRangeEnd = 363869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_14()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_14_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363869, XrefRangeEnd = 363874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_34(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_34_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363874, XrefRangeEnd = 363884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_15()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_15_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363884, XrefRangeEnd = 363889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_35(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_35_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363889, XrefRangeEnd = 363899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_16()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_16_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363899, XrefRangeEnd = 363904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_36(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_36_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363904, XrefRangeEnd = 363906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_17(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_17_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363906, XrefRangeEnd = 363908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_18(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_18_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363908, XrefRangeEnd = 363910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_19(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_19_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363910, XrefRangeEnd = 363920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_20()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_20_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363920, XrefRangeEnd = 363925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_37(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_37_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363925, XrefRangeEnd = 363927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_21(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_21_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363927, XrefRangeEnd = 363929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_22(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_22_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363929, XrefRangeEnd = 363931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_23(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_23_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363931, XrefRangeEnd = 363933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_24(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_24_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363933, XrefRangeEnd = 363935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_25(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_25_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363935, XrefRangeEnd = 363937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_26(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_26_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363937, XrefRangeEnd = 363942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_27(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_27_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363942, XrefRangeEnd = 363944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_28(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_28_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363944, XrefRangeEnd = 363946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetupCallbacks_b__38_29(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomizeGraphy.NativeMethodInfoPtr__SetupCallbacks_b__38_29_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe G_CUIColorPicker m_colorPicker
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_colorPicker));
      return num == IntPtr.Zero ? (G_CUIColorPicker) null : Il2CppObjectPool.Get<G_CUIColorPicker>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_colorPicker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Toggle m_backgroundToggle
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_backgroundToggle));
      return num == IntPtr.Zero ? (Toggle) null : Il2CppObjectPool.Get<Toggle>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_backgroundToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_graphyModeDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_graphyModeDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_graphyModeDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_backgroundColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_backgroundColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_backgroundColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_graphModulePositionDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_graphModulePositionDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_graphModulePositionDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_fpsModuleStateDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fpsModuleStateDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fpsModuleStateDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputField m_goodInputField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_goodInputField));
      return num == IntPtr.Zero ? (InputField) null : Il2CppObjectPool.Get<InputField>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_goodInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputField m_cautionInputField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_cautionInputField));
      return num == IntPtr.Zero ? (InputField) null : Il2CppObjectPool.Get<InputField>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_cautionInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_goodColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_goodColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_goodColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_cautionColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_cautionColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_cautionColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_criticalColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_criticalColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_criticalColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_timeToResetMinMaxSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_timeToResetMinMaxSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_timeToResetMinMaxSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_fpsGraphResolutionSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fpsGraphResolutionSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fpsGraphResolutionSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_fpsTextUpdateRateSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fpsTextUpdateRateSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fpsTextUpdateRateSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_ramModuleStateDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_ramModuleStateDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_ramModuleStateDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_reservedColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_reservedColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_reservedColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_allocatedColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_allocatedColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_allocatedColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_monoColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_monoColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_monoColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_ramGraphResolutionSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_ramGraphResolutionSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_ramGraphResolutionSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_ramTextUpdateRateSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_ramTextUpdateRateSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_ramTextUpdateRateSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_audioModuleStateDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioModuleStateDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioModuleStateDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_audioGraphColorButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioGraphColorButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioGraphColorButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_findAudioListenerDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_findAudioListenerDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_findAudioListenerDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_fttWindowDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fttWindowDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_fttWindowDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_spectrumSizeSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_spectrumSizeSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_spectrumSizeSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_audioGraphResolutionSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioGraphResolutionSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioGraphResolutionSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_audioTextUpdateRateSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioTextUpdateRateSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_audioTextUpdateRateSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dropdown m_advancedModulePositionDropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_advancedModulePositionDropdown));
      return num == IntPtr.Zero ? (Dropdown) null : Il2CppObjectPool.Get<Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_advancedModulePositionDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Toggle m_advancedModuleToggle
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_advancedModuleToggle));
      return num == IntPtr.Zero ? (Toggle) null : Il2CppObjectPool.Get<Toggle>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_advancedModuleToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_musicButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_musicButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_musicButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button m_sfxButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxButton));
      return num == IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_musicVolumeSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_musicVolumeSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_musicVolumeSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider m_sfxVolumeSlider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxVolumeSlider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxVolumeSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AudioSource m_musicAudioSource
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_musicAudioSource));
      return num == IntPtr.Zero ? (AudioSource) null : Il2CppObjectPool.Get<AudioSource>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_musicAudioSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AudioSource m_sfxAudioSource
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxAudioSource));
      return num == IntPtr.Zero ? (AudioSource) null : Il2CppObjectPool.Get<AudioSource>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxAudioSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<AudioClip> m_sfxAudioClips
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxAudioClips));
      return num == IntPtr.Zero ? (List<AudioClip>) null : Il2CppObjectPool.Get<List<AudioClip>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_sfxAudioClips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizeGraphy.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
