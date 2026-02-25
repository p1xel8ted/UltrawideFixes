// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ToneMappingParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ToneMappingParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
  [FieldOffset(0)]
  public readonly bool on;

  static ToneMappingParams()
  {
    Il2CppClassPointerStore<ToneMappingParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ToneMappingParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToneMappingParams>.NativeClassPtr);
    ToneMappingParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToneMappingParams>.NativeClassPtr, nameof (on));
    ToneMappingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToneMappingParams>.NativeClassPtr, 100663640);
  }

  [CallerCount(0)]
  public unsafe ToneMappingParams(bool on)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &on
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ToneMappingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ToneMappingParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
