// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.LanguageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.UI.ControlMapper;

[Serializable]
public class LanguageData(System.IntPtr pointer) : LanguageDataBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__yes;
  private static readonly System.IntPtr NativeFieldInfoPtr__no;
  private static readonly System.IntPtr NativeFieldInfoPtr__add;
  private static readonly System.IntPtr NativeFieldInfoPtr__replace;
  private static readonly System.IntPtr NativeFieldInfoPtr__remove;
  private static readonly System.IntPtr NativeFieldInfoPtr__swap;
  private static readonly System.IntPtr NativeFieldInfoPtr__cancel;
  private static readonly System.IntPtr NativeFieldInfoPtr__none;
  private static readonly System.IntPtr NativeFieldInfoPtr__okay;
  private static readonly System.IntPtr NativeFieldInfoPtr__done;
  private static readonly System.IntPtr NativeFieldInfoPtr__default;
  private static readonly System.IntPtr NativeFieldInfoPtr__assignControllerWindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__assignControllerWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly;
  private static readonly System.IntPtr NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly;
  private static readonly System.IntPtr NativeFieldInfoPtr__elementAssignmentConflictWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__elementAlreadyInUseBlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr__elementAlreadyInUseCanReplace;
  private static readonly System.IntPtr NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed;
  private static readonly System.IntPtr NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateControllerWindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep1WindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep1WindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep2WindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep2WindowMessage;
  private static readonly System.IntPtr NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsWindowTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr__actionColumnLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__keyboardColumnLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__mouseColumnLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__controllerColumnLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__removeControllerButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateControllerButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__assignControllerButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__doneButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__playersGroupLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__controllerSettingsGroupLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__assignedControllersGroupLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__settingsGroupLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__mapCategoriesGroupLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_invertToggleLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr__modifierKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr__customEntries;
  private static readonly System.IntPtr NativeFieldInfoPtr__initialized;
  private static readonly System.IntPtr NativeFieldInfoPtr_customDict;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LanguageData()
  {
    Il2CppClassPointerStore<LanguageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (LanguageData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData>.NativeClassPtr);
    LanguageData.NativeFieldInfoPtr__yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_yes));
    LanguageData.NativeFieldInfoPtr__no = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_no));
    LanguageData.NativeFieldInfoPtr__add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_add));
    LanguageData.NativeFieldInfoPtr__replace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_replace));
    LanguageData.NativeFieldInfoPtr__remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_remove));
    LanguageData.NativeFieldInfoPtr__swap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_swap));
    LanguageData.NativeFieldInfoPtr__cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_cancel));
    LanguageData.NativeFieldInfoPtr__none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_none));
    LanguageData.NativeFieldInfoPtr__okay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_okay));
    LanguageData.NativeFieldInfoPtr__done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_done));
    LanguageData.NativeFieldInfoPtr__default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_default));
    LanguageData.NativeFieldInfoPtr__assignControllerWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_assignControllerWindowTitle));
    LanguageData.NativeFieldInfoPtr__assignControllerWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_assignControllerWindowMessage));
    LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_controllerAssignmentConflictWindowTitle));
    LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_controllerAssignmentConflictWindowMessage));
    LanguageData.NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_elementAssignmentPrePollingWindowMessage));
    LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_joystickElementAssignmentPollingWindowMessage));
    LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly));
    LanguageData.NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_keyboardElementAssignmentPollingWindowMessage));
    LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_mouseElementAssignmentPollingWindowMessage));
    LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly));
    LanguageData.NativeFieldInfoPtr__elementAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_elementAssignmentConflictWindowMessage));
    LanguageData.NativeFieldInfoPtr__elementAlreadyInUseBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_elementAlreadyInUseBlocked));
    LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_elementAlreadyInUseCanReplace));
    LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_elementAlreadyInUseCanReplace_conflictAllowed));
    LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_mouseAssignmentConflictWindowTitle));
    LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_mouseAssignmentConflictWindowMessage));
    LanguageData.NativeFieldInfoPtr__calibrateControllerWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateControllerWindowTitle));
    LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateAxisStep1WindowTitle));
    LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateAxisStep1WindowMessage));
    LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateAxisStep2WindowTitle));
    LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateAxisStep2WindowMessage));
    LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_inputBehaviorSettingsWindowTitle));
    LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_restoreDefaultsWindowTitle));
    LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_restoreDefaultsWindowMessage_onePlayer));
    LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_restoreDefaultsWindowMessage_multiPlayer));
    LanguageData.NativeFieldInfoPtr__actionColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_actionColumnLabel));
    LanguageData.NativeFieldInfoPtr__keyboardColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_keyboardColumnLabel));
    LanguageData.NativeFieldInfoPtr__mouseColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_mouseColumnLabel));
    LanguageData.NativeFieldInfoPtr__controllerColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_controllerColumnLabel));
    LanguageData.NativeFieldInfoPtr__removeControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_removeControllerButtonLabel));
    LanguageData.NativeFieldInfoPtr__calibrateControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateControllerButtonLabel));
    LanguageData.NativeFieldInfoPtr__assignControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_assignControllerButtonLabel));
    LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_inputBehaviorSettingsButtonLabel));
    LanguageData.NativeFieldInfoPtr__doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_doneButtonLabel));
    LanguageData.NativeFieldInfoPtr__restoreDefaultsButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_restoreDefaultsButtonLabel));
    LanguageData.NativeFieldInfoPtr__playersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_playersGroupLabel));
    LanguageData.NativeFieldInfoPtr__controllerSettingsGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_controllerSettingsGroupLabel));
    LanguageData.NativeFieldInfoPtr__assignedControllersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_assignedControllersGroupLabel));
    LanguageData.NativeFieldInfoPtr__settingsGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_settingsGroupLabel));
    LanguageData.NativeFieldInfoPtr__mapCategoriesGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_mapCategoriesGroupLabel));
    LanguageData.NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateWindow_deadZoneSliderLabel));
    LanguageData.NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateWindow_zeroSliderLabel));
    LanguageData.NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateWindow_sensitivitySliderLabel));
    LanguageData.NativeFieldInfoPtr__calibrateWindow_invertToggleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateWindow_invertToggleLabel));
    LanguageData.NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_calibrateWindow_calibrateButtonLabel));
    LanguageData.NativeFieldInfoPtr__modifierKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_modifierKeys));
    LanguageData.NativeFieldInfoPtr__customEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_customEntries));
    LanguageData.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (_initialized));
    LanguageData.NativeFieldInfoPtr_customDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (customDict));
    LanguageData.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669793);
    LanguageData.NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669794);
    LanguageData.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669795);
    LanguageData.NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669796);
    LanguageData.NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669797);
    LanguageData.NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669798);
    LanguageData.NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669799);
    LanguageData.NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669800);
    LanguageData.NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669801);
    LanguageData.NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669802);
    LanguageData.NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669803);
    LanguageData.NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669804);
    LanguageData.NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669805);
    LanguageData.NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669806);
    LanguageData.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669807);
    LanguageData.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669808);
    LanguageData.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669809);
    LanguageData.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669810);
    LanguageData.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669811);
    LanguageData.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669812);
    LanguageData.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669813);
    LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669814);
    LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669815);
    LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669816);
    LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669817);
    LanguageData.NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669818);
    LanguageData.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669819);
    LanguageData.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669820);
    LanguageData.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669821);
    LanguageData.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669822);
    LanguageData.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669823);
    LanguageData.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669824);
    LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669825);
    LanguageData.NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669826);
    LanguageData.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669827);
    LanguageData.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669828);
    LanguageData.NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669829);
    LanguageData.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669830);
    LanguageData.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669831);
    LanguageData.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669832);
    LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669833);
    LanguageData.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669834);
    LanguageData.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669835);
    LanguageData.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669836);
    LanguageData.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669837);
    LanguageData.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669838);
    LanguageData.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669839);
    LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669840);
    LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669841);
    LanguageData.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669842);
    LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669843);
    LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669844);
    LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669845);
    LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669846);
    LanguageData.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669847);
    LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669848);
    LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669849);
    LanguageData.NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669850);
    LanguageData.NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669851);
    LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669852);
    LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669853);
    LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669854);
    LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669855);
    LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669856);
    LanguageData.NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669857);
    LanguageData.NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669858);
    LanguageData.NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669859);
    LanguageData.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669860);
    LanguageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669861);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79185, XrefRangeEnd = 79186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79186, XrefRangeEnd = 79190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetCustomEntry(string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79190, XrefRangeEnd = 79194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool ContainsCustomEntryKey(string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public override unsafe string yes
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string no
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string add
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string replace
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string remove
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string swap
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string cancel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string none
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string okay
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string done
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string default_
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string assignControllerWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string assignControllerWindowMessage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string controllerAssignmentConflictWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string elementAssignmentPrePollingWindowMessage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string elementAssignmentConflictWindowMessage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string mouseAssignmentConflictWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateControllerWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateAxisStep1WindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateAxisStep2WindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string inputBehaviorSettingsWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string restoreDefaultsWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string actionColumnLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string keyboardColumnLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string mouseColumnLabel
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 79194, RefRangeEnd = 79195, XrefRangeStart = 79194, XrefRangeEnd = 79194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string controllerColumnLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string removeControllerButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateControllerButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string assignControllerButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string inputBehaviorSettingsButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string doneButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string restoreDefaultsButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string controllerSettingsGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string playersGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string assignedControllersGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string settingsGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string mapCategoriesGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string restoreDefaultsWindowMessage
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79195, XrefRangeEnd = 79200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateWindow_deadZoneSliderLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateWindow_zeroSliderLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateWindow_sensitivitySliderLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateWindow_invertToggleLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe string calibrateWindow_calibrateButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79200, XrefRangeEnd = 79201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetControllerAssignmentConflictWindowMessage(
    string joystickName,
    string otherPlayerName,
    string currentPlayerName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(joystickName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(currentPlayerName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79201, XrefRangeEnd = 79202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79202, XrefRangeEnd = 79203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(
    string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79203, XrefRangeEnd = 79204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79204, XrefRangeEnd = 79205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetMouseElementAssignmentPollingWindowMessage(string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79205, XrefRangeEnd = 79206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(
    string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79206, XrefRangeEnd = 79207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetElementAlreadyInUseBlocked(string elementName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(elementName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79207, XrefRangeEnd = 79209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetElementAlreadyInUseCanReplace(
    string elementName,
    bool allowConflicts)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(elementName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowConflicts;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79209, XrefRangeEnd = 79210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetMouseAssignmentConflictWindowMessage(
    string otherPlayerName,
    string thisPlayerName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(thisPlayerName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79210, XrefRangeEnd = 79211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetCalibrateAxisStep1WindowMessage(string axisName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(axisName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79211, XrefRangeEnd = 79212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetCalibrateAxisStep2WindowMessage(string axisName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(axisName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79212, XrefRangeEnd = 79218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetPlayerName(int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playerId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79218, XrefRangeEnd = 79225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetControllerName(Controller controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79225, XrefRangeEnd = 79232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetElementIdentifierName(ActionElementMap actionElementMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMap)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79232, XrefRangeEnd = 79234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetElementIdentifierName(
    Controller controller,
    int elementIdentifierId,
    AxisRange axisRange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &elementIdentifierId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &axisRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79234, XrefRangeEnd = 79241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetElementIdentifierName(
    KeyCode keyCode,
    ModifierKeyFlags modifierKeyFlags)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &keyCode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifierKeyFlags;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79241, XrefRangeEnd = 79247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetActionName(int actionId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &actionId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79247, XrefRangeEnd = 79262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetActionName(int actionId, AxisRange axisRange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &actionId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axisRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79262, XrefRangeEnd = 79268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetMapCategoryName(int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79268, XrefRangeEnd = 79274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetActionCategoryName(int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79274, XrefRangeEnd = 79280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetLayoutName(ControllerType controllerType, int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79280, XrefRangeEnd = 79300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ModifierKeyFlagsToString(ModifierKeyFlags flags)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &flags
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageData.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79300, XrefRangeEnd = 79409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LanguageData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _yes
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__yes)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__yes), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _no
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__no)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__no), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _add
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__add)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__add), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _replace
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__replace)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__replace), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _remove
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__remove)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__remove), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _swap
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__swap)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__swap), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _cancel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__cancel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__cancel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _none
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__none)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__none), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _okay
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__okay)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__okay), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _done
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__done)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__done), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _default
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__default)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__default), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _assignControllerWindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _assignControllerWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _controllerAssignmentConflictWindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _controllerAssignmentConflictWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _elementAssignmentPrePollingWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _joystickElementAssignmentPollingWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _keyboardElementAssignmentPollingWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _mouseElementAssignmentPollingWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _elementAssignmentConflictWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentConflictWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentConflictWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _elementAlreadyInUseBlocked
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseBlocked)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseBlocked), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _elementAlreadyInUseCanReplace
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _elementAlreadyInUseCanReplace_conflictAllowed
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _mouseAssignmentConflictWindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _mouseAssignmentConflictWindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateControllerWindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerWindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateAxisStep1WindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateAxisStep1WindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateAxisStep2WindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateAxisStep2WindowMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _inputBehaviorSettingsWindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _restoreDefaultsWindowTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _restoreDefaultsWindowMessage_onePlayer
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _restoreDefaultsWindowMessage_multiPlayer
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _actionColumnLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__actionColumnLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__actionColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _keyboardColumnLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardColumnLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _mouseColumnLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseColumnLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _controllerColumnLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerColumnLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _removeControllerButtonLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__removeControllerButtonLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__removeControllerButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateControllerButtonLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerButtonLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _assignControllerButtonLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerButtonLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _inputBehaviorSettingsButtonLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _doneButtonLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__doneButtonLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__doneButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _restoreDefaultsButtonLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsButtonLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _playersGroupLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__playersGroupLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__playersGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _controllerSettingsGroupLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerSettingsGroupLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerSettingsGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _assignedControllersGroupLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignedControllersGroupLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignedControllersGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _settingsGroupLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__settingsGroupLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__settingsGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _mapCategoriesGroupLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mapCategoriesGroupLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mapCategoriesGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateWindow_deadZoneSliderLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateWindow_zeroSliderLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateWindow_sensitivitySliderLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateWindow_invertToggleLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_invertToggleLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_invertToggleLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _calibrateWindow_calibrateButtonLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LanguageData.ModifierKeys _modifierKeys
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__modifierKeys));
      return num == System.IntPtr.Zero ? (LanguageData.ModifierKeys) null : Il2CppObjectPool.Get<LanguageData.ModifierKeys>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__modifierKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<LanguageData.CustomEntry> _customEntries
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__customEntries));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<LanguageData.CustomEntry>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageData.CustomEntry>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__customEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__initialized)) = value;
    }
  }

  public unsafe Dictionary<string, string> customDict
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_customDict));
      return num == System.IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_customDict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class CustomEntry(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_key;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0;

    static CustomEntry()
    {
      Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (CustomEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr);
      LanguageData.CustomEntry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, nameof (key));
      LanguageData.CustomEntry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, nameof (value));
      LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, 100669862);
      LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, 100669863);
      LanguageData.CustomEntry.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, 100669864);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(80 /*0x50*/)]
    [CachedScanResults(RefRangeStart = 79068, RefRangeEnd = 79148, XrefRangeStart = 79067, XrefRangeEnd = 79068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomEntry(string key, string value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 79173, RefRangeEnd = 79174, XrefRangeStart = 79148, XrefRangeEnd = 79173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Dictionary<string, string> ToDictionary(
      Il2CppReferenceArray<LanguageData.CustomEntry> array)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LanguageData.CustomEntry.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num3);
    }

    public unsafe string key
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_key)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string value
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_value)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [Serializable]
  public class ModifierKeys(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_control;
    private static readonly System.IntPtr NativeFieldInfoPtr_alt;
    private static readonly System.IntPtr NativeFieldInfoPtr_shift;
    private static readonly System.IntPtr NativeFieldInfoPtr_command;
    private static readonly System.IntPtr NativeFieldInfoPtr_separator;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ModifierKeys()
    {
      Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, nameof (ModifierKeys));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr);
      LanguageData.ModifierKeys.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, nameof (control));
      LanguageData.ModifierKeys.NativeFieldInfoPtr_alt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, nameof (alt));
      LanguageData.ModifierKeys.NativeFieldInfoPtr_shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, nameof (shift));
      LanguageData.ModifierKeys.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, nameof (command));
      LanguageData.ModifierKeys.NativeFieldInfoPtr_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, nameof (separator));
      LanguageData.ModifierKeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, 100669865);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79174, XrefRangeEnd = 79185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifierKeys()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LanguageData.ModifierKeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe string control
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_control)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_control), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string alt
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_alt)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_alt), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string shift
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_shift)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_shift), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string command
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_command)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_command), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string separator
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_separator)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_separator), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
