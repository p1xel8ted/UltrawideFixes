// Decompiled with JetBrains decompiler
// Type: UnityEngine.LensFlare
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class LensFlare : Behaviour
{
  private static readonly LensFlare.get_brightness_InjectedDelegate get_brightness_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_brightness_InjectedDelegate>("UnityEngine.LensFlare::get_brightness_Injected");
  private static readonly LensFlare.set_brightness_InjectedDelegate set_brightness_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_brightness_InjectedDelegate>("UnityEngine.LensFlare::set_brightness_Injected");
  private static readonly LensFlare.get_fadeSpeed_InjectedDelegate get_fadeSpeed_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_fadeSpeed_InjectedDelegate>("UnityEngine.LensFlare::get_fadeSpeed_Injected");
  private static readonly LensFlare.set_fadeSpeed_InjectedDelegate set_fadeSpeed_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_fadeSpeed_InjectedDelegate>("UnityEngine.LensFlare::set_fadeSpeed_Injected");
  private static readonly LensFlare.get_color_InjectedDelegate get_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_color_InjectedDelegate>("UnityEngine.LensFlare::get_color_Injected");
  private static readonly LensFlare.set_color_InjectedDelegate set_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_color_InjectedDelegate>("UnityEngine.LensFlare::set_color_Injected");
  private static readonly LensFlare.get_flare_InjectedDelegate get_flare_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_flare_InjectedDelegate>("UnityEngine.LensFlare::get_flare_Injected");
  private static readonly LensFlare.set_flare_InjectedDelegate set_flare_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_flare_InjectedDelegate>("UnityEngine.LensFlare::set_flare_Injected");

  public float brightness
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LensFlare.get_brightness_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LensFlare.set_brightness_Injected(_unity_self, value);
    }
  }

  public float fadeSpeed
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LensFlare.get_fadeSpeed_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LensFlare.set_fadeSpeed_Injected(_unity_self, value);
    }
  }

  public Color color
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Color ret;
      LensFlare.get_color_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LensFlare.set_color_Injected(_unity_self, ref value);
    }
  }

  public Flare flare
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Flare>(LensFlare.get_flare_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LensFlare>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LensFlare.set_flare_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Flare>(value));
    }
  }

  public static float get_brightness_Injected(System.IntPtr _unity_self)
  {
    return LensFlare.get_brightness_InjectedDelegateField(_unity_self);
  }

  public static void set_brightness_Injected(System.IntPtr _unity_self, float value)
  {
    LensFlare.set_brightness_InjectedDelegateField(_unity_self, value);
  }

  public static float get_fadeSpeed_Injected(System.IntPtr _unity_self)
  {
    return LensFlare.get_fadeSpeed_InjectedDelegateField(_unity_self);
  }

  public static void set_fadeSpeed_Injected(System.IntPtr _unity_self, float value)
  {
    LensFlare.set_fadeSpeed_InjectedDelegateField(_unity_self, value);
  }

  public static void get_color_Injected(System.IntPtr _unity_self, out Color ret)
  {
    LensFlare.get_color_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_color_Injected(System.IntPtr _unity_self, [In] ref Color value)
  {
    LensFlare.set_color_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static System.IntPtr get_flare_Injected(System.IntPtr _unity_self)
  {
    return LensFlare.get_flare_InjectedDelegateField(_unity_self);
  }

  public static void set_flare_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    LensFlare.set_flare_InjectedDelegateField(_unity_self, value);
  }

  private delegate float get_brightness_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_brightness_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_fadeSpeed_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_fadeSpeed_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate void get_color_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_color_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate System.IntPtr get_flare_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_flare_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);
}
