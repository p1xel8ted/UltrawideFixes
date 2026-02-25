// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FinalBlitCBufferData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct FinalBlitCBufferData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_bloomIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_lutUvwScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_lutUvwOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_postExposure;
  private static readonly System.IntPtr NativeFieldInfoPtr_vignetteColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_vignetteScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_vignetteOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_distortionIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_distortionDistanceScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_padding;
  private static readonly System.IntPtr NativeFieldInfoPtr_fgParams;
  private static readonly System.IntPtr NativeFieldInfoPtr_fgRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_fgUvScaleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_errorFillColor;
  [FieldOffset(0)]
  public float bloomIntensity;
  [FieldOffset(4)]
  public float lutUvwScale;
  [FieldOffset(8)]
  public float lutUvwOffset;
  [FieldOffset(12)]
  public float postExposure;
  [FieldOffset(16 /*0x10*/)]
  public Vector3 vignetteColor;
  [FieldOffset(28)]
  public float vignetteScale;
  [FieldOffset(32 /*0x20*/)]
  public float vignetteOffset;
  [FieldOffset(36)]
  public float distortionIntensity;
  [FieldOffset(40)]
  public float distortionDistanceScale;
  [FieldOffset(44)]
  public float padding;
  [FieldOffset(48 /*0x30*/)]
  public Vector4 fgParams;
  [FieldOffset(64 /*0x40*/)]
  public Vector4 fgRange;
  [FieldOffset(80 /*0x50*/)]
  public Vector4 fgUvScaleOffset;
  [FieldOffset(96 /*0x60*/)]
  public Vector4 errorFillColor;

  static FinalBlitCBufferData()
  {
    Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FinalBlitCBufferData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr);
    FinalBlitCBufferData.NativeFieldInfoPtr_bloomIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (bloomIntensity));
    FinalBlitCBufferData.NativeFieldInfoPtr_lutUvwScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (lutUvwScale));
    FinalBlitCBufferData.NativeFieldInfoPtr_lutUvwOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (lutUvwOffset));
    FinalBlitCBufferData.NativeFieldInfoPtr_postExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (postExposure));
    FinalBlitCBufferData.NativeFieldInfoPtr_vignetteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (vignetteColor));
    FinalBlitCBufferData.NativeFieldInfoPtr_vignetteScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (vignetteScale));
    FinalBlitCBufferData.NativeFieldInfoPtr_vignetteOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (vignetteOffset));
    FinalBlitCBufferData.NativeFieldInfoPtr_distortionIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (distortionIntensity));
    FinalBlitCBufferData.NativeFieldInfoPtr_distortionDistanceScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (distortionDistanceScale));
    FinalBlitCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (padding));
    FinalBlitCBufferData.NativeFieldInfoPtr_fgParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (fgParams));
    FinalBlitCBufferData.NativeFieldInfoPtr_fgRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (fgRange));
    FinalBlitCBufferData.NativeFieldInfoPtr_fgUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (fgUvScaleOffset));
    FinalBlitCBufferData.NativeFieldInfoPtr_errorFillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, nameof (errorFillColor));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalBlitCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
