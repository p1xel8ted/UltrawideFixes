// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchCullingContext
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class BatchCullingContext : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlanes;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplits;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodParameters;
  private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewType;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionType;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingFlags;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewID;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_sceneCullingMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_splitExclusionMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_isOrthographic;
  private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_occlusionBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Byte_Int32_Int32_IntPtr_0;

  static BatchCullingContext()
  {
    Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchCullingContext));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr);
    BatchCullingContext.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (cullingPlanes));
    BatchCullingContext.NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (cullingSplits));
    BatchCullingContext.NativeFieldInfoPtr_lodParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (lodParameters));
    BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (localToWorldMatrix));
    BatchCullingContext.NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (viewType));
    BatchCullingContext.NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (projectionType));
    BatchCullingContext.NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (cullingFlags));
    BatchCullingContext.NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (viewID));
    BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (cullingLayerMask));
    BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (sceneCullingMask));
    BatchCullingContext.NativeFieldInfoPtr_splitExclusionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (splitExclusionMask));
    BatchCullingContext.NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (isOrthographic));
    BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (receiverPlaneOffset));
    BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (receiverPlaneCount));
    BatchCullingContext.NativeFieldInfoPtr_occlusionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, nameof (occlusionBuffer));
    BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Byte_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, 100670291);
  }

  [CallerCount(0)]
  public unsafe BatchCullingContext(
    NativeArray<Plane> inCullingPlanes,
    NativeArray<CullingSplit> inCullingSplits,
    LODParameters inLodParameters,
    Matrix4x4 inLocalToWorldMatrix,
    BatchCullingViewType inViewType,
    BatchCullingProjectionType inProjectionType,
    BatchCullingFlags inBatchCullingFlags,
    ulong inViewID,
    uint inCullingLayerMask,
    ulong inSceneCullingMask,
    byte inExclusionSplitMask,
    int inReceiverPlaneOffset,
    int inReceiverPlaneCount,
    System.IntPtr inOcclusionBuffer)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[14];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) inCullingPlanes));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) inCullingSplits));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inLodParameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inLocalToWorldMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &inViewType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &inProjectionType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &inBatchCullingFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &inViewID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &inCullingLayerMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &inSceneCullingMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &inExclusionSplitMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &inReceiverPlaneOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &inReceiverPlaneCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &inOcclusionBuffer;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Byte_Int32_Int32_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public BatchCullingContext(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public BatchCullingContext()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
  {
  }

  public NativeArray<Plane> cullingPlanes
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes);
      return new NativeArray<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Plane>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Plane>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<CullingSplit> cullingSplits
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingSplits);
      return new NativeArray<CullingSplit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<CullingSplit>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingSplits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CullingSplit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe LODParameters lodParameters
  {
    get
    {
      return *(LODParameters*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters));
    }
    [param: In] set
    {
      *(LODParameters*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters)) = value;
    }
  }

  public unsafe Matrix4x4 localToWorldMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix)) = value;
    }
  }

  public unsafe BatchCullingViewType viewType
  {
    get
    {
      return *(BatchCullingViewType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewType));
    }
    [param: In] set
    {
      *(BatchCullingViewType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewType)) = value;
    }
  }

  public unsafe BatchCullingProjectionType projectionType
  {
    get
    {
      return *(BatchCullingProjectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_projectionType));
    }
    [param: In] set
    {
      *(BatchCullingProjectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_projectionType)) = value;
    }
  }

  public unsafe BatchCullingFlags cullingFlags
  {
    get
    {
      return *(BatchCullingFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingFlags));
    }
    [param: In] set
    {
      *(BatchCullingFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingFlags)) = value;
    }
  }

  public unsafe BatchPackedCullingViewID viewID
  {
    get
    {
      return *(BatchPackedCullingViewID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewID));
    }
    [param: In] set
    {
      *(BatchPackedCullingViewID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewID)) = value;
    }
  }

  public unsafe uint cullingLayerMask
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask)) = value;
    }
  }

  public unsafe ulong sceneCullingMask
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask)) = value;
    }
  }

  public unsafe ushort splitExclusionMask
  {
    get
    {
      return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_splitExclusionMask));
    }
    [param: In] set
    {
      *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_splitExclusionMask)) = value;
    }
  }

  public unsafe byte isOrthographic
  {
    get
    {
      return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_isOrthographic));
    }
    [param: In] set
    {
      *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_isOrthographic)) = value;
    }
  }

  public unsafe int receiverPlaneOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset)) = value;
    }
  }

  public unsafe int receiverPlaneCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount)) = value;
    }
  }

  public unsafe System.IntPtr occlusionBuffer
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_occlusionBuffer));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_occlusionBuffer)) = value;
    }
  }
}
