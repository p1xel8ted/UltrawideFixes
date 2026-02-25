// Decompiled with JetBrains decompiler
// Type: UnityEngine.LightProbeProxyVolume
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class LightProbeProxyVolume(System.IntPtr pointer) : Behaviour(pointer)
{
  private static readonly LightProbeProxyVolume.get_isFeatureSupportedDelegate get_isFeatureSupportedDelegateField;
  private static readonly LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate get_boundsGlobal_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_sizeCustom_InjectedDelegate get_sizeCustom_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_sizeCustom_InjectedDelegate set_sizeCustom_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_originCustom_InjectedDelegate get_originCustom_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_originCustom_InjectedDelegate set_originCustom_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_probeDensity_InjectedDelegate get_probeDensity_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_probeDensity_InjectedDelegate set_probeDensity_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_gridResolutionX_InjectedDelegate get_gridResolutionX_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_gridResolutionX_InjectedDelegate set_gridResolutionX_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_gridResolutionY_InjectedDelegate get_gridResolutionY_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_gridResolutionY_InjectedDelegate set_gridResolutionY_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_gridResolutionZ_InjectedDelegate get_gridResolutionZ_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_gridResolutionZ_InjectedDelegate set_gridResolutionZ_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_boundingBoxMode_InjectedDelegate get_boundingBoxMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_boundingBoxMode_InjectedDelegate set_boundingBoxMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_resolutionMode_InjectedDelegate get_resolutionMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_resolutionMode_InjectedDelegate set_resolutionMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_probePositionMode_InjectedDelegate get_probePositionMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_probePositionMode_InjectedDelegate set_probePositionMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_refreshMode_InjectedDelegate get_refreshMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_refreshMode_InjectedDelegate set_refreshMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_qualityMode_InjectedDelegate get_qualityMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_qualityMode_InjectedDelegate set_qualityMode_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.get_dataFormat_InjectedDelegate get_dataFormat_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.set_dataFormat_InjectedDelegate set_dataFormat_InjectedDelegateField;
  private static readonly LightProbeProxyVolume.SetDirtyFlag_InjectedDelegate SetDirtyFlag_InjectedDelegateField;

  static LightProbeProxyVolume()
  {
    Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LightProbeProxyVolume));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr);
    LightProbeProxyVolume.get_isFeatureSupportedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_isFeatureSupportedDelegate>("UnityEngine.LightProbeProxyVolume::get_isFeatureSupported");
    LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundsGlobal_Injected");
    LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_sizeCustom_Injected");
    LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_sizeCustom_Injected");
    LightProbeProxyVolume.get_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_originCustom_Injected");
    LightProbeProxyVolume.set_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_originCustom_Injected");
    LightProbeProxyVolume.get_probeDensity_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probeDensity_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_probeDensity_Injected");
    LightProbeProxyVolume.set_probeDensity_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probeDensity_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_probeDensity_Injected");
    LightProbeProxyVolume.get_gridResolutionX_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionX_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionX_Injected");
    LightProbeProxyVolume.set_gridResolutionX_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionX_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionX_Injected");
    LightProbeProxyVolume.get_gridResolutionY_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionY_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionY_Injected");
    LightProbeProxyVolume.set_gridResolutionY_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionY_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionY_Injected");
    LightProbeProxyVolume.get_gridResolutionZ_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionZ_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionZ_Injected");
    LightProbeProxyVolume.set_gridResolutionZ_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionZ_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionZ_Injected");
    LightProbeProxyVolume.get_boundingBoxMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundingBoxMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundingBoxMode_Injected");
    LightProbeProxyVolume.set_boundingBoxMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_boundingBoxMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_boundingBoxMode_Injected");
    LightProbeProxyVolume.get_resolutionMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_resolutionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_resolutionMode_Injected");
    LightProbeProxyVolume.set_resolutionMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_resolutionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_resolutionMode_Injected");
    LightProbeProxyVolume.get_probePositionMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probePositionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_probePositionMode_Injected");
    LightProbeProxyVolume.set_probePositionMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probePositionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_probePositionMode_Injected");
    LightProbeProxyVolume.get_refreshMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_refreshMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_refreshMode_Injected");
    LightProbeProxyVolume.set_refreshMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_refreshMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_refreshMode_Injected");
    LightProbeProxyVolume.get_qualityMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_qualityMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_qualityMode_Injected");
    LightProbeProxyVolume.set_qualityMode_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_qualityMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_qualityMode_Injected");
    LightProbeProxyVolume.get_dataFormat_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_dataFormat_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_dataFormat_Injected");
    LightProbeProxyVolume.set_dataFormat_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_dataFormat_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_dataFormat_Injected");
    LightProbeProxyVolume.SetDirtyFlag_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.SetDirtyFlag_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::SetDirtyFlag_Injected");
  }

  public static bool isFeatureSupported
  {
    get => LightProbeProxyVolume.get_isFeatureSupportedDelegateField();
  }

  public Bounds boundsGlobal
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Bounds ret;
      LightProbeProxyVolume.get_boundsGlobal_Injected(_unity_self, out ret);
      return ret;
    }
  }

  public Vector3 sizeCustom
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      LightProbeProxyVolume.get_sizeCustom_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_sizeCustom_Injected(_unity_self, ref value);
    }
  }

  public Vector3 originCustom
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Vector3 ret;
      LightProbeProxyVolume.get_originCustom_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_originCustom_Injected(_unity_self, ref value);
    }
  }

  public float probeDensity
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_probeDensity_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_probeDensity_Injected(_unity_self, value);
    }
  }

  public int gridResolutionX
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_gridResolutionX_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_gridResolutionX_Injected(_unity_self, value);
    }
  }

  public int gridResolutionY
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_gridResolutionY_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_gridResolutionY_Injected(_unity_self, value);
    }
  }

  public int gridResolutionZ
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_gridResolutionZ_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_gridResolutionZ_Injected(_unity_self, value);
    }
  }

  public LightProbeProxyVolume.BoundingBoxMode boundingBoxMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_boundingBoxMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_boundingBoxMode_Injected(_unity_self, value);
    }
  }

  public LightProbeProxyVolume.ResolutionMode resolutionMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_resolutionMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_resolutionMode_Injected(_unity_self, value);
    }
  }

  public LightProbeProxyVolume.ProbePositionMode probePositionMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_probePositionMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_probePositionMode_Injected(_unity_self, value);
    }
  }

  public LightProbeProxyVolume.RefreshMode refreshMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_refreshMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_refreshMode_Injected(_unity_self, value);
    }
  }

  public LightProbeProxyVolume.QualityMode qualityMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_qualityMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_qualityMode_Injected(_unity_self, value);
    }
  }

  public LightProbeProxyVolume.DataFormat dataFormat
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbeProxyVolume.get_dataFormat_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbeProxyVolume.set_dataFormat_Injected(_unity_self, value);
    }
  }

  public void Update() => this.SetDirtyFlag(true);

  public void SetDirtyFlag(bool flag)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbeProxyVolume>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    LightProbeProxyVolume.SetDirtyFlag_Injected(_unity_self, flag);
  }

  public static void get_boundsGlobal_Injected(System.IntPtr _unity_self, out Bounds ret)
  {
    LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void get_sizeCustom_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_sizeCustom_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
  {
    LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static void get_originCustom_Injected(System.IntPtr _unity_self, out Vector3 ret)
  {
    LightProbeProxyVolume.get_originCustom_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_originCustom_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
  {
    LightProbeProxyVolume.set_originCustom_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static float get_probeDensity_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_probeDensity_InjectedDelegateField(_unity_self);
  }

  public static void set_probeDensity_Injected(System.IntPtr _unity_self, float value)
  {
    LightProbeProxyVolume.set_probeDensity_InjectedDelegateField(_unity_self, value);
  }

  public static int get_gridResolutionX_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_gridResolutionX_InjectedDelegateField(_unity_self);
  }

  public static void set_gridResolutionX_Injected(System.IntPtr _unity_self, int value)
  {
    LightProbeProxyVolume.set_gridResolutionX_InjectedDelegateField(_unity_self, value);
  }

  public static int get_gridResolutionY_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_gridResolutionY_InjectedDelegateField(_unity_self);
  }

  public static void set_gridResolutionY_Injected(System.IntPtr _unity_self, int value)
  {
    LightProbeProxyVolume.set_gridResolutionY_InjectedDelegateField(_unity_self, value);
  }

  public static int get_gridResolutionZ_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_gridResolutionZ_InjectedDelegateField(_unity_self);
  }

  public static void set_gridResolutionZ_Injected(System.IntPtr _unity_self, int value)
  {
    LightProbeProxyVolume.set_gridResolutionZ_InjectedDelegateField(_unity_self, value);
  }

  public static LightProbeProxyVolume.BoundingBoxMode get_boundingBoxMode_Injected(
    System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_boundingBoxMode_InjectedDelegateField(_unity_self);
  }

  public static void set_boundingBoxMode_Injected(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.BoundingBoxMode value)
  {
    LightProbeProxyVolume.set_boundingBoxMode_InjectedDelegateField(_unity_self, value);
  }

  public static LightProbeProxyVolume.ResolutionMode get_resolutionMode_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_resolutionMode_InjectedDelegateField(_unity_self);
  }

  public static void set_resolutionMode_Injected(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.ResolutionMode value)
  {
    LightProbeProxyVolume.set_resolutionMode_InjectedDelegateField(_unity_self, value);
  }

  public static LightProbeProxyVolume.ProbePositionMode get_probePositionMode_Injected(
    System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_probePositionMode_InjectedDelegateField(_unity_self);
  }

  public static void set_probePositionMode_Injected(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.ProbePositionMode value)
  {
    LightProbeProxyVolume.set_probePositionMode_InjectedDelegateField(_unity_self, value);
  }

  public static LightProbeProxyVolume.RefreshMode get_refreshMode_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_refreshMode_InjectedDelegateField(_unity_self);
  }

  public static void set_refreshMode_Injected(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.RefreshMode value)
  {
    LightProbeProxyVolume.set_refreshMode_InjectedDelegateField(_unity_self, value);
  }

  public static LightProbeProxyVolume.QualityMode get_qualityMode_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_qualityMode_InjectedDelegateField(_unity_self);
  }

  public static void set_qualityMode_Injected(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.QualityMode value)
  {
    LightProbeProxyVolume.set_qualityMode_InjectedDelegateField(_unity_self, value);
  }

  public static LightProbeProxyVolume.DataFormat get_dataFormat_Injected(System.IntPtr _unity_self)
  {
    return LightProbeProxyVolume.get_dataFormat_InjectedDelegateField(_unity_self);
  }

  public static void set_dataFormat_Injected(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.DataFormat value)
  {
    LightProbeProxyVolume.set_dataFormat_InjectedDelegateField(_unity_self, value);
  }

  public static void SetDirtyFlag_Injected(System.IntPtr _unity_self, bool flag)
  {
    LightProbeProxyVolume.SetDirtyFlag_InjectedDelegateField(_unity_self, flag);
  }

  public enum ResolutionMode
  {
    Automatic,
    Custom,
  }

  public enum BoundingBoxMode
  {
    AutomaticLocal,
    AutomaticWorld,
    Custom,
  }

  public enum ProbePositionMode
  {
    CellCorner,
    CellCenter,
  }

  public enum RefreshMode
  {
    Automatic,
    EveryFrame,
    ViaScripting,
  }

  public enum QualityMode
  {
    Low,
    Normal,
  }

  public enum DataFormat
  {
    HalfFloat,
    Float,
  }

  private delegate bool get_isFeatureSupportedDelegate();

  private delegate void get_boundsGlobal_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void get_sizeCustom_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_sizeCustom_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate void get_originCustom_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_originCustom_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate float get_probeDensity_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_probeDensity_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate int get_gridResolutionX_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_gridResolutionX_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate int get_gridResolutionY_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_gridResolutionY_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate int get_gridResolutionZ_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_gridResolutionZ_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate LightProbeProxyVolume.BoundingBoxMode get_boundingBoxMode_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_boundingBoxMode_InjectedDelegate(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.BoundingBoxMode value);

  private delegate LightProbeProxyVolume.ResolutionMode get_resolutionMode_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_resolutionMode_InjectedDelegate(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.ResolutionMode value);

  private delegate LightProbeProxyVolume.ProbePositionMode get_probePositionMode_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_probePositionMode_InjectedDelegate(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.ProbePositionMode value);

  private delegate LightProbeProxyVolume.RefreshMode get_refreshMode_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_refreshMode_InjectedDelegate(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.RefreshMode value);

  private delegate LightProbeProxyVolume.QualityMode get_qualityMode_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_qualityMode_InjectedDelegate(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.QualityMode value);

  private delegate LightProbeProxyVolume.DataFormat get_dataFormat_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_dataFormat_InjectedDelegate(
    System.IntPtr _unity_self,
    LightProbeProxyVolume.DataFormat value);

  private delegate void SetDirtyFlag_InjectedDelegate(System.IntPtr _unity_self, bool flag);
}
