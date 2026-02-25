// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusteredLightListData
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

public sealed class ClusteredLightListData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kLightsPerTileLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidCllPunctualLightList;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidCllLineLightList;
  private static readonly System.IntPtr NativeFieldInfoPtr__gridSize3D;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__punctualLightBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__lineLightBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_ComputeBufferMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseBuffer_Private_Static_Void_byref_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GridSize2D_Public_get_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GridSize3D_Public_get_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PunctualLightBuffer_Public_get_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LineLightBuffer_Public_get_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupFrame_Public_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0;

  static ClusteredLightListData()
  {
    Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusteredLightListData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr);
    ClusteredLightListData.NativeFieldInfoPtr_kLightsPerTileLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (kLightsPerTileLimit));
    ClusteredLightListData.NativeFieldInfoPtr_kSidCllPunctualLightList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (kSidCllPunctualLightList));
    ClusteredLightListData.NativeFieldInfoPtr_kSidCllLineLightList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (kSidCllLineLightList));
    ClusteredLightListData.NativeFieldInfoPtr__gridSize3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (_gridSize3D));
    ClusteredLightListData.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (_cbuffer));
    ClusteredLightListData.NativeFieldInfoPtr__punctualLightBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (_punctualLightBuffer));
    ClusteredLightListData.NativeFieldInfoPtr__lineLightBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (_lineLightBuffer));
    ClusteredLightListData.NativeMethodInfoPtr_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663828);
    ClusteredLightListData.NativeMethodInfoPtr_ReleaseBuffer_Private_Static_Void_byref_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663829);
    ClusteredLightListData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663830);
    ClusteredLightListData.NativeMethodInfoPtr_get_GridSize2D_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663831);
    ClusteredLightListData.NativeMethodInfoPtr_get_GridSize3D_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663832);
    ClusteredLightListData.NativeMethodInfoPtr_get_PunctualLightBuffer_Public_get_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663833);
    ClusteredLightListData.NativeMethodInfoPtr_get_LineLightBuffer_Public_get_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663834);
    ClusteredLightListData.NativeMethodInfoPtr_SetupFrame_Public_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663835);
    ClusteredLightListData.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663836);
    ClusteredLightListData.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, 100663837);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929660, RefRangeEnd = 929662, XrefRangeStart = 929655, XrefRangeEnd = 929660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ComputeBuffer MakeByteAddressBuffer(
    string label,
    int itemCount,
    ComputeBufferMode mode = ComputeBufferMode.Immutable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_ComputeBufferMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929662, XrefRangeEnd = 929663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReleaseBuffer(ref ComputeBuffer buffer)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_ReleaseBuffer_Private_Static_Void_byref_ComputeBuffer_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    ref ComputeBuffer local = ref buffer;
    System.IntPtr pointer = ptr;
    ComputeBuffer computeBuffer = pointer == System.IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer);
    local = computeBuffer;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929672, RefRangeEnd = 929673, XrefRangeStart = 929663, XrefRangeEnd = 929672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClusteredLightListData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector2Int GridSize2D
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_get_GridSize2D_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3Int GridSize3D
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_get_GridSize3D_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ComputeBuffer PunctualLightBuffer
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_get_PunctualLightBuffer_Public_get_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num3);
    }
  }

  public unsafe ComputeBuffer LineLightBuffer
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_get_LineLightBuffer_Public_get_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929701, RefRangeEnd = 929702, XrefRangeStart = 929673, XrefRangeEnd = 929701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupFrame(
    CommandBuffer cmd,
    Vector3Int gridSize3D,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gridSize3D;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_SetupFrame_Public_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929710, RefRangeEnd = 929711, XrefRangeStart = 929702, XrefRangeEnd = 929710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929719, RefRangeEnd = 929720, XrefRangeStart = 929711, XrefRangeEnd = 929719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    Vector3Int gridSize3D,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gridSize3D;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClusteredLightListData.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector3Int_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kLightsPerTileLimit
  {
    get
    {
      int lightsPerTileLimit;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListData.NativeFieldInfoPtr_kLightsPerTileLimit, (void*) &lightsPerTileLimit);
      return lightsPerTileLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListData.NativeFieldInfoPtr_kLightsPerTileLimit, (void*) &value);
    }
  }

  public static unsafe int kSidCllPunctualLightList
  {
    get
    {
      int punctualLightList;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListData.NativeFieldInfoPtr_kSidCllPunctualLightList, (void*) &punctualLightList);
      return punctualLightList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListData.NativeFieldInfoPtr_kSidCllPunctualLightList, (void*) &value);
    }
  }

  public static unsafe int kSidCllLineLightList
  {
    get
    {
      int cllLineLightList;
      IL2CPP.il2cpp_field_static_get_value(ClusteredLightListData.NativeFieldInfoPtr_kSidCllLineLightList, (void*) &cllLineLightList);
      return cllLineLightList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ClusteredLightListData.NativeFieldInfoPtr_kSidCllLineLightList, (void*) &value);
    }
  }

  public unsafe Vector3Int _gridSize3D
  {
    get
    {
      return *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__gridSize3D));
    }
    [param: In] set
    {
      *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__gridSize3D)) = value;
    }
  }

  public unsafe CBuffer<ClusteredLightListData.ClusteredLightListCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ClusteredLightListData.ClusteredLightListCBufferData>) null : Il2CppObjectPool.Get<CBuffer<ClusteredLightListData.ClusteredLightListCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _punctualLightBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__punctualLightBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__punctualLightBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _lineLightBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__lineLightBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClusteredLightListData.NativeFieldInfoPtr__lineLightBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ClusteredLightListCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_gridSize3D;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding0;
    private static readonly System.IntPtr NativeFieldInfoPtr_gridCoordsToFlatIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_screenCoordsToGridCoords;
    private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrixRow2;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthVsToSliceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthVsToSliceIndexUniform;
    [FieldOffset(0)]
    public Vector3Int gridSize3D;
    [FieldOffset(12)]
    public uint padding0;
    [FieldOffset(16 /*0x10*/)]
    public Vector2Int gridCoordsToFlatIndex;
    [FieldOffset(24)]
    public Vector2 screenCoordsToGridCoords;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 viewMatrixRow2;
    [FieldOffset(48 /*0x30*/)]
    public Vector2 depthVsToSliceIndex;
    [FieldOffset(56)]
    public Vector2 depthVsToSliceIndexUniform;

    static ClusteredLightListCBufferData()
    {
      Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClusteredLightListData>.NativeClassPtr, nameof (ClusteredLightListCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr);
      ClusteredLightListData.ClusteredLightListCBufferData.NativeFieldInfoPtr_gridSize3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, nameof (gridSize3D));
      ClusteredLightListData.ClusteredLightListCBufferData.NativeFieldInfoPtr_padding0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, nameof (padding0));
      ClusteredLightListData.ClusteredLightListCBufferData.NativeFieldInfoPtr_gridCoordsToFlatIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, nameof (gridCoordsToFlatIndex));
      ClusteredLightListData.ClusteredLightListCBufferData.NativeFieldInfoPtr_screenCoordsToGridCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, nameof (screenCoordsToGridCoords));
      ClusteredLightListData.ClusteredLightListCBufferData.NativeFieldInfoPtr_viewMatrixRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, nameof (viewMatrixRow2));
      ClusteredLightListData.ClusteredLightListCBufferData.NativeFieldInfoPtr_depthVsToSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, nameof (depthVsToSliceIndex));
      ClusteredLightListData.ClusteredLightListCBufferData.NativeFieldInfoPtr_depthVsToSliceIndexUniform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, nameof (depthVsToSliceIndexUniform));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClusteredLightListData.ClusteredLightListCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
