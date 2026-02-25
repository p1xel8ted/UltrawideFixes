// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MediumCullingResult
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class MediumCullingResult : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_volumeDensityGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumeNoiseIsOnList;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumeNoiseGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumeMaterialGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr_count;
  private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneDistanceWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_farPlaneDistanceWs;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_VolumeDensityGpu_Il2CppStructArray_1_Single_Il2CppStructArray_1_VolumeNoiseGpu_Il2CppStructArray_1_VolumeMaterialGpu_Int32_Single_Single_0;

  static MediumCullingResult()
  {
    Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (MediumCullingResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr);
    MediumCullingResult.NativeFieldInfoPtr_volumeDensityGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, nameof (volumeDensityGpuList));
    MediumCullingResult.NativeFieldInfoPtr_volumeNoiseIsOnList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, nameof (volumeNoiseIsOnList));
    MediumCullingResult.NativeFieldInfoPtr_volumeNoiseGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, nameof (volumeNoiseGpuList));
    MediumCullingResult.NativeFieldInfoPtr_volumeMaterialGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, nameof (volumeMaterialGpuList));
    MediumCullingResult.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, nameof (count));
    MediumCullingResult.NativeFieldInfoPtr_nearPlaneDistanceWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, nameof (nearPlaneDistanceWs));
    MediumCullingResult.NativeFieldInfoPtr_farPlaneDistanceWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, nameof (farPlaneDistanceWs));
    MediumCullingResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_VolumeDensityGpu_Il2CppStructArray_1_Single_Il2CppStructArray_1_VolumeNoiseGpu_Il2CppStructArray_1_VolumeMaterialGpu_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr, 100664267);
  }

  [CallerCount(0)]
  public unsafe MediumCullingResult(
    Il2CppStructArray<VolumeDensityGpu> volumeDensityGpuList,
    Il2CppStructArray<float> volumeNoiseIsOn,
    Il2CppStructArray<VolumeNoiseGpu> volumeNoiseGpuList,
    Il2CppStructArray<VolumeMaterialGpu> volumeMaterialGpuList,
    int count,
    float nearPlaneDistanceWs,
    float farPlaneDistanceWs)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeDensityGpuList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeNoiseIsOn);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeNoiseGpuList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeMaterialGpuList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &nearPlaneDistanceWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &farPlaneDistanceWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MediumCullingResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_VolumeDensityGpu_Il2CppStructArray_1_Single_Il2CppStructArray_1_VolumeNoiseGpu_Il2CppStructArray_1_VolumeMaterialGpu_Int32_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public MediumCullingResult(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public MediumCullingResult()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediumCullingResult>.NativeClassPtr))
  {
  }

  public unsafe Il2CppStructArray<VolumeDensityGpu> volumeDensityGpuList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeDensityGpuList));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<VolumeDensityGpu>) null : Il2CppObjectPool.Get<Il2CppStructArray<VolumeDensityGpu>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeDensityGpuList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> volumeNoiseIsOnList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeNoiseIsOnList));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeNoiseIsOnList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<VolumeNoiseGpu> volumeNoiseGpuList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeNoiseGpuList));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<VolumeNoiseGpu>) null : Il2CppObjectPool.Get<Il2CppStructArray<VolumeNoiseGpu>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeNoiseGpuList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<VolumeMaterialGpu> volumeMaterialGpuList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeMaterialGpuList));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<VolumeMaterialGpu>) null : Il2CppObjectPool.Get<Il2CppStructArray<VolumeMaterialGpu>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_volumeMaterialGpuList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int count
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_count));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_count)) = value;
    }
  }

  public unsafe float nearPlaneDistanceWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_nearPlaneDistanceWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_nearPlaneDistanceWs)) = value;
    }
  }

  public unsafe float farPlaneDistanceWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_farPlaneDistanceWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MediumCullingResult.NativeFieldInfoPtr_farPlaneDistanceWs)) = value;
    }
  }
}
