// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SampleDistributionVisualisation
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

public sealed class SampleDistributionVisualisation(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kHemisphereSampleCount;
  private static readonly IntPtr NativeFieldInfoPtr_kDiskSampleCount;
  private static readonly IntPtr NativeFieldInfoPtr_kAngleCount;
  private static readonly IntPtr NativeMethodInfoPtr_DrawHemisphereSampleDistribution_Private_Static_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_DrawDiskSampleDistribution_Private_Static_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_DrawAngleDistribution_Private_Static_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SampleDistributionVisualisation()
  {
    Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SampleDistributionVisualisation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr);
    SampleDistributionVisualisation.NativeFieldInfoPtr_kHemisphereSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, nameof (kHemisphereSampleCount));
    SampleDistributionVisualisation.NativeFieldInfoPtr_kDiskSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, nameof (kDiskSampleCount));
    SampleDistributionVisualisation.NativeFieldInfoPtr_kAngleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, nameof (kAngleCount));
    SampleDistributionVisualisation.NativeMethodInfoPtr_DrawHemisphereSampleDistribution_Private_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, 100663505 /*0x060000D1*/);
    SampleDistributionVisualisation.NativeMethodInfoPtr_DrawDiskSampleDistribution_Private_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, 100663506 /*0x060000D2*/);
    SampleDistributionVisualisation.NativeMethodInfoPtr_DrawAngleDistribution_Private_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, 100663507 /*0x060000D3*/);
    SampleDistributionVisualisation.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, 100663508 /*0x060000D4*/);
    SampleDistributionVisualisation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr, 100663509 /*0x060000D5*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925768, RefRangeEnd = 925769, XrefRangeStart = 925735, XrefRangeEnd = 925768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawHemisphereSampleDistribution(Transform transform)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SampleDistributionVisualisation.NativeMethodInfoPtr_DrawHemisphereSampleDistribution_Private_Static_Void_Transform_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925786, RefRangeEnd = 925787, XrefRangeStart = 925769, XrefRangeEnd = 925786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawDiskSampleDistribution(Transform transform)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SampleDistributionVisualisation.NativeMethodInfoPtr_DrawDiskSampleDistribution_Private_Static_Void_Transform_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925798, RefRangeEnd = 925799, XrefRangeStart = 925787, XrefRangeEnd = 925798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawAngleDistribution(Transform transform)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SampleDistributionVisualisation.NativeMethodInfoPtr_DrawAngleDistribution_Private_Static_Void_Transform_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925799, XrefRangeEnd = 925805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SampleDistributionVisualisation.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SampleDistributionVisualisation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SampleDistributionVisualisation>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SampleDistributionVisualisation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kHemisphereSampleCount
  {
    get
    {
      int hemisphereSampleCount;
      IL2CPP.il2cpp_field_static_get_value(SampleDistributionVisualisation.NativeFieldInfoPtr_kHemisphereSampleCount, (void*) &hemisphereSampleCount);
      return hemisphereSampleCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SampleDistributionVisualisation.NativeFieldInfoPtr_kHemisphereSampleCount, (void*) &value);
    }
  }

  public static unsafe int kDiskSampleCount
  {
    get
    {
      int kDiskSampleCount;
      IL2CPP.il2cpp_field_static_get_value(SampleDistributionVisualisation.NativeFieldInfoPtr_kDiskSampleCount, (void*) &kDiskSampleCount);
      return kDiskSampleCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SampleDistributionVisualisation.NativeFieldInfoPtr_kDiskSampleCount, (void*) &value);
    }
  }

  public static unsafe int kAngleCount
  {
    get
    {
      int kAngleCount;
      IL2CPP.il2cpp_field_static_get_value(SampleDistributionVisualisation.NativeFieldInfoPtr_kAngleCount, (void*) &kAngleCount);
      return kAngleCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SampleDistributionVisualisation.NativeFieldInfoPtr_kAngleCount, (void*) &value);
    }
  }
}
