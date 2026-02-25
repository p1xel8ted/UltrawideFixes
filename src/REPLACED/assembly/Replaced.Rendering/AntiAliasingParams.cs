// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.AntiAliasingParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AntiAliasingParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_subpixelOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_sigmaMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_antiflicker;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Vector2_Single_Single_0;
  [FieldOffset(0)]
  public readonly bool on;
  [FieldOffset(4)]
  public readonly Vector2 subpixelOffset;
  [FieldOffset(12)]
  public readonly float sigmaMultiplier;
  [FieldOffset(16 /*0x10*/)]
  public readonly float antiflicker;

  static AntiAliasingParams()
  {
    Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (AntiAliasingParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr);
    AntiAliasingParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr, nameof (on));
    AntiAliasingParams.NativeFieldInfoPtr_subpixelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr, nameof (subpixelOffset));
    AntiAliasingParams.NativeFieldInfoPtr_sigmaMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr, nameof (sigmaMultiplier));
    AntiAliasingParams.NativeFieldInfoPtr_antiflicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr, nameof (antiflicker));
    AntiAliasingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr, 100663627);
  }

  [CallerCount(0)]
  public unsafe AntiAliasingParams(
    bool on,
    Vector2 subpixelOffset,
    float sigmaMultiplier,
    float antiflicker)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &on;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &subpixelOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sigmaMultiplier;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &antiflicker;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiAliasingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Vector2_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntiAliasingParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
