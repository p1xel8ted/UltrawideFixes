// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderTargetFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum RenderTargetFlags
{
  None = 0,
  ReadOnlyDepth = 1,
  ReadOnlyStencil = 2,
  ReadOnlyDepthStencil = ReadOnlyStencil | ReadOnlyDepth, // 0x00000003
}
