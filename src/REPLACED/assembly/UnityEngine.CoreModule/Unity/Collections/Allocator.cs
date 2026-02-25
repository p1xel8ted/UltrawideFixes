// Decompiled with JetBrains decompiler
// Type: Unity.Collections.Allocator
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace Unity.Collections;

public enum Allocator
{
  Invalid = 0,
  None = 1,
  Temp = 2,
  TempJob = 3,
  Persistent = 4,
  AudioKernel = 5,
  Domain = 6,
  FirstUserIndex = 64, // 0x00000040
}
