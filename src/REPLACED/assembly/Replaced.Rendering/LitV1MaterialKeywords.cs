// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LitV1MaterialKeywords
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public static class LitV1MaterialKeywords : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kUvctUnifiedPixelArt;
  private static readonly System.IntPtr NativeFieldInfoPtr_kUvctSeparatePixelArt;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_kAlphaTest;
  private static readonly System.IntPtr NativeFieldInfoPtr_kAlphaBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_kAlphaPhysicallyPlausible;
  private static readonly System.IntPtr NativeFieldInfoPtr_kEmission;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDevdbgMaterialShaderOutput;

  static LitV1MaterialKeywords()
  {
    Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LitV1MaterialKeywords));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr);
    LitV1MaterialKeywords.NativeFieldInfoPtr_kUvctUnifiedPixelArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kUvctUnifiedPixelArt));
    LitV1MaterialKeywords.NativeFieldInfoPtr_kUvctSeparatePixelArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kUvctSeparatePixelArt));
    LitV1MaterialKeywords.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kSmoothnessTexSpecularAlpha));
    LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kAlphaTest));
    LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kAlphaBlend));
    LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaPhysicallyPlausible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kAlphaPhysicallyPlausible));
    LitV1MaterialKeywords.NativeFieldInfoPtr_kEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kEmission));
    LitV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LitV1MaterialKeywords>.NativeClassPtr, nameof (kDevdbgMaterialShaderOutput));
  }

  public LitV1MaterialKeywords(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kUvctUnifiedPixelArt
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kUvctUnifiedPixelArt, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kUvctUnifiedPixelArt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kUvctSeparatePixelArt
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kUvctSeparatePixelArt, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kUvctSeparatePixelArt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kSmoothnessTexSpecularAlpha
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kAlphaTest
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaTest, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaTest, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kAlphaBlend
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaBlend, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaBlend, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kAlphaPhysicallyPlausible
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaPhysicallyPlausible, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kAlphaPhysicallyPlausible, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kEmission
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kEmission, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kEmission, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kDevdbgMaterialShaderOutput
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LitV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
