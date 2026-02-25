// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ResolveMsaaCBuffer
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ResolveMsaaCBuffer
{
  private static readonly System.IntPtr NativeFieldInfoPtr_texelSize;
  [FieldOffset(0)]
  public Vector4 texelSize;

  static ResolveMsaaCBuffer()
  {
    Il2CppClassPointerStore<ResolveMsaaCBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ResolveMsaaCBuffer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveMsaaCBuffer>.NativeClassPtr);
    ResolveMsaaCBuffer.NativeFieldInfoPtr_texelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaCBuffer>.NativeClassPtr, nameof (texelSize));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResolveMsaaCBuffer>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
