// Decompiled with JetBrains decompiler
// Type: UnityEngine.LODGroup
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class LODGroup : Component
{
  private static readonly LODGroup.get_crossFadeAnimationDurationDelegate get_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.get_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::get_crossFadeAnimationDuration");
  private static readonly LODGroup.set_crossFadeAnimationDurationDelegate set_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.set_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::set_crossFadeAnimationDuration");
  private static readonly LODGroup.get_localReferencePoint_InjectedDelegate get_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_localReferencePoint_Injected");
  private static readonly LODGroup.set_localReferencePoint_InjectedDelegate set_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::set_localReferencePoint_Injected");
  private static readonly LODGroup.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_size_InjectedDelegate>("UnityEngine.LODGroup::get_size_Injected");
  private static readonly LODGroup.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_size_InjectedDelegate>("UnityEngine.LODGroup::set_size_Injected");
  private static readonly LODGroup.get_lodCount_InjectedDelegate get_lodCount_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_lodCount_InjectedDelegate>("UnityEngine.LODGroup::get_lodCount_Injected");
  private static readonly LODGroup.get_lastLODBillboard_InjectedDelegate get_lastLODBillboard_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_lastLODBillboard_InjectedDelegate>("UnityEngine.LODGroup::get_lastLODBillboard_Injected");
  private static readonly LODGroup.set_lastLODBillboard_InjectedDelegate set_lastLODBillboard_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_lastLODBillboard_InjectedDelegate>("UnityEngine.LODGroup::set_lastLODBillboard_Injected");
  private static readonly LODGroup.get_fadeMode_InjectedDelegate get_fadeMode_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_fadeMode_InjectedDelegate>("UnityEngine.LODGroup::get_fadeMode_Injected");
  private static readonly LODGroup.set_fadeMode_InjectedDelegate set_fadeMode_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_fadeMode_InjectedDelegate>("UnityEngine.LODGroup::set_fadeMode_Injected");
  private static readonly LODGroup.get_animateCrossFading_InjectedDelegate get_animateCrossFading_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_animateCrossFading_InjectedDelegate>("UnityEngine.LODGroup::get_animateCrossFading_Injected");
  private static readonly LODGroup.set_animateCrossFading_InjectedDelegate set_animateCrossFading_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_animateCrossFading_InjectedDelegate>("UnityEngine.LODGroup::set_animateCrossFading_Injected");
  private static readonly LODGroup.get_enabled_InjectedDelegate get_enabled_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_enabled_InjectedDelegate>("UnityEngine.LODGroup::get_enabled_Injected");
  private static readonly LODGroup.set_enabled_InjectedDelegate set_enabled_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_enabled_InjectedDelegate>("UnityEngine.LODGroup::set_enabled_Injected");
  private static readonly LODGroup.RecalculateBounds_InjectedDelegate RecalculateBounds_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.RecalculateBounds_InjectedDelegate>("UnityEngine.LODGroup::RecalculateBounds_Injected");
  private static readonly LODGroup.ForceLOD_InjectedDelegate ForceLOD_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.ForceLOD_InjectedDelegate>("UnityEngine.LODGroup::ForceLOD_Injected");
  private static readonly LODGroup.get_worldReferencePoint_InjectedDelegate get_worldReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_worldReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_worldReferencePoint_Injected");

  public Vector3 localReferencePoint
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      LODGroup.get_localReferencePoint_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LODGroup.set_localReferencePoint_Injected(_unity_self, ref value);
    }
  }

  public float size
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LODGroup.get_size_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LODGroup.set_size_Injected(_unity_self, value);
    }
  }

  public int lodCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LODGroup.get_lodCount_Injected(_unity_self);
    }
  }

  public bool lastLODBillboard
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LODGroup.get_lastLODBillboard_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LODGroup.set_lastLODBillboard_Injected(_unity_self, value);
    }
  }

  public LODFadeMode fadeMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LODGroup.get_fadeMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LODGroup.set_fadeMode_Injected(_unity_self, value);
    }
  }

  public bool animateCrossFading
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LODGroup.get_animateCrossFading_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LODGroup.set_animateCrossFading_Injected(_unity_self, value);
    }
  }

  public bool enabled
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LODGroup.get_enabled_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LODGroup.set_enabled_Injected(_unity_self, value);
    }
  }

  public void RecalculateBounds()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    LODGroup.RecalculateBounds_Injected(_unity_self);
  }

  public void ForceLOD(int index)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    LODGroup.ForceLOD_Injected(_unity_self, index);
  }

  public static float crossFadeAnimationDuration
  {
    get => LODGroup.get_crossFadeAnimationDurationDelegateField();
    set => LODGroup.set_crossFadeAnimationDurationDelegateField(value);
  }

  public Vector3 worldReferencePoint
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LODGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      LODGroup.get_worldReferencePoint_Injected(_unity_self, out ret);
      return ret;
    }
  }

  public static void get_localReferencePoint_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    LODGroup.get_localReferencePoint_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_localReferencePoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
  {
    LODGroup.set_localReferencePoint_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static float get_size_Injected(System.IntPtr _unity_self)
  {
    return LODGroup.get_size_InjectedDelegateField(_unity_self);
  }

  public static void set_size_Injected(System.IntPtr _unity_self, float value)
  {
    LODGroup.set_size_InjectedDelegateField(_unity_self, value);
  }

  public static int get_lodCount_Injected(System.IntPtr _unity_self)
  {
    return LODGroup.get_lodCount_InjectedDelegateField(_unity_self);
  }

  public static bool get_lastLODBillboard_Injected(System.IntPtr _unity_self)
  {
    return LODGroup.get_lastLODBillboard_InjectedDelegateField(_unity_self);
  }

  public static void set_lastLODBillboard_Injected(System.IntPtr _unity_self, bool value)
  {
    LODGroup.set_lastLODBillboard_InjectedDelegateField(_unity_self, value);
  }

  public static LODFadeMode get_fadeMode_Injected(System.IntPtr _unity_self)
  {
    return LODGroup.get_fadeMode_InjectedDelegateField(_unity_self);
  }

  public static void set_fadeMode_Injected(System.IntPtr _unity_self, LODFadeMode value)
  {
    LODGroup.set_fadeMode_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_animateCrossFading_Injected(System.IntPtr _unity_self)
  {
    return LODGroup.get_animateCrossFading_InjectedDelegateField(_unity_self);
  }

  public static void set_animateCrossFading_Injected(System.IntPtr _unity_self, bool value)
  {
    LODGroup.set_animateCrossFading_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_enabled_Injected(System.IntPtr _unity_self)
  {
    return LODGroup.get_enabled_InjectedDelegateField(_unity_self);
  }

  public static void set_enabled_Injected(System.IntPtr _unity_self, bool value)
  {
    LODGroup.set_enabled_InjectedDelegateField(_unity_self, value);
  }

  public static void RecalculateBounds_Injected(System.IntPtr _unity_self)
  {
    LODGroup.RecalculateBounds_InjectedDelegateField(_unity_self);
  }

  public static void ForceLOD_Injected(System.IntPtr _unity_self, int index)
  {
    LODGroup.ForceLOD_InjectedDelegateField(_unity_self, index);
  }

  public static void get_worldReferencePoint_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    LODGroup.get_worldReferencePoint_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  private delegate float get_crossFadeAnimationDurationDelegate();

  private delegate void set_crossFadeAnimationDurationDelegate(float value);

  private delegate void get_localReferencePoint_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_localReferencePoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate float get_size_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_size_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate int get_lodCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool get_lastLODBillboard_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_lastLODBillboard_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate LODFadeMode get_fadeMode_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_fadeMode_InjectedDelegate(System.IntPtr _unity_self, LODFadeMode value);

  private delegate bool get_animateCrossFading_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_animateCrossFading_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate bool get_enabled_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_enabled_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate void RecalculateBounds_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void ForceLOD_InjectedDelegate(System.IntPtr _unity_self, int index);

  private delegate void get_worldReferencePoint_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);
}
