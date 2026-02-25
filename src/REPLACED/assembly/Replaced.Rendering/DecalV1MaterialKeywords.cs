// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalV1MaterialKeywords
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public static class DecalV1MaterialKeywords : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_kUvctPixelArt;

  static DecalV1MaterialKeywords()
  {
    Il2CppClassPointerStore<DecalV1MaterialKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalV1MaterialKeywords));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalV1MaterialKeywords>.NativeClassPtr);
    DecalV1MaterialKeywords.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalV1MaterialKeywords>.NativeClassPtr, nameof (kSmoothnessTexSpecularAlpha));
    DecalV1MaterialKeywords.NativeFieldInfoPtr_kUvctPixelArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalV1MaterialKeywords>.NativeClassPtr, nameof (kUvctPixelArt));
  }

  public DecalV1MaterialKeywords(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kSmoothnessTexSpecularAlpha
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalV1MaterialKeywords.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalV1MaterialKeywords.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kUvctPixelArt
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalV1MaterialKeywords.NativeFieldInfoPtr_kUvctPixelArt, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalV1MaterialKeywords.NativeFieldInfoPtr_kUvctPixelArt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
