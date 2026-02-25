// Decompiled with JetBrains decompiler
// Type: UnityEngine.DedicatedServer.Arguments
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.DedicatedServer;

public static class Arguments
{
  private static readonly Arguments.SetArgumentErrorPolicyDelegate SetArgumentErrorPolicyDelegateField = IL2CPP.ResolveICall<Arguments.SetArgumentErrorPolicyDelegate>("UnityEngine.DedicatedServer.Arguments::SetArgumentErrorPolicy");
  private static readonly Arguments.GetArgumentErrorPolicyDelegate GetArgumentErrorPolicyDelegateField = IL2CPP.ResolveICall<Arguments.GetArgumentErrorPolicyDelegate>("UnityEngine.DedicatedServer.Arguments::GetArgumentErrorPolicy");
  private static readonly Arguments.GetBoolArgument_InjectedDelegate GetBoolArgument_InjectedDelegateField = IL2CPP.ResolveICall<Arguments.GetBoolArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::GetBoolArgument_Injected");
  private static readonly Arguments.GetIntArgument_InjectedDelegate GetIntArgument_InjectedDelegateField = IL2CPP.ResolveICall<Arguments.GetIntArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::GetIntArgument_Injected");
  private static readonly Arguments.GetStringArgument_InjectedDelegate GetStringArgument_InjectedDelegateField = IL2CPP.ResolveICall<Arguments.GetStringArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::GetStringArgument_Injected");
  private static readonly Arguments.SetBoolArgument_InjectedDelegate SetBoolArgument_InjectedDelegateField = IL2CPP.ResolveICall<Arguments.SetBoolArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::SetBoolArgument_Injected");
  private static readonly Arguments.SetIntArgument_InjectedDelegate SetIntArgument_InjectedDelegateField = IL2CPP.ResolveICall<Arguments.SetIntArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::SetIntArgument_Injected");
  private static readonly Arguments.SetStringArgument_InjectedDelegate SetStringArgument_InjectedDelegateField = IL2CPP.ResolveICall<Arguments.SetStringArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::SetStringArgument_Injected");

  public static unsafe bool GetBoolArgument(string arg)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = arg.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return Arguments.GetBoolArgument_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe bool GetIntArgument(string arg, out int intValue)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = arg.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return Arguments.GetIntArgument_Injected(ref managedSpanWrapper, out intValue);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe bool GetStringArgument(string arg, out string stringValue)
  {
    ManagedSpanWrapper stringValue1;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = arg.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return Arguments.GetStringArgument_Injected(ref managedSpanWrapper, out stringValue1);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      stringValue = OutStringMarshaller.GetStringAndDispose(stringValue1);
    }
  }

  public static unsafe void SetBoolArgument(string arg)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = arg.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Arguments.SetBoolArgument_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void SetIntArgument(string arg, int intValue)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = arg.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Arguments.SetIntArgument_Injected(ref managedSpanWrapper, intValue);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void SetStringArgument(string arg, string stringValue)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = arg.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(stringValue, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = stringValue.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      Arguments.SetStringArgument_Injected(ref local1, ref local2);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static Il2CppSystem.Nullable<int> Port
  {
    get
    {
      int intValue;
      return Arguments.GetIntArgument("port", out intValue) ? new Il2CppSystem.Nullable<int>(intValue) : (Il2CppSystem.Nullable<int>) null;
    }
    set => Arguments.SetIntArgument("port", ((Il2CppSystem.Nullable<int>) ref value).GetValueOrDefault());
  }

  public static Il2CppSystem.Nullable<int> TargetFramerate
  {
    get
    {
      int intValue;
      return Arguments.GetIntArgument("framerate", out intValue) ? new Il2CppSystem.Nullable<int>(intValue) : (Il2CppSystem.Nullable<int>) null;
    }
    set => Arguments.SetIntArgument("framerate", ((Il2CppSystem.Nullable<int>) ref value).GetValueOrDefault());
  }

  public static Il2CppSystem.Nullable<int> LogLevel
  {
    get
    {
      int intValue;
      return Arguments.GetIntArgument("loglevel", out intValue) ? new Il2CppSystem.Nullable<int>(intValue) : (Il2CppSystem.Nullable<int>) null;
    }
    set => Arguments.SetIntArgument("loglevel", ((Il2CppSystem.Nullable<int>) ref value).GetValueOrDefault());
  }

  public static string LogPath
  {
    get
    {
      string stringValue;
      if (Arguments.GetStringArgument("logpath", out stringValue))
        return stringValue;
      return Arguments.GetStringArgument("logfile", out stringValue) ? Path.GetDirectoryName(stringValue) : (string) null;
    }
    set => Arguments.SetStringArgument("logpath", value);
  }

  public static Il2CppSystem.Nullable<int> QueryPort
  {
    get
    {
      int intValue;
      return Arguments.GetIntArgument("queryport", out intValue) ? new Il2CppSystem.Nullable<int>(intValue) : (Il2CppSystem.Nullable<int>) null;
    }
    set => Arguments.SetIntArgument("queryport", ((Il2CppSystem.Nullable<int>) ref value).GetValueOrDefault());
  }

  public static string QueryType
  {
    get
    {
      string stringValue;
      return Arguments.GetStringArgument("querytype", out stringValue) ? stringValue : (string) null;
    }
    set => Arguments.SetStringArgument("querytype", value);
  }

  public static void SetArgumentErrorPolicy(Arguments.ArgumentErrorPolicy policy)
  {
    Arguments.SetArgumentErrorPolicyDelegateField(policy);
  }

  public static Arguments.ArgumentErrorPolicy GetArgumentErrorPolicy()
  {
    return Arguments.GetArgumentErrorPolicyDelegateField();
  }

  public static Arguments.ArgumentErrorPolicy ErrorPolicy
  {
    get => Arguments.GetArgumentErrorPolicy();
    set => Arguments.SetArgumentErrorPolicy(value);
  }

  public static bool GetBoolArgument_Injected(ref ManagedSpanWrapper arg)
  {
    return Arguments.GetBoolArgument_InjectedDelegateField((System.IntPtr) ref arg);
  }

  public static bool GetIntArgument_Injected(ref ManagedSpanWrapper arg, out int intValue)
  {
    return Arguments.GetIntArgument_InjectedDelegateField((System.IntPtr) ref arg, (System.IntPtr) ref intValue);
  }

  public static bool GetStringArgument_Injected(
    ref ManagedSpanWrapper arg,
    out ManagedSpanWrapper stringValue)
  {
    return Arguments.GetStringArgument_InjectedDelegateField((System.IntPtr) ref arg, (System.IntPtr) ref stringValue);
  }

  public static void SetBoolArgument_Injected(ref ManagedSpanWrapper arg)
  {
    Arguments.SetBoolArgument_InjectedDelegateField((System.IntPtr) ref arg);
  }

  public static void SetIntArgument_Injected(ref ManagedSpanWrapper arg, int intValue)
  {
    Arguments.SetIntArgument_InjectedDelegateField((System.IntPtr) ref arg, intValue);
  }

  public static void SetStringArgument_Injected(
    ref ManagedSpanWrapper arg,
    ref ManagedSpanWrapper stringValue)
  {
    Arguments.SetStringArgument_InjectedDelegateField((System.IntPtr) ref arg, (System.IntPtr) ref stringValue);
  }

  public enum ArgumentErrorPolicy
  {
    Ignore,
    Warn,
    Fatal,
  }

  private delegate void SetArgumentErrorPolicyDelegate(Arguments.ArgumentErrorPolicy policy);

  private delegate Arguments.ArgumentErrorPolicy GetArgumentErrorPolicyDelegate();

  private delegate bool GetBoolArgument_InjectedDelegate(System.IntPtr arg);

  private delegate bool GetIntArgument_InjectedDelegate(System.IntPtr arg, [Out] System.IntPtr intValue);

  private delegate bool GetStringArgument_InjectedDelegate(System.IntPtr arg, [Out] System.IntPtr stringValue);

  private delegate void SetBoolArgument_InjectedDelegate(System.IntPtr arg);

  private delegate void SetIntArgument_InjectedDelegate(System.IntPtr arg, int intValue);

  private delegate void SetStringArgument_InjectedDelegate(System.IntPtr arg, System.IntPtr stringValue);
}
