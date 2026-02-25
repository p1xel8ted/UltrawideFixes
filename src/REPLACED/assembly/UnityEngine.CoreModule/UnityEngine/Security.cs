// Decompiled with JetBrains decompiler
// Type: UnityEngine.Security
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace UnityEngine;

public sealed class Security
{
  public static Assembly LoadAndVerifyAssembly(
    Il2CppStructArray<byte> assemblyData,
    string authorizationKey)
  {
    return (Assembly) null;
  }

  public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData)
  {
    return (Assembly) null;
  }

  public static bool PrefetchSocketPolicy(string ip, int atPort)
  {
    int timeout = 3000;
    return Security.PrefetchSocketPolicy(ip, atPort, timeout);
  }

  public static bool PrefetchSocketPolicy(string ip, int atPort, int timeout) => false;
}
