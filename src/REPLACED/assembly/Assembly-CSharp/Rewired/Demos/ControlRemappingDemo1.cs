// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.ControlRemappingDemo1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos;

public class ControlRemappingDemo1(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultModalWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultModalHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_assignmentTimeout;
  private static readonly System.IntPtr NativeFieldInfoPtr_dialog;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputMapper;
  private static readonly System.IntPtr NativeFieldInfoPtr_conflictFoundEventData;
  private static readonly System.IntPtr NativeFieldInfoPtr_guiState;
  private static readonly System.IntPtr NativeFieldInfoPtr_busy;
  private static readonly System.IntPtr NativeFieldInfoPtr_pageGUIState;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedMapCategoryId;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedController;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_showMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_startListening;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionScrollPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_calibrateScrollPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr_setupFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialized;
  private static readonly System.IntPtr NativeFieldInfoPtr_isCompiling;
  private static readonly System.IntPtr NativeFieldInfoPtr_style_wordWrap;
  private static readonly System.IntPtr NativeFieldInfoPtr_style_centeredBox;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleMenuControl_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Open_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawPage_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMapCategories_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowDialog_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessQueue_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearMapSelection_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetAll_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckRecompile_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ControlRemappingDemo1()
  {
    Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (ControlRemappingDemo1));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr);
    ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (defaultModalWidth));
    ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (defaultModalHeight));
    ControlRemappingDemo1.NativeFieldInfoPtr_assignmentTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (assignmentTimeout));
    ControlRemappingDemo1.NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (dialog));
    ControlRemappingDemo1.NativeFieldInfoPtr_inputMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (inputMapper));
    ControlRemappingDemo1.NativeFieldInfoPtr_conflictFoundEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (conflictFoundEventData));
    ControlRemappingDemo1.NativeFieldInfoPtr_guiState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (guiState));
    ControlRemappingDemo1.NativeFieldInfoPtr_busy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (busy));
    ControlRemappingDemo1.NativeFieldInfoPtr_pageGUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (pageGUIState));
    ControlRemappingDemo1.NativeFieldInfoPtr_selectedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (selectedPlayer));
    ControlRemappingDemo1.NativeFieldInfoPtr_selectedMapCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (selectedMapCategoryId));
    ControlRemappingDemo1.NativeFieldInfoPtr_selectedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (selectedController));
    ControlRemappingDemo1.NativeFieldInfoPtr_selectedMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (selectedMap));
    ControlRemappingDemo1.NativeFieldInfoPtr_showMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (showMenu));
    ControlRemappingDemo1.NativeFieldInfoPtr_startListening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (startListening));
    ControlRemappingDemo1.NativeFieldInfoPtr_actionScrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (actionScrollPos));
    ControlRemappingDemo1.NativeFieldInfoPtr_calibrateScrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (calibrateScrollPos));
    ControlRemappingDemo1.NativeFieldInfoPtr_actionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (actionQueue));
    ControlRemappingDemo1.NativeFieldInfoPtr_setupFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (setupFinished));
    ControlRemappingDemo1.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (initialized));
    ControlRemappingDemo1.NativeFieldInfoPtr_isCompiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (isCompiling));
    ControlRemappingDemo1.NativeFieldInfoPtr_style_wordWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (style_wordWrap));
    ControlRemappingDemo1.NativeFieldInfoPtr_style_centeredBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (style_centeredBox));
    ControlRemappingDemo1.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670148);
    ControlRemappingDemo1.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670149);
    ControlRemappingDemo1.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670150);
    ControlRemappingDemo1.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670151);
    ControlRemappingDemo1.NativeMethodInfoPtr_Setup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670152);
    ControlRemappingDemo1.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670153);
    ControlRemappingDemo1.NativeMethodInfoPtr_Unsubscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670154);
    ControlRemappingDemo1.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670155);
    ControlRemappingDemo1.NativeMethodInfoPtr_HandleMenuControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670156);
    ControlRemappingDemo1.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670157);
    ControlRemappingDemo1.NativeMethodInfoPtr_Open_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670158);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670159);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawPage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670160);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670161);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670162);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670163);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670164);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670165);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawMapCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670166);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670167);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670168);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670169);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670170);
    ControlRemappingDemo1.NativeMethodInfoPtr_ShowDialog_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670171);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670172);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670173);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670174);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670175);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670176);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670177);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670178);
    ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670179);
    ControlRemappingDemo1.NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670180);
    ControlRemappingDemo1.NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670181);
    ControlRemappingDemo1.NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670182);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670183);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670184);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670185);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670186);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670187);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670188);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670189);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670190);
    ControlRemappingDemo1.NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670191);
    ControlRemappingDemo1.NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670192);
    ControlRemappingDemo1.NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670193);
    ControlRemappingDemo1.NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670194);
    ControlRemappingDemo1.NativeMethodInfoPtr_ClearMapSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670195);
    ControlRemappingDemo1.NativeMethodInfoPtr_ResetAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670196);
    ControlRemappingDemo1.NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670197);
    ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670198);
    ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670199);
    ControlRemappingDemo1.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670200);
    ControlRemappingDemo1.NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670201);
    ControlRemappingDemo1.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670202);
    ControlRemappingDemo1.NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670203);
    ControlRemappingDemo1.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670204);
    ControlRemappingDemo1.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670205);
    ControlRemappingDemo1.NativeMethodInfoPtr_CheckRecompile_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670206);
    ControlRemappingDemo1.NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670207);
    ControlRemappingDemo1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100670208 /*0x06001B00*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81055, XrefRangeEnd = 81061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81061, XrefRangeEnd = 81077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81077, XrefRangeEnd = 81079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81122, RefRangeEnd = 81123, XrefRangeStart = 81079, XrefRangeEnd = 81122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81123, XrefRangeEnd = 81139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Setup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Subscribe()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unsubscribe()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Unsubscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81139, XrefRangeEnd = 81191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnGUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81191, XrefRangeEnd = 81202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HandleMenuControl()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_HandleMenuControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81202, XrefRangeEnd = 81203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Open()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Open_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81203, XrefRangeEnd = 81238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawInitialScreen()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81265, RefRangeEnd = 81266, XrefRangeStart = 81238, XrefRangeEnd = 81265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawPage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawPage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81322, RefRangeEnd = 81323, XrefRangeStart = 81266, XrefRangeEnd = 81322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawPlayerSelector()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81387, RefRangeEnd = 81388, XrefRangeStart = 81323, XrefRangeEnd = 81387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawMouseAssignment()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81468, RefRangeEnd = 81469, XrefRangeStart = 81388, XrefRangeEnd = 81468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawJoystickSelector()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81564, RefRangeEnd = 81565, XrefRangeStart = 81469, XrefRangeEnd = 81564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawControllerSelector()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81609, RefRangeEnd = 81610, XrefRangeStart = 81565, XrefRangeEnd = 81609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawCalibrateButton()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81684, RefRangeEnd = 81685, XrefRangeStart = 81610, XrefRangeEnd = 81684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawMapCategories()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawMapCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81863, RefRangeEnd = 81864, XrefRangeStart = 81685, XrefRangeEnd = 81863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawCategoryActions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 81893, RefRangeEnd = 81897, XrefRangeStart = 81864, XrefRangeEnd = 81893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawActionAssignmentButton(
    int playerId,
    InputAction action,
    AxisRange actionRange,
    ControlRemappingDemo1.ControllerSelection controller,
    ControllerMap controllerMap,
    ActionElementMap elementMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &actionRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controllerMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elementMap);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81907, RefRangeEnd = 81908, XrefRangeStart = 81897, XrefRangeEnd = 81907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawInvertButton(
    int playerId,
    InputAction action,
    Pole actionAxisContribution,
    ControlRemappingDemo1.ControllerSelection controller,
    ControllerMap controllerMap,
    ActionElementMap elementMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &actionAxisContribution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controllerMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elementMap);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 81936, RefRangeEnd = 81940, XrefRangeStart = 81908, XrefRangeEnd = 81936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawAddActionMapButton(
    int playerId,
    InputAction action,
    AxisRange actionRange,
    ControlRemappingDemo1.ControllerSelection controller,
    ControllerMap controllerMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &actionRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controllerMap);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81940, XrefRangeEnd = 81942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowDialog()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ShowDialog_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81942, XrefRangeEnd = 81957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawModalWindow(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81957, XrefRangeEnd = 81970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawModalWindow_OkayOnly(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81970, XrefRangeEnd = 81992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawElementAssignmentWindow(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81992, XrefRangeEnd = 82012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawElementAssignmentProtectedConflictWindow(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82012, XrefRangeEnd = 82036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawElementAssignmentNormalConflictWindow(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82036, XrefRangeEnd = 82053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82053, XrefRangeEnd = 82083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawFallbackJoystickIdentificationWindow(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82083, XrefRangeEnd = 82283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawCalibrationWindow(string title, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82283, XrefRangeEnd = 82306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DialogResultCallback(
    int queueActionId,
    ControlRemappingDemo1.UserResponse response)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &queueActionId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &response;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 82308, RefRangeEnd = 82311, XrefRangeStart = 82306, XrefRangeEnd = 82308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Rect GetScreenCenteredRect(float width, float height)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82318, RefRangeEnd = 82320, XrefRangeStart = 82311, XrefRangeEnd = 82318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnqueueAction(ControlRemappingDemo1.QueueEntry entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82343, RefRangeEnd = 82344, XrefRangeStart = 82320, XrefRangeEnd = 82343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessQueue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82378, RefRangeEnd = 82379, XrefRangeStart = 82344, XrefRangeEnd = 82378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessJoystickAssignmentChange(
    ControlRemappingDemo1.JoystickAssignmentChange entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82389, RefRangeEnd = 82390, XrefRangeStart = 82379, XrefRangeEnd = 82389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessElementAssignmentChange(
    ControlRemappingDemo1.ElementAssignmentChange entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82417, RefRangeEnd = 82418, XrefRangeStart = 82390, XrefRangeEnd = 82417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessRemoveOrReassignElementAssignment(
    ControlRemappingDemo1.ElementAssignmentChange entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82437, RefRangeEnd = 82438, XrefRangeStart = 82418, XrefRangeEnd = 82437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessRemoveElementAssignment(
    ControlRemappingDemo1.ElementAssignmentChange entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82489, RefRangeEnd = 82490, XrefRangeStart = 82438, XrefRangeEnd = 82489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessAddOrReplaceElementAssignment(
    ControlRemappingDemo1.ElementAssignmentChange entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82522, RefRangeEnd = 82523, XrefRangeStart = 82490, XrefRangeEnd = 82522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessElementAssignmentConflictCheck(
    ControlRemappingDemo1.ElementAssignmentChange entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82542, RefRangeEnd = 82543, XrefRangeStart = 82523, XrefRangeEnd = 82542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessFallbackJoystickIdentification(
    ControlRemappingDemo1.FallbackJoystickIdentification entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82566, RefRangeEnd = 82567, XrefRangeStart = 82543, XrefRangeEnd = 82566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessCalibration(ControlRemappingDemo1.Calibration entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82567, XrefRangeEnd = 82568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayerSelectionChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ControllerSelectionChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearControllerSelection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ClearMapSelection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ClearMapSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82568, XrefRangeEnd = 82569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ResetAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 82576, RefRangeEnd = 82582, XrefRangeStart = 82569, XrefRangeEnd = 82576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearWorkingVars()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82582, XrefRangeEnd = 82590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGUIStateStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82590, XrefRangeEnd = 82597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGUIStateEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82597, XrefRangeEnd = 82640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickConnected(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82640, XrefRangeEnd = 82681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82681, XrefRangeEnd = 82687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickDisconnected(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnConflictFound(InputMapper.ConflictFoundEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnStopped(InputMapper.StoppedEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 82722, RefRangeEnd = 82725, XrefRangeStart = 82687, XrefRangeEnd = 82722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void IdentifyAllJoysticks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckRecompile()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_CheckRecompile_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RecompileWindow(int windowId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &windowId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82725, XrefRangeEnd = 82730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControlRemappingDemo1()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float defaultModalWidth
  {
    get
    {
      float defaultModalWidth;
      IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalWidth, (void*) &defaultModalWidth);
      return defaultModalWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalWidth, (void*) &value);
    }
  }

  public static unsafe float defaultModalHeight
  {
    get
    {
      float defaultModalHeight;
      IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalHeight, (void*) &defaultModalHeight);
      return defaultModalHeight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalHeight, (void*) &value);
    }
  }

  public static unsafe float assignmentTimeout
  {
    get
    {
      float assignmentTimeout;
      IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.NativeFieldInfoPtr_assignmentTimeout, (void*) &assignmentTimeout);
      return assignmentTimeout;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.NativeFieldInfoPtr_assignmentTimeout, (void*) &value);
    }
  }

  public unsafe ControlRemappingDemo1.DialogHelper dialog
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_dialog));
      return num == System.IntPtr.Zero ? (ControlRemappingDemo1.DialogHelper) null : Il2CppObjectPool.Get<ControlRemappingDemo1.DialogHelper>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_dialog), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputMapper inputMapper
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_inputMapper));
      return num == System.IntPtr.Zero ? (InputMapper) null : Il2CppObjectPool.Get<InputMapper>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_inputMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputMapper.ConflictFoundEventData conflictFoundEventData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_conflictFoundEventData));
      return num == System.IntPtr.Zero ? (InputMapper.ConflictFoundEventData) null : Il2CppObjectPool.Get<InputMapper.ConflictFoundEventData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_conflictFoundEventData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool guiState
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_guiState));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_guiState)) = value;
    }
  }

  public unsafe bool busy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_busy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_busy)) = value;
    }
  }

  public unsafe bool pageGUIState
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_pageGUIState));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_pageGUIState)) = value;
    }
  }

  public unsafe Player selectedPlayer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedPlayer));
      return num == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int selectedMapCategoryId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMapCategoryId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMapCategoryId)) = value;
    }
  }

  public unsafe ControlRemappingDemo1.ControllerSelection selectedController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedController));
      return num == System.IntPtr.Zero ? (ControlRemappingDemo1.ControllerSelection) null : Il2CppObjectPool.Get<ControlRemappingDemo1.ControllerSelection>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerMap selectedMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMap));
      return num == System.IntPtr.Zero ? (ControllerMap) null : Il2CppObjectPool.Get<ControllerMap>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool showMenu
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_showMenu));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_showMenu)) = value;
    }
  }

  public unsafe bool startListening
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_startListening));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_startListening)) = value;
    }
  }

  public unsafe Vector2 actionScrollPos
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionScrollPos));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionScrollPos)) = value;
    }
  }

  public unsafe Vector2 calibrateScrollPos
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_calibrateScrollPos));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_calibrateScrollPos)) = value;
    }
  }

  public unsafe Queue<ControlRemappingDemo1.QueueEntry> actionQueue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionQueue));
      return num == System.IntPtr.Zero ? (Queue<ControlRemappingDemo1.QueueEntry>) null : Il2CppObjectPool.Get<Queue<ControlRemappingDemo1.QueueEntry>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionQueue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool setupFinished
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_setupFinished));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_setupFinished)) = value;
    }
  }

  public unsafe bool initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_initialized)) = value;
    }
  }

  public unsafe bool isCompiling
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_isCompiling));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_isCompiling)) = value;
    }
  }

  public unsafe GUIStyle style_wordWrap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_wordWrap));
      return num == System.IntPtr.Zero ? (GUIStyle) null : Il2CppObjectPool.Get<GUIStyle>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_wordWrap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GUIStyle style_centeredBox
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_centeredBox));
      return num == System.IntPtr.Zero ? (GUIStyle) null : Il2CppObjectPool.Get<GUIStyle>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_centeredBox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class ControllerSelection(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__id;
    private static readonly System.IntPtr NativeFieldInfoPtr__idPrev;
    private static readonly System.IntPtr NativeFieldInfoPtr__type;
    private static readonly System.IntPtr NativeFieldInfoPtr__typePrev;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

    static ControllerSelection()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (ControllerSelection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr);
      ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, nameof (_id));
      ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__idPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, nameof (_idPrev));
      ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, nameof (_type));
      ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__typePrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, nameof (_typePrev));
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670209);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670210);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670211);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670212);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670213);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670214);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670215);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670216);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670217);
      ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100670218);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 80812, RefRangeEnd = 80813, XrefRangeStart = 80811, XrefRangeEnd = 80812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ControllerSelection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int id
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe ControllerType type
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControllerType*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe int idPrev
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe ControllerType typePrev
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControllerType*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool hasSelection
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 80813, RefRangeEnd = 80817, XrefRangeStart = 80813, XrefRangeEnd = 80813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 80817, RefRangeEnd = 80821, XrefRangeStart = 80817, XrefRangeEnd = 80817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(int id, ControllerType type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 80821, RefRangeEnd = 80826, XrefRangeStart = 80821, XrefRangeEnd = 80821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int _id
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__id));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__id)) = value;
      }
    }

    public unsafe int _idPrev
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__idPrev));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__idPrev)) = value;
      }
    }

    public unsafe ControllerType _type
    {
      get
      {
        return *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__type));
      }
      [param: In] set
      {
        *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__type)) = value;
      }
    }

    public unsafe ControllerType _typePrev
    {
      get
      {
        return *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__typePrev));
      }
      [param: In] set
      {
        *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__typePrev)) = value;
      }
    }
  }

  public class DialogHelper(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_openBusyDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_closeBusyDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr__type;
    private static readonly System.IntPtr NativeFieldInfoPtr__enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__busyTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__busyTimerRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_drawWindowDelegate;
    private static readonly System.IntPtr NativeFieldInfoPtr_drawWindowFunction;
    private static readonly System.IntPtr NativeFieldInfoPtr_windowProperties;
    private static readonly System.IntPtr NativeFieldInfoPtr_currentActionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_resultCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_DialogType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_busy_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCancelButton_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimers_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StateChanged_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetTimers_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FullReset_Public_Void_0;

    static DialogHelper()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (DialogHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr);
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_openBusyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (openBusyDelay));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_closeBusyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (closeBusyDelay));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (_type));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (_enabled));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (_busyTime));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTimerRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (_busyTimerRunning));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (drawWindowDelegate));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (drawWindowFunction));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_windowProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (windowProperties));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_currentActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (currentActionId));
      ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_resultCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, nameof (resultCallback));
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670219);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670220);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670221);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_type_Public_get_DialogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670222);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670223);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670224);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670225);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670226);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670227);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670228);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Draw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670229);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670230);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670231);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670232);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670233);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670234);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670235);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670236);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670237);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670238);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670239);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_UpdateTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670240);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670241);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670242);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StateChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670243);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670244);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_ResetTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670245);
      ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_FullReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100670246);
    }

    public unsafe float busyTimer
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80826, XrefRangeEnd = 80827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool enabled
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80827, XrefRangeEnd = 80828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe ControlRemappingDemo1.DialogHelper.DialogType type
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_type_Public_get_DialogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControlRemappingDemo1.DialogHelper.DialogType*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80828, XrefRangeEnd = 80831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe bool busy
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 80844, RefRangeEnd = 80845, XrefRangeStart = 80831, XrefRangeEnd = 80844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DialogHelper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 80848, RefRangeEnd = 80854, XrefRangeStart = 80845, XrefRangeEnd = 80848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartModal(
      int queueActionId,
      ControlRemappingDemo1.DialogHelper.DialogType type,
      ControlRemappingDemo1.WindowProperties windowProperties,
      Il2CppSystem.Action<int, ControlRemappingDemo1.UserResponse> resultCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &queueActionId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) windowProperties));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultCallback);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 80858, RefRangeEnd = 80859, XrefRangeStart = 80854, XrefRangeEnd = 80858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartModal(
      int queueActionId,
      ControlRemappingDemo1.DialogHelper.DialogType type,
      ControlRemappingDemo1.WindowProperties windowProperties,
      Il2CppSystem.Action<int, ControlRemappingDemo1.UserResponse> resultCallback,
      float openBusyDelay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &queueActionId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) windowProperties));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultCallback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &openBusyDelay;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 80874, RefRangeEnd = 80876, XrefRangeStart = 80859, XrefRangeEnd = 80874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80876, XrefRangeEnd = 80890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Draw()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Draw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80890, XrefRangeEnd = 80910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawConfirmButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 80928, RefRangeEnd = 80931, XrefRangeStart = 80910, XrefRangeEnd = 80928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawConfirmButton(string title)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(title)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80931, XrefRangeEnd = 80951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawConfirmButton(ControlRemappingDemo1.UserResponse response)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &response
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 80969, RefRangeEnd = 80972, XrefRangeStart = 80951, XrefRangeEnd = 80969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawConfirmButton(ControlRemappingDemo1.UserResponse response, string title)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &response;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 80992, RefRangeEnd = 80995, XrefRangeStart = 80972, XrefRangeEnd = 80992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawCancelButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 81013, RefRangeEnd = 81014, XrefRangeStart = 80995, XrefRangeEnd = 81013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawCancelButton(string title)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(title)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 81015, RefRangeEnd = 81017, XrefRangeStart = 81014, XrefRangeEnd = 81015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Confirm()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81017, XrefRangeEnd = 81018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Confirm(ControlRemappingDemo1.UserResponse response)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &response
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81018, XrefRangeEnd = 81019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Cancel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81019, XrefRangeEnd = 81020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawWindow(int windowId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &windowId
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81020, XrefRangeEnd = 81021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTimers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_UpdateTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81021, XrefRangeEnd = 81022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartBusyTimer(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &time
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81022, XrefRangeEnd = 81023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Close()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StateChanged(float delay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delay
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StateChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void ResetTimers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_ResetTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 81023, RefRangeEnd = 81024, XrefRangeStart = 81023, XrefRangeEnd = 81023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FullReset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_FullReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe float openBusyDelay
    {
      get
      {
        float openBusyDelay;
        IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_openBusyDelay, (void*) &openBusyDelay);
        return openBusyDelay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_openBusyDelay, (void*) &value);
      }
    }

    public static unsafe float closeBusyDelay
    {
      get
      {
        float closeBusyDelay;
        IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_closeBusyDelay, (void*) &closeBusyDelay);
        return closeBusyDelay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_closeBusyDelay, (void*) &value);
      }
    }

    public unsafe ControlRemappingDemo1.DialogHelper.DialogType _type
    {
      get
      {
        return *(ControlRemappingDemo1.DialogHelper.DialogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__type));
      }
      [param: In] set
      {
        *(ControlRemappingDemo1.DialogHelper.DialogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__type)) = value;
      }
    }

    public unsafe bool _enabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__enabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__enabled)) = value;
      }
    }

    public unsafe float _busyTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTime)) = value;
      }
    }

    public unsafe bool _busyTimerRunning
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTimerRunning));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTimerRunning)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<int> drawWindowDelegate
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowDelegate));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowDelegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GUI.WindowFunction drawWindowFunction
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowFunction));
        return num == System.IntPtr.Zero ? (GUI.WindowFunction) null : Il2CppObjectPool.Get<GUI.WindowFunction>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowFunction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ControlRemappingDemo1.WindowProperties windowProperties
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_windowProperties);
        return new ControlRemappingDemo1.WindowProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_windowProperties), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int currentActionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_currentActionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_currentActionId)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<int, ControlRemappingDemo1.UserResponse> resultCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_resultCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int, ControlRemappingDemo1.UserResponse>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int, ControlRemappingDemo1.UserResponse>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_resultCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum DialogType
    {
      None = 0,
      JoystickConflict = 1,
      ElementConflict = 2,
      KeyConflict = 3,
      DeleteAssignmentConfirmation = 10, // 0x0000000A
      AssignElement = 11, // 0x0000000B
    }
  }

  public class QueueEntry(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__queueActionType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__state_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__response_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_uidCounter;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_State_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Protected_set_Void_State_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_response_Public_get_UserResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

    static QueueEntry()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (QueueEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr);
      ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<id>k__BackingField");
      ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__queueActionType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<queueActionType>k__BackingField");
      ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__state_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<state>k__BackingField");
      ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__response_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<response>k__BackingField");
      ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr_uidCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, nameof (uidCounter));
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670247);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670248);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670249);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670250);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_state_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670251);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_state_Protected_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670252);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_response_Public_get_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670253);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670254);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670255);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670256);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670257);
      ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100670258);
    }

    public unsafe int id
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe ControlRemappingDemo1.QueueActionType queueActionType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControlRemappingDemo1.QueueActionType*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe ControlRemappingDemo1.QueueEntry.State state
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_state_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControlRemappingDemo1.QueueEntry.State*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_state_Protected_set_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe ControlRemappingDemo1.UserResponse response
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_response_Public_get_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControlRemappingDemo1.UserResponse*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public static unsafe int nextId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81024, XrefRangeEnd = 81026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81026, XrefRangeEnd = 81029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe QueueEntry(
      ControlRemappingDemo1.QueueActionType queueActionType)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &queueActionType
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 81029, RefRangeEnd = 81030, XrefRangeStart = 81029, XrefRangeEnd = 81029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Confirm(ControlRemappingDemo1.UserResponse response)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &response
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 81030, RefRangeEnd = 81031, XrefRangeStart = 81030, XrefRangeEnd = 81030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Cancel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int _id_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__id_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__id_k__BackingField)) = value;
      }
    }

    public unsafe ControlRemappingDemo1.QueueActionType _queueActionType_k__BackingField
    {
      get
      {
        return *(ControlRemappingDemo1.QueueActionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__queueActionType_k__BackingField));
      }
      [param: In] set
      {
        *(ControlRemappingDemo1.QueueActionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__queueActionType_k__BackingField)) = value;
      }
    }

    public unsafe ControlRemappingDemo1.QueueEntry.State _state_k__BackingField
    {
      get
      {
        return *(ControlRemappingDemo1.QueueEntry.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__state_k__BackingField));
      }
      [param: In] set
      {
        *(ControlRemappingDemo1.QueueEntry.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__state_k__BackingField)) = value;
      }
    }

    public unsafe ControlRemappingDemo1.UserResponse _response_k__BackingField
    {
      get
      {
        return *(ControlRemappingDemo1.UserResponse*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__response_k__BackingField));
      }
      [param: In] set
      {
        *(ControlRemappingDemo1.UserResponse*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__response_k__BackingField)) = value;
      }
    }

    public static unsafe int uidCounter
    {
      get
      {
        int uidCounter;
        IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr_uidCounter, (void*) &uidCounter);
        return uidCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr_uidCounter, (void*) &value);
      }
    }

    public enum State
    {
      Waiting,
      Confirmed,
      Canceled,
    }
  }

  public class JoystickAssignmentChange(System.IntPtr pointer) : ControlRemappingDemo1.QueueEntry(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__playerId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__joystickId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__assign_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_assign_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;

    static JoystickAssignmentChange()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (JoystickAssignmentChange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr);
      ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, "<playerId>k__BackingField");
      ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__joystickId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, "<joystickId>k__BackingField");
      ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__assign_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, "<assign>k__BackingField");
      ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100670259);
      ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100670260);
      ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100670261);
      ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100670262);
      ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_assign_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100670263);
      ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100670264);
      ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100670265);
    }

    public unsafe int playerId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe int joystickId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe bool assign
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_assign_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 81035, RefRangeEnd = 81036, XrefRangeStart = 81032, XrefRangeEnd = 81035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &newPlayerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &joystickId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &assign;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int _playerId_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__playerId_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__playerId_k__BackingField)) = value;
      }
    }

    public unsafe int _joystickId_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__joystickId_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__joystickId_k__BackingField)) = value;
      }
    }

    public unsafe bool _assign_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__assign_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__assign_k__BackingField)) = value;
      }
    }
  }

  public class ElementAssignmentChange(System.IntPtr pointer) : ControlRemappingDemo1.QueueEntry(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__changeType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__context_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_context_Public_get_Context_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_context_Private_set_Void_Context_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0;

    static ElementAssignmentChange()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (ElementAssignmentChange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr);
      ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__changeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, "<changeType>k__BackingField");
      ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, "<context>k__BackingField");
      ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100670266);
      ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100670267);
      ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100670268);
      ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_context_Private_set_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100670269);
      ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100670270);
      ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100670271);
    }

    public unsafe ControlRemappingDemo1.ElementAssignmentChangeType changeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControlRemappingDemo1.ElementAssignmentChangeType*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe InputMapper.Context context
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (InputMapper.Context) null : Il2CppObjectPool.Get<InputMapper.Context>(num3);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_context_Private_set_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 81039, RefRangeEnd = 81041, XrefRangeStart = 81036, XrefRangeEnd = 81039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ElementAssignmentChange(
      ControlRemappingDemo1.ElementAssignmentChangeType changeType,
      InputMapper.Context context)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &changeType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 81045, RefRangeEnd = 81047, XrefRangeStart = 81041, XrefRangeEnd = 81045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ElementAssignmentChange(
      ControlRemappingDemo1.ElementAssignmentChange other)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ControlRemappingDemo1.ElementAssignmentChangeType _changeType_k__BackingField
    {
      get
      {
        return *(ControlRemappingDemo1.ElementAssignmentChangeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__changeType_k__BackingField));
      }
      [param: In] set
      {
        *(ControlRemappingDemo1.ElementAssignmentChangeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__changeType_k__BackingField)) = value;
      }
    }

    public unsafe InputMapper.Context _context_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__context_k__BackingField));
        return num == System.IntPtr.Zero ? (InputMapper.Context) null : Il2CppObjectPool.Get<InputMapper.Context>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__context_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class FallbackJoystickIdentification(System.IntPtr pointer) : 
    ControlRemappingDemo1.QueueEntry(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__joystickId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__joystickName_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickName_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

    static FallbackJoystickIdentification()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (FallbackJoystickIdentification));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr);
      ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, "<joystickId>k__BackingField");
      ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, "<joystickName>k__BackingField");
      ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100670272);
      ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100670273);
      ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100670274);
      ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100670275);
      ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100670276);
    }

    public unsafe int joystickId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe string joystickName
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 81050, RefRangeEnd = 81051, XrefRangeStart = 81047, XrefRangeEnd = 81050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FallbackJoystickIdentification(int joystickId, string joystickName)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &joystickId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(joystickName);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int _joystickId_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickId_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickId_k__BackingField)) = value;
      }
    }

    public unsafe string _joystickName_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickName_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  public class Calibration(System.IntPtr pointer) : ControlRemappingDemo1.QueueEntry(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__player_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__controllerType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__joystick_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__calibrationMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_selectedElementIdentifierId;
    private static readonly System.IntPtr NativeFieldInfoPtr_recording;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_player_Private_set_Void_Player_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0;

    static Calibration()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (Calibration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr);
      ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<player>k__BackingField");
      ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__controllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<controllerType>k__BackingField");
      ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__joystick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<joystick>k__BackingField");
      ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__calibrationMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<calibrationMap>k__BackingField");
      ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_selectedElementIdentifierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, nameof (selectedElementIdentifierId));
      ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_recording = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, nameof (recording));
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670277);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670278);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670279);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670280);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670281);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670282);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670283);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670284);
      ControlRemappingDemo1.Calibration.NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100670285);
    }

    public unsafe Player player
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe ControllerType controllerType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ControllerType*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Joystick joystick
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Joystick) null : Il2CppObjectPool.Get<Joystick>(num3);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe CalibrationMap calibrationMap
    {
      [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (CalibrationMap) null : Il2CppObjectPool.Get<CalibrationMap>(num3);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 81054, RefRangeEnd = 81055, XrefRangeStart = 81051, XrefRangeEnd = 81054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystick);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) calibrationMap);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Player _player_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__player_k__BackingField));
        return num == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ControllerType _controllerType_k__BackingField
    {
      get
      {
        return *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__controllerType_k__BackingField));
      }
      [param: In] set
      {
        *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__controllerType_k__BackingField)) = value;
      }
    }

    public unsafe Joystick _joystick_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__joystick_k__BackingField));
        return num == System.IntPtr.Zero ? (Joystick) null : Il2CppObjectPool.Get<Joystick>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__joystick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CalibrationMap _calibrationMap_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__calibrationMap_k__BackingField));
        return num == System.IntPtr.Zero ? (CalibrationMap) null : Il2CppObjectPool.Get<CalibrationMap>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__calibrationMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int selectedElementIdentifierId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_selectedElementIdentifierId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_selectedElementIdentifierId)) = value;
      }
    }

    public unsafe bool recording
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_recording));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_recording)) = value;
      }
    }
  }

  public sealed class WindowProperties : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_windowId;
    private static readonly System.IntPtr NativeFieldInfoPtr_rect;
    private static readonly System.IntPtr NativeFieldInfoPtr_windowDrawDelegate;
    private static readonly System.IntPtr NativeFieldInfoPtr_title;
    private static readonly System.IntPtr NativeFieldInfoPtr_message;

    static WindowProperties()
    {
      Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, nameof (WindowProperties));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr);
      ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, nameof (windowId));
      ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, nameof (rect));
      ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowDrawDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, nameof (windowDrawDelegate));
      ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, nameof (title));
      ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, nameof (message));
    }

    public WindowProperties(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public WindowProperties()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr))
    {
    }

    public unsafe int windowId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowId)) = value;
      }
    }

    public unsafe Rect rect
    {
      get
      {
        return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_rect));
      }
      [param: In] set
      {
        *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_rect)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<string, string> windowDrawDelegate
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowDrawDelegate));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<string, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowDrawDelegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string title
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_title)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string message
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_message)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  public enum QueueActionType
  {
    None,
    JoystickAssignment,
    ElementAssignment,
    FallbackJoystickIdentification,
    Calibrate,
  }

  public enum ElementAssignmentChangeType
  {
    Add,
    Replace,
    Remove,
    ReassignOrRemove,
    ConflictCheck,
  }

  public enum UserResponse
  {
    Confirm,
    Cancel,
    Custom1,
    Custom2,
  }
}
