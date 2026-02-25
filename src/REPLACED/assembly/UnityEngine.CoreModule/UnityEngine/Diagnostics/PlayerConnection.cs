// Decompiled with JetBrains decompiler
// Type: UnityEngine.Diagnostics.PlayerConnection
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace UnityEngine.Diagnostics;

public static class PlayerConnection
{
  public static bool connected => UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected;

  public static void SendFile(string remoteFilePath, Il2CppStructArray<byte> data)
  {
  }
}
