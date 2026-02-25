// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.WhiteBalanceParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct WhiteBalanceParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_temperature;
  private static readonly System.IntPtr NativeFieldInfoPtr_tint;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
  [FieldOffset(0)]
  public readonly float temperature;
  [FieldOffset(4)]
  public readonly float tint;

  static WhiteBalanceParams()
  {
    Il2CppClassPointerStore<WhiteBalanceParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (WhiteBalanceParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhiteBalanceParams>.NativeClassPtr);
    WhiteBalanceParams.NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceParams>.NativeClassPtr, nameof (temperature));
    WhiteBalanceParams.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceParams>.NativeClassPtr, nameof (tint));
    WhiteBalanceParams.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalanceParams>.NativeClassPtr, 100663641);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 21792, RefRangeEnd = 21797, XrefRangeStart = 21792, XrefRangeEnd = 21797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WhiteBalanceParams(float temperature, float tint)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &temperature;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tint;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WhiteBalanceParams.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WhiteBalanceParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
