// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusteredLightListHeatmap
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
public sealed class ClusteredLightListHeatmap(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_transparency;
  private static readonly IntPtr NativeFieldInfoPtr_heatmapData;
  private static readonly IntPtr NativeFieldInfoPtr_maxLightCount;
  private static readonly IntPtr NativeFieldInfoPtr_showAllClusters;
  private static readonly IntPtr NativeFieldInfoPtr_clusterIndex;
  private static readonly IntPtr NativeFieldInfoPtr_maxClusterCount;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ClusteredLightListHeatmap()
  {
    Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusteredLightListHeatmap));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr);
    ClusteredLightListHeatmap.NativeFieldInfoPtr_transparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr, nameof (transparency));
    ClusteredLightListHeatmap.NativeFieldInfoPtr_heatmapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr, nameof (heatmapData));
    ClusteredLightListHeatmap.NativeFieldInfoPtr_maxLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr, nameof (maxLightCount));
    ClusteredLightListHeatmap.NativeFieldInfoPtr_showAllClusters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr, nameof (showAllClusters));
    ClusteredLightListHeatmap.NativeFieldInfoPtr_clusterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr, nameof (clusterIndex));
    ClusteredLightListHeatmap.NativeFieldInfoPtr_maxClusterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr, nameof (maxClusterCount));
    ClusteredLightListHeatmap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr, 100663580);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926445, XrefRangeEnd = 926470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClusteredLightListHeatmap()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClusteredLightListHeatmap>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHeatmap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ClampedFloatParameter transparency
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_transparency));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_transparency), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnumParameter<HeatmapDataType> heatmapData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_heatmapData));
      return num == IntPtr.Zero ? (EnumParameter<HeatmapDataType>) null : Il2CppObjectPool.Get<EnumParameter<HeatmapDataType>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_heatmapData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinIntParameter maxLightCount
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_maxLightCount));
      return num == IntPtr.Zero ? (MinIntParameter) null : Il2CppObjectPool.Get<MinIntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_maxLightCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter showAllClusters
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_showAllClusters));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_showAllClusters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinIntParameter clusterIndex
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_clusterIndex));
      return num == IntPtr.Zero ? (MinIntParameter) null : Il2CppObjectPool.Get<MinIntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_clusterIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinIntParameter maxClusterCount
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_maxClusterCount));
      return num == IntPtr.Zero ? (MinIntParameter) null : Il2CppObjectPool.Get<MinIntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmap.NativeFieldInfoPtr_maxClusterCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
