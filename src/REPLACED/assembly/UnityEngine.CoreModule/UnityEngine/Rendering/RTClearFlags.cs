// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RTClearFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum RTClearFlags
{
  None = 0,
  Color = 1,
  Depth = 2,
  Stencil = 4,
  All = Stencil | Depth | Color, // 0x00000007
  DepthStencil = Stencil | Depth, // 0x00000006
  ColorDepth = Depth | Color, // 0x00000003
  ColorStencil = Stencil | Color, // 0x00000005
}
