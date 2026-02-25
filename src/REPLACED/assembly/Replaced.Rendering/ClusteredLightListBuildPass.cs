// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusteredLightListBuildPass
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

public sealed class ClusteredLightListBuildPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidPackedLightDataBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidCllPunctualLightList;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidCllLineLightList;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelBuild;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelClear;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogGridDepthDistribution_Private_Static_Void_Vector3Int_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector3Int_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ClusteredLightListBuildPass()
  {
    Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusteredLightListBuildPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr);
    ClusteredLightListBuildPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (kGroupSize));
    ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidPackedLightDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (kSidPackedLightDataBuffer));
    ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidCllPunctualLightList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (kSidCllPunctualLightList));
    ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidCllLineLightList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (kSidCllLineLightList));
    ClusteredLightListBuildPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (_cbuffer));
    ClusteredLightListBuildPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (_compute));
    ClusteredLightListBuildPass.NativeFieldInfoPtr__kernelBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (_kernelBuild));
    ClusteredLightListBuildPass.NativeFieldInfoPtr__kernelClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (_kernelClear));
    ClusteredLightListBuildPass.NativeMethodInfoPtr_LogGridDepthDistribution_Private_Static_Void_Vector3Int_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, 100663822 /*0x0600020E*/);
    ClusteredLightListBuildPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, 100663823 /*0x0600020F*/);
    ClusteredLightListBuildPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, 100663824 /*0x06000210*/);
    ClusteredLightListBuildPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, 100663825);
    ClusteredLightListBuildPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, 100663826);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogGridDepthDistribution(
    Vector3Int gridSize3D,
    float nearVs,
    float farVs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &gridSize3D;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nearVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &farVs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListBuildPass.NativeMethodInfoPtr_LogGridDepthDistribution_Private_Static_Void_Vector3Int_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929614, RefRangeEnd = 929615, XrefRangeStart = 929599, XrefRangeEnd = 929614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClusteredLightListBuildPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListBuildPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929643, RefRangeEnd = 929645, XrefRangeStart = 929615, XrefRangeEnd = 929643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    ClusteredInputLightList inputLightList,
    ClusteredLightListData cllData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputLightList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cllData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListBuildPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_ClusteredInputLightList_ClusteredLightListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929645, XrefRangeEnd = 929650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    Vector3Int gridSize3D,
    int lightCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gridSize3D;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lightCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListBuildPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929654, RefRangeEnd = 929655, XrefRangeStart = 929650, XrefRangeEnd = 929654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListBuildPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector3Int kGroupSize
  {
    get
    {
      Vector3Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidPackedLightDataBuffer
  {
    get
    {
      int packedLightDataBuffer;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidPackedLightDataBuffer, (void*) &packedLightDataBuffer);
      return packedLightDataBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidPackedLightDataBuffer, (void*) &value);
    }
  }

  public static unsafe int kSidCllPunctualLightList
  {
    get
    {
      int punctualLightList;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidCllPunctualLightList, (void*) &punctualLightList);
      return punctualLightList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidCllPunctualLightList, (void*) &value);
    }
  }

  public static unsafe int kSidCllLineLightList
  {
    get
    {
      int cllLineLightList;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidCllLineLightList, (void*) &cllLineLightList);
      return cllLineLightList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListBuildPass.NativeFieldInfoPtr_kSidCllLineLightList, (void*) &value);
    }
  }

  public unsafe CBuffer<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>) null : Il2CppObjectPool.Get<CBuffer<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernelBuild
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__kernelBuild));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__kernelBuild)) = value;
    }
  }

  public unsafe int _kernelClear
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__kernelClear));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListBuildPass.NativeFieldInfoPtr__kernelClear)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ClusteredLightListBuildCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneDistanceVs;
    private static readonly System.IntPtr NativeFieldInfoPtr_farPlaneDistanceVs;
    private static readonly System.IntPtr NativeFieldInfoPtr_commonRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_commonDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_gridSizeRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_lightCount;
    [FieldOffset(0)]
    public Matrix4x4 invProjectionMatrix;
    [FieldOffset(64 /*0x40*/)]
    public float nearPlaneDistanceVs;
    [FieldOffset(68)]
    public float farPlaneDistanceVs;
    [FieldOffset(72)]
    public float commonRatio;
    [FieldOffset(76)]
    public float commonDiff;
    [FieldOffset(80 /*0x50*/)]
    public Vector3 gridSizeRcp;
    [FieldOffset(92)]
    public uint lightCount;

    static ClusteredLightListBuildCBufferData()
    {
      Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusteredLightListBuildPass>.NativeClassPtr, nameof (ClusteredLightListBuildCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr);
      ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData.NativeFieldInfoPtr_invProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, nameof (invProjectionMatrix));
      ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData.NativeFieldInfoPtr_nearPlaneDistanceVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, nameof (nearPlaneDistanceVs));
      ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData.NativeFieldInfoPtr_farPlaneDistanceVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, nameof (farPlaneDistanceVs));
      ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData.NativeFieldInfoPtr_commonRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, nameof (commonRatio));
      ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData.NativeFieldInfoPtr_commonDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, nameof (commonDiff));
      ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData.NativeFieldInfoPtr_gridSizeRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, nameof (gridSizeRcp));
      ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData.NativeFieldInfoPtr_lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, nameof (lightCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusteredLightListBuildPass.ClusteredLightListBuildCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
