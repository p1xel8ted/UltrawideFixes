// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PixelizationParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct PixelizationParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_resolution;
  private static readonly System.IntPtr NativeFieldInfoPtr_posterizationLevels;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Int32_0;
  [FieldOffset(0)]
  public readonly Vector2Int resolution;
  [FieldOffset(8)]
  public readonly int posterizationLevels;

  static PixelizationParams()
  {
    Il2CppClassPointerStore<PixelizationParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PixelizationParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelizationParams>.NativeClassPtr);
    PixelizationParams.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationParams>.NativeClassPtr, nameof (resolution));
    PixelizationParams.NativeFieldInfoPtr_posterizationLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationParams>.NativeClassPtr, nameof (posterizationLevels));
    PixelizationParams.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelizationParams>.NativeClassPtr, 100663610);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926842, RefRangeEnd = 926844, XrefRangeStart = 926840, XrefRangeEnd = 926842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PixelizationParams(Vector2 resolution, int posterizationLevels)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &resolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &posterizationLevels;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PixelizationParams.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PixelizationParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
