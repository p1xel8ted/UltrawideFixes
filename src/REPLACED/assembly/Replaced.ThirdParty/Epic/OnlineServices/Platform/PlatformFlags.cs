// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.PlatformFlags
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using System;

#nullable disable
namespace Epic.OnlineServices.Platform;

[Flags]
public enum PlatformFlags : ulong
{
  None = 0,
  LoadingInEditor = 1,
  DisableOverlay = 2,
  DisableSocialOverlay = 4,
  Reserved1 = 8,
  WindowsEnableOverlayD3D9 = 16, // 0x0000000000000010
  WindowsEnableOverlayD3D10 = 32, // 0x0000000000000020
  WindowsEnableOverlayOpengl = 64, // 0x0000000000000040
}
