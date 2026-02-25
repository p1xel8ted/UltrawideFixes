// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SkyAndClouds
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
public sealed class SkyAndClouds(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_doFirmamentPass;
  private static readonly IntPtr NativeFieldInfoPtr_sphereRowCount;
  private static readonly IntPtr NativeFieldInfoPtr_sphereColumnCount;
  private static readonly IntPtr NativeFieldInfoPtr_sphereThetaRange;
  private static readonly IntPtr NativeFieldInfoPtr_spherePhiRange;
  private static readonly IntPtr NativeFieldInfoPtr_spherePositionWs;
  private static readonly IntPtr NativeFieldInfoPtr_sphereScaleWs;
  private static readonly IntPtr NativeFieldInfoPtr_fillColor;
  private static readonly IntPtr NativeFieldInfoPtr_topColor;
  private static readonly IntPtr NativeFieldInfoPtr_topColorHeight01;
  private static readonly IntPtr NativeFieldInfoPtr_topColorGradient;
  private static readonly IntPtr NativeFieldInfoPtr_bottomColor;
  private static readonly IntPtr NativeFieldInfoPtr_bottomColorHeight01;
  private static readonly IntPtr NativeFieldInfoPtr_bottomColorGradient;
  private static readonly IntPtr NativeFieldInfoPtr_debugOptions;
  private static readonly IntPtr NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_dirLightDistanceWs;
  private static readonly IntPtr NativeFieldInfoPtr_frgSkyCloudIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_frgThicknessWs;
  private static readonly IntPtr NativeFieldInfoPtr_frgExtinctionTop;
  private static readonly IntPtr NativeFieldInfoPtr_frgExtinctionBottom;
  private static readonly IntPtr NativeFieldInfoPtr_texCloudCoverageMap;
  private static readonly IntPtr NativeFieldInfoPtr_frgBaseNoiseUvwOffset;
  private static readonly IntPtr NativeFieldInfoPtr_frgBaseNoiseSmoothness;
  private static readonly IntPtr NativeFieldInfoPtr_frgBaseShapeTop;
  private static readonly IntPtr NativeFieldInfoPtr_frgBaseShapeBottom;
  private static readonly IntPtr NativeFieldInfoPtr_frgDetailNoiseSmoothness;
  private static readonly IntPtr NativeFieldInfoPtr_frgDetailShapeTop;
  private static readonly IntPtr NativeFieldInfoPtr_frgDetailShapeBottom;
  private static readonly IntPtr NativeFieldInfoPtr_bgrSkyCloudIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_bgrThicknessWs;
  private static readonly IntPtr NativeFieldInfoPtr_bgrExtinctionTop;
  private static readonly IntPtr NativeFieldInfoPtr_bgrExtinctionBottom;
  private static readonly IntPtr NativeFieldInfoPtr_bgrCoverageGradientTop;
  private static readonly IntPtr NativeFieldInfoPtr_bgrCoverageTopVertOffset;
  private static readonly IntPtr NativeFieldInfoPtr_bgrCoverageGradientBottom;
  private static readonly IntPtr NativeFieldInfoPtr_bgrCoverageBottomVertOffset;
  private static readonly IntPtr NativeFieldInfoPtr_bgrBaseNoiseUvwOffset;
  private static readonly IntPtr NativeFieldInfoPtr_bgrBaseNoiseSmoothness;
  private static readonly IntPtr NativeFieldInfoPtr_bgrBaseShapeTop;
  private static readonly IntPtr NativeFieldInfoPtr_bgrBaseShapeBottom;
  private static readonly IntPtr NativeFieldInfoPtr_bgrDetailNoiseSmoothness;
  private static readonly IntPtr NativeFieldInfoPtr_bgrDetailShapeTop;
  private static readonly IntPtr NativeFieldInfoPtr_bgrDetailShapeBottom;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SkyAndClouds()
  {
    Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SkyAndClouds));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr);
    SkyAndClouds.NativeFieldInfoPtr_doFirmamentPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (doFirmamentPass));
    SkyAndClouds.NativeFieldInfoPtr_sphereRowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (sphereRowCount));
    SkyAndClouds.NativeFieldInfoPtr_sphereColumnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (sphereColumnCount));
    SkyAndClouds.NativeFieldInfoPtr_sphereThetaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (sphereThetaRange));
    SkyAndClouds.NativeFieldInfoPtr_spherePhiRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (spherePhiRange));
    SkyAndClouds.NativeFieldInfoPtr_spherePositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (spherePositionWs));
    SkyAndClouds.NativeFieldInfoPtr_sphereScaleWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (sphereScaleWs));
    SkyAndClouds.NativeFieldInfoPtr_fillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (fillColor));
    SkyAndClouds.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (topColor));
    SkyAndClouds.NativeFieldInfoPtr_topColorHeight01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (topColorHeight01));
    SkyAndClouds.NativeFieldInfoPtr_topColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (topColorGradient));
    SkyAndClouds.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bottomColor));
    SkyAndClouds.NativeFieldInfoPtr_bottomColorHeight01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bottomColorHeight01));
    SkyAndClouds.NativeFieldInfoPtr_bottomColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bottomColorGradient));
    SkyAndClouds.NativeFieldInfoPtr_debugOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (debugOptions));
    SkyAndClouds.NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (baseShapeNoiseZOffsetSpeed));
    SkyAndClouds.NativeFieldInfoPtr_dirLightDistanceWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (dirLightDistanceWs));
    SkyAndClouds.NativeFieldInfoPtr_frgSkyCloudIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgSkyCloudIntensity));
    SkyAndClouds.NativeFieldInfoPtr_frgThicknessWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgThicknessWs));
    SkyAndClouds.NativeFieldInfoPtr_frgExtinctionTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgExtinctionTop));
    SkyAndClouds.NativeFieldInfoPtr_frgExtinctionBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgExtinctionBottom));
    SkyAndClouds.NativeFieldInfoPtr_texCloudCoverageMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (texCloudCoverageMap));
    SkyAndClouds.NativeFieldInfoPtr_frgBaseNoiseUvwOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgBaseNoiseUvwOffset));
    SkyAndClouds.NativeFieldInfoPtr_frgBaseNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgBaseNoiseSmoothness));
    SkyAndClouds.NativeFieldInfoPtr_frgBaseShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgBaseShapeTop));
    SkyAndClouds.NativeFieldInfoPtr_frgBaseShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgBaseShapeBottom));
    SkyAndClouds.NativeFieldInfoPtr_frgDetailNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgDetailNoiseSmoothness));
    SkyAndClouds.NativeFieldInfoPtr_frgDetailShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgDetailShapeTop));
    SkyAndClouds.NativeFieldInfoPtr_frgDetailShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (frgDetailShapeBottom));
    SkyAndClouds.NativeFieldInfoPtr_bgrSkyCloudIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrSkyCloudIntensity));
    SkyAndClouds.NativeFieldInfoPtr_bgrThicknessWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrThicknessWs));
    SkyAndClouds.NativeFieldInfoPtr_bgrExtinctionTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrExtinctionTop));
    SkyAndClouds.NativeFieldInfoPtr_bgrExtinctionBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrExtinctionBottom));
    SkyAndClouds.NativeFieldInfoPtr_bgrCoverageGradientTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrCoverageGradientTop));
    SkyAndClouds.NativeFieldInfoPtr_bgrCoverageTopVertOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrCoverageTopVertOffset));
    SkyAndClouds.NativeFieldInfoPtr_bgrCoverageGradientBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrCoverageGradientBottom));
    SkyAndClouds.NativeFieldInfoPtr_bgrCoverageBottomVertOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrCoverageBottomVertOffset));
    SkyAndClouds.NativeFieldInfoPtr_bgrBaseNoiseUvwOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrBaseNoiseUvwOffset));
    SkyAndClouds.NativeFieldInfoPtr_bgrBaseNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrBaseNoiseSmoothness));
    SkyAndClouds.NativeFieldInfoPtr_bgrBaseShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrBaseShapeTop));
    SkyAndClouds.NativeFieldInfoPtr_bgrBaseShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrBaseShapeBottom));
    SkyAndClouds.NativeFieldInfoPtr_bgrDetailNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrDetailNoiseSmoothness));
    SkyAndClouds.NativeFieldInfoPtr_bgrDetailShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrDetailShapeTop));
    SkyAndClouds.NativeFieldInfoPtr_bgrDetailShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, nameof (bgrDetailShapeBottom));
    SkyAndClouds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr, 100663655);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927152, XrefRangeEnd = 927298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SkyAndClouds()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyAndClouds>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndClouds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BoolParameter doFirmamentPass
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_doFirmamentPass));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_doFirmamentPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedIntParameter sphereRowCount
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereRowCount));
      return num == IntPtr.Zero ? (ClampedIntParameter) null : Il2CppObjectPool.Get<ClampedIntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereRowCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedIntParameter sphereColumnCount
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereColumnCount));
      return num == IntPtr.Zero ? (ClampedIntParameter) null : Il2CppObjectPool.Get<ClampedIntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereColumnCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatRangeParameter sphereThetaRange
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereThetaRange));
      return num == IntPtr.Zero ? (FloatRangeParameter) null : Il2CppObjectPool.Get<FloatRangeParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereThetaRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatRangeParameter spherePhiRange
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_spherePhiRange));
      return num == IntPtr.Zero ? (FloatRangeParameter) null : Il2CppObjectPool.Get<FloatRangeParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_spherePhiRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3Parameter spherePositionWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_spherePositionWs));
      return num == IntPtr.Zero ? (Vector3Parameter) null : Il2CppObjectPool.Get<Vector3Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_spherePositionWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3Parameter sphereScaleWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereScaleWs));
      return num == IntPtr.Zero ? (Vector3Parameter) null : Il2CppObjectPool.Get<Vector3Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_sphereScaleWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter fillColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_fillColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_fillColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter topColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_topColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_topColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter topColorHeight01
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_topColorHeight01));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_topColorHeight01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter topColorGradient
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_topColorGradient));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_topColorGradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter bottomColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bottomColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bottomColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bottomColorHeight01
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bottomColorHeight01));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bottomColorHeight01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bottomColorGradient
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bottomColorGradient));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bottomColorGradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IntParameter debugOptions
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_debugOptions));
      return num == IntPtr.Zero ? (IntParameter) null : Il2CppObjectPool.Get<IntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_debugOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter baseShapeNoiseZOffsetSpeed
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter dirLightDistanceWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_dirLightDistanceWs));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_dirLightDistanceWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter frgSkyCloudIntensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgSkyCloudIntensity));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgSkyCloudIntensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter frgThicknessWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgThicknessWs));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgThicknessWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter frgExtinctionTop
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgExtinctionTop));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgExtinctionTop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter frgExtinctionBottom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgExtinctionBottom));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgExtinctionBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextureParameter texCloudCoverageMap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_texCloudCoverageMap));
      return num == IntPtr.Zero ? (TextureParameter) null : Il2CppObjectPool.Get<TextureParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_texCloudCoverageMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3Parameter frgBaseNoiseUvwOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseNoiseUvwOffset));
      return num == IntPtr.Zero ? (Vector3Parameter) null : Il2CppObjectPool.Get<Vector3Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseNoiseUvwOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter frgBaseNoiseSmoothness
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseNoiseSmoothness));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseNoiseSmoothness), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter frgBaseShapeTop
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseShapeTop));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseShapeTop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter frgBaseShapeBottom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseShapeBottom));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgBaseShapeBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter frgDetailNoiseSmoothness
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgDetailNoiseSmoothness));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgDetailNoiseSmoothness), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter frgDetailShapeTop
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgDetailShapeTop));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgDetailShapeTop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter frgDetailShapeBottom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgDetailShapeBottom));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_frgDetailShapeBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrSkyCloudIntensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrSkyCloudIntensity));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrSkyCloudIntensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bgrThicknessWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrThicknessWs));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrThicknessWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrExtinctionTop
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrExtinctionTop));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrExtinctionTop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrExtinctionBottom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrExtinctionBottom));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrExtinctionBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrCoverageGradientTop
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageGradientTop));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageGradientTop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrCoverageTopVertOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageTopVertOffset));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageTopVertOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrCoverageGradientBottom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageGradientBottom));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageGradientBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrCoverageBottomVertOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageBottomVertOffset));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrCoverageBottomVertOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3Parameter bgrBaseNoiseUvwOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseNoiseUvwOffset));
      return num == IntPtr.Zero ? (Vector3Parameter) null : Il2CppObjectPool.Get<Vector3Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseNoiseUvwOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bgrBaseNoiseSmoothness
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseNoiseSmoothness));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseNoiseSmoothness), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrBaseShapeTop
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseShapeTop));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseShapeTop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrBaseShapeBottom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseShapeBottom));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrBaseShapeBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bgrDetailNoiseSmoothness
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrDetailNoiseSmoothness));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrDetailNoiseSmoothness), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrDetailShapeTop
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrDetailShapeTop));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrDetailShapeTop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bgrDetailShapeBottom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrDetailShapeBottom));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndClouds.NativeFieldInfoPtr_bgrDetailShapeBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
