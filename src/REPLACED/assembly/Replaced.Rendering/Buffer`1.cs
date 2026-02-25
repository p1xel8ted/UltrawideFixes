// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.Buffer`1
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

public sealed class Buffer<Data>(System.IntPtr pointer) : Il2CppSystem.Object(pointer) where Data : new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_array;
  private static readonly System.IntPtr NativeFieldInfoPtr__gpuBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferType_ComputeBufferMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindGlobalWithoutUpdate_Public_Void_CommandBuffer_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindWithoutUpdate_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGpuBuffer_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGpuBuffer_Public_Void_CommandBuffer_Int32_Int32_0;

  static Buffer()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", "Buffer`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Data>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr);
    Buffer<Data>.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, nameof (array));
    Buffer<Data>.NativeFieldInfoPtr__gpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, nameof (_gpuBuffer));
    Buffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663303 /*0x06000007*/);
    Buffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663304 /*0x06000008*/);
    Buffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferType_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663305 /*0x06000009*/);
    Buffer<Data>.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663306 /*0x0600000A*/);
    Buffer<Data>.NativeMethodInfoPtr_BindGlobalWithoutUpdate_Public_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663307 /*0x0600000B*/);
    Buffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663308 /*0x0600000C*/);
    Buffer<Data>.NativeMethodInfoPtr_BindWithoutUpdate_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663309 /*0x0600000D*/);
    Buffer<Data>.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663310 /*0x0600000E*/);
    Buffer<Data>.NativeMethodInfoPtr_UpdateGpuBuffer_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663311 /*0x0600000F*/);
    Buffer<Data>.NativeMethodInfoPtr_UpdateGpuBuffer_Public_Void_CommandBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr, 100663312 /*0x06000010*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923721, XrefRangeEnd = 923730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Buffer(string label, int itemCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923730, XrefRangeEnd = 923739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Buffer(string label, int itemCount, ComputeBufferMode usage)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &usage;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 923813, RefRangeEnd = 923814, XrefRangeStart = 923739, XrefRangeEnd = 923813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Buffer(
    string label,
    int itemCount,
    ComputeBufferType type,
    ComputeBufferMode usage)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<Data>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &usage;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferType_ComputeBufferMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923814, XrefRangeEnd = 923819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindGlobal(CommandBuffer cmd, int sid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sid;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 923821, RefRangeEnd = 923846, XrefRangeStart = 923819, XrefRangeEnd = 923821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindGlobalWithoutUpdate(CommandBuffer cmd, int sid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sid;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr_BindGlobalWithoutUpdate_Public_Void_CommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923846, XrefRangeEnd = 923895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bind(CommandBuffer cmd, ComputeShader compute, int kernel, int sid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sid;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 923897, RefRangeEnd = 923899, XrefRangeStart = 923895, XrefRangeEnd = 923897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindWithoutUpdate(
    CommandBuffer cmd,
    ComputeShader compute,
    int kernel,
    int sid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sid;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr_BindWithoutUpdate_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 923900, RefRangeEnd = 923935, XrefRangeStart = 923899, XrefRangeEnd = 923900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 923937, RefRangeEnd = 923956, XrefRangeStart = 923935, XrefRangeEnd = 923937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateGpuBuffer(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr_UpdateGpuBuffer_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 923957, RefRangeEnd = 923963, XrefRangeStart = 923956, XrefRangeEnd = 923957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateGpuBuffer(CommandBuffer cmd, int startIndex, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Buffer<Data>.NativeMethodInfoPtr_UpdateGpuBuffer_Public_Void_CommandBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppArrayBase<Data> array
  {
    get
    {
      return Il2CppArrayBase<Data>.WrapNativeGenericArrayPointer(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Buffer<Data>.NativeFieldInfoPtr_array)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Buffer<Data>.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _gpuBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Buffer<Data>.NativeFieldInfoPtr__gpuBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Buffer<Data>.NativeFieldInfoPtr__gpuBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
