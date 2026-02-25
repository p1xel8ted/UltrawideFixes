// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CloudV1MaterialKeywords
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public static class CloudV1MaterialKeywords : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kDevdbgMaterialShaderOutput;

  static CloudV1MaterialKeywords()
  {
    Il2CppClassPointerStore<CloudV1MaterialKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CloudV1MaterialKeywords));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudV1MaterialKeywords>.NativeClassPtr);
    CloudV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudV1MaterialKeywords>.NativeClassPtr, nameof (kDevdbgMaterialShaderOutput));
  }

  public CloudV1MaterialKeywords(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kDevdbgMaterialShaderOutput
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CloudV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CloudV1MaterialKeywords.NativeFieldInfoPtr_kDevdbgMaterialShaderOutput, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
