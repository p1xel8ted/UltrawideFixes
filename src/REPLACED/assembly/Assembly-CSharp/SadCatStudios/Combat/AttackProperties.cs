// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.AttackProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace SadCatStudios.Combat;

public enum AttackProperties
{
  None = 0,
  Blockable = 1,
  Unblockable = 2,
  Unparryable = 4,
  Ramming = 8,
  DelayedDamage = 16, // 0x00000010
  RangedStart = 32, // 0x00000020
}
