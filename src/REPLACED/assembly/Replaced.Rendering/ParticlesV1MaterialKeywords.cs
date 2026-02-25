// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ParticlesV1MaterialKeywords
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public static class ParticlesV1MaterialKeywords : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kFlipbookBlending;
  private static readonly System.IntPtr NativeFieldInfoPtr_kAlphaTest;
  private static readonly System.IntPtr NativeFieldInfoPtr_kAlphaBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSoftParticles;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCameraFade;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDistortion;

  static ParticlesV1MaterialKeywords()
  {
    Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ParticlesV1MaterialKeywords));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr);
    ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kFlipbookBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (kFlipbookBlending));
    ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kAlphaTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (kAlphaTest));
    ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kAlphaBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (kAlphaBlend));
    ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kSoftParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (kSoftParticles));
    ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kCameraFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (kCameraFade));
    ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (kDistortion));
  }

  public ParticlesV1MaterialKeywords(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kFlipbookBlending
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kFlipbookBlending, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kFlipbookBlending, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kAlphaTest
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kAlphaTest, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kAlphaTest, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kAlphaBlend
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kAlphaBlend, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kAlphaBlend, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kSoftParticles
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kSoftParticles, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kSoftParticles, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kCameraFade
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kCameraFade, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kCameraFade, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kDistortion
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kDistortion, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.NativeFieldInfoPtr_kDistortion, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static class Lit : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_kUvctUnifiedPixelArt;
    private static readonly System.IntPtr NativeFieldInfoPtr_kUvctSeparatePixelArt;
    private static readonly System.IntPtr NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_kEmission;
    private static readonly System.IntPtr NativeFieldInfoPtr_kBlendModeMultiply;
    private static readonly System.IntPtr NativeFieldInfoPtr_kDevdbgMaterialShaderOutput;
    private static readonly System.IntPtr NativeFieldInfoPtr_kLightingModelGiOnly;
    private static readonly System.IntPtr NativeFieldInfoPtr_kLightingModelFull;

    static Lit()
    {
      Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (Lit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr);
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kUvctUnifiedPixelArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kUvctUnifiedPixelArt));
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kUvctSeparatePixelArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kUvctSeparatePixelArt));
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kSmoothnessTexSpecularAlpha));
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kEmission));
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kBlendModeMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kBlendModeMultiply));
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kDevdbgMaterialShaderOutput));
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kLightingModelGiOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kLightingModelGiOnly));
      ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kLightingModelFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Lit>.NativeClassPtr, nameof (kLightingModelFull));
    }

    public Lit(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string kUvctUnifiedPixelArt
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kUvctUnifiedPixelArt, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kUvctUnifiedPixelArt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kUvctSeparatePixelArt
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kUvctSeparatePixelArt, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kUvctSeparatePixelArt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kSmoothnessTexSpecularAlpha
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kSmoothnessTexSpecularAlpha, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kEmission
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kEmission, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kEmission, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kBlendModeMultiply
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kBlendModeMultiply, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kBlendModeMultiply, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kDevdbgMaterialShaderOutput
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kLightingModelGiOnly
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kLightingModelGiOnly, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kLightingModelGiOnly, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kLightingModelFull
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kLightingModelFull, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Lit.NativeFieldInfoPtr_kLightingModelFull, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  public static class Unlit : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_kUvctUnifiedPixelArt;
    private static readonly System.IntPtr NativeFieldInfoPtr_kUvctSeparatePixelArt;
    private static readonly System.IntPtr NativeFieldInfoPtr_kEmission;
    private static readonly System.IntPtr NativeFieldInfoPtr_kBlendModeMultiply;
    private static readonly System.IntPtr NativeFieldInfoPtr_kAffectedByVolumetric;
    private static readonly System.IntPtr NativeFieldInfoPtr_kDevdbgMaterialShaderOutput;

    static Unlit()
    {
      Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticlesV1MaterialKeywords>.NativeClassPtr, nameof (Unlit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr);
      ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kUvctUnifiedPixelArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr, nameof (kUvctUnifiedPixelArt));
      ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kUvctSeparatePixelArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr, nameof (kUvctSeparatePixelArt));
      ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr, nameof (kEmission));
      ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kBlendModeMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr, nameof (kBlendModeMultiply));
      ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kAffectedByVolumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr, nameof (kAffectedByVolumetric));
      ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesV1MaterialKeywords.Unlit>.NativeClassPtr, nameof (kDevdbgMaterialShaderOutput));
    }

    public Unlit(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string kUvctUnifiedPixelArt
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kUvctUnifiedPixelArt, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kUvctUnifiedPixelArt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kUvctSeparatePixelArt
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kUvctSeparatePixelArt, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kUvctSeparatePixelArt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kEmission
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kEmission, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kEmission, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kBlendModeMultiply
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kBlendModeMultiply, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kBlendModeMultiply, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kAffectedByVolumetric
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kAffectedByVolumetric, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kAffectedByVolumetric, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string kDevdbgMaterialShaderOutput
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlesV1MaterialKeywords.Unlit.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
