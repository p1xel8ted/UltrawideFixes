// Decompiled with JetBrains decompiler
// Type: UnityEngine.MaterialGlobalIlluminationFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine;

[Flags]
public enum MaterialGlobalIlluminationFlags
{
  None = 0,
  RealtimeEmissive = 1,
  BakedEmissive = 2,
  EmissiveIsBlack = 4,
  AnyEmissive = BakedEmissive | RealtimeEmissive, // 0x00000003
}
