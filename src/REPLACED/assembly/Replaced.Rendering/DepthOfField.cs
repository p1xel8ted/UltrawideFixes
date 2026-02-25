// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DepthOfField
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[Serializable]
public sealed class DepthOfField(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kBokehOverlapDefault;
  private static readonly IntPtr NativeFieldInfoPtr_kMovementThresholdShoulder;
  private static readonly IntPtr NativeFieldInfoPtr_kMovementThresholdMax;
  private static readonly IntPtr NativeFieldInfoPtr_enable;
  private static readonly IntPtr NativeFieldInfoPtr_affectsSceneView;
  private static readonly IntPtr NativeFieldInfoPtr_autofocus;
  private static readonly IntPtr NativeFieldInfoPtr_focusPointDistance;
  private static readonly IntPtr NativeFieldInfoPtr_focusFieldStartOffset;
  private static readonly IntPtr NativeFieldInfoPtr_foregroundTotalBlurOffset;
  private static readonly IntPtr NativeFieldInfoPtr_focusFieldEndOffset;
  private static readonly IntPtr NativeFieldInfoPtr_backgroundTotalBlurOffset;
  private static readonly IntPtr NativeFieldInfoPtr_visualizeDistances;
  private static readonly IntPtr NativeFieldInfoPtr_maxCocRadius;
  private static readonly IntPtr NativeFieldInfoPtr_backgroundSharpness;
  private static readonly IntPtr NativeFieldInfoPtr_foregroundSharpness;
  private static readonly IntPtr NativeFieldInfoPtr_enableBokeh;
  private static readonly IntPtr NativeFieldInfoPtr_lumaThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_texBokehShape;
  private static readonly IntPtr NativeFieldInfoPtr_bokehIntensityMin;
  private static readonly IntPtr NativeFieldInfoPtr_bokehIntensityMax;
  private static readonly IntPtr NativeFieldInfoPtr_bokehSizeMultiplierForeground;
  private static readonly IntPtr NativeFieldInfoPtr_cocDiffereceThresholdForeground;
  private static readonly IntPtr NativeFieldInfoPtr_bokehIntensityMultiplierForeground;
  private static readonly IntPtr NativeFieldInfoPtr_bokehSizeMultiplierBackground;
  private static readonly IntPtr NativeFieldInfoPtr_cocDiffereceThresholdBackground;
  private static readonly IntPtr NativeFieldInfoPtr_bokehIntensityMultiplierBackground;
  private static readonly IntPtr NativeFieldInfoPtr_movementThreshold0;
  private static readonly IntPtr NativeFieldInfoPtr_movementThreshold1;
  private static readonly IntPtr NativeFieldInfoPtr_stabilization0;
  private static readonly IntPtr NativeFieldInfoPtr_stabilization1;
  private static readonly IntPtr NativeFieldInfoPtr_showBokehSprites;
  private static readonly IntPtr NativeFieldInfoPtr_debugBokehColor;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DepthOfField()
  {
    Il2CppClassPointerStore<DepthOfField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DepthOfField));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr);
    DepthOfField.NativeFieldInfoPtr_kBokehOverlapDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (kBokehOverlapDefault));
    DepthOfField.NativeFieldInfoPtr_kMovementThresholdShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (kMovementThresholdShoulder));
    DepthOfField.NativeFieldInfoPtr_kMovementThresholdMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (kMovementThresholdMax));
    DepthOfField.NativeFieldInfoPtr_enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (enable));
    DepthOfField.NativeFieldInfoPtr_affectsSceneView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (affectsSceneView));
    DepthOfField.NativeFieldInfoPtr_autofocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (autofocus));
    DepthOfField.NativeFieldInfoPtr_focusPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (focusPointDistance));
    DepthOfField.NativeFieldInfoPtr_focusFieldStartOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (focusFieldStartOffset));
    DepthOfField.NativeFieldInfoPtr_foregroundTotalBlurOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (foregroundTotalBlurOffset));
    DepthOfField.NativeFieldInfoPtr_focusFieldEndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (focusFieldEndOffset));
    DepthOfField.NativeFieldInfoPtr_backgroundTotalBlurOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (backgroundTotalBlurOffset));
    DepthOfField.NativeFieldInfoPtr_visualizeDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (visualizeDistances));
    DepthOfField.NativeFieldInfoPtr_maxCocRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (maxCocRadius));
    DepthOfField.NativeFieldInfoPtr_backgroundSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (backgroundSharpness));
    DepthOfField.NativeFieldInfoPtr_foregroundSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (foregroundSharpness));
    DepthOfField.NativeFieldInfoPtr_enableBokeh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (enableBokeh));
    DepthOfField.NativeFieldInfoPtr_lumaThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (lumaThreshold));
    DepthOfField.NativeFieldInfoPtr_texBokehShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (texBokehShape));
    DepthOfField.NativeFieldInfoPtr_bokehIntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (bokehIntensityMin));
    DepthOfField.NativeFieldInfoPtr_bokehIntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (bokehIntensityMax));
    DepthOfField.NativeFieldInfoPtr_bokehSizeMultiplierForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (bokehSizeMultiplierForeground));
    DepthOfField.NativeFieldInfoPtr_cocDiffereceThresholdForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (cocDiffereceThresholdForeground));
    DepthOfField.NativeFieldInfoPtr_bokehIntensityMultiplierForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (bokehIntensityMultiplierForeground));
    DepthOfField.NativeFieldInfoPtr_bokehSizeMultiplierBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (bokehSizeMultiplierBackground));
    DepthOfField.NativeFieldInfoPtr_cocDiffereceThresholdBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (cocDiffereceThresholdBackground));
    DepthOfField.NativeFieldInfoPtr_bokehIntensityMultiplierBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (bokehIntensityMultiplierBackground));
    DepthOfField.NativeFieldInfoPtr_movementThreshold0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (movementThreshold0));
    DepthOfField.NativeFieldInfoPtr_movementThreshold1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (movementThreshold1));
    DepthOfField.NativeFieldInfoPtr_stabilization0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (stabilization0));
    DepthOfField.NativeFieldInfoPtr_stabilization1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (stabilization1));
    DepthOfField.NativeFieldInfoPtr_showBokehSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (showBokehSprites));
    DepthOfField.NativeFieldInfoPtr_debugBokehColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, nameof (debugBokehColor));
    DepthOfField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, 100663587);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926527, XrefRangeEnd = 926621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DepthOfField()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthOfField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kBokehOverlapDefault
  {
    get
    {
      float bokehOverlapDefault;
      IL2CPP.il2cpp_field_static_get_value(DepthOfField.NativeFieldInfoPtr_kBokehOverlapDefault, (void*) &bokehOverlapDefault);
      return bokehOverlapDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthOfField.NativeFieldInfoPtr_kBokehOverlapDefault, (void*) &value);
    }
  }

  public static unsafe float kMovementThresholdShoulder
  {
    get
    {
      float thresholdShoulder;
      IL2CPP.il2cpp_field_static_get_value(DepthOfField.NativeFieldInfoPtr_kMovementThresholdShoulder, (void*) &thresholdShoulder);
      return thresholdShoulder;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthOfField.NativeFieldInfoPtr_kMovementThresholdShoulder, (void*) &value);
    }
  }

  public static unsafe float kMovementThresholdMax
  {
    get
    {
      float movementThresholdMax;
      IL2CPP.il2cpp_field_static_get_value(DepthOfField.NativeFieldInfoPtr_kMovementThresholdMax, (void*) &movementThresholdMax);
      return movementThresholdMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthOfField.NativeFieldInfoPtr_kMovementThresholdMax, (void*) &value);
    }
  }

  public unsafe BoolParameter enable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_enable));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_enable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter affectsSceneView
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_affectsSceneView));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_affectsSceneView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter autofocus
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_autofocus));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_autofocus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter focusPointDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusPointDistance));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusPointDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MaxFloatParameter focusFieldStartOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusFieldStartOffset));
      return num == IntPtr.Zero ? (MaxFloatParameter) null : Il2CppObjectPool.Get<MaxFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusFieldStartOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MaxFloatParameter foregroundTotalBlurOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_foregroundTotalBlurOffset));
      return num == IntPtr.Zero ? (MaxFloatParameter) null : Il2CppObjectPool.Get<MaxFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_foregroundTotalBlurOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter focusFieldEndOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusFieldEndOffset));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusFieldEndOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter backgroundTotalBlurOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_backgroundTotalBlurOffset));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_backgroundTotalBlurOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter visualizeDistances
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_visualizeDistances));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_visualizeDistances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter maxCocRadius
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_maxCocRadius));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_maxCocRadius), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter backgroundSharpness
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_backgroundSharpness));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_backgroundSharpness), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter foregroundSharpness
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_foregroundSharpness));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_foregroundSharpness), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter enableBokeh
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_enableBokeh));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_enableBokeh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter lumaThreshold
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_lumaThreshold));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_lumaThreshold), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextureParameter texBokehShape
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_texBokehShape));
      return num == IntPtr.Zero ? (TextureParameter) null : Il2CppObjectPool.Get<TextureParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_texBokehShape), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bokehIntensityMin
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMin));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMin), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bokehIntensityMax
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMax));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMax), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bokehSizeMultiplierForeground
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehSizeMultiplierForeground));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehSizeMultiplierForeground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter cocDiffereceThresholdForeground
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_cocDiffereceThresholdForeground));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_cocDiffereceThresholdForeground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bokehIntensityMultiplierForeground
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMultiplierForeground));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMultiplierForeground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bokehSizeMultiplierBackground
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehSizeMultiplierBackground));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehSizeMultiplierBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter cocDiffereceThresholdBackground
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_cocDiffereceThresholdBackground));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_cocDiffereceThresholdBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bokehIntensityMultiplierBackground
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMultiplierBackground));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bokehIntensityMultiplierBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter movementThreshold0
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_movementThreshold0));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_movementThreshold0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter movementThreshold1
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_movementThreshold1));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_movementThreshold1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter stabilization0
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_stabilization0));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_stabilization0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter stabilization1
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_stabilization1));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_stabilization1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter showBokehSprites
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_showBokehSprites));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_showBokehSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter debugBokehColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_debugBokehColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_debugBokehColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
