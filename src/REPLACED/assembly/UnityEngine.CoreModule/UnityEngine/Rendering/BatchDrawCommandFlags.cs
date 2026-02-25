// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchDrawCommandFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Rendering;

[Flags]
public enum BatchDrawCommandFlags
{
  None = 0,
  FlipWinding = 1,
  HasMotion = 2,
  IsLightMapped = 4,
  HasSortingPosition = 8,
  LODCrossFadeKeyword = 16, // 0x00000010
  LODCrossFadeValuePacked = 32, // 0x00000020
  LODCrossFade = LODCrossFadeValuePacked | LODCrossFadeKeyword, // 0x00000030
  UseLegacyLightmapsKeyword = 64, // 0x00000040
}
