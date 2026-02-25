// Decompiled with JetBrains decompiler
// Type: Configs.JoystickVibrationConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Configs;

public class JoystickVibrationConfig(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_useLeftMotor;
  private static readonly IntPtr NativeFieldInfoPtr_useRightMotor;
  private static readonly IntPtr NativeFieldInfoPtr_leftMotorCancelPrevios;
  private static readonly IntPtr NativeFieldInfoPtr_rightMotorCancelPrevios;
  private static readonly IntPtr NativeMethodInfoPtr_CallVibration_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static JoystickVibrationConfig()
  {
    Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Configs", nameof (JoystickVibrationConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr);
    JoystickVibrationConfig.NativeFieldInfoPtr_useLeftMotor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr, nameof (useLeftMotor));
    JoystickVibrationConfig.NativeFieldInfoPtr_useRightMotor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr, nameof (useRightMotor));
    JoystickVibrationConfig.NativeFieldInfoPtr_leftMotorCancelPrevios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr, nameof (leftMotorCancelPrevios));
    JoystickVibrationConfig.NativeFieldInfoPtr_rightMotorCancelPrevios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr, nameof (rightMotorCancelPrevios));
    JoystickVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr, 100670613);
    JoystickVibrationConfig.NativeMethodInfoPtr_StopVibration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr, 100670614);
    JoystickVibrationConfig.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr, 100670615);
  }

  [CallerCount(0)]
  public virtual unsafe void CallVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JoystickVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86633, XrefRangeEnd = 86638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickVibrationConfig.NativeMethodInfoPtr_StopVibration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86638, XrefRangeEnd = 86639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickVibrationConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickVibrationConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickVibrationConfig.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool useLeftMotor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_useLeftMotor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_useLeftMotor)) = value;
    }
  }

  public unsafe bool useRightMotor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_useRightMotor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_useRightMotor)) = value;
    }
  }

  public unsafe bool leftMotorCancelPrevios
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_leftMotorCancelPrevios));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_leftMotorCancelPrevios)) = value;
    }
  }

  public unsafe bool rightMotorCancelPrevios
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_rightMotorCancelPrevios));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickVibrationConfig.NativeFieldInfoPtr_rightMotorCancelPrevios)) = value;
    }
  }
}
