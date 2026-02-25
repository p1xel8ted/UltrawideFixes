// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Config
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices;

public static class Config : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_LibraryName;
  private static readonly System.IntPtr NativeFieldInfoPtr_LibraryCallingConvention;

  static Config()
  {
    Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (Config));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
    Config.NativeFieldInfoPtr_LibraryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, nameof (LibraryName));
    Config.NativeFieldInfoPtr_LibraryCallingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, nameof (LibraryCallingConvention));
  }

  public Config(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string LibraryName
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_LibraryName, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_LibraryName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe CallingConvention LibraryCallingConvention
  {
    get
    {
      CallingConvention callingConvention;
      IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_LibraryCallingConvention, (void*) &callingConvention);
      return callingConvention;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_LibraryCallingConvention, (void*) &value);
    }
  }
}
