// Decompiled with JetBrains decompiler
// Type: UnityEngine.RenderTextureCreationFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine;

[Flags]
public enum RenderTextureCreationFlags
{
  MipMap = 1,
  AutoGenerateMips = 2,
  SRGB = 4,
  EyeTexture = 8,
  EnableRandomWrite = 16, // 0x00000010
  CreatedFromScript = 32, // 0x00000020
  AllowVerticalFlip = 128, // 0x00000080
  NoResolvedColorSurface = 256, // 0x00000100
  DynamicallyScalable = 1024, // 0x00000400
  BindMS = 2048, // 0x00000800
  DynamicallyScalableExplicit = 131072, // 0x00020000
}
