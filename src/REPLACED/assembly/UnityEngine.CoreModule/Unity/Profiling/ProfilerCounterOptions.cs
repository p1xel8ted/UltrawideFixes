// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.ProfilerCounterOptions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace Unity.Profiling;

[Flags]
public enum ProfilerCounterOptions : ushort
{
  None = 0,
  FlushOnEndOfFrame = 2,
  ResetToZeroOnFlush = 4,
}
