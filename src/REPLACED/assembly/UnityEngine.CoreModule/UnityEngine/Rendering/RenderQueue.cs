// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderQueue
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum RenderQueue
{
  Background = 1000, // 0x000003E8
  Geometry = 2000, // 0x000007D0
  AlphaTest = 2450, // 0x00000992
  GeometryLast = 2500, // 0x000009C4
  Transparent = 3000, // 0x00000BB8
  Overlay = 4000, // 0x00000FA0
}
