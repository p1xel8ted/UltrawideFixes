// Decompiled with JetBrains decompiler
// Type: UnityEngine.Internal.InternalHDROutputFaking
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Internal;

public static class InternalHDROutputFaking
{
  private static readonly InternalHDROutputFaking.SetEnabledDelegate SetEnabledDelegateField = IL2CPP.ResolveICall<InternalHDROutputFaking.SetEnabledDelegate>("UnityEngine.Internal.InternalHDROutputFaking::SetEnabled");

  public static void SetEnabled(bool enabled)
  {
    InternalHDROutputFaking.SetEnabledDelegateField(enabled);
  }

  private delegate void SetEnabledDelegate(bool enabled);
}
