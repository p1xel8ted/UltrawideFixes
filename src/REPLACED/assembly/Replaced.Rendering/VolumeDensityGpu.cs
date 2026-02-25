// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumeDensityGpu
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VolumeDensityGpu
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rightWsOverLen;
  private static readonly System.IntPtr NativeFieldInfoPtr_upWsOverLen;
  private static readonly System.IntPtr NativeFieldInfoPtr_forwardWsOverLen;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionDotAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_densityTop;
  private static readonly System.IntPtr NativeFieldInfoPtr_densityBottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_densityFadeToCenter;
  [FieldOffset(0)]
  public Vector3 rightWsOverLen;
  [FieldOffset(12)]
  public Vector3 upWsOverLen;
  [FieldOffset(24)]
  public Vector3 forwardWsOverLen;
  [FieldOffset(36)]
  public Vector3 positionDotAxis;
  [FieldOffset(48 /*0x30*/)]
  public float densityTop;
  [FieldOffset(52)]
  public float densityBottom;
  [FieldOffset(56)]
  public float densityFadeToCenter;

  static VolumeDensityGpu()
  {
    Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumeDensityGpu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr);
    VolumeDensityGpu.NativeFieldInfoPtr_rightWsOverLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, nameof (rightWsOverLen));
    VolumeDensityGpu.NativeFieldInfoPtr_upWsOverLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, nameof (upWsOverLen));
    VolumeDensityGpu.NativeFieldInfoPtr_forwardWsOverLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, nameof (forwardWsOverLen));
    VolumeDensityGpu.NativeFieldInfoPtr_positionDotAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, nameof (positionDotAxis));
    VolumeDensityGpu.NativeFieldInfoPtr_densityTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, nameof (densityTop));
    VolumeDensityGpu.NativeFieldInfoPtr_densityBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, nameof (densityBottom));
    VolumeDensityGpu.NativeFieldInfoPtr_densityFadeToCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, nameof (densityFadeToCenter));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeDensityGpu>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
