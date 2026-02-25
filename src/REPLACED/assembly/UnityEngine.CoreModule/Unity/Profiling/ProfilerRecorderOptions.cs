// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.ProfilerRecorderOptions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace Unity.Profiling;

[Flags]
public enum ProfilerRecorderOptions
{
  None = 0,
  StartImmediately = 1,
  KeepAliveDuringDomainReload = 2,
  CollectOnlyOnCurrentThread = 4,
  WrapAroundWhenCapacityReached = 8,
  SumAllSamplesInFrame = 16, // 0x00000010
  GpuRecorder = 64, // 0x00000040
  Default = SumAllSamplesInFrame | WrapAroundWhenCapacityReached, // 0x00000018
}
