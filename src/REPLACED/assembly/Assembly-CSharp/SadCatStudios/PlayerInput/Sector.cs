// Decompiled with JetBrains decompiler
// Type: SadCatStudios.PlayerInput.Sector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace SadCatStudios.PlayerInput;

public enum Sector
{
  None = 0,
  PositiveHorizontal = 1,
  NegativeHorizontal = 2,
  PositiveVertical = 4,
  NegativeVertical = 8,
  PositiveUpDiagonal = 16, // 0x00000010
  NegativeUpDiagonal = 32, // 0x00000020
  PositiveDownDiagonal = 64, // 0x00000040
  NegativeDownDiagonal = 128, // 0x00000080
  NotHorizontal = 256, // 0x00000100
  NotVertical = 512, // 0x00000200
}
