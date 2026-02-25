// Decompiled with JetBrains decompiler
// Type: UnityEngine.BootConfigData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class BootConfigData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0;
  private static readonly BootConfigData.Append_InjectedDelegate Append_InjectedDelegateField;
  private static readonly BootConfigData.Set_InjectedDelegate Set_InjectedDelegateField;
  private static readonly BootConfigData.GetValue_InjectedDelegate GetValue_InjectedDelegateField;

  static BootConfigData()
  {
    Il2CppClassPointerStore<BootConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BootConfigData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr);
    BootConfigData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, nameof (m_Ptr));
    BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, 100663903);
    BootConfigData.Append_InjectedDelegateField = IL2CPP.ResolveICall<BootConfigData.Append_InjectedDelegate>("UnityEngine.BootConfigData::Append_Injected");
    BootConfigData.Set_InjectedDelegateField = IL2CPP.ResolveICall<BootConfigData.Set_InjectedDelegate>("UnityEngine.BootConfigData::Set_Injected");
    BootConfigData.GetValue_InjectedDelegateField = IL2CPP.ResolveICall<BootConfigData.GetValue_InjectedDelegate>("UnityEngine.BootConfigData::GetValue_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417499, XrefRangeEnd = 417503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BootConfigData WrapBootConfigData(System.IntPtr nativeHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &nativeHandle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BootConfigData) null : Il2CppObjectPool.Get<BootConfigData>(num3);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public void AddKey(string key) => this.Append(key, (string) null);

  public string Get(string key) => this.GetValue(key, 0);

  public string Get(string key, int index) => this.GetValue(key, index);

  public unsafe void Append(string key, string value)
  {
    try
    {
      System.IntPtr native = BootConfigData.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = key.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = value.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      BootConfigData.Append_Injected(native, ref local1, ref local2);
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

  public unsafe void Set(string key, string value)
  {
    try
    {
      System.IntPtr native = BootConfigData.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = key.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = value.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      BootConfigData.Set_Injected(native, ref local1, ref local2);
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

  public unsafe string GetValue(string key, int index)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      System.IntPtr native = BootConfigData.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = key.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      BootConfigData.GetValue_Injected(native, ref managedSpanWrapper, index, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static void Append_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper key,
    ref ManagedSpanWrapper value)
  {
    BootConfigData.Append_InjectedDelegateField(_unity_self, (System.IntPtr) ref key, (System.IntPtr) ref value);
  }

  public static void Set_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper key,
    ref ManagedSpanWrapper value)
  {
    BootConfigData.Set_InjectedDelegateField(_unity_self, (System.IntPtr) ref key, (System.IntPtr) ref value);
  }

  public static void GetValue_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper key,
    int index,
    out ManagedSpanWrapper ret)
  {
    BootConfigData.GetValue_InjectedDelegateField(_unity_self, (System.IntPtr) ref key, index, (System.IntPtr) ref ret);
  }

  public static class BindingsMarshaller
  {
  }

  private delegate void Append_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, System.IntPtr value);

  private delegate void Set_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, System.IntPtr value);

  private delegate void GetValue_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr key,
    int index,
    [Out] System.IntPtr ret);
}
