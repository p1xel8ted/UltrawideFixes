// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderStateMask
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum RenderStateMask
{
  Nothing = 0,
  Blend = 1,
  Raster = 2,
  Depth = 4,
  Stencil = 8,
  Everything = Stencil | Depth | Raster | Blend, // 0x0000000F
}
