// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShaderPropertyFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum ShaderPropertyFlags
{
  None = 0,
  HideInInspector = 1,
  PerRendererData = 2,
  NoScaleOffset = 4,
  Normal = 8,
  HDR = 16, // 0x00000010
  Gamma = 32, // 0x00000020
  NonModifiableTextureData = 64, // 0x00000040
  MainTexture = 128, // 0x00000080
  MainColor = 256, // 0x00000100
}
