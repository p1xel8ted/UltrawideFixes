// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.GraphyManager
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using Tayx.Graphy.Advanced;
using Tayx.Graphy.Audio;
using Tayx.Graphy.Fps;
using Tayx.Graphy.Ram;
using Tayx.Graphy.Utils;
using UnityEngine;

#nullable disable
namespace Tayx.Graphy;

public class GraphyManager(IntPtr pointer) : G_Singleton<GraphyManager>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_enableOnStartup;
  private static readonly IntPtr NativeFieldInfoPtr_m_keepAlive;
  private static readonly IntPtr NativeFieldInfoPtr_m_background;
  private static readonly IntPtr NativeFieldInfoPtr_m_backgroundColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_enableHotkeys;
  private static readonly IntPtr NativeFieldInfoPtr_m_toggleModeKeyCode;
  private static readonly IntPtr NativeFieldInfoPtr_m_toggleModeCtrl;
  private static readonly IntPtr NativeFieldInfoPtr_m_toggleModeAlt;
  private static readonly IntPtr NativeFieldInfoPtr_m_toggleActiveKeyCode;
  private static readonly IntPtr NativeFieldInfoPtr_m_toggleActiveCtrl;
  private static readonly IntPtr NativeFieldInfoPtr_m_toggleActiveAlt;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphModulePosition;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsModuleState;
  private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMinMaxFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_goodFpsColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_goodFpsThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_m_cautionFpsColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_cautionFpsThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_m_criticalFpsColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsGraphResolution;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsTextUpdateRate;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramModuleState;
  private static readonly IntPtr NativeFieldInfoPtr_m_allocatedRamColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_reservedRamColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_monoRamColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramGraphResolution;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramTextUpdateRate;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioModuleState;
  private static readonly IntPtr NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioListener;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphColor;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphResolution;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioTextUpdateRate;
  private static readonly IntPtr NativeFieldInfoPtr_m_FFTWindow;
  private static readonly IntPtr NativeFieldInfoPtr_m_spectrumSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_advancedModulePosition;
  private static readonly IntPtr NativeFieldInfoPtr_m_advancedModuleState;
  private static readonly IntPtr NativeFieldInfoPtr_m_initialized;
  private static readonly IntPtr NativeFieldInfoPtr_m_active;
  private static readonly IntPtr NativeFieldInfoPtr_m_focused;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_advancedData;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_modulePresetState;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_GraphyMode_Public_get_Mode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_GraphyMode_Public_set_Void_Mode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnableOnStartup_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Background_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Background_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BackgroundColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_BackgroundColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_GraphModulePosition_Public_get_ModulePosition_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_GraphModulePosition_Public_set_Void_ModulePosition_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FpsModuleState_Public_get_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_FpsModuleState_Public_set_Void_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TimeToResetMinMaxFps_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_TimeToResetMinMaxFps_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_GoodFPSColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_GoodFPSColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CautionFPSColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_CautionFPSColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CriticalFPSColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_CriticalFPSColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_GoodFPSThreshold_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_GoodFPSThreshold_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CautionFPSThreshold_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_CautionFPSThreshold_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FpsGraphResolution_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_FpsGraphResolution_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FpsTextUpdateRate_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_FpsTextUpdateRate_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RamModuleState_Public_get_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_RamModuleState_Public_set_Void_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AllocatedRamColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AllocatedRamColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ReservedRamColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ReservedRamColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MonoRamColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_MonoRamColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RamGraphResolution_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_RamGraphResolution_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RamTextUpdateRate_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_RamTextUpdateRate_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AudioModuleState_Public_get_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AudioModuleState_Public_set_Void_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AudioListener_Public_get_AudioListener_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AudioListener_Public_set_Void_AudioListener_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FindAudioListenerInCameraIfNull_Public_get_LookForAudioListener_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_FindAudioListenerInCameraIfNull_Public_set_Void_LookForAudioListener_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AudioGraphColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AudioGraphColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AudioGraphResolution_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AudioGraphResolution_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AudioTextUpdateRate_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AudioTextUpdateRate_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FftWindow_Public_get_FFTWindow_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_FftWindow_Public_set_Void_FFTWindow_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpectrumSize_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_SpectrumSize_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Spectrum_Public_get_Il2CppStructArray_1_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AdvancedModuleState_Public_get_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AdvancedModuleState_Public_set_Void_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AdvancedModulePosition_Public_get_ModulePosition_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AdvancedModulePosition_Public_set_Void_ModulePosition_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetModulePosition_Public_Void_ModuleType_ModulePosition_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetModuleMode_Public_Void_ModuleType_ModuleState_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToggleModes_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Public_Void_ModulePreset_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToggleActive_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForHotkeyPresses_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckFor1KeyPress_Private_Boolean_KeyCode_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckFor2KeyPress_Private_Boolean_KeyCode_KeyCode_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckFor3KeyPress_Private_Boolean_KeyCode_KeyCode_KeyCode_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateAllParameters_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RefreshAllParameters_Private_Void_0;

  static GraphyManager()
  {
    Il2CppClassPointerStore<GraphyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy", nameof (GraphyManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr);
    GraphyManager.NativeFieldInfoPtr_m_graphyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_graphyMode));
    GraphyManager.NativeFieldInfoPtr_m_enableOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_enableOnStartup));
    GraphyManager.NativeFieldInfoPtr_m_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_keepAlive));
    GraphyManager.NativeFieldInfoPtr_m_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_background));
    GraphyManager.NativeFieldInfoPtr_m_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_backgroundColor));
    GraphyManager.NativeFieldInfoPtr_m_enableHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_enableHotkeys));
    GraphyManager.NativeFieldInfoPtr_m_toggleModeKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_toggleModeKeyCode));
    GraphyManager.NativeFieldInfoPtr_m_toggleModeCtrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_toggleModeCtrl));
    GraphyManager.NativeFieldInfoPtr_m_toggleModeAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_toggleModeAlt));
    GraphyManager.NativeFieldInfoPtr_m_toggleActiveKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_toggleActiveKeyCode));
    GraphyManager.NativeFieldInfoPtr_m_toggleActiveCtrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_toggleActiveCtrl));
    GraphyManager.NativeFieldInfoPtr_m_toggleActiveAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_toggleActiveAlt));
    GraphyManager.NativeFieldInfoPtr_m_graphModulePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_graphModulePosition));
    GraphyManager.NativeFieldInfoPtr_m_fpsModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_fpsModuleState));
    GraphyManager.NativeFieldInfoPtr_m_timeToResetMinMaxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_timeToResetMinMaxFps));
    GraphyManager.NativeFieldInfoPtr_m_goodFpsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_goodFpsColor));
    GraphyManager.NativeFieldInfoPtr_m_goodFpsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_goodFpsThreshold));
    GraphyManager.NativeFieldInfoPtr_m_cautionFpsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_cautionFpsColor));
    GraphyManager.NativeFieldInfoPtr_m_cautionFpsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_cautionFpsThreshold));
    GraphyManager.NativeFieldInfoPtr_m_criticalFpsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_criticalFpsColor));
    GraphyManager.NativeFieldInfoPtr_m_fpsGraphResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_fpsGraphResolution));
    GraphyManager.NativeFieldInfoPtr_m_fpsTextUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_fpsTextUpdateRate));
    GraphyManager.NativeFieldInfoPtr_m_ramModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_ramModuleState));
    GraphyManager.NativeFieldInfoPtr_m_allocatedRamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_allocatedRamColor));
    GraphyManager.NativeFieldInfoPtr_m_reservedRamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_reservedRamColor));
    GraphyManager.NativeFieldInfoPtr_m_monoRamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_monoRamColor));
    GraphyManager.NativeFieldInfoPtr_m_ramGraphResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_ramGraphResolution));
    GraphyManager.NativeFieldInfoPtr_m_ramTextUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_ramTextUpdateRate));
    GraphyManager.NativeFieldInfoPtr_m_audioModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_audioModuleState));
    GraphyManager.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_findAudioListenerInCameraIfNull));
    GraphyManager.NativeFieldInfoPtr_m_audioListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_audioListener));
    GraphyManager.NativeFieldInfoPtr_m_audioGraphColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_audioGraphColor));
    GraphyManager.NativeFieldInfoPtr_m_audioGraphResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_audioGraphResolution));
    GraphyManager.NativeFieldInfoPtr_m_audioTextUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_audioTextUpdateRate));
    GraphyManager.NativeFieldInfoPtr_m_FFTWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_FFTWindow));
    GraphyManager.NativeFieldInfoPtr_m_spectrumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_spectrumSize));
    GraphyManager.NativeFieldInfoPtr_m_advancedModulePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_advancedModulePosition));
    GraphyManager.NativeFieldInfoPtr_m_advancedModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_advancedModuleState));
    GraphyManager.NativeFieldInfoPtr_m_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_initialized));
    GraphyManager.NativeFieldInfoPtr_m_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_active));
    GraphyManager.NativeFieldInfoPtr_m_focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_focused));
    GraphyManager.NativeFieldInfoPtr_m_fpsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_fpsManager));
    GraphyManager.NativeFieldInfoPtr_m_ramManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_ramManager));
    GraphyManager.NativeFieldInfoPtr_m_audioManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_audioManager));
    GraphyManager.NativeFieldInfoPtr_m_advancedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_advancedData));
    GraphyManager.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_fpsMonitor));
    GraphyManager.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_ramMonitor));
    GraphyManager.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_audioMonitor));
    GraphyManager.NativeFieldInfoPtr_m_modulePresetState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, nameof (m_modulePresetState));
    GraphyManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663429 /*0x06000085*/);
    GraphyManager.NativeMethodInfoPtr_get_GraphyMode_Public_get_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663430 /*0x06000086*/);
    GraphyManager.NativeMethodInfoPtr_set_GraphyMode_Public_set_Void_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663431 /*0x06000087*/);
    GraphyManager.NativeMethodInfoPtr_get_EnableOnStartup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663432 /*0x06000088*/);
    GraphyManager.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663433 /*0x06000089*/);
    GraphyManager.NativeMethodInfoPtr_get_Background_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663434 /*0x0600008A*/);
    GraphyManager.NativeMethodInfoPtr_set_Background_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663435 /*0x0600008B*/);
    GraphyManager.NativeMethodInfoPtr_get_BackgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663436 /*0x0600008C*/);
    GraphyManager.NativeMethodInfoPtr_set_BackgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663437 /*0x0600008D*/);
    GraphyManager.NativeMethodInfoPtr_get_GraphModulePosition_Public_get_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663438 /*0x0600008E*/);
    GraphyManager.NativeMethodInfoPtr_set_GraphModulePosition_Public_set_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663439 /*0x0600008F*/);
    GraphyManager.NativeMethodInfoPtr_get_FpsModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663440 /*0x06000090*/);
    GraphyManager.NativeMethodInfoPtr_set_FpsModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663441 /*0x06000091*/);
    GraphyManager.NativeMethodInfoPtr_get_TimeToResetMinMaxFps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663442 /*0x06000092*/);
    GraphyManager.NativeMethodInfoPtr_set_TimeToResetMinMaxFps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663443 /*0x06000093*/);
    GraphyManager.NativeMethodInfoPtr_get_GoodFPSColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663444 /*0x06000094*/);
    GraphyManager.NativeMethodInfoPtr_set_GoodFPSColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663445 /*0x06000095*/);
    GraphyManager.NativeMethodInfoPtr_get_CautionFPSColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663446 /*0x06000096*/);
    GraphyManager.NativeMethodInfoPtr_set_CautionFPSColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663447 /*0x06000097*/);
    GraphyManager.NativeMethodInfoPtr_get_CriticalFPSColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663448 /*0x06000098*/);
    GraphyManager.NativeMethodInfoPtr_set_CriticalFPSColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663449 /*0x06000099*/);
    GraphyManager.NativeMethodInfoPtr_get_GoodFPSThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663450 /*0x0600009A*/);
    GraphyManager.NativeMethodInfoPtr_set_GoodFPSThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663451 /*0x0600009B*/);
    GraphyManager.NativeMethodInfoPtr_get_CautionFPSThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663452 /*0x0600009C*/);
    GraphyManager.NativeMethodInfoPtr_set_CautionFPSThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663453 /*0x0600009D*/);
    GraphyManager.NativeMethodInfoPtr_get_FpsGraphResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663454 /*0x0600009E*/);
    GraphyManager.NativeMethodInfoPtr_set_FpsGraphResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663455 /*0x0600009F*/);
    GraphyManager.NativeMethodInfoPtr_get_FpsTextUpdateRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663456 /*0x060000A0*/);
    GraphyManager.NativeMethodInfoPtr_set_FpsTextUpdateRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663457 /*0x060000A1*/);
    GraphyManager.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663458 /*0x060000A2*/);
    GraphyManager.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663459 /*0x060000A3*/);
    GraphyManager.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663460 /*0x060000A4*/);
    GraphyManager.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663461 /*0x060000A5*/);
    GraphyManager.NativeMethodInfoPtr_get_RamModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663462 /*0x060000A6*/);
    GraphyManager.NativeMethodInfoPtr_set_RamModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663463 /*0x060000A7*/);
    GraphyManager.NativeMethodInfoPtr_get_AllocatedRamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663464 /*0x060000A8*/);
    GraphyManager.NativeMethodInfoPtr_set_AllocatedRamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663465 /*0x060000A9*/);
    GraphyManager.NativeMethodInfoPtr_get_ReservedRamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663466 /*0x060000AA*/);
    GraphyManager.NativeMethodInfoPtr_set_ReservedRamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663467 /*0x060000AB*/);
    GraphyManager.NativeMethodInfoPtr_get_MonoRamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663468 /*0x060000AC*/);
    GraphyManager.NativeMethodInfoPtr_set_MonoRamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663469 /*0x060000AD*/);
    GraphyManager.NativeMethodInfoPtr_get_RamGraphResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663470 /*0x060000AE*/);
    GraphyManager.NativeMethodInfoPtr_set_RamGraphResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663471 /*0x060000AF*/);
    GraphyManager.NativeMethodInfoPtr_get_RamTextUpdateRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663472 /*0x060000B0*/);
    GraphyManager.NativeMethodInfoPtr_set_RamTextUpdateRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663473 /*0x060000B1*/);
    GraphyManager.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663474 /*0x060000B2*/);
    GraphyManager.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663475 /*0x060000B3*/);
    GraphyManager.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663476 /*0x060000B4*/);
    GraphyManager.NativeMethodInfoPtr_get_AudioModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663477 /*0x060000B5*/);
    GraphyManager.NativeMethodInfoPtr_set_AudioModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663478 /*0x060000B6*/);
    GraphyManager.NativeMethodInfoPtr_get_AudioListener_Public_get_AudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663479 /*0x060000B7*/);
    GraphyManager.NativeMethodInfoPtr_set_AudioListener_Public_set_Void_AudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663480 /*0x060000B8*/);
    GraphyManager.NativeMethodInfoPtr_get_FindAudioListenerInCameraIfNull_Public_get_LookForAudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663481 /*0x060000B9*/);
    GraphyManager.NativeMethodInfoPtr_set_FindAudioListenerInCameraIfNull_Public_set_Void_LookForAudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663482 /*0x060000BA*/);
    GraphyManager.NativeMethodInfoPtr_get_AudioGraphColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663483 /*0x060000BB*/);
    GraphyManager.NativeMethodInfoPtr_set_AudioGraphColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663484 /*0x060000BC*/);
    GraphyManager.NativeMethodInfoPtr_get_AudioGraphResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663485 /*0x060000BD*/);
    GraphyManager.NativeMethodInfoPtr_set_AudioGraphResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663486 /*0x060000BE*/);
    GraphyManager.NativeMethodInfoPtr_get_AudioTextUpdateRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663487 /*0x060000BF*/);
    GraphyManager.NativeMethodInfoPtr_set_AudioTextUpdateRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663488 /*0x060000C0*/);
    GraphyManager.NativeMethodInfoPtr_get_FftWindow_Public_get_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663489 /*0x060000C1*/);
    GraphyManager.NativeMethodInfoPtr_set_FftWindow_Public_set_Void_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663490 /*0x060000C2*/);
    GraphyManager.NativeMethodInfoPtr_get_SpectrumSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663491 /*0x060000C3*/);
    GraphyManager.NativeMethodInfoPtr_set_SpectrumSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663492 /*0x060000C4*/);
    GraphyManager.NativeMethodInfoPtr_get_Spectrum_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663493 /*0x060000C5*/);
    GraphyManager.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663494 /*0x060000C6*/);
    GraphyManager.NativeMethodInfoPtr_get_AdvancedModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663495 /*0x060000C7*/);
    GraphyManager.NativeMethodInfoPtr_set_AdvancedModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663496 /*0x060000C8*/);
    GraphyManager.NativeMethodInfoPtr_get_AdvancedModulePosition_Public_get_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663497 /*0x060000C9*/);
    GraphyManager.NativeMethodInfoPtr_set_AdvancedModulePosition_Public_set_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663498 /*0x060000CA*/);
    GraphyManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663499 /*0x060000CB*/);
    GraphyManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663500 /*0x060000CC*/);
    GraphyManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663501 /*0x060000CD*/);
    GraphyManager.NativeMethodInfoPtr_SetModulePosition_Public_Void_ModuleType_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663502 /*0x060000CE*/);
    GraphyManager.NativeMethodInfoPtr_SetModuleMode_Public_Void_ModuleType_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663503 /*0x060000CF*/);
    GraphyManager.NativeMethodInfoPtr_ToggleModes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663504 /*0x060000D0*/);
    GraphyManager.NativeMethodInfoPtr_SetPreset_Public_Void_ModulePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663505 /*0x060000D1*/);
    GraphyManager.NativeMethodInfoPtr_ToggleActive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663506 /*0x060000D2*/);
    GraphyManager.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663507 /*0x060000D3*/);
    GraphyManager.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663508 /*0x060000D4*/);
    GraphyManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663509 /*0x060000D5*/);
    GraphyManager.NativeMethodInfoPtr_CheckForHotkeyPresses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663510 /*0x060000D6*/);
    GraphyManager.NativeMethodInfoPtr_CheckFor1KeyPress_Private_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663511 /*0x060000D7*/);
    GraphyManager.NativeMethodInfoPtr_CheckFor2KeyPress_Private_Boolean_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663512 /*0x060000D8*/);
    GraphyManager.NativeMethodInfoPtr_CheckFor3KeyPress_Private_Boolean_KeyCode_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663513 /*0x060000D9*/);
    GraphyManager.NativeMethodInfoPtr_UpdateAllParameters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663514 /*0x060000DA*/);
    GraphyManager.NativeMethodInfoPtr_RefreshAllParameters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100663515 /*0x060000DB*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361286, XrefRangeEnd = 361292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphyManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GraphyManager.Mode GraphyMode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GraphyMode_Public_get_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.Mode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361292, XrefRangeEnd = 361297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GraphyMode_Public_set_Void_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool EnableOnStartup
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_EnableOnStartup_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool KeepAlive
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Background
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_Background_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361297, XrefRangeEnd = 361302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_Background_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color BackgroundColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_BackgroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361302, XrefRangeEnd = 361307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_BackgroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe GraphyManager.ModulePosition GraphModulePosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GraphModulePosition_Public_get_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.ModulePosition*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361307, XrefRangeEnd = 361311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GraphModulePosition_Public_set_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe GraphyManager.ModuleState FpsModuleState
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FpsModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.ModuleState*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361311, XrefRangeEnd = 361313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FpsModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int TimeToResetMinMaxFps
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 74758, RefRangeEnd = 74763, XrefRangeStart = 74758, XrefRangeEnd = 74763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_TimeToResetMinMaxFps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361313, XrefRangeEnd = 361315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_TimeToResetMinMaxFps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color GoodFPSColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GoodFPSColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361315, XrefRangeEnd = 361317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GoodFPSColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color CautionFPSColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CautionFPSColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361317, XrefRangeEnd = 361319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_CautionFPSColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color CriticalFPSColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CriticalFPSColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361319, XrefRangeEnd = 361321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_CriticalFPSColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int GoodFPSThreshold
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GoodFPSThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361321, XrefRangeEnd = 361323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GoodFPSThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int CautionFPSThreshold
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CautionFPSThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361323, XrefRangeEnd = 361325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_CautionFPSThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int FpsGraphResolution
  {
    [CallerCount(20), CachedScanResults(RefRangeStart = 74775, RefRangeEnd = 74795, XrefRangeStart = 74775, XrefRangeEnd = 74795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FpsGraphResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361325, XrefRangeEnd = 361327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FpsGraphResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int FpsTextUpdateRate
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FpsTextUpdateRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361327, XrefRangeEnd = 361329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FpsTextUpdateRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float CurrentFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float AverageFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MinFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MaxFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe GraphyManager.ModuleState RamModuleState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_RamModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.ModuleState*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361329, XrefRangeEnd = 361331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_RamModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color AllocatedRamColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AllocatedRamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361331, XrefRangeEnd = 361333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AllocatedRamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color ReservedRamColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_ReservedRamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361333, XrefRangeEnd = 361335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_ReservedRamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color MonoRamColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MonoRamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361335, XrefRangeEnd = 361337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_MonoRamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int RamGraphResolution
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_RamGraphResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361337, XrefRangeEnd = 361339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_RamGraphResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int RamTextUpdateRate
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_RamTextUpdateRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361339, XrefRangeEnd = 361341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_RamTextUpdateRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float AllocatedRam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float ReservedRam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MonoRam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe GraphyManager.ModuleState AudioModuleState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.ModuleState*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361341, XrefRangeEnd = 361343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AudioListener AudioListener
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioListener_Public_get_AudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AudioListener) null : Il2CppObjectPool.Get<AudioListener>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361343, XrefRangeEnd = 361345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioListener_Public_set_Void_AudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe GraphyManager.LookForAudioListener FindAudioListenerInCameraIfNull
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FindAudioListenerInCameraIfNull_Public_get_LookForAudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.LookForAudioListener*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361345, XrefRangeEnd = 361347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FindAudioListenerInCameraIfNull_Public_set_Void_LookForAudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color AudioGraphColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioGraphColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361347, XrefRangeEnd = 361349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioGraphColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int AudioGraphResolution
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioGraphResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361349, XrefRangeEnd = 361351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioGraphResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int AudioTextUpdateRate
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioTextUpdateRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361351, XrefRangeEnd = 361353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioTextUpdateRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe FFTWindow FftWindow
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FftWindow_Public_get_FFTWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FFTWindow*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361353, XrefRangeEnd = 361355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FftWindow_Public_set_Void_FFTWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int SpectrumSize
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_SpectrumSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361355, XrefRangeEnd = 361357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_SpectrumSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<float> Spectrum
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_Spectrum_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num3);
    }
  }

  public unsafe float MaxDB
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe GraphyManager.ModuleState AdvancedModuleState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AdvancedModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.ModuleState*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361357, XrefRangeEnd = 361362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AdvancedModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe GraphyManager.ModulePosition AdvancedModulePosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AdvancedModulePosition_Public_get_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphyManager.ModulePosition*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361362, XrefRangeEnd = 361364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AdvancedModulePosition_Public_set_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361364, XrefRangeEnd = 361365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361365, XrefRangeEnd = 361366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361366, XrefRangeEnd = 361370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnApplicationFocus(bool isFocused)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isFocused
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361370, XrefRangeEnd = 361373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetModulePosition(
    GraphyManager.ModuleType moduleType,
    GraphyManager.ModulePosition modulePosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &moduleType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &modulePosition;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_SetModulePosition_Public_Void_ModuleType_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361373, XrefRangeEnd = 361377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetModuleMode(
    GraphyManager.ModuleType moduleType,
    GraphyManager.ModuleState moduleState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &moduleType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &moduleState;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_SetModuleMode_Public_Void_ModuleType_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361388, RefRangeEnd = 361389, XrefRangeStart = 361377, XrefRangeEnd = 361388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleModes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_ToggleModes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361464, RefRangeEnd = 361465, XrefRangeStart = 361389, XrefRangeEnd = 361464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPreset(GraphyManager.ModulePreset modulePreset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &modulePreset
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_SetPreset_Public_Void_ModulePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361474, RefRangeEnd = 361475, XrefRangeStart = 361465, XrefRangeEnd = 361474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_ToggleActive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361475, XrefRangeEnd = 361482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361482, XrefRangeEnd = 361491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361564, RefRangeEnd = 361565, XrefRangeStart = 361491, XrefRangeEnd = 361564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361593, RefRangeEnd = 361594, XrefRangeStart = 361565, XrefRangeEnd = 361593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForHotkeyPresses()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckForHotkeyPresses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361594, XrefRangeEnd = 361595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckFor1KeyPress(KeyCode key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &key
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckFor1KeyPress_Private_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361597, RefRangeEnd = 361598, XrefRangeStart = 361595, XrefRangeEnd = 361597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckFor2KeyPress(KeyCode key1, KeyCode key2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &key1;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &key2;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckFor2KeyPress_Private_Boolean_KeyCode_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 361604, RefRangeEnd = 361612, XrefRangeStart = 361598, XrefRangeEnd = 361604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckFor3KeyPress(KeyCode key1, KeyCode key2, KeyCode key3)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &key1;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &key2;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &key3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckFor3KeyPress_Private_Boolean_KeyCode_KeyCode_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361612, XrefRangeEnd = 361617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateAllParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_UpdateAllParameters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361617, XrefRangeEnd = 361622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshAllParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_RefreshAllParameters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GraphyManager.Mode m_graphyMode
  {
    get
    {
      return *(GraphyManager.Mode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphyMode));
    }
    [param: In] set
    {
      *(GraphyManager.Mode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphyMode)) = value;
    }
  }

  public unsafe bool m_enableOnStartup
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableOnStartup));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableOnStartup)) = value;
    }
  }

  public unsafe bool m_keepAlive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_keepAlive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_keepAlive)) = value;
    }
  }

  public unsafe bool m_background
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_background));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_background)) = value;
    }
  }

  public unsafe Color m_backgroundColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_backgroundColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_backgroundColor)) = value;
    }
  }

  public unsafe bool m_enableHotkeys
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableHotkeys));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableHotkeys)) = value;
    }
  }

  public unsafe KeyCode m_toggleModeKeyCode
  {
    get
    {
      return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeKeyCode));
    }
    [param: In] set
    {
      *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeKeyCode)) = value;
    }
  }

  public unsafe bool m_toggleModeCtrl
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeCtrl));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeCtrl)) = value;
    }
  }

  public unsafe bool m_toggleModeAlt
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeAlt));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeAlt)) = value;
    }
  }

  public unsafe KeyCode m_toggleActiveKeyCode
  {
    get
    {
      return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveKeyCode));
    }
    [param: In] set
    {
      *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveKeyCode)) = value;
    }
  }

  public unsafe bool m_toggleActiveCtrl
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveCtrl));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveCtrl)) = value;
    }
  }

  public unsafe bool m_toggleActiveAlt
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveAlt));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveAlt)) = value;
    }
  }

  public unsafe GraphyManager.ModulePosition m_graphModulePosition
  {
    get
    {
      return *(GraphyManager.ModulePosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphModulePosition));
    }
    [param: In] set
    {
      *(GraphyManager.ModulePosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphModulePosition)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_fpsModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsModuleState)) = value;
    }
  }

  public unsafe int m_timeToResetMinMaxFps
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_timeToResetMinMaxFps));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_timeToResetMinMaxFps)) = value;
    }
  }

  public unsafe Color m_goodFpsColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsColor)) = value;
    }
  }

  public unsafe int m_goodFpsThreshold
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsThreshold));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsThreshold)) = value;
    }
  }

  public unsafe Color m_cautionFpsColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsColor)) = value;
    }
  }

  public unsafe int m_cautionFpsThreshold
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsThreshold));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsThreshold)) = value;
    }
  }

  public unsafe Color m_criticalFpsColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_criticalFpsColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_criticalFpsColor)) = value;
    }
  }

  public unsafe int m_fpsGraphResolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsGraphResolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsGraphResolution)) = value;
    }
  }

  public unsafe int m_fpsTextUpdateRate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsTextUpdateRate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsTextUpdateRate)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_ramModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramModuleState)) = value;
    }
  }

  public unsafe Color m_allocatedRamColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_allocatedRamColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_allocatedRamColor)) = value;
    }
  }

  public unsafe Color m_reservedRamColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_reservedRamColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_reservedRamColor)) = value;
    }
  }

  public unsafe Color m_monoRamColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_monoRamColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_monoRamColor)) = value;
    }
  }

  public unsafe int m_ramGraphResolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramGraphResolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramGraphResolution)) = value;
    }
  }

  public unsafe int m_ramTextUpdateRate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramTextUpdateRate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramTextUpdateRate)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_audioModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioModuleState)) = value;
    }
  }

  public unsafe GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull
  {
    get
    {
      return *(GraphyManager.LookForAudioListener*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull));
    }
    [param: In] set
    {
      *(GraphyManager.LookForAudioListener*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull)) = value;
    }
  }

  public unsafe AudioListener m_audioListener
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioListener));
      return num == IntPtr.Zero ? (AudioListener) null : Il2CppObjectPool.Get<AudioListener>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioListener), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color m_audioGraphColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphColor)) = value;
    }
  }

  public unsafe int m_audioGraphResolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphResolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphResolution)) = value;
    }
  }

  public unsafe int m_audioTextUpdateRate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioTextUpdateRate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioTextUpdateRate)) = value;
    }
  }

  public unsafe FFTWindow m_FFTWindow
  {
    get
    {
      return *(FFTWindow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_FFTWindow));
    }
    [param: In] set
    {
      *(FFTWindow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_FFTWindow)) = value;
    }
  }

  public unsafe int m_spectrumSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_spectrumSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_spectrumSize)) = value;
    }
  }

  public unsafe GraphyManager.ModulePosition m_advancedModulePosition
  {
    get
    {
      return *(GraphyManager.ModulePosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModulePosition));
    }
    [param: In] set
    {
      *(GraphyManager.ModulePosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModulePosition)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_advancedModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModuleState)) = value;
    }
  }

  public unsafe bool m_initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_initialized)) = value;
    }
  }

  public unsafe bool m_active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_active)) = value;
    }
  }

  public unsafe bool m_focused
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_focused));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_focused)) = value;
    }
  }

  public unsafe G_FpsManager m_fpsManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsManager));
      return num == IntPtr.Zero ? (G_FpsManager) null : Il2CppObjectPool.Get<G_FpsManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_RamManager m_ramManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramManager));
      return num == IntPtr.Zero ? (G_RamManager) null : Il2CppObjectPool.Get<G_RamManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AudioManager m_audioManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioManager));
      return num == IntPtr.Zero ? (G_AudioManager) null : Il2CppObjectPool.Get<G_AudioManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AdvancedData m_advancedData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedData));
      return num == IntPtr.Zero ? (G_AdvancedData) null : Il2CppObjectPool.Get<G_AdvancedData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_FpsMonitor m_fpsMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsMonitor));
      return num == IntPtr.Zero ? (G_FpsMonitor) null : Il2CppObjectPool.Get<G_FpsMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_RamMonitor m_ramMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramMonitor));
      return num == IntPtr.Zero ? (G_RamMonitor) null : Il2CppObjectPool.Get<G_RamMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AudioMonitor m_audioMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioMonitor));
      return num == IntPtr.Zero ? (G_AudioMonitor) null : Il2CppObjectPool.Get<G_AudioMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager.ModulePreset m_modulePresetState
  {
    get
    {
      return *(GraphyManager.ModulePreset*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_modulePresetState));
    }
    [param: In] set
    {
      *(GraphyManager.ModulePreset*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_modulePresetState)) = value;
    }
  }

  public enum Mode
  {
    FULL,
    LIGHT,
  }

  public enum ModuleType
  {
    FPS,
    RAM,
    AUDIO,
    ADVANCED,
  }

  public enum ModuleState
  {
    FULL,
    TEXT,
    BASIC,
    BACKGROUND,
    OFF,
  }

  public enum ModulePosition
  {
    TOP_RIGHT,
    TOP_LEFT,
    BOTTOM_RIGHT,
    BOTTOM_LEFT,
    FREE,
  }

  public enum LookForAudioListener
  {
    ALWAYS,
    ON_SCENE_LOAD,
    NEVER,
  }

  public enum ModulePreset
  {
    FPS_BASIC,
    FPS_TEXT,
    FPS_FULL,
    FPS_TEXT_RAM_TEXT,
    FPS_FULL_RAM_TEXT,
    FPS_FULL_RAM_FULL,
    FPS_TEXT_RAM_TEXT_AUDIO_TEXT,
    FPS_FULL_RAM_TEXT_AUDIO_TEXT,
    FPS_FULL_RAM_FULL_AUDIO_TEXT,
    FPS_FULL_RAM_FULL_AUDIO_FULL,
    FPS_FULL_RAM_FULL_AUDIO_FULL_ADVANCED_FULL,
    FPS_BASIC_ADVANCED_FULL,
  }
}
