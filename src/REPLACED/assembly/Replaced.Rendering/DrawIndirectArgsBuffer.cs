// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DrawIndirectArgsBuffer
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class DrawIndirectArgsBuffer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__cpuArgsBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__gpuBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GpuBuffer_Public_get_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInstanceCount_Public_Void_CommandBuffer_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static DrawIndirectArgsBuffer()
  {
    Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DrawIndirectArgsBuffer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr);
    DrawIndirectArgsBuffer.NativeFieldInfoPtr__cpuArgsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr, nameof (_cpuArgsBuffer));
    DrawIndirectArgsBuffer.NativeFieldInfoPtr__gpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr, nameof (_gpuBuffer));
    DrawIndirectArgsBuffer.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr, 100663319 /*0x06000017*/);
    DrawIndirectArgsBuffer.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr, 100663320 /*0x06000018*/);
    DrawIndirectArgsBuffer.NativeMethodInfoPtr_get_GpuBuffer_Public_get_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr, 100663321 /*0x06000019*/);
    DrawIndirectArgsBuffer.NativeMethodInfoPtr_SetInstanceCount_Public_Void_CommandBuffer_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr, 100663322 /*0x0600001A*/);
    DrawIndirectArgsBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr, 100663323 /*0x0600001B*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924110, RefRangeEnd = 924111, XrefRangeStart = 924099, XrefRangeEnd = 924110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DrawIndirectArgsBuffer(uint indexCountPerInstance)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &indexCountPerInstance
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrawIndirectArgsBuffer.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924111, XrefRangeEnd = 924122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DrawIndirectArgsBuffer(
    uint indexCountPerInstance,
    uint instanceCount,
    uint startIndexLocation,
    uint baseVertexLocation,
    uint startInstanceLocation)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawIndirectArgsBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &indexCountPerInstance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &instanceCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndexLocation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &baseVertexLocation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startInstanceLocation;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrawIndirectArgsBuffer.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ComputeBuffer GpuBuffer
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DrawIndirectArgsBuffer.NativeMethodInfoPtr_get_GpuBuffer_Public_get_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924123, RefRangeEnd = 924124, XrefRangeStart = 924122, XrefRangeEnd = 924123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInstanceCount(CommandBuffer cmd, ComputeBuffer appendConsumeBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) appendConsumeBuffer);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrawIndirectArgsBuffer.NativeMethodInfoPtr_SetInstanceCount_Public_Void_CommandBuffer_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 923900, RefRangeEnd = 923935, XrefRangeStart = 923900, XrefRangeEnd = 923935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrawIndirectArgsBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStructArray<uint> _cpuArgsBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawIndirectArgsBuffer.NativeFieldInfoPtr__cpuArgsBuffer));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<uint>) null : Il2CppObjectPool.Get<Il2CppStructArray<uint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawIndirectArgsBuffer.NativeFieldInfoPtr__cpuArgsBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _gpuBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawIndirectArgsBuffer.NativeFieldInfoPtr__gpuBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawIndirectArgsBuffer.NativeFieldInfoPtr__gpuBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
