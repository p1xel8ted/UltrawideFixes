// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.Memory.CaptureFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace Unity.Profiling.Memory;

public enum CaptureFlags : uint
{
  ManagedObjects = 1,
  NativeObjects = 2,
  NativeAllocations = 4,
  NativeAllocationSites = 8,
  NativeStackTraces = 16, // 0x00000010
}
