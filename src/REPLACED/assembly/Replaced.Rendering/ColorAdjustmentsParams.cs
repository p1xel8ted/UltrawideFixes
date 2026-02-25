// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ColorAdjustmentsParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ColorAdjustmentsParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_postExposure;
  private static readonly System.IntPtr NativeFieldInfoPtr_contrast;
  private static readonly System.IntPtr NativeFieldInfoPtr_hueShift;
  private static readonly System.IntPtr NativeFieldInfoPtr_saturation;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  [FieldOffset(0)]
  public readonly float postExposure;
  [FieldOffset(4)]
  public readonly float contrast;
  [FieldOffset(8)]
  public readonly float hueShift;
  [FieldOffset(12)]
  public readonly float saturation;

  static ColorAdjustmentsParams()
  {
    Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ColorAdjustmentsParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr);
    ColorAdjustmentsParams.NativeFieldInfoPtr_postExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr, nameof (postExposure));
    ColorAdjustmentsParams.NativeFieldInfoPtr_contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr, nameof (contrast));
    ColorAdjustmentsParams.NativeFieldInfoPtr_hueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr, nameof (hueShift));
    ColorAdjustmentsParams.NativeFieldInfoPtr_saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr, nameof (saturation));
    ColorAdjustmentsParams.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr, 100663636);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 245806, RefRangeEnd = 245814, XrefRangeStart = 245806, XrefRangeEnd = 245814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColorAdjustmentsParams(
    float postExposure,
    float contrast,
    float hueShift,
    float saturation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &postExposure;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contrast;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hueShift;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &saturation;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ColorAdjustmentsParams.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorAdjustmentsParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
