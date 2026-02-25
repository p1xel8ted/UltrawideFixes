// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LogLevel
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

#nullable disable
namespace Epic.OnlineServices.Logging;

public enum LogLevel
{
  Off = 0,
  Fatal = 100, // 0x00000064
  Error = 200, // 0x000000C8
  Warning = 300, // 0x0000012C
  Info = 400, // 0x00000190
  Verbose = 500, // 0x000001F4
  VeryVerbose = 600, // 0x00000258
}
