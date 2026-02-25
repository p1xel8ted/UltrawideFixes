// Decompiled with JetBrains decompiler
// Type: Configs.JoystickCurvedVibrationConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Configs;

public class JoystickCurvedVibrationConfig(IntPtr pointer) : JoystickVibrationConfig(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_leftMotorCurve;
  private static readonly IntPtr NativeFieldInfoPtr_rightMotorCurve;
  private static readonly IntPtr NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JoystickCurvedVibrationConfig()
  {
    Il2CppClassPointerStore<JoystickCurvedVibrationConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Configs", nameof (JoystickCurvedVibrationConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickCurvedVibrationConfig>.NativeClassPtr);
    JoystickCurvedVibrationConfig.NativeFieldInfoPtr_leftMotorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickCurvedVibrationConfig>.NativeClassPtr, nameof (leftMotorCurve));
    JoystickCurvedVibrationConfig.NativeFieldInfoPtr_rightMotorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickCurvedVibrationConfig>.NativeClassPtr, nameof (rightMotorCurve));
    JoystickCurvedVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickCurvedVibrationConfig>.NativeClassPtr, 100670609);
    JoystickCurvedVibrationConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickCurvedVibrationConfig>.NativeClassPtr, 100670610);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86615, XrefRangeEnd = 86622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CallVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JoystickCurvedVibrationConfig.NativeMethodInfoPtr_CallVibration_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86622, XrefRangeEnd = 86625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickCurvedVibrationConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickCurvedVibrationConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickCurvedVibrationConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve leftMotorCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickCurvedVibrationConfig.NativeFieldInfoPtr_leftMotorCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickCurvedVibrationConfig.NativeFieldInfoPtr_leftMotorCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve rightMotorCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickCurvedVibrationConfig.NativeFieldInfoPtr_rightMotorCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickCurvedVibrationConfig.NativeFieldInfoPtr_rightMotorCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
