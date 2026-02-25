// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusteredInputLightList
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

public sealed class ClusteredInputLightList(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__buffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__totalLightCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackLightDescriptor_Private_Static_UInt32_Int32_ShapeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_CLLPackedLightData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLineLight_Public_Void_Int32_byref_Matrix4x4_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPointLight_Public_Void_Int32_byref_Matrix4x4_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddSpotlight_Public_Void_Int32_byref_Matrix4x4_Vector3_Vector3_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PutLightData_Private_Void_Int32_ShapeType_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ClusteredInputLightList()
  {
    Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusteredInputLightList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr);
    ClusteredInputLightList.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, nameof (_buffer));
    ClusteredInputLightList.NativeFieldInfoPtr__totalLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, nameof (_totalLightCount));
    ClusteredInputLightList.NativeMethodInfoPtr_PackLightDescriptor_Private_Static_UInt32_Int32_ShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663811 /*0x06000203*/);
    ClusteredInputLightList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663812 /*0x06000204*/);
    ClusteredInputLightList.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663813 /*0x06000205*/);
    ClusteredInputLightList.NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_CLLPackedLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663814 /*0x06000206*/);
    ClusteredInputLightList.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663815 /*0x06000207*/);
    ClusteredInputLightList.NativeMethodInfoPtr_AddLineLight_Public_Void_Int32_byref_Matrix4x4_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663816 /*0x06000208*/);
    ClusteredInputLightList.NativeMethodInfoPtr_AddPointLight_Public_Void_Int32_byref_Matrix4x4_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663817 /*0x06000209*/);
    ClusteredInputLightList.NativeMethodInfoPtr_AddSpotlight_Public_Void_Int32_byref_Matrix4x4_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663818 /*0x0600020A*/);
    ClusteredInputLightList.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663819 /*0x0600020B*/);
    ClusteredInputLightList.NativeMethodInfoPtr_PutLightData_Private_Void_Int32_ShapeType_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663820 /*0x0600020C*/);
    ClusteredInputLightList.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr, 100663821 /*0x0600020D*/);
  }

  [CallerCount(0)]
  public static unsafe uint PackLightDescriptor(
    int lightIdx,
    ClusteredInputLightList.ShapeType shapeType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lightIdx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shapeType;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_PackLightDescriptor_Private_Static_UInt32_Int32_ShapeType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClusteredInputLightList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClusteredInputLightList>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int LightCount
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_get_LightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929577, RefRangeEnd = 929578, XrefRangeStart = 929577, XrefRangeEnd = 929577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginWrite(Buffer<CLLPackedLightData> cllInputBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cllInputBuffer)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_BeginWrite_Public_Void_Buffer_1_CLLPackedLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929582, RefRangeEnd = 929583, XrefRangeStart = 929578, XrefRangeEnd = 929582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndWrite(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929586, RefRangeEnd = 929587, XrefRangeStart = 929583, XrefRangeEnd = 929586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddLineLight(
    int lightIdx,
    [In] ref Matrix4x4 viewMatrix,
    Vector3 position0Ws,
    Vector3 position1Ws,
    float radiusWs)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &lightIdx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position0Ws;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position1Ws;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_AddLineLight_Public_Void_Int32_byref_Matrix4x4_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929587, XrefRangeEnd = 929591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPointLight(
    int lightIdx,
    [In] ref Matrix4x4 viewMatrix,
    Vector3 positionWs,
    float radiusWs)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &lightIdx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &positionWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_AddPointLight_Public_Void_Int32_byref_Matrix4x4_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929591, XrefRangeEnd = 929594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddSpotlight(
    int lightIdx,
    [In] ref Matrix4x4 viewMatrix,
    Vector3 positionWs,
    Vector3 forwardWs,
    float lengthWs,
    float baseRadiusWs,
    float tanOuterHalf)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &lightIdx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &positionWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forwardWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lengthWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &baseRadiusWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tanOuterHalf;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_AddSpotlight_Public_Void_Int32_byref_Matrix4x4_Vector3_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929594, XrefRangeEnd = 929598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bind(
    CommandBuffer cmd,
    ComputeShader compute,
    int kernel,
    int sidPackedLightDataBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sidPackedLightDataBuffer;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929598, XrefRangeEnd = 929599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PutLightData(
    int lightIdx,
    ClusteredInputLightList.ShapeType shapeType,
    Vector3 positionVs1,
    Vector3 positionVs2,
    float radiusVs,
    float tanOuterHalf)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &lightIdx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shapeType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &positionVs1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &positionVs2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &tanOuterHalf;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_PutLightData_Private_Void_Int32_ShapeType_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredInputLightList.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Buffer<CLLPackedLightData> _buffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredInputLightList.NativeFieldInfoPtr__buffer));
      return num == System.IntPtr.Zero ? (Buffer<CLLPackedLightData>) null : Il2CppObjectPool.Get<Buffer<CLLPackedLightData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredInputLightList.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _totalLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredInputLightList.NativeFieldInfoPtr__totalLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredInputLightList.NativeFieldInfoPtr__totalLightCount)) = value;
    }
  }

  public enum ShapeType : uint
  {
    Sphere,
    Cone,
    LineSegment,
  }
}
