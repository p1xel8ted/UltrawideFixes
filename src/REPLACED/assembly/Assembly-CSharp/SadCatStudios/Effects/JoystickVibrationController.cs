// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.JoystickVibrationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Configs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Effects;

public class JoystickVibrationController(IntPtr pointer) : 
  GlobalSingletonBehaviour<JoystickVibrationController>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_Vibrate_Public_Void_JoystickVibrationConfig_0;
  private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JoystickVibrationController()
  {
    Il2CppClassPointerStore<JoystickVibrationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (JoystickVibrationController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickVibrationController>.NativeClassPtr);
    JoystickVibrationController.NativeMethodInfoPtr_Vibrate_Public_Void_JoystickVibrationConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickVibrationController>.NativeClassPtr, 100675725);
    JoystickVibrationController.NativeMethodInfoPtr_StopVibration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickVibrationController>.NativeClassPtr, 100675726);
    JoystickVibrationController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickVibrationController>.NativeClassPtr, 100675727);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 119109, RefRangeEnd = 119110, XrefRangeStart = 119108, XrefRangeEnd = 119109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Vibrate(JoystickVibrationConfig config)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) config)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickVibrationController.NativeMethodInfoPtr_Vibrate_Public_Void_JoystickVibrationConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119110, XrefRangeEnd = 119115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickVibrationController.NativeMethodInfoPtr_StopVibration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119115, XrefRangeEnd = 119118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickVibrationController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickVibrationController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoystickVibrationController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
