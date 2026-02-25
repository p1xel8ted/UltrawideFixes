// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.Decal
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

public class Decal(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kPriorityMin;
  private static readonly IntPtr NativeFieldInfoPtr_kPriorityMax;
  private static readonly IntPtr NativeFieldInfoPtr_kOverallInfluenceMin;
  private static readonly IntPtr NativeFieldInfoPtr_kOverallInfluenceMax;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultUvScaleOffset;
  private static readonly IntPtr NativeFieldInfoPtr_material;
  private static readonly IntPtr NativeFieldInfoPtr_priority;
  private static readonly IntPtr NativeFieldInfoPtr_baseColorUvScaleOffset;
  private static readonly IntPtr NativeFieldInfoPtr_specularColorUvScaleOffset;
  private static readonly IntPtr NativeFieldInfoPtr_normalMapUvScaleOffset;
  private static readonly IntPtr NativeFieldInfoPtr_emissionColorUvScaleOffset;
  private static readonly IntPtr NativeFieldInfoPtr_overallInfluence;
  private static readonly IntPtr NativeMethodInfoPtr_GetBaseColorAlpha_Public_Static_Vector4_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetDecalBlendingMode_Public_Static_DecalBlendingMode_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTexBaseColor_Public_Static_Texture_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTexNormalMap_Public_Static_Texture_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSpecularColor_Public_Static_Vector4_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSmoothness_Public_Static_Single_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTexSpecularColor_Public_Static_Texture_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetEmissionColor_Public_Static_Vector4_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTexEmissionColor_Public_Static_Texture_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetBaseColorInfluence_Public_Static_Single_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetNormalMapInfluence_Public_Static_Single_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSpecularColorInfluence_Public_Static_Single_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSmoothnessInfluence_Public_Static_Single_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetEmissionColorInfluence_Public_Static_Single_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Decal()
  {
    Il2CppClassPointerStore<Decal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (Decal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decal>.NativeClassPtr);
    Decal.NativeFieldInfoPtr_kPriorityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (kPriorityMin));
    Decal.NativeFieldInfoPtr_kPriorityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (kPriorityMax));
    Decal.NativeFieldInfoPtr_kOverallInfluenceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (kOverallInfluenceMin));
    Decal.NativeFieldInfoPtr_kOverallInfluenceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (kOverallInfluenceMax));
    Decal.NativeFieldInfoPtr_kDefaultUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (kDefaultUvScaleOffset));
    Decal.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (material));
    Decal.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (priority));
    Decal.NativeFieldInfoPtr_baseColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (baseColorUvScaleOffset));
    Decal.NativeFieldInfoPtr_specularColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (specularColorUvScaleOffset));
    Decal.NativeFieldInfoPtr_normalMapUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (normalMapUvScaleOffset));
    Decal.NativeFieldInfoPtr_emissionColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (emissionColorUvScaleOffset));
    Decal.NativeFieldInfoPtr_overallInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, nameof (overallInfluence));
    Decal.NativeMethodInfoPtr_GetBaseColorAlpha_Public_Static_Vector4_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663669);
    Decal.NativeMethodInfoPtr_GetDecalBlendingMode_Public_Static_DecalBlendingMode_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663670);
    Decal.NativeMethodInfoPtr_GetTexBaseColor_Public_Static_Texture_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663671);
    Decal.NativeMethodInfoPtr_GetTexNormalMap_Public_Static_Texture_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663672);
    Decal.NativeMethodInfoPtr_GetSpecularColor_Public_Static_Vector4_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663673);
    Decal.NativeMethodInfoPtr_GetSmoothness_Public_Static_Single_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663674);
    Decal.NativeMethodInfoPtr_GetTexSpecularColor_Public_Static_Texture_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663675);
    Decal.NativeMethodInfoPtr_GetEmissionColor_Public_Static_Vector4_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663676);
    Decal.NativeMethodInfoPtr_GetTexEmissionColor_Public_Static_Texture_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663677);
    Decal.NativeMethodInfoPtr_GetBaseColorInfluence_Public_Static_Single_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663678);
    Decal.NativeMethodInfoPtr_GetNormalMapInfluence_Public_Static_Single_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663679);
    Decal.NativeMethodInfoPtr_GetSpecularColorInfluence_Public_Static_Single_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663680 /*0x06000180*/);
    Decal.NativeMethodInfoPtr_GetSmoothnessInfluence_Public_Static_Single_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663681);
    Decal.NativeMethodInfoPtr_GetEmissionColorInfluence_Public_Static_Single_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663682);
    Decal.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663683);
    Decal.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663684);
    Decal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100663685);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927440, XrefRangeEnd = 927444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetBaseColorAlpha(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetBaseColorAlpha_Public_Static_Vector4_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927444, XrefRangeEnd = 927449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DecalBlendingMode GetDecalBlendingMode(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetDecalBlendingMode_Public_Static_DecalBlendingMode_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DecalBlendingMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927449, XrefRangeEnd = 927454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexBaseColor(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetTexBaseColor_Public_Static_Texture_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927454, XrefRangeEnd = 927459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexNormalMap(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetTexNormalMap_Public_Static_Texture_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927459, XrefRangeEnd = 927463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetSpecularColor(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetSpecularColor_Public_Static_Vector4_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927463, XrefRangeEnd = 927468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetSmoothness(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetSmoothness_Public_Static_Single_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927468, XrefRangeEnd = 927473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexSpecularColor(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetTexSpecularColor_Public_Static_Texture_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927473, XrefRangeEnd = 927477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetEmissionColor(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetEmissionColor_Public_Static_Vector4_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927477, XrefRangeEnd = 927482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexEmissionColor(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetTexEmissionColor_Public_Static_Texture_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927482, XrefRangeEnd = 927487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetBaseColorInfluence(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetBaseColorInfluence_Public_Static_Single_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927487, XrefRangeEnd = 927492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetNormalMapInfluence(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetNormalMapInfluence_Public_Static_Single_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927492, XrefRangeEnd = 927497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetSpecularColorInfluence(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetSpecularColorInfluence_Public_Static_Single_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927497, XrefRangeEnd = 927502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetSmoothnessInfluence(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetSmoothnessInfluence_Public_Static_Single_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927502, XrefRangeEnd = 927507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetEmissionColorInfluence(Decal decal)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetEmissionColorInfluence_Public_Static_Single_Decal_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927507, XrefRangeEnd = 927518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927518, XrefRangeEnd = 927529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927529, XrefRangeEnd = 927537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Decal()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decal>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kPriorityMin
  {
    get
    {
      int kPriorityMin;
      IL2CPP.il2cpp_field_static_get_value(Decal.NativeFieldInfoPtr_kPriorityMin, (void*) &kPriorityMin);
      return kPriorityMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Decal.NativeFieldInfoPtr_kPriorityMin, (void*) &value);
    }
  }

  public static unsafe int kPriorityMax
  {
    get
    {
      int kPriorityMax;
      IL2CPP.il2cpp_field_static_get_value(Decal.NativeFieldInfoPtr_kPriorityMax, (void*) &kPriorityMax);
      return kPriorityMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Decal.NativeFieldInfoPtr_kPriorityMax, (void*) &value);
    }
  }

  public static unsafe float kOverallInfluenceMin
  {
    get
    {
      float overallInfluenceMin;
      IL2CPP.il2cpp_field_static_get_value(Decal.NativeFieldInfoPtr_kOverallInfluenceMin, (void*) &overallInfluenceMin);
      return overallInfluenceMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Decal.NativeFieldInfoPtr_kOverallInfluenceMin, (void*) &value);
    }
  }

  public static unsafe float kOverallInfluenceMax
  {
    get
    {
      float overallInfluenceMax;
      IL2CPP.il2cpp_field_static_get_value(Decal.NativeFieldInfoPtr_kOverallInfluenceMax, (void*) &overallInfluenceMax);
      return overallInfluenceMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Decal.NativeFieldInfoPtr_kOverallInfluenceMax, (void*) &value);
    }
  }

  public static unsafe Vector4 kDefaultUvScaleOffset
  {
    get
    {
      Vector4 defaultUvScaleOffset;
      IL2CPP.il2cpp_field_static_get_value(Decal.NativeFieldInfoPtr_kDefaultUvScaleOffset, (void*) &defaultUvScaleOffset);
      return defaultUvScaleOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Decal.NativeFieldInfoPtr_kDefaultUvScaleOffset, (void*) &value);
    }
  }

  public unsafe Material material
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_material));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int priority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_priority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_priority)) = value;
    }
  }

  public unsafe Vector4 baseColorUvScaleOffset
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_baseColorUvScaleOffset));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_baseColorUvScaleOffset)) = value;
    }
  }

  public unsafe Vector4 specularColorUvScaleOffset
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_specularColorUvScaleOffset));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_specularColorUvScaleOffset)) = value;
    }
  }

  public unsafe Vector4 normalMapUvScaleOffset
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_normalMapUvScaleOffset));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_normalMapUvScaleOffset)) = value;
    }
  }

  public unsafe Vector4 emissionColorUvScaleOffset
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_emissionColorUvScaleOffset));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_emissionColorUvScaleOffset)) = value;
    }
  }

  public unsafe float overallInfluence
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_overallInfluence));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_overallInfluence)) = value;
    }
  }
}
