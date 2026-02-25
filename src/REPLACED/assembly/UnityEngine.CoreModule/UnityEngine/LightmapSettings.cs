// Decompiled with JetBrains decompiler
// Type: UnityEngine.LightmapSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public sealed class LightmapSettings(IntPtr pointer) : Object(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_lightmaps_Public_Static_set_Void_Il2CppReferenceArray_1_LightmapData_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsMode_Public_Static_get_LightmapsMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_lightmapsMode_Public_Static_set_Void_LightmapsMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_lightProbes_Public_Static_get_LightProbes_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_lightProbes_Public_Static_set_Void_LightProbes_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsModeLegacy_Public_Static_get_LightmapsModeLegacy_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_lightmapsModeLegacy_Public_Static_set_Void_LightmapsModeLegacy_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_bakedColorSpace_Public_Static_get_ColorSpace_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_bakedColorSpace_Public_Static_set_Void_ColorSpace_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_lightProbes_Injected_Private_Static_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_lightProbes_Injected_Private_Static_Void_IntPtr_0;

  static LightmapSettings()
  {
    Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LightmapSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr);
    LightmapSettings.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664762);
    LightmapSettings.NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664763);
    LightmapSettings.NativeMethodInfoPtr_set_lightmaps_Public_Static_set_Void_Il2CppReferenceArray_1_LightmapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664764);
    LightmapSettings.NativeMethodInfoPtr_get_lightmapsMode_Public_Static_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664765);
    LightmapSettings.NativeMethodInfoPtr_set_lightmapsMode_Public_Static_set_Void_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664766);
    LightmapSettings.NativeMethodInfoPtr_get_lightProbes_Public_Static_get_LightProbes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664767);
    LightmapSettings.NativeMethodInfoPtr_set_lightProbes_Public_Static_set_Void_LightProbes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664768 /*0x060005C0*/);
    LightmapSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664769);
    LightmapSettings.NativeMethodInfoPtr_get_lightmapsModeLegacy_Public_Static_get_LightmapsModeLegacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664770);
    LightmapSettings.NativeMethodInfoPtr_set_lightmapsModeLegacy_Public_Static_set_Void_LightmapsModeLegacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664771);
    LightmapSettings.NativeMethodInfoPtr_get_bakedColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664772);
    LightmapSettings.NativeMethodInfoPtr_set_bakedColorSpace_Public_Static_set_Void_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664773);
    LightmapSettings.NativeMethodInfoPtr_get_lightProbes_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664774);
    LightmapSettings.NativeMethodInfoPtr_set_lightProbes_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664775);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423689, XrefRangeEnd = 423693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightmapSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppReferenceArray<LightmapData> lightmaps
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423693, XrefRangeEnd = 423695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppReferenceArray<LightmapData>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<LightmapData>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423695, XrefRangeEnd = 423697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightmaps_Public_Static_set_Void_Il2CppReferenceArray_1_LightmapData_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe LightmapsMode lightmapsMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423697, XrefRangeEnd = 423699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightmapsMode_Public_Static_get_LightmapsMode_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LightmapsMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423699, XrefRangeEnd = 423701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightmapsMode_Public_Static_set_Void_LightmapsMode_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe LightProbes lightProbes
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423701, XrefRangeEnd = 423706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightProbes_Public_Static_get_LightProbes_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (LightProbes) null : Il2CppObjectPool.Get<LightProbes>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423706, XrefRangeEnd = 423711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightProbes_Public_Static_set_Void_LightProbes_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423711, XrefRangeEnd = 423713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Reset()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe LightmapsModeLegacy lightmapsModeLegacy
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 337858, RefRangeEnd = 337861, XrefRangeStart = 337858, XrefRangeEnd = 337861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightmapsModeLegacy_Public_Static_get_LightmapsModeLegacy_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LightmapsModeLegacy*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(15159), CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightmapsModeLegacy_Public_Static_set_Void_LightmapsModeLegacy_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe ColorSpace bakedColorSpace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423713, XrefRangeEnd = 423715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_bakedColorSpace_Public_Static_get_ColorSpace_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(15159), CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_bakedColorSpace_Public_Static_set_Void_ColorSpace_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423715, XrefRangeEnd = 423717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_lightProbes_Injected()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightProbes_Injected_Private_Static_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423717, XrefRangeEnd = 423719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_lightProbes_Injected(IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightProbes_Injected_Private_Static_Void_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
