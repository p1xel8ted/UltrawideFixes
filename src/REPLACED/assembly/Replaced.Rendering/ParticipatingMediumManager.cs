// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ParticipatingMediumManager
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ParticipatingMediumManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSceneObjectCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr__mediumObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumeDensityGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumeNoiseIsOn;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumeNoiseGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumeMaterialGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr__frustumPlanes;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcNearFarPlaneDistances_Private_Static_Void_Camera_Bounds_byref_Single_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVolumeDensityGpu_Private_Static_VolumeDensityGpu_ParticipatingMedium_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVolumeNoiseIsOn_Private_Static_Single_ParticipatingMedium_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVolumeNoiseGpu_Private_Static_VolumeNoiseGpu_ParticipatingMedium_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVolumeMaterialGpu_Private_Static_VolumeMaterialGpu_ParticipatingMedium_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_ParticipatingMedium_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_ParticipatingMedium_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Public_MediumCullingResult_Camera_Single_0;

  static ParticipatingMediumManager()
  {
    Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ParticipatingMediumManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr);
    ParticipatingMediumManager.NativeFieldInfoPtr_kSceneObjectCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, nameof (kSceneObjectCountLimit));
    ParticipatingMediumManager.NativeFieldInfoPtr__mediumObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, nameof (_mediumObjects));
    ParticipatingMediumManager.NativeFieldInfoPtr__volumeDensityGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, nameof (_volumeDensityGpuList));
    ParticipatingMediumManager.NativeFieldInfoPtr__volumeNoiseIsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, nameof (_volumeNoiseIsOn));
    ParticipatingMediumManager.NativeFieldInfoPtr__volumeNoiseGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, nameof (_volumeNoiseGpuList));
    ParticipatingMediumManager.NativeFieldInfoPtr__volumeMaterialGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, nameof (_volumeMaterialGpuList));
    ParticipatingMediumManager.NativeFieldInfoPtr__frustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, nameof (_frustumPlanes));
    ParticipatingMediumManager.NativeMethodInfoPtr_CalcNearFarPlaneDistances_Private_Static_Void_Camera_Bounds_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664268);
    ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeDensityGpu_Private_Static_VolumeDensityGpu_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664269);
    ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeNoiseIsOn_Private_Static_Single_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664270);
    ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeNoiseGpu_Private_Static_VolumeNoiseGpu_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664271);
    ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeMaterialGpu_Private_Static_VolumeMaterialGpu_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664272 /*0x060003D0*/);
    ParticipatingMediumManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664273);
    ParticipatingMediumManager.NativeMethodInfoPtr_Add_Public_Void_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664274);
    ParticipatingMediumManager.NativeMethodInfoPtr_Remove_Public_Void_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664275);
    ParticipatingMediumManager.NativeMethodInfoPtr_Cull_Public_MediumCullingResult_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr, 100664276);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935846, XrefRangeEnd = 935878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CalcNearFarPlaneDistances(
    Camera camera,
    Bounds bbox,
    out float nearPlaneDistance,
    out float farPlaneDistance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bbox;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref nearPlaneDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref farPlaneDistance;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_CalcNearFarPlaneDistances_Private_Static_Void_Camera_Bounds_byref_Single_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935895, RefRangeEnd = 935896, XrefRangeStart = 935878, XrefRangeEnd = 935895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe VolumeDensityGpu MakeVolumeDensityGpu(ParticipatingMedium medium)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeDensityGpu_Private_Static_VolumeDensityGpu_ParticipatingMedium_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(VolumeDensityGpu*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float MakeVolumeNoiseIsOn(ParticipatingMedium medium)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeNoiseIsOn_Private_Static_Single_ParticipatingMedium_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935908, RefRangeEnd = 935909, XrefRangeStart = 935896, XrefRangeEnd = 935908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe VolumeNoiseGpu MakeVolumeNoiseGpu(ParticipatingMedium medium)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeNoiseGpu_Private_Static_VolumeNoiseGpu_ParticipatingMedium_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(VolumeNoiseGpu*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935909, XrefRangeEnd = 935912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe VolumeMaterialGpu MakeVolumeMaterialGpu(ParticipatingMedium medium)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_MakeVolumeMaterialGpu_Private_Static_VolumeMaterialGpu_ParticipatingMedium_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(VolumeMaterialGpu*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935912, XrefRangeEnd = 935934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ParticipatingMediumManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticipatingMediumManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935934, XrefRangeEnd = 935939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(ParticipatingMedium medium)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_Add_Public_Void_ParticipatingMedium_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935939, XrefRangeEnd = 935943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Remove(ParticipatingMedium medium)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_Remove_Public_Void_ParticipatingMedium_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935968, RefRangeEnd = 935969, XrefRangeStart = 935943, XrefRangeEnd = 935968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MediumCullingResult Cull(Camera camera, float maxFarDistance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxFarDistance;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ParticipatingMediumManager.NativeMethodInfoPtr_Cull_Public_MediumCullingResult_Camera_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new MediumCullingResult(pointer);
  }

  public static unsafe int kSceneObjectCountLimit
  {
    get
    {
      int objectCountLimit;
      IL2CPP.il2cpp_field_static_get_value(ParticipatingMediumManager.NativeFieldInfoPtr_kSceneObjectCountLimit, (void*) &objectCountLimit);
      return objectCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ParticipatingMediumManager.NativeFieldInfoPtr_kSceneObjectCountLimit, (void*) &value);
    }
  }

  public unsafe List<ParticipatingMedium> _mediumObjects
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__mediumObjects));
      return num == System.IntPtr.Zero ? (List<ParticipatingMedium>) null : Il2CppObjectPool.Get<List<ParticipatingMedium>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__mediumObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<VolumeDensityGpu> _volumeDensityGpuList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeDensityGpuList));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<VolumeDensityGpu>) null : Il2CppObjectPool.Get<Il2CppStructArray<VolumeDensityGpu>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeDensityGpuList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> _volumeNoiseIsOn
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeNoiseIsOn));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeNoiseIsOn), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<VolumeNoiseGpu> _volumeNoiseGpuList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeNoiseGpuList));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<VolumeNoiseGpu>) null : Il2CppObjectPool.Get<Il2CppStructArray<VolumeNoiseGpu>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeNoiseGpuList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<VolumeMaterialGpu> _volumeMaterialGpuList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeMaterialGpuList));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<VolumeMaterialGpu>) null : Il2CppObjectPool.Get<Il2CppStructArray<VolumeMaterialGpu>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__volumeMaterialGpuList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<UnityEngine.Plane> _frustumPlanes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__frustumPlanes));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<UnityEngine.Plane>) null : Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.Plane>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipatingMediumManager.NativeFieldInfoPtr__frustumPlanes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
