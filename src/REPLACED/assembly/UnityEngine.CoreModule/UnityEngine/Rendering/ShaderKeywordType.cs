// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShaderKeywordType
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum ShaderKeywordType
{
  None = 0,
  BuiltinDefault = 2,
  BuiltinExtra = 6,
  BuiltinAutoStripped = 10, // 0x0000000A
  UserDefined = 16, // 0x00000010
  Plugin = 32, // 0x00000020
}
