// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PresentToCameraRTMaterialKeywords
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public static class PresentToCameraRTMaterialKeywords : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kFilmGrain;
  private static readonly System.IntPtr NativeFieldInfoPtr_kKeywordReverseYFlip;

  static PresentToCameraRTMaterialKeywords()
  {
    Il2CppClassPointerStore<PresentToCameraRTMaterialKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PresentToCameraRTMaterialKeywords));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentToCameraRTMaterialKeywords>.NativeClassPtr);
    PresentToCameraRTMaterialKeywords.NativeFieldInfoPtr_kFilmGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTMaterialKeywords>.NativeClassPtr, nameof (kFilmGrain));
    PresentToCameraRTMaterialKeywords.NativeFieldInfoPtr_kKeywordReverseYFlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTMaterialKeywords>.NativeClassPtr, nameof (kKeywordReverseYFlip));
  }

  public PresentToCameraRTMaterialKeywords(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kFilmGrain
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(PresentToCameraRTMaterialKeywords.NativeFieldInfoPtr_kFilmGrain, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresentToCameraRTMaterialKeywords.NativeFieldInfoPtr_kFilmGrain, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kKeywordReverseYFlip
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(PresentToCameraRTMaterialKeywords.NativeFieldInfoPtr_kKeywordReverseYFlip, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresentToCameraRTMaterialKeywords.NativeFieldInfoPtr_kKeywordReverseYFlip, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
