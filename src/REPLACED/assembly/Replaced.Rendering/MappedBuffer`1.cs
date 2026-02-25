// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MappedBuffer`1
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class MappedBuffer<Data>(System.IntPtr pointer) : Il2CppSystem.Object(pointer) where Data : new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr__mappedArray;
  private static readonly System.IntPtr NativeFieldInfoPtr__gpuBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__totalItemCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__isMapped;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginWrite_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndWrite_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Void_Int32_byref_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static MappedBuffer()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", "MappedBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Data>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr);
    MappedBuffer<Data>.NativeFieldInfoPtr__mappedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, nameof (_mappedArray));
    MappedBuffer<Data>.NativeFieldInfoPtr__gpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, nameof (_gpuBuffer));
    MappedBuffer<Data>.NativeFieldInfoPtr__totalItemCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, nameof (_totalItemCount));
    MappedBuffer<Data>.NativeFieldInfoPtr__isMapped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, nameof (_isMapped));
    MappedBuffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663324 /*0x0600001C*/);
    MappedBuffer<Data>.NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663325 /*0x0600001D*/);
    MappedBuffer<Data>.NativeMethodInfoPtr_BeginWrite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663326 /*0x0600001E*/);
    MappedBuffer<Data>.NativeMethodInfoPtr_EndWrite_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663327 /*0x0600001F*/);
    MappedBuffer<Data>.NativeMethodInfoPtr_Write_Public_Void_Int32_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663328 /*0x06000020*/);
    MappedBuffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663329 /*0x06000021*/);
    MappedBuffer<Data>.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663330 /*0x06000022*/);
    MappedBuffer<Data>.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr, 100663331 /*0x06000023*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924124, XrefRangeEnd = 924131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MappedBuffer(string label, int itemCount, ComputeBufferType type)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MappedBuffer<Data>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ComputeBufferType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool IsMapped
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe void BeginWrite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr_BeginWrite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void EndWrite(int writtenItemCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &writtenItemCount
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr_EndWrite_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924131, XrefRangeEnd = 924133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Write(int idx, [In] ref Data dataItem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &idx;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dataItem);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr_Write_Public_Void_Int32_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Data local = ref dataItem;
    System.IntPtr num3 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<Data>(num3, false, false);
    local = (Data) valueGeneric;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924133, XrefRangeEnd = 924135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bind(CommandBuffer cmd, ComputeShader compute, int kernel, int sid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sid;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924135, XrefRangeEnd = 924137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindGlobal(CommandBuffer cmd, int sid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sid;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924137, XrefRangeEnd = 924138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MappedBuffer<Data>.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public NativeArray<Data> _mappedArray
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__mappedArray);
      return new NativeArray<Data>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Data>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__mappedArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe ComputeBuffer _gpuBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__gpuBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__gpuBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _totalItemCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__totalItemCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__totalItemCount)) = value;
    }
  }

  public unsafe bool _isMapped
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__isMapped));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MappedBuffer<Data>.NativeFieldInfoPtr__isMapped)) = value;
    }
  }
}
