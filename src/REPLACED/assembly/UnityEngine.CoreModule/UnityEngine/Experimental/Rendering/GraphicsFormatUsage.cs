// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.GraphicsFormatUsage
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

[Flags]
public enum GraphicsFormatUsage
{
  None = 0,
  Sample = 1,
  Linear = 2,
  Sparse = 4,
  Render = 16, // 0x00000010
  Blend = 32, // 0x00000020
  GetPixels = 64, // 0x00000040
  SetPixels = 128, // 0x00000080
  SetPixels32 = 256, // 0x00000100
  ReadPixels = 512, // 0x00000200
  LoadStore = 1024, // 0x00000400
  MSAA2x = 2048, // 0x00000800
  MSAA4x = 4096, // 0x00001000
  MSAA8x = 8192, // 0x00002000
  StencilSampling = 65536, // 0x00010000
}
