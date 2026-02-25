// Decompiled with JetBrains decompiler
// Type: UnityEngine.UnityEventQueueSystem
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public class UnityEventQueueSystem
{
  private static readonly UnityEventQueueSystem.GetGlobalEventQueueDelegate GetGlobalEventQueueDelegateField = IL2CPP.ResolveICall<UnityEventQueueSystem.GetGlobalEventQueueDelegate>("UnityEngine.UnityEventQueueSystem::GetGlobalEventQueue");

  public static string GenerateEventIdForPayload(string eventPayloadName)
  {
    throw new NotSupportedException("Method unstripping failed");
  }

  public static IntPtr GetGlobalEventQueue()
  {
    return UnityEventQueueSystem.GetGlobalEventQueueDelegateField();
  }

  private delegate IntPtr GetGlobalEventQueueDelegate();
}
