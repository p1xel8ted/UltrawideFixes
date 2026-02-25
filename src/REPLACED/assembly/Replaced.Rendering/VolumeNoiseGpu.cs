// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumeNoiseGpu
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VolumeNoiseGpu
{
  private static readonly System.IntPtr NativeFieldInfoPtr_curlNoiseScroll;
  private static readonly System.IntPtr NativeFieldInfoPtr_curlNoiseScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseNoiseTiling;
  private static readonly System.IntPtr NativeFieldInfoPtr_noiseInfluenceTop;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseNoiseScroll;
  private static readonly System.IntPtr NativeFieldInfoPtr_noiseInfluenceBottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalWScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalWOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalMipmapLevel;
  [FieldOffset(0)]
  public Vector3 curlNoiseScroll;
  [FieldOffset(12)]
  public float curlNoiseScale;
  [FieldOffset(16 /*0x10*/)]
  public Vector3 baseNoiseTiling;
  [FieldOffset(28)]
  public float noiseInfluenceTop;
  [FieldOffset(32 /*0x20*/)]
  public Vector3 baseNoiseScroll;
  [FieldOffset(44)]
  public float noiseInfluenceBottom;
  [FieldOffset(48 /*0x30*/)]
  public float finalWScale;
  [FieldOffset(52)]
  public float finalWOffset;
  [FieldOffset(56)]
  public float finalMipmapLevel;

  static VolumeNoiseGpu()
  {
    Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumeNoiseGpu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr);
    VolumeNoiseGpu.NativeFieldInfoPtr_curlNoiseScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (curlNoiseScroll));
    VolumeNoiseGpu.NativeFieldInfoPtr_curlNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (curlNoiseScale));
    VolumeNoiseGpu.NativeFieldInfoPtr_baseNoiseTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (baseNoiseTiling));
    VolumeNoiseGpu.NativeFieldInfoPtr_noiseInfluenceTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (noiseInfluenceTop));
    VolumeNoiseGpu.NativeFieldInfoPtr_baseNoiseScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (baseNoiseScroll));
    VolumeNoiseGpu.NativeFieldInfoPtr_noiseInfluenceBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (noiseInfluenceBottom));
    VolumeNoiseGpu.NativeFieldInfoPtr_finalWScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (finalWScale));
    VolumeNoiseGpu.NativeFieldInfoPtr_finalWOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (finalWOffset));
    VolumeNoiseGpu.NativeFieldInfoPtr_finalMipmapLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, nameof (finalMipmapLevel));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeNoiseGpu>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
