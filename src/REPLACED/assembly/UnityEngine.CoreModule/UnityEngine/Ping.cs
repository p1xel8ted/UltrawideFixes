// Decompiled with JetBrains decompiler
// Type: UnityEngine.Ping
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Ping
{
  private static readonly Ping.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Ping.Internal_DestroyDelegate>("UnityEngine.Ping::Internal_Destroy");
  private static readonly Ping.Internal_Create_InjectedDelegate Internal_Create_InjectedDelegateField = IL2CPP.ResolveICall<Ping.Internal_Create_InjectedDelegate>("UnityEngine.Ping::Internal_Create_Injected");
  private static readonly Ping.Internal_IsDone_InjectedDelegate Internal_IsDone_InjectedDelegateField = IL2CPP.ResolveICall<Ping.Internal_IsDone_InjectedDelegate>("UnityEngine.Ping::Internal_IsDone_Injected");
  private static readonly Ping.get_time_InjectedDelegate get_time_InjectedDelegateField = IL2CPP.ResolveICall<Ping.get_time_InjectedDelegate>("UnityEngine.Ping::get_time_Injected");
  private static readonly Ping.get_ip_InjectedDelegate get_ip_InjectedDelegateField = IL2CPP.ResolveICall<Ping.get_ip_InjectedDelegate>("UnityEngine.Ping::get_ip_Injected");

  public override void Finalize()
  {
    try
    {
      this.DestroyPing();
    }
    finally
    {
      ((Il2CppSystem.Object) this).Finalize();
    }
  }

  public void DestroyPing() => throw new System.NotSupportedException("Method unstripping failed");

  public static void Internal_Destroy(System.IntPtr ptr) => Ping.Internal_DestroyDelegateField(ptr);

  public static unsafe System.IntPtr Internal_Create(string address)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(address, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = address.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return Ping.Internal_Create_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public bool isDone => throw new System.NotSupportedException("Method unstripping failed");

  public bool Internal_IsDone()
  {
    System.IntPtr native = Ping.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Ping.Internal_IsDone_Injected(native);
  }

  public int time
  {
    get
    {
      System.IntPtr native = Ping.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Ping.get_time_Injected(native);
    }
  }

  public string ip
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        System.IntPtr native = Ping.BindingsMarshaller.ConvertToNative(this);
        if (native == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        Ping.get_ip_Injected(native, out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static System.IntPtr Internal_Create_Injected(ref ManagedSpanWrapper address)
  {
    return Ping.Internal_Create_InjectedDelegateField((System.IntPtr) ref address);
  }

  public static bool Internal_IsDone_Injected(System.IntPtr _unity_self)
  {
    return Ping.Internal_IsDone_InjectedDelegateField(_unity_self);
  }

  public static int get_time_Injected(System.IntPtr _unity_self)
  {
    return Ping.get_time_InjectedDelegateField(_unity_self);
  }

  public static void get_ip_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    Ping.get_ip_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static class BindingsMarshaller
  {
  }

  private delegate void Internal_DestroyDelegate(System.IntPtr ptr);

  private delegate System.IntPtr Internal_Create_InjectedDelegate(System.IntPtr address);

  private delegate bool Internal_IsDone_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_time_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void get_ip_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);
}
