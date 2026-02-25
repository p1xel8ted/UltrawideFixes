// Decompiled with JetBrains decompiler
// Type: UnityEngine.HmiPlatform
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class HmiPlatform
{
  private static readonly HmiPlatform.LogStartupTiming_InjectedDelegate LogStartupTiming_InjectedDelegateField = IL2CPP.ResolveICall<HmiPlatform.LogStartupTiming_InjectedDelegate>("UnityEngine.HmiPlatform::LogStartupTiming_Injected");

  public static unsafe void LogStartupTiming(string tag)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(tag, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = tag.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      HmiPlatform.LogStartupTiming_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void LogStartupTiming_Injected(ref ManagedSpanWrapper tag)
  {
    HmiPlatform.LogStartupTiming_InjectedDelegateField((System.IntPtr) ref tag);
  }

  private delegate void LogStartupTiming_InjectedDelegate(System.IntPtr tag);
}
