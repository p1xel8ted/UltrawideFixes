// Decompiled with JetBrains decompiler
// Type: Rewired.Utils.ExternalTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Utils;

public class ExternalTools(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__getPlatformInitializerDelegate;
  private static readonly System.IntPtr NativeFieldInfoPtr__isEditorPaused;
  private static readonly System.IntPtr NativeFieldInfoPtr__EditorPausedStateChangedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WindowsStandalone_ForwardRawInput_Public_Virtual_Final_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0;

  static ExternalTools()
  {
    Il2CppClassPointerStore<ExternalTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Utils", nameof (ExternalTools));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr);
    ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (_getPlatformInitializerDelegate));
    ExternalTools.NativeFieldInfoPtr__isEditorPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (_isEditorPaused));
    ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (_EditorPausedStateChangedEvent));
    ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (XboxOneInput_OnGamepadStateChange));
    ExternalTools.NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668156);
    ExternalTools.NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668157);
    ExternalTools.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668158);
    ExternalTools.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668159);
    ExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668160 /*0x06001300*/);
    ExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668161);
    ExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668162);
    ExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668163);
    ExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668164);
    ExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668165);
    ExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668166);
    ExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668167);
    ExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668168);
    ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668169);
    ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668170);
    ExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668171);
    ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668172);
    ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668173);
    ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668174);
    ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668175);
    ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668176);
    ExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668177);
    ExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668178);
    ExternalTools.NativeMethodInfoPtr_WindowsStandalone_ForwardRawInput_Public_Virtual_Final_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668179);
    ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668180);
    ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668181);
    ExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668182);
    ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668183);
    ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668184);
    ExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668185);
    ExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668186);
    ExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100668187);
  }

  public static unsafe Il2CppSystem.Func<Il2CppSystem.Object> getPlatformInitializerDelegate
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65237, XrefRangeEnd = 65239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Object>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65239, XrefRangeEnd = 65241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ExternalTools()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Destroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe bool isEditorPaused
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65241, XrefRangeEnd = 65244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void add_EditorPausedStateChangedEvent(Il2CppSystem.Action<bool> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65244, XrefRangeEnd = 65247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void remove_EditorPausedStateChangedEvent(Il2CppSystem.Action<bool> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65247, XrefRangeEnd = 65248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object GetPlatformInitializer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65248, XrefRangeEnd = 65249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string GetFocusedEditorWindowTitle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(194)]
  [CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsEditorSceneViewFocused()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(194)]
  [CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool LinuxInput_IsJoystickPreconfigured(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65443, XrefRangeEnd = 65448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void add_XboxOneInput_OnGamepadStateChange(Il2CppSystem.Action<uint, bool> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65448, XrefRangeEnd = 65453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void remove_XboxOneInput_OnGamepadStateChange(Il2CppSystem.Action<uint, bool> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int XboxOneInput_GetUserIdForGamepad(uint id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ulong XboxOneInput_GetControllerId(uint unityJoystickId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &unityJoystickId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(194)]
  [CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &unityJoystickId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string XboxOneInput_GetControllerType(ulong xboxControllerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &xboxControllerId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &xboxControllerId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void XboxOne_Gamepad_UpdatePlugin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(194)]
  [CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool XboxOne_Gamepad_SetGamepadVibration(
    ulong xboxOneJoystickId,
    float leftMotor,
    float rightMotor,
    float leftTriggerLevel,
    float rightTriggerLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &xboxOneJoystickId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &leftMotor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rightMotor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &leftTriggerLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rightTriggerLevel;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void XboxOne_Gamepad_PulseVibrateMotor(
    ulong xboxOneJoystickId,
    int motorInt,
    float startLevel,
    float endLevel,
    ulong durationMS)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &xboxOneJoystickId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorInt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &endLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &durationMS;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65453, XrefRangeEnd = 65463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero1;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero2;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref List<int> local1 = ref vids;
    System.IntPtr pointer1 = zero1;
    List<int> list1 = pointer1 == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer1);
    local1 = list1;
    ref List<int> local2 = ref pids;
    System.IntPtr pointer2 = zero2;
    List<int> list2 = pointer2 == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer2);
    local2 = list2;
  }

  [CallerCount(0)]
  public virtual unsafe int GetAndroidAPILevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65463, XrefRangeEnd = 65464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void WindowsStandalone_ForwardRawInput(
    System.IntPtr rawInputHeaderIndices,
    System.IntPtr rawInputDataIndices,
    uint indicesCount,
    System.IntPtr rawInputData,
    uint rawInputDataSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &rawInputHeaderIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &indicesCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_WindowsStandalone_ForwardRawInput_Public_Virtual_Final_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65464, XrefRangeEnd = 65472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool UnityUI_Graphic_GetRaycastTarget(Il2CppSystem.Object graphic)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphic)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65472, XrefRangeEnd = 65480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityUI_Graphic_SetRaycastTarget(Il2CppSystem.Object graphic, bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphic);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe bool UnityInput_IsTouchPressureSupported
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65480, XrefRangeEnd = 65481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65481, XrefRangeEnd = 65482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float UnityInput_GetTouchPressure(ref Touch touch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref touch
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65482, XrefRangeEnd = 65483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref touch
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65483, XrefRangeEnd = 65487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IControllerTemplate CreateControllerTemplate(Il2CppSystem.Guid typeGuid, Il2CppSystem.Object payload)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &typeGuid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IControllerTemplate) null : Il2CppObjectPool.Get<IControllerTemplate>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65487, XrefRangeEnd = 65495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetControllerTemplateTypes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65495, XrefRangeEnd = 65503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetControllerTemplateInterfaceTypes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
  }

  public static unsafe Il2CppSystem.Func<Il2CppSystem.Object> _getPlatformInitializerDelegate
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Object>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _isEditorPaused
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__isEditorPaused));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__isEditorPaused)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<bool> _EditorPausedStateChangedEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<uint, bool> XboxOneInput_OnGamepadStateChange
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<uint, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<uint, bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
