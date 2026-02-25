// Decompiled with JetBrains decompiler
// Type: GdkPlatformSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
public static class GdkPlatformSettings : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_gameConfigTitleId;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameConfigScid;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameConfigSandbox;

  static GdkPlatformSettings()
  {
    Il2CppClassPointerStore<GdkPlatformSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GdkPlatformSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GdkPlatformSettings>.NativeClassPtr);
    GdkPlatformSettings.NativeFieldInfoPtr_gameConfigTitleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GdkPlatformSettings>.NativeClassPtr, nameof (gameConfigTitleId));
    GdkPlatformSettings.NativeFieldInfoPtr_gameConfigScid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GdkPlatformSettings>.NativeClassPtr, nameof (gameConfigScid));
    GdkPlatformSettings.NativeFieldInfoPtr_gameConfigSandbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GdkPlatformSettings>.NativeClassPtr, nameof (gameConfigSandbox));
  }

  public GdkPlatformSettings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string gameConfigTitleId
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GdkPlatformSettings.NativeFieldInfoPtr_gameConfigTitleId, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GdkPlatformSettings.NativeFieldInfoPtr_gameConfigTitleId, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string gameConfigScid
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GdkPlatformSettings.NativeFieldInfoPtr_gameConfigScid, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GdkPlatformSettings.NativeFieldInfoPtr_gameConfigScid, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string gameConfigSandbox
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GdkPlatformSettings.NativeFieldInfoPtr_gameConfigSandbox, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GdkPlatformSettings.NativeFieldInfoPtr_gameConfigSandbox, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
