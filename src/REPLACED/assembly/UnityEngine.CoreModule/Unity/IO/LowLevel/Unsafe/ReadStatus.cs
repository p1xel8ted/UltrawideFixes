// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.ReadStatus
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

public enum ReadStatus
{
  Complete = 0,
  InProgress = 1,
  Failed = 2,
  Truncated = 4,
  Canceled = 5,
}
