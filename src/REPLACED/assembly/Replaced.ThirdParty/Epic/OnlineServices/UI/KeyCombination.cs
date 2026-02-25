// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.KeyCombination
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using System;

#nullable disable
namespace Epic.OnlineServices.UI;

[Flags]
public enum KeyCombination
{
  ModifierShift = 16, // 0x00000010
  KeyTypeMask = 65535, // 0x0000FFFF
  ModifierMask = -65536, // 0xFFFF0000
  Shift = 65536, // 0x00010000
  Control = 131072, // 0x00020000
  Alt = 262144, // 0x00040000
  Meta = 524288, // 0x00080000
  ValidModifierMask = Meta | Alt | Control | Shift, // 0x000F0000
  None = 0,
  Space = 1,
  Backspace = 2,
  Tab = Backspace | Space, // 0x00000003
  Escape = 4,
  PageUp = Escape | Space, // 0x00000005
  PageDown = Escape | Backspace, // 0x00000006
  End = PageDown | Space, // 0x00000007
  Home = 8,
  Insert = Home | Space, // 0x00000009
  Delete = Home | Backspace, // 0x0000000A
  Left = Delete | Space, // 0x0000000B
  Up = Home | Escape, // 0x0000000C
  Right = Up | Space, // 0x0000000D
  Down = Up | Backspace, // 0x0000000E
  Key0 = Down | Space, // 0x0000000F
  Key1 = ModifierShift, // 0x00000010
  Key2 = Key1 | Space, // 0x00000011
  Key3 = Key1 | Backspace, // 0x00000012
  Key4 = Key3 | Space, // 0x00000013
  Key5 = Key1 | Escape, // 0x00000014
  Key6 = Key5 | Space, // 0x00000015
  Key7 = Key5 | Backspace, // 0x00000016
  Key8 = Key7 | Space, // 0x00000017
  Key9 = Key1 | Home, // 0x00000018
  KeyA = Key9 | Space, // 0x00000019
  KeyB = Key9 | Backspace, // 0x0000001A
  KeyC = KeyB | Space, // 0x0000001B
  KeyD = Key9 | Escape, // 0x0000001C
  KeyE = KeyD | Space, // 0x0000001D
  KeyF = KeyD | Backspace, // 0x0000001E
  KeyG = KeyF | Space, // 0x0000001F
  KeyH = 32, // 0x00000020
  KeyI = KeyH | Space, // 0x00000021
  KeyJ = KeyH | Backspace, // 0x00000022
  KeyK = KeyJ | Space, // 0x00000023
  KeyL = KeyH | Escape, // 0x00000024
  KeyM = KeyL | Space, // 0x00000025
  KeyN = KeyL | Backspace, // 0x00000026
  KeyO = KeyN | Space, // 0x00000027
  KeyP = KeyH | Home, // 0x00000028
  KeyQ = KeyP | Space, // 0x00000029
  KeyR = KeyP | Backspace, // 0x0000002A
  KeyS = KeyR | Space, // 0x0000002B
  KeyT = KeyP | Escape, // 0x0000002C
  KeyU = KeyT | Space, // 0x0000002D
  KeyV = KeyT | Backspace, // 0x0000002E
  KeyW = KeyV | Space, // 0x0000002F
  KeyX = KeyH | Key1, // 0x00000030
  KeyY = KeyX | Space, // 0x00000031
  KeyZ = KeyX | Backspace, // 0x00000032
  Numpad0 = KeyZ | Space, // 0x00000033
  Numpad1 = KeyX | Escape, // 0x00000034
  Numpad2 = Numpad1 | Space, // 0x00000035
  Numpad3 = Numpad1 | Backspace, // 0x00000036
  Numpad4 = Numpad3 | Space, // 0x00000037
  Numpad5 = KeyX | Home, // 0x00000038
  Numpad6 = Numpad5 | Space, // 0x00000039
  Numpad7 = Numpad5 | Backspace, // 0x0000003A
  Numpad8 = Numpad7 | Space, // 0x0000003B
  Numpad9 = Numpad5 | Escape, // 0x0000003C
  NumpadAsterisk = Numpad9 | Space, // 0x0000003D
  NumpadPlus = Numpad9 | Backspace, // 0x0000003E
  NumpadMinus = NumpadPlus | Space, // 0x0000003F
  NumpadPeriod = 64, // 0x00000040
  NumpadDivide = NumpadPeriod | Space, // 0x00000041
  F1 = NumpadPeriod | Backspace, // 0x00000042
  F2 = F1 | Space, // 0x00000043
  F3 = NumpadPeriod | Escape, // 0x00000044
  F4 = F3 | Space, // 0x00000045
  F5 = F3 | Backspace, // 0x00000046
  F6 = F5 | Space, // 0x00000047
  F7 = NumpadPeriod | Home, // 0x00000048
  F8 = F7 | Space, // 0x00000049
  F9 = F7 | Backspace, // 0x0000004A
  F10 = F9 | Space, // 0x0000004B
  F11 = F7 | Escape, // 0x0000004C
  F12 = F11 | Space, // 0x0000004D
  F13 = F11 | Backspace, // 0x0000004E
  F14 = F13 | Space, // 0x0000004F
  F15 = NumpadPeriod | Key1, // 0x00000050
  F16 = F15 | Space, // 0x00000051
  F17 = F15 | Backspace, // 0x00000052
  F18 = F17 | Space, // 0x00000053
  F19 = F15 | Escape, // 0x00000054
  F20 = F19 | Space, // 0x00000055
  F21 = F19 | Backspace, // 0x00000056
  F22 = F21 | Space, // 0x00000057
  F23 = F15 | Home, // 0x00000058
  F24 = F23 | Space, // 0x00000059
  OemPlus = F23 | Backspace, // 0x0000005A
  OemComma = OemPlus | Space, // 0x0000005B
  OemMinus = F23 | Escape, // 0x0000005C
  OemPeriod = OemMinus | Space, // 0x0000005D
  Oem1 = OemMinus | Backspace, // 0x0000005E
  Oem2 = Oem1 | Space, // 0x0000005F
  Oem3 = NumpadPeriod | KeyH, // 0x00000060
  Oem4 = Oem3 | Space, // 0x00000061
  Oem5 = Oem3 | Backspace, // 0x00000062
  Oem6 = Oem5 | Space, // 0x00000063
  Oem7 = Oem3 | Escape, // 0x00000064
  Oem8 = Oem7 | Space, // 0x00000065
  MaxKeyType = Oem7 | Backspace, // 0x00000066
}
