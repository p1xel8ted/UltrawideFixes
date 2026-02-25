// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.LanguageDataBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace Rewired.UI.ControlMapper;

[Serializable]
public class LanguageDataBase(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_isLocalizationSystemEnabled_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCustomEntry_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Abstract_Virtual_New_Boolean_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_yes_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_no_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_add_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_replace_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_remove_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_swap_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_cancel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_none_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_okay_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_done_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_default__Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionColumnLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_mouseColumnLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_controllerColumnLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_doneButtonLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_playersGroupLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_settingsGroupLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Abstract_Virtual_New_String_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Abstract_Virtual_New_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPlayerName_Public_Abstract_Virtual_New_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetControllerName_Public_Abstract_Virtual_New_String_Controller_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_ActionElementMap_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_Controller_Int32_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_KeyCode_ModifierKeyFlags_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMapCategoryName_Public_Abstract_Virtual_New_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetActionCategoryName_Public_Abstract_Virtual_New_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetLayoutName_Public_Abstract_Virtual_New_String_ControllerType_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Abstract_Virtual_New_String_ModifierKeyFlags_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static LanguageDataBase()
  {
    Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (LanguageDataBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr);
    LanguageDataBase.NativeMethodInfoPtr_get_isLocalizationSystemEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669866);
    LanguageDataBase.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669867);
    LanguageDataBase.NativeMethodInfoPtr_GetCustomEntry_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669868);
    LanguageDataBase.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669869);
    LanguageDataBase.NativeMethodInfoPtr_get_yes_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669870);
    LanguageDataBase.NativeMethodInfoPtr_get_no_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669871);
    LanguageDataBase.NativeMethodInfoPtr_get_add_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669872);
    LanguageDataBase.NativeMethodInfoPtr_get_replace_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669873);
    LanguageDataBase.NativeMethodInfoPtr_get_remove_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669874);
    LanguageDataBase.NativeMethodInfoPtr_get_swap_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669875);
    LanguageDataBase.NativeMethodInfoPtr_get_cancel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669876);
    LanguageDataBase.NativeMethodInfoPtr_get_none_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669877);
    LanguageDataBase.NativeMethodInfoPtr_get_okay_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669878);
    LanguageDataBase.NativeMethodInfoPtr_get_done_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669879);
    LanguageDataBase.NativeMethodInfoPtr_get_default__Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669880);
    LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669881);
    LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669882);
    LanguageDataBase.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669883);
    LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669884);
    LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669885);
    LanguageDataBase.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669886);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669887);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669888);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669889);
    LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669890);
    LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669891);
    LanguageDataBase.NativeMethodInfoPtr_get_actionColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669892);
    LanguageDataBase.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669893);
    LanguageDataBase.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669894);
    LanguageDataBase.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669895);
    LanguageDataBase.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669896);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669897);
    LanguageDataBase.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669898);
    LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669899);
    LanguageDataBase.NativeMethodInfoPtr_get_doneButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669900);
    LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669901);
    LanguageDataBase.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669902);
    LanguageDataBase.NativeMethodInfoPtr_get_playersGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669903);
    LanguageDataBase.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669904);
    LanguageDataBase.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669905);
    LanguageDataBase.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669906);
    LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669907);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669908);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669909);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669910);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669911);
    LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669912);
    LanguageDataBase.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669913);
    LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669914);
    LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669915);
    LanguageDataBase.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669916);
    LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669917);
    LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669918);
    LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669919);
    LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Abstract_Virtual_New_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669920);
    LanguageDataBase.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669921);
    LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669922);
    LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669923);
    LanguageDataBase.NativeMethodInfoPtr_GetPlayerName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669924);
    LanguageDataBase.NativeMethodInfoPtr_GetControllerName_Public_Abstract_Virtual_New_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669925);
    LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669926);
    LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_Controller_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669927);
    LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_KeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669928);
    LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669929);
    LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669930);
    LanguageDataBase.NativeMethodInfoPtr_GetMapCategoryName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669931);
    LanguageDataBase.NativeMethodInfoPtr_GetActionCategoryName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669932);
    LanguageDataBase.NativeMethodInfoPtr_GetLayoutName_Public_Abstract_Virtual_New_String_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669933);
    LanguageDataBase.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Abstract_Virtual_New_String_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669934);
    LanguageDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669935);
  }

  public unsafe bool isLocalizationSystemEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79409, XrefRangeEnd = 79414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LanguageDataBase.NativeMethodInfoPtr_get_isLocalizationSystemEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe string GetCustomEntry(string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetCustomEntry_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool ContainsCustomEntryKey(string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe string yes
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_yes_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string no
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_no_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string add
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_add_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string replace
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_replace_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string remove
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_remove_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string swap
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_swap_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string cancel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_cancel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string none
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_none_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string okay
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_okay_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string done
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_done_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string default_
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_default__Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string assignControllerWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string assignControllerWindowMessage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string controllerAssignmentConflictWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string elementAssignmentPrePollingWindowMessage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string elementAssignmentConflictWindowMessage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string mouseAssignmentConflictWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateControllerWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateAxisStep1WindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateAxisStep2WindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string inputBehaviorSettingsWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string restoreDefaultsWindowTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string actionColumnLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_actionColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string keyboardColumnLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string mouseColumnLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string controllerColumnLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string removeControllerButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateControllerButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string assignControllerButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string inputBehaviorSettingsButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string doneButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_doneButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string restoreDefaultsButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string controllerSettingsGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string playersGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_playersGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string assignedControllersGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string settingsGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string mapCategoriesGroupLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string restoreDefaultsWindowMessage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateWindow_deadZoneSliderLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateWindow_zeroSliderLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateWindow_sensitivitySliderLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateWindow_invertToggleLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string calibrateWindow_calibrateButtonLabel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe string GetControllerAssignmentConflictWindowMessage(
    string joystickName,
    string otherPlayerName,
    string currentPlayerName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(joystickName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(currentPlayerName);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(
    string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetMouseElementAssignmentPollingWindowMessage(string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(
    string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetElementAlreadyInUseBlocked(string elementName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(elementName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetElementAlreadyInUseCanReplace(
    string elementName,
    bool allowConflicts)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(elementName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &allowConflicts;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Abstract_Virtual_New_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetMouseAssignmentConflictWindowMessage(
    string otherPlayerName,
    string thisPlayerName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(thisPlayerName);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetCalibrateAxisStep1WindowMessage(string axisName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(axisName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetCalibrateAxisStep2WindowMessage(string axisName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(axisName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetPlayerName(int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &playerId
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetPlayerName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetControllerName(Controller controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetControllerName_Public_Abstract_Virtual_New_String_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetElementIdentifierName(ActionElementMap actionElementMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMap)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetElementIdentifierName(
    Controller controller,
    int elementIdentifierId,
    AxisRange axisRange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &elementIdentifierId;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &axisRange;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_Controller_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetElementIdentifierName(
    KeyCode keyCode,
    ModifierKeyFlags modifierKeyFlags)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &keyCode;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &modifierKeyFlags;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_KeyCode_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetActionName(int actionId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &actionId
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetActionName(int actionId, AxisRange axisRange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &actionId;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &axisRange;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetMapCategoryName(int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &id
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetMapCategoryName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetActionCategoryName(int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &id
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetActionCategoryName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string GetLayoutName(ControllerType controllerType, int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &controllerType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &id;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_GetLayoutName_Public_Abstract_Virtual_New_String_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe string ModifierKeyFlagsToString(ModifierKeyFlags flags)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &flags
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LanguageDataBase.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Abstract_Virtual_New_String_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LanguageDataBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LanguageDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
