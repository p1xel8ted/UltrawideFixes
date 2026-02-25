// Decompiled with JetBrains decompiler
// Type: UnityEngine.ColorGamutUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine;

public class ColorGamutUtility(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0;

  static ColorGamutUtility()
  {
    Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ColorGamutUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr);
    ColorGamutUtility.NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664802);
    ColorGamutUtility.NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664803);
    ColorGamutUtility.NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664804);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423825, RefRangeEnd = 423826, XrefRangeStart = 423823, XrefRangeEnd = 423825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ColorPrimaries GetColorPrimaries(ColorGamut gamut)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &gamut
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ColorPrimaries*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423828, RefRangeEnd = 423829, XrefRangeStart = 423826, XrefRangeEnd = 423828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe WhitePoint GetWhitePoint(ColorGamut gamut)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &gamut
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(WhitePoint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423831, RefRangeEnd = 423832, XrefRangeStart = 423829, XrefRangeEnd = 423831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TransferFunction GetTransferFunction(ColorGamut gamut)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &gamut
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TransferFunction*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
