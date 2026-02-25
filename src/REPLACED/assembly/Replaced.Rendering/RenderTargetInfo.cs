// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.RenderTargetInfo
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RenderTargetInfo
{
  private static readonly System.IntPtr NativeFieldInfoPtr_fullSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_cropOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_cropSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_whAspect;
  private static readonly System.IntPtr NativeFieldInfoPtr_noCrop;
  [FieldOffset(0)]
  public Vector2Int fullSize;
  [FieldOffset(8)]
  public Vector2Int cropOffset;
  [FieldOffset(16 /*0x10*/)]
  public Vector2Int cropSize;
  [FieldOffset(24)]
  public float whAspect;
  [FieldOffset(28)]
  public bool noCrop;

  static RenderTargetInfo()
  {
    Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (RenderTargetInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr);
    RenderTargetInfo.NativeFieldInfoPtr_fullSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, nameof (fullSize));
    RenderTargetInfo.NativeFieldInfoPtr_cropOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, nameof (cropOffset));
    RenderTargetInfo.NativeFieldInfoPtr_cropSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, nameof (cropSize));
    RenderTargetInfo.NativeFieldInfoPtr_whAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, nameof (whAspect));
    RenderTargetInfo.NativeFieldInfoPtr_noCrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, nameof (noCrop));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
