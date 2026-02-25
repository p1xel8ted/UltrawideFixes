// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ColorWriteMask
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum ColorWriteMask
{
  Alpha = 1,
  Blue = 2,
  Green = 4,
  Red = 8,
  All = Red | Green | Blue | Alpha, // 0x0000000F
}
