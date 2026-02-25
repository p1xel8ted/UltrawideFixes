// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusteredLightListHeatmapSettings
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ClusteredLightListHeatmapSettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTransparencyMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_showHeatmap;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_transparency01;
  private static readonly System.IntPtr NativeFieldInfoPtr_showAllClusters;
  private static readonly System.IntPtr NativeFieldInfoPtr_clusterIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ClusteredLightListHeatmapSettings()
  {
    Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusteredLightListHeatmapSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr);
    ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_kTransparencyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr, nameof (kTransparencyMin));
    ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_showHeatmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr, nameof (showHeatmap));
    ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_maxLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr, nameof (maxLightCount));
    ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_transparency01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr, nameof (transparency01));
    ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_showAllClusters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr, nameof (showAllClusters));
    ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_clusterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr, nameof (clusterIndex));
    ClusteredLightListHeatmapSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr, 100663418 /*0x0600007A*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924842, RefRangeEnd = 924843, XrefRangeStart = 924841, XrefRangeEnd = 924842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClusteredLightListHeatmapSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClusteredLightListHeatmapSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHeatmapSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kTransparencyMin
  {
    get
    {
      float kTransparencyMin;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_kTransparencyMin, (void*) &kTransparencyMin);
      return kTransparencyMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_kTransparencyMin, (void*) &value);
    }
  }

  public unsafe bool showHeatmap
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_showHeatmap));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_showHeatmap)) = value;
    }
  }

  public unsafe int maxLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_maxLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_maxLightCount)) = value;
    }
  }

  public unsafe float transparency01
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_transparency01));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_transparency01)) = value;
    }
  }

  public unsafe bool showAllClusters
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_showAllClusters));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_showAllClusters)) = value;
    }
  }

  public unsafe int clusterIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_clusterIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapSettings.NativeFieldInfoPtr_clusterIndex)) = value;
    }
  }
}
