// Decompiled with JetBrains decompiler
// Type: SadCatStudios.PlayerInput.InputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Rewired;
using SadCatStudios.Foundation.Events;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.PlayerInput;

public class InputManager(System.IntPtr pointer) : GlobalSingletonBehaviour<InputManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inputCacheTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_axisDeadzone;
  private static readonly System.IntPtr NativeFieldInfoPtr_axisAngles;
  private static readonly System.IntPtr NativeFieldInfoPtr_player;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputDownSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_axisCancelled;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonCancelled;
  private static readonly System.IntPtr NativeFieldInfoPtr_rewiredInputManager;
  private static readonly System.IntPtr NativeFieldInfoPtr_lockedSector;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelledAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelledButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_vibrateWithDelayCoroutine;
  private static readonly System.IntPtr NativeFieldInfoPtr_vibrateCoroutine;
  private static readonly System.IntPtr NativeFieldInfoPtr_disposeEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputActionValues;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AxisCancelled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ButtonCancelled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis_Public_Single_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRepeating_Public_Boolean_InputAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisDir_Public_Single_InputAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis2D_Public_Vector2_InputAction_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalogMap_Public_Vector3_InputAction_InputAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Public_Boolean_InputAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateKeyCache_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDownDirect_Public_Boolean_InputAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonUpDirect_Public_Boolean_InputAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDouble_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonShortDown_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonHold_Public_Boolean_InputAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLongPress_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnyKey_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InSector_Public_Boolean_Sector_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseUsed_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterForControllerChanged_Public_Void_PlayerActiveControllerChangedDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterForControllerChanged_Public_Void_PlayerActiveControllerChangedDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableGeneralInput_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableDefaultInput_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableDebugInput_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedAxisCancel_Public_Void_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedButtonCancel_Public_Void_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LockAxis_Public_Void_Sector_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnlockSector_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_Single_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_AnimationCurve_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoystickStopVibration_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VibrationPower_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckInputLock_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw_Private_Single_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisNorm_Private_Single_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deadzone_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckFlag_Private_Boolean_Sector_Sector_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForAxisCancel_Private_IEnumerator_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForButtonCancel_Private_IEnumerator_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Vibrate_Private_IEnumerator_Int32_AnimationCurve_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VibrateWithDelay_Private_IEnumerator_Int32_Single_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLayout_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalizedString_Public_Virtual_Final_New_Boolean_String_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__22_0_Private_Void_GameStateChangedEvent_0;

  static InputManager()
  {
    Il2CppClassPointerStore<InputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.PlayerInput", nameof (InputManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager>.NativeClassPtr);
    InputManager.NativeFieldInfoPtr_inputCacheTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (inputCacheTime));
    InputManager.NativeFieldInfoPtr_axisDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (axisDeadzone));
    InputManager.NativeFieldInfoPtr_axisAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (axisAngles));
    InputManager.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (player));
    InputManager.NativeFieldInfoPtr_inputDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (inputDownSet));
    InputManager.NativeFieldInfoPtr_axisCancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (axisCancelled));
    InputManager.NativeFieldInfoPtr_buttonCancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (buttonCancelled));
    InputManager.NativeFieldInfoPtr_rewiredInputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (rewiredInputManager));
    InputManager.NativeFieldInfoPtr_lockedSector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (lockedSector));
    InputManager.NativeFieldInfoPtr_cancelledAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (cancelledAxis));
    InputManager.NativeFieldInfoPtr_cancelledButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (cancelledButton));
    InputManager.NativeFieldInfoPtr_vibrateWithDelayCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (vibrateWithDelayCoroutine));
    InputManager.NativeFieldInfoPtr_vibrateCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (vibrateCoroutine));
    InputManager.NativeFieldInfoPtr_disposeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (disposeEvent));
    InputManager.NativeFieldInfoPtr_inputActionValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (inputActionValues));
    InputManager.NativeMethodInfoPtr_get_AxisCancelled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671010);
    InputManager.NativeMethodInfoPtr_get_ButtonCancelled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671011);
    InputManager.NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671012);
    InputManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671013);
    InputManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671014);
    InputManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671015);
    InputManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671016);
    InputManager.NativeMethodInfoPtr_GetAxis_Public_Single_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671017);
    InputManager.NativeMethodInfoPtr_GetRepeating_Public_Boolean_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671018);
    InputManager.NativeMethodInfoPtr_GetAxisDir_Public_Single_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671019);
    InputManager.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_InputAction_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671020);
    InputManager.NativeMethodInfoPtr_GetAnalogMap_Public_Vector3_InputAction_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671021);
    InputManager.NativeMethodInfoPtr_GetButton_Public_Boolean_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671022);
    InputManager.NativeMethodInfoPtr_InvalidateKeyCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671023);
    InputManager.NativeMethodInfoPtr_GetButtonDown_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671024);
    InputManager.NativeMethodInfoPtr_GetButtonDownDirect_Public_Boolean_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671025);
    InputManager.NativeMethodInfoPtr_GetButtonUp_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671026);
    InputManager.NativeMethodInfoPtr_GetButtonUpDirect_Public_Boolean_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671027);
    InputManager.NativeMethodInfoPtr_GetButtonDouble_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671028);
    InputManager.NativeMethodInfoPtr_GetButtonShortDown_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671029);
    InputManager.NativeMethodInfoPtr_GetButtonHold_Public_Boolean_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671030);
    InputManager.NativeMethodInfoPtr_GetLongPress_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671031);
    InputManager.NativeMethodInfoPtr_AnyKey_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671032);
    InputManager.NativeMethodInfoPtr_InSector_Public_Boolean_Sector_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671033);
    InputManager.NativeMethodInfoPtr_IsMouseUsed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671034);
    InputManager.NativeMethodInfoPtr_RegisterForControllerChanged_Public_Void_PlayerActiveControllerChangedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671035);
    InputManager.NativeMethodInfoPtr_UnregisterForControllerChanged_Public_Void_PlayerActiveControllerChangedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671036);
    InputManager.NativeMethodInfoPtr_EnableGeneralInput_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671037);
    InputManager.NativeMethodInfoPtr_EnableDefaultInput_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671038);
    InputManager.NativeMethodInfoPtr_EnableDebugInput_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671039);
    InputManager.NativeMethodInfoPtr_NeedAxisCancel_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671040);
    InputManager.NativeMethodInfoPtr_NeedButtonCancel_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671041);
    InputManager.NativeMethodInfoPtr_LockAxis_Public_Void_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671042);
    InputManager.NativeMethodInfoPtr_UnlockSector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671043);
    InputManager.NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671044);
    InputManager.NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_AnimationCurve_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671045);
    InputManager.NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671046);
    InputManager.NativeMethodInfoPtr_JoystickStopVibration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671047);
    InputManager.NativeMethodInfoPtr_VibrationPower_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671048);
    InputManager.NativeMethodInfoPtr_CheckInputLock_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671049);
    InputManager.NativeMethodInfoPtr_GetAxisRaw_Private_Single_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671050);
    InputManager.NativeMethodInfoPtr_GetAxisNorm_Private_Single_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671051);
    InputManager.NativeMethodInfoPtr_Deadzone_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671052);
    InputManager.NativeMethodInfoPtr_Normalize_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671053);
    InputManager.NativeMethodInfoPtr_CheckFlag_Private_Boolean_Sector_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671054);
    InputManager.NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671055);
    InputManager.NativeMethodInfoPtr_WaitForAxisCancel_Private_IEnumerator_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671056);
    InputManager.NativeMethodInfoPtr_WaitForButtonCancel_Private_IEnumerator_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671057);
    InputManager.NativeMethodInfoPtr_Vibrate_Private_IEnumerator_Int32_AnimationCurve_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671058);
    InputManager.NativeMethodInfoPtr_VibrateWithDelay_Private_IEnumerator_Int32_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671059);
    InputManager.NativeMethodInfoPtr_SetLayout_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671060);
    InputManager.NativeMethodInfoPtr_TryGetLocalizedString_Public_Virtual_Final_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671061);
    InputManager.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671062);
    InputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671063);
    InputManager.NativeMethodInfoPtr__Start_b__22_0_Private_Void_GameStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100671064);
  }

  public unsafe bool AxisCancelled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_AxisCancelled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ButtonCancelled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_ButtonCancelled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Rewired.InputManager RewiredInputManager
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 90426, RefRangeEnd = 90428, XrefRangeStart = 90419, XrefRangeEnd = 90426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Rewired.InputManager) null : Il2CppObjectPool.Get<Rewired.InputManager>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90428, XrefRangeEnd = 90457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90457, XrefRangeEnd = 90476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90476, XrefRangeEnd = 90501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90501, XrefRangeEnd = 90509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 90511, RefRangeEnd = 90524, XrefRangeStart = 90509, XrefRangeEnd = 90511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAxis(InputAction axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &axis
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetAxis_Public_Single_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90527, RefRangeEnd = 90529, XrefRangeStart = 90524, XrefRangeEnd = 90527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetRepeating(InputAction axis, bool negative = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &negative;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetRepeating_Public_Boolean_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 90531, RefRangeEnd = 90541, XrefRangeStart = 90529, XrefRangeEnd = 90531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAxisDir(InputAction axis, bool ignoreDeathZone = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreDeathZone;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetAxisDir_Public_Single_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90543, RefRangeEnd = 90545, XrefRangeStart = 90541, XrefRangeEnd = 90543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2 GetAxis2D(InputAction axis1, InputAction axis2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &axis1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_InputAction_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90554, RefRangeEnd = 90557, XrefRangeStart = 90545, XrefRangeEnd = 90554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetAnalogMap(InputAction axis1, InputAction axis2, bool zAsStrength = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &axis1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &zAsStrength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetAnalogMap_Public_Vector3_InputAction_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 90557, RefRangeEnd = 90572, XrefRangeStart = 90557, XrefRangeEnd = 90557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButton(InputAction button, bool includeNegative = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &button;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeNegative;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButton_Public_Boolean_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 90582, RefRangeEnd = 90600, XrefRangeStart = 90572, XrefRangeEnd = 90582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvalidateKeyCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_InvalidateKeyCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 90601, RefRangeEnd = 90646, XrefRangeStart = 90600, XrefRangeEnd = 90601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonDown(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButtonDown_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90648, RefRangeEnd = 90650, XrefRangeStart = 90646, XrefRangeEnd = 90648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonDownDirect(InputAction button, bool includeNegative = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &button;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeNegative;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButtonDownDirect_Public_Boolean_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 90651, RefRangeEnd = 90656, XrefRangeStart = 90650, XrefRangeEnd = 90651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonUp(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButtonUp_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90656, XrefRangeEnd = 90658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonUpDirect(InputAction button, bool includeNegative = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &button;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeNegative;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButtonUpDirect_Public_Boolean_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90659, RefRangeEnd = 90660, XrefRangeStart = 90658, XrefRangeEnd = 90659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonDouble(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButtonDouble_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90666, RefRangeEnd = 90667, XrefRangeStart = 90660, XrefRangeEnd = 90666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonShortDown(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButtonShortDown_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90669, RefRangeEnd = 90671, XrefRangeStart = 90667, XrefRangeEnd = 90669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonHold(InputAction button, bool includeNegative = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &button;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeNegative;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetButtonHold_Public_Boolean_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90671, XrefRangeEnd = 90673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetLongPress(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetLongPress_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90674, RefRangeEnd = 90677, XrefRangeStart = 90673, XrefRangeEnd = 90674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AnyKey()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_AnyKey_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 90721, RefRangeEnd = 90727, XrefRangeStart = 90677, XrefRangeEnd = 90721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InSector(Sector sector, float dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_InSector_Public_Boolean_Sector_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90730, RefRangeEnd = 90733, XrefRangeStart = 90727, XrefRangeEnd = 90730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsMouseUsed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_IsMouseUsed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 90735, RefRangeEnd = 90740, XrefRangeStart = 90733, XrefRangeEnd = 90735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterForControllerChanged(PlayerActiveControllerChangedDelegate callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_RegisterForControllerChanged_Public_Void_PlayerActiveControllerChangedDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90742, RefRangeEnd = 90745, XrefRangeStart = 90740, XrefRangeEnd = 90742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterForControllerChanged(PlayerActiveControllerChangedDelegate callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UnregisterForControllerChanged_Public_Void_PlayerActiveControllerChangedDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 90755, RefRangeEnd = 90769, XrefRangeStart = 90745, XrefRangeEnd = 90755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableGeneralInput(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_EnableGeneralInput_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90773, RefRangeEnd = 90774, XrefRangeStart = 90769, XrefRangeEnd = 90773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableDefaultInput(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_EnableDefaultInput_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90778, RefRangeEnd = 90781, XrefRangeStart = 90774, XrefRangeEnd = 90778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableDebugInput(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_EnableDebugInput_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90781, XrefRangeEnd = 90786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NeedAxisCancel(InputAction axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &axis
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_NeedAxisCancel_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90786, XrefRangeEnd = 90791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NeedButtonCancel(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_NeedButtonCancel_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 90791, RefRangeEnd = 90807, XrefRangeStart = 90791, XrefRangeEnd = 90791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LockAxis(Sector lockSector)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &lockSector
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_LockAxis_Public_Void_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 90807, RefRangeEnd = 90820, XrefRangeStart = 90807, XrefRangeEnd = 90807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnlockSector()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UnlockSector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90825, RefRangeEnd = 90827, XrefRangeStart = 90820, XrefRangeEnd = 90825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickVibration(
    int motorIndex,
    float motorLevel,
    float delay,
    float duration,
    bool stopOthers)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delay;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOthers;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90832, RefRangeEnd = 90834, XrefRangeStart = 90827, XrefRangeEnd = 90832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickVibration(int motorIndex, AnimationCurve curve, bool stopOthers)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOthers;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_AnimationCurve_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90838, RefRangeEnd = 90840, XrefRangeStart = 90834, XrefRangeEnd = 90838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickVibration(int motorIndex, float motorLevel, bool stopOthers)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOthers;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_JoystickVibration_Public_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90844, RefRangeEnd = 90847, XrefRangeStart = 90840, XrefRangeEnd = 90844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickStopVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_JoystickStopVibration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90847, XrefRangeEnd = 90849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float VibrationPower(float motorLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &motorLevel
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_VibrationPower_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90849, RefRangeEnd = 90851, XrefRangeStart = 90849, XrefRangeEnd = 90849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckInputLock(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_CheckInputLock_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90851, XrefRangeEnd = 90852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAxisRaw(InputAction axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &axis
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetAxisRaw_Private_Single_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90852, XrefRangeEnd = 90853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAxisNorm(InputAction axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &axis
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetAxisNorm_Private_Single_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90853, XrefRangeEnd = 90854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Deadzone(float raw)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &raw
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Deadzone_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe float Normalize(float raw)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &raw
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Normalize_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90854, XrefRangeEnd = 90857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckFlag(Sector sector, Sector flag)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_CheckFlag_Private_Boolean_Sector_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerDisconnected(ControllerStatusChangedEventArgs obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90857, XrefRangeEnd = 90861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForAxisCancel(InputAction axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &axis
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_WaitForAxisCancel_Private_IEnumerator_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90861, XrefRangeEnd = 90865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForButtonCancel(InputAction button)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &button
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_WaitForButtonCancel_Private_IEnumerator_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90865, XrefRangeEnd = 90869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Vibrate(int motorIndex, AnimationCurve curve, bool stopOthers)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOthers;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Vibrate_Private_IEnumerator_Int32_AnimationCurve_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90869, XrefRangeEnd = 90873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator VibrateWithDelay(
    int motorIndex,
    float motorLevel,
    float delay,
    float duration,
    bool stopOthers)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delay;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOthers;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_VibrateWithDelay_Private_IEnumerator_Int32_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90889, RefRangeEnd = 90891, XrefRangeStart = 90873, XrefRangeEnd = 90889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetLayout(string layoutTag)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(layoutTag)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_SetLayout_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90891, XrefRangeEnd = 90903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool TryGetLocalizedString(string key, out string result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_TryGetLocalizedString_Public_Virtual_Final_New_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    result = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90903, XrefRangeEnd = 90909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LanguageChanged(ArticyLanguage oldLang, ArticyLanguage newLang)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) oldLang);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newLang);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90909, XrefRangeEnd = 90928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90928, XrefRangeEnd = 90942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__22_0(GameStateChangedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr__Start_b__22_0_Private_Void_GameStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference inputCacheTime
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_inputCacheTime));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_inputCacheTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference axisDeadzone
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_axisDeadzone));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_axisDeadzone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference axisAngles
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_axisAngles));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_axisAngles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Player player
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_player));
      return num == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputCache inputDownSet
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_inputDownSet));
      return num == System.IntPtr.Zero ? (InputCache) null : Il2CppObjectPool.Get<InputCache>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_inputDownSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool axisCancelled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_axisCancelled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_axisCancelled)) = value;
    }
  }

  public unsafe bool buttonCancelled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_buttonCancelled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_buttonCancelled)) = value;
    }
  }

  public unsafe Rewired.InputManager rewiredInputManager
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_rewiredInputManager));
      return num == System.IntPtr.Zero ? (Rewired.InputManager) null : Il2CppObjectPool.Get<Rewired.InputManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_rewiredInputManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sector lockedSector
  {
    get
    {
      return *(Sector*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lockedSector));
    }
    [param: In] set
    {
      *(Sector*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lockedSector)) = value;
    }
  }

  public unsafe InputAction cancelledAxis
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_cancelledAxis));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_cancelledAxis)) = value;
    }
  }

  public unsafe InputAction cancelledButton
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_cancelledButton));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_cancelledButton)) = value;
    }
  }

  public unsafe IEnumerator vibrateWithDelayCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_vibrateWithDelayCoroutine));
      return num == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_vibrateWithDelayCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IEnumerator vibrateCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_vibrateCoroutine));
      return num == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_vibrateCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable disposeEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_disposeEvent));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_disposeEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<InputAction> inputActionValues
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_inputActionValues));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<InputAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<InputAction>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_inputActionValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.PlayerInput.InputManager+<Vibrate>d__66")]
  public sealed class _Vibrate_d__66(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_motorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_stopOthers;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Vibrate_d__66()
    {
      Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<Vibrate>d__66");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr);
      InputManager._Vibrate_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, "<>1__state");
      InputManager._Vibrate_d__66.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, "<>2__current");
      InputManager._Vibrate_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, "<>4__this");
      InputManager._Vibrate_d__66.NativeFieldInfoPtr_motorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, nameof (motorIndex));
      InputManager._Vibrate_d__66.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, nameof (curve));
      InputManager._Vibrate_d__66.NativeFieldInfoPtr_stopOthers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, nameof (stopOthers));
      InputManager._Vibrate_d__66.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, "<timer>5__2");
      InputManager._Vibrate_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, 100671065);
      InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, 100671066);
      InputManager._Vibrate_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, 100671067);
      InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, 100671068);
      InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, 100671069);
      InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr, 100671070);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Vibrate_d__66(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager._Vibrate_d__66>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._Vibrate_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90382, XrefRangeEnd = 90391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._Vibrate_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90391, XrefRangeEnd = 90396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._Vibrate_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InputManager) null : Il2CppObjectPool.Get<InputManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int motorIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr_motorIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr_motorIndex)) = value;
      }
    }

    public unsafe AnimationCurve curve
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr_curve));
        return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool stopOthers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr_stopOthers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr_stopOthers)) = value;
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._Vibrate_d__66.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.PlayerInput.InputManager+<VibrateWithDelay>d__67")]
  public sealed class _VibrateWithDelay_d__67(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_motorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_motorLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_stopOthers;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _VibrateWithDelay_d__67()
    {
      Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<VibrateWithDelay>d__67");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr);
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, "<>1__state");
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, "<>2__current");
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, nameof (delay));
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, "<>4__this");
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_motorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, nameof (motorIndex));
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_motorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, nameof (motorLevel));
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, nameof (duration));
      InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_stopOthers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, nameof (stopOthers));
      InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, 100671071);
      InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, 100671072);
      InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, 100671073);
      InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, 100671074);
      InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, 100671075);
      InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr, 100671076);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _VibrateWithDelay_d__67(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager._VibrateWithDelay_d__67>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90396, XrefRangeEnd = 90400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90400, XrefRangeEnd = 90405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._VibrateWithDelay_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_delay)) = value;
      }
    }

    public unsafe InputManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InputManager) null : Il2CppObjectPool.Get<InputManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int motorIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_motorIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_motorIndex)) = value;
      }
    }

    public unsafe float motorLevel
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_motorLevel));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_motorLevel)) = value;
      }
    }

    public unsafe float duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_duration)) = value;
      }
    }

    public unsafe bool stopOthers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_stopOthers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._VibrateWithDelay_d__67.NativeFieldInfoPtr_stopOthers)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.PlayerInput.InputManager+<WaitForAxisCancel>d__64")]
  public sealed class _WaitForAxisCancel_d__64(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_axis;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForAxisCancel_d__64()
    {
      Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<WaitForAxisCancel>d__64");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr);
      InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, "<>1__state");
      InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, "<>2__current");
      InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, "<>4__this");
      InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, nameof (axis));
      InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, 100671077);
      InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, 100671078);
      InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, 100671079);
      InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, 100671080);
      InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, 100671081);
      InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr, 100671082);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForAxisCancel_d__64(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager._WaitForAxisCancel_d__64>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90405, XrefRangeEnd = 90407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90407, XrefRangeEnd = 90412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForAxisCancel_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InputManager) null : Il2CppObjectPool.Get<InputManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputAction axis
    {
      get
      {
        return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr_axis));
      }
      [param: In] set
      {
        *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForAxisCancel_d__64.NativeFieldInfoPtr_axis)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.PlayerInput.InputManager+<WaitForButtonCancel>d__65")]
  public sealed class _WaitForButtonCancel_d__65(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_button;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForButtonCancel_d__65()
    {
      Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<WaitForButtonCancel>d__65");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr);
      InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, "<>1__state");
      InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, "<>2__current");
      InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, "<>4__this");
      InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, nameof (button));
      InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, 100671083);
      InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, 100671084);
      InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, 100671085);
      InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, 100671086);
      InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, 100671087);
      InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr, 100671088);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForButtonCancel_d__65(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager._WaitForButtonCancel_d__65>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90412, XrefRangeEnd = 90414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90414, XrefRangeEnd = 90419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager._WaitForButtonCancel_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InputManager) null : Il2CppObjectPool.Get<InputManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputAction button
    {
      get
      {
        return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr_button));
      }
      [param: In] set
      {
        *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager._WaitForButtonCancel_d__65.NativeFieldInfoPtr_button)) = value;
      }
    }
  }
}
