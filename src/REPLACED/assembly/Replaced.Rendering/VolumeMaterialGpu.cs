// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumeMaterialGpu
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VolumeMaterialGpu
{
  private static readonly System.IntPtr NativeFieldInfoPtr_albedo;
  private static readonly System.IntPtr NativeFieldInfoPtr_extinction;
  private static readonly System.IntPtr NativeFieldInfoPtr_anisotropy;
  [FieldOffset(0)]
  public Vector3 albedo;
  [FieldOffset(12)]
  public float extinction;
  [FieldOffset(16 /*0x10*/)]
  public float anisotropy;

  static VolumeMaterialGpu()
  {
    Il2CppClassPointerStore<VolumeMaterialGpu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumeMaterialGpu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeMaterialGpu>.NativeClassPtr);
    VolumeMaterialGpu.NativeFieldInfoPtr_albedo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeMaterialGpu>.NativeClassPtr, nameof (albedo));
    VolumeMaterialGpu.NativeFieldInfoPtr_extinction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeMaterialGpu>.NativeClassPtr, nameof (extinction));
    VolumeMaterialGpu.NativeFieldInfoPtr_anisotropy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeMaterialGpu>.NativeClassPtr, nameof (anisotropy));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeMaterialGpu>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
