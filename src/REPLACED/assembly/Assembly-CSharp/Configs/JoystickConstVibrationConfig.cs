// Decompiled with JetBrains decompiler
// Type: Configs.JoystickConstVibrationConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Configs;

public class JoystickConstVibrationConfig(IntPtr pointer) : JoystickVibrationConfig(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_leftMotorLevel;
  private static readonly IntPtr NativeFieldInfoPtr_rightMotorLevel;
  private static readonly IntPtr NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JoystickConstVibrationConfig()
  {
    Il2CppClassPointerStore<JoystickConstVibrationConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Configs", nameof (JoystickConstVibrationConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickConstVibrationConfig>.NativeClassPtr);
    JoystickConstVibrationConfig.NativeFieldInfoPtr_leftMotorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickConstVibrationConfig>.NativeClassPtr, nameof (leftMotorLevel));
    JoystickConstVibrationConfig.NativeFieldInfoPtr_rightMotorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickConstVibrationConfig>.NativeClassPtr, nameof (rightMotorLevel));
    JoystickConstVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickConstVibrationConfig>.NativeClassPtr, 100670607);
    JoystickConstVibrationConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickConstVibrationConfig>.NativeClassPtr, 100670608);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86607, XrefRangeEnd = 86614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CallVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JoystickConstVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86614, XrefRangeEnd = 86615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickConstVibrationConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickConstVibrationConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickConstVibrationConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float leftMotorLevel
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickConstVibrationConfig.NativeFieldInfoPtr_leftMotorLevel));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickConstVibrationConfig.NativeFieldInfoPtr_leftMotorLevel)) = value;
    }
  }

  public unsafe float rightMotorLevel
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickConstVibrationConfig.NativeFieldInfoPtr_rightMotorLevel));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickConstVibrationConfig.NativeFieldInfoPtr_rightMotorLevel)) = value;
    }
  }
}
