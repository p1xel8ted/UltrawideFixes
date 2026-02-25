// Decompiled with JetBrains decompiler
// Type: UnityEngine.UnityEventAwaitableExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using UnityEngine.Events;

#nullable disable
namespace UnityEngine;

public static class UnityEventAwaitableExtensions
{
  public static Awaitable.Awaiter GetAwaiter(UnityEvent ev)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Awaitable<T>.Awaiter GetAwaiter<T>(UnityEvent<T> ev)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Awaitable<Il2CppSystem.ValueTuple<T0, T1>>.Awaiter GetAwaiter<T0, T1>(
    UnityEvent<T0, T1> ev)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Awaitable<Il2CppSystem.ValueTuple<T0, T1, T2>>.Awaiter GetAwaiter<T0, T1, T2>(
    UnityEvent<T0, T1, T2> ev)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Awaitable<Il2CppSystem.ValueTuple<T0, T1, T2, T3>>.Awaiter GetAwaiter<T0, T1, T2, T3>(
    UnityEvent<T0, T1, T2, T3> ev)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public sealed class \u003C\u003Ec__DisplayClass0_0
  {
  }
}
