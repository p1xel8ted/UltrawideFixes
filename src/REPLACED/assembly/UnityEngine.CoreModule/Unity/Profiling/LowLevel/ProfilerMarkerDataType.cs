// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.LowLevel.ProfilerMarkerDataType
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace Unity.Profiling.LowLevel;

public enum ProfilerMarkerDataType : byte
{
  InstanceId = 1,
  Int32 = 2,
  UInt32 = 3,
  Int64 = 4,
  UInt64 = 5,
  Float = 6,
  Double = 7,
  String16 = 9,
  Blob8 = 11, // 0x0B
  GfxResourceId = 12, // 0x0C
}
