// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ColorGradingLutCBufferData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ColorGradingLutCBufferData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lutTexelScaleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_whiteBalance;
  private static readonly System.IntPtr NativeFieldInfoPtr_channelMixerRed;
  private static readonly System.IntPtr NativeFieldInfoPtr_channelMixerGreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_channelMixerBlue;
  private static readonly System.IntPtr NativeFieldInfoPtr_smhLimits;
  private static readonly System.IntPtr NativeFieldInfoPtr_smhShadows;
  private static readonly System.IntPtr NativeFieldInfoPtr_smhMidtones;
  private static readonly System.IntPtr NativeFieldInfoPtr_smhHighlights;
  private static readonly System.IntPtr NativeFieldInfoPtr_oggOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_oggGamma;
  private static readonly System.IntPtr NativeFieldInfoPtr_oggGain;
  private static readonly System.IntPtr NativeFieldInfoPtr_hueSatContrast;
  [FieldOffset(0)]
  public Vector4 lutTexelScaleOffset;
  [FieldOffset(16 /*0x10*/)]
  public Vector4 whiteBalance;
  [FieldOffset(32 /*0x20*/)]
  public Vector4 channelMixerRed;
  [FieldOffset(48 /*0x30*/)]
  public Vector4 channelMixerGreen;
  [FieldOffset(64 /*0x40*/)]
  public Vector4 channelMixerBlue;
  [FieldOffset(80 /*0x50*/)]
  public Vector4 smhLimits;
  [FieldOffset(96 /*0x60*/)]
  public Vector4 smhShadows;
  [FieldOffset(112 /*0x70*/)]
  public Vector4 smhMidtones;
  [FieldOffset(128 /*0x80*/)]
  public Vector4 smhHighlights;
  [FieldOffset(144 /*0x90*/)]
  public Vector4 oggOffset;
  [FieldOffset(160 /*0xA0*/)]
  public Vector4 oggGamma;
  [FieldOffset(176 /*0xB0*/)]
  public Vector4 oggGain;
  [FieldOffset(192 /*0xC0*/)]
  public Vector4 hueSatContrast;

  static ColorGradingLutCBufferData()
  {
    Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ColorGradingLutCBufferData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr);
    ColorGradingLutCBufferData.NativeFieldInfoPtr_lutTexelScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (lutTexelScaleOffset));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_whiteBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (whiteBalance));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_channelMixerRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (channelMixerRed));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_channelMixerGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (channelMixerGreen));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_channelMixerBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (channelMixerBlue));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_smhLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (smhLimits));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_smhShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (smhShadows));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_smhMidtones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (smhMidtones));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_smhHighlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (smhHighlights));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_oggOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (oggOffset));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_oggGamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (oggGamma));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_oggGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (oggGain));
    ColorGradingLutCBufferData.NativeFieldInfoPtr_hueSatContrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, nameof (hueSatContrast));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingLutCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
