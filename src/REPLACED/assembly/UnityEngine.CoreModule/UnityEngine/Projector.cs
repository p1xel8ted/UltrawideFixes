// Decompiled with JetBrains decompiler
// Type: UnityEngine.Projector
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Projector : Behaviour
{
  private static readonly Projector.get_nearClipPlane_InjectedDelegate get_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_nearClipPlane_InjectedDelegate>("UnityEngine.Projector::get_nearClipPlane_Injected");
  private static readonly Projector.set_nearClipPlane_InjectedDelegate set_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_nearClipPlane_InjectedDelegate>("UnityEngine.Projector::set_nearClipPlane_Injected");
  private static readonly Projector.get_farClipPlane_InjectedDelegate get_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_farClipPlane_InjectedDelegate>("UnityEngine.Projector::get_farClipPlane_Injected");
  private static readonly Projector.set_farClipPlane_InjectedDelegate set_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_farClipPlane_InjectedDelegate>("UnityEngine.Projector::set_farClipPlane_Injected");
  private static readonly Projector.get_fieldOfView_InjectedDelegate get_fieldOfView_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_fieldOfView_InjectedDelegate>("UnityEngine.Projector::get_fieldOfView_Injected");
  private static readonly Projector.set_fieldOfView_InjectedDelegate set_fieldOfView_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_fieldOfView_InjectedDelegate>("UnityEngine.Projector::set_fieldOfView_Injected");
  private static readonly Projector.get_aspectRatio_InjectedDelegate get_aspectRatio_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_aspectRatio_InjectedDelegate>("UnityEngine.Projector::get_aspectRatio_Injected");
  private static readonly Projector.set_aspectRatio_InjectedDelegate set_aspectRatio_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_aspectRatio_InjectedDelegate>("UnityEngine.Projector::set_aspectRatio_Injected");
  private static readonly Projector.get_orthographic_InjectedDelegate get_orthographic_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_orthographic_InjectedDelegate>("UnityEngine.Projector::get_orthographic_Injected");
  private static readonly Projector.set_orthographic_InjectedDelegate set_orthographic_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_orthographic_InjectedDelegate>("UnityEngine.Projector::set_orthographic_Injected");
  private static readonly Projector.get_orthographicSize_InjectedDelegate get_orthographicSize_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicSize_InjectedDelegate>("UnityEngine.Projector::get_orthographicSize_Injected");
  private static readonly Projector.set_orthographicSize_InjectedDelegate set_orthographicSize_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicSize_InjectedDelegate>("UnityEngine.Projector::set_orthographicSize_Injected");
  private static readonly Projector.get_ignoreLayers_InjectedDelegate get_ignoreLayers_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_ignoreLayers_InjectedDelegate>("UnityEngine.Projector::get_ignoreLayers_Injected");
  private static readonly Projector.set_ignoreLayers_InjectedDelegate set_ignoreLayers_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_ignoreLayers_InjectedDelegate>("UnityEngine.Projector::set_ignoreLayers_Injected");
  private static readonly Projector.get_material_InjectedDelegate get_material_InjectedDelegateField = IL2CPP.ResolveICall<Projector.get_material_InjectedDelegate>("UnityEngine.Projector::get_material_Injected");
  private static readonly Projector.set_material_InjectedDelegate set_material_InjectedDelegateField = IL2CPP.ResolveICall<Projector.set_material_InjectedDelegate>("UnityEngine.Projector::set_material_Injected");

  public float nearClipPlane
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Projector.get_nearClipPlane_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_nearClipPlane_Injected(_unity_self, value);
    }
  }

  public float farClipPlane
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Projector.get_farClipPlane_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_farClipPlane_Injected(_unity_self, value);
    }
  }

  public float fieldOfView
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Projector.get_fieldOfView_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_fieldOfView_Injected(_unity_self, value);
    }
  }

  public float aspectRatio
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Projector.get_aspectRatio_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_aspectRatio_Injected(_unity_self, value);
    }
  }

  public bool orthographic
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Projector.get_orthographic_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_orthographic_Injected(_unity_self, value);
    }
  }

  public float orthographicSize
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Projector.get_orthographicSize_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_orthographicSize_Injected(_unity_self, value);
    }
  }

  public int ignoreLayers
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Projector.get_ignoreLayers_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_ignoreLayers_Injected(_unity_self, value);
    }
  }

  public Material material
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Material>(Projector.get_material_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Projector>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Projector.set_material_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Material>(value));
    }
  }

  public static float get_nearClipPlane_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_nearClipPlane_InjectedDelegateField(_unity_self);
  }

  public static void set_nearClipPlane_Injected(System.IntPtr _unity_self, float value)
  {
    Projector.set_nearClipPlane_InjectedDelegateField(_unity_self, value);
  }

  public static float get_farClipPlane_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_farClipPlane_InjectedDelegateField(_unity_self);
  }

  public static void set_farClipPlane_Injected(System.IntPtr _unity_self, float value)
  {
    Projector.set_farClipPlane_InjectedDelegateField(_unity_self, value);
  }

  public static float get_fieldOfView_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_fieldOfView_InjectedDelegateField(_unity_self);
  }

  public static void set_fieldOfView_Injected(System.IntPtr _unity_self, float value)
  {
    Projector.set_fieldOfView_InjectedDelegateField(_unity_self, value);
  }

  public static float get_aspectRatio_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_aspectRatio_InjectedDelegateField(_unity_self);
  }

  public static void set_aspectRatio_Injected(System.IntPtr _unity_self, float value)
  {
    Projector.set_aspectRatio_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_orthographic_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_orthographic_InjectedDelegateField(_unity_self);
  }

  public static void set_orthographic_Injected(System.IntPtr _unity_self, bool value)
  {
    Projector.set_orthographic_InjectedDelegateField(_unity_self, value);
  }

  public static float get_orthographicSize_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_orthographicSize_InjectedDelegateField(_unity_self);
  }

  public static void set_orthographicSize_Injected(System.IntPtr _unity_self, float value)
  {
    Projector.set_orthographicSize_InjectedDelegateField(_unity_self, value);
  }

  public static int get_ignoreLayers_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_ignoreLayers_InjectedDelegateField(_unity_self);
  }

  public static void set_ignoreLayers_Injected(System.IntPtr _unity_self, int value)
  {
    Projector.set_ignoreLayers_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_material_Injected(System.IntPtr _unity_self)
  {
    return Projector.get_material_InjectedDelegateField(_unity_self);
  }

  public static void set_material_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    Projector.set_material_InjectedDelegateField(_unity_self, value);
  }

  private delegate float get_nearClipPlane_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_nearClipPlane_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_farClipPlane_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_farClipPlane_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_fieldOfView_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_fieldOfView_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_aspectRatio_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_aspectRatio_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate bool get_orthographic_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_orthographic_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate float get_orthographicSize_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_orthographicSize_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate int get_ignoreLayers_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_ignoreLayers_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate System.IntPtr get_material_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_material_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);
}
