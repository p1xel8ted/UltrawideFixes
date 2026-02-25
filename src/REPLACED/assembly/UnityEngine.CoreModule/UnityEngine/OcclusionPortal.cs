// Decompiled with JetBrains decompiler
// Type: UnityEngine.OcclusionPortal
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine;

public sealed class OcclusionPortal : Component
{
  private static readonly OcclusionPortal.get_open_InjectedDelegate get_open_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionPortal.get_open_InjectedDelegate>("UnityEngine.OcclusionPortal::get_open_Injected");
  private static readonly OcclusionPortal.set_open_InjectedDelegate set_open_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionPortal.set_open_InjectedDelegate>("UnityEngine.OcclusionPortal::set_open_Injected");

  public bool open
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<OcclusionPortal>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return OcclusionPortal.get_open_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<OcclusionPortal>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      OcclusionPortal.set_open_Injected(_unity_self, value);
    }
  }

  public static bool get_open_Injected(System.IntPtr _unity_self)
  {
    return OcclusionPortal.get_open_InjectedDelegateField(_unity_self);
  }

  public static void set_open_Injected(System.IntPtr _unity_self, bool value)
  {
    OcclusionPortal.set_open_InjectedDelegateField(_unity_self, value);
  }

  private delegate bool get_open_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_open_InjectedDelegate(System.IntPtr _unity_self, bool value);
}
