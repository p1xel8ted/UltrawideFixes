// Decompiled with JetBrains decompiler
// Type: Rewired.Platforms.Switch.NintendoSwitchInputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Platforms.Switch;

public sealed class NintendoSwitchInputManager(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__userData;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static NintendoSwitchInputManager()
  {
    Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Platforms.Switch", nameof (NintendoSwitchInputManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr);
    NintendoSwitchInputManager.NativeFieldInfoPtr__userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (_userData));
    NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100668077);
    NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100668078);
    NintendoSwitchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100668079);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Rewired_Utils_Interfaces_IExternalInputManager_Initialize(
    Platform platform,
    Il2CppSystem.Object configVars)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &platform;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) configVars);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65232, XrefRangeEnd = 65237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NintendoSwitchInputManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe NintendoSwitchInputManager.UserData _userData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NativeFieldInfoPtr__userData));
      return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.UserData) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.UserData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NativeFieldInfoPtr__userData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class UserData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__allowedNpadStyles;
    private static readonly System.IntPtr NativeFieldInfoPtr__joyConGripStyle;
    private static readonly System.IntPtr NativeFieldInfoPtr__adjustIMUsForGripStyle;
    private static readonly System.IntPtr NativeFieldInfoPtr__handheldActivationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__assignJoysticksByNpadId;
    private static readonly System.IntPtr NativeFieldInfoPtr__useVibrationThread;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo1;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo2;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo3;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo4;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo5;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo6;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo7;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadNo8;
    private static readonly System.IntPtr NativeFieldInfoPtr__npadHandheld;
    private static readonly System.IntPtr NativeFieldInfoPtr__debugPad;
    private static readonly System.IntPtr NativeFieldInfoPtr___delegates;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_useVibrationThread_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_useVibrationThread_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_0_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_1_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_2_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_3_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_4_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_5_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_6_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_7_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_8_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_9_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_10_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_11_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_12_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_13_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_14_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_15_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_16_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_17_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_18_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_19_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_20_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_21_Private_Void_Boolean_0;

    static UserData()
    {
      Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (UserData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr);
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_allowedNpadStyles));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_joyConGripStyle));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_adjustIMUsForGripStyle));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_handheldActivationMode));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_assignJoysticksByNpadId));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__useVibrationThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_useVibrationThread));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo1));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo2));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo3));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo4));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo5));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo6));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo7));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo8));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadHandheld));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_debugPad));
      NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (__delegates));
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668080);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668081);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668082);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668083);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668084);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668085);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668086);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668087);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668088);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668089);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_useVibrationThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668090);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_useVibrationThread_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668091);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668092);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668093);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668094);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668095);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668096);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668097);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668098);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668099);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668100);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668101);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668102);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668103);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668104);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668105);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_0_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668106);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668107);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668108);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668109);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668110);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668111);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_6_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668112);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_7_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668113);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_8_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668114);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_9_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668115);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_10_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668116);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_11_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668117);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_12_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668118);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_13_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668119);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_14_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668120);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_15_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668121);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_16_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668122);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_17_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668123);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_18_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668124);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_19_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668125);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_20_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668126);
      NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_21_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100668127);
    }

    public unsafe int allowedNpadStyles
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe int joyConGripStyle
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe bool adjustIMUsForGripStyle
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 64585, RefRangeEnd = 64591, XrefRangeStart = 64585, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe int handheldActivationMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe bool assignJoysticksByNpadId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe bool useVibrationThread
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_useVibrationThread_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_useVibrationThread_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo1
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo2
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo3
    {
      [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo4
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo5
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo6
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo7
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo8
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadHandheld
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num3);
      }
    }

    public unsafe NintendoSwitchInputManager.DebugPadSettings_Internal debugPad
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (NintendoSwitchInputManager.DebugPadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.DebugPadSettings_Internal>(num3);
      }
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> delegates
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 64833, RefRangeEnd = 64835, XrefRangeStart = 64624, XrefRangeEnd = 64833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64835, XrefRangeEnd = 64845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(
      int key,
      out T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref value;
        System.IntPtr num4 = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64845, XrefRangeEnd = 64854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(
      int key,
      T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 64887, RefRangeEnd = 64888, XrefRangeStart = 64854, XrefRangeEnd = 64887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _get_delegates_b__56_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_0_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _get_delegates_b__56_1(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe int _get_delegates_b__56_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _get_delegates_b__56_3(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 64585, RefRangeEnd = 64591, XrefRangeStart = 64585, XrefRangeEnd = 64591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _get_delegates_b__56_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe void _get_delegates_b__56_5(bool x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe int _get_delegates_b__56_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_6_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe void _get_delegates_b__56_7(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_7_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _get_delegates_b__56_8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_8_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe void _get_delegates_b__56_9(bool x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_9_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_10()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_10_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_11()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_11_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_12()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_12_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_13()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_13_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_14()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_14_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_15()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_15_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_16()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_16_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_17()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_17_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_18()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_18_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    public unsafe Il2CppSystem.Object _get_delegates_b__56_19()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_19_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    public unsafe bool _get_delegates_b__56_20()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_20_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe void _get_delegates_b__56_21(bool x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_21_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int _allowedNpadStyles
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles)) = value;
      }
    }

    public unsafe int _joyConGripStyle
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle)) = value;
      }
    }

    public unsafe bool _adjustIMUsForGripStyle
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle)) = value;
      }
    }

    public unsafe int _handheldActivationMode
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode)) = value;
      }
    }

    public unsafe bool _assignJoysticksByNpadId
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId)) = value;
      }
    }

    public unsafe bool _useVibrationThread
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__useVibrationThread));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__useVibrationThread)) = value;
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo3
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo5
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo6
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo7
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo8
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadHandheld
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NintendoSwitchInputManager.DebugPadSettings_Internal _debugPad
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad));
        return num == System.IntPtr.Zero ? (NintendoSwitchInputManager.DebugPadSettings_Internal) null : Il2CppObjectPool.Get<NintendoSwitchInputManager.DebugPadSettings_Internal>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> __delegates
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates));
        return num == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }

  [Serializable]
  public sealed class NpadSettings_Internal(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__isAllowed;
    private static readonly System.IntPtr NativeFieldInfoPtr__rewiredPlayerId;
    private static readonly System.IntPtr NativeFieldInfoPtr__joyConAssignmentMode;
    private static readonly System.IntPtr NativeFieldInfoPtr___delegates;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0;

    static NpadSettings_Internal()
    {
      Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (NpadSettings_Internal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (_isAllowed));
      NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (_rewiredPlayerId));
      NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (_joyConAssignmentMode));
      NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (__delegates));
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668128);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668129);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668130);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668131);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668132);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668133);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668134);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668135);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668136);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668137);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668138);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668139);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668140);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668141);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668142);
      NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100668143);
    }

    public unsafe bool isAllowed
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe int rewiredPlayerId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe int joyConAssignmentMode
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64891, XrefRangeEnd = 64892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NpadSettings_Internal(int playerId)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> delegates
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 64952, RefRangeEnd = 64954, XrefRangeStart = 64892, XrefRangeEnd = 64952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64954, XrefRangeEnd = 64964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(
      int key,
      out T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref value;
        System.IntPtr num4 = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64964, XrefRangeEnd = 64973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(
      int key,
      T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    public unsafe bool _get_delegates_b__15_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _get_delegates_b__15_1(bool x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe int _get_delegates_b__15_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _get_delegates_b__15_3(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _get_delegates_b__15_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _get_delegates_b__15_5(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool _isAllowed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed)) = value;
      }
    }

    public unsafe int _rewiredPlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId)) = value;
      }
    }

    public unsafe int _joyConAssignmentMode
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode)) = value;
      }
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> __delegates
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates));
        return num == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }

  [Serializable]
  public sealed class DebugPadSettings_Internal(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__rewiredPlayerId;
    private static readonly System.IntPtr NativeFieldInfoPtr___delegates;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0;

    static DebugPadSettings_Internal()
    {
      Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (DebugPadSettings_Internal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, nameof (_enabled));
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, nameof (_rewiredPlayerId));
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, nameof (__delegates));
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668144);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668145);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668146);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668147);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668148);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668149);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668150);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668151);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668152);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668153);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668154);
      NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100668155);
    }

    public unsafe int rewiredPlayerId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe bool enabled
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64973, XrefRangeEnd = 64974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugPadSettings_Internal(int playerId)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> delegates
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 65018, RefRangeEnd = 65020, XrefRangeStart = 64974, XrefRangeEnd = 65018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65020, XrefRangeEnd = 65030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(
      int key,
      out T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref value;
        System.IntPtr num4 = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65030, XrefRangeEnd = 65039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(
      int key,
      T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    public unsafe bool _get_delegates_b__11_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _get_delegates_b__11_1(bool x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe int _get_delegates_b__11_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _get_delegates_b__11_3(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &x
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool _enabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled)) = value;
      }
    }

    public unsafe int _rewiredPlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId)) = value;
      }
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> __delegates
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates));
        return num == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
