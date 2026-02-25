// Decompiled with JetBrains decompiler
// Type: UnityEngine.CustomRenderTexture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class CustomRenderTexture(System.IntPtr pointer) : RenderTexture(pointer)
{
  private static readonly CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate Internal_CreateCustomRenderTextureDelegateField;
  private static readonly CustomRenderTexture.TriggerUpdate_InjectedDelegate TriggerUpdate_InjectedDelegateField;
  private static readonly CustomRenderTexture.TriggerInitialization_InjectedDelegate TriggerInitialization_InjectedDelegateField;
  private static readonly CustomRenderTexture.ClearUpdateZones_InjectedDelegate ClearUpdateZones_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_material_InjectedDelegate get_material_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_material_InjectedDelegate set_material_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_initializationMaterial_InjectedDelegate get_initializationMaterial_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_initializationMaterial_InjectedDelegate set_initializationMaterial_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_initializationTexture_InjectedDelegate get_initializationTexture_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_initializationTexture_InjectedDelegate set_initializationTexture_InjectedDelegateField;
  private static readonly CustomRenderTexture.GetUpdateZonesInternal_InjectedDelegate GetUpdateZonesInternal_InjectedDelegateField;
  private static readonly CustomRenderTexture.SetUpdateZonesInternal_InjectedDelegate SetUpdateZonesInternal_InjectedDelegateField;
  private static readonly CustomRenderTexture.GetDoubleBufferRenderTexture_InjectedDelegate GetDoubleBufferRenderTexture_InjectedDelegateField;
  private static readonly CustomRenderTexture.EnsureDoubleBufferConsistency_InjectedDelegate EnsureDoubleBufferConsistency_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_initializationSource_InjectedDelegate get_initializationSource_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_initializationSource_InjectedDelegate set_initializationSource_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_initializationColor_InjectedDelegate get_initializationColor_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_initializationColor_InjectedDelegate set_initializationColor_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_updateMode_InjectedDelegate get_updateMode_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_updateMode_InjectedDelegate set_updateMode_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_initializationMode_InjectedDelegate get_initializationMode_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_initializationMode_InjectedDelegate set_initializationMode_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_updateZoneSpace_InjectedDelegate get_updateZoneSpace_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_updateZoneSpace_InjectedDelegate set_updateZoneSpace_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_shaderPass_InjectedDelegate get_shaderPass_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_shaderPass_InjectedDelegate set_shaderPass_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_cubemapFaceMask_InjectedDelegate get_cubemapFaceMask_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_cubemapFaceMask_InjectedDelegate set_cubemapFaceMask_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_doubleBuffered_InjectedDelegate get_doubleBuffered_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_doubleBuffered_InjectedDelegate set_doubleBuffered_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_wrapUpdateZones_InjectedDelegate get_wrapUpdateZones_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_wrapUpdateZones_InjectedDelegate set_wrapUpdateZones_InjectedDelegateField;
  private static readonly CustomRenderTexture.get_updatePeriod_InjectedDelegate get_updatePeriod_InjectedDelegateField;
  private static readonly CustomRenderTexture.set_updatePeriod_InjectedDelegate set_updatePeriod_InjectedDelegateField;

  static CustomRenderTexture()
  {
    Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CustomRenderTexture));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr);
    CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate>("UnityEngine.CustomRenderTexture::Internal_CreateCustomRenderTexture");
    CustomRenderTexture.TriggerUpdate_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerUpdate_InjectedDelegate>("UnityEngine.CustomRenderTexture::TriggerUpdate_Injected");
    CustomRenderTexture.TriggerInitialization_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerInitialization_InjectedDelegate>("UnityEngine.CustomRenderTexture::TriggerInitialization_Injected");
    CustomRenderTexture.ClearUpdateZones_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.ClearUpdateZones_InjectedDelegate>("UnityEngine.CustomRenderTexture::ClearUpdateZones_Injected");
    CustomRenderTexture.get_material_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_material_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_material_Injected");
    CustomRenderTexture.set_material_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_material_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_material_Injected");
    CustomRenderTexture.get_initializationMaterial_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationMaterial_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationMaterial_Injected");
    CustomRenderTexture.set_initializationMaterial_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationMaterial_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationMaterial_Injected");
    CustomRenderTexture.get_initializationTexture_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationTexture_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationTexture_Injected");
    CustomRenderTexture.set_initializationTexture_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationTexture_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationTexture_Injected");
    CustomRenderTexture.GetUpdateZonesInternal_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetUpdateZonesInternal_InjectedDelegate>("UnityEngine.CustomRenderTexture::GetUpdateZonesInternal_Injected");
    CustomRenderTexture.SetUpdateZonesInternal_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.SetUpdateZonesInternal_InjectedDelegate>("UnityEngine.CustomRenderTexture::SetUpdateZonesInternal_Injected");
    CustomRenderTexture.GetDoubleBufferRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetDoubleBufferRenderTexture_InjectedDelegate>("UnityEngine.CustomRenderTexture::GetDoubleBufferRenderTexture_Injected");
    CustomRenderTexture.EnsureDoubleBufferConsistency_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.EnsureDoubleBufferConsistency_InjectedDelegate>("UnityEngine.CustomRenderTexture::EnsureDoubleBufferConsistency_Injected");
    CustomRenderTexture.get_initializationSource_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationSource_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationSource_Injected");
    CustomRenderTexture.set_initializationSource_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationSource_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationSource_Injected");
    CustomRenderTexture.get_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationColor_Injected");
    CustomRenderTexture.set_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationColor_Injected");
    CustomRenderTexture.get_updateMode_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_updateMode_Injected");
    CustomRenderTexture.set_updateMode_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_updateMode_Injected");
    CustomRenderTexture.get_initializationMode_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationMode_Injected");
    CustomRenderTexture.set_initializationMode_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationMode_Injected");
    CustomRenderTexture.get_updateZoneSpace_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateZoneSpace_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_updateZoneSpace_Injected");
    CustomRenderTexture.set_updateZoneSpace_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateZoneSpace_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_updateZoneSpace_Injected");
    CustomRenderTexture.get_shaderPass_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_shaderPass_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_shaderPass_Injected");
    CustomRenderTexture.set_shaderPass_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_shaderPass_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_shaderPass_Injected");
    CustomRenderTexture.get_cubemapFaceMask_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_cubemapFaceMask_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_cubemapFaceMask_Injected");
    CustomRenderTexture.set_cubemapFaceMask_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_cubemapFaceMask_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_cubemapFaceMask_Injected");
    CustomRenderTexture.get_doubleBuffered_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_doubleBuffered_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_doubleBuffered_Injected");
    CustomRenderTexture.set_doubleBuffered_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_doubleBuffered_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_doubleBuffered_Injected");
    CustomRenderTexture.get_wrapUpdateZones_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_wrapUpdateZones_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_wrapUpdateZones_Injected");
    CustomRenderTexture.set_wrapUpdateZones_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_wrapUpdateZones_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_wrapUpdateZones_Injected");
    CustomRenderTexture.get_updatePeriod_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updatePeriod_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_updatePeriod_Injected");
    CustomRenderTexture.set_updatePeriod_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updatePeriod_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_updatePeriod_Injected");
  }

  public static void Internal_CreateCustomRenderTexture(CustomRenderTexture rt)
  {
    CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rt));
  }

  public void TriggerUpdate(int count)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CustomRenderTexture.TriggerUpdate_Injected(_unity_self, count);
  }

  public void Update(int count)
  {
    CustomRenderTextureManager.InvokeTriggerUpdate(this, count);
    this.TriggerUpdate(count);
  }

  public void Update() => this.Update(1);

  public void TriggerInitialization()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CustomRenderTexture.TriggerInitialization_Injected(_unity_self);
  }

  public void Initialize()
  {
    this.TriggerInitialization();
    CustomRenderTextureManager.InvokeTriggerInitialize(this);
  }

  public void ClearUpdateZones()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CustomRenderTexture.ClearUpdateZones_Injected(_unity_self);
  }

  public Material material
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Material>(CustomRenderTexture.get_material_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_material_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Material>(value));
    }
  }

  public Material initializationMaterial
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Material>(CustomRenderTexture.get_initializationMaterial_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_initializationMaterial_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Material>(value));
    }
  }

  public Texture initializationTexture
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Texture>(CustomRenderTexture.get_initializationTexture_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_initializationTexture_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(value));
    }
  }

  public void GetUpdateZonesInternal(Il2CppSystem.Object updateZones)
  {
    if (updateZones == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(updateZones, nameof (updateZones));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CustomRenderTexture.GetUpdateZonesInternal_Injected(_unity_self, updateZones);
  }

  public RenderTexture GetDoubleBufferRenderTexture()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Unmarshal.UnmarshalUnityObject<RenderTexture>(CustomRenderTexture.GetDoubleBufferRenderTexture_Injected(_unity_self));
  }

  public void EnsureDoubleBufferConsistency()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CustomRenderTexture.EnsureDoubleBufferConsistency_Injected(_unity_self);
  }

  public CustomRenderTextureInitializationSource initializationSource
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_initializationSource_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_initializationSource_Injected(_unity_self, value);
    }
  }

  public Color initializationColor
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Color ret;
      CustomRenderTexture.get_initializationColor_Injected(_unity_self, out ret);
      return ret;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_initializationColor_Injected(_unity_self, ref value);
    }
  }

  public CustomRenderTextureUpdateMode updateMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_updateMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_updateMode_Injected(_unity_self, value);
    }
  }

  public CustomRenderTextureUpdateMode initializationMode
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_initializationMode_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_initializationMode_Injected(_unity_self, value);
    }
  }

  public CustomRenderTextureUpdateZoneSpace updateZoneSpace
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_updateZoneSpace_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_updateZoneSpace_Injected(_unity_self, value);
    }
  }

  public int shaderPass
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_shaderPass_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_shaderPass_Injected(_unity_self, value);
    }
  }

  public uint cubemapFaceMask
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_cubemapFaceMask_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_cubemapFaceMask_Injected(_unity_self, value);
    }
  }

  public bool doubleBuffered
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_doubleBuffered_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_doubleBuffered_Injected(_unity_self, value);
    }
  }

  public bool wrapUpdateZones
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_wrapUpdateZones_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_wrapUpdateZones_Injected(_unity_self, value);
    }
  }

  public float updatePeriod
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CustomRenderTexture.get_updatePeriod_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CustomRenderTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CustomRenderTexture.set_updatePeriod_Injected(_unity_self, value);
    }
  }

  public static void TriggerUpdate_Injected(System.IntPtr _unity_self, int count)
  {
    CustomRenderTexture.TriggerUpdate_InjectedDelegateField(_unity_self, count);
  }

  public static void TriggerInitialization_Injected(System.IntPtr _unity_self)
  {
    CustomRenderTexture.TriggerInitialization_InjectedDelegateField(_unity_self);
  }

  public static void ClearUpdateZones_Injected(System.IntPtr _unity_self)
  {
    CustomRenderTexture.ClearUpdateZones_InjectedDelegateField(_unity_self);
  }

  public static System.IntPtr get_material_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_material_InjectedDelegateField(_unity_self);
  }

  public static void set_material_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    CustomRenderTexture.set_material_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_initializationMaterial_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_initializationMaterial_InjectedDelegateField(_unity_self);
  }

  public static void set_initializationMaterial_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    CustomRenderTexture.set_initializationMaterial_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_initializationTexture_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_initializationTexture_InjectedDelegateField(_unity_self);
  }

  public static void set_initializationTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    CustomRenderTexture.set_initializationTexture_InjectedDelegateField(_unity_self, value);
  }

  public static void GetUpdateZonesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object updateZones)
  {
    CustomRenderTexture.GetUpdateZonesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) updateZones));
  }

  public static void SetUpdateZonesInternal_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper updateZones)
  {
    CustomRenderTexture.SetUpdateZonesInternal_InjectedDelegateField(_unity_self, (System.IntPtr) ref updateZones);
  }

  public static System.IntPtr GetDoubleBufferRenderTexture_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.GetDoubleBufferRenderTexture_InjectedDelegateField(_unity_self);
  }

  public static void EnsureDoubleBufferConsistency_Injected(System.IntPtr _unity_self)
  {
    CustomRenderTexture.EnsureDoubleBufferConsistency_InjectedDelegateField(_unity_self);
  }

  public static CustomRenderTextureInitializationSource get_initializationSource_Injected(
    System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_initializationSource_InjectedDelegateField(_unity_self);
  }

  public static void set_initializationSource_Injected(
    System.IntPtr _unity_self,
    CustomRenderTextureInitializationSource value)
  {
    CustomRenderTexture.set_initializationSource_InjectedDelegateField(_unity_self, value);
  }

  public static void get_initializationColor_Injected(System.IntPtr _unity_self, out Color ret)
  {
    CustomRenderTexture.get_initializationColor_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_initializationColor_Injected(System.IntPtr _unity_self, [In] ref Color value)
  {
    CustomRenderTexture.set_initializationColor_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static CustomRenderTextureUpdateMode get_updateMode_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_updateMode_InjectedDelegateField(_unity_self);
  }

  public static void set_updateMode_Injected(
    System.IntPtr _unity_self,
    CustomRenderTextureUpdateMode value)
  {
    CustomRenderTexture.set_updateMode_InjectedDelegateField(_unity_self, value);
  }

  public static CustomRenderTextureUpdateMode get_initializationMode_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_initializationMode_InjectedDelegateField(_unity_self);
  }

  public static void set_initializationMode_Injected(
    System.IntPtr _unity_self,
    CustomRenderTextureUpdateMode value)
  {
    CustomRenderTexture.set_initializationMode_InjectedDelegateField(_unity_self, value);
  }

  public static CustomRenderTextureUpdateZoneSpace get_updateZoneSpace_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_updateZoneSpace_InjectedDelegateField(_unity_self);
  }

  public static void set_updateZoneSpace_Injected(
    System.IntPtr _unity_self,
    CustomRenderTextureUpdateZoneSpace value)
  {
    CustomRenderTexture.set_updateZoneSpace_InjectedDelegateField(_unity_self, value);
  }

  public static int get_shaderPass_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_shaderPass_InjectedDelegateField(_unity_self);
  }

  public static void set_shaderPass_Injected(System.IntPtr _unity_self, int value)
  {
    CustomRenderTexture.set_shaderPass_InjectedDelegateField(_unity_self, value);
  }

  public static uint get_cubemapFaceMask_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_cubemapFaceMask_InjectedDelegateField(_unity_self);
  }

  public static void set_cubemapFaceMask_Injected(System.IntPtr _unity_self, uint value)
  {
    CustomRenderTexture.set_cubemapFaceMask_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_doubleBuffered_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_doubleBuffered_InjectedDelegateField(_unity_self);
  }

  public static void set_doubleBuffered_Injected(System.IntPtr _unity_self, bool value)
  {
    CustomRenderTexture.set_doubleBuffered_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_wrapUpdateZones_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_wrapUpdateZones_InjectedDelegateField(_unity_self);
  }

  public static void set_wrapUpdateZones_Injected(System.IntPtr _unity_self, bool value)
  {
    CustomRenderTexture.set_wrapUpdateZones_InjectedDelegateField(_unity_self, value);
  }

  public static float get_updatePeriod_Injected(System.IntPtr _unity_self)
  {
    return CustomRenderTexture.get_updatePeriod_InjectedDelegateField(_unity_self);
  }

  public static void set_updatePeriod_Injected(System.IntPtr _unity_self, float value)
  {
    CustomRenderTexture.set_updatePeriod_InjectedDelegateField(_unity_self, value);
  }

  private delegate void Internal_CreateCustomRenderTextureDelegate(System.IntPtr rt);

  private delegate void TriggerUpdate_InjectedDelegate(System.IntPtr _unity_self, int count);

  private delegate void TriggerInitialization_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void ClearUpdateZones_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr get_material_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_material_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate System.IntPtr get_initializationMaterial_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_initializationMaterial_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr value);

  private delegate System.IntPtr get_initializationTexture_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_initializationTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate void GetUpdateZonesInternal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr updateZones);

  private delegate void SetUpdateZonesInternal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr updateZones);

  private delegate System.IntPtr GetDoubleBufferRenderTexture_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void EnsureDoubleBufferConsistency_InjectedDelegate(System.IntPtr _unity_self);

  private delegate CustomRenderTextureInitializationSource get_initializationSource_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_initializationSource_InjectedDelegate(
    System.IntPtr _unity_self,
    CustomRenderTextureInitializationSource value);

  private delegate void get_initializationColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_initializationColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

  private delegate CustomRenderTextureUpdateMode get_updateMode_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_updateMode_InjectedDelegate(
    System.IntPtr _unity_self,
    CustomRenderTextureUpdateMode value);

  private delegate CustomRenderTextureUpdateMode get_initializationMode_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_initializationMode_InjectedDelegate(
    System.IntPtr _unity_self,
    CustomRenderTextureUpdateMode value);

  private delegate CustomRenderTextureUpdateZoneSpace get_updateZoneSpace_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate void set_updateZoneSpace_InjectedDelegate(
    System.IntPtr _unity_self,
    CustomRenderTextureUpdateZoneSpace value);

  private delegate int get_shaderPass_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_shaderPass_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate uint get_cubemapFaceMask_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_cubemapFaceMask_InjectedDelegate(System.IntPtr _unity_self, uint value);

  private delegate bool get_doubleBuffered_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_doubleBuffered_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate bool get_wrapUpdateZones_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_wrapUpdateZones_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate float get_updatePeriod_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_updatePeriod_InjectedDelegate(System.IntPtr _unity_self, float value);
}
