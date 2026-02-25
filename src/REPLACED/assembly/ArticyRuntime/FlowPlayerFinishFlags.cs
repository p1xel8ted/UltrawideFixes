// Decompiled with JetBrains decompiler
// Type: Articy.Unity.FlowPlayerFinishFlags
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using System;

#nullable disable
namespace Articy.Unity;

[Flags]
public enum FlowPlayerFinishFlags
{
  BreakOnStopNodes = 1,
  TraverseThroughNonScriptNodes = 2,
  EvaluateOnBranches = 4,
  All = EvaluateOnBranches | TraverseThroughNonScriptNodes | BreakOnStopNodes, // 0x00000007
  None = 8,
}
