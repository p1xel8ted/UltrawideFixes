// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LineLightsV2Data
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

public sealed class LineLightsV2Data(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidLLV2BufferRenderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidLLV2BufferPackedData;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidLLV2BufferPackedDataVolumetric;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferRenderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferPackedData;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferPackedDataVolumetric;
  private static readonly System.IntPtr NativeFieldInfoPtr__maxLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightCount;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_UInt32_Buffer_1_PackedData_Buffer_1_PackedData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static LineLightsV2Data()
  {
    Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LineLightsV2Data));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr);
    LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (kSidLLV2BufferRenderingLayerMask));
    LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferPackedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (kSidLLV2BufferPackedData));
    LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferPackedDataVolumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (kSidLLV2BufferPackedDataVolumetric));
    LineLightsV2Data.NativeFieldInfoPtr__bufferRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (_bufferRenderingLayerMask));
    LineLightsV2Data.NativeFieldInfoPtr__bufferPackedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (_bufferPackedData));
    LineLightsV2Data.NativeFieldInfoPtr__bufferPackedDataVolumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (_bufferPackedDataVolumetric));
    LineLightsV2Data.NativeFieldInfoPtr__maxLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (_maxLightCount));
    LineLightsV2Data.NativeFieldInfoPtr__lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (_lightCount));
    LineLightsV2Data.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, 100664006);
    LineLightsV2Data.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, 100664007);
    LineLightsV2Data.NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_UInt32_Buffer_1_PackedData_Buffer_1_PackedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, 100664008);
    LineLightsV2Data.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, 100664009);
    LineLightsV2Data.NativeMethodInfoPtr_AddLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, 100664010);
    LineLightsV2Data.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, 100664011);
    LineLightsV2Data.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, 100664012);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931644, XrefRangeEnd = 931645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LineLightsV2Data(int maxLightCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &maxLightCount
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineLightsV2Data.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int LightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineLightsV2Data.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe void BeginWrite(
    Buffer<uint> bufferRenderingLayerMask,
    Buffer<LineLightsV2Data.PackedData> bufferPackedData,
    Buffer<LineLightsV2Data.PackedData> bufferPackedDataVolumetric)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferRenderingLayerMask);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferPackedData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferPackedDataVolumetric);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineLightsV2Data.NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_UInt32_Buffer_1_PackedData_Buffer_1_PackedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931645, XrefRangeEnd = 931667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndWrite(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineLightsV2Data.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 931676, RefRangeEnd = 931678, XrefRangeStart = 931667, XrefRangeEnd = 931676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int AddLight(int vlIndex, [In] ref VisibleLight vl, LightExtraData led)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineLightsV2Data.NativeMethodInfoPtr_AddLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931678, XrefRangeEnd = 931693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindGlobal(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineLightsV2Data.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineLightsV2Data.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidLLV2BufferRenderingLayerMask
  {
    get
    {
      int renderingLayerMask;
      IL2CPP.il2cpp_field_static_get_value(LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferRenderingLayerMask, (void*) &renderingLayerMask);
      return renderingLayerMask;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferRenderingLayerMask, (void*) &value);
    }
  }

  public static unsafe int kSidLLV2BufferPackedData
  {
    get
    {
      int bufferPackedData;
      IL2CPP.il2cpp_field_static_get_value(LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferPackedData, (void*) &bufferPackedData);
      return bufferPackedData;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferPackedData, (void*) &value);
    }
  }

  public static unsafe int kSidLLV2BufferPackedDataVolumetric
  {
    get
    {
      int packedDataVolumetric;
      IL2CPP.il2cpp_field_static_get_value(LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferPackedDataVolumetric, (void*) &packedDataVolumetric);
      return packedDataVolumetric;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LineLightsV2Data.NativeFieldInfoPtr_kSidLLV2BufferPackedDataVolumetric, (void*) &value);
    }
  }

  public unsafe Buffer<uint> _bufferRenderingLayerMask
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__bufferRenderingLayerMask));
      return num == System.IntPtr.Zero ? (Buffer<uint>) null : Il2CppObjectPool.Get<Buffer<uint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__bufferRenderingLayerMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<LineLightsV2Data.PackedData> _bufferPackedData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__bufferPackedData));
      return num == System.IntPtr.Zero ? (Buffer<LineLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<LineLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__bufferPackedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<LineLightsV2Data.PackedData> _bufferPackedDataVolumetric
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__bufferPackedDataVolumetric));
      return num == System.IntPtr.Zero ? (Buffer<LineLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<LineLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__bufferPackedDataVolumetric), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _maxLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__maxLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__maxLightCount)) = value;
    }
  }

  public unsafe int _lightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__lightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineLightsV2Data.NativeFieldInfoPtr__lightCount)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PackedData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_l0Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_axisUnnormWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricIntensityLimitRangeScaleEnd;
    private static readonly System.IntPtr NativeFieldInfoPtr_tint;
    private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
    [FieldOffset(0)]
    public Vector3 l0Ws;
    [FieldOffset(12)]
    public Vector3 axisUnnormWs;
    [FieldOffset(24)]
    public uint volumetricIntensityLimitRangeScaleEnd;
    [FieldOffset(28)]
    public uint tint;
    [FieldOffset(32 /*0x20*/)]
    public float intensity;

    static PackedData()
    {
      Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LineLightsV2Data>.NativeClassPtr, nameof (PackedData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr);
      LineLightsV2Data.PackedData.NativeFieldInfoPtr_l0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr, nameof (l0Ws));
      LineLightsV2Data.PackedData.NativeFieldInfoPtr_axisUnnormWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr, nameof (axisUnnormWs));
      LineLightsV2Data.PackedData.NativeFieldInfoPtr_volumetricIntensityLimitRangeScaleEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr, nameof (volumetricIntensityLimitRangeScaleEnd));
      LineLightsV2Data.PackedData.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr, nameof (tint));
      LineLightsV2Data.PackedData.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr, nameof (intensity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineLightsV2Data.PackedData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
