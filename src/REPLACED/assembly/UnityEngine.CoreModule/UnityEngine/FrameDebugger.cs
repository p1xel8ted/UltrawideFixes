// Decompiled with JetBrains decompiler
// Type: UnityEngine.FrameDebugger
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine;

public static class FrameDebugger
{
  private static readonly FrameDebugger.IsLocalEnabledDelegate IsLocalEnabledDelegateField = IL2CPP.ResolveICall<FrameDebugger.IsLocalEnabledDelegate>("UnityEngine.FrameDebugger::IsLocalEnabled");
  private static readonly FrameDebugger.IsRemoteEnabledDelegate IsRemoteEnabledDelegateField = IL2CPP.ResolveICall<FrameDebugger.IsRemoteEnabledDelegate>("UnityEngine.FrameDebugger::IsRemoteEnabled");

  public static bool enabled => FrameDebugger.IsLocalEnabled() || FrameDebugger.IsRemoteEnabled();

  public static bool IsLocalEnabled() => FrameDebugger.IsLocalEnabledDelegateField();

  public static bool IsRemoteEnabled() => FrameDebugger.IsRemoteEnabledDelegateField();

  private delegate bool IsLocalEnabledDelegate();

  private delegate bool IsRemoteEnabledDelegate();
}
