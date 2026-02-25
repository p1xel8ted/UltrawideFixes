// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LensDistortionParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct LensDistortionParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
  [FieldOffset(0)]
  public readonly float intensity;

  static LensDistortionParams()
  {
    Il2CppClassPointerStore<LensDistortionParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LensDistortionParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensDistortionParams>.NativeClassPtr);
    LensDistortionParams.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortionParams>.NativeClassPtr, nameof (intensity));
    LensDistortionParams.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortionParams>.NativeClassPtr, 100663643);
  }

  [CallerCount(43)]
  [CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LensDistortionParams(float intensity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &intensity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LensDistortionParams.NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LensDistortionParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
