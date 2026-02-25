// Decompiled with JetBrains decompiler
// Type: UnityEngine.DiagnosticSwitch
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class DiagnosticSwitch
{
  private static readonly DiagnosticSwitch.get_name_InjectedDelegate get_name_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_name_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_name_Injected");
  private static readonly DiagnosticSwitch.get_description_InjectedDelegate get_description_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_description_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_description_Injected");
  private static readonly DiagnosticSwitch.get_owningModule_InjectedDelegate get_owningModule_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_owningModule_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_owningModule_Injected");
  private static readonly DiagnosticSwitch.get_flags_InjectedDelegate get_flags_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_flags_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_flags_Injected");
  private static readonly DiagnosticSwitch.get_defaultValue_InjectedDelegate get_defaultValue_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_defaultValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_defaultValue_Injected");
  private static readonly DiagnosticSwitch.get_minValue_InjectedDelegate get_minValue_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_minValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_minValue_Injected");
  private static readonly DiagnosticSwitch.get_maxValue_InjectedDelegate get_maxValue_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_maxValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_maxValue_Injected");
  private static readonly DiagnosticSwitch.get_enumInfo_InjectedDelegate get_enumInfo_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_enumInfo_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_enumInfo_Injected");
  private static readonly DiagnosticSwitch.GetScriptingValue_InjectedDelegate GetScriptingValue_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.GetScriptingValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingValue_Injected");
  private static readonly DiagnosticSwitch.GetScriptingPersistentValue_InjectedDelegate GetScriptingPersistentValue_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.GetScriptingPersistentValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingPersistentValue_Injected");
  private static readonly DiagnosticSwitch.SetScriptingValue_InjectedDelegate SetScriptingValue_InjectedDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.SetScriptingValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::SetScriptingValue_Injected");

  public string name
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
        if (native == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        DiagnosticSwitch.get_name_Injected(native, out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public string description
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
        if (native == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        DiagnosticSwitch.get_description_Injected(native, out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public string owningModule
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
        if (native == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        DiagnosticSwitch.get_owningModule_Injected(native, out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public DiagnosticSwitch.Flags flags
  {
    get
    {
      System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return DiagnosticSwitch.get_flags_Injected(native);
    }
  }

  public Il2CppSystem.Object value
  {
    get => this.GetScriptingValue();
    set => this.SetScriptingValue(value, false);
  }

  public Il2CppSystem.Object defaultValue
  {
    get
    {
      System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return DiagnosticSwitch.get_defaultValue_Injected(native);
    }
  }

  public Il2CppSystem.Object minValue
  {
    get
    {
      System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return DiagnosticSwitch.get_minValue_Injected(native);
    }
  }

  public Il2CppSystem.Object maxValue
  {
    get
    {
      System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return DiagnosticSwitch.get_maxValue_Injected(native);
    }
  }

  public Il2CppSystem.Object persistentValue
  {
    get => this.GetScriptingPersistentValue();
    set => this.SetScriptingValue(value, true);
  }

  public EnumInfo enumInfo
  {
    get
    {
      System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return DiagnosticSwitch.get_enumInfo_Injected(native);
    }
  }

  public Il2CppSystem.Object GetScriptingValue()
  {
    System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return DiagnosticSwitch.GetScriptingValue_Injected(native);
  }

  public Il2CppSystem.Object GetScriptingPersistentValue()
  {
    System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return DiagnosticSwitch.GetScriptingPersistentValue_Injected(native);
  }

  public void SetScriptingValue(Il2CppSystem.Object value, bool setPersistent)
  {
    System.IntPtr native = DiagnosticSwitch.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    DiagnosticSwitch.SetScriptingValue_Injected(native, value, setPersistent);
  }

  public bool isSetToDefault => Il2CppSystem.Object.Equals(this.persistentValue, this.defaultValue);

  public bool needsRestart => !Il2CppSystem.Object.Equals(this.value, this.persistentValue);

  public override string ToString()
  {
    return Il2CppSystem.String.Concat(this.name, " = ", this.value == null ? "<null>" : this.value.ToString());
  }

  public static void get_name_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    DiagnosticSwitch.get_name_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void get_description_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    DiagnosticSwitch.get_description_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void get_owningModule_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    DiagnosticSwitch.get_owningModule_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static DiagnosticSwitch.Flags get_flags_Injected(System.IntPtr _unity_self)
  {
    return DiagnosticSwitch.get_flags_InjectedDelegateField(_unity_self);
  }

  public static Il2CppSystem.Object get_defaultValue_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = DiagnosticSwitch.get_defaultValue_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
  }

  public static Il2CppSystem.Object get_minValue_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = DiagnosticSwitch.get_minValue_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
  }

  public static Il2CppSystem.Object get_maxValue_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = DiagnosticSwitch.get_maxValue_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
  }

  public static EnumInfo get_enumInfo_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = DiagnosticSwitch.get_enumInfo_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (EnumInfo) null : Il2CppObjectPool.Get<EnumInfo>(num);
  }

  public static Il2CppSystem.Object GetScriptingValue_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = DiagnosticSwitch.GetScriptingValue_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
  }

  public static Il2CppSystem.Object GetScriptingPersistentValue_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = DiagnosticSwitch.GetScriptingPersistentValue_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
  }

  public static void SetScriptingValue_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Object value,
    bool setPersistent)
  {
    DiagnosticSwitch.SetScriptingValue_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value), setPersistent);
  }

  public enum Flags
  {
    None,
    CanChangeAfterEngineStart,
    PropagateToAssetImportWorkerProcess,
  }

  public static class BindingsMarshaller
  {
  }

  private delegate void get_name_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void get_description_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void get_owningModule_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate DiagnosticSwitch.Flags get_flags_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr get_defaultValue_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr get_minValue_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr get_maxValue_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr get_enumInfo_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr GetScriptingValue_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr GetScriptingPersistentValue_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void SetScriptingValue_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr value,
    bool setPersistent);
}
