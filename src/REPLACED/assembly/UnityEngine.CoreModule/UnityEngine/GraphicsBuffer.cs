// Decompiled with JetBrains decompiler
// Type: UnityEngine.GraphicsBuffer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class GraphicsBuffer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Target_UsageFlags_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_GraphicsBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUsageFlags_Private_UsageFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_usageFlags_Public_get_UsageFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnlockBufferAfterWrite_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUsageFlags_Injected_Private_Static_UsageFlags_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly GraphicsBuffer.get_target_InjectedDelegate get_target_InjectedDelegateField;
  private static readonly GraphicsBuffer.get_bufferHandle_InjectedDelegate get_bufferHandle_InjectedDelegateField;
  private static readonly GraphicsBuffer.InternalSetData_InjectedDelegate InternalSetData_InjectedDelegateField;
  private static readonly GraphicsBuffer.InternalGetData_InjectedDelegate InternalGetData_InjectedDelegateField;
  private static readonly GraphicsBuffer.GetNativeBufferPtr_InjectedDelegate GetNativeBufferPtr_InjectedDelegateField;
  private static readonly GraphicsBuffer.SetCounterValue_InjectedDelegate SetCounterValue_InjectedDelegateField;
  private static readonly GraphicsBuffer.CopyCountCC_InjectedDelegate CopyCountCC_InjectedDelegateField;
  private static readonly GraphicsBuffer.CopyCountGC_InjectedDelegate CopyCountGC_InjectedDelegateField;
  private static readonly GraphicsBuffer.CopyCountCG_InjectedDelegate CopyCountCG_InjectedDelegateField;
  private static readonly GraphicsBuffer.CopyCountGG_InjectedDelegate CopyCountGG_InjectedDelegateField;

  static GraphicsBuffer()
  {
    Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (GraphicsBuffer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr);
    GraphicsBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, nameof (m_Ptr));
    GraphicsBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665788);
    GraphicsBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665789);
    GraphicsBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665790);
    GraphicsBuffer.NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665791);
    GraphicsBuffer.NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665792 /*0x060009C0*/);
    GraphicsBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665793);
    GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665794);
    GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665796);
    GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665797);
    GraphicsBuffer.NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665798);
    GraphicsBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665799);
    GraphicsBuffer.NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665800);
    GraphicsBuffer.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665801);
    GraphicsBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665802);
    GraphicsBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665803);
    GraphicsBuffer.NativeMethodInfoPtr_GetUsageFlags_Private_UsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665804);
    GraphicsBuffer.NativeMethodInfoPtr_get_usageFlags_Public_get_UsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665805);
    GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665806);
    GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665807);
    GraphicsBuffer.NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665808 /*0x060009D0*/);
    GraphicsBuffer.NativeMethodInfoPtr_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665809);
    GraphicsBuffer.NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665810);
    GraphicsBuffer.NativeMethodInfoPtr_UnlockBufferAfterWrite_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665811);
    GraphicsBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665812);
    GraphicsBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665813);
    GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665814);
    GraphicsBuffer.NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665815);
    GraphicsBuffer.NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665816);
    GraphicsBuffer.NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665817);
    GraphicsBuffer.NativeMethodInfoPtr_GetUsageFlags_Injected_Private_Static_UsageFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665818);
    GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665819);
    GraphicsBuffer.NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665820);
    GraphicsBuffer.NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665821);
    GraphicsBuffer.NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665822);
    GraphicsBuffer.get_target_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_target_InjectedDelegate>("UnityEngine.GraphicsBuffer::get_target_Injected");
    GraphicsBuffer.get_bufferHandle_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_bufferHandle_InjectedDelegate>("UnityEngine.GraphicsBuffer::get_bufferHandle_Injected");
    GraphicsBuffer.InternalSetData_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalSetData_InjectedDelegate>("UnityEngine.GraphicsBuffer::InternalSetData_Injected");
    GraphicsBuffer.InternalGetData_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalGetData_InjectedDelegate>("UnityEngine.GraphicsBuffer::InternalGetData_Injected");
    GraphicsBuffer.GetNativeBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.GetNativeBufferPtr_InjectedDelegate>("UnityEngine.GraphicsBuffer::GetNativeBufferPtr_Injected");
    GraphicsBuffer.SetCounterValue_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.SetCounterValue_InjectedDelegate>("UnityEngine.GraphicsBuffer::SetCounterValue_Injected");
    GraphicsBuffer.CopyCountCC_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCC_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountCC_Injected");
    GraphicsBuffer.CopyCountGC_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGC_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountGC_Injected");
    GraphicsBuffer.CopyCountCG_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCG_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountCG_Injected");
    GraphicsBuffer.CopyCountGG_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGG_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountGG_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430125, XrefRangeEnd = 430134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 430143, RefRangeEnd = 430155, XrefRangeStart = 430134, XrefRangeEnd = 430143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430155, XrefRangeEnd = 430161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose(bool disposing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &disposing
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe bool RequiresCompute(GraphicsBuffer.Target target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &target
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsVertexIndexOrCopyOnly(GraphicsBuffer.Target target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &target
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430161, XrefRangeEnd = 430163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr InitBuffer(
    GraphicsBuffer.Target target,
    GraphicsBuffer.UsageFlags usageFlags,
    int count,
    int stride)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usageFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430163, XrefRangeEnd = 430166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyBuffer(GraphicsBuffer buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buf)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 430168, RefRangeEnd = 430176, XrefRangeStart = 430166, XrefRangeEnd = 430168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphicsBuffer(GraphicsBuffer.Target target, int count, int stride)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 430178, RefRangeEnd = 430181, XrefRangeStart = 430176, XrefRangeEnd = 430178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphicsBuffer(
    GraphicsBuffer.Target target,
    GraphicsBuffer.UsageFlags usageFlags,
    int count,
    int stride)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usageFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_UsageFlags_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 430185, RefRangeEnd = 430187, XrefRangeStart = 430181, XrefRangeEnd = 430185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalInitialization(
    GraphicsBuffer.Target target,
    GraphicsBuffer.UsageFlags usageFlags,
    int count,
    int stride)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usageFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 430143, RefRangeEnd = 430155, XrefRangeStart = 430143, XrefRangeEnd = 430155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430187, XrefRangeEnd = 430190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidBuffer(GraphicsBuffer buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buf)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_GraphicsBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 430190, RefRangeEnd = 430192, XrefRangeStart = 430190, XrefRangeEnd = 430190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe int count
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 430196, RefRangeEnd = 430199, XrefRangeStart = 430192, XrefRangeEnd = 430196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int stride
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 430203, RefRangeEnd = 430206, XrefRangeStart = 430199, XrefRangeEnd = 430203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 430210, RefRangeEnd = 430211, XrefRangeStart = 430206, XrefRangeEnd = 430210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphicsBuffer.UsageFlags GetUsageFlags()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_GetUsageFlags_Private_UsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsBuffer.UsageFlags*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe GraphicsBuffer.UsageFlags usageFlags
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 430210, RefRangeEnd = 430211, XrefRangeStart = 430210, XrefRangeEnd = 430211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_get_usageFlags_Public_get_UsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphicsBuffer.UsageFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 430215, RefRangeEnd = 430217, XrefRangeStart = 430211, XrefRangeEnd = 430215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData<T>(
    NativeArray<T> data,
    int nativeBufferStartIndex,
    int graphicsBufferStartIndex,
    int count)
    where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &graphicsBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 430221, RefRangeEnd = 430222, XrefRangeStart = 430217, XrefRangeEnd = 430221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalSetNativeData(
    System.IntPtr data,
    int nativeBufferStartIndex,
    int graphicsBufferStartIndex,
    int count,
    int elemSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &graphicsBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &elemSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 430226, RefRangeEnd = 430227, XrefRangeStart = 430222, XrefRangeEnd = 430226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void* BeginBufferWrite(int offset = 0, int size = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return (void*) num2;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 430234, RefRangeEnd = 430235, XrefRangeStart = 430227, XrefRangeEnd = 430234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count) where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &bufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.MethodInfoStoreGeneric_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 430239, RefRangeEnd = 430241, XrefRangeStart = 430235, XrefRangeEnd = 430239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndBufferWrite(int bytesWritten = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &bytesWritten
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 430261, RefRangeEnd = 430262, XrefRangeStart = 430241, XrefRangeEnd = 430261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnlockBufferAfterWrite<T>(int countWritten) where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &countWritten
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.MethodInfoStoreGeneric_UnlockBufferAfterWrite_Public_Void_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string name
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 430263, RefRangeEnd = 430264, XrefRangeStart = 430262, XrefRangeEnd = 430263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 430279, RefRangeEnd = 430280, XrefRangeStart = 430264, XrefRangeEnd = 430279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetName(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430280, XrefRangeEnd = 430282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyBuffer_Injected(System.IntPtr buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buf
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430282, XrefRangeEnd = 430284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidBuffer_Injected(System.IntPtr buf)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buf
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430284, XrefRangeEnd = 430286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_count_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430286, XrefRangeEnd = 430288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_stride_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430288, XrefRangeEnd = 430290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsBuffer.UsageFlags GetUsageFlags_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_GetUsageFlags_Injected_Private_Static_UsageFlags_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsBuffer.UsageFlags*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430290, XrefRangeEnd = 430292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InternalSetNativeData_Injected(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int nativeBufferStartIndex,
    int graphicsBufferStartIndex,
    int count,
    int elemSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &graphicsBufferStartIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &elemSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430292, XrefRangeEnd = 430294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* BeginBufferWrite_Injected(System.IntPtr _unity_self, int offset, int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return (void*) num2;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430294, XrefRangeEnd = 430296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EndBufferWrite_Injected(System.IntPtr _unity_self, int bytesWritten)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bytesWritten;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430296, XrefRangeEnd = 430298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsBuffer.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public GraphicsBuffer.Target target
  {
    get
    {
      System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsBuffer.get_target_Injected(native);
    }
  }

  public GraphicsBufferHandle bufferHandle
  {
    get
    {
      System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      GraphicsBufferHandle ret;
      GraphicsBuffer.get_bufferHandle_Injected(native, out ret);
      return ret;
    }
  }

  public void SetData(Il2CppSystem.Array data)
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsArrayBlittable(data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", (Il2CppSystem.Object) UnsafeUtility.GetReasonForArrayNonBlittable(data)));
    this.InternalSetData(data, 0, 0, data.Length, UnsafeUtility.SizeOf(data.GetType().GetElementType()));
  }

  public void SetData<T>(List<T> data) where T : struct
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    this.InternalSetData((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
  }

  public unsafe void SetData<T>(NativeArray<T> data) where T : struct
  {
    this.InternalSetNativeData((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), 0, 0, ((NativeArray<T>) ref data).Length, UnsafeUtility.SizeOf<T>());
  }

  public void SetData(
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int graphicsBufferStartIndex,
    int count)
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsArrayBlittable(data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", (Il2CppSystem.Object) UnsafeUtility.GetReasonForArrayNonBlittable(data)));
    if (managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object) (System.ValueType) managedBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) graphicsBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) count));
    this.InternalSetData(data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
  }

  public void SetData<T>(
    List<T> data,
    int managedBufferStartIndex,
    int graphicsBufferStartIndex,
    int count)
    where T : struct
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    if (managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object) (System.ValueType) managedBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) graphicsBufferStartIndex, (Il2CppSystem.Object) (System.ValueType) count));
    this.InternalSetData((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
  }

  public void InternalSetData(
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int graphicsBufferStartIndex,
    int count,
    int elemSize)
  {
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GraphicsBuffer.InternalSetData_Injected(native, data, managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
  }

  public void GetData(Il2CppSystem.Array data)
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsArrayBlittable(data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object) UnsafeUtility.GetReasonForArrayNonBlittable(data)));
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
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object) UnsafeUtility.GetReasonForArrayNonBlittable(data)));
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
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GraphicsBuffer.InternalGetData_Injected(native, data, managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
  }

  public System.IntPtr GetNativeBufferPtr()
  {
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return GraphicsBuffer.GetNativeBufferPtr_Injected(native);
  }

  public void SetCounterValue(uint counterValue)
  {
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GraphicsBuffer.SetCounterValue_Injected(native, counterValue);
  }

  public static void CopyCountCC(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountCC_Injected(src == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(src), dst == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
  }

  public static void CopyCountGC(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountGC_Injected(src == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(src), dst == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
  }

  public static void CopyCountCG(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountCG_Injected(src == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(src), dst == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
  }

  public static void CopyCountGG(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountGG_Injected(src == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(src), dst == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
  }

  public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountCC(src, dst, dstOffsetBytes);
  }

  public static void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountGC(src, dst, dstOffsetBytes);
  }

  public static void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountCG(src, dst, dstOffsetBytes);
  }

  public static void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountGG(src, dst, dstOffsetBytes);
  }

  public static GraphicsBuffer.Target get_target_Injected(System.IntPtr _unity_self)
  {
    return GraphicsBuffer.get_target_InjectedDelegateField(_unity_self);
  }

  public static void get_bufferHandle_Injected(System.IntPtr _unity_self, out GraphicsBufferHandle ret)
  {
    GraphicsBuffer.get_bufferHandle_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void InternalSetData_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int graphicsBufferStartIndex,
    int count,
    int elemSize)
  {
    GraphicsBuffer.InternalSetData_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
  }

  public static void InternalGetData_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize)
  {
    GraphicsBuffer.InternalGetData_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
  }

  public static System.IntPtr GetNativeBufferPtr_Injected(System.IntPtr _unity_self)
  {
    return GraphicsBuffer.GetNativeBufferPtr_InjectedDelegateField(_unity_self);
  }

  public static void SetCounterValue_Injected(System.IntPtr _unity_self, uint counterValue)
  {
    GraphicsBuffer.SetCounterValue_InjectedDelegateField(_unity_self, counterValue);
  }

  public static void CopyCountCC_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountCC_InjectedDelegateField(src, dst, dstOffsetBytes);
  }

  public static void CopyCountGC_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountGC_InjectedDelegateField(src, dst, dstOffsetBytes);
  }

  public static void CopyCountCG_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountCG_InjectedDelegateField(src, dst, dstOffsetBytes);
  }

  public static void CopyCountGG_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
  {
    GraphicsBuffer.CopyCountGG_InjectedDelegateField(src, dst, dstOffsetBytes);
  }

  [Flags]
  public enum Target
  {
    Vertex = 1,
    Index = 2,
    CopySource = 4,
    CopyDestination = 8,
    Structured = 16, // 0x00000010
    Raw = 32, // 0x00000020
    Append = 64, // 0x00000040
    Counter = 128, // 0x00000080
    IndirectArguments = 256, // 0x00000100
    Constant = 512, // 0x00000200
  }

  [Flags]
  public enum UsageFlags
  {
    None = 0,
    LockBufferForWrite = 1,
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_GraphicsBuffer_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GraphicsBuffer_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<GraphicsBuffer.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsBuffer.BindingsMarshaller>.NativeClassPtr);
      GraphicsBuffer.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_GraphicsBuffer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer.BindingsMarshaller>.NativeClassPtr, 100665823);
      GraphicsBuffer.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer.BindingsMarshaller>.NativeClassPtr, 100665824 /*0x060009E0*/);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 430114, RefRangeEnd = 430125, XrefRangeStart = 430110, XrefRangeEnd = 430114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GraphicsBuffer ConvertToManaged(System.IntPtr ptr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &ptr
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_GraphicsBuffer_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GraphicsBuffer) null : Il2CppObjectPool.Get<GraphicsBuffer>(num3);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(GraphicsBuffer graphicsBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphicsBuffer)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GraphicsBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
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
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsBuffer.NativeMethodInfoPtr_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_UnlockBufferAfterWrite_Public_Void_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsBuffer.NativeMethodInfoPtr_UnlockBufferAfterWrite_Public_Void_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate GraphicsBuffer.Target get_target_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void get_bufferHandle_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void InternalSetData_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int managedBufferStartIndex,
    int graphicsBufferStartIndex,
    int count,
    int elemSize);

  private delegate void InternalGetData_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int managedBufferStartIndex,
    int computeBufferStartIndex,
    int count,
    int elemSize);

  private delegate System.IntPtr GetNativeBufferPtr_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void SetCounterValue_InjectedDelegate(System.IntPtr _unity_self, uint counterValue);

  private delegate void CopyCountCC_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

  private delegate void CopyCountGC_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

  private delegate void CopyCountCG_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

  private delegate void CopyCountGG_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);
}
