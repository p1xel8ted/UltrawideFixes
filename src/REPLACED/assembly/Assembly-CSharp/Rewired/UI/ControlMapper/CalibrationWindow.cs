// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.CalibrationWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired.Integration.UnityUI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class CalibrationWindow(System.IntPtr pointer) : Window(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_minSensitivityOtherAxes;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxDeadzone;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightContentContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_valueDisplayGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_calibratedValueMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr_rawValueMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr_calibratedZeroMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr_deadzoneArea;
  private static readonly System.IntPtr NativeFieldInfoPtr_deadzoneSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_zeroSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensitivitySlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_invertToggle;
  private static readonly System.IntPtr NativeFieldInfoPtr_axisScrollAreaContent;
  private static readonly System.IntPtr NativeFieldInfoPtr_doneButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_calibrateButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_doneButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_deadzoneSliderLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_zeroSliderLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensitivitySliderLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_invertToggleLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_calibrateButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_axisButtonPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_joystick;
  private static readonly System.IntPtr NativeFieldInfoPtr_origCalibrationData;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_origSelectedAxisCalibrationData;
  private static readonly System.IntPtr NativeFieldInfoPtr_displayAreaWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_axisButtons;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonCallbacks;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_rewiredStandaloneInputModule;
  private static readonly System.IntPtr NativeFieldInfoPtr_menuHorizActionId;
  private static readonly System.IntPtr NativeFieldInfoPtr_menuVertActionId;
  private static readonly System.IntPtr NativeFieldInfoPtr_minSensitivity;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_axisSelected_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_axisCalibration_Private_get_AxisCalibration_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetJoystick_Public_Void_Int32_Joystick_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDone_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCalibrate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnInvert_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnZeroValueChange_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnZeroCancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeadzoneValueChange_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeadzoneCancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSensitivityValueChange_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSensitivityCancel_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAxisScrollRectScroll_Public_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAxisSelected_Private_Void_Int32_Button_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDisplay_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Redraw_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshControls_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedrawDeadzone_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedrawCalibratedZero_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedrawValueMarkers_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SelectAxis_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMinSensitivity_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsMenuAxis_Private_Boolean_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisButtonDeadZone_Private_Void_Int32_Int32_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSliderSensitivity_Private_Single_AxisCalibration_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSensitivity_Public_Void_AxisCalibration_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessPowerValue_Private_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CalibrationWindow()
  {
    Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (CalibrationWindow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr);
    CalibrationWindow.NativeFieldInfoPtr_minSensitivityOtherAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (minSensitivityOtherAxes));
    CalibrationWindow.NativeFieldInfoPtr_maxDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (maxDeadzone));
    CalibrationWindow.NativeFieldInfoPtr_rightContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (rightContentContainer));
    CalibrationWindow.NativeFieldInfoPtr_valueDisplayGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (valueDisplayGroup));
    CalibrationWindow.NativeFieldInfoPtr_calibratedValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (calibratedValueMarker));
    CalibrationWindow.NativeFieldInfoPtr_rawValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (rawValueMarker));
    CalibrationWindow.NativeFieldInfoPtr_calibratedZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (calibratedZeroMarker));
    CalibrationWindow.NativeFieldInfoPtr_deadzoneArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (deadzoneArea));
    CalibrationWindow.NativeFieldInfoPtr_deadzoneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (deadzoneSlider));
    CalibrationWindow.NativeFieldInfoPtr_zeroSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (zeroSlider));
    CalibrationWindow.NativeFieldInfoPtr_sensitivitySlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (sensitivitySlider));
    CalibrationWindow.NativeFieldInfoPtr_invertToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (invertToggle));
    CalibrationWindow.NativeFieldInfoPtr_axisScrollAreaContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (axisScrollAreaContent));
    CalibrationWindow.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (doneButton));
    CalibrationWindow.NativeFieldInfoPtr_calibrateButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (calibrateButton));
    CalibrationWindow.NativeFieldInfoPtr_doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (doneButtonLabel));
    CalibrationWindow.NativeFieldInfoPtr_cancelButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (cancelButtonLabel));
    CalibrationWindow.NativeFieldInfoPtr_defaultButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (defaultButtonLabel));
    CalibrationWindow.NativeFieldInfoPtr_deadzoneSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (deadzoneSliderLabel));
    CalibrationWindow.NativeFieldInfoPtr_zeroSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (zeroSliderLabel));
    CalibrationWindow.NativeFieldInfoPtr_sensitivitySliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (sensitivitySliderLabel));
    CalibrationWindow.NativeFieldInfoPtr_invertToggleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (invertToggleLabel));
    CalibrationWindow.NativeFieldInfoPtr_calibrateButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (calibrateButtonLabel));
    CalibrationWindow.NativeFieldInfoPtr_axisButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (axisButtonPrefab));
    CalibrationWindow.NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (joystick));
    CalibrationWindow.NativeFieldInfoPtr_origCalibrationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (origCalibrationData));
    CalibrationWindow.NativeFieldInfoPtr_selectedAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (selectedAxis));
    CalibrationWindow.NativeFieldInfoPtr_origSelectedAxisCalibrationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (origSelectedAxisCalibrationData));
    CalibrationWindow.NativeFieldInfoPtr_displayAreaWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (displayAreaWidth));
    CalibrationWindow.NativeFieldInfoPtr_axisButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (axisButtons));
    CalibrationWindow.NativeFieldInfoPtr_buttonCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (buttonCallbacks));
    CalibrationWindow.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (playerId));
    CalibrationWindow.NativeFieldInfoPtr_rewiredStandaloneInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (rewiredStandaloneInputModule));
    CalibrationWindow.NativeFieldInfoPtr_menuHorizActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (menuHorizActionId));
    CalibrationWindow.NativeFieldInfoPtr_menuVertActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (menuVertActionId));
    CalibrationWindow.NativeFieldInfoPtr_minSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, nameof (minSensitivity));
    CalibrationWindow.NativeMethodInfoPtr_get_axisSelected_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668951);
    CalibrationWindow.NativeMethodInfoPtr_get_axisCalibration_Private_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668952);
    CalibrationWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668953);
    CalibrationWindow.NativeMethodInfoPtr_SetJoystick_Public_Void_Int32_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668954);
    CalibrationWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668955);
    CalibrationWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668956);
    CalibrationWindow.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668957);
    CalibrationWindow.NativeMethodInfoPtr_OnDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668958);
    CalibrationWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668959);
    CalibrationWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668960);
    CalibrationWindow.NativeMethodInfoPtr_OnCalibrate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668961);
    CalibrationWindow.NativeMethodInfoPtr_OnInvert_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668962);
    CalibrationWindow.NativeMethodInfoPtr_OnZeroValueChange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668963);
    CalibrationWindow.NativeMethodInfoPtr_OnZeroCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668964);
    CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneValueChange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668965);
    CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668966);
    CalibrationWindow.NativeMethodInfoPtr_OnSensitivityValueChange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668967);
    CalibrationWindow.NativeMethodInfoPtr_OnSensitivityCancel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668968);
    CalibrationWindow.NativeMethodInfoPtr_OnAxisScrollRectScroll_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668969);
    CalibrationWindow.NativeMethodInfoPtr_OnAxisSelected_Private_Void_Int32_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668970);
    CalibrationWindow.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668971);
    CalibrationWindow.NativeMethodInfoPtr_Redraw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668972);
    CalibrationWindow.NativeMethodInfoPtr_RefreshControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668973);
    CalibrationWindow.NativeMethodInfoPtr_RedrawDeadzone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668974);
    CalibrationWindow.NativeMethodInfoPtr_RedrawCalibratedZero_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668975);
    CalibrationWindow.NativeMethodInfoPtr_RedrawValueMarkers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668976);
    CalibrationWindow.NativeMethodInfoPtr_SelectAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668977);
    CalibrationWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668978);
    CalibrationWindow.NativeMethodInfoPtr_SetMinSensitivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668979);
    CalibrationWindow.NativeMethodInfoPtr_IsMenuAxis_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668980);
    CalibrationWindow.NativeMethodInfoPtr_GetAxisButtonDeadZone_Private_Void_Int32_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668981);
    CalibrationWindow.NativeMethodInfoPtr_GetSliderSensitivity_Private_Single_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668982);
    CalibrationWindow.NativeMethodInfoPtr_SetSensitivity_Public_Void_AxisCalibration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668983);
    CalibrationWindow.NativeMethodInfoPtr_ProcessPowerValue_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668984);
    CalibrationWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668985);
  }

  public unsafe bool axisSelected
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71878, XrefRangeEnd = 71880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_get_axisSelected_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AxisCalibration axisCalibration
  {
    [CallerCount(14), CachedScanResults(RefRangeStart = 71884, RefRangeEnd = 71898, XrefRangeStart = 71880, XrefRangeEnd = 71884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_get_axisCalibration_Private_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AxisCalibration) null : Il2CppObjectPool.Get<AxisCalibration>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71898, XrefRangeEnd = 71993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Initialize(int id, Il2CppSystem.Func<int, bool> isFocusedCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) isFocusedCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CalibrationWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 72087, RefRangeEnd = 72088, XrefRangeStart = 71993, XrefRangeEnd = 72087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetJoystick(int playerId, Joystick joystick)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystick);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetJoystick_Public_Void_Int32_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 72095, RefRangeEnd = 72098, XrefRangeStart = 72088, XrefRangeEnd = 72095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetButtonCallback(
    CalibrationWindow.ButtonIdentifier buttonIdentifier,
    Il2CppSystem.Action<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &buttonIdentifier;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72098, XrefRangeEnd = 72102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CalibrationWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72102, XrefRangeEnd = 72104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CalibrationWindow.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72104, XrefRangeEnd = 72107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnCancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72107, XrefRangeEnd = 72112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnRestoreDefault()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72112, XrefRangeEnd = 72115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCalibrate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnCalibrate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72115, XrefRangeEnd = 72118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnInvert(bool state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &state
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnInvert_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72118, XrefRangeEnd = 72122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnZeroValueChange(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnZeroValueChange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72122, XrefRangeEnd = 72127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnZeroCancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnZeroCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72127, XrefRangeEnd = 72133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDeadzoneValueChange(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneValueChange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72133, XrefRangeEnd = 72139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDeadzoneCancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72139, XrefRangeEnd = 72142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnSensitivityValueChange(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnSensitivityValueChange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72142, XrefRangeEnd = 72146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnSensitivityCancel(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnSensitivityCancel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnAxisScrollRectScroll(Vector2 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnAxisScrollRectScroll_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72146, XrefRangeEnd = 72150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnAxisSelected(int axisIndex, UnityEngine.UI.Button button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &axisIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) button);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnAxisSelected_Private_Void_Int32_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72150, XrefRangeEnd = 72151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateDisplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72151, XrefRangeEnd = 72153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Redraw()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_Redraw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 72164, RefRangeEnd = 72172, XrefRangeStart = 72153, XrefRangeEnd = 72164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshControls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RefreshControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 72182, RefRangeEnd = 72185, XrefRangeStart = 72172, XrefRangeEnd = 72182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawDeadzone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RedrawDeadzone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 72193, RefRangeEnd = 72201, XrefRangeStart = 72185, XrefRangeEnd = 72193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawCalibratedZero()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RedrawCalibratedZero_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 72215, RefRangeEnd = 72223, XrefRangeStart = 72201, XrefRangeEnd = 72215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawValueMarkers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RedrawValueMarkers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 72254, RefRangeEnd = 72258, XrefRangeStart = 72223, XrefRangeEnd = 72254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SelectAxis(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SelectAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72258, XrefRangeEnd = 72263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void TakeInputFocus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CalibrationWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72263, XrefRangeEnd = 72272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetMinSensitivity()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetMinSensitivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 72303, RefRangeEnd = 72307, XrefRangeStart = 72272, XrefRangeEnd = 72303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsMenuAxis(int actionId, int axisIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &actionId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axisIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_IsMenuAxis_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 72316, RefRangeEnd = 72318, XrefRangeStart = 72307, XrefRangeEnd = 72316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetAxisButtonDeadZone(int playerId, int actionId, ref float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_GetAxisButtonDeadZone_Private_Void_Int32_Int32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72318, XrefRangeEnd = 72319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetSliderSensitivity(AxisCalibration axisCalibration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) axisCalibration)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_GetSliderSensitivity_Private_Single_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void SetSensitivity(AxisCalibration axisCalibration, float sliderValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) axisCalibration);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sliderValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetSensitivity_Public_Void_AxisCalibration_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 72321, RefRangeEnd = 72323, XrefRangeStart = 72319, XrefRangeEnd = 72321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ProcessPowerValue(float value, float minValue, float maxValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_ProcessPowerValue_Private_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72323, XrefRangeEnd = 72324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CalibrationWindow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float minSensitivityOtherAxes
  {
    get
    {
      float sensitivityOtherAxes;
      IL2CPP.il2cpp_field_static_get_value(CalibrationWindow.NativeFieldInfoPtr_minSensitivityOtherAxes, (void*) &sensitivityOtherAxes);
      return sensitivityOtherAxes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CalibrationWindow.NativeFieldInfoPtr_minSensitivityOtherAxes, (void*) &value);
    }
  }

  public static unsafe float maxDeadzone
  {
    get
    {
      float maxDeadzone;
      IL2CPP.il2cpp_field_static_get_value(CalibrationWindow.NativeFieldInfoPtr_maxDeadzone, (void*) &maxDeadzone);
      return maxDeadzone;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CalibrationWindow.NativeFieldInfoPtr_maxDeadzone, (void*) &value);
    }
  }

  public unsafe RectTransform rightContentContainer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rightContentContainer));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rightContentContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform valueDisplayGroup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_valueDisplayGroup));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_valueDisplayGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform calibratedValueMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedValueMarker));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedValueMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rawValueMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rawValueMarker));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rawValueMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform calibratedZeroMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedZeroMarker));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedZeroMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform deadzoneArea
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneArea));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneArea), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider deadzoneSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider zeroSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider sensitivitySlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Toggle invertToggle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggle));
      return num == System.IntPtr.Zero ? (Toggle) null : Il2CppObjectPool.Get<Toggle>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform axisScrollAreaContent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisScrollAreaContent));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisScrollAreaContent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button doneButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button calibrateButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text doneButtonLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButtonLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButtonLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text cancelButtonLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_cancelButtonLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_cancelButtonLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text defaultButtonLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_defaultButtonLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_defaultButtonLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text deadzoneSliderLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSliderLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSliderLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text zeroSliderLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSliderLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSliderLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text sensitivitySliderLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySliderLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySliderLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text invertToggleLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggleLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggleLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text calibrateButtonLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButtonLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButtonLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject axisButtonPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtonPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Joystick joystick
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_joystick));
      return num == System.IntPtr.Zero ? (Joystick) null : Il2CppObjectPool.Get<Joystick>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_joystick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string origCalibrationData
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origCalibrationData)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origCalibrationData), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int selectedAxis
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_selectedAxis));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_selectedAxis)) = value;
    }
  }

  public AxisCalibrationData origSelectedAxisCalibrationData
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origSelectedAxisCalibrationData);
      return new AxisCalibrationData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origSelectedAxisCalibrationData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe float displayAreaWidth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_displayAreaWidth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_displayAreaWidth)) = value;
    }
  }

  public unsafe List<UnityEngine.UI.Button> axisButtons
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtons));
      return num == System.IntPtr.Zero ? (List<UnityEngine.UI.Button>) null : Il2CppObjectPool.Get<List<UnityEngine.UI.Button>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, Il2CppSystem.Action<int>> buttonCallbacks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_buttonCallbacks));
      return num == System.IntPtr.Zero ? (Dictionary<int, Il2CppSystem.Action<int>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppSystem.Action<int>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_buttonCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe RewiredStandaloneInputModule rewiredStandaloneInputModule
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rewiredStandaloneInputModule));
      return num == System.IntPtr.Zero ? (RewiredStandaloneInputModule) null : Il2CppObjectPool.Get<RewiredStandaloneInputModule>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rewiredStandaloneInputModule), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int menuHorizActionId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuHorizActionId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuHorizActionId)) = value;
    }
  }

  public unsafe int menuVertActionId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuVertActionId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuVertActionId)) = value;
    }
  }

  public unsafe float minSensitivity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_minSensitivity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_minSensitivity)) = value;
    }
  }

  public enum ButtonIdentifier
  {
    Done,
    Cancel,
    Default,
    Calibrate,
  }

  [ObfuscatedName("Rewired.UI.ControlMapper.CalibrationWindow+<>c__DisplayClass41_0")]
  public sealed class __c__DisplayClass41_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_index;
    private static readonly System.IntPtr NativeFieldInfoPtr_button;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetJoystick_b__0_Internal_Void_0;

    static __c__DisplayClass41_0()
    {
      Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "<>c__DisplayClass41_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr);
      CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, nameof (index));
      CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, nameof (button));
      CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
      CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, 100668986);
      CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__SetJoystick_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, 100668987);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass41_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71874, XrefRangeEnd = 71878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetJoystick_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__SetJoystick_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_index)) = value;
      }
    }

    public unsafe UnityEngine.UI.Button button
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_button));
        return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CalibrationWindow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CalibrationWindow) null : Il2CppObjectPool.Get<CalibrationWindow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
