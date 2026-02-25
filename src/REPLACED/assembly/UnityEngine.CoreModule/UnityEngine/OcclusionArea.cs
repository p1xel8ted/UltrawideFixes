// Decompiled with JetBrains decompiler
// Type: UnityEngine.OcclusionArea
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class OcclusionArea : Component
{
  private static readonly OcclusionArea.get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_center_InjectedDelegate>("UnityEngine.OcclusionArea::get_center_Injected");
  private static readonly OcclusionArea.set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_center_InjectedDelegate>("UnityEngine.OcclusionArea::set_center_Injected");
  private static readonly OcclusionArea.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_size_InjectedDelegate>("UnityEngine.OcclusionArea::get_size_Injected");
  private static readonly OcclusionArea.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_size_InjectedDelegate>("UnityEngine.OcclusionArea::set_size_Injected");

  public Vector3 center
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<OcclusionArea>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      OcclusionArea.get_center_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<OcclusionArea>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      OcclusionArea.set_center_Injected(_unity_self, ref value);
    }
  }

  public Vector3 size
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<OcclusionArea>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      OcclusionArea.get_size_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<OcclusionArea>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      OcclusionArea.set_size_Injected(_unity_self, ref value);
    }
  }

  public static void get_center_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    OcclusionArea.get_center_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_center_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
  {
    OcclusionArea.set_center_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static void get_size_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    OcclusionArea.get_size_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_size_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
  {
    OcclusionArea.set_size_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  private delegate void get_center_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_center_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate void get_size_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_size_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);
}
