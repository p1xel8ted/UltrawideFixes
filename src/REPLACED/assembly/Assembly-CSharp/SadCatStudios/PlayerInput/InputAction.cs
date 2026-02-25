// Decompiled with JetBrains decompiler
// Type: SadCatStudios.PlayerInput.InputAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace SadCatStudios.PlayerInput;

public enum InputAction
{
  None = 0,
  Action = 2,
  MoveHorizontal = 5,
  MoveVertical = 6,
  LookHorizontal = 7,
  LookVertical = 8,
  Jump = 9,
  HeavyStrike = 10, // 0x0000000A
  Shoot = 11, // 0x0000000B
  Crouch = 12, // 0x0000000C
  Run = 13, // 0x0000000D
  WalkToggle = 14, // 0x0000000E
  UIHorizontal = 16, // 0x00000010
  UIVertical = 17, // 0x00000011
  UISubmit = 18, // 0x00000012
  UICancel = 19, // 0x00000013
  Deflect = 20, // 0x00000014
  Block = 21, // 0x00000015
  LightStrike = 22, // 0x00000016
  Grab = 23, // 0x00000017
  Roll = 24, // 0x00000018
  ContextualAction = 25, // 0x00000019
  Gadget = 26, // 0x0000001A
  MassStun = 27, // 0x0000001B
  Overdrive = 28, // 0x0000001C
  CameraMoveForward = 30, // 0x0000001E
  CameraMoveHorizontal = 31, // 0x0000001F
  CameraMoveVertical = 32, // 0x00000020
  CameraLookVertical = 33, // 0x00000021
  CameraLookHorizontal = 34, // 0x00000022
  Debug = 35, // 0x00000023
  CameraFollowMouse = 36, // 0x00000024
  UIMenu = 37, // 0x00000025
  Healing = 38, // 0x00000026
  PDA = 39, // 0x00000027
  Hacking = 40, // 0x00000028
  Dialogue_1 = 42, // 0x0000002A
  Dialogue_2 = 43, // 0x0000002B
  Dialogue_3 = 44, // 0x0000002C
  Dialogue_4 = 45, // 0x0000002D
  UIScroll = 46, // 0x0000002E
  UIDelete = 48, // 0x00000030
}
