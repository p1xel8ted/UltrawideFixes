// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.LowLevel.MarkerFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace Unity.Profiling.LowLevel;

[Flags]
public enum MarkerFlags : ushort
{
  Default = 0,
  Script = 2,
  ScriptInvoke = 32, // 0x0020
  ScriptDeepProfiler = 64, // 0x0040
  AvailabilityEditor = 4,
  AvailabilityNonDevelopment = 8,
  Warning = 16, // 0x0010
  Counter = 128, // 0x0080
  SampleGPU = 256, // 0x0100
}
