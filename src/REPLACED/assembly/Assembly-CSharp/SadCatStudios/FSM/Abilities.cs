// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Abilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using System;

#nullable disable
namespace SadCatStudios.FSM;

[Flags]
public enum Abilities
{
  Undefined = 0,
  BasicMovement = 1,
  BasicPlatforming = 2,
  BasicMeleeCombat = 4,
  BasicRangeCombat = 8,
  PickaxePlatforming = 16, // 0x00000010
  DashPlatforming = 32, // 0x00000020
  RandomIdles = 64, // 0x00000040
  ProjectileDeflection = 128, // 0x00000080
  Hacking = 256, // 0x00000100
  MassStun = 512, // 0x00000200
  Overdrive = 1024, // 0x00000400
  PDA = 2048, // 0x00000800
  Healing = 4096, // 0x00001000
}
