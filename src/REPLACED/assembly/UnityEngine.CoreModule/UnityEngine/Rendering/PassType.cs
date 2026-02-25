// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.PassType
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum PassType
{
  Normal = 0,
  Vertex = 1,
  VertexLM = 2,
  VertexLMRGBM = 3,
  ForwardBase = 4,
  ForwardAdd = 5,
  LightPrePassBase = 6,
  LightPrePassFinal = 7,
  ShadowCaster = 8,
  Deferred = 10, // 0x0000000A
  Meta = 11, // 0x0000000B
  MotionVectors = 12, // 0x0000000C
  ScriptableRenderPipeline = 13, // 0x0000000D
  ScriptableRenderPipelineDefaultUnlit = 14, // 0x0000000E
  GrabPass = 15, // 0x0000000F
}
