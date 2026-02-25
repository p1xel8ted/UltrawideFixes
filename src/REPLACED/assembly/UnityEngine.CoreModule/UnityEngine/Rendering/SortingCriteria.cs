// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SortingCriteria
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum SortingCriteria
{
  None = 0,
  SortingLayer = 1,
  RenderQueue = 2,
  BackToFront = 4,
  QuantizedFrontToBack = 8,
  OptimizeStateChanges = 16, // 0x00000010
  CanvasOrder = 32, // 0x00000020
  RendererPriority = 64, // 0x00000040
  CommonOpaque = CanvasOrder | OptimizeStateChanges | QuantizedFrontToBack | RenderQueue | SortingLayer, // 0x0000003B
  CommonTransparent = OptimizeStateChanges | BackToFront | RenderQueue | SortingLayer, // 0x00000017
}
