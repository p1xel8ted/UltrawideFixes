// Decompiled with JetBrains decompiler
// Type: UnityEngine.AsyncOperationAwaitableExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine;

public static class AsyncOperationAwaitableExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_Awaiter_AsyncOperation_0;

  static AsyncOperationAwaitableExtensions()
  {
    Il2CppClassPointerStore<AsyncOperationAwaitableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AsyncOperationAwaitableExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationAwaitableExtensions>.NativeClassPtr);
    AsyncOperationAwaitableExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_Awaiter_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationAwaitableExtensions>.NativeClassPtr, 100667936);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443437, XrefRangeEnd = 443450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Awaitable.Awaiter GetAwaiter(this AsyncOperation op)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AsyncOperationAwaitableExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_Awaiter_AsyncOperation_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Awaitable.Awaiter(pointer);
  }

  public AsyncOperationAwaitableExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
