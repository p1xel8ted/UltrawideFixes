// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.InputBehaviorWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class InputBehaviorWindow(System.IntPtr pointer) : Window(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_minSensitivity;
  private static readonly System.IntPtr NativeFieldInfoPtr_spawnTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_doneButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_doneButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultButtonLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_uiControlSetPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_uiSliderControlPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputBehaviorInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonCallbacks;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerId;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDone_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputBehaviorWindow()
  {
    Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (InputBehaviorWindow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr);
    InputBehaviorWindow.NativeFieldInfoPtr_minSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (minSensitivity));
    InputBehaviorWindow.NativeFieldInfoPtr_spawnTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (spawnTransform));
    InputBehaviorWindow.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (doneButton));
    InputBehaviorWindow.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (cancelButton));
    InputBehaviorWindow.NativeFieldInfoPtr_defaultButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (defaultButton));
    InputBehaviorWindow.NativeFieldInfoPtr_doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (doneButtonLabel));
    InputBehaviorWindow.NativeFieldInfoPtr_cancelButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (cancelButtonLabel));
    InputBehaviorWindow.NativeFieldInfoPtr_defaultButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (defaultButtonLabel));
    InputBehaviorWindow.NativeFieldInfoPtr_uiControlSetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (uiControlSetPrefab));
    InputBehaviorWindow.NativeFieldInfoPtr_uiSliderControlPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (uiSliderControlPrefab));
    InputBehaviorWindow.NativeFieldInfoPtr_inputBehaviorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (inputBehaviorInfo));
    InputBehaviorWindow.NativeFieldInfoPtr_buttonCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (buttonCallbacks));
    InputBehaviorWindow.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (playerId));
    InputBehaviorWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669748);
    InputBehaviorWindow.NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669749);
    InputBehaviorWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669750);
    InputBehaviorWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669751);
    InputBehaviorWindow.NativeMethodInfoPtr_OnDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669752);
    InputBehaviorWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669753);
    InputBehaviorWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669754);
    InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669755);
    InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669756);
    InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669757);
    InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669758);
    InputBehaviorWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669759);
    InputBehaviorWindow.NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669760);
    InputBehaviorWindow.NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669761);
    InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669762);
    InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669763);
    InputBehaviorWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669764);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78778, XrefRangeEnd = 78847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Initialize(int id, Il2CppSystem.Func<int, bool> isFocusedCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) isFocusedCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputBehaviorWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78898, RefRangeEnd = 78899, XrefRangeStart = 78847, XrefRangeEnd = 78898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData(
    int playerId,
    Il2CppReferenceArray<Rewired.UI.ControlMapper.ControlMapper.InputBehaviorSettings> data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 78906, RefRangeEnd = 78908, XrefRangeStart = 78899, XrefRangeEnd = 78906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetButtonCallback(
    InputBehaviorWindow.ButtonIdentifier buttonIdentifier,
    Il2CppSystem.Action<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &buttonIdentifier;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78908, XrefRangeEnd = 78926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputBehaviorWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78926, XrefRangeEnd = 78929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_OnDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnCancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78929, XrefRangeEnd = 78945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnRestoreDefault()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78945, XrefRangeEnd = 78948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickAxisSensitivityValueChanged(
    int inputBehaviorId,
    int controlId,
    float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &inputBehaviorId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controlId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78948, XrefRangeEnd = 78951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MouseXYAxisSensitivityValueChanged(
    int inputBehaviorId,
    int controlId,
    float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &inputBehaviorId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controlId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78951, XrefRangeEnd = 78960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inputBehaviorId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controlId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78960, XrefRangeEnd = 78969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inputBehaviorId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controlId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78981, RefRangeEnd = 78982, XrefRangeStart = 78969, XrefRangeEnd = 78981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void TakeInputFocus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputBehaviorWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78994, RefRangeEnd = 78995, XrefRangeStart = 78982, XrefRangeEnd = 78994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIControlSet CreateControlSet()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIControlSet) null : Il2CppObjectPool.Get<UIControlSet>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 79027, RefRangeEnd = 79029, XrefRangeStart = 78995, XrefRangeEnd = 79027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISliderControl CreateSlider(
    UIControlSet set,
    int inputBehaviorId,
    string defaultTitle,
    string overrideTitle,
    Sprite icon,
    float minValue,
    float maxValue,
    Il2CppSystem.Action<int, int, float> valueChangedCallback,
    Il2CppSystem.Action<int, int> cancelCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) set);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputBehaviorId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultTitle);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(overrideTitle);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) valueChangedCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cancelCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UISliderControl) null : Il2CppObjectPool.Get<UISliderControl>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 79035, RefRangeEnd = 79038, XrefRangeStart = 79029, XrefRangeEnd = 79035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputBehavior GetInputBehavior(int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (InputBehavior) null : Il2CppObjectPool.Get<InputBehavior>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 79042, RefRangeEnd = 79044, XrefRangeStart = 79038, XrefRangeEnd = 79042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputBehaviorWindow.InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputBehaviorId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (InputBehaviorWindow.InputBehaviorInfo) null : Il2CppObjectPool.Get<InputBehaviorWindow.InputBehaviorInfo>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79045, RefRangeEnd = 79046, XrefRangeStart = 79044, XrefRangeEnd = 79045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputBehaviorWindow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float minSensitivity
  {
    get
    {
      float minSensitivity;
      IL2CPP.il2cpp_field_static_get_value(InputBehaviorWindow.NativeFieldInfoPtr_minSensitivity, (void*) &minSensitivity);
      return minSensitivity;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputBehaviorWindow.NativeFieldInfoPtr_minSensitivity, (void*) &value);
    }
  }

  public unsafe RectTransform spawnTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_spawnTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_spawnTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button doneButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button cancelButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button defaultButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButton));
      return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text doneButtonLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButtonLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButtonLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text cancelButtonLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButtonLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButtonLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text defaultButtonLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButtonLabel));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButtonLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject uiControlSetPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiControlSetPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiControlSetPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject uiSliderControlPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiSliderControlPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiSliderControlPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<InputBehaviorWindow.InputBehaviorInfo> inputBehaviorInfo
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_inputBehaviorInfo));
      return num == System.IntPtr.Zero ? (List<InputBehaviorWindow.InputBehaviorInfo>) null : Il2CppObjectPool.Get<List<InputBehaviorWindow.InputBehaviorInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_inputBehaviorInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, Il2CppSystem.Action<int>> buttonCallbacks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_buttonCallbacks));
      return num == System.IntPtr.Zero ? (Dictionary<int, Il2CppSystem.Action<int>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppSystem.Action<int>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_buttonCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public class InputBehaviorInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__inputBehavior;
    private static readonly System.IntPtr NativeFieldInfoPtr__controlSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_idToProperty;
    private static readonly System.IntPtr NativeFieldInfoPtr_copyOfOriginal;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestorePreviousData_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshControls_Public_Void_0;

    static InputBehaviorInfo()
    {
      Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, nameof (InputBehaviorInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr);
      InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__inputBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, nameof (_inputBehavior));
      InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__controlSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, nameof (_controlSet));
      InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_idToProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, nameof (idToProperty));
      InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_copyOfOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, nameof (copyOfOriginal));
      InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669765);
      InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669766);
      InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669767);
      InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestorePreviousData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669768);
      InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669769);
      InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669770);
      InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RefreshControls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669771);
    }

    public unsafe InputBehavior inputBehavior
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (InputBehavior) null : Il2CppObjectPool.Get<InputBehavior>(num3);
      }
    }

    public unsafe UIControlSet controlSet
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (UIControlSet) null : Il2CppObjectPool.Get<UIControlSet>(num3);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 78732, RefRangeEnd = 78733, XrefRangeStart = 78727, XrefRangeEnd = 78732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InputBehaviorInfo(
      InputBehavior inputBehavior,
      UIControlSet controlSet,
      Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputBehavior);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controlSet);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) idToProperty);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78733, XrefRangeEnd = 78735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestorePreviousData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestorePreviousData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78735, XrefRangeEnd = 78738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreDefaultData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78738, XrefRangeEnd = 78748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreData(InputBehaviorWindow.PropertyType propertyType, int controlId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &propertyType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controlId;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 78775, RefRangeEnd = 78777, XrefRangeStart = 78748, XrefRangeEnd = 78775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshControls()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RefreshControls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe InputBehavior _inputBehavior
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__inputBehavior));
        return num == System.IntPtr.Zero ? (InputBehavior) null : Il2CppObjectPool.Get<InputBehavior>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__inputBehavior), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIControlSet _controlSet
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__controlSet));
        return num == System.IntPtr.Zero ? (UIControlSet) null : Il2CppObjectPool.Get<UIControlSet>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__controlSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_idToProperty));
        return num == System.IntPtr.Zero ? (Dictionary<int, InputBehaviorWindow.PropertyType>) null : Il2CppObjectPool.Get<Dictionary<int, InputBehaviorWindow.PropertyType>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_idToProperty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputBehavior copyOfOriginal
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_copyOfOriginal));
        return num == System.IntPtr.Zero ? (InputBehavior) null : Il2CppObjectPool.Get<InputBehavior>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_copyOfOriginal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public enum ButtonIdentifier
  {
    Done,
    Cancel,
    Default,
  }

  public enum PropertyType
  {
    JoystickAxisSensitivity,
    MouseXYAxisSensitivity,
  }

  [ObfuscatedName("Rewired.UI.ControlMapper.InputBehaviorWindow+<>c__DisplayClass26_0")]
  public sealed class __c__DisplayClass26_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_valueChangedCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_inputBehaviorId;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancelCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0;

    static __c__DisplayClass26_0()
    {
      Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "<>c__DisplayClass26_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr);
      InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_valueChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, nameof (valueChangedCallback));
      InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_inputBehaviorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, nameof (inputBehaviorId));
      InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, nameof (cancelCallback));
      InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, 100669772);
      InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, 100669773);
      InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, 100669774);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass26_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void _CreateSlider_b__0(int cId, float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78777, XrefRangeEnd = 78778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateSlider_b__1(int cId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &cId
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppSystem.Action<int, int, float> valueChangedCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_valueChangedCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int, int, float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int, int, float>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_valueChangedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int inputBehaviorId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_inputBehaviorId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_inputBehaviorId)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<int, int> cancelCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_cancelCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int, int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int, int>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
