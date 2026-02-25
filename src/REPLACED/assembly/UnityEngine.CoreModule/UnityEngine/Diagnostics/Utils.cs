// Decompiled with JetBrains decompiler
// Type: UnityEngine.Diagnostics.Utils
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Diagnostics;

public static class Utils
{
  private static readonly Utils.ForceCrashDelegate ForceCrashDelegateField = IL2CPP.ResolveICall<Utils.ForceCrashDelegate>("UnityEngine.Diagnostics.Utils::ForceCrash");
  private static readonly Utils.ValidateHeapDelegate ValidateHeapDelegateField = IL2CPP.ResolveICall<Utils.ValidateHeapDelegate>("UnityEngine.Diagnostics.Utils::ValidateHeap");
  private static readonly Utils.NativeAssert_InjectedDelegate NativeAssert_InjectedDelegateField = IL2CPP.ResolveICall<Utils.NativeAssert_InjectedDelegate>("UnityEngine.Diagnostics.Utils::NativeAssert_Injected");
  private static readonly Utils.NativeError_InjectedDelegate NativeError_InjectedDelegateField = IL2CPP.ResolveICall<Utils.NativeError_InjectedDelegate>("UnityEngine.Diagnostics.Utils::NativeError_Injected");
  private static readonly Utils.NativeWarning_InjectedDelegate NativeWarning_InjectedDelegateField = IL2CPP.ResolveICall<Utils.NativeWarning_InjectedDelegate>("UnityEngine.Diagnostics.Utils::NativeWarning_Injected");

  public static void ForceCrash(ForcedCrashCategory crashCategory)
  {
    Utils.ForceCrashDelegateField(crashCategory);
  }

  public static unsafe void NativeAssert(string message)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = message.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Utils.NativeAssert_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void NativeError(string message)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = message.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Utils.NativeError_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void NativeWarning(string message)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = message.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Utils.NativeWarning_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void ValidateHeap() => Utils.ValidateHeapDelegateField();

  public static void NativeAssert_Injected(ref ManagedSpanWrapper message)
  {
    Utils.NativeAssert_InjectedDelegateField((System.IntPtr) ref message);
  }

  public static void NativeError_Injected(ref ManagedSpanWrapper message)
  {
    Utils.NativeError_InjectedDelegateField((System.IntPtr) ref message);
  }

  public static void NativeWarning_Injected(ref ManagedSpanWrapper message)
  {
    Utils.NativeWarning_InjectedDelegateField((System.IntPtr) ref message);
  }

  private delegate void ForceCrashDelegate(ForcedCrashCategory crashCategory);

  private delegate void ValidateHeapDelegate();

  private delegate void NativeAssert_InjectedDelegate(System.IntPtr message);

  private delegate void NativeError_InjectedDelegate(System.IntPtr message);

  private delegate void NativeWarning_InjectedDelegate(System.IntPtr message);
}
