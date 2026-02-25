// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BuiltinRenderTextureType
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum BuiltinRenderTextureType
{
  PropertyName = -4, // 0xFFFFFFFC
  BufferPtr = -3, // 0xFFFFFFFD
  RenderTexture = -2, // 0xFFFFFFFE
  BindableTexture = -1, // 0xFFFFFFFF
  None = 0,
  CurrentActive = 1,
  CameraTarget = 2,
  Depth = 3,
  DepthNormals = 4,
  ResolvedDepth = 5,
  PrepassNormalsSpec = 7,
  PrepassLight = 8,
  PrepassLightSpec = 9,
  GBuffer0 = 10, // 0x0000000A
  GBuffer1 = 11, // 0x0000000B
  GBuffer2 = 12, // 0x0000000C
  GBuffer3 = 13, // 0x0000000D
  Reflections = 14, // 0x0000000E
  MotionVectors = 15, // 0x0000000F
  GBuffer4 = 16, // 0x00000010
  GBuffer5 = 17, // 0x00000011
  GBuffer6 = 18, // 0x00000012
  GBuffer7 = 19, // 0x00000013
}
