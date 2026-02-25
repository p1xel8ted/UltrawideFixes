// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.AuthScopeFlags
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using System;

#nullable disable
namespace Epic.OnlineServices.Auth;

[Flags]
public enum AuthScopeFlags
{
  NoFlags = 0,
  BasicProfile = 1,
  FriendsList = 2,
  Presence = 4,
  FriendsManagement = 8,
  Email = 16, // 0x00000010
}
