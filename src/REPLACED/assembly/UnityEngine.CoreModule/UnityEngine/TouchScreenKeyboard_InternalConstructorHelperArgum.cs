// Decompiled with JetBrains decompiler
// Type: UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct TouchScreenKeyboard_InternalConstructorHelperArguments
{
  private static readonly System.IntPtr NativeFieldInfoPtr_keyboardType;
  private static readonly System.IntPtr NativeFieldInfoPtr_autocorrection;
  private static readonly System.IntPtr NativeFieldInfoPtr_multiline;
  private static readonly System.IntPtr NativeFieldInfoPtr_secure;
  private static readonly System.IntPtr NativeFieldInfoPtr_alert;
  private static readonly System.IntPtr NativeFieldInfoPtr_characterLimit;
  [FieldOffset(0)]
  public uint keyboardType;
  [FieldOffset(4)]
  public uint autocorrection;
  [FieldOffset(8)]
  public uint multiline;
  [FieldOffset(12)]
  public uint secure;
  [FieldOffset(16 /*0x10*/)]
  public uint alert;
  [FieldOffset(20)]
  public int characterLimit;

  static TouchScreenKeyboard_InternalConstructorHelperArguments()
  {
    Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TouchScreenKeyboard_InternalConstructorHelperArguments));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr);
    TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_keyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, nameof (keyboardType));
    TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_autocorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, nameof (autocorrection));
    TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, nameof (multiline));
    TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, nameof (secure));
    TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, nameof (alert));
    TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_characterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, nameof (characterLimit));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
