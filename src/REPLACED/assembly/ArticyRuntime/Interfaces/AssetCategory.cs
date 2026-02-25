// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.AssetCategory
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using System;

#nullable disable
namespace Articy.Unity.Interfaces;

[Flags]
public enum AssetCategory
{
  None = 0,
  Image = 1,
  Video = 2,
  Audio = 4,
  Document = 8,
  Misc = 16, // 0x00000010
  All = Misc | Document | Audio | Video | Image, // 0x0000001F
}
