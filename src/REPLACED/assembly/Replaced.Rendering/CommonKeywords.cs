// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CommonKeywords
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public static class CommonKeywords : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kDevDbgShowBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kReceiveShadowsOff;

  static CommonKeywords()
  {
    Il2CppClassPointerStore<CommonKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CommonKeywords));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonKeywords>.NativeClassPtr);
    CommonKeywords.NativeFieldInfoPtr_kDevDbgShowBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonKeywords>.NativeClassPtr, nameof (kDevDbgShowBaseColor));
    CommonKeywords.NativeFieldInfoPtr_kReceiveShadowsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonKeywords>.NativeClassPtr, nameof (kReceiveShadowsOff));
  }

  public CommonKeywords(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kDevDbgShowBaseColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CommonKeywords.NativeFieldInfoPtr_kDevDbgShowBaseColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CommonKeywords.NativeFieldInfoPtr_kDevDbgShowBaseColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kReceiveShadowsOff
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CommonKeywords.NativeFieldInfoPtr_kReceiveShadowsOff, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CommonKeywords.NativeFieldInfoPtr_kReceiveShadowsOff, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
