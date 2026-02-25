// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CopyTextureSupport
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum CopyTextureSupport
{
  None = 0,
  Basic = 1,
  Copy3D = 2,
  DifferentTypes = 4,
  TextureToRT = 8,
  RTToTexture = 16, // 0x00000010
}
