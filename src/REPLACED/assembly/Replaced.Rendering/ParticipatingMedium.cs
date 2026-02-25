// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ParticipatingMedium
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public class ParticipatingMedium(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kDensityRange;
  private static readonly IntPtr NativeFieldInfoPtr_kDensityFadeToCenterRange;
  private static readonly IntPtr NativeFieldInfoPtr_kBaseNoiseInfluenceRange;
  private static readonly IntPtr NativeFieldInfoPtr_kCurlNoiseScaleRange;
  private static readonly IntPtr NativeFieldInfoPtr_kExtinctionRange;
  private static readonly IntPtr NativeFieldInfoPtr_kAnisotropyRange;
  private static readonly IntPtr NativeFieldInfoPtr_densityTop;
  private static readonly IntPtr NativeFieldInfoPtr_densityBottom;
  private static readonly IntPtr NativeFieldInfoPtr_densityFadeToCenter;
  private static readonly IntPtr NativeFieldInfoPtr_baseNoiseTiling;
  private static readonly IntPtr NativeFieldInfoPtr_baseNoiseScroll;
  private static readonly IntPtr NativeFieldInfoPtr_baseNoiseInfluenceTop;
  private static readonly IntPtr NativeFieldInfoPtr_baseNoiseInfluenceBottom;
  private static readonly IntPtr NativeFieldInfoPtr_baseNoiseType;
  private static readonly IntPtr NativeFieldInfoPtr_curlNoiseScale;
  private static readonly IntPtr NativeFieldInfoPtr_curlNoiseScroll;
  private static readonly IntPtr NativeFieldInfoPtr_albedo;
  private static readonly IntPtr NativeFieldInfoPtr_extinction;
  private static readonly IntPtr NativeFieldInfoPtr_anisotropy;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ParticipatingMedium()
  {
    Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ParticipatingMedium));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr);
    ParticipatingMedium.NativeFieldInfoPtr_kDensityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (kDensityRange));
    ParticipatingMedium.NativeFieldInfoPtr_kDensityFadeToCenterRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (kDensityFadeToCenterRange));
    ParticipatingMedium.NativeFieldInfoPtr_kBaseNoiseInfluenceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (kBaseNoiseInfluenceRange));
    ParticipatingMedium.NativeFieldInfoPtr_kCurlNoiseScaleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (kCurlNoiseScaleRange));
    ParticipatingMedium.NativeFieldInfoPtr_kExtinctionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (kExtinctionRange));
    ParticipatingMedium.NativeFieldInfoPtr_kAnisotropyRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (kAnisotropyRange));
    ParticipatingMedium.NativeFieldInfoPtr_densityTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (densityTop));
    ParticipatingMedium.NativeFieldInfoPtr_densityBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (densityBottom));
    ParticipatingMedium.NativeFieldInfoPtr_densityFadeToCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (densityFadeToCenter));
    ParticipatingMedium.NativeFieldInfoPtr_baseNoiseTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (baseNoiseTiling));
    ParticipatingMedium.NativeFieldInfoPtr_baseNoiseScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (baseNoiseScroll));
    ParticipatingMedium.NativeFieldInfoPtr_baseNoiseInfluenceTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (baseNoiseInfluenceTop));
    ParticipatingMedium.NativeFieldInfoPtr_baseNoiseInfluenceBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (baseNoiseInfluenceBottom));
    ParticipatingMedium.NativeFieldInfoPtr_baseNoiseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (baseNoiseType));
    ParticipatingMedium.NativeFieldInfoPtr_curlNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (curlNoiseScale));
    ParticipatingMedium.NativeFieldInfoPtr_curlNoiseScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (curlNoiseScroll));
    ParticipatingMedium.NativeFieldInfoPtr_albedo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (albedo));
    ParticipatingMedium.NativeFieldInfoPtr_extinction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (extinction));
    ParticipatingMedium.NativeFieldInfoPtr_anisotropy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, nameof (anisotropy));
    ParticipatingMedium.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, 100664263);
    ParticipatingMedium.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, 100664264);
    ParticipatingMedium.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr, 100664265);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935811, XrefRangeEnd = 935826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipatingMedium.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935826, XrefRangeEnd = 935839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipatingMedium.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935839, XrefRangeEnd = 935846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ParticipatingMedium()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticipatingMedium>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipatingMedium.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2 kDensityRange
  {
    get
    {
      Vector2 kDensityRange;
      IL2CPP.il2cpp_field_static_get_value(ParticipatingMedium.NativeFieldInfoPtr_kDensityRange, (void*) &kDensityRange);
      return kDensityRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticipatingMedium.NativeFieldInfoPtr_kDensityRange, (void*) &value);
    }
  }

  public static unsafe Vector2 kDensityFadeToCenterRange
  {
    get
    {
      Vector2 fadeToCenterRange;
      IL2CPP.il2cpp_field_static_get_value(ParticipatingMedium.NativeFieldInfoPtr_kDensityFadeToCenterRange, (void*) &fadeToCenterRange);
      return fadeToCenterRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticipatingMedium.NativeFieldInfoPtr_kDensityFadeToCenterRange, (void*) &value);
    }
  }

  public static unsafe Vector2 kBaseNoiseInfluenceRange
  {
    get
    {
      Vector2 noiseInfluenceRange;
      IL2CPP.il2cpp_field_static_get_value(ParticipatingMedium.NativeFieldInfoPtr_kBaseNoiseInfluenceRange, (void*) &noiseInfluenceRange);
      return noiseInfluenceRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticipatingMedium.NativeFieldInfoPtr_kBaseNoiseInfluenceRange, (void*) &value);
    }
  }

  public static unsafe Vector2 kCurlNoiseScaleRange
  {
    get
    {
      Vector2 curlNoiseScaleRange;
      IL2CPP.il2cpp_field_static_get_value(ParticipatingMedium.NativeFieldInfoPtr_kCurlNoiseScaleRange, (void*) &curlNoiseScaleRange);
      return curlNoiseScaleRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticipatingMedium.NativeFieldInfoPtr_kCurlNoiseScaleRange, (void*) &value);
    }
  }

  public static unsafe Vector2 kExtinctionRange
  {
    get
    {
      Vector2 kExtinctionRange;
      IL2CPP.il2cpp_field_static_get_value(ParticipatingMedium.NativeFieldInfoPtr_kExtinctionRange, (void*) &kExtinctionRange);
      return kExtinctionRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticipatingMedium.NativeFieldInfoPtr_kExtinctionRange, (void*) &value);
    }
  }

  public static unsafe Vector2 kAnisotropyRange
  {
    get
    {
      Vector2 kAnisotropyRange;
      IL2CPP.il2cpp_field_static_get_value(ParticipatingMedium.NativeFieldInfoPtr_kAnisotropyRange, (void*) &kAnisotropyRange);
      return kAnisotropyRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticipatingMedium.NativeFieldInfoPtr_kAnisotropyRange, (void*) &value);
    }
  }

  public unsafe float densityTop
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_densityTop));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_densityTop)) = value;
    }
  }

  public unsafe float densityBottom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_densityBottom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_densityBottom)) = value;
    }
  }

  public unsafe float densityFadeToCenter
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_densityFadeToCenter));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_densityFadeToCenter)) = value;
    }
  }

  public unsafe Vector3 baseNoiseTiling
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseTiling));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseTiling)) = value;
    }
  }

  public unsafe Vector3 baseNoiseScroll
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseScroll));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseScroll)) = value;
    }
  }

  public unsafe float baseNoiseInfluenceTop
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseInfluenceTop));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseInfluenceTop)) = value;
    }
  }

  public unsafe float baseNoiseInfluenceBottom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseInfluenceBottom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseInfluenceBottom)) = value;
    }
  }

  public unsafe ParticipatingMedium.NoiseType baseNoiseType
  {
    get
    {
      return *(ParticipatingMedium.NoiseType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseType));
    }
    [param: In] set
    {
      *(ParticipatingMedium.NoiseType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_baseNoiseType)) = value;
    }
  }

  public unsafe float curlNoiseScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_curlNoiseScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_curlNoiseScale)) = value;
    }
  }

  public unsafe Vector3 curlNoiseScroll
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_curlNoiseScroll));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_curlNoiseScroll)) = value;
    }
  }

  public unsafe Color albedo
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_albedo));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_albedo)) = value;
    }
  }

  public unsafe float extinction
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_extinction));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_extinction)) = value;
    }
  }

  public unsafe float anisotropy
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_anisotropy));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMedium.NativeFieldInfoPtr_anisotropy)) = value;
    }
  }

  public enum NoiseType
  {
    Grainy,
    Smooth1,
  }
}
