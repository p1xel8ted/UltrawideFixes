// Decompiled with JetBrains decompiler
// Type: UnityEngine.ComputeBuffer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class ComputeBuffer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_usage_Private_get_ComputeBufferMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Array_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginWrite_Public_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndWrite_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_usage_Injected_Private_Static_ComputeBufferMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly ComputeBuffer.InternalGetData_InjectedDelegate InternalGetData_InjectedDelegateField;
  private static readonly ComputeBuffer.SetCounterValue_InjectedDelegate SetCounterValue_InjectedDelegateField;
  private static readonly ComputeBuffer.CopyCount_InjectedDelegate CopyCount_InjectedDelegateField;
  private static readonly ComputeBuffer.GetNativeBufferPtr_InjectedDelegate GetNativeBufferPtr_InjectedDelegateField;

  static ComputeBuffer()
  {
    Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ComputeBuffer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr);
    ComputeBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, nameof (m_Ptr));
    ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668460);
    ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668461);
    ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668462);
    ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668463);
    ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668464);
    ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668465);
    ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668466);
    ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668467);
    ComputeBuffer.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668468);
    ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668469);
    ComputeBuffer.NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668470);
    ComputeBuffer.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668471);
    ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668472);
    ComputeBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668473);
    ComputeBuffer.NativeMethodInfoPtr_get_usage_Private_get_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668474);
    ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668475);
    ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668476);
    ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668477);
    ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668478);
    ComputeBuffer.NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668479);
    ComputeBuffer.NativeMethodInfoPtr_BeginWrite_Public_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668480);
    ComputeBuffer.NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668481);
    ComputeBuffer.NativeMethodInfoPtr_EndWrite_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668482);
    ComputeBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668483);
    ComputeBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668484);
    ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668485);
    ComputeBuffer.NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668486);
    ComputeBuffer.NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668487);
    ComputeBuffer.NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668488);
    ComputeBuffer.NativeMethodInfoPtr_get_usage_Injected_Private_Static_ComputeBufferMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668489);
    ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668490);
    ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668491);
    ComputeBuffer.NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668492);
    ComputeBuffer.NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668493);
    ComputeBuffer.NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100668494);
    ComputeBuffer.InternalGetData_InjectedDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalGetData_InjectedDelegate>("UnityEngine.ComputeBuffer::InternalGetData_Injected");
    ComputeBuffer.SetCounterValue_InjectedDelegateField = IL2CPP.ResolveICall<ComputeBuffer.SetCounterValue_InjectedDelegate>("UnityEngine.ComputeBuffer::SetCounterValue_Injected");
    ComputeBuffer.CopyCount_InjectedDelegateField = IL2CPP.ResolveICall<ComputeBuffer.CopyCount_InjectedDelegate>("UnityEngine.ComputeBuffer::CopyCount_Injected");
    ComputeBuffer.GetNativeBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<ComputeBuffer.GetNativeBufferPtr_InjectedDelegate>("UnityEngine.ComputeBuffer::GetNativeBufferPtr_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464502, XrefRangeEnd = 464511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 464520, RefRangeEnd = 464543, XrefRangeStart = 464511, XrefRangeEnd = 464520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464543, XrefRangeEnd = 464549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose(bool disposing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &disposing
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464549, XrefRangeEnd = 464551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr InitBuffer(
    int count,
    int stride,
    ComputeBufferType type,
    ComputeBufferMode usage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &usage;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464551, XrefRangeEnd = 464554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyBuffer(ComputeBuffer buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buf)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 464555, RefRangeEnd = 464559, XrefRangeStart = 464554, XrefRangeEnd = 464555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ComputeBuffer(int count, int stride)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 464560, RefRangeEnd = 464572, XrefRangeStart = 464559, XrefRangeEnd = 464560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 464573, RefRangeEnd = 464582, XrefRangeStart = 464572, XrefRangeEnd = 464573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ComputeBuffer(
    int count,
    int stride,
    ComputeBufferType type,
    ComputeBufferMode usage)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &usage;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 464587, RefRangeEnd = 464590, XrefRangeStart = 464582, XrefRangeEnd = 464587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ComputeBuffer(
    int count,
    int stride,
    ComputeBufferType type,
    ComputeBufferMode usage,
    int stackDepth)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &usage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stackDepth;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 464520, RefRangeEnd = 464543, XrefRangeStart = 464520, XrefRangeEnd = 464543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464590, XrefRangeEnd = 464593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidBuffer(ComputeBuffer buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buf)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_ComputeBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 464593, RefRangeEnd = 464594, XrefRangeStart = 464593, XrefRangeEnd = 464593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe int count
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 464598, RefRangeEnd = 464600, XrefRangeStart = 464594, XrefRangeEnd = 464598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int stride
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 464604, RefRangeEnd = 464616, XrefRangeStart = 464600, XrefRangeEnd = 464604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ComputeBufferMode usage
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 464620, RefRangeEnd = 464621, XrefRangeStart = 464616, XrefRangeEnd = 464620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_usage_Private_get_ComputeBufferMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ComputeBufferMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 464628, RefRangeEnd = 464641, XrefRangeStart = 464621, XrefRangeEnd = 464628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData(Il2CppSystem.Array data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 464645, RefRangeEnd = 464647, XrefRangeStart = 464641, XrefRangeEnd = 464645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData<T>(
    NativeArray<T> data,
    int nativeBufferStartIndex,
    int computeBufferStartIndex,
    int count)
    where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &computeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 464651, RefRangeEnd = 464653, XrefRangeStart = 464647, XrefRangeEnd = 464651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalSetNativeData(
    System.IntPtr data,
    int nativeBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &computeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &elemSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464653, XrefRangeEnd = 464657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalSetData(
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &managedBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &computeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &elemSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 464661, RefRangeEnd = 464662, XrefRangeStart = 464657, XrefRangeEnd = 464661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void* BeginBufferWrite(int offset = 0, int size = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return (void*) num2;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464662, XrefRangeEnd = 464668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count) where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &computeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.MethodInfoStoreGeneric_BeginWrite_Public_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 464672, RefRangeEnd = 464673, XrefRangeStart = 464668, XrefRangeEnd = 464672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndBufferWrite(int bytesWritten = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &bytesWritten
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464673, XrefRangeEnd = 464686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndWrite<T>(int countWritten) where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &countWritten
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.MethodInfoStoreGeneric_EndWrite_Public_Void_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string name
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 464687, RefRangeEnd = 464697, XrefRangeStart = 464686, XrefRangeEnd = 464687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 464712, RefRangeEnd = 464713, XrefRangeStart = 464697, XrefRangeEnd = 464712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetName(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464713, XrefRangeEnd = 464715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyBuffer_Injected(System.IntPtr buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buf
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464715, XrefRangeEnd = 464717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidBuffer_Injected(System.IntPtr buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buf
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464717, XrefRangeEnd = 464719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_count_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464719, XrefRangeEnd = 464721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_stride_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464721, XrefRangeEnd = 464723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ComputeBufferMode get_usage_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_usage_Injected_Private_Static_ComputeBufferMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ComputeBufferMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464723, XrefRangeEnd = 464725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InternalSetNativeData_Injected(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int nativeBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &computeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &elemSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464725, XrefRangeEnd = 464727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InternalSetData_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &managedBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &computeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &elemSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464727, XrefRangeEnd = 464729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* BeginBufferWrite_Injected(System.IntPtr _unity_self, int offset, int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return (void*) num2;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464729, XrefRangeEnd = 464731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EndBufferWrite_Injected(System.IntPtr _unity_self, int bytesWritten)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bytesWritten;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464731, XrefRangeEnd = 464733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public void SetData<T>(List<T> data) where T : struct
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    this.InternalSetData((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
  }

  public unsafe void SetData<T>(NativeArray<T> data) where T : struct
  {
    this.InternalSetNativeData((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), 0, 0, ((NativeArray<T>) ref data).Length, UnsafeUtility.SizeOf<T>());
  }

  public void SetData(
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count)
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsArrayBlittable(data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to ComputeBuffer.SetData(array) must be blittable.\n{0}", (Il2CppSystem.Object) UnsafeUtility.GetReasonForArrayNonBlittable(data)));
    if (managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object) (System.ValueType) managedBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) computeBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) count));
    this.InternalSetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
  }

  public void SetData<T>(
    List<T> data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count)
    where T : struct
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    if (managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object) (System.ValueType) managedBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) computeBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) count));
    this.InternalSetData((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
  }

  public void GetData(Il2CppSystem.Array data)
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsArrayBlittable(data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object) UnsafeUtility.GetReasonForArrayNonBlittable(data)));
    this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
  }

  public void GetData(
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count)
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsArrayBlittable(data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object) UnsafeUtility.GetReasonForArrayNonBlittable(data)));
    if (managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object) (System.ValueType) managedBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) computeBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) count));
    this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
  }

  public void InternalGetData(
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize)
  {
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeBuffer.InternalGetData_Injected(native, data, managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
  }

  public void SetCounterValue(uint counterValue)
  {
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeBuffer.SetCounterValue_Injected(native, counterValue);
  }

  public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
  {
    ComputeBuffer.CopyCount_Injected(src == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(src), dst == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
  }

  public System.IntPtr GetNativeBufferPtr()
  {
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ComputeBuffer.GetNativeBufferPtr_Injected(native);
  }

  public static void InternalGetData_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize)
  {
    ComputeBuffer.InternalGetData_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
  }

  public static void SetCounterValue_Injected(System.IntPtr _unity_self, uint counterValue)
  {
    ComputeBuffer.SetCounterValue_InjectedDelegateField(_unity_self, counterValue);
  }

  public static void CopyCount_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
  {
    ComputeBuffer.CopyCount_InjectedDelegateField(src, dst, dstOffsetBytes);
  }

  public static System.IntPtr GetNativeBufferPtr_Injected(System.IntPtr _unity_self)
  {
    return ComputeBuffer.GetNativeBufferPtr_InjectedDelegateField(_unity_self);
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_ComputeBuffer_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<ComputeBuffer.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBuffer.BindingsMarshaller>.NativeClassPtr);
      ComputeBuffer.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer.BindingsMarshaller>.NativeClassPtr, 100668495);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(ComputeBuffer computeBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) computeBuffer)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_ComputeBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_BeginWrite_Public_NativeArray_1_T_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ComputeBuffer.NativeMethodInfoPtr_BeginWrite_Public_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_EndWrite_Public_Void_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ComputeBuffer.NativeMethodInfoPtr_EndWrite_Public_Void_Int32_0, Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate void InternalGetData_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize);

  private delegate void SetCounterValue_InjectedDelegate(System.IntPtr _unity_self, uint counterValue);

  private delegate void CopyCount_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

  private delegate System.IntPtr GetNativeBufferPtr_InjectedDelegate(System.IntPtr _unity_self);
}
