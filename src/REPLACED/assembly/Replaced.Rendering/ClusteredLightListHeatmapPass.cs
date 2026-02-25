// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusteredLightListHeatmapPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ClusteredLightListHeatmapPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__engineMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__settings;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_ClusteredLightListHeatmapSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_HeatmapDataType_Int32_Single_Boolean_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ClusteredLightListHeatmapPass()
  {
    Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusteredLightListHeatmapPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr);
    ClusteredLightListHeatmapPass.NativeFieldInfoPtr__engineMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, nameof (_engineMaterial));
    ClusteredLightListHeatmapPass.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, nameof (_settings));
    ClusteredLightListHeatmapPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, nameof (_cbuffer));
    ClusteredLightListHeatmapPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_ClusteredLightListHeatmapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, 100664088);
    ClusteredLightListHeatmapPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, 100664089);
    ClusteredLightListHeatmapPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_HeatmapDataType_Int32_Single_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, 100664090);
    ClusteredLightListHeatmapPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, 100664091);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932616, XrefRangeEnd = 932629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClusteredLightListHeatmapPass(
    Shader shader,
    ClusteredLightListHeatmapSettings settings)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHeatmapPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_ClusteredLightListHeatmapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932629, XrefRangeEnd = 932650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(CommandBuffer cmd, [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHeatmapPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932654, RefRangeEnd = 932656, XrefRangeStart = 932650, XrefRangeEnd = 932654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    HeatmapDataType heatmapData,
    int maxLightCount,
    float transparency01,
    bool showAllClusters,
    int clusterIndex,
    int maxClusterCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heatmapData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxLightCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &transparency01;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &showAllClusters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &clusterIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxClusterCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHeatmapPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_HeatmapDataType_Int32_Single_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932656, XrefRangeEnd = 932660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHeatmapPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Material _engineMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapPass.NativeFieldInfoPtr__engineMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapPass.NativeFieldInfoPtr__engineMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClusteredLightListHeatmapSettings _settings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapPass.NativeFieldInfoPtr__settings));
      return num == System.IntPtr.Zero ? (ClusteredLightListHeatmapSettings) null : Il2CppObjectPool.Get<ClusteredLightListHeatmapSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapPass.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>) null : Il2CppObjectPool.Get<CBuffer<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListHeatmapPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ClusteredLightListHeatmapCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_transparency01;
    private static readonly System.IntPtr NativeFieldInfoPtr_heatmapDataType;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxLightCountRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_showAllClusters;
    private static readonly System.IntPtr NativeFieldInfoPtr_clusterIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxClusterCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxClusterCountRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public float transparency01;
    [FieldOffset(4)]
    public uint heatmapDataType;
    [FieldOffset(8)]
    public float maxLightCountRcp;
    [FieldOffset(12)]
    public uint showAllClusters;
    [FieldOffset(16 /*0x10*/)]
    public uint clusterIndex;
    [FieldOffset(20)]
    public uint maxClusterCount;
    [FieldOffset(24)]
    public float maxClusterCountRcp;
    [FieldOffset(28)]
    public uint padding;

    static ClusteredLightListHeatmapCBufferData()
    {
      Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusteredLightListHeatmapPass>.NativeClassPtr, nameof (ClusteredLightListHeatmapCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr);
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_transparency01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (transparency01));
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_heatmapDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (heatmapDataType));
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_maxLightCountRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (maxLightCountRcp));
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_showAllClusters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (showAllClusters));
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_clusterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (clusterIndex));
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_maxClusterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (maxClusterCount));
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_maxClusterCountRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (maxClusterCountRcp));
      ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusteredLightListHeatmapPass.ClusteredLightListHeatmapCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
