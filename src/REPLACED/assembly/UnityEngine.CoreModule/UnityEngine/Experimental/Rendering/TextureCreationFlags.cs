// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.TextureCreationFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

[Flags]
public enum TextureCreationFlags
{
  None = 0,
  MipChain = 1,
  DontInitializePixels = 4,
  Crunch = 64, // 0x00000040
  DontUploadUponCreate = 1024, // 0x00000400
  IgnoreMipmapLimit = 2048, // 0x00000800
}
