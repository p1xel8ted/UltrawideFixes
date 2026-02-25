// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalMaterialUtils
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

public static class DecalMaterialUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropScriptUpdateCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropDecalBlendingMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameTexBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameTexNormalMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameSpecularColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameSmoothness;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameTexSpecularColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameEmissionColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameTexEmissionColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameBaseColorInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameNormalMapInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameSpecularColorInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameSmoothnessInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPropNameEmissionColorInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidDecalBlendingMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexNormalMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidSpecularColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidSmootness;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSpecularColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidEmissionColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexEmissionColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidBaseColorInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidNormalMapInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidSpecularColorInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidSmoothnessInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidEmissionColorInfluence;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDecalBlendingMode_Public_Static_DecalBlendingMode_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseColorAlpha_Public_Static_Vector4_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexBaseColor_Public_Static_Texture_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexNormalMap_Public_Static_Texture_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSpecularColor_Public_Static_Vector4_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSmoothness_Public_Static_Single_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexSpecularColor_Public_Static_Texture_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEmissionColor_Public_Static_Vector4_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexEmissionColor_Public_Static_Texture_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseColorInfluence_Public_Static_Single_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalMapInfluence_Public_Static_Single_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSpecularColorInfluence_Public_Static_Single_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSmoothnessInfluence_Public_Static_Single_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEmissionColorInfluence_Public_Static_Single_Material_0;

  static DecalMaterialUtils()
  {
    Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalMaterialUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr);
    DecalMaterialUtils.NativeFieldInfoPtr_kPropScriptUpdateCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropScriptUpdateCounter));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropDecalBlendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropDecalBlendingMode));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameBaseColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameTexBaseColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameTexNormalMap));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSpecularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameSpecularColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameSmoothness));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexSpecularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameTexSpecularColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameEmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameEmissionColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexEmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameTexEmissionColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameBaseColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameBaseColorInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameNormalMapInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameNormalMapInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSpecularColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameSpecularColorInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSmoothnessInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameSmoothnessInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kPropNameEmissionColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kPropNameEmissionColorInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidDecalBlendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidDecalBlendingMode));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidBaseColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidTexBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidTexBaseColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidTexNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidTexNormalMap));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidSpecularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidSpecularColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidSmootness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidSmootness));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidTexSpecularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidTexSpecularColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidEmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidEmissionColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidTexEmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidTexEmissionColor));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidBaseColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidBaseColorInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidNormalMapInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidNormalMapInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidSpecularColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidSpecularColorInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidSmoothnessInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidSmoothnessInfluence));
    DecalMaterialUtils.NativeFieldInfoPtr_kSidEmissionColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, nameof (kSidEmissionColorInfluence));
    DecalMaterialUtils.NativeMethodInfoPtr_GetDecalBlendingMode_Public_Static_DecalBlendingMode_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664060);
    DecalMaterialUtils.NativeMethodInfoPtr_GetBaseColorAlpha_Public_Static_Vector4_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664061);
    DecalMaterialUtils.NativeMethodInfoPtr_GetTexBaseColor_Public_Static_Texture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664062);
    DecalMaterialUtils.NativeMethodInfoPtr_GetTexNormalMap_Public_Static_Texture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664063);
    DecalMaterialUtils.NativeMethodInfoPtr_GetSpecularColor_Public_Static_Vector4_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664064 /*0x06000300*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetSmoothness_Public_Static_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664065 /*0x06000301*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetTexSpecularColor_Public_Static_Texture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664066 /*0x06000302*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetEmissionColor_Public_Static_Vector4_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664067 /*0x06000303*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetTexEmissionColor_Public_Static_Texture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664068 /*0x06000304*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetBaseColorInfluence_Public_Static_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664069 /*0x06000305*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetNormalMapInfluence_Public_Static_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664070 /*0x06000306*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetSpecularColorInfluence_Public_Static_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664071 /*0x06000307*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetSmoothnessInfluence_Public_Static_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664072 /*0x06000308*/);
    DecalMaterialUtils.NativeMethodInfoPtr_GetEmissionColorInfluence_Public_Static_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalMaterialUtils>.NativeClassPtr, 100664073 /*0x06000309*/);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932295, RefRangeEnd = 932297, XrefRangeStart = 932290, XrefRangeEnd = 932295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DecalBlendingMode GetDecalBlendingMode(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetDecalBlendingMode_Public_Static_DecalBlendingMode_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DecalBlendingMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932302, RefRangeEnd = 932304, XrefRangeStart = 932297, XrefRangeEnd = 932302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetBaseColorAlpha(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetBaseColorAlpha_Public_Static_Vector4_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932310, RefRangeEnd = 932312, XrefRangeStart = 932304, XrefRangeEnd = 932310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexBaseColor(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetTexBaseColor_Public_Static_Texture_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932318, RefRangeEnd = 932320, XrefRangeStart = 932312, XrefRangeEnd = 932318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexNormalMap(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetTexNormalMap_Public_Static_Texture_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932325, RefRangeEnd = 932327, XrefRangeStart = 932320, XrefRangeEnd = 932325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetSpecularColor(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetSpecularColor_Public_Static_Vector4_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932333, RefRangeEnd = 932335, XrefRangeStart = 932327, XrefRangeEnd = 932333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetSmoothness(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetSmoothness_Public_Static_Single_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932398, RefRangeEnd = 932400, XrefRangeStart = 932335, XrefRangeEnd = 932398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexSpecularColor(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetTexSpecularColor_Public_Static_Texture_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932405, RefRangeEnd = 932407, XrefRangeStart = 932400, XrefRangeEnd = 932405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetEmissionColor(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetEmissionColor_Public_Static_Vector4_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932413, RefRangeEnd = 932415, XrefRangeStart = 932407, XrefRangeEnd = 932413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture GetTexEmissionColor(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetTexEmissionColor_Public_Static_Texture_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932421, RefRangeEnd = 932423, XrefRangeStart = 932415, XrefRangeEnd = 932421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetBaseColorInfluence(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetBaseColorInfluence_Public_Static_Single_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932429, RefRangeEnd = 932431, XrefRangeStart = 932423, XrefRangeEnd = 932429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetNormalMapInfluence(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetNormalMapInfluence_Public_Static_Single_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932437, RefRangeEnd = 932439, XrefRangeStart = 932431, XrefRangeEnd = 932437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetSpecularColorInfluence(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetSpecularColorInfluence_Public_Static_Single_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932445, RefRangeEnd = 932447, XrefRangeStart = 932439, XrefRangeEnd = 932445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetSmoothnessInfluence(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetSmoothnessInfluence_Public_Static_Single_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932453, RefRangeEnd = 932455, XrefRangeStart = 932447, XrefRangeEnd = 932453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetEmissionColorInfluence(Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalMaterialUtils.NativeMethodInfoPtr_GetEmissionColorInfluence_Public_Static_Single_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public DecalMaterialUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string kPropScriptUpdateCounter
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropScriptUpdateCounter, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropScriptUpdateCounter, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropDecalBlendingMode
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropDecalBlendingMode, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropDecalBlendingMode, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameBaseColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameBaseColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameBaseColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameTexBaseColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexBaseColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexBaseColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameTexNormalMap
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexNormalMap, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexNormalMap, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameSpecularColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSpecularColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSpecularColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameSmoothness
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSmoothness, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSmoothness, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameTexSpecularColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexSpecularColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexSpecularColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameEmissionColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameEmissionColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameEmissionColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameTexEmissionColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexEmissionColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameTexEmissionColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameBaseColorInfluence
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameBaseColorInfluence, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameBaseColorInfluence, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameNormalMapInfluence
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameNormalMapInfluence, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameNormalMapInfluence, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameSpecularColorInfluence
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSpecularColorInfluence, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSpecularColorInfluence, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameSmoothnessInfluence
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSmoothnessInfluence, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameSmoothnessInfluence, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kPropNameEmissionColorInfluence
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameEmissionColorInfluence, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kPropNameEmissionColorInfluence, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int kSidDecalBlendingMode
  {
    get
    {
      int decalBlendingMode;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidDecalBlendingMode, (void*) &decalBlendingMode);
      return decalBlendingMode;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidDecalBlendingMode, (void*) &value);
    }
  }

  public static unsafe int kSidBaseColor
  {
    get
    {
      int kSidBaseColor;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidBaseColor, (void*) &kSidBaseColor);
      return kSidBaseColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidBaseColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexBaseColor
  {
    get
    {
      int kSidTexBaseColor;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexBaseColor, (void*) &kSidTexBaseColor);
      return kSidTexBaseColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexBaseColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexNormalMap
  {
    get
    {
      int kSidTexNormalMap;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexNormalMap, (void*) &kSidTexNormalMap);
      return kSidTexNormalMap;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexNormalMap, (void*) &value);
    }
  }

  public static unsafe int kSidSpecularColor
  {
    get
    {
      int sidSpecularColor;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSpecularColor, (void*) &sidSpecularColor);
      return sidSpecularColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSpecularColor, (void*) &value);
    }
  }

  public static unsafe int kSidSmootness
  {
    get
    {
      int kSidSmootness;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSmootness, (void*) &kSidSmootness);
      return kSidSmootness;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSmootness, (void*) &value);
    }
  }

  public static unsafe int kSidTexSpecularColor
  {
    get
    {
      int texSpecularColor;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexSpecularColor, (void*) &texSpecularColor);
      return texSpecularColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexSpecularColor, (void*) &value);
    }
  }

  public static unsafe int kSidEmissionColor
  {
    get
    {
      int sidEmissionColor;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidEmissionColor, (void*) &sidEmissionColor);
      return sidEmissionColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidEmissionColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexEmissionColor
  {
    get
    {
      int texEmissionColor;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexEmissionColor, (void*) &texEmissionColor);
      return texEmissionColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidTexEmissionColor, (void*) &value);
    }
  }

  public static unsafe int kSidBaseColorInfluence
  {
    get
    {
      int baseColorInfluence;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidBaseColorInfluence, (void*) &baseColorInfluence);
      return baseColorInfluence;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidBaseColorInfluence, (void*) &value);
    }
  }

  public static unsafe int kSidNormalMapInfluence
  {
    get
    {
      int normalMapInfluence;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidNormalMapInfluence, (void*) &normalMapInfluence);
      return normalMapInfluence;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidNormalMapInfluence, (void*) &value);
    }
  }

  public static unsafe int kSidSpecularColorInfluence
  {
    get
    {
      int specularColorInfluence;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSpecularColorInfluence, (void*) &specularColorInfluence);
      return specularColorInfluence;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSpecularColorInfluence, (void*) &value);
    }
  }

  public static unsafe int kSidSmoothnessInfluence
  {
    get
    {
      int smoothnessInfluence;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSmoothnessInfluence, (void*) &smoothnessInfluence);
      return smoothnessInfluence;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidSmoothnessInfluence, (void*) &value);
    }
  }

  public static unsafe int kSidEmissionColorInfluence
  {
    get
    {
      int emissionColorInfluence;
      IL2CPP.il2cpp_field_static_get_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidEmissionColorInfluence, (void*) &emissionColorInfluence);
      return emissionColorInfluence;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalMaterialUtils.NativeFieldInfoPtr_kSidEmissionColorInfluence, (void*) &value);
    }
  }
}
