// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LightExtraData
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

#nullable disable
namespace SadCatStudios.Rendering;

public class LightExtraData(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultIntensityDirectional;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultIntensityPoint;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultIntensitySpot;
  private static readonly IntPtr NativeFieldInfoPtr_kConeAngleDegreeMin;
  private static readonly IntPtr NativeFieldInfoPtr_kConeAngleDegreeMax;
  private static readonly IntPtr NativeFieldInfoPtr_kInnerConeAnglePercentageMin;
  private static readonly IntPtr NativeFieldInfoPtr_kInnerConeAnglePercentageMax;
  private static readonly IntPtr NativeFieldInfoPtr_kNormalBiasMin;
  private static readonly IntPtr NativeFieldInfoPtr_kNormalBiasMax;
  private static readonly IntPtr NativeFieldInfoPtr_kDepthBiasMin;
  private static readonly IntPtr NativeFieldInfoPtr_kDepthBiasMax;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCountMin;
  private static readonly IntPtr NativeFieldInfoPtr_kCascadeCountMax;
  private static readonly IntPtr NativeFieldInfoPtr_kVolumetricShadowStepMin;
  private static readonly IntPtr NativeFieldInfoPtr_kVolumetricShadowStepMax;
  private static readonly IntPtr NativeFieldInfoPtr_devdbgShowUnityRange;
  private static readonly IntPtr NativeFieldInfoPtr_shapeType;
  private static readonly IntPtr NativeFieldInfoPtr_intensity;
  private static readonly IntPtr NativeFieldInfoPtr_innerConeAnglePercentage;
  private static readonly IntPtr NativeFieldInfoPtr_lineLength;
  private static readonly IntPtr NativeFieldInfoPtr_lineRange;
  private static readonly IntPtr NativeFieldInfoPtr_useInverseSqureLaw;
  private static readonly IntPtr NativeFieldInfoPtr_shadowMappingEnabled;
  private static readonly IntPtr NativeFieldInfoPtr_shadowMapResolution;
  private static readonly IntPtr NativeFieldInfoPtr_shadowTint;
  private static readonly IntPtr NativeFieldInfoPtr_normalBias;
  private static readonly IntPtr NativeFieldInfoPtr_depthBias;
  private static readonly IntPtr NativeFieldInfoPtr_volumetricIntensityMultiplier;
  private static readonly IntPtr NativeFieldInfoPtr_volumetricIntensityLimitEnabled;
  private static readonly IntPtr NativeFieldInfoPtr_volumetricIntensityLimit;
  private static readonly IntPtr NativeFieldInfoPtr_volumetricRangeScaleStart;
  private static readonly IntPtr NativeFieldInfoPtr_volumetricRangeScaleEnd;
  private static readonly IntPtr NativeFieldInfoPtr_cloudIntensityMultiplier;
  private static readonly IntPtr NativeFieldInfoPtr_cloudIntensityLimit;
  private static readonly IntPtr NativeFieldInfoPtr_cloudIntensityLimitEnabled;
  private static readonly IntPtr NativeFieldInfoPtr_texPattern;
  private static readonly IntPtr NativeFieldInfoPtr_patternUvScaleOffset;
  private static readonly IntPtr NativeFieldInfoPtr_patternArraySliceIndex;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LightExtraData()
  {
    Il2CppClassPointerStore<LightExtraData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LightExtraData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr);
    LightExtraData.NativeFieldInfoPtr_kDefaultIntensityDirectional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kDefaultIntensityDirectional));
    LightExtraData.NativeFieldInfoPtr_kDefaultIntensityPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kDefaultIntensityPoint));
    LightExtraData.NativeFieldInfoPtr_kDefaultIntensitySpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kDefaultIntensitySpot));
    LightExtraData.NativeFieldInfoPtr_kConeAngleDegreeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kConeAngleDegreeMin));
    LightExtraData.NativeFieldInfoPtr_kConeAngleDegreeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kConeAngleDegreeMax));
    LightExtraData.NativeFieldInfoPtr_kInnerConeAnglePercentageMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kInnerConeAnglePercentageMin));
    LightExtraData.NativeFieldInfoPtr_kInnerConeAnglePercentageMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kInnerConeAnglePercentageMax));
    LightExtraData.NativeFieldInfoPtr_kNormalBiasMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kNormalBiasMin));
    LightExtraData.NativeFieldInfoPtr_kNormalBiasMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kNormalBiasMax));
    LightExtraData.NativeFieldInfoPtr_kDepthBiasMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kDepthBiasMin));
    LightExtraData.NativeFieldInfoPtr_kDepthBiasMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kDepthBiasMax));
    LightExtraData.NativeFieldInfoPtr_kCascadeCountMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kCascadeCountMin));
    LightExtraData.NativeFieldInfoPtr_kCascadeCountMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kCascadeCountMax));
    LightExtraData.NativeFieldInfoPtr_kVolumetricShadowStepMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kVolumetricShadowStepMin));
    LightExtraData.NativeFieldInfoPtr_kVolumetricShadowStepMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (kVolumetricShadowStepMax));
    LightExtraData.NativeFieldInfoPtr_devdbgShowUnityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (devdbgShowUnityRange));
    LightExtraData.NativeFieldInfoPtr_shapeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (shapeType));
    LightExtraData.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (intensity));
    LightExtraData.NativeFieldInfoPtr_innerConeAnglePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (innerConeAnglePercentage));
    LightExtraData.NativeFieldInfoPtr_lineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (lineLength));
    LightExtraData.NativeFieldInfoPtr_lineRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (lineRange));
    LightExtraData.NativeFieldInfoPtr_useInverseSqureLaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (useInverseSqureLaw));
    LightExtraData.NativeFieldInfoPtr_shadowMappingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (shadowMappingEnabled));
    LightExtraData.NativeFieldInfoPtr_shadowMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (shadowMapResolution));
    LightExtraData.NativeFieldInfoPtr_shadowTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (shadowTint));
    LightExtraData.NativeFieldInfoPtr_normalBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (normalBias));
    LightExtraData.NativeFieldInfoPtr_depthBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (depthBias));
    LightExtraData.NativeFieldInfoPtr_volumetricIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (volumetricIntensityMultiplier));
    LightExtraData.NativeFieldInfoPtr_volumetricIntensityLimitEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (volumetricIntensityLimitEnabled));
    LightExtraData.NativeFieldInfoPtr_volumetricIntensityLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (volumetricIntensityLimit));
    LightExtraData.NativeFieldInfoPtr_volumetricRangeScaleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (volumetricRangeScaleStart));
    LightExtraData.NativeFieldInfoPtr_volumetricRangeScaleEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (volumetricRangeScaleEnd));
    LightExtraData.NativeFieldInfoPtr_cloudIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (cloudIntensityMultiplier));
    LightExtraData.NativeFieldInfoPtr_cloudIntensityLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (cloudIntensityLimit));
    LightExtraData.NativeFieldInfoPtr_cloudIntensityLimitEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (cloudIntensityLimitEnabled));
    LightExtraData.NativeFieldInfoPtr_texPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (texPattern));
    LightExtraData.NativeFieldInfoPtr_patternUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (patternUvScaleOffset));
    LightExtraData.NativeFieldInfoPtr_patternArraySliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, nameof (patternArraySliceIndex));
    LightExtraData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr, 100663933);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931129, XrefRangeEnd = 931130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightExtraData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightExtraData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightExtraData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kDefaultIntensityDirectional
  {
    get
    {
      float intensityDirectional;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kDefaultIntensityDirectional, (void*) &intensityDirectional);
      return intensityDirectional;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kDefaultIntensityDirectional, (void*) &value);
    }
  }

  public static unsafe float kDefaultIntensityPoint
  {
    get
    {
      float defaultIntensityPoint;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kDefaultIntensityPoint, (void*) &defaultIntensityPoint);
      return defaultIntensityPoint;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kDefaultIntensityPoint, (void*) &value);
    }
  }

  public static unsafe float kDefaultIntensitySpot
  {
    get
    {
      float defaultIntensitySpot;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kDefaultIntensitySpot, (void*) &defaultIntensitySpot);
      return defaultIntensitySpot;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kDefaultIntensitySpot, (void*) &value);
    }
  }

  public static unsafe float kConeAngleDegreeMin
  {
    get
    {
      float coneAngleDegreeMin;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kConeAngleDegreeMin, (void*) &coneAngleDegreeMin);
      return coneAngleDegreeMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kConeAngleDegreeMin, (void*) &value);
    }
  }

  public static unsafe float kConeAngleDegreeMax
  {
    get
    {
      float coneAngleDegreeMax;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kConeAngleDegreeMax, (void*) &coneAngleDegreeMax);
      return coneAngleDegreeMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kConeAngleDegreeMax, (void*) &value);
    }
  }

  public static unsafe float kInnerConeAnglePercentageMin
  {
    get
    {
      float anglePercentageMin;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kInnerConeAnglePercentageMin, (void*) &anglePercentageMin);
      return anglePercentageMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kInnerConeAnglePercentageMin, (void*) &value);
    }
  }

  public static unsafe float kInnerConeAnglePercentageMax
  {
    get
    {
      float anglePercentageMax;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kInnerConeAnglePercentageMax, (void*) &anglePercentageMax);
      return anglePercentageMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kInnerConeAnglePercentageMax, (void*) &value);
    }
  }

  public static unsafe float kNormalBiasMin
  {
    get
    {
      float kNormalBiasMin;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kNormalBiasMin, (void*) &kNormalBiasMin);
      return kNormalBiasMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kNormalBiasMin, (void*) &value);
    }
  }

  public static unsafe float kNormalBiasMax
  {
    get
    {
      float kNormalBiasMax;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kNormalBiasMax, (void*) &kNormalBiasMax);
      return kNormalBiasMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kNormalBiasMax, (void*) &value);
    }
  }

  public static unsafe float kDepthBiasMin
  {
    get
    {
      float kDepthBiasMin;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kDepthBiasMin, (void*) &kDepthBiasMin);
      return kDepthBiasMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kDepthBiasMin, (void*) &value);
    }
  }

  public static unsafe float kDepthBiasMax
  {
    get
    {
      float kDepthBiasMax;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kDepthBiasMax, (void*) &kDepthBiasMax);
      return kDepthBiasMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kDepthBiasMax, (void*) &value);
    }
  }

  public static unsafe int kCascadeCountMin
  {
    get
    {
      int kCascadeCountMin;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kCascadeCountMin, (void*) &kCascadeCountMin);
      return kCascadeCountMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kCascadeCountMin, (void*) &value);
    }
  }

  public static unsafe int kCascadeCountMax
  {
    get
    {
      int kCascadeCountMax;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kCascadeCountMax, (void*) &kCascadeCountMax);
      return kCascadeCountMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kCascadeCountMax, (void*) &value);
    }
  }

  public static unsafe int kVolumetricShadowStepMin
  {
    get
    {
      int volumetricShadowStepMin;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kVolumetricShadowStepMin, (void*) &volumetricShadowStepMin);
      return volumetricShadowStepMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kVolumetricShadowStepMin, (void*) &value);
    }
  }

  public static unsafe int kVolumetricShadowStepMax
  {
    get
    {
      int volumetricShadowStepMax;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_kVolumetricShadowStepMax, (void*) &volumetricShadowStepMax);
      return volumetricShadowStepMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_kVolumetricShadowStepMax, (void*) &value);
    }
  }

  public static unsafe bool devdbgShowUnityRange
  {
    get
    {
      bool devdbgShowUnityRange;
      IL2CPP.il2cpp_field_static_get_value(LightExtraData.NativeFieldInfoPtr_devdbgShowUnityRange, (void*) &devdbgShowUnityRange);
      return devdbgShowUnityRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightExtraData.NativeFieldInfoPtr_devdbgShowUnityRange, (void*) &value);
    }
  }

  public unsafe LightShapeType shapeType
  {
    get
    {
      return *(LightShapeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shapeType));
    }
    [param: In] set
    {
      *(LightShapeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shapeType)) = value;
    }
  }

  public unsafe float intensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_intensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_intensity)) = value;
    }
  }

  public unsafe float innerConeAnglePercentage
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_innerConeAnglePercentage));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_innerConeAnglePercentage)) = value;
    }
  }

  public unsafe float lineLength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_lineLength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_lineLength)) = value;
    }
  }

  public unsafe float lineRange
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_lineRange));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_lineRange)) = value;
    }
  }

  public unsafe bool useInverseSqureLaw
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_useInverseSqureLaw));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_useInverseSqureLaw)) = value;
    }
  }

  public unsafe bool shadowMappingEnabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shadowMappingEnabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shadowMappingEnabled)) = value;
    }
  }

  public unsafe int shadowMapResolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shadowMapResolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shadowMapResolution)) = value;
    }
  }

  public unsafe Color shadowTint
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shadowTint));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_shadowTint)) = value;
    }
  }

  public unsafe float normalBias
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_normalBias));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_normalBias)) = value;
    }
  }

  public unsafe float depthBias
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_depthBias));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_depthBias)) = value;
    }
  }

  public unsafe float volumetricIntensityMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricIntensityMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricIntensityMultiplier)) = value;
    }
  }

  public unsafe bool volumetricIntensityLimitEnabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricIntensityLimitEnabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricIntensityLimitEnabled)) = value;
    }
  }

  public unsafe float volumetricIntensityLimit
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricIntensityLimit));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricIntensityLimit)) = value;
    }
  }

  public unsafe float volumetricRangeScaleStart
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricRangeScaleStart));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricRangeScaleStart)) = value;
    }
  }

  public unsafe float volumetricRangeScaleEnd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricRangeScaleEnd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_volumetricRangeScaleEnd)) = value;
    }
  }

  public unsafe float cloudIntensityMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_cloudIntensityMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_cloudIntensityMultiplier)) = value;
    }
  }

  public unsafe float cloudIntensityLimit
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_cloudIntensityLimit));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_cloudIntensityLimit)) = value;
    }
  }

  public unsafe bool cloudIntensityLimitEnabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_cloudIntensityLimitEnabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_cloudIntensityLimitEnabled)) = value;
    }
  }

  public unsafe Texture2DArray texPattern
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_texPattern));
      return num == IntPtr.Zero ? (Texture2DArray) null : Il2CppObjectPool.Get<Texture2DArray>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_texPattern), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4 patternUvScaleOffset
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_patternUvScaleOffset));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_patternUvScaleOffset)) = value;
    }
  }

  public unsafe int patternArraySliceIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_patternArraySliceIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightExtraData.NativeFieldInfoPtr_patternArraySliceIndex)) = value;
    }
  }
}
