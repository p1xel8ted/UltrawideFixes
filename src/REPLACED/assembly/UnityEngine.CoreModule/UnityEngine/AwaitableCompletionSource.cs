// Decompiled with JetBrains decompiler
// Type: UnityEngine.AwaitableCompletionSource
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine;

public class AwaitableCompletionSource
{
  public Awaitable Awaitable
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public void SetResult()
  {
    if (!this.TrySetResult())
      throw new Il2CppSystem.InvalidOperationException("Can't raise completion of the same Awaitable twice");
  }

  public void SetCanceled()
  {
    if (!this.TrySetCanceled())
      throw new Il2CppSystem.InvalidOperationException("Can't raise completion of the same Awaitable twice");
  }

  public void SetException(Il2CppSystem.Exception exception)
  {
    if (!this.TrySetException(exception))
      throw new Il2CppSystem.InvalidOperationException("Can't raise completion of the same Awaitable twice");
  }

  public bool CheckAndAcquireCompletionState()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public bool TrySetResult()
  {
    if (!this.CheckAndAcquireCompletionState())
      return false;
    this.Awaitable.RaiseManagedCompletion();
    return true;
  }

  public bool TrySetCanceled()
  {
    if (!this.CheckAndAcquireCompletionState())
      return false;
    this.Awaitable.Cancel();
    return true;
  }

  public bool TrySetException(Il2CppSystem.Exception exception)
  {
    if (!this.CheckAndAcquireCompletionState())
      return false;
    this.Awaitable.RaiseManagedCompletion(exception);
    return true;
  }

  public void Reset() => throw new System.NotSupportedException("Method unstripping failed");
}
