// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.PerObjectData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum PerObjectData
{
  None = 0,
  LightProbe = 1,
  ReflectionProbes = 2,
  LightProbeProxyVolume = 4,
  Lightmaps = 8,
  LightData = 16, // 0x00000010
  MotionVectors = 32, // 0x00000020
  LightIndices = 64, // 0x00000040
  ReflectionProbeData = 128, // 0x00000080
  OcclusionProbe = 256, // 0x00000100
  OcclusionProbeProxyVolume = 512, // 0x00000200
  ShadowMask = 1024, // 0x00000400
}
