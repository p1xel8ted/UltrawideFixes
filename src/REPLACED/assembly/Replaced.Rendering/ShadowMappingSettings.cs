// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowMappingSettings
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[Serializable]
public sealed class ShadowMappingSettings(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kShadowDistanceDefault;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCountDefault;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCountMin;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCountMax;
  private static readonly IntPtr NativeFieldInfoPtr_kSplitRatioDefault;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCount2SplitRatioDefualt;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCount3SplitRatioDefault;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCount4SplitRatioDefault;
  private static readonly IntPtr NativeFieldInfoPtr_shadowDistance;
  private static readonly IntPtr NativeFieldInfoPtr_dlNearPlaneDistance;
  private static readonly IntPtr NativeFieldInfoPtr_dlCascadeCount;
  private static readonly IntPtr NativeFieldInfoPtr_dlCascadeCount2SplitRatio;
  private static readonly IntPtr NativeFieldInfoPtr_dlCascadeCount3SplitRatio;
  private static readonly IntPtr NativeFieldInfoPtr_dlCascadeCount4SplitRatio;
  private static readonly IntPtr NativeFieldInfoPtr_dlDisplayCascadesLayout;
  private static readonly IntPtr NativeMethodInfoPtr_GetDirectionalLightCascadeSplitRatio_Public_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ShadowMappingSettings()
  {
    Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowMappingSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr);
    ShadowMappingSettings.NativeFieldInfoPtr_kShadowDistanceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kShadowDistanceDefault));
    ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kCascadeCountDefault));
    ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kCascadeCountMin));
    ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kCascadeCountMax));
    ShadowMappingSettings.NativeFieldInfoPtr_kSplitRatioDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kSplitRatioDefault));
    ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount2SplitRatioDefualt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kCascadeCount2SplitRatioDefualt));
    ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount3SplitRatioDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kCascadeCount3SplitRatioDefault));
    ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount4SplitRatioDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (kCascadeCount4SplitRatioDefault));
    ShadowMappingSettings.NativeFieldInfoPtr_shadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (shadowDistance));
    ShadowMappingSettings.NativeFieldInfoPtr_dlNearPlaneDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (dlNearPlaneDistance));
    ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (dlCascadeCount));
    ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount2SplitRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (dlCascadeCount2SplitRatio));
    ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount3SplitRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (dlCascadeCount3SplitRatio));
    ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount4SplitRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (dlCascadeCount4SplitRatio));
    ShadowMappingSettings.NativeFieldInfoPtr_dlDisplayCascadesLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, nameof (dlDisplayCascadesLayout));
    ShadowMappingSettings.NativeMethodInfoPtr_GetDirectionalLightCascadeSplitRatio_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, 100663650);
    ShadowMappingSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr, 100663651);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927086, RefRangeEnd = 927087, XrefRangeStart = 927086, XrefRangeEnd = 927086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetDirectionalLightCascadeSplitRatio()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowMappingSettings.NativeMethodInfoPtr_GetDirectionalLightCascadeSplitRatio_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927087, XrefRangeEnd = 927122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowMappingSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowMappingSettings>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowMappingSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kShadowDistanceDefault
  {
    get
    {
      float shadowDistanceDefault;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kShadowDistanceDefault, (void*) &shadowDistanceDefault);
      return shadowDistanceDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kShadowDistanceDefault, (void*) &value);
    }
  }

  public static unsafe int kCascadeCountDefault
  {
    get
    {
      int cascadeCountDefault;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountDefault, (void*) &cascadeCountDefault);
      return cascadeCountDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountDefault, (void*) &value);
    }
  }

  public static unsafe int kCascadeCountMin
  {
    get
    {
      int kCascadeCountMin;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountMin, (void*) &kCascadeCountMin);
      return kCascadeCountMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountMin, (void*) &value);
    }
  }

  public static unsafe int kCascadeCountMax
  {
    get
    {
      int kCascadeCountMax;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountMax, (void*) &kCascadeCountMax);
      return kCascadeCountMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCountMax, (void*) &value);
    }
  }

  public static unsafe Vector3 kSplitRatioDefault
  {
    get
    {
      Vector3 splitRatioDefault;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kSplitRatioDefault, (void*) &splitRatioDefault);
      return splitRatioDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kSplitRatioDefault, (void*) &value);
    }
  }

  public static unsafe float kCascadeCount2SplitRatioDefualt
  {
    get
    {
      float splitRatioDefualt;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount2SplitRatioDefualt, (void*) &splitRatioDefualt);
      return splitRatioDefualt;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount2SplitRatioDefualt, (void*) &value);
    }
  }

  public static unsafe Vector2 kCascadeCount3SplitRatioDefault
  {
    get
    {
      Vector2 splitRatioDefault;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount3SplitRatioDefault, (void*) &splitRatioDefault);
      return splitRatioDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount3SplitRatioDefault, (void*) &value);
    }
  }

  public static unsafe Vector3 kCascadeCount4SplitRatioDefault
  {
    get
    {
      Vector3 splitRatioDefault;
      IL2CPP.il2cpp_field_static_get_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount4SplitRatioDefault, (void*) &splitRatioDefault);
      return splitRatioDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowMappingSettings.NativeFieldInfoPtr_kCascadeCount4SplitRatioDefault, (void*) &value);
    }
  }

  public unsafe MinFloatParameter shadowDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_shadowDistance));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_shadowDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatParameter dlNearPlaneDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlNearPlaneDistance));
      return num == IntPtr.Zero ? (FloatParameter) null : Il2CppObjectPool.Get<FloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlNearPlaneDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedIntParameter dlCascadeCount
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount));
      return num == IntPtr.Zero ? (ClampedIntParameter) null : Il2CppObjectPool.Get<ClampedIntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatParameter dlCascadeCount2SplitRatio
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount2SplitRatio));
      return num == IntPtr.Zero ? (FloatParameter) null : Il2CppObjectPool.Get<FloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount2SplitRatio), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Parameter dlCascadeCount3SplitRatio
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount3SplitRatio));
      return num == IntPtr.Zero ? (Vector2Parameter) null : Il2CppObjectPool.Get<Vector2Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount3SplitRatio), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3Parameter dlCascadeCount4SplitRatio
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount4SplitRatio));
      return num == IntPtr.Zero ? (Vector3Parameter) null : Il2CppObjectPool.Get<Vector3Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlCascadeCount4SplitRatio), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DisplayShadowMapCascadesLayoutParameter dlDisplayCascadesLayout
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlDisplayCascadesLayout));
      return num == IntPtr.Zero ? (DisplayShadowMapCascadesLayoutParameter) null : Il2CppObjectPool.Get<DisplayShadowMapCascadesLayoutParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowMappingSettings.NativeFieldInfoPtr_dlDisplayCascadesLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
