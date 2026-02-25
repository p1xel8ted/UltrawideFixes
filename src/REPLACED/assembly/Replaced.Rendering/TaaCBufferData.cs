// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.TaaCBufferData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct TaaCBufferData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_texCoordToUv;
  private static readonly System.IntPtr NativeFieldInfoPtr_sigmaMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_antiflickerMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_texSize;
  [FieldOffset(0)]
  public Vector4 texCoordToUv;
  [FieldOffset(16 /*0x10*/)]
  public float sigmaMultiplier;
  [FieldOffset(20)]
  public float antiflickerMultiplier;
  [FieldOffset(24)]
  public Vector2 texSize;

  static TaaCBufferData()
  {
    Il2CppClassPointerStore<TaaCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (TaaCBufferData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaCBufferData>.NativeClassPtr);
    TaaCBufferData.NativeFieldInfoPtr_texCoordToUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaCBufferData>.NativeClassPtr, nameof (texCoordToUv));
    TaaCBufferData.NativeFieldInfoPtr_sigmaMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaCBufferData>.NativeClassPtr, nameof (sigmaMultiplier));
    TaaCBufferData.NativeFieldInfoPtr_antiflickerMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaCBufferData>.NativeClassPtr, nameof (antiflickerMultiplier));
    TaaCBufferData.NativeFieldInfoPtr_texSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaCBufferData>.NativeClassPtr, nameof (texSize));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaaCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
