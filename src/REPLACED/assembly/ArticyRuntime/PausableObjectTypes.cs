// Decompiled with JetBrains decompiler
// Type: Articy.Unity.PausableObjectTypes
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using System;

#nullable disable
namespace Articy.Unity;

[Flags]
public enum PausableObjectTypes
{
  FlowFragments = 1,
  Dialogues = 2,
  DialogueFragments = 4,
  Hubs = 8,
  Jumps = 16, // 0x00000010
  Conditions = 32, // 0x00000020
  Instructions = 64, // 0x00000040
  Pins = 128, // 0x00000080
  Connections = 256, // 0x00000100
}
