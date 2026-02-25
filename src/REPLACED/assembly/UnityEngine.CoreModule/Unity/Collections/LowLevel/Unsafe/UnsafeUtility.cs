// Decompiled with JetBrains decompiler
// Type: Unity.Collections.LowLevel.Unsafe.UnsafeUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.Collections.LowLevel.Unsafe;

public static class UnsafeUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_As_Internal_Static_T_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0;
  public const int kIsManaged = 1;
  public const int kIsNativeContainer = 2;
  private static readonly UnsafeUtility.GetFieldOffsetInStructDelegate GetFieldOffsetInStructDelegateField;
  private static readonly UnsafeUtility.GetFieldOffsetInClassDelegate GetFieldOffsetInClassDelegateField;
  private static readonly UnsafeUtility.PinSystemArrayAndGetAddressDelegate PinSystemArrayAndGetAddressDelegateField;
  private static readonly UnsafeUtility.PinSystemObjectAndGetAddressDelegate PinSystemObjectAndGetAddressDelegateField;
  private static readonly UnsafeUtility.ReleaseGCObjectDelegate ReleaseGCObjectDelegateField;
  private static readonly UnsafeUtility.CopyObjectAddressToPtrDelegate CopyObjectAddressToPtrDelegateField;
  private static readonly UnsafeUtility.CheckForLeaksDelegate CheckForLeaksDelegateField;
  private static readonly UnsafeUtility.ForgiveLeaksDelegate ForgiveLeaksDelegateField;
  private static readonly UnsafeUtility.GetLeakDetectionModeDelegate GetLeakDetectionModeDelegateField;
  private static readonly UnsafeUtility.SetLeakDetectionModeDelegate SetLeakDetectionModeDelegateField;
  private static readonly UnsafeUtility.MemCpyReplicateDelegate MemCpyReplicateDelegateField;
  private static readonly UnsafeUtility.MemSwapDelegate MemSwapDelegateField;
  private static readonly UnsafeUtility.MemCmpDelegate MemCmpDelegateField;
  private static readonly UnsafeUtility.IsUnmanagedDelegate IsUnmanagedDelegateField;
  private static readonly UnsafeUtility.IsValidNativeContainerElementTypeDelegate IsValidNativeContainerElementTypeDelegateField;
  private static readonly UnsafeUtility.GetScriptingTypeFlagsDelegate GetScriptingTypeFlagsDelegateField;
  private static readonly UnsafeUtility.LogError_InjectedDelegate LogError_InjectedDelegateField;

  static UnsafeUtility()
  {
    Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", nameof (UnsafeUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr);
    UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663581);
    UnsafeUtility.NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663582);
    UnsafeUtility.NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663583);
    UnsafeUtility.NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663584 /*0x06000120*/);
    UnsafeUtility.NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663585);
    UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663586);
    UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663587);
    UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663588);
    UnsafeUtility.NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663589);
    UnsafeUtility.NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663590);
    UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663591);
    UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663592);
    UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663593);
    UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663594);
    UnsafeUtility.NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663595);
    UnsafeUtility.NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663596);
    UnsafeUtility.NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663597);
    UnsafeUtility.NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663598);
    UnsafeUtility.NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663599);
    UnsafeUtility.NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663600 /*0x06000130*/);
    UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663601);
    UnsafeUtility.NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663602);
    UnsafeUtility.NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663603);
    UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663604);
    UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663605);
    UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663606);
    UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663607);
    UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663608);
    UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663609);
    UnsafeUtility.NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663610);
    UnsafeUtility.NativeMethodInfoPtr_As_Internal_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663611);
    UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663612);
    UnsafeUtility.NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663613);
    UnsafeUtility.NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663614);
    UnsafeUtility.NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663615);
    UnsafeUtility.GetFieldOffsetInStructDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInStructDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInStruct");
    UnsafeUtility.GetFieldOffsetInClassDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInClassDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInClass");
    UnsafeUtility.PinSystemArrayAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemArrayAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemArrayAndGetAddress");
    UnsafeUtility.PinSystemObjectAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemObjectAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemObjectAndGetAddress");
    UnsafeUtility.ReleaseGCObjectDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ReleaseGCObjectDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ReleaseGCObject");
    UnsafeUtility.CopyObjectAddressToPtrDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CopyObjectAddressToPtrDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CopyObjectAddressToPtr");
    UnsafeUtility.CheckForLeaksDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CheckForLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CheckForLeaks");
    UnsafeUtility.ForgiveLeaksDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ForgiveLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ForgiveLeaks");
    UnsafeUtility.GetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetLeakDetectionMode");
    UnsafeUtility.SetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.SetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SetLeakDetectionMode");
    UnsafeUtility.MemCpyReplicateDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCpyReplicateDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyReplicate");
    UnsafeUtility.MemSwapDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemSwapDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSwap");
    UnsafeUtility.MemCmpDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCmpDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCmp");
    UnsafeUtility.IsUnmanagedDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsUnmanagedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged");
    UnsafeUtility.IsValidNativeContainerElementTypeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsValidNativeContainerElementTypeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsValidNativeContainerElementType");
    UnsafeUtility.GetScriptingTypeFlagsDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetScriptingTypeFlagsDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetScriptingTypeFlags");
    UnsafeUtility.LogError_InjectedDelegateField = IL2CPP.ResolveICall<UnsafeUtility.LogError_InjectedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LogError_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414747, XrefRangeEnd = 414752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsBlittable<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_IsBlittable_Public_Static_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 414754, RefRangeEnd = 414758, XrefRangeStart = 414752, XrefRangeEnd = 414754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int LeakRecord(System.IntPtr handle, LeakCategory category, int callstacksToSkip)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &category;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &callstacksToSkip;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414760, RefRangeEnd = 414762, XrefRangeStart = 414758, XrefRangeEnd = 414760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int LeakErase(System.IntPtr handle, LeakCategory category)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &category;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414764, RefRangeEnd = 414766, XrefRangeStart = 414762, XrefRangeEnd = 414764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* MallocTracked(
    long size,
    int alignment,
    Allocator allocator,
    int callstacksToSkip)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alignment;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &callstacksToSkip;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return (void*) num2;
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414768, RefRangeEnd = 414770, XrefRangeStart = 414766, XrefRangeEnd = 414768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FreeTracked(void* memory, Allocator allocator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) memory;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 414772, RefRangeEnd = 414783, XrefRangeStart = 414770, XrefRangeEnd = 414772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* Malloc(long size, int alignment, Allocator allocator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alignment;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return (void*) num2;
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 414785, RefRangeEnd = 414800, XrefRangeStart = 414783, XrefRangeEnd = 414785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Free(void* memory, Allocator allocator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) memory;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(53)]
  [CachedScanResults(RefRangeStart = 414802, RefRangeEnd = 414855, XrefRangeStart = 414800, XrefRangeEnd = 414802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MemCpy(void* destination, void* source, long size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414857, RefRangeEnd = 414858, XrefRangeStart = 414855, XrefRangeEnd = 414857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MemCpyStride(
    void* destination,
    int destinationStride,
    void* source,
    int sourceStride,
    int elementSize,
    int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &destinationStride;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceStride;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &elementSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414860, RefRangeEnd = 414862, XrefRangeStart = 414858, XrefRangeEnd = 414860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MemMove(void* destination, void* source, long size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 414864, RefRangeEnd = 414873, XrefRangeStart = 414862, XrefRangeEnd = 414864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MemSet(void* destination, byte value, long size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 414875, RefRangeEnd = 414885, XrefRangeStart = 414873, XrefRangeEnd = 414875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MemClear(void* destination, long size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 414889, RefRangeEnd = 414892, XrefRangeStart = 414885, XrefRangeEnd = 414889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int SizeOf(Il2CppSystem.Type type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414894, RefRangeEnd = 414895, XrefRangeStart = 414892, XrefRangeEnd = 414894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsBlittable(Il2CppSystem.Type type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414895, XrefRangeEnd = 414896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsBlittableValueType(Il2CppSystem.Type t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 414915, RefRangeEnd = 414918, XrefRangeStart = 414896, XrefRangeEnd = 414915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetReasonForTypeNonBlittableImpl(Il2CppSystem.Type t, string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 414920, RefRangeEnd = 414927, XrefRangeStart = 414918, XrefRangeEnd = 414920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsArrayBlittable(Il2CppSystem.Array arr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arr)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414927, XrefRangeEnd = 414928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsGenericListBlittable<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_IsGenericListBlittable_Internal_Static_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414931, RefRangeEnd = 414933, XrefRangeStart = 414928, XrefRangeEnd = 414931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetReasonForArrayNonBlittable(Il2CppSystem.Array arr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arr)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414933, XrefRangeEnd = 414944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetReasonForGenericListNonBlittable<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_GetReasonForGenericListNonBlittable_Internal_Static_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 414945, RefRangeEnd = 414959, XrefRangeStart = 414944, XrefRangeEnd = 414945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int AlignOf<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414959, XrefRangeEnd = 414960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyPtrToStructure<T>(void* ptr, out T output) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ptr;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref output;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (typeof (T).IsValueType)
      return;
    ref T local2 = ref output;
    System.IntPtr num3 = zero;
    // ISSUE: variable of the null type
    __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num3, false, false);
    local2 = (T) valueGeneric;
  }

  [CallerCount(0)]
  public static unsafe void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ptr;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref output;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (typeof (T).IsValueType)
      return;
    ref T local2 = ref output;
    System.IntPtr num3 = zero;
    // ISSUE: variable of the null type
    __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num3, false, false);
    local2 = (T) valueGeneric;
  }

  [CallerCount(0)]
  public static unsafe T ReadArrayElement<T>(void* source, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  public static unsafe T ReadArrayElementWithStride<T>(void* source, int index, int stride)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  public static unsafe void WriteArrayElement<T>(void* destination, int index, T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(0)]
  public static unsafe void WriteArrayElementWithStride<T>(
    void* destination,
    int index,
    int stride,
    T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(1564)]
  [CachedScanResults(RefRangeStart = 106995, RefRangeEnd = 108559, XrefRangeStart = 106995, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* AddressOf<T>(ref T output) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) output);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref T local = ref output;
    System.IntPtr num3 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num3, false, false);
    local = (T) valueGeneric;
    return (void*) num2;
  }

  [CallerCount(0)]
  public static unsafe int SizeOf<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1564)]
  [CachedScanResults(RefRangeStart = 106995, RefRangeEnd = 108559, XrefRangeStart = 106995, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ref T As<U, T>(ref U from)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref U local = ref from;
    System.IntPtr num3 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<U>(num3, false, false);
    local = (U) valueGeneric;
    // ISSUE: cast to a reference type
    return (T&) num2;
  }

  [CallerCount(1564)]
  [CachedScanResults(RefRangeStart = 106995, RefRangeEnd = 108559, XrefRangeStart = 106995, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T As<T>(Il2CppSystem.Object from) where T : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_As_Internal_Static_T_Object_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(1564)]
  [CachedScanResults(RefRangeStart = 106995, RefRangeEnd = 108559, XrefRangeStart = 106995, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ref T AsRef<T>(void* ptr) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ptr
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    // ISSUE: cast to a reference type
    return (T&) num2;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414960, XrefRangeEnd = 414961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int EnumToInt<T>(T enumValue) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) enumValue;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref enumValue;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumValue);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref intValue;
    System.IntPtr num1;
    IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref T local = ref enumValue;
    System.IntPtr num2 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
    local = (T) valueGeneric;
  }

  [CallerCount(0)]
  public static unsafe bool EnumEquals<T>(T lhs, T rhs) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) lhs;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref lhs;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local3;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local4 = (object) rhs;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref rhs;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  public UnsafeUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static int GetFieldOffsetInStruct(FieldInfo field)
  {
    return UnsafeUtility.GetFieldOffsetInStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field));
  }

  public static int GetFieldOffsetInClass(FieldInfo field)
  {
    return UnsafeUtility.GetFieldOffsetInClassDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field));
  }

  public static int GetFieldOffset(FieldInfo field)
  {
    if (field.DeclaringType.IsValueType)
      return UnsafeUtility.GetFieldOffsetInStruct(field);
    return field.DeclaringType.IsClass ? UnsafeUtility.GetFieldOffsetInClass(field) : -1;
  }

  public static unsafe void* PinGCObjectAndGetAddress(Il2CppSystem.Object target, out ulong gcHandle)
  {
    return UnsafeUtility.PinSystemObjectAndGetAddress(target, out gcHandle);
  }

  public static unsafe void* PinGCArrayAndGetDataAddress(Il2CppSystem.Array target, out ulong gcHandle)
  {
    return UnsafeUtility.PinSystemArrayAndGetAddress((Il2CppSystem.Object) target, out gcHandle);
  }

  public static unsafe void* PinSystemArrayAndGetAddress(Il2CppSystem.Object target, out ulong gcHandle)
  {
    return (void*) UnsafeUtility.PinSystemArrayAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target), (System.IntPtr) ref gcHandle);
  }

  public static unsafe void* PinSystemObjectAndGetAddress(Il2CppSystem.Object target, out ulong gcHandle)
  {
    return (void*) UnsafeUtility.PinSystemObjectAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target), (System.IntPtr) ref gcHandle);
  }

  public static void ReleaseGCObject(ulong gcHandle)
  {
    UnsafeUtility.ReleaseGCObjectDelegateField(gcHandle);
  }

  public static unsafe void CopyObjectAddressToPtr(Il2CppSystem.Object target, void* dstPtr)
  {
    UnsafeUtility.CopyObjectAddressToPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target), (System.IntPtr) dstPtr);
  }

  public static int CheckForLeaks() => UnsafeUtility.CheckForLeaksDelegateField();

  public static int ForgiveLeaks() => UnsafeUtility.ForgiveLeaksDelegateField();

  public static NativeLeakDetectionMode GetLeakDetectionMode()
  {
    return UnsafeUtility.GetLeakDetectionModeDelegateField();
  }

  public static void SetLeakDetectionMode(NativeLeakDetectionMode value)
  {
    UnsafeUtility.SetLeakDetectionModeDelegateField(value);
  }

  public static bool IsValidAllocator(Allocator allocator) => allocator > Allocator.None;

  public static unsafe void MemCpyReplicate(void* destination, void* source, int size, int count)
  {
    UnsafeUtility.MemCpyReplicateDelegateField((System.IntPtr) destination, (System.IntPtr) source, size, count);
  }

  public static unsafe void MemSwap(void* ptr1, void* ptr2, long size)
  {
    UnsafeUtility.MemSwapDelegateField((System.IntPtr) ptr1, (System.IntPtr) ptr2, size);
  }

  public static unsafe int MemCmp(void* ptr1, void* ptr2, long size)
  {
    return UnsafeUtility.MemCmpDelegateField((System.IntPtr) ptr1, (System.IntPtr) ptr2, size);
  }

  public static bool IsUnmanaged(Il2CppSystem.Type type)
  {
    return UnsafeUtility.IsUnmanagedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type));
  }

  public static bool IsValidNativeContainerElementType(Il2CppSystem.Type type)
  {
    return UnsafeUtility.IsValidNativeContainerElementTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type));
  }

  public static int GetScriptingTypeFlags(Il2CppSystem.Type type)
  {
    return UnsafeUtility.GetScriptingTypeFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type));
  }

  public static unsafe void LogError(string msg, string filename, int linenumber)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(msg, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = msg.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = filename.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      int linenumber1 = linenumber;
      UnsafeUtility.LogError_Injected(ref local1, ref local2, linenumber1);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static string GetReasonForTypeNonBlittable(Il2CppSystem.Type t)
  {
    return UnsafeUtility.GetReasonForTypeNonBlittableImpl(t, t.Name);
  }

  public static string GetReasonForValueTypeNonBlittable<T>() where T : struct
  {
    Il2CppSystem.Type typeFromHandle = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
    return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
  }

  public static bool IsUnmanaged<T>()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static bool IsNativeContainerType<T>()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static bool IsValidNativeContainerElementType<T>()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppSystem.Span<byte> GetByteSpanFromArray(Il2CppSystem.Array array, int elementSize)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppSystem.Span<byte> GetByteSpanFromList<T>(List<T> list) where T : struct
  {
    return MemoryMarshal.AsBytes<T>(NoAllocHelpers.ExtractArrayFromList<T>(list).AsSpan<T>());
  }

  public static unsafe void CopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
  {
    UnsafeUtility.InternalCopyStructureToPtr<T>(ref input, ptr);
  }

  public static unsafe void InternalCopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
  {
    *(T*) ptr = input;
  }

  public static unsafe ref T ClassAsRef<T>(void* ptr) where T : class => ref (*(T*) ptr);

  public static unsafe ref T ArrayElementAsRef<T>(void* ptr, int index) where T : struct
  {
    // ISSUE: cast to a reference type
    return (T&) ((System.IntPtr) ptr + (System.IntPtr) ((long) index * (long) sizeof (T)));
  }

  public static ref T Add<T>(ref T source, int elementOffset) where T : struct, Il2CppSystem.ValueType
  {
    // ISSUE: cast to a reference type
    return (T&) ((System.IntPtr) ref source + sizeof (T) * elementOffset);
  }

  public static void LogError_Injected(
    ref ManagedSpanWrapper msg,
    ref ManagedSpanWrapper filename,
    int linenumber)
  {
    UnsafeUtility.LogError_InjectedDelegateField((System.IntPtr) ref msg, (System.IntPtr) ref filename, linenumber);
  }

  public sealed class AlignOfHelper<T> : Il2CppSystem.ValueType where T : new()
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_dummy;
    private static readonly System.IntPtr NativeFieldInfoPtr_data;

    static AlignOfHelper()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "AlignOfHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr);
      UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, nameof (dummy));
      UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, nameof (data));
    }

    public AlignOfHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AlignOfHelper()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr))
    {
    }

    public unsafe byte dummy
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy)) = value;
      }
    }

    public unsafe T data
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
        System.Type type = typeof (T);
        if (!type.IsValueType)
        {
          if (!string.Equals(type.FullName, "System.String"))
          {
            System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
            if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
            {
              System.IntPtr num2 = ptr;
              System.IntPtr num3 = IL2CPP.il2cpp_object_unbox(ptr);
              int num4 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num2), (uint&) System.IntPtr.Zero);
              __memcpy(num1, num3, num4);
            }
            else
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, ptr);
          }
          else
          {
            System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, il2Cpp);
          }
        }
        else
        {
          T obj = value;
          *(T*) num1 = obj;
        }
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_IsBlittable_Public_Static_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsGenericListBlittable_Internal_Static_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetReasonForGenericListNonBlittable_Internal_Static_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_As_Internal_Static_T_Object_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_As_Internal_Static_T_Object_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate int GetFieldOffsetInStructDelegate(System.IntPtr field);

  private delegate int GetFieldOffsetInClassDelegate(System.IntPtr field);

  private delegate System.IntPtr PinSystemArrayAndGetAddressDelegate(System.IntPtr target, [Out] System.IntPtr gcHandle);

  private delegate System.IntPtr PinSystemObjectAndGetAddressDelegate(
    System.IntPtr target,
    [Out] System.IntPtr gcHandle);

  private delegate void ReleaseGCObjectDelegate(ulong gcHandle);

  private delegate void CopyObjectAddressToPtrDelegate(System.IntPtr target, System.IntPtr dstPtr);

  private delegate int CheckForLeaksDelegate();

  private delegate int ForgiveLeaksDelegate();

  private delegate NativeLeakDetectionMode GetLeakDetectionModeDelegate();

  private delegate void SetLeakDetectionModeDelegate(NativeLeakDetectionMode value);

  private delegate void MemCpyReplicateDelegate(
    System.IntPtr destination,
    System.IntPtr source,
    int size,
    int count);

  private delegate void MemSwapDelegate(System.IntPtr ptr1, System.IntPtr ptr2, long size);

  private delegate int MemCmpDelegate(System.IntPtr ptr1, System.IntPtr ptr2, long size);

  private delegate bool IsUnmanagedDelegate(System.IntPtr type);

  private delegate bool IsValidNativeContainerElementTypeDelegate(System.IntPtr type);

  private delegate int GetScriptingTypeFlagsDelegate(System.IntPtr type);

  private delegate void LogError_InjectedDelegate(System.IntPtr msg, System.IntPtr filename, int linenumber);
}
