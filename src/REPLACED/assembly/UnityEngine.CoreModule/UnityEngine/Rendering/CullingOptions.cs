// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CullingOptions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum CullingOptions
{
  None = 0,
  ForceEvenIfCameraIsNotActive = 1,
  OcclusionCull = 2,
  NeedsLighting = 4,
  NeedsReflectionProbes = 8,
  Stereo = 16, // 0x00000010
  DisablePerObjectCulling = 32, // 0x00000020
  ShadowCasters = 64, // 0x00000040
}
