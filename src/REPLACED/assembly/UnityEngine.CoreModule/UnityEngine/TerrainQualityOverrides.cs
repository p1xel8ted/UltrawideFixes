// Decompiled with JetBrains decompiler
// Type: UnityEngine.TerrainQualityOverrides
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine;

public enum TerrainQualityOverrides
{
  None = 0,
  PixelError = 1,
  BasemapDistance = 2,
  DetailDensity = 4,
  DetailDistance = 8,
  TreeDistance = 16, // 0x00000010
  BillboardStart = 32, // 0x00000020
  FadeLength = 64, // 0x00000040
  MaxTrees = 128, // 0x00000080
}
