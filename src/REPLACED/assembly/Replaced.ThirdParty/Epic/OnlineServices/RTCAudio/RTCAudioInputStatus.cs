// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.RTCAudioInputStatus
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

public enum RTCAudioInputStatus
{
  Idle,
  Recording,
  RecordingSilent,
  RecordingDisconnected,
  Failed,
}
