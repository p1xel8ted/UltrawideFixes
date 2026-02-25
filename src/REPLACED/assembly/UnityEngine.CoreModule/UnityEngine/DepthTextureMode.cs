// Decompiled with JetBrains decompiler
// Type: UnityEngine.DepthTextureMode
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine;

[Flags]
public enum DepthTextureMode
{
  None = 0,
  Depth = 1,
  DepthNormals = 2,
  MotionVectors = 4,
}
