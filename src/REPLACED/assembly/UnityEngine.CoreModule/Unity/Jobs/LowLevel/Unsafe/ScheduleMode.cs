// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.LowLevel.Unsafe.ScheduleMode
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace Unity.Jobs.LowLevel.Unsafe;

public enum ScheduleMode
{
  Run = 0,
  Batched = 1,
  Parallel = 1,
  Single = 2,
}
