// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LightingDataHelper
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public static class LightingDataHelper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kHalfMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_kHalfMax;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSupportedLayersMask_Public_Static_UInt32_byref_VisibleLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVolumetricIntensityLimit_Public_Static_Single_LightExtraData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInHalfRange_Public_Static_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInHalfRange_Public_Static_Boolean_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rgb101010Bits_Public_Static_UInt32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_R11g11b10_Public_Static_UInt32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rgb24Bits_Public_Static_UInt32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackHalfAndUShort_Public_Static_UInt32_Single_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackVector4AsHalf4_Public_Static_Vector2Int_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pack2Vector3_Public_Static_Vector3Int_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackAsHalf2_Public_Static_UInt32_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackTint_Public_Static_UInt32_byref_VisibleLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackTint_Public_Static_UInt32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackFlags_Public_Static_UInt32_LightExtraData_Boolean_Boolean_0;

  static LightingDataHelper()
  {
    Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LightingDataHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr);
    LightingDataHelper.NativeFieldInfoPtr_kHalfMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, nameof (kHalfMin));
    LightingDataHelper.NativeFieldInfoPtr_kHalfMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, nameof (kHalfMax));
    LightingDataHelper.NativeMethodInfoPtr_GetSupportedLayersMask_Public_Static_UInt32_byref_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663962);
    LightingDataHelper.NativeMethodInfoPtr_GetVolumetricIntensityLimit_Public_Static_Single_LightExtraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663963);
    LightingDataHelper.NativeMethodInfoPtr_IsInHalfRange_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663964);
    LightingDataHelper.NativeMethodInfoPtr_IsInHalfRange_Public_Static_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663965);
    LightingDataHelper.NativeMethodInfoPtr_Rgb101010Bits_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663966);
    LightingDataHelper.NativeMethodInfoPtr_R11g11b10_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663967);
    LightingDataHelper.NativeMethodInfoPtr_Rgb24Bits_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663968 /*0x060002A0*/);
    LightingDataHelper.NativeMethodInfoPtr_PackHalfAndUShort_Public_Static_UInt32_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663969);
    LightingDataHelper.NativeMethodInfoPtr_PackVector4AsHalf4_Public_Static_Vector2Int_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663970);
    LightingDataHelper.NativeMethodInfoPtr_Pack2Vector3_Public_Static_Vector3Int_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663971);
    LightingDataHelper.NativeMethodInfoPtr_PackAsHalf2_Public_Static_UInt32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663972);
    LightingDataHelper.NativeMethodInfoPtr_PackTint_Public_Static_UInt32_byref_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663973);
    LightingDataHelper.NativeMethodInfoPtr_PackTint_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663974);
    LightingDataHelper.NativeMethodInfoPtr_PackFlags_Public_Static_UInt32_LightExtraData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingDataHelper>.NativeClassPtr, 100663975);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 931206, RefRangeEnd = 931209, XrefRangeStart = 931204, XrefRangeEnd = 931206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetSupportedLayersMask([In] ref VisibleLight vl)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref vl
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_GetSupportedLayersMask_Public_Static_UInt32_byref_VisibleLight_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931209, RefRangeEnd = 931210, XrefRangeStart = 931209, XrefRangeEnd = 931209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetVolumetricIntensityLimit(LightExtraData led)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_GetVolumetricIntensityLimit_Public_Static_Single_LightExtraData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsInHalfRange(float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_IsInHalfRange_Public_Static_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsInHalfRange(Vector3 vec)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &vec
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_IsInHalfRange_Public_Static_Boolean_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931210, XrefRangeEnd = 931219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint Rgb101010Bits(Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_Rgb101010Bits_Public_Static_UInt32_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931219, XrefRangeEnd = 931222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint R11g11b10(Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_R11g11b10_Public_Static_UInt32_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931222, XrefRangeEnd = 931231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint Rgb24Bits(Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_Rgb24Bits_Public_Static_UInt32_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931231, XrefRangeEnd = 931232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint PackHalfAndUShort(float floatValue, uint ushortValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &floatValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ushortValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_PackHalfAndUShort_Public_Static_UInt32_Single_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931232, XrefRangeEnd = 931236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2Int PackVector4AsHalf4(Vector3 vec, float wValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vec;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_PackVector4AsHalf4_Public_Static_Vector2Int_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931236, XrefRangeEnd = 931242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3Int Pack2Vector3(Vector3 v0, Vector3 v1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &v0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_Pack2Vector3_Public_Static_Vector3Int_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 931244, RefRangeEnd = 931248, XrefRangeStart = 931242, XrefRangeEnd = 931244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint PackAsHalf2(float a, float b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_PackAsHalf2_Public_Static_UInt32_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 931256, RefRangeEnd = 931261, XrefRangeStart = 931248, XrefRangeEnd = 931256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint PackTint([In] ref VisibleLight vl)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref vl
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_PackTint_Public_Static_UInt32_byref_VisibleLight_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931261, XrefRangeEnd = 931264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint PackTint(Color tint)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &tint
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_PackTint_Public_Static_UInt32_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931264, RefRangeEnd = 931265, XrefRangeStart = 931264, XrefRangeEnd = 931264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint PackFlags(LightExtraData led, bool doesCastShadows = false, bool hasPattern = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &doesCastShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hasPattern;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingDataHelper.NativeMethodInfoPtr_PackFlags_Public_Static_UInt32_LightExtraData_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public LightingDataHelper(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float kHalfMin
  {
    get
    {
      float kHalfMin;
      IL2CPP.il2cpp_field_static_get_value(LightingDataHelper.NativeFieldInfoPtr_kHalfMin, (void*) &kHalfMin);
      return kHalfMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingDataHelper.NativeFieldInfoPtr_kHalfMin, (void*) &value);
    }
  }

  public static unsafe float kHalfMax
  {
    get
    {
      float kHalfMax;
      IL2CPP.il2cpp_field_static_get_value(LightingDataHelper.NativeFieldInfoPtr_kHalfMax, (void*) &kHalfMax);
      return kHalfMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingDataHelper.NativeFieldInfoPtr_kHalfMax, (void*) &value);
    }
  }
}
