// Decompiled with JetBrains decompiler
// Type: Configs.JoystickSimpleVibrationConfig
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

public class JoystickSimpleVibrationConfig(IntPtr pointer) : JoystickVibrationConfig(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_delay;
  private static readonly IntPtr NativeFieldInfoPtr_leftMotorForce;
  private static readonly IntPtr NativeFieldInfoPtr_leftMotorDuration;
  private static readonly IntPtr NativeFieldInfoPtr_rightMotorForce;
  private static readonly IntPtr NativeFieldInfoPtr_rightMotorDuration;
  private static readonly IntPtr NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JoystickSimpleVibrationConfig()
  {
    Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Configs", nameof (JoystickSimpleVibrationConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr);
    JoystickSimpleVibrationConfig.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr, nameof (delay));
    JoystickSimpleVibrationConfig.NativeFieldInfoPtr_leftMotorForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr, nameof (leftMotorForce));
    JoystickSimpleVibrationConfig.NativeFieldInfoPtr_leftMotorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr, nameof (leftMotorDuration));
    JoystickSimpleVibrationConfig.NativeFieldInfoPtr_rightMotorForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr, nameof (rightMotorForce));
    JoystickSimpleVibrationConfig.NativeFieldInfoPtr_rightMotorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr, nameof (rightMotorDuration));
    JoystickSimpleVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr, 100670611);
    JoystickSimpleVibrationConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr, 100670612);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86625, XrefRangeEnd = 86632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CallVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JoystickSimpleVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86632, XrefRangeEnd = 86633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickSimpleVibrationConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickSimpleVibrationConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickSimpleVibrationConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float delay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_delay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_delay)) = value;
    }
  }

  public unsafe float leftMotorForce
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_leftMotorForce));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_leftMotorForce)) = value;
    }
  }

  public unsafe float leftMotorDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_leftMotorDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_leftMotorDuration)) = value;
    }
  }

  public unsafe float rightMotorForce
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_rightMotorForce));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_rightMotorForce)) = value;
    }
  }

  public unsafe float rightMotorDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_rightMotorDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickSimpleVibrationConfig.NativeFieldInfoPtr_rightMotorDuration)) = value;
    }
  }
}
