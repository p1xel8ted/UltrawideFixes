// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SkyAndCloudsParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class SkyAndCloudsParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_doFirmamentPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereRowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereColumnCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereThetaMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereThetaMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_spherePhiMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_spherePhiMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_spherePositionWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereRadius3Ws;
  private static readonly System.IntPtr NativeFieldInfoPtr_topColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_topColorStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_topColorEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_middleColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomColorStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomColorEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_dirLightDistanceWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_totalCloudVolumeDepthWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_frgSkyIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_frgThicknessWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_texCloudCoverageMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_bgrSkyIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_bgrCoverage;
  private static readonly System.IntPtr NativeFieldInfoPtr_bgrCoverageTopVertOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_bgrCoverageBottomVertOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_clBaseNoiseUvwOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_clBaseNoiseUvwScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_clBaseNoiseSmoothness;
  private static readonly System.IntPtr NativeFieldInfoPtr_clBaseShapeTop;
  private static readonly System.IntPtr NativeFieldInfoPtr_clBaseShapeBottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_clDetailNoiseSmoothness;
  private static readonly System.IntPtr NativeFieldInfoPtr_clDetailShapeTop;
  private static readonly System.IntPtr NativeFieldInfoPtr_clDetailShapeBottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_clExtinctionTop;
  private static readonly System.IntPtr NativeFieldInfoPtr_clExtinctionBottom;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Single_Single_Single_Single_Vector3_Vector3_Color_Single_Single_Color_Color_Single_Single_Int32_Single_Single_Single_Single_Single_Texture_Single_Vector2_Single_Single_Vector3_Vector3_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_0;

  static SkyAndCloudsParams()
  {
    Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SkyAndCloudsParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr);
    SkyAndCloudsParams.NativeFieldInfoPtr_doFirmamentPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (doFirmamentPass));
    SkyAndCloudsParams.NativeFieldInfoPtr_sphereRowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (sphereRowCount));
    SkyAndCloudsParams.NativeFieldInfoPtr_sphereColumnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (sphereColumnCount));
    SkyAndCloudsParams.NativeFieldInfoPtr_sphereThetaMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (sphereThetaMin));
    SkyAndCloudsParams.NativeFieldInfoPtr_sphereThetaMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (sphereThetaMax));
    SkyAndCloudsParams.NativeFieldInfoPtr_spherePhiMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (spherePhiMin));
    SkyAndCloudsParams.NativeFieldInfoPtr_spherePhiMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (spherePhiMax));
    SkyAndCloudsParams.NativeFieldInfoPtr_spherePositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (spherePositionWs));
    SkyAndCloudsParams.NativeFieldInfoPtr_sphereRadius3Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (sphereRadius3Ws));
    SkyAndCloudsParams.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (topColor));
    SkyAndCloudsParams.NativeFieldInfoPtr_topColorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (topColorStart));
    SkyAndCloudsParams.NativeFieldInfoPtr_topColorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (topColorEnd));
    SkyAndCloudsParams.NativeFieldInfoPtr_middleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (middleColor));
    SkyAndCloudsParams.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (bottomColor));
    SkyAndCloudsParams.NativeFieldInfoPtr_bottomColorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (bottomColorStart));
    SkyAndCloudsParams.NativeFieldInfoPtr_bottomColorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (bottomColorEnd));
    SkyAndCloudsParams.NativeFieldInfoPtr_debugOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (debugOptions));
    SkyAndCloudsParams.NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (baseShapeNoiseZOffsetSpeed));
    SkyAndCloudsParams.NativeFieldInfoPtr_dirLightDistanceWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (dirLightDistanceWs));
    SkyAndCloudsParams.NativeFieldInfoPtr_totalCloudVolumeDepthWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (totalCloudVolumeDepthWs));
    SkyAndCloudsParams.NativeFieldInfoPtr_frgSkyIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (frgSkyIntensity));
    SkyAndCloudsParams.NativeFieldInfoPtr_frgThicknessWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (frgThicknessWs));
    SkyAndCloudsParams.NativeFieldInfoPtr_texCloudCoverageMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (texCloudCoverageMap));
    SkyAndCloudsParams.NativeFieldInfoPtr_bgrSkyIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (bgrSkyIntensity));
    SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (bgrCoverage));
    SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverageTopVertOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (bgrCoverageTopVertOffset));
    SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverageBottomVertOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (bgrCoverageBottomVertOffset));
    SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseUvwOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clBaseNoiseUvwOffset));
    SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseUvwScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clBaseNoiseUvwScale));
    SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clBaseNoiseSmoothness));
    SkyAndCloudsParams.NativeFieldInfoPtr_clBaseShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clBaseShapeTop));
    SkyAndCloudsParams.NativeFieldInfoPtr_clBaseShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clBaseShapeBottom));
    SkyAndCloudsParams.NativeFieldInfoPtr_clDetailNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clDetailNoiseSmoothness));
    SkyAndCloudsParams.NativeFieldInfoPtr_clDetailShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clDetailShapeTop));
    SkyAndCloudsParams.NativeFieldInfoPtr_clDetailShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clDetailShapeBottom));
    SkyAndCloudsParams.NativeFieldInfoPtr_clExtinctionTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clExtinctionTop));
    SkyAndCloudsParams.NativeFieldInfoPtr_clExtinctionBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, nameof (clExtinctionBottom));
    SkyAndCloudsParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Single_Single_Single_Single_Vector3_Vector3_Color_Single_Single_Color_Color_Single_Single_Int32_Single_Single_Single_Single_Single_Texture_Single_Vector2_Single_Single_Vector3_Vector3_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, 100663605);
  }

  [CallerCount(0)]
  public unsafe SkyAndCloudsParams(
    bool doFirmamentPass,
    int sphereRowCount,
    int sphereColumnCount,
    float sphereThetaMin,
    float sphereThetaMax,
    float spherePhiMin,
    float spherePhiMax,
    Vector3 spherePositionWs,
    Vector3 sphereRadius3Ws,
    Color topColor,
    float topColorStart,
    float topColorEnd,
    Color middleColor,
    Color bottomColor,
    float bottomColorStart,
    float bottomColorEnd,
    int debugOptions,
    float baseShapeNoiseZOffsetSpeed,
    float dirLightDistanceWs,
    float totalCloudVolumeDepthWs,
    float frgSkyIntensity,
    float frgThicknessWs,
    Texture texCloudCoverageMap,
    float bgrSkyIntensity,
    Vector2 bgrCoverageRange,
    float bgrCoverageTopVertOffset,
    float bgrCoverageBottomVertOffset,
    Vector3 clBaseNoiseUvwOffset,
    Vector3 clBaseNoiseUvwScale,
    Vector2 clBaseNoiseSmoothness,
    Vector2 clBaseShapeTop,
    Vector2 clBaseShapeBottom,
    Vector2 clDetailNoiseSmoothness,
    Vector2 clDetailShapeTop,
    Vector2 clDetailShapeBottom,
    Vector2 clExtinctionTop,
    Vector2 clExtinctionBottom)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[37];
    numPtr[0] = (System.IntPtr) &doFirmamentPass;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sphereRowCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sphereColumnCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sphereThetaMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &sphereThetaMax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &spherePhiMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &spherePhiMax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &spherePositionWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &sphereRadius3Ws;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &topColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &topColorStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &topColorEnd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &middleColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &bottomColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = (System.IntPtr) &bottomColorStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) &bottomColorEnd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(16) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOptions;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(17) * sizeof (System.IntPtr))) = (System.IntPtr) &baseShapeNoiseZOffsetSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(18) * sizeof (System.IntPtr))) = (System.IntPtr) &dirLightDistanceWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(19) * sizeof (System.IntPtr))) = (System.IntPtr) &totalCloudVolumeDepthWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(20) * sizeof (System.IntPtr))) = (System.IntPtr) &frgSkyIntensity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(21) * sizeof (System.IntPtr))) = (System.IntPtr) &frgThicknessWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(22) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texCloudCoverageMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(23) * sizeof (System.IntPtr))) = (System.IntPtr) &bgrSkyIntensity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(24) * sizeof (System.IntPtr))) = (System.IntPtr) &bgrCoverageRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(25) * sizeof (System.IntPtr))) = (System.IntPtr) &bgrCoverageTopVertOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(26) * sizeof (System.IntPtr))) = (System.IntPtr) &bgrCoverageBottomVertOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(27) * sizeof (System.IntPtr))) = (System.IntPtr) &clBaseNoiseUvwOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(28) * sizeof (System.IntPtr))) = (System.IntPtr) &clBaseNoiseUvwScale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(29) * sizeof (System.IntPtr))) = (System.IntPtr) &clBaseNoiseSmoothness;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(30) * sizeof (System.IntPtr))) = (System.IntPtr) &clBaseShapeTop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(31) * sizeof (System.IntPtr))) = (System.IntPtr) &clBaseShapeBottom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(32) * sizeof (System.IntPtr))) = (System.IntPtr) &clDetailNoiseSmoothness;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(33) * sizeof (System.IntPtr))) = (System.IntPtr) &clDetailShapeTop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(34) * sizeof (System.IntPtr))) = (System.IntPtr) &clDetailShapeBottom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(35) * sizeof (System.IntPtr))) = (System.IntPtr) &clExtinctionTop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(36) * sizeof (System.IntPtr))) = (System.IntPtr) &clExtinctionBottom;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Single_Single_Single_Single_Vector3_Vector3_Color_Single_Single_Color_Color_Single_Single_Int32_Single_Single_Single_Single_Single_Texture_Single_Vector2_Single_Single_Vector3_Vector3_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public SkyAndCloudsParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public SkyAndCloudsParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr))
  {
  }

  public unsafe bool doFirmamentPass
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_doFirmamentPass));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_doFirmamentPass)) = value;
    }
  }

  public unsafe int sphereRowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereRowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereRowCount)) = value;
    }
  }

  public unsafe int sphereColumnCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereColumnCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereColumnCount)) = value;
    }
  }

  public unsafe float sphereThetaMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereThetaMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereThetaMin)) = value;
    }
  }

  public unsafe float sphereThetaMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereThetaMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereThetaMax)) = value;
    }
  }

  public unsafe float spherePhiMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_spherePhiMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_spherePhiMin)) = value;
    }
  }

  public unsafe float spherePhiMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_spherePhiMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_spherePhiMax)) = value;
    }
  }

  public unsafe Vector3 spherePositionWs
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_spherePositionWs));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_spherePositionWs)) = value;
    }
  }

  public unsafe Vector3 sphereRadius3Ws
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereRadius3Ws));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_sphereRadius3Ws)) = value;
    }
  }

  public unsafe Color topColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_topColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_topColor)) = value;
    }
  }

  public unsafe float topColorStart
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_topColorStart));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_topColorStart)) = value;
    }
  }

  public unsafe float topColorEnd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_topColorEnd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_topColorEnd)) = value;
    }
  }

  public unsafe Color middleColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_middleColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_middleColor)) = value;
    }
  }

  public unsafe Color bottomColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bottomColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bottomColor)) = value;
    }
  }

  public unsafe float bottomColorStart
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bottomColorStart));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bottomColorStart)) = value;
    }
  }

  public unsafe float bottomColorEnd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bottomColorEnd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bottomColorEnd)) = value;
    }
  }

  public unsafe int debugOptions
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_debugOptions));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_debugOptions)) = value;
    }
  }

  public unsafe float baseShapeNoiseZOffsetSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_baseShapeNoiseZOffsetSpeed)) = value;
    }
  }

  public unsafe float dirLightDistanceWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_dirLightDistanceWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_dirLightDistanceWs)) = value;
    }
  }

  public unsafe float totalCloudVolumeDepthWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_totalCloudVolumeDepthWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_totalCloudVolumeDepthWs)) = value;
    }
  }

  public unsafe float frgSkyIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_frgSkyIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_frgSkyIntensity)) = value;
    }
  }

  public unsafe float frgThicknessWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_frgThicknessWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_frgThicknessWs)) = value;
    }
  }

  public unsafe Texture texCloudCoverageMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_texCloudCoverageMap));
      return num == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_texCloudCoverageMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float bgrSkyIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrSkyIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrSkyIntensity)) = value;
    }
  }

  public unsafe Vector2 bgrCoverage
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverage));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverage)) = value;
    }
  }

  public unsafe float bgrCoverageTopVertOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverageTopVertOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverageTopVertOffset)) = value;
    }
  }

  public unsafe float bgrCoverageBottomVertOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverageBottomVertOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_bgrCoverageBottomVertOffset)) = value;
    }
  }

  public unsafe Vector3 clBaseNoiseUvwOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseUvwOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseUvwOffset)) = value;
    }
  }

  public unsafe Vector3 clBaseNoiseUvwScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseUvwScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseUvwScale)) = value;
    }
  }

  public unsafe Vector2 clBaseNoiseSmoothness
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseSmoothness));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseNoiseSmoothness)) = value;
    }
  }

  public unsafe Vector2 clBaseShapeTop
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseShapeTop));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseShapeTop)) = value;
    }
  }

  public unsafe Vector2 clBaseShapeBottom
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseShapeBottom));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clBaseShapeBottom)) = value;
    }
  }

  public unsafe Vector2 clDetailNoiseSmoothness
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clDetailNoiseSmoothness));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clDetailNoiseSmoothness)) = value;
    }
  }

  public unsafe Vector2 clDetailShapeTop
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clDetailShapeTop));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clDetailShapeTop)) = value;
    }
  }

  public unsafe Vector2 clDetailShapeBottom
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clDetailShapeBottom));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clDetailShapeBottom)) = value;
    }
  }

  public unsafe Vector2 clExtinctionTop
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clExtinctionTop));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clExtinctionTop)) = value;
    }
  }

  public unsafe Vector2 clExtinctionBottom
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clExtinctionBottom));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsParams.NativeFieldInfoPtr_clExtinctionBottom)) = value;
    }
  }
}
