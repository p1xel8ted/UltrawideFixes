// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.LoadStoreActionDebugModeSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Rendering;

public static class LoadStoreActionDebugModeSettings
{
  private static readonly LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegate get_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::get_LoadStoreDebugModeEnabled");
  private static readonly LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegate set_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::set_LoadStoreDebugModeEnabled");

  public static bool LoadStoreDebugModeEnabled
  {
    get => LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegateField();
    set => LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegateField(value);
  }

  private delegate bool get_LoadStoreDebugModeEnabledDelegate();

  private delegate void set_LoadStoreDebugModeEnabledDelegate(bool value);
}
