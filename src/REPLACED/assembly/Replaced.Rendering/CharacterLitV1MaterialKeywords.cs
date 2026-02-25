// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CharacterLitV1MaterialKeywords
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public static class CharacterLitV1MaterialKeywords : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTransmittance;
  private static readonly System.IntPtr NativeFieldInfoPtr_kAffectedByDecals;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPaletteColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDevdbgShaderOutput;

  static CharacterLitV1MaterialKeywords()
  {
    Il2CppClassPointerStore<CharacterLitV1MaterialKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CharacterLitV1MaterialKeywords));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterLitV1MaterialKeywords>.NativeClassPtr);
    CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kTransmittance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLitV1MaterialKeywords>.NativeClassPtr, nameof (kTransmittance));
    CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kAffectedByDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLitV1MaterialKeywords>.NativeClassPtr, nameof (kAffectedByDecals));
    CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kPaletteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLitV1MaterialKeywords>.NativeClassPtr, nameof (kPaletteColor));
    CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgShaderOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLitV1MaterialKeywords>.NativeClassPtr, nameof (kDevdbgShaderOutput));
  }

  public CharacterLitV1MaterialKeywords(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kTransmittance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kTransmittance, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kTransmittance, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kAffectedByDecals
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kAffectedByDecals, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kAffectedByDecals, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPaletteColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kPaletteColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kPaletteColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kDevdbgShaderOutput
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgShaderOutput, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterLitV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgShaderOutput, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
