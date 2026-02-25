// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LogCategory
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

#nullable disable
namespace Epic.OnlineServices.Logging;

public enum LogCategory
{
  Core = 0,
  Auth = 1,
  Friends = 2,
  Presence = 3,
  UserInfo = 4,
  HttpSerialization = 5,
  Ecom = 6,
  P2P = 7,
  Sessions = 8,
  RateLimiter = 9,
  PlayerDataStorage = 10, // 0x0000000A
  Analytics = 11, // 0x0000000B
  Messaging = 12, // 0x0000000C
  Connect = 13, // 0x0000000D
  Overlay = 14, // 0x0000000E
  Achievements = 15, // 0x0000000F
  Stats = 16, // 0x00000010
  Ui = 17, // 0x00000011
  Lobby = 18, // 0x00000012
  Leaderboards = 19, // 0x00000013
  Keychain = 20, // 0x00000014
  IdentityProvider = 21, // 0x00000015
  TitleStorage = 22, // 0x00000016
  Mods = 23, // 0x00000017
  AntiCheat = 24, // 0x00000018
  Reports = 25, // 0x00000019
  Sanctions = 26, // 0x0000001A
  ProgressionSnapshots = 27, // 0x0000001B
  Kws = 28, // 0x0000001C
  Rtc = 29, // 0x0000001D
  RTCAdmin = 30, // 0x0000001E
  Inventory = 31, // 0x0000001F
  ReceiptValidator = 32, // 0x00000020
  CustomInvites = 33, // 0x00000021
  AllCategories = 2147483647, // 0x7FFFFFFF
}
