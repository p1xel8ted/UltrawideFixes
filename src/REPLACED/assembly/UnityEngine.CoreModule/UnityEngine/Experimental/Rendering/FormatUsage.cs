// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.FormatUsage
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public enum FormatUsage
{
  Sample = 0,
  Linear = 1,
  Sparse = 2,
  Render = 4,
  Blend = 5,
  GetPixels = 6,
  SetPixels = 7,
  SetPixels32 = 8,
  ReadPixels = 9,
  LoadStore = 10, // 0x0000000A
  MSAA2x = 11, // 0x0000000B
  MSAA4x = 12, // 0x0000000C
  MSAA8x = 13, // 0x0000000D
  StencilSampling = 16, // 0x00000010
}
